namespace AWWW_Kol1.Models
{
	public class Article
	{
		public int ArticleId { get; set; }
		public string Title { get; set; } = null!;
		public string Lead { get; set; } = null!;
		public string Content { get; set; } = null!;
		public DateTime CreationDate { get; set; }
		public int AuthorId { get; set; }
		public virtual Author Author { get; set; } = null!;
		public virtual IList<Comment> ?Comments { get; set; }
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; } = null!;
		public virtual IList<Tag>? Tags { get; set; }
		public int ?MatchId { get; set; }
		public virtual Match ?Match { get; set; } 
	}


}
