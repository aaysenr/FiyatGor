using FiyatGor.DataAccessLayer.Abstracts;
using FiyatGor.DataAccessLayer.Context;
using FiyatGor.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatGor.DataAccessLayer.Concrets
{
    public class StokRepository : IStokRepository
    {

        private readonly FiyatgordbContext _context;

        public StokRepository(FiyatgordbContext context)
        {
            _context = context;
        }

        public async Task<Stok?> GetStokByBarcodeAsync(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
            {
                throw new ArgumentException("Barkod numarası alanı boş olamaz.", nameof(barcode));
            }

            

            var stok = await _context.Stoks.Where(s => s.Barkod == barcode).FirstOrDefaultAsync();

            if (stok == null)
            {
                throw new InvalidOperationException("Girilen barkod numarası ile eşleşen herhangi bir ürün bulunamadı.");
            }

            return stok;

            

        }



        public async Task AddStokAsync(Stok stok)
        {
            if (stok == null)
            {
                throw new ArgumentNullException(nameof(stok));
            }

            
            var existingStok = await _context.Stoks
                .FirstOrDefaultAsync(s => s.Barkod == stok.Barkod);

            if (existingStok != null)
            {
                throw new InvalidOperationException($"Girilen '{stok.Barkod}' barkod numarası zaten mevcut.");
            }

            _context.Stoks.Add(stok);
            await _context.SaveChangesAsync();
        }



        public async Task DeleteStokByBarcodeAsync(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
            {
                throw new ArgumentException("Barkod numarası alanı boş olamaz.", nameof(barcode));
            }

            var stok = await _context.Stoks
                .FirstOrDefaultAsync(s => s.Barkod == barcode);

            if (stok == null)
            {
                throw new InvalidOperationException($"Girilen '{barcode}' barkod numarası ile eşleşen herhangi bir ürün bulunamadı.");
            }

            _context.Stoks.Remove(stok);
            await _context.SaveChangesAsync();
        }



        public async Task UpdateStokAsync(Stok stok)
        {
            if (stok == null)
            {
                throw new ArgumentNullException(nameof(stok));
            }

            var existingStok = await _context.Stoks
                .FirstOrDefaultAsync(s => s.Barkod == stok.Barkod);

            if (existingStok == null)
            {
                throw new InvalidOperationException($"Girilen '{stok.Barkod}' barkod numarasıyla eşleşen herhangi bir ürün bulunamadı.");
            }

            _context.Stoks.Update(stok);
            await _context.SaveChangesAsync();
        }


        public async Task<List<Stok>> GetAllStoksAsync()
        {
            return await _context.Stoks.ToListAsync();
        }



    }
}
