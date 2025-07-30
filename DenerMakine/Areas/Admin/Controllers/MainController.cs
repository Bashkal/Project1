using DenerMakine.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DenerMakine.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MainController : Controller
    {
        DataBaseContext _context;
        public MainController(DataBaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DataBaseContext context = new DataBaseContext();
            return View(context);
        }
        public FileStreamResult FileDown(int id)
        {
            var guide = _context.Guides.Find(id);
            if (guide == null || string.IsNullOrEmpty(guide.File))
            {
                throw new FileNotFoundException("Kılavuz dosyası bulunamadı.");
            }
            else
            {
                var extension = Path.GetExtension(guide.File);
                var stream = new FileStream("wwwroot" + guide.File, FileMode.Open);
                return new FileStreamResult(stream, "application/" + extension) { FileDownloadName = Path.Combine(guide.Name, guide.FileType) };
            }
        }
    }
}
