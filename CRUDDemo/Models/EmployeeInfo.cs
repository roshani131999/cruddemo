using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDemo.Models
{
    public class EmployeeInfo
    {
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage ="Enter Your Name!!!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Select your Gender First")]
        public string Gender { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Enter your company name")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Enter Your Department")]
        public string Department { get; set; }
    }
}
