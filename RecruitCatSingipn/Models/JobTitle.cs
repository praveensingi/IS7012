using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SkillsRequired { get; set; }

        public Decimal minSalary { get; set; }

        public Decimal maxSalary { get; set; }

        public List<Candidate>? Candidates { get; set; }

    }
}
