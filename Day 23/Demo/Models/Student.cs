using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Day23_Demo.Models
{
    public class Student
    {
       [Required]
        [Display(Name="Student ID")]
        public int Id { get; set; }

        [Required(ErrorMessage="Name is Compulsory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is Compulsory")]
        public string Address { get; set; }


    }
}