using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSingipn.Models;

namespace RecruitCatSingipn.Data
{
    public class RecruitCatSingipnContext : DbContext
    {
        public RecruitCatSingipnContext (DbContextOptions<RecruitCatSingipnContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSingipn.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatSingipn.Models.Company> Company { get; set; }

        public DbSet<RecruitCatSingipn.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatSingipn.Models.JobTitle> JobTitle { get; set; }
    }
}
