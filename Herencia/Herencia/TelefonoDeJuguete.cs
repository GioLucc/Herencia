using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public sealed class TelefonoDeJuguete : Telefono
    {
        private string material;
        private string tienePantalla;
        private bool haceSonidos;

        public TelefonoDeJuguete(string marca, string modelo, string color, float precio, string material, string tienePantalla, bool haceSonidos) : base(marca, modelo, color, precio)
        {
            this.material = material;
            this.tienePantalla = tienePantalla;
            this.haceSonidos = haceSonidos;
        }

        public string Material { get => material; set => material = value; }
        public string TienePantalla { get => tienePantalla; set => tienePantalla = value; }
        public bool HaceSonidos { get => haceSonidos; set => haceSonidos = value; }


    }
}
