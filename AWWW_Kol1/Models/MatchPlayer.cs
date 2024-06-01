namespace AWWW_Kol1.Models
{
	public class MatchPlayer
	{
		public int MatchPlayerId { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int MatchId { get; set; }
		public virtual Match Match { get; set; } = null!;
		public virtual IList<MatchEvent> ?MatchEvents { get; set; }
		public int PostionId { get; set; }
		public virtual Position Postion { get; set; } = null!;
		public int PlayerId { get; set; }
		public virtual Player Player { get; set; } = null!;
	}
}
