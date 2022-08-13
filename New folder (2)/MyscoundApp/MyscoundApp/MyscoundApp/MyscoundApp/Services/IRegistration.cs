using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyscoundApp.Services
{
    public interface IRegistration
    {
        Task<bool> AddRegisAsync(T item);
        Task<bool> UpdateRegisAsync(T item);
        Task<bool> DeleteRegisAsync(string id);
        Task<T> GetRegisAsync(string id);
        Task<IEnumerable<T>> GetRegisAsync(bool forceRefresh = false);
    }
}
