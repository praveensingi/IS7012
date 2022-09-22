using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatSingipn.Data;
using RecruitCatSingipn.Models;

namespace RecruitCatSingipn.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatSingipn.Data.RecruitCatSingipnContext _context;

        public CreateModel(RecruitCatSingipn.Data.RecruitCatSingipnContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
