namespace AWWW_Kol1.Models
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string Name { get; set; } = null!;
		public virtual IList<Article> ?Articles { get; set; }
	}
}
