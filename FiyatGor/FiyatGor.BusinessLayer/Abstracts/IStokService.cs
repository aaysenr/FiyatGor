using FiyatGor.BusinessLayer.DTOs;
using FiyatGor.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatGor.BusinessLayer.Abstracts
{
    public interface IStokService
    {

        Task<StokDetailsDto?> GetStokDetailsAsync(string barcode);

        Task AddNewStokAsync(string barkod, string ad, double bakiye, double sfiyat);

        Task DeleteStokByBarcodeAsync(string barcode);

        Task UpdateStokDetailsAsync(string barkod, string? ad = null, double? bakiye = null, double? sfiyat = null);

        Task<List<StokDetailsDto>> GetAllStoksAsync();

    }
}
