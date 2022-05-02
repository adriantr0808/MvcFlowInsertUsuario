using Microsoft.EntityFrameworkCore;
using MvcFlowInsertUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFlowInsertUsuario.Data
{
    public class UsuariosContext:DbContext
    {
        public UsuariosContext
            (DbContextOptions<UsuariosContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
