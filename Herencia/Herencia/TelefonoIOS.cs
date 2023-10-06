using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class TelefonoIOS : TelefonoInteligente
    {
        private bool tieneFaceID;
        private bool iCloudActivado;
        private float versionDeSiri;

        public TelefonoIOS(string marca, string modelo, string color, float precio, string sistemaOperativo, bool poseeNfc, bool gpsActivado, string redesMoviles, float cantidadAlmacenamiento, bool tieneFaceID, bool iCloudActivado, float versionDeSiri) : base(marca, modelo, color, precio, sistemaOperativo, poseeNfc, gpsActivado, redesMoviles, cantidadAlmacenamiento)
        {
            this.tieneFaceID = tieneFaceID;
            this.iCloudActivado = iCloudActivado;
            this.versionDeSiri = versionDeSiri;
        }

        public bool TieneFaceID { get => tieneFaceID; set => tieneFaceID = value; }
        public bool ICloudActivado { get => iCloudActivado; set => iCloudActivado = value; }
        public float VersionDeSiri { get => versionDeSiri; set => versionDeSiri = value; }

    }
}
