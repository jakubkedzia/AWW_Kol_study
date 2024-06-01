namespace AWWW_Kol1.Models
{
	public class MatchEvent
	{
		public int MatchEventId { get; set; }
		public int Minute { get; set; }
		public int MatchId { get; set; }
		public virtual Match Match { get; set; } = null!;
		public int ?MatchPlayerId { get; set; }
		public virtual MatchPlayer ?MatchPlayer { get; set; }
		public int EventTypeId { get; set; }
		public virtual EventType EventType { get; set; } = null!;
	}
}
