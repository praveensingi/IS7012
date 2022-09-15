using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSingipn.Models
{
    public class Industry
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Sector { get; set; }

        public int NoOfCompaniesAssociated { get; set; }

        public List<Candidate>? Candidates { get; set; }

        public List<Company>? Companies { get; set; }
    }
}
