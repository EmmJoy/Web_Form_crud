using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using assignment.Data;
using assignment.Joy_Model;

namespace assignment.Pages.users
{
    public class DetailsModel : PageModel
    {
        private readonly assignment.Data.assignmentContext _context;

        public DetailsModel(assignment.Data.assignmentContext context)
        {
            _context = context;
        }

        public user user { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.user.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                user = user;
            }
            return Page();
        }
    }
}
