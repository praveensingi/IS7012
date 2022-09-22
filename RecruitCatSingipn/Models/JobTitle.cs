using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Required Skills")]
        public string SkillsRequired { get; set; }

        [Required]
        [Range(0, (double)(decimal.MaxValue))]
        [DisplayName("Minimum Salary")]
        public Decimal minSalary { get; set; }

        [Required]
        [Range(0, (double)(decimal.MaxValue))]
        [DisplayName("Maximum Salary")]
        public Decimal maxSalary { get; set; }

        public List<Candidate>? Candidates { get; set; }

    }
}
