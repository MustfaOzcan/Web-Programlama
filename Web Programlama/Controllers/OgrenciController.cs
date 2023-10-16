using Microsoft.AspNetCore.Mvc;
using Web_Programlama.Models;

namespace Web_Programlama.Controllers
{
	public class OgrenciController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult OgrEkle()
		{
			return View();
		}


		public String OgrKaydetParam(string OgrAd, string OgrSoyad, string OgrNo)
		{
			string msj = OgrAd + " " + OgrSoyad + "" + OgrNo + " " + "Kaydedildi";
			return msj;
		}

		///////////////////////////////////////////////////////
		
		public IActionResult OgrEkleClass()
		{
			return View();
		}

		public IActionResult OgrKaydetClass(Ogrenci ogr)
		{
			return View(ogr);	
		}
		/// //////////////////////////////////////////////////
		
		///////////////////////////////////////////////////////////////////////////////////////////////////
		public String KayitBasarili()
		{

			return "kayit basarili";
		}

		public String KayitBasarisiz()
		{
			return "basarisiz";
		}

		public IActionResult OgrEkleforKaydet()
		{
			return View();
		}

		public IActionResult OgrKaydet()
		{
			string ad = HttpContext.Request.Query["OgrAd"];
			string soyad = HttpContext.Request.Query["OgrSoyad"];
			int no = Convert.ToInt32(HttpContext.Request.Query["OgrNo"]);
			string msj = "";
			if (no < 0 || ad.Length < 3)
			{
				return RedirectToAction("KayitBasarisiz");

			}
			else
			{
				return RedirectToAction("KayitBasarili");
			}

		}

		///////////////////////////////////////////////////////////////////////////////////////////////////
		static public List<Ogrenci> ogrenciler = new List<Ogrenci>();//dinamik dizi
		public IActionResult EkleSon()
		{
			return View();
		}
		public IActionResult OgrKaydetSon(Ogrenci ogr)
		{
			ogrenciler.Add(ogr);
			return RedirectToAction("OgrList");
		}
		
		public IActionResult OgrList()
		{
			return View(ogrenciler);
		}
		/////////////////////////////////////////

	}
}
