using edidoc.MVC.Interfaces;
using edidoc.MVC.Models;

namespace edidoc.MVC.Services;

public class DocumentService : IDocumentService
{
    private readonly IDocumentRepository _documentRepository;

    public DocumentService(IDocumentRepository documentRepository)
    {
        _documentRepository = documentRepository;
    }

    public async Task<DocumentModel> GetByIdAsync(int id)
    {
        return await _documentRepository.GetByIdAsync(id);
    }
}