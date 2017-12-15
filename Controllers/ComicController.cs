using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Azurepeakswebcomic.Models;
using Azurepeakswebcomic.Models.Entities;

namespace Azurepeakswebcomic.Controllers
{
    public class ComicController : Controller
    {

     ComicDbContext db = new ComicDbContext();

        public IActionResult Index()
        {
            ViewBag.stud = db.Comics;       
            return View();
        }

        // search metode
        // søg på - id
        // få udskrevet alt info on den ene person
        public IActionResult Search(int id = 1)
        {
            ViewBag.number = id;

            ViewBag.stud = db.Comics.ToList();

            return View();
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Comic co)
        {
            db.Comics.Add(co);
            db.SaveChanges();
            return View();
        }

        public IActionResult Entry(int id = 13)
        {    
              ViewBag.number = id;

            ViewBag.stud = db.Comics.ToList();
            
            return View();
        }

         public IActionResult AdminLogin()
        {
            string username = "jaks";
            string password = "1337";
            ViewBag.usn= username;
            ViewBag.pwd= password;       
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Comic cm = new Comic() { ComicId = id };
            db.Comics.Remove(cm);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("ComicId,Imgurl,Name,Date")] Comic comic)
        {
            db.Update(comic);
            db.SaveChanges();
            return View();
        }



    }
}
