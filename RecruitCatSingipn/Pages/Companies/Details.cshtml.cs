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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSingipn.Data.RecruitCatSingipnContext _context;

        public DetailsModel(RecruitCatSingipn.Data.RecruitCatSingipnContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                .Include(c => c.Industry)
                .Include(c => c.Candidates)
                .Include(c => c.JobTitle).FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
