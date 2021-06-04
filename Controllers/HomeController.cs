using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JsGraphicExampleWithMvc.Models;
using JsGraphicExampleWithMvc.ViewModels;

namespace JsGraphicExampleWithMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Example1()
        {

            return View();
        }


        [HttpGet("[controller]/graphic/values1")]
        public ActionResult<GraphicsViewModel> Get()
        {
            // Get item from database
            GraphicsViewModel viewModel = new GraphicsViewModel();
            viewModel.ItemPropertyDictionary = new Dictionary<string, List<ItemProperty>>();
            viewModel.ItemPropertyDictionary.Add("Fuel", new List<ItemProperty> {
                new ItemProperty {Category = "Fuel", Type= "Gasoline", Value = "20"}});
            viewModel.ItemPropertyDictionary.Add("Polymer", new List<ItemProperty> {
                new ItemProperty {Category = "Polymer", Type= "Plastic bottle", Value = "2"}});
            viewModel.ItemPropertyDictionary.Add("Wood", new List<ItemProperty> {
                new ItemProperty {Category = "Wood", Type= "Small table", Value = "4"}});
            viewModel.ItemPropertyDictionary.Add("Food", new List<ItemProperty> {
                new ItemProperty {Category = "Food", Type= "Butter stick", Value = "1"}});

            return viewModel;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
