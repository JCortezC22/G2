using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******TIENDA EL PEPITO*********\n\n\n HECHO POR: JORDY & WENDY");

            Console.WriteLine("\nELIGE LA OPCION:\n 1- Prendas de alta calidad " +
                "\n 2- Prendas de media calidad \n 3- Prendas de baja calidad\n 4- Salir del programa");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion <= 0 || opcion >= 5)
            {
                Clear();
                Console.WriteLine("*******TIENDA EL PEPITO*********\n\n\n HECHO POR: JORDY & WENDY\n");
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡¡Por favor asegurate que la opción se encuentre en el menu!!");
                ResetColor();
                Console.WriteLine("\nELIGE LA OPCIÓN:" +
                    "\n 1- Prendas de alta calidad " +
                "\n 2- Prendas de media calidad \n 3- Prendas de baja calidad\n 4- Salir del programa");
                opcion = int.Parse(Console.ReadLine());
            }
            CatalogoPrendas catalogo = new CatalogoPrendas();

            switch (opcion)
            {

                case 1:
                    Clear();
                    Console.WriteLine($"Elegiste la opcion {opcion}\n");

                    PrendaAltaCalidad[] prendasAltaCalidad = new PrendaAltaCalidad[4];

                    prendasAltaCalidad[0] = new PrendaAltaCalidad
                    {
                        Material = "Algodón",
                        Talla = "M",
                        Color = "Azul",
                        Precio = 49.99M,
                        Marca = "Hugo Boss",
                        Diseño = "Camisa de vestir"
                    };
                    
                    prendasAltaCalidad[1] = new PrendaAltaCalidad
                    {
                        Material = "Seda",
                        Talla = "S",
                        Color = "Rojo",
                        Precio = 99.99M,
                        Marca = "Gucci",
                        Diseño = "Vestido de gala"
                    };

                    prendasAltaCalidad[2] = new PrendaAltaCalidad
                    {
                        Material = "Lana",
                        Talla = "L",
                        Color = "Negro",
                        Precio = 79.99M,
                        Marca = "Armani",
                        Diseño = "Saco de vestir"
                    };
                    catalogo.AgregarPrenda(prendasAltaCalidad[0]);
                    catalogo.AgregarPrenda(prendasAltaCalidad[1]);
                    catalogo.AgregarPrenda(prendasAltaCalidad[2]);
                    catalogo.MostrarCatalogo("AltaCalidad");

                    break;
                case 2:

                    PrendaMediaCalidad[] prendaMediaCalidad = new PrendaMediaCalidad[4];

                    prendaMediaCalidad[0] = new PrendaMediaCalidad
                    {
                        Material = "Algodón",
                        Talla = "L",
                        Color = "Negro",
                        Precio = 59.99M,
                        Diseño = "Pantalón casual"
                    };

                    prendaMediaCalidad[1] = new PrendaMediaCalidad
                    {
                        Material = "Mezclilla",
                        Talla = "M",
                        Color = "Azul",
                        Precio = 39.99M,
                        Diseño = "Pantalón de mezclilla"
                    };

                    prendaMediaCalidad[2] = new PrendaMediaCalidad
                    {
                        Material = "Lino",
                        Talla = "S",
                        Color = "Blanco",
                        Precio = 49.99M,
                        Diseño = "Pantalón de vestir"
                    };

                    catalogo.AgregarPrenda(prendaMediaCalidad[0]);
                    catalogo.AgregarPrenda(prendaMediaCalidad[1]);
                    catalogo.AgregarPrenda(prendaMediaCalidad[2]);
                    catalogo.MostrarCatalogo("MediaCalidad");
                    break;
                case 3:
                    PrendaBajaCalidad[] prendaBajaCalidad = new PrendaBajaCalidad[4];

                    prendaBajaCalidad[0] = new PrendaBajaCalidad
                    {
                        Material = "Poliéster",
                        Talla = "M",
                        Color = "Rojo",
                        Precio = 24.99M,
                    };

                    prendaBajaCalidad[1] = new PrendaBajaCalidad
                    {
                        Material = "Poliéster",
                        Talla = "M",
                        Color = "Rojo",
                        Precio = 24.99M,
                    };

                    prendaBajaCalidad[2] = new PrendaBajaCalidad
                    {
                        Material = "Nylon",
                        Talla = "L",
                        Color = "Verde",
                        Precio = 29.99M,
                    };

                    catalogo.AgregarPrenda(prendaBajaCalidad[0]);
                    catalogo.AgregarPrenda(prendaBajaCalidad[1]);
                    catalogo.AgregarPrenda(prendaBajaCalidad[2]);
                    catalogo.MostrarCatalogo("BajaCalidad");
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Lo siento mucho, esa opción no está disponible");
                    Console.ReadLine();
                    break;
            }

        }
    }

    
}

