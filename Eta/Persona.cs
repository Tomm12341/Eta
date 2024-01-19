using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eta
{
    internal class Persona
    {
        public DateTime DataNascita { get; set; }


        public int CalcolaEta()
        {
            int Anni= DateTime.Now.Year-DataNascita.Year;

            if (DateTime.Now.Month > DataNascita.Month || DateTime.Now.Month == DataNascita.Month && DateTime.Now.Day > DataNascita.Day)
            {
                Anni = Anni - 1;
                return (int)Anni;

            }
            else if (DateTime.Now.Month == DataNascita.Month && DateTime.Now.Day==DataNascita.Day || DateTime.Now.Month > DataNascita.Month || DateTime.Now.Month == DataNascita.Month && DateTime.Now.Day > DataNascita.Day)
            {
                return (int)Anni;
            }
           
            
           
        }
    }
}
