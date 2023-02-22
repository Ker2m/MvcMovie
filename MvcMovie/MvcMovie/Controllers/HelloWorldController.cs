using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index(string mesaj, int adet)
        {
            ViewData["Baslik"] = "Index Test";
            ViewData["Message"] = mesaj;
            ViewData["NumTimes"] = adet;
            return View();
        }

        public IActionResult Welcome(string name, int urunId)
        {
            string[] urunler = { "kedi", "kalem", "silgi", "defter" };
            string gelenUrun = urunler[urunId - 1];


            BilgiPaketi bp = new BilgiPaketi();
            bp.KisiAdi = name;
            bp.UrunAdi = gelenUrun;

            // ViewData["kargo"] = bp;

            return View(bp);
        }
    }
}
