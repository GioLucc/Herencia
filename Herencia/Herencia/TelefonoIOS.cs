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


        public void PersonalizarInterfaz()
        {
            Console.WriteLine("Personalizando la interfaz de usuario de iOS.");
        }

        public void RealizarVideollamada(String contacto)
        {
            Console.WriteLine("Realizando una videollamada a " + contacto + " utilizando FaceTime.");
        }

        public void ActualizariOS()
        {
            Console.WriteLine("Buscando actualizaciones de iOS para el iPhone " + Modelo + ".");
        }

        public void DesbloquearConFaceID()
        {
            if (tieneFaceID)
            {
                Console.WriteLine("Desbloqueando el iPhone con Face ID.");
            }
            else
            {
                Console.WriteLine("Este iPhone no tiene Face ID.");
            }
        }

        public String MostrarIos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Color);
            sb.AppendLine(Marca);
            sb.AppendLine(Modelo);
            sb.AppendLine(Precio.ToString());
            sb.AppendLine(tieneFaceID.ToString());
            sb.AppendLine(iCloudActivado.ToString());
            sb.AppendLine(versionDeSiri.ToString());


            return sb.ToString();
        }
    }
}
