using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CRUDStudent.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required (ErrorMessage ="Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required (ErrorMessage = "the Number Must be 11 Numbers")]
        public int Mobile { get; set; }


    }
}