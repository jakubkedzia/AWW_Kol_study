namespace AWWW_Kol1.Models
{
	public class Comment
	{
		public int CommentId { get; set; }
		public string Title { get; set; } = null!;
		public string Content { get; set; } = null!;
		public int ArticleId { get; set; }
		public virtual Article Article { get; set; } = null!;
	}
}
