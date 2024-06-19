using System.Collections.Generic;
using System.Threading.Tasks;

namespace edidoc.MVC.Interfaces;

public interface ICommentRepository
{
    Task<Comment> GetByIdAsync(int id);
    Task<IEnumerable<Comment>> GetByDocumentIdAsync(int documentId);
    Task AddAsync(Comment comment);
    Task UpdateAsync(Comment comment);
    Task DeleteAsync(int id);
}
