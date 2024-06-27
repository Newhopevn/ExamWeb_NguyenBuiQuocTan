using ExamWeb_NguyenBuiQuocTan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_NguyenBuiQuocTan.Controllers
{
    public class MusicController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MusicController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var musicList = _db.DiaNhacs.ToList();
            var tongsoluong = _db.DiaNhacs.Sum(x => x.SoLuong);
            ViewBag.Sum = tongsoluong;
            return View(musicList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(DiaNhac diaNhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Add(diaNhac);
                _db.SaveChanges();
                TempData["success"] = "Da them thanh cong";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            var diaNhac = _db.DiaNhacs.Find(id);
            if (diaNhac == null)
            {
                return NotFound();
            }
            return View(diaNhac);
        }
        
        [HttpPost]
        public IActionResult Update(DiaNhac diaNhac)
        {
            if (ModelState.IsValid) 
            {
                
                _db.DiaNhacs.Update(diaNhac);
                _db.SaveChanges();
                TempData["success"] = "Dia Nhac updated success";
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult Delete(int id)
        {
            var diaNhac = _db.DiaNhacs.FirstOrDefault(x => x.Id == id);
            if (diaNhac == null)
            {
                return NotFound();
            }
            return View(diaNhac);
        }
       
        public IActionResult DeleteConfirmed(int id)
        {
            var diaNhac = _db.DiaNhacs.Find(id);
            if (diaNhac == null)
            {
                return NotFound();
            }
            _db.DiaNhacs.Remove(diaNhac);
            _db.SaveChanges();
            TempData["success"] = "Book deleted success";
            return RedirectToAction("Index");
        }
    }
}