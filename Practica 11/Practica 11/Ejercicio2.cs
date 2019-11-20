using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Miguel Braghiroli 11/11/19
namespace Practica_11
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("Datos_cliente.dat", FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string Ncliente = binario.ReadString();
                string Tcliente = binario.ReadString();
                string FNcliente = binario.ReadString();
                decimal Scliente = binario.ReadDecimal();
                stream.Close();
                binario.Close();
                Console.WriteLine("Datos del cliente...");
                Console.WriteLine();
                Console.WriteLine("Nombre del cliente: {0}", Ncliente);
                Console.WriteLine();
                Console.WriteLine("numero de telefono del cliente: {0}", Tcliente);
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento del cliente: {0}", FNcliente);
                Console.WriteLine();
                Console.WriteLine("Salario del cliente: {0:C2}", Scliente);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Presione la tecla <ENTER> para salir");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al guardar los datos del cliente...");
            }
        }
    }
}
