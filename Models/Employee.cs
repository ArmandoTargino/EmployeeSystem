using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEF.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmployeeFirstName { get; set; }

        [Required]
        [MaxLength(200)]
        public string EmployeeLastName { get; set; }

        [MaxLength(100)]
        public string EmployeeMiddleName { get; set; }

        [Required]
        [MaxLength(300)]
        public string Department { get; set; }

        [Required]
        [MaxLength(10)]
        public string DateOfJoining { get; set; }

        [Required]
        [MaxLength(100)]
        public string StreetAddress { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string State { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [Required]
        [MaxLength(8)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(300)]
        public string Email { get; set; }

        [Required]
        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(13)]
        public string Salary { get; set; }
        [Required]
        [MaxLength(300)] 
        public string PhotoFileName { get; set; }

    }

   

}
