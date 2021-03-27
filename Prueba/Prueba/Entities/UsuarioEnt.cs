using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities
{
    public class UsuarioEnt
    {
        private string NombUsu;
        private string Pass;
        public UsuarioEnt(string nombreUsuario, string password)
        {
            NombUsu = nombreUsuario;
            Pass = password;
        }

        public string NombreDeUsuario
        {
            get => NombUsu;
            set => NombUsu = value;

        }
        public string Password
        {
            get => Pass;
            set => Pass = value;

        }
    }
}
