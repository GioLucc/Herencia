using System.Transactions;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelefonoAndroid primerTelefono = new TelefonoAndroid("Motorola", "Edge 30", "Blanco", 200f, "Android 12", false,true,"5Hz",128,false,14.4f,2.1f);

            Console.WriteLine(primerTelefono);

            TelefonoDeJuguete telefonitoRosa = new TelefonoDeJuguete("DiToys", "2", "Rosita", 5, "Plastico", "No tiene", true);
            telefonitoRosa.ActivarLuces();
            telefonitoRosa.ReproducirCancionBarbieGirl();
        }
    }
}