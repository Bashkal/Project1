using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NetCoreWebApplication.Filters
{
    public class UserControl : ActionFilterAttribute
    {
        override public void OnActionExecuting(ActionExecutingContext context)
        {
           var userGuide = context.HttpContext.Session.GetString("Date");
           var userCookie = context.HttpContext.Request.Cookies["Department"];
            if (string.IsNullOrEmpty(userGuide) && string.IsNullOrEmpty(userCookie))
            {
                context.Result = new RedirectToActionResult("Privacy", "Home", null);
                return;
            }

            base.OnActionExecuting(context);
        }
    }
}
