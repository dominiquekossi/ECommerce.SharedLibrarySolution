using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.SharedLibrary.Response;

namespace ECommerce.SharedLibrary.Interface
{
    public interface IGenericInterface<T> where T : class
    {
        Task<Responses> GetByIdAsync(T entity);
        //Task<IEnumerable<T>> GetAllAsync();
        //Task<bool> AddAsync(T entity);
        //Task<bool> UpdateAsync(T entity);
        //Task<bool> DeleteAsync(int id);
    }
    
}
