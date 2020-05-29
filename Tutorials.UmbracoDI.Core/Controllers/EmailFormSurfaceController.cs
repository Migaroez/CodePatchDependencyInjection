using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using Tutorials.UmbracoDI.Models;
using Umbraco.Web.Mvc;

namespace Tutorials.UmbracoDI.Core.Controllers
{
    public class EmailFormSurfaceController : SurfaceController
    {
        // Important to attribute your child action with ChildActionOnly
        // otherwise the action will become publicly routable (i.e. have
        // a publicly available Url)
        [ChildActionOnly]
        public ActionResult RenderForm()
        {
            var model = new EmailFormModel();
            
            return PartialView("EmailForm", model);
        }

        [HttpPost]
        public ActionResult SubmitForm(EmailFormModel model)
        {
            TempData["EmailForm"] = null;
            // model not valid, do not save, but return current Umbraco page
            if (!ModelState.IsValid)
            {
                // Perhaps you might want to add a custom message to the ViewBag
                // which will be available on the View when it renders (since we're not
                // redirecting)
                return CurrentUmbracoPage();
            }

            // Add a message in TempData which will be available
            // in the View after the redirect
            TempData["EmailForm"] = "Your form was successfully submitted at " + DateTime.Now;

            // redirect to current page to clear the form
            return RedirectToCurrentUmbracoPage();
        }
    }
}
