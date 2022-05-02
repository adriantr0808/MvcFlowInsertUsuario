using Microsoft.AspNetCore.Mvc;
using MvcFlowInsertUsuario.Models;
using MvcFlowInsertUsuario.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFlowInsertUsuario.Controllers
{
    public class LogicAppController : Controller
    {
        private ServiceLogicApp service;

        public LogicAppController(ServiceLogicApp service)
        {
            this.service = service;
        }
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(Usuario user)
        {
            await this.service.InsertUsuarioAsync(user);
            return View();
        }
    }
}
