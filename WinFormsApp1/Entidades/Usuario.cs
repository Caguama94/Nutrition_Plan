using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Dieta.Entidades
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Usuario(string username, string password)
        {
            Username=username;
            Password=password;
        }
    }


}
