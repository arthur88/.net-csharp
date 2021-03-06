﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyBookListRazor.Model;

namespace UdemyBookListRazor.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new {  data = await _db.Book.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookfromDb = await _db.Book.FirstOrDefaultAsync(u => u.Id == id);

            if(bookfromDb == null)
            {
                return Json(new { success = false, message = "Error whilwe deleting" });
            }
            _db.Book.Remove(bookfromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Deleted succesfully" });
        }

    }
}
