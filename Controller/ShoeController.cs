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

        public IActionResult List(string category)
        {
            IEnumerable<Shoe> shoes;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                shoes = _shoeRepository.AllShoes.OrderBy(s => s.ShoeId);
                currentCategory = "All Shoes";
            }
            else
            {
                shoes = _shoeRepository.AllShoes.Where(s => s.Category.CategoryName == category)
                    .OrderBy(s => s.ShoeId);

                currentCategory = _categoryRepository.AllCategories
                    .FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
                
            }

            return View(new ShoeListViewModel(shoes, currentCategory));

        }
        // public IActionResult List()
        // {
        //     // ViewBag.CurrentCategory = "Basketball shoes";
        //     // return View(_shoeRepository.AllShoes);
        //
        //     ShoeListViewModel shoeListViewModel = new ShoeListViewModel(_shoeRepository.AllShoes,
        //         "All shoes");
        //     return View(shoeListViewModel);
        // }
        public IActionResult Details(int id)
        {
            var shoe = _shoeRepository.GetShoeById(id);
            if (shoe == null)
            {
                return NotFound();
            }

            return View(shoe);

        }
        
        
    }
}