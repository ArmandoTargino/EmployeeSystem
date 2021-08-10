using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEF.Models
{
    public class Vacation
    {

        public int VacationId { get; set; }

        public int EmployeeEmployeeId { get; set; }

        public string EmployeeEmployeeLastName { get; set; }

        [Required]
        public int VacationDaysAvailable { get; set; }

        [Required]
        public int VacationInitialDate { get; set; }

        [Required]
        public int VacationEndDate { get; set; }

        [Required]
        public bool IsOnVacation { get; set; }

    }
}
