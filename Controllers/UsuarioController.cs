using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlayToy.Models;


namespace PlayToy.Controllers
{
    public class UsuarioController : Controller
    {
        private JugueteriaContext _context;
        public UsuarioController(JugueteriaContext x) {
            _context = x;
        }
        public IActionResult Logeo(){
            return View();
        } 
        
        [HttpPost]
        public IActionResult ValidarUsuario(){
            var usu= _context.Usuarios.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Logeo(string user, string pass){
                var usuario = _context.Usuarios.FirstOrDefault(u => u.User == user && u.Contrasena == pass);
                if(usuario!=null){
                    return RedirectToAction("Cuenta");
                    

                    /*if(empleado.Categoria=="Jefe de programación"){
                        return RedirectToAction("MenuJefe");
                    }else{
                        return RedirectToAction("MenuOtros");
                    }*/
                }else{
                    //return Ingresar("Usuario o contraseña incorrectos");
                    return RedirectToAction("Logeo");
                }
        }
        
        
        public IActionResult Registrar(){
            return View();
        }

        [HttpPost]
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
            //var lista = _context.Usuarios.Include(x => x.Juguetes).ToList();
            return View(/*lista*/);
        }
    }
}