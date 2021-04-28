using Microsoft.AspNetCore.Mvc;
using System.Linq;
using pira.Data;
using pira.Models;

namespace pira.Controllers
{
    public class FormController : Controller
    {

        private FormContext _context;
        public FormController(FormContext context)
        {
            _context = context;
        }
        public IActionResult Form(){
            return View();
        }
        [HttpPost]
        public IActionResult Form(Form f){
            if(ModelState.IsValid){
                _context.Add(f);
                _context.SaveChanges();

                
            }
            return View(f);
        }
        public IActionResult Lista(){
            var pre = _context.Presentacion.OrderBy(x => x.NombreP).ToList();
            return View(pre);
        }
        }
    }
