using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoeStoreApp.Models;
using ShoeStoreApp.ViewModels;

namespace ShoeStoreApp.Controller
{
    public class ShoeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ShoeController(IShoeRepository shoeRepository, ICategoryRepository categoryRepository)
        {
            _shoeRepository = shoeRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            // ViewBag.CurrentCategory = "Basketball shoes";
            // return View(_shoeRepository.AllShoes);

            ShoeListViewModel shoeListViewModel = new ShoeListViewModel(_shoeRepository.AllShoes,
                "Basketball shoes");
            return View(shoeListViewModel);
        }
    }
}