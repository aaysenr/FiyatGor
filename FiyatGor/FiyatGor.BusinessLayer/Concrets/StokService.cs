using FiyatGor.BusinessLayer.Abstracts;
using FiyatGor.BusinessLayer.DTOs;
using FiyatGor.DataAccessLayer.Abstracts;
using FiyatGor.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FiyatGor.BusinessLayer.Concrets
{
    public class StokService : IStokService
    {


        private readonly IStokRepository _stokRepository;

        public StokService(IStokRepository stokRepository)
        {
            _stokRepository = stokRepository;
        }

        public async Task<StokDetailsDto?> GetStokDetailsAsync(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
            {
                throw new ArgumentException("Barkod numarası alanı boş olamaz.", nameof(barcode));
            }

            var stokEntity = await _stokRepository.GetStokByBarcodeAsync(barcode);
            if (stokEntity == null)
            {
                return null;
            }

            // Entity'den DTO'ya dönüşüm.
            var stokDto = new StokDetailsDto
            {
                Barkod = stokEntity.Barkod,
                Ad = stokEntity.Ad,
                SFiyat = stokEntity.SFiyat ?? 0.0,
                Bakiye = stokEntity.Bakiye ?? 0.0
            };

            return stokDto;
        }

        public async Task AddNewStokAsync(string barkod, string ad, double bakiye, double sfiyat)
        {
            if (string.IsNullOrWhiteSpace(barkod) || string.IsNullOrWhiteSpace(ad))
            {
                throw new ArgumentException("Barkod ve ad alanları boş olamaz.");
            }

            // Stok nesnesini oluştur.
            var stok = new Stok
            {
                Barkod = barkod,
                Ad = ad,
                Bakiye = bakiye,
                SFiyat = sfiyat
            };

            ValidateStok(stok);
            await _stokRepository.AddStokAsync(stok);
        }

        public async Task DeleteStokByBarcodeAsync(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
            {
                throw new ArgumentException("Barkod numarası alanı boş olamaz.", nameof(barcode));
            }

            await _stokRepository.DeleteStokByBarcodeAsync(barcode);
        }

        public async Task UpdateStokDetailsAsync(string barkod, string? ad = null, double? bakiye = null, double? sfiyat = null)
        {
            if (string.IsNullOrWhiteSpace(barkod))
            {
                throw new ArgumentException("Barkod numarası alanı boş olamaz.", nameof(barkod));
            }

            var stok = await _stokRepository.GetStokByBarcodeAsync(barkod);
            if (stok == null)
            {
                throw new StokNotFoundException($"Girilen {barkod} barkod numarası ile eşleşen ürün bulunamadı.");
            }

            if (ad != null)
            {
                stok.Ad = ad;
            }

            if (bakiye.HasValue)
            {
                stok.Bakiye = bakiye.Value;
            }
            if (sfiyat.HasValue)
            {
                stok.SFiyat = sfiyat.Value;
            }

            ValidateStok(stok);
            await _stokRepository.UpdateStokAsync(stok);
        }

        public async Task<List<StokDetailsDto>> GetAllStoksAsync()
        {
            var stoks = await _stokRepository.GetAllStoksAsync();
            return stoks.Select(stok => new StokDetailsDto
            {
                Barkod = stok.Barkod,
                Ad = stok.Ad,
                SFiyat = stok.SFiyat ?? 0.0, // Null kontrolü ile varsayılan değer kullanılır.
                Bakiye = stok.Bakiye ?? 0.0  // Null kontrolü ile varsayılan değer kullanılır.
            }).ToList();
        }


        private void ValidateStok(Stok stok)
        {
            if (string.IsNullOrWhiteSpace(stok.Barkod))
            {
                throw new ArgumentException("Barkod ve ad alanları boş olamaz.");
            }
            
        }



    }

    public class StokNotFoundException : Exception
    {
        public StokNotFoundException(string message) : base(message) { }
    }
}