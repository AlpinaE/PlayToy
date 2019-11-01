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

        public IActionResult Logeo(string user, string password){

            if(user.equalsIngoreCase(Usuario.User)  && password.equalsIngoreCase(Usuario.Contrasena)){
                    
            }

            return View()
        }

        public IActionResult Registrar(Usuario u){

             if (ModelState.IsValid) {
                _context.Add(u);
                _context.SaveChanges();
                return RedirectToAction("Logeo");
            }
            return View(u);
        }

        public IActionResult Cuenta()
        {
            var lista = _context.Usuarios.Include(x => x.Juguetes).ToList();
            return View(lista);
        }

        

    }
}