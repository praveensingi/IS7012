using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Decimal TargetSalary { get; set; }

        public string Address { get; set; }

        public string MobileNumber { get; set; }

        public string? Gender { get; set; }

        public bool Resigned { get; set; }

        public string Skills { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? StartDate { get; set; }

        public int? IndustryId { get; set; }

        public int? CompanyId { get; set; }

        public int? JobTitleId { get; set; }

    }
}
