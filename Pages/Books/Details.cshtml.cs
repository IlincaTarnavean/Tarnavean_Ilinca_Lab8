using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tarnavean_Ilinca_Lab8.Data;
using Tarnavean_Ilinca_Lab8.Models;

namespace Tarnavean_Ilinca_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Tarnavean_Ilinca_Lab8.Data.Tarnavean_Ilinca_Lab8Context _context;

        public DetailsModel(Tarnavean_Ilinca_Lab8.Data.Tarnavean_Ilinca_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
