using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayToy.Models;


namespace PlayToy.Controllers
{
    public class PedidoController : Controller
    {
         private JugueteriaContext _context;
        public PedidoController(JugueteriaContext x) {
            _context = x;
        }  
        
         
    }
}