using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressYourLuck.Controllers
{
    public class AuditController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var activeAuditTypeId = HttpContext.Session.GetString("activeAuditTypeID");

            if (string.IsNullOrEmpty(activeAuditTypeId))
            {
                activeAuditTypeId = "";
            }

            return RedirectToAction("List", new { activeAuditTypeId = activeAuditTypeId });
        }

    }
}
