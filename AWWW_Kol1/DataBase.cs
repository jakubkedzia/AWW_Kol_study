using System;
using Microsoft.EntityFrameworkCore;
using AWWW_Kol1.Models;

namespace AWWW_Kol1
{
	public class DataBase : DbContext
	{
		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Article> Articles { get; set; }
		public virtual DbSet<Comment> Comments { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Tag> Tags { get; set; }
		public virtual DbSet<Leauge> Lauges { get; set; }
		public virtual DbSet<Match> Matches { get; set; }
		public virtual DbSet<Team> Teams { get; set; }	
		public virtual DbSet<Player> Players { get; set; }
		public virtual DbSet<MatchEvent> MatchEvents { get; set; }
		public virtual DbSet<MatchPlayer> MatchPlayers { get; set; }
		public virtual DbSet<Position> Positions { get; set; }
		public virtual DbSet<EventType> EventTypes { get; set; }
		public DataBase(DbContextOptions<DataBase> options) : base(options) 
		{ 
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseLazyLoadingProxies();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Match>()
				.HasOne(m => m.HomeTeam)
				.WithMany(t => t.HomeMatches)
                .HasForeignKey(m => m.HomeTeamId)
				.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Match>()
				.HasOne(m => m.ForeignTeam)
				.WithMany(t => t.ForeignMatches)
				.HasForeignKey(m => m.ForeignTeamId)
				.OnDelete(DeleteBehavior.NoAction);
			 
			modelBuilder.Entity<MatchPlayer>()
				.HasKey(mp => new { mp.MatchId, mp.MatchPlayerId });

			modelBuilder.Entity<MatchEvent>()
				.HasOne(me => me.MatchPlayer)
				.WithMany(mp => mp.MatchEvents)
				.HasForeignKey(me => new { me.MatchId, me.MatchPlayerId })
				.HasConstraintName("FK_MatchEvent_MatchPlayer")
				.IsRequired();
		}
	}
}
