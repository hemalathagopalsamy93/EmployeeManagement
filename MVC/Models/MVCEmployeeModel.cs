using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MVCEmployeeModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }
        public string Designation { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}