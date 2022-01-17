using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Extensions;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : MainController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _produtoServices;

        public HomeController(ILogger<HomeController> logger, IProductService produtoServices)
        {
            _logger = logger;
            _produtoServices = produtoServices;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            _produtoServices.AddProduct(null);
            return View();
        }
        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
