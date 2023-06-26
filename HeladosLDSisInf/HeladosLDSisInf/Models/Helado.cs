﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeladosLDSisInf.Models
{
    public class Helado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Sabor { get; set; }
        //Cantidad de porciones existentes
        [Required]
        public int Cantidad_P { get; set; }
        //precio sin ganancia
        [Required]
        public Decimal Precio_Venta { get; set; }
    }
}
