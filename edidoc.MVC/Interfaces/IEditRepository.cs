using System.Collections.Generic;
using System.Threading.Tasks;

namespace edidoc.MVC.Interfaces;

public interface IEditRepository
{
    Task<Edit> GetByIdAsync(int id);
    Task<IEnumerable<Edit>> GetByDocumentIdAsync(int documentId);
    Task AddAsync(Edit edit);
    Task UpdateAsync(Edit edit);
    Task DeleteAsync(int id);
}
