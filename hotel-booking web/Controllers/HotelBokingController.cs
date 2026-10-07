using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hotel_booking_web.Controllers
{
    public class HotelBokingController : Controller
    {
        // GET: HotelBoking
        public ActionResult Index()
        {
            return View();
        }
    }
}