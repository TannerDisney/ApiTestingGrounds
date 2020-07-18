using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using Microsoft.AspNetCore.Mvc;

namespace ApiTestingGrounds.Controllers
{
    public class APIController : Controller
    {
        public IActionResult NewsAPI()
        {
            return View();
        }
    }
}