using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект2
{
	internal class ApplicationContext4:DbContext
	{
		public DbSet<Zayavka> Zayavkas { get; set; }
		public ApplicationContext4() : base("DefaultConnection4") { }
	}
}
