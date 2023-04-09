using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoeStoreApp.Models;
using ShoeStoreApp.ViewModels;

namespace ShoeStoreApp.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IShoeRepository _shoeRepository;

        public HomeController(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }
        
        public IActionResult Index()
        {
            var shoesOfTheWeek = _shoeRepository.ShoeOfTheWeek;
            var homeViewModel = new HomeViewModel(shoesOfTheWeek);

            return View(homeViewModel);
        }
    }
}