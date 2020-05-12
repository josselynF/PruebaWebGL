using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebGLJuego.Models;

namespace WebGLJuego.Controllers{
    public class UnityController:Controller{

        public IActionResult Index(){
            return View();
        }

    }
}
