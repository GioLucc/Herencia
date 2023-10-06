using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class TelefonoAndroid : TelefonoInteligente
    {
        private bool modoDesarrolloHabilitado;
        private float versionDePlayProtect;
        private float versionAsistenteDeVoz;

        public TelefonoAndroid(string marca, string modelo, string color, float precio, string sistemaOperativo, bool poseeNfc, bool gpsActivado, string redesMoviles, float cantidadAlmacenamiento, bool modoDesarrolloHabilitado, float versionDePlayProtect, float versionAsistenteDeVoz) : base(marca, modelo, color, precio, sistemaOperativo, poseeNfc, gpsActivado, redesMoviles, cantidadAlmacenamiento)
        {
            this.modoDesarrolloHabilitado = modoDesarrolloHabilitado;
            this.versionDePlayProtect = versionDePlayProtect;
            this.versionAsistenteDeVoz = versionAsistenteDeVoz;
        }

        public bool ModoDesarrolloHabilitado { get => modoDesarrolloHabilitado; set => modoDesarrolloHabilitado = value; }
        public float VersionDePlayProtect { get => versionDePlayProtect; set => versionDePlayProtect = value; }
        public float VersionAsistenteDeVoz { get => versionAsistenteDeVoz; set => versionAsistenteDeVoz = value; }
    }
}
