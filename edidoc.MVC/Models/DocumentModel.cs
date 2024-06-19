namespace edidoc.MVC.Models
{
    public class DocumentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        public List<EditModel> Edits { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}