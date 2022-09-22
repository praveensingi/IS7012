using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class Industry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(60)]
        public string Sector { get; set; }

        [Required]
        [Range(0, 5000)]
        [DisplayName("Associated Companies")]
        public int NoOfCompaniesAssociated { get; set; }

        public List<Candidate>? Candidates { get; set; }

        public List<Company>? Companies { get; set; }
    }
}
