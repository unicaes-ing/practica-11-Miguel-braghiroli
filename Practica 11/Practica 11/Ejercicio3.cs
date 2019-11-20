using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Miguel Braghiroli 11/11/19
namespace Practica_11
{
    class Ejercicio3
    {
        public static void MenuInicial()
        {
            Console.SetCursorPosition(70, 10);
            Console.WriteLine("==== Registro de Alumnos ====");
            Console.SetCursorPosition(65, 12);
            Console.WriteLine("1-Agregar alumno.");
            Console.SetCursorPosition(65, 14);
            Console.WriteLine("2-Mostrar Alumnos.");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("3-Buscar Alumno.");
            Console.SetCursorPosition(65, 18);
            Console.WriteLine("4-Salir");
            Console.SetCursorPosition(65, 22);
            Console.Write("Ingrese una opcion: ");
            int Opc = Convert.ToInt32(Console.ReadLine());
            switch (Opc)
            {
                case 1:
                    Console.Clear();
                    Ingresar();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Mostrar();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Buscar();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Presione <ENTER> para salir del programa");
                    Console.ReadKey();
                    break;
            }
        }
        static void Main(string[] args)
        {
            MenuInicial();
            Console.ReadKey();
        }
        public static void Ingresar()
        {
            try
            {
                Console.WriteLine("==== Datos del alumno ====");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese el carnet del alumno:");
                string Calumno = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese el nombre del alumno:");
                string Nalumno = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingrese la edad del alumno:");
                int Ealumno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ingrese el CUM del alumno:");
                decimal CUMalumno = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("Datos_Alumno.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(Calumno);
                binario.Write(Nalumno);
                binario.Write(Ealumno);
                binario.Write(CUMalumno);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Los datos de guardaron exitosamente...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un error al almacenar los datos");
            }
        }
        public static void Mostrar()
        {
            Console.WriteLine("==== Mostrar datos ====");
            Console.WriteLine();
            Console.WriteLine("1-Todos los alumnos");
            Console.WriteLine();
            Console.WriteLine("2-Filtrados por CUM");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese una opcion: ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
        }
        public static void Buscar()
        {
        }
    }
}
