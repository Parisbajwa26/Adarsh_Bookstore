﻿using AdarshBookstore.DataAccess.Repository.IRepository;
using AdarshBookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdarshBookstore.Areas.Admin.Controllers
{
    [   Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                return View(category);
            }

            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll() 
        {
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}
