
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKho.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return PartialView();
        }

        public ActionResult IndexKhoHang()
        {
            return PartialView();
        }

        public ActionResult Index2()
        {
            return PartialView();
        }

        public ActionResult LoginUser()
        {
            return View();
        }

    }
}