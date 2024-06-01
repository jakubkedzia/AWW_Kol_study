namespace AWWW_Kol1.Models
{
	public class Tag
	{
		public int TagId { get; set; }
		public string Name { get; set; } = null!;
		public virtual IList<Article> ? Articles { get; set; }
	}
}
