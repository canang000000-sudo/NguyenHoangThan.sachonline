using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace TranPhamThanhTrung.SachOnline.Controllers
{
    public class SachOnlineController : Controller
    {
        private List<SACH> LaySachMoi(int count)
        {
            return data.SACHes.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }
        public ActionResult ChuDePartial()
        {
            var listChuDe = from cd in data.CHUDEs select cd;
        return PartialView(listChuDe);
        }
        // Action Index cho trang chủ [cite: 1399, 1400]
        public ActionResult Index()
        {
            var listSachMoi = LaySachMoi(6); // Lấy 6 quyển sách mới nhất [cite: 1403]
            return View(listSachMoi);
    }
        // GET: SachOnline
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NavPartial()
        {
            return PartialView();
        }

        public ActionResult SliderPartial()
        {
            return PartialView();
        }

        public ActionResult ChuDePartial()
        {
            return PartialView();
        }

        public ActionResult NhaXuatBanPartial()
        {
            return PartialView();
        }

        public ActionResult SachBanNhieuPartial()
        {
            return PartialView();
        }

        public ActionResult FooterPartial()
        {
            return PartialView();
        }
    }
}
