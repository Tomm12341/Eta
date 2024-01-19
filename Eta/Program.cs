using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine("inserisci la tua data di nascita: ");
            persona.DataNascita = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("hai {0} anni", persona.CalcolaEta());
            Console.ReadLine
                ();
        }
    }
}
