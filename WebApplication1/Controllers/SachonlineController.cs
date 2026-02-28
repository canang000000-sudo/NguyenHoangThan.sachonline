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

        SachOnlineEntities data = new SachOnlineEntities();

        private List<SACH> LaySachMoi(int count)
        {
            return data.SACHes.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }

        private List<SACH> LaySachBanNhieu(int count)
        {
            // Sort by SoLuongBan (Sold Number) descending and take the top 6
            return data.SACHes.OrderByDescending(s => s.SoLuongBan).Take(count).ToList();
        }

        public ActionResult ChuDePartial()
        {
            var listChuDe = from cd in data.CHUDEs select cd;
            return PartialView(listChuDe);
        }

        // GET: SachOnline
        public ActionResult Index()
        {
            var listSachMoi = LaySachMoi(6); // Lấy 6 quyển sách mới nhất
            return View(listSachMoi);
        }

        public ActionResult NavPartial()
        {
            return PartialView();
        }

        public ActionResult SliderPartial()
        {
            return PartialView();
        }

        public ActionResult NhaXuatBanPartial()
        {
            var listNhaXuatBan = from nxb in data.NHAXUATBANs select nxb;
            return PartialView(listNhaXuatBan);
        }

        public ActionResult SachBanNhieuPartial()
        {
            var sachBanNhieu = LaySachBanNhieu(6);
            return PartialView(sachBanNhieu);
        }

        public ActionResult FooterPartial()
        {
            return PartialView();
        }
    }
}
