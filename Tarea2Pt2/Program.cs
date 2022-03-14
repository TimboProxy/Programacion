using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parte2
{

    class Program
    {
        static void Main(string[] args)
        {

            int Precio_plancha = 100;
            int Precio_molcajete = 900;
            int Precio_burro = 10000;
            int Precio_prendas = 1500;
            int Precio_licuadora = 5600;

            int sum = 0;
            int cant = 0;
            int planchatotal = 0;
            int molcajetetotal = 0;
            int burrototal = 0;
            int prendastotal = 0;
            int licuadorastotal = 0;
            int total1;
            int total2;
            int total3;
            int total4;
            int total5;


            Console.WriteLine("\tABARROTES MARÍA ");
            Console.WriteLine("\tVentas");


            Console.WriteLine("\n\nArticulo 1");
            Console.WriteLine("\nRopa:  ");
            Console.WriteLine("Precio Ropa: 100 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            planchatotal = cant * Precio_plancha;
            Console.WriteLine("Importe : {0}", planchatotal);



            Console.WriteLine("\n\nArticulo 2");
            Console.WriteLine("\nLicuadora:  ");
            Console.WriteLine("Precio Licuadora: 900 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            molcajetetotal = cant * Precio_molcajete;
            Console.WriteLine("Importe : {0}", molcajetetotal);



            Console.WriteLine("\n\nArticulo 3");
            Console.WriteLine("\nLavadora:  ");
            Console.WriteLine("Precio Lavadora: 10000 ");

            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());

            burrototal = cant * Precio_burro;
            Console.WriteLine("Importe : {0}", burrototal);



            Console.WriteLine("\n\nArticulo 4");
            Console.WriteLine("\nMicrondas:  ");
            Console.WriteLine("Precio Microndas: 1500 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            prendastotal = cant * Precio_prendas;
            Console.WriteLine("Importe : {0}", prendastotal);



            Console.WriteLine("\n\nArticulo 5");
            Console.WriteLine("\nComedor:  ");

            Console.WriteLine("Precio Comedor: 5600 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            licuadorastotal = cant * Precio_licuadora;
            Console.WriteLine("Importe : {0}", licuadorastotal);


            sum = planchatotal + molcajetetotal + burrototal + prendastotal + licuadorastotal;
            total1 = (planchatotal / Precio_plancha);
            total2 = (molcajetetotal / Precio_molcajete);
            total3 = (burrototal / Precio_burro);
            total4 = (prendastotal / Precio_prendas);
            total5 = (licuadorastotal / Precio_licuadora);

            Console.WriteLine("El Total de ganacias fue de: {0}", sum);
            Console.WriteLine("Planchas Vendidas: {0}", total1);
            Console.WriteLine("Molcajetes vendidos: {0}", total2);
            Console.WriteLine("Burros vendidos: {0}", total3);
            Console.WriteLine("Prendas vendidas: {0}", total4);
            Console.WriteLine("Licuadoras vendidas: {0}", total5);
            Console.ReadKey();
        }
    }
}