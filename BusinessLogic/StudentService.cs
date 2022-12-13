using System.Collections.Generic;
using System.Linq;
using WPFDB.Models;
using WPFDB.Context;

namespace WPFDB.BusinessLogic
{
    public class StudentService
    {
        ApplicationContext applicationContext;
        public StudentService()
        {
            applicationContext = new ApplicationContext();
        }
        public IEnumerable<Students> Get()
        {
            return applicationContext.Students.ToList();
        }
        public void Add(Students student)
        {
            applicationContext.Students.Add(student);
            applicationContext.SaveChanges();
        }
        public void Delete(Students student)
        {
            applicationContext.Students.Remove(student);
            applicationContext.SaveChanges();
        }
        public void Update(Students student)
        {
            applicationContext.Students.Update(student);
            applicationContext.SaveChanges();
        }
    }
}