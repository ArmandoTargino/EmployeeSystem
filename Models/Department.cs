using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEF.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(300)]
        public string DepartmentName { get; set; }
    }
}
