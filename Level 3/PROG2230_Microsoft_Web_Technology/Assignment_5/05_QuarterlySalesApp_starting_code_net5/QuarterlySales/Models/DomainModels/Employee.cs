using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace QuarterlySales.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a birth date.")]
        [PastDate(ErrorMessage = "Birth date must be a valid date that's in the past.")]
        [Remote("CheckEmployee", "Validation", AdditionalFields = "Firstname, Lastname")]
        [Display(Name = "Birth Date")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Please enter a hire date.")]
        [PastDate(ErrorMessage = "Hire date must be a valid date that's in the past.")]
        //[GreaterThan(FieldName = "DOB", ErrorMessage = "Hire date must be later than birth date.")]
        [GreaterThan("1/1/1995", ErrorMessage = "Hire date can't be before company was formed in 1995.")]
        [Display(Name = "Hire Date")]
        public DateTime? DateOfHire { get; set; }

        [GreaterThan(0, ErrorMessage = "Please select a manager.")]
        [Remote("CheckManager", "Validation", AdditionalFields = "Firstname, Lastname, DOB")]
        [Display(Name = "Manager")]
        public int ManagerId { get; set; }

        public string Fullname => $"{Firstname} {Lastname}";
    }
}
