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
    public class IndexModel : PageModel
    {
        private readonly assignment.Data.assignmentContext _context;

        public IndexModel(assignment.Data.assignmentContext context)
        {
            _context = context;
        }

        public IList<user> user { get;set; } = default!;

        public async Task OnGetAsync()
        {
            user = await _context.user.ToListAsync();
        }
    }
}
