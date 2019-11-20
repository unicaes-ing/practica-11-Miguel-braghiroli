using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Miguel Braghiroli 11/11/19
namespace Practica_11
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresar los datos del cliente");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Nombre del cliente:");
                string Ncliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Numero telefonico del cliente:");
                string Tcliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento del cliente:");
                string FNcliente = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Salario del cliente:");
                decimal Scliente = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("Datos_cliente.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(Ncliente);
                binario.Write(Tcliente);
                binario.Write(FNcliente);
                binario.Write(Scliente);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Los datos se almacenaron correctamente...");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Ocurrio un error al guardar los datos del cliente...");
            }
        }
    }
}
