using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp1.modelos
{
    internal class Cliente
    {



        public string? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public string? TarjetaDeCredito { get; set; }

        public string NombreCompleto => Nombre + " " + Apellido;

        public override string ToString()
        {
            return NombreCompleto;
        }
    }




}
