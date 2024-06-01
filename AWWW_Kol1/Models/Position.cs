namespace AWWW_Kol1.Models
{
	public class Position
	{
		public int PositionId { get; set; }
		public string Name { get; set; } = null!;
		public virtual IList<MatchPlayer> ?MatchPlayers { get; set; }
		public virtual IList<Player>? Players { get; set; }
	}
}
