using edidoc.MVC.Models;
using edidoc.MVC.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace edidoc.MVC.Repositories;

public class DocumentRepository : IDocumentRepository
{
    private readonly DbContext _dbContext;

    public DocumentRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<DocumentModel> GetByIdAsync(int id)
    {
        return await _dbContext.Documents
            .Include(d => d.Comments)
            .FirstOrDefaultAsync(d => d.Id == id);
    }
}