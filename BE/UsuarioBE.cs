using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioBE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }

        public UsuarioBE(string nombre, string email, string tipo)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Tipo = tipo;
        }
    }
}
