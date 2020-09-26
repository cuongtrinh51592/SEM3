using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Session04.Models;

namespace Session04.DAL
{
    public class GoldClubContext:DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}