using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoyPlaca
{
    class Program
    {
         static void Main()
        {            
            Placa dato = new Placa();
            int hora= new int();
            DateTime dt= new DateTime();

            try
            {
                Console.WriteLine("Write the number of the car:");
                dato.nuevaPlaca(Convert.ToInt16(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("It is a 4 digits number");
                Main();
            }

            try
            {
                Console.WriteLine("Write the date (dd-mm-yyyy):");
                dt=Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please follow the format");
                Main();
            }
            try
            {
                Console.WriteLine("Write the hour (hhhh):");
                hora=Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("24 hour format, for example 1700");
                Main();
            }
            
            calcularPico(dt, hora, dato);
            Console.ReadKey();
        }

        public static void calcularPico(DateTime fecha, int hora, Placa dato){
      
            if (Enumerable.Range(700,930).Contains(hora)||Enumerable.Range(1600,1930).Contains(hora))
            {
                if(fecha.DayOfWeek.Equals("Monday")&&dato.ultimoDigito()==1||dato.ultimoDigito()==2)
                    Console.WriteLine("You can't use the car");
                if (fecha.DayOfWeek.Equals("Tuesday") && dato.ultimoDigito() == 3 || dato.ultimoDigito() == 4)
                    Console.WriteLine("You can't use the car");
                if (fecha.DayOfWeek.Equals("Wednesday") && dato.ultimoDigito() == 5 || dato.ultimoDigito() == 6)
                    Console.WriteLine("You can't use the car");
                if (fecha.DayOfWeek.Equals("Thursday") && dato.ultimoDigito() == 7 || dato.ultimoDigito() == 8)
                    Console.WriteLine("You can't use the car");
                if (fecha.DayOfWeek.Equals("Friday") && dato.ultimoDigito() == 9 || dato.ultimoDigito() == 0)
                    Console.WriteLine("You can't use the car");
                Console.WriteLine("No problem with Pico y Placa :)");
            }
            else
            {
                Console.WriteLine("No problem with Pico y Placa :)");
            }
    
        }
    }
}
