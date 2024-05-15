
using Fiorello_PB101.Data;
using Fiorello_PB101.Services;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fiorello_PB101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IBlogService _blogService;
        public HomeController(ISliderService sliderService,
                                    IBlogService blogService)
        {
            _sliderService = sliderService;
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM model = new ()
            {
                Sliders = await _sliderService.GetAllAsync(),
                SliderInfo= await _sliderService.GetSliderInfoAsync(),
                Blogs= await _blogService.GetAllAsync()
            };

            return View(model);
        }



             
        
       
    }
}