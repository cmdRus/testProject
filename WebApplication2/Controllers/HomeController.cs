using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public List<Device> GetData()
        {
            using(var db = new DeviceContext())
            {
                List<Device> devices = db.Devices.ToList();
                
                if(devices == null)
                {
                    return null;
                }
                else
                {
                    return devices;
                }
            }
        }

        [HttpPost]
        public void PostData(Device device_)
        {
            if (device_ is null)
            {
                throw new ArgumentNullException(nameof(device_));
            }
            else
            {
                using (var db = new DeviceContext())
                {
                    db.Add(device_);
                    db.SaveChanges();
                }
            }
        }
    }
}
