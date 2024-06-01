namespace AWWW_Kol1.Models
{
	public class EventType
	{
		public int EventTypeId { get; set; }
		public string Name { get; set; } = null!;
		public virtual IList<MatchEvent> ?MatchEvents { get; set; }
	}
}
