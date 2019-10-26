using Microsoft.AspNetCore.Mvc;
using IdentityData;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IdentityData;

namespace Schaak.Controllers
{
    public class TestController : Controller
    {
        readonly List<Boek> boeks;
        readonly List<Uitleen> uitleens;
        readonly List<Klant> klants;

        public TestController()
        {
            boeks = new List<Boek>
            {
                new Boek(){Id=1,Naam="Boek1"},
                new Boek(){Id=2,Naam="Boek2" },
                new Boek(){Id=3,Naam="Boek3"}
            };
            klants = new List<Klant>
            {
                new Klant(){ Id=1,Naam="Klant1"},
                new Klant(){ Id=2,Naam="Klant2"},
                new Klant(){ Id=3,Naam="Klant3"}
            };
            uitleens = new List<Uitleen>
                {
                new Uitleen() { BoekId=1,KlantId=2},
                new Uitleen() { BoekId=2,KlantId=3}
            };
        }
        public class Boek
        {
            public string Naam { get; set; }
            public int? Id { get; set; }
        }

        public class Klant
        {
            public string Naam { get; set; }
            public int? Id { get; set; }
        }

        public class Uitleen
        {
            public int? KlantId { get; set; }
            public int? BoekId { get; set; }
        }
        public class UitleenQuery
        {
            public string BoekNaam { get; set; }
            public int? BoekId { get; set; }
            public int KlantId { get; set; }
            public string KlantNaam { get; set; }
        }
        public class UitleenTabel
        {
            public IEnumerable<Boek> Boeken { get; set; }
            public IEnumerable<Uitleen> Uitleen { get; set; }
        }
        public class BoekKlanten
        {
            public int? BoekId { get; set; }
            public string BoekNaam { get; set; }
            public List<Uitleen> Uitleen { get; set; }
        }
        public IActionResult Index()
        {
            var UQ1 = boeks.Join(uitleens.DefaultIfEmpty(new Uitleen()), a => a.Id, b => b.BoekId, (a, b) => new  { BoekId = a.Id, BoekNaam = a.Naam, b.KlantId }).ToList();
            var UQ2 = boeks.DefaultIfEmpty(new Boek()).Join(uitleens, a => a.Id, b => b.BoekId, (a, b) => new { BoekId = a.Id, BoekNaam = a.Naam, b.KlantId }).ToList();
            var UQ3 = boeks.DefaultIfEmpty(new Boek()).Join(uitleens.DefaultIfEmpty(new Uitleen()), a => a.Id, b => b.BoekId, (a, b) => new { BoekId = a.Id, BoekNaam = a.Naam, b.KlantId }).ToList();

            var UQ4 = boeks.Join(uitleens.DefaultIfEmpty(new Uitleen()), a => a.Id, b => b.BoekId, (a, b) => new { BoekId = a.Id, BoekNaam = a.Naam, b.KlantId }).ToList();
            var UQ5 = boeks.DefaultIfEmpty(new Boek()).Join(uitleens, a => a.Id, b => b.BoekId, (a, b) => new { BoekId = a.Id, BoekNaam = a.Naam, b.KlantId }).ToList();
            var UQ6 = boeks.DefaultIfEmpty(new Boek()).Join(uitleens.DefaultIfEmpty(new Uitleen()), a => a.Id, b => b.BoekId, (a, b) => new { BoekId = a.Id, BoekNaam = a.Naam,  b.KlantId }).ToList();

            var defuit = new Uitleen() { BoekId = 0, KlantId = 0 };
            var UQ8 = from boek in boeks
                      join uitleen in uitleens.DefaultIfEmpty() on boek.Id equals uitleen.BoekId
                      select new { boek.Naam, boek.Id, KlantId = uitleen == null ? 0 : uitleen.KlantId };


            var UQ9 = boeks.Join(uitleens, a => a.Id, b => b.BoekId, (a, b) => new { a.Id, BoekNaam = a.Naam, b.KlantId });
            var UQ10 = UQ9.DefaultIfEmpty().Select(a => new { a.BoekNaam, a.Id, a.KlantId });

           
            //var UQ4 = from boek in boeks rightjoin uitleen in uitleens on boek.Id equals uitleen.BoekId select new { BoekId = boek.Id, Boeknaam = boek.Naam, KlantId = uitleen.KlantId };




            /////Werkt////
            var UQ7 = from boek in boeks
                      join uitleen in uitleens on boek.Id equals uitleen.BoekId into bu
                      from boui in bu.DefaultIfEmpty()
                      select new { boek.Naam, boek.Id, KlantId = boui == null ? 0 : boui.KlantId };
            //innerjoin
            List<BoekKlanten> UQ11 = boeks.GroupJoin(uitleens, a => a.Id, b => b.BoekId, (bk, ul) => new BoekKlanten { BoekId = bk.Id, BoekNaam = bk.Naam, Uitleen = ul.ToList() }).ToList();

            //leftouter 
            var UQ12 = boeks.GroupJoin(uitleens, a => a.Id, b => b.BoekId, (x, y) => new { x.Naam, x.Id, Uitleen = y })
           .SelectMany(x => x.Uitleen.DefaultIfEmpty(), (x, y) => new BoekKlanten() { BoekId = x.Id, BoekNaam = x.Naam, Uitleen=x.Uitleen.ToList()  }).ToList();

            var UQ13 = boeks.GroupJoin(uitleens, a => a.Id, b => b.BoekId, (x, y) => new { Boek=x, Uitleen = y })
                       .SelectMany(x => x.Uitleen.DefaultIfEmpty(), (x, y) => new BoekKlanten() { BoekId = x.Boek.Id, BoekNaam = x.Boek.Naam, Uitleen = x.Uitleen?.ToList() }).ToList();



            return View(UQ13);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateAdministrators()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
