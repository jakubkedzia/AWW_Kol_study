namespace AWWW_Kol1.Models
{
	public class Player
	{
		public int PlayerId { get; set; }
		public string FirstName { get; set; } = null!;
		public string LastName { get; set; } = null!;
		public string Country { get; set; } = null!;
		public DateTime BirthDate { get; set; }
		public int TeamId { get; set; }
		public virtual Team Team { get; set; } = null!;
		public int PositionId { get; set; }
		public virtual Position Position { get; set; } = null!;
		public virtual IList<MatchPlayer>? MatchPlayers { get; set; }
	}
}
