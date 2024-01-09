using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PVA_zapoctovy_ukol_AIK2_Daniel_Hašek.Data;
using PVA_zapoctovy_ukol_AIK2_Daniel_Hašek.Models;

namespace PVA_zapoctovy_ukol_AIK2_Daniel_Hašek.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _dbContext;

        [BindProperty]
        public Credit Credit { get; set; } = new Credit();

        public IndexModel(ILogger<IndexModel> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Credit.Created = DateTime.Now;                    

            _dbContext.Credits.Add(Credit);
            await _dbContext.SaveChangesAsync();

            Credit = new Credit();

            ModelState.Clear();

            return Page();
        }
    }
}
