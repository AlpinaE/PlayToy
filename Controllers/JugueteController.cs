using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayToy.Models;



namespace PlayToy.Controllers
{
    public class JugueteController : Controller
    {
         private JugueteriaContext _context;
        public JugueteController(JugueteriaContext x) {
            _context = x;
        }  

        public IActionResult Catalogo(){
            return View();
        }
    }
}