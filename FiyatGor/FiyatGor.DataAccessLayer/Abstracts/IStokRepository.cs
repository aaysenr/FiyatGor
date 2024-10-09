using FiyatGor.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatGor.DataAccessLayer.Abstracts
{

    public interface IStokRepository
    {


        Task<Stok?> GetStokByBarcodeAsync(string barcode);

        Task AddStokAsync(Stok stok);

        Task DeleteStokByBarcodeAsync(string barcode);

        Task UpdateStokAsync(Stok stok);

        Task<List<Stok>> GetAllStoksAsync();


    }



}
