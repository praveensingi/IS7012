using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(60)]
        public string LastName { get; set; }

        [Required]
        [Range(0, (double)(decimal.MaxValue))]
        [DisplayName("Target Salary")]
        public Decimal TargetSalary { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}-[0-9]{3}-[0-9]{4}$")]
        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }

        public string? Gender { get; set; }

        public bool Resigned { get; set; }

        [Required]
        [StringLength(255)]
        public string Skills { get; set; }

        [DisplayName("Birth Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int? IndustryId { get; set; }

        public Company Company { get; set; }

        [DisplayName("Company")]
        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        public int? JobTitleId { get; set; }

    }
}
