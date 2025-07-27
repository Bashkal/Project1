using Microsoft.AspNetCore.Mvc;
namespace NetCoreWebApplication.ViewComponents
{
    public class Categories : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
