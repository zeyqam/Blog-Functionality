
using Fiorello_PB101.Data;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiorello_PB101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        public HomeController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM model = new ()
            {
                Sliders = await _sliderService.GetAllAsync(),
                SliderInfo= await _sliderService.GetSliderInfoAsync()
            };

            return View(model);
        }



             
        
       
    }
}