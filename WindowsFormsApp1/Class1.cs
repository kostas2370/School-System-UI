﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    class parser
    {
        public const string url = "http://127.0.0.1:8000";
        private static String username, password;
        private static readonly HttpClient client = new HttpClient();
        private static string auth;
        private static int role;
        private Dictionary<string, string> login;



        //Get the auth token for the user

        async public Task<String> getToken(string username, string password)
        {
            // we check if server is up
            if (await check_server() == false)
            {

                return "down";
            }
            login = new Dictionary<string, string>
            {
                {"username",username },
                {"password",password }
            };

            //Request the data
            var content = new FormUrlEncodedContent(login);
            var response = await client.PostAsync($"{url}/api/token/", content);
            var xd = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                auth = JsonConvert.DeserializeObject<Token>(xd).access;
                //adding the authenitication header to our client header
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", auth);
                return auth;

            }
            else
            {
                return null;

            }

        }

        // a fucnction to see if the server is up .
        async public static Task<bool> check_server()
        {
            try
            {
                var checkingResponse = await client.GetAsync(url);
                return true;
            }
            catch
            {
                return false;
            }

        }

        /*A function to register the user 
         it returns true if user got registered
         it returns false if user registration failed 
         
         */
        async public Task<bool> registeruser(string username, string password)
        {


            Dictionary<string, string> user_register = new Dictionary<string, string>
    {
        {"username",username },
        {"password",password },

    };

            var content = new FormUrlEncodedContent(user_register);



            var postreg = await client.PostAsync("http://127.0.0.1:8000/api/register/", content);
            if (postreg.IsSuccessStatusCode)
            {
                return true;
            }




            return false;


        }

        /*
         A function that gets the role of the user
        it returns a number between 1 - 4 
        1 : School manager
        2 : Teacher
        3 : Student
        4 : No role 
        
        it returns 0 if the registration failed .
         
         
         */
        async public static Task<int> getrole()
        {
            var req = await client.GetAsync($"{url}/api/getrole/");

            if (req.IsSuccessStatusCode)
            {
                var rol = await req.Content.ReadAsStringAsync();
                return Int16.Parse(JsonConvert.DeserializeObject<Role>(rol).role.ToString());
            }
            return 0;


        }

        /* 
         A function to register the Teachers

        It returns true if teacher was registered succesfully
        False if teacher is not registered 
         */
        async public Task<bool> registerTeacher(string first_name, string last_name, string email, string phone)
        {

            Dictionary<string, string> registerform = new Dictionary<string, string> {
                {"first_name",first_name},
                {"last_name",last_name},
                {"phone",phone},
                {"email",email},


            };


            var content = new FormUrlEncodedContent(registerform);
            var x = await client.PostAsync($"{url}/api/teacher/", content);

            if (x.IsSuccessStatusCode)
            {
                return true;
            }

            return false;


        }

        // This function checks if auth exists !
        public static bool check_if_online()
        {
            if (auth != null)
            {
                return true;

            }
            return false;

        }

        // This function check if the email is valid .
        public static bool check_if_valid_mail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;


            }


        }
        /* 
         
         This fucntion returns the classrooms
         */
        async public Task<List<Classroom>> getClassrooms(String id = null, string classname = null, string classnumber = null)
        {
            string req_url;
            if (!(id is null))//ID != ""
            {
                req_url = $"{url}/api/classroom/?id={id}";
            }
            else if (!(classname is null) && !(classnumber is null))
            {
                req_url = $"{url}/api/classroom/?classname={classname}&class_number={classnumber}";

            }
            else if (!(classname is null))
            {
                req_url = $"{url}/api/classroom/?classname={classname}";
            }
            else
            {

                req_url = $"{url}/api/classroom/";
            }



            var req = await client.GetAsync(req_url);
            if (req.IsSuccessStatusCode)
            {
                var rol = await req.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Classroom>>(rol);
            }
            return null;
        }

        // This function register Students .
        async public Task<bool> addStudent(string first, string last, string email, string phone, int class_id, string filename = null)
        {

            using (var multipartFormContent = new MultipartFormDataContent())
            {

                multipartFormContent.Add(new StringContent(first), name: "first_name");
                multipartFormContent.Add(new StringContent(last), name: "last_name");
                multipartFormContent.Add(new StringContent(email), name: "email");
                multipartFormContent.Add(new StringContent(phone), name: "phone");
                multipartFormContent.Add(new StringContent(class_id.ToString()), name: "classroom");

                if (filename != null)
                {
                    var fileStreamContent = new StreamContent(File.OpenRead(filename));
                    fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                    multipartFormContent.Add(fileStreamContent, name: "photo", fileName: filename);
                }


                var j = await client.PostAsync($"{url}/api/student/", multipartFormContent);


                if (j.IsSuccessStatusCode)

                {
                    return true;

                }
                return false;




            }
        }
        //A function that return a list with students 
        async public Task<List<Students>> getStudents()
        {

            string req_url = $"{url}/api/student/";

            var response = await client.GetAsync(req_url);

            if (response.IsSuccessStatusCode)
            {

                var rol = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Students>>(rol);
            }



            return null;
        }

        // it resets the auth
        public static void logout()
        {
            client.DefaultRequestHeaders.Authorization = null;
            auth = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();




        }
        async public Task<List<Grades>> GetGrades(string classroom = null)
        {

            string req_url;
            if (classroom != null)
            {
                req_url = $"{url}/api/grade/?classroom={classroom}";
            }
            else
            {
                req_url = $"{url}/api/grade/";
            }

            var response = await client.GetAsync(req_url);

            if (response.IsSuccessStatusCode)
            {

                var rol = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Grades>>(rol);
            }
            return null;

        }
        async public Task<List<Subjects>> getSubjects(int id)
        {
            string req_url = $"{url}/api/subject/?subject_id={id}";
            var response = await client.GetAsync(req_url);

            if (response.IsSuccessStatusCode)
            {
                var rol = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Subjects>>(rol);


            }
            return null;
        }

        async public Task<List<Teachers>> getTeachers(int id)
        {
            string req_url = $"{url}/api/teacher/?teacher_id={id}";
            var response = await client.GetAsync(req_url);
            if (response.IsSuccessStatusCode)
            {

                var rol = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Teachers>>(rol);
            }
            return null;


        }
        async public Task<Students> updateStudent(string first_Name, string last_name, string email, string phone, string classe, string apousies, string photo = null)
        {
            string req_url = $"{url}/api/student/update/";

            using (var multipartFormContent = new MultipartFormDataContent())
            {

                multipartFormContent.Add(new StringContent(first_Name), name: "first_name");
                multipartFormContent.Add(new StringContent(last_name), name: "last_name");
                multipartFormContent.Add(new StringContent(phone), name: "phone");
                multipartFormContent.Add(new StringContent(email), name: "email");
                multipartFormContent.Add(new StringContent(apousies.ToString()), name: "apousies");
                multipartFormContent.Add(new StringContent(classe.ToString()), name: "classroom");
                if (photo != null)
                {
                    var fileStreamContent = new StreamContent(File.OpenRead(photo));
                    fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");
                    multipartFormContent.Add(fileStreamContent, name: "photo", fileName: photo);
                }

                var j = await client.PutAsync(req_url, multipartFormContent);
                if (j.IsSuccessStatusCode)
                {
                    var rol = await j.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Students>(rol);

                }
                return null;

            }





        }
        async public Task<List<assigments>> getAssigments(string id=null, string classroom = null,string subject=null)
        {

            string req_url;
            if (!(classroom is null))
            {
                 req_url = $"{url}/api/assigment/?classroom={classroom}";

            }else if (!(id is null))
            {
                 req_url = $"{url}/api/assigment/?id={id}";

            }else if (!(subject is null))
            {
                 req_url = $"{url}/api/assigment/?subject={subject}";

            }
            else
            {
                return null;
            }

            var response = await client.GetAsync(req_url);
            if (response.IsSuccessStatusCode)
            {
                var rol = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<assigments>>(rol);
            }
            return null;

        }
        
        async public Task<List<StudentAssigments>> GetStudentAssigments(int role,string student=null,string assigment=null)
        {
            string req_url;
            if(role == 3)
            {
                   req_url = $"{url}/api/student/assigment/?assigment={assigment}";  
             
            }
            else
            {
                req_url = $"{url}student/assigment/";
            }
            var response = await client.GetAsync(req_url);
            if (response.IsSuccessStatusCode)
            {
                var rol = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<StudentAssigments>>(rol);
            }
            return null;


        }
        async public Task<bool> addStudentAssigment(string student, string assignment, string file)
        {
            string req_url = $"{url}/api/student/assigment/";

            using (var multipartFormContent = new MultipartFormDataContent())
            {

                multipartFormContent.Add(new StringContent(student), name: "student");
                multipartFormContent.Add(new StringContent(assignment), name: "assignment");
                var fileStreamContent = new StreamContent(File.OpenRead(file));
                multipartFormContent.Add(fileStreamContent, name: "file", fileName: file);
                var j = await client.PostAsync(req_url, multipartFormContent);

                if (j.IsSuccessStatusCode)
                {
                    return true;
                }
            }

          

                return false;
        }


    } 

    //json formaters classes : 
    class Token
    {
        public string refresh;
        public string access;
    }

    class Role
    {
        public int role;
    }
    public class Classroom
    {
        public string classname;
        public int class_number;
        public int maximum;
        public int students_in;
        public int id;
    }
    public class Students
    {
        public string user;
        public string first_Name;
        public string last_Name;
        public string classroom;
        public string phone;
        public string student_id;
        public string email;
        public string created;
        public string photo;
        public string apouseies;

    }
    public class Grades
    {
        public string student;
        public string subject_name;
        public string teacher;
        public string classroom;
        public string grade;
    }
    public class Subjects
    {
        public string onoma;
        public int teacher;
        public int classroom;
        public int subject_id;

    }
    public class Teachers
    {
        public int user;
        public string first_name;
        public string last_name;
        public string phone;
        public int teacher_id;
        public string email;
        public string created;
    }
   public class assigments
    {
        public int id;
        public string pdf_question;
        public string created;
        public string deadline;
        public string title;
        public string question;
        public int Subject;
        public int classroom;
        
      
       



    }
   public class StudentAssigments
    {
        public int student;
        public int assigment;
        public string file;
        public string score;
        public int id;
    }
}


