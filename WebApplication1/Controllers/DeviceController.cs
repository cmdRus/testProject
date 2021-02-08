using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class DeviceController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Device> d = ApiClient.GetRequest<List<Device>>("Home");
            if (d == null)
            {
                return View();
            }
            else
            {
                return View(d);
            }
        }
    }
}
