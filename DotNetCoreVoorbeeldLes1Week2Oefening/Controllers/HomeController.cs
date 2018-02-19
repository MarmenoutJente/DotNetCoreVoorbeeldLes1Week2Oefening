using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreVoorbeeldLes1Week2Oefening.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string name)
        {
            return $"Hallo {name}";
        }
    }
}