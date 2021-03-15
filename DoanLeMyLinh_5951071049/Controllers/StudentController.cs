using DoanLeMyLinh_5951071049.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoanLeMyLinh_5951071049.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            var studentList = new List<Student>();
            //  for (int i = 0; i < 10; i++)
            //{
            var student = new Student
            {
                Class = $"CQ.59.CNTT",
                Name = $"Doan Le My Linh",
                ID = $"5951071049",
                Address = $"Ho Chi Minh city",
                DateTime = DateTime.Now.ToUniversalTime()
            };
            studentList.Add(student);
            //  }

            return studentList;
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
