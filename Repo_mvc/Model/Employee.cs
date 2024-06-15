﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_mvc.Model
{
    [Table("Employees")]
     public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public int Age { get; set; }
    }

   
   
}
