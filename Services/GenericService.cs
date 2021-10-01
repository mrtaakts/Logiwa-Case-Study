using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : BaseEntity
    {
        public readonly AppDbContext _context;
        public GenericService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseDto> Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            var savestatus = await _context.SaveChangesAsync();
            return savestatus > 0 ? new ResponseDto { Message = "Başarıyla Eklendi.", Status = true } : new ResponseDto { Message = "Eklenme İşlemi Gerçekleşmedi.", Status = false };
        }

        public async Task<ResponseDto> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                var savestatus = _context.SaveChanges();
                return savestatus > 0 ? new ResponseDto { Message = "Başarıyla silindi.", Status = true } : new ResponseDto { Message = "Silinme İşlemi Gerçekleşmedi.", Status = false };

            }
            return new ResponseDto { Message = $"{id} nolu id bulunamadı.", Status = false };

        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            var entity = await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            return entity;


        }


    }
}
