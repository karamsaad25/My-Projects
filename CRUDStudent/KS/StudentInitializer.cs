using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUDStudent.Models;

namespace CRUDStudent.KS
{
    public class StudentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            var Students = new List<Student>
            {
                new Student { FirstName = "Karam" , LastName = "Saad" , Email= "KaramSaad@gmail.com" , Mobile = 01154503757, },
                new Student { FirstName = "Karem" , LastName = "Saed" , Email= "KaremSaed@gmail.com" , Mobile = 01154514657, },
                new Student { FirstName = "Nada" , LastName = "Ashraf" , Email= "NadaAshraf@gmail.com" , Mobile = 01112332140, },
                new Student { FirstName = "Li" , LastName = "Son" , Email= "LiSon@gmail.com" , Mobile = 01222300128, },
                new Student { FirstName = "Lenda" , LastName = "Ali" , Email= "LendAli@gmail.com" , Mobile = 01005146123, },
                new Student { FirstName = "Ahmed" , LastName = "Saad" , Email= "AhmedSaad@gmail.com" , Mobile = 01009320312, },

            };
            Students.ForEach(x => context.Students.Add(x));
            context.SaveChanges();

        }
    }
}