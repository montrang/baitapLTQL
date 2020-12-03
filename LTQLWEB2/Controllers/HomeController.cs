using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using LTQLWEB2.Models;

namespace LTQLWEB2.Controllers
{
    public class HomeController : Controller
    {
        DBConnect db = new DBConnect();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // 
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(KHACHHANG kh)
        {
           if(ModelState.IsValid)
            {
                // Kiểm tra trong database xem đã có Email này hay chưa
                var checkEmail = db.KHACHHANGs.FirstOrDefault(m => m.Email == kh.Email);
                if(checkEmail == null)
                {
                    kh.PassWord = GETMD5(kh.PassWord);
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.KHACHHANGs.Add(kh);
                    db.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.EmailError = "Email đã tồn tại";
                    return View();
                }
            }
            return View();
        }
        // 44=>65 tạo chứa năng để đẩy dữ liệu lên server

        // tạo chức năng mã hóa mật khẩu
        public static string GETMD5(string pass)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(pass);
            byte[] targetData = md5.ComputeHash(fromData);
            string mk_da_ma_hoa = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                mk_da_ma_hoa += targetData[i].ToString("x2");

            }
            return mk_da_ma_hoa;

        }
    }
}
