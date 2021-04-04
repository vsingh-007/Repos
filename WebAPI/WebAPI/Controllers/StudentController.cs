using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        static List<Student> _studentList = null;
        void Initialize()
        {
            _studentList = new List<Student>()
           {
               new Student() { StudentId=1, Name="Ajay" , Batch="B001", Marks=89, DateOfBirth=Convert.ToDateTime("12/12/2020")},

               new Student() { StudentId=2, Name="Deepak" , Batch="B002", Marks=78, DateOfBirth=Convert.ToDateTime("10/06/2020")},
           };

        }

        public StudentController()
        {
            if (_studentList == null)
            {
                Initialize();
            }
        }

        // GET: api/Student
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK,_studentList);
        }

        // GET: api/Student/5
        public HttpResponseMessage Get(int id)
        {
            Student student = _studentList.Where(x => x.StudentId == id).FirstOrDefault();
            if (student != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, student);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student Not Found");
            }
        }

        // POST: api/Student
        public HttpResponseMessage Post(Student student)
        {
            if (student != null)
            {
                _studentList.Add(student);
            }
            return Request.CreateResponse(HttpStatusCode.Created);

        }


        // PUT: api/Student/5
        public HttpResponseMessage Put(int id, Student objStudent)
        {
            Student student = _studentList.Where(x => x.StudentId == id).FirstOrDefault();

            if (student==null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Student Not Found");
            }
            else
            {
                if (student != null)
                {
                    foreach (Student temp in _studentList)
                    {
                        if (temp.StudentId == id)
                        {
                            temp.Name = objStudent.Name;
                            temp.DateOfBirth = objStudent.DateOfBirth;
                            temp.Batch = objStudent.Batch;
                            temp.Marks = objStudent.Marks;
                        }
                    }
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Modified");
            }
            
        }

        // DELETE: api/Student/5
        public HttpResponseMessage Delete(int id)
        {
            Student student = _studentList.Where(x => x.StudentId == id).FirstOrDefault();

            if (student == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "STudent Not found");

            }
            else
            {
                if (student != null)
                {
                    _studentList.Remove(student);
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }

        }
    }
}
