using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassAPI.Models; 

namespace ClassAPI.Controllers
{
    public class StudentsController : ApiController
    {
        private static IList<Student> iosStudents = new List<Student>
        {
            new Student 
            { 
                Id = 1, FullName = "Basar Akyelli", PictureFileName = "basar"
            },
              new Student
            {
                Id = 2, FullName = "Dasmer Singh", PictureFileName = "das"
            },
            new Student
            {
                Id = 3, FullName = "Dulio Denis", PictureFileName = "dulio"
            },
            new Student
            {
                Id = 4, FullName = "Sunayna Jain", PictureFileName = "sunayna"
            },
            new Student
            {
                Id = 5, FullName = "Al Tyus", PictureFileName = "al"
            },
            new Student
            {
                Id = 6, FullName = "James Lin", PictureFileName = "james"
            },
        };

        // GET api/values
        public IEnumerable<Student> Get()
        {
            return iosStudents;
        }

        // GET api/values/5
        public Student Get(int id)
        {
            return iosStudents.First(s => s.Id == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}