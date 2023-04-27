using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace EjercicioSesion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Console.WriteLine("");
            Ejercicio3();
        }

        public static void Ejercicio1()
        {
            Console.WriteLine("Escriba su nombre.");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba su apellido.");
            string apellido = Console.ReadLine();
            Console.WriteLine("Escriba su edad");
            int edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Sabe programar? Escriba 's' para afirmar o 'n' para negar");
            string sabe = Console.ReadLine().ToLower();

            bool sabe2 = Convert.ToBoolean(sabe == "s");

            
            if (sabe2 == true)
            {
                //string ok = "Sí";
                sabe = "Sí";
            }
            else if (sabe2 == false) 
            {
                sabe = "No";
            }
            else
            {
                Console.WriteLine("Ha introducido un caracter no admitido");
            }


            Console.WriteLine("Nombre: " + nombre + " Apellido: " + apellido + " Edad: " + edad + " Sabe Programar?: " + sabe);
        }

        public void Ejercicio2()
        {
            //Coche
            int puertas;
            int ruedas;
            string marca;
            bool ITVvigente;

            //Mesa
            decimal peso;
            decimal largo;
            string material;
            string color;

        }

        public static void Ejercicio3()
        {
            int num = 10;

            Console.WriteLine("El número es mayor que 18? " + (num >= 18));

            char a = 'a';

            Console.WriteLine("Es el el siguiente caracter 'a'? " + (a == 'a'));

            Console.WriteLine("Es num menor que 18 y el caracter 'a'? " + (num < 18 && a == 'a'));

            Console.WriteLine("Es num menor que 18 y el caracter 'g'? " + (num < 18 && a == 'g'));
        }
    }


}