using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Services
{
    public interface IGenericService<TEntity> where TEntity : BaseEntity
    {
        Task<ResponseDto> Create(TEntity entity);
        IQueryable<TEntity> GetAll();
        Task<ResponseDto> Delete(int id);
        Task<TEntity> GetById(int id);
    }
}
