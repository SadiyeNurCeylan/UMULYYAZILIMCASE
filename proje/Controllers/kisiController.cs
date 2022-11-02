using proje.Models.Context;
using proje.Models.Entities;
using proje.Models.kisimodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace proje.Controllers
{
    public class kisiController : Controller
    {
        MvcProjeContext db = new MvcProjeContext();

        // GET: kisi
        public ActionResult Index()
        {
           
            var model = new KisiIndexViewModel
            {
                kisiler = db.kisiler.ToList(),
                modlar = db.modlar.ToList(),
                hareketler = db.hareketler.ToList(),
                teslimatlar = db.teslimatlar.ToList(),
                paketler = db.paketler.ToList(),
                birimler = db.birimler.ToList(),
                uniteler = db.uniteler.ToList(),
                paralar = db.paralar.ToList(),
                sehirler = db.sehirler.ToList()
        };

            return View(model);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            var model = new KisiEkleViewModel
            {
                kisi = new kisi(),
                modlar = db.modlar.ToList(),
                hareketler = db.hareketler.ToList(),
                teslimatlar = db.teslimatlar.ToList(),
                sehirler = db.sehirler.ToList(),
                paketler = db.paketler.ToList(),
                birimler = db.birimler.ToList(),
                uniteler = db.uniteler.ToList(),
                paralar = db.paralar.ToList()

            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Ekle(kisi kisi)
        {
            try
            {
                db.kisiler.Add(kisi);
                db.SaveChanges();

                TempData["basarilimesaj"] = "Ekleme İşlemi Başarıyla Gerçekleşti !";
            }
            catch
            {
                TempData["hatalimesaj"] = "Ekleme İşlemi Başarısız! Lütfen Tekrar Deneyin !";
            }

            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var kisi = db.kisiler.Find(id);

            if(kisi==null)
            {
                TempData["hatalimesaj"] = "Güncellenmek İstenen Kayıt Bulunamadı !";
                return RedirectToAction("Index");
            }

            var model = new KisiGuncelleViewModel
            {
                kisi = kisi,
                modlar = db.modlar.ToList(),
                hareketler = db.hareketler.ToList(),
                teslimatlar = db.teslimatlar.ToList(),
                paketler = db.paketler.ToList(),
                birimler = db.birimler.ToList(),
                uniteler = db.uniteler.ToList(),
                paralar = db.paralar.ToList(),
                sehirler = db.sehirler.ToList()
            };


            ViewBag.modlar = new SelectList(db.modlar.ToList(), "id", "Mod");
            ViewBag.hareketler = new SelectList(db.hareketler.ToList(), "id", "Hareket");
            ViewBag.teslimatlar = new SelectList(db.teslimatlar.ToList(), "id", "Teslimat");
            ViewBag.paketler = new SelectList(db.paketler.ToList(), "id", "Paket");
            ViewBag.birimler = new SelectList(db.birimler.ToList(), "id", "Birim");
            ViewBag.uniteler = new SelectList(db.uniteler.ToList(), "id", "Unite");
            ViewBag.paralar = new SelectList(db.paralar.ToList(), "id", "Para");
            ViewBag.sehirler = new SelectList(db.sehirler.ToList(), "id", "Sehiradi");

            return View(model);
        }

        [HttpPost]
        public ActionResult Guncelle(kisi kisi)
        {
            var eskikisi = db.kisiler.Find(kisi.id);

            if(eskikisi==null)
            {
                TempData["hatalimesaj"] = "Güncellenmek İstenen Kayıt Bulunamadı !";
                return RedirectToAction("Index");
            }

            eskikisi.ad = kisi.ad;
            eskikisi.soyad = kisi.soyad;
            eskikisi.modid = kisi.modid;
            eskikisi.hareketid = kisi.hareketid;
            eskikisi.teslimatid = kisi.teslimatid;
            eskikisi.birimid = kisi.birimid;
            eskikisi.uniteid = kisi.uniteid;
            eskikisi.paraid = kisi.paraid;
            eskikisi.sehirid = kisi.sehirid;

            db.SaveChanges();

            TempData["basarilimesaj"] = "Güncelleme İşlemi Başarıyla Gerçekleşti !";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Detay(int id)
        {
            var kisi = db.kisiler.Find(id);

            if (kisi== null)
            {
                TempData["hatalimesaj"] = "Kayıt Bulunamadı !";
                return RedirectToAction("Index");
            }

            var model = new KisiDetayViewModel
            {
                kisi = kisi,
                modlar = db.modlar.ToList(),
                hareketler = db.hareketler.ToList(),
                teslimatlar = db.teslimatlar.ToList(),
                paketler = db.paketler.ToList(),
                birimler = db.birimler.ToList(),
                uniteler = db.uniteler.ToList(),
                paralar = db.paralar.ToList(),
                sehirler = db.sehirler.ToList(),
            };

            return View(model);
        }

        public ActionResult Sil(int id)
        {
            var kisi = db.kisiler.Find(id);

            if(kisi == null)
            {
                TempData["hatalimesaj"] = "Kayıt Bulunamadı !";
                return RedirectToAction("Index");
            }

            db.kisiler.Remove(kisi);
            db.SaveChanges();

            TempData["basarilimesaj"] = "Kişi Silme İşlemi Başarılı !";

            return RedirectToAction("Index");
        }

        public ActionResult MailGonder(int id)
        {
            var kisi = db.kisiler.Find(id);

            if(kisi==null)
            {
                TempData["hatalimesaj"] = "Kişi Bulunamadı !";
                return RedirectToAction("Index");
            }

            return View(kisi);
        }

        [HttpPost]
        public ActionResult MailGönder(string email, string baslik, string mesaj)
        {
            try
            {
                var gondericimail = new MailAddress("sadiyenurceylan19@gmail.com");
                var sifre = "";
                var alicimail = new MailAddress(email);

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(gondericimail.Address, sifre)

                };

                using (var msg = new MailMessage(gondericimail, alicimail)
                {
                    IsBodyHtml = true,
                    Subject=baslik,
                    Body=mesaj
                })
                {
                    smtp.Send(msg);
                }
                TempData["basarilimesaj"] = "Mail Gönderme İşlemi Başarıyla Gerçekleşti";
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                TempData["hatalimesaj"] = "Mail Gönderme İşlemi Sırasında Hata Oluştu! Lütfen Tekrar Deneyin !";
                return RedirectToAction("Index");
            }
        }

    }
}