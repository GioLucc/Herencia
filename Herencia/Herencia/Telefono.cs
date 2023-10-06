using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Telefono
    {
        private string marca;
        private string modelo;
        private string color;
        private float precio;

        public Telefono(string marca, string modelo, string color, float precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.precio = precio;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public float Precio { get => precio; set => precio = value; }



    }
}
