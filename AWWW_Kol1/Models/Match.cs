namespace AWWW_Kol1.Models
{
	public class Match
	{
		 public int MatchId { get; set; }
		 public DateTime Date { get; set; }
		public string Stadium { get; set; } = null!;
		public virtual IList<Article> ?Articles { get; set; }
		public virtual IList<MatchEvent > ?MatchEvents { get; set; }
		public virtual IList<MatchPlayer>? MatchPlayers { get; set; }
		public int HomeTeamId { get; set; }
		public virtual Team HomeTeam { get; set; } = null!;
		public int ForeignTeamId { get; set; }
		public virtual Team ForeignTeam { get; set; } = null!;

	}
}
