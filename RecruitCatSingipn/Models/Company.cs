using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PositionName { get; set; }

        public decimal MinimumSalary { get; set; }

        public decimal MaximumSalary { get; set; }

        public Decimal Revenue { get; set; }

        public DateTime? StartDate { get; set; }

        public string Location { get; set; }

        public int IndustryId { get; set; }

        public int? JobTitleId { get; set; }

        public List<Candidate>? Candidates { get; set; }

    }
}
