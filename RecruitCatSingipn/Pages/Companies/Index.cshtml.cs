using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSingipn.Data;
using RecruitCatSingipn.Models;

namespace RecruitCatSingipn.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatSingipn.Data.RecruitCatSingipnContext _context;

        public IndexModel(RecruitCatSingipn.Data.RecruitCatSingipnContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
