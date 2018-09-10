﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiApp.Model
{
    public class Student
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
