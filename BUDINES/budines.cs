using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUDINES
{
    class budines
    {
        static double masakg,masagr,restomasa, moldesusados, envoltorios, cajas;
        static double budinesSinEmpaquetar, paquetesSinCaja;

        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de masa que producio en kg");
            masakg = Convert.ToDouble(Console.ReadLine());
            masagr = masakg * 1000;
            
      
            moldesusados = Math.Truncate(masagr / 55);
            restomasa = masagr % 55;

            envoltorios =Math.Truncate(moldesusados / 12);

            cajas =Math.Truncate(envoltorios / 20);

             budinesSinEmpaquetar = moldesusados % 12;
             paquetesSinCaja = envoltorios % 20;



            Console.WriteLine($"La cantidad de budines producidos: {moldesusados}");
            Console.WriteLine($"La cantidad de paquetes de budines (envoltorios): {envoltorios}");
            Console.WriteLine($"La cantidad de cajas llenas listas para distribución: {cajas}");
            Console.WriteLine($"Masa sobrante después de hacer los budines: {restomasa} gramos");
            Console.WriteLine("----------------");
            Console.WriteLine("----------------");
            Console.WriteLine($"Budines sin empaquetar: {budinesSinEmpaquetar}");
            Console.WriteLine($"Paquetes sin caja: {paquetesSinCaja}");

            Console.ReadKey();
        }
    }
}
