using Estate.Data;
using Microsoft.AspNetCore.Mvc;

namespace Estate.ViewComponents.Home
{
    public class UpdateDatePartial : ViewComponent
    {
        ApplicationDbContext _context;

        public UpdateDatePartial(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke() 
        {
            var value = _context.UpdateDates.OrderByDescending(x => x.Id).FirstOrDefault();
            return View(value); 
        }
    }
}
