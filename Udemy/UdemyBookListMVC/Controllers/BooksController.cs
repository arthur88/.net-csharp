using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyBookListMVC.Models;

namespace UdemyBookListMVC.Controllers
{

    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Book Book { get; set; }
        public IActionResult Index()
        {
            return View();
        }       
        
        public IActionResult Upsert(int? ID)
        {
            Book = new Book();
            if(ID == null)
            {
                //create requrest
                return View(Book);
            }
            //update
            Book = _db.Books.FirstOrDefault(u => u.ID == ID);

            if(Book == null)
            {
                return NotFound();
            }
            return View(Book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
           if(ModelState.IsValid)
            {
                if(Book.ID == 0)
                {
                    //create
                    _db.Books.Add(Book);
                }
                else
                {
                    //update
                    _db.Books.Update(Book);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Book);
        }

        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        #region API calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Books.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookfromDb = await _db.Books.FirstOrDefaultAsync(u => u.ID == id);

            if (bookfromDb == null)
            {
                return Json(new { success = false, message = "Error whilwe deleting" });
            }
            _db.Books.Remove(bookfromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Deleted succesfully" });
        }
        #endregion
    }
}
