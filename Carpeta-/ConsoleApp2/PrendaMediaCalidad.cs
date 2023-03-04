﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrendaMediaCalidad: Prenda
    {
        public string Diseño { get; set; }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Prenda de media calidad, {Diseño}, {Material}, {Color}, {Talla}, {Precio:C}");
        }
    }
}
