using LoveCalculator.BLL.Factory;
using LoveCalculator.BLL.Interfaces;
using LoveCalculator.WebBased.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LoveCalculator.WebBased.Controllers
{
    public class HomeController : Controller
    {

        
        

        [HttpGet]
        public IActionResult Index()
        {
            
            return View(new LoveCalculatorModel());
        }
        [HttpPost]
        public IActionResult Index(LoveCalculatorModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                var loveCalculator = LoveCalculatorServiceFactory.Create();
                var result = loveCalculator.GetLoveScorePercentage(model.YourName, model.PartnersName);

                // Replace \n with <br> to correctly format in HTML
                result = result.Replace("\n", "<br>");

                model = new LoveCalculatorModel
                {
                    Result = result
                };

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                ModelState.AddModelError("Result", "Unexpected Error");
            }
            return View(model);
        }

       
    }
}
