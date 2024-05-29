using System;
using Microsoft.EntityFrameworkCore;
using AWWW_Kol1.Models;

namespace AWWW_Kol1
{
	public class DataBase : DbContext
	{
		public DataBase(DbContextOptions<DataBase> options) : base(options) 
		{ 
			
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseLazyLoadingProxies();
		}
	}
}
