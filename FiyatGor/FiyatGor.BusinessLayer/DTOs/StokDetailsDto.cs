using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiyatGor.DataAccessLayer.Entities;

namespace FiyatGor.BusinessLayer.DTOs
{
    public class StokDetailsDto
    {
        public string Barkod { get; set; } = "-"; // Varsayılan değer "-" atandı.
        public string? Ad { get; set; } // Varsayılan değer null.
        public double SFiyat { get; set; } = 0; // Varsayılan değer atandı.
        public double Bakiye { get; set; } // Varsayılan değer verilmediği için varsayılan olarak 0'dır.

    }
}
