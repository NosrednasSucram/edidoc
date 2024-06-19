using System.Collections.Generic;

namespace edidoc.MVC;

public class DocumentViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public List<EditViewModel> Edits { get; set; }
    public List<CommentViewModel> Comments { get; set; }
}