namespace AWWW_Kol1.Models
{
	public class Team
	{
		public int TeamId { get; set; }
		public string Name { get; set; } = null!;
		public string Country { get; set; } = null!;
		public string City {  get; set; } = null!;
		public DateTime FoundingDate { get; set; }
		public int LeaugeId { get; set; }
		public virtual Leauge Leauge { get; set; } = null!;
		public virtual IList<Match>? HomeMatches { get; set; }
		public virtual IList<Match>? ForeignMatches { get; set; }
		public virtual IList<Player>? Players { get; set; }
	}
}
