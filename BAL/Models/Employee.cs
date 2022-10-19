﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? Empgender { get; set; }

        public DateTime EmpDob { get; set; }

        public string? EmpEmail { get; set; }

        public string? EmpDep { get; set; }


    }
}
