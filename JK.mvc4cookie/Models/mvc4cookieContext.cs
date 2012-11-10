using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JK.mvc4cookie.Models
{
  public class mvc4cookieContext : DbContext
  {
    public mvc4cookieContext() : base("mvc4cookie")
    {
    }

    public DbSet<UserProfile> UserProfiles { get; set; }
  }
}