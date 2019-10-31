using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayToy.Models;
using PlayToy_3.Models;


namespace PlayToy.Controllers
{
    public class UsuarioController : Controller
    {
        private JugueteriaContext _context;
        public UsuarioController(JugueteriaContext x) {
            _context = x;
        } 
    }
}