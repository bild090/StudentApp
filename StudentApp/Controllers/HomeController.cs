using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentApp.Core.Models;
using StudentApp.EntityFrameworkCore.Contract;
using StudentApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {

        

        public HomeController()
        {
       
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
