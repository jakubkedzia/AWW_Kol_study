namespace AWWW_Kol1.Models
{
	public class Leauge
	{
		public int LeaugeId { get; set; }
		public string Name { get; set; } = null!;
		public string Country { get; set; } = null!;
		public int Level { get; set; }
		public virtual IList<Team>? Teams { get; set; }

	}
}
