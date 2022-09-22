using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [DisplayName("Position Name")]
        [Required]
        [StringLength(60)]
        public string PositionName { get; set; }

        [DisplayName("Minimum Salary")]
        [Required]
        [Range(0, (double)decimal.MaxValue)]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Required]
        [Range(0, (double)decimal.MaxValue)]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Revenue")]
        [Required]
        [Range((double)decimal.MinValue, (double)decimal.MaxValue)]
        public Decimal Revenue { get; set; }

        [DisplayName("Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [StringLength(255)]
        public string Location { get; set; }

        public Industry Industry { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }

        public JobTitle JobTitle { get; set; }

        [DisplayName("JobTitle")]
        public int? JobTitleId { get; set; }

        public List<Candidate>? Candidates { get; set; }

    }
}
