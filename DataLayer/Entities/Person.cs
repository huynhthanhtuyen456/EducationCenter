using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Enums;
using DataLayer.Entities.Roles;

namespace DataLayer
{
    public class Person : BaseModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "FirstName must be between 1 and 50 characters")]
        public string ?FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "LastName is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "LastName must be between 1 and 50 characters")]
        public string ?LastName { get; set; }

        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "DateOfBirth is required")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is required")]
        public GenderEnum Gender { get; set; }

        [DisplayName("Age")]
        public int Age { get; set; }

        [Phone(ErrorMessage = "Invalid Telephone")]
        public string ?Telephone { get; set; }

        [DisplayName("Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required(ErrorMessage = "Email is required")]
        public string ?Email { get; set; }

        public required int RoleId { get; set; }
        public required virtual Role Role { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            int currentYear = DateTime.Now.Year;

            int yearOfBirth = dateOfBirth.Year;
            age = currentYear - yearOfBirth;
            if (age < 0) { age = 0; }
            return age;
        }
    }
}
