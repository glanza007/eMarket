﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMarket.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }
        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;
    }
}
