using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CDSMovie.Database
{
    public class AccountLoggin
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(256)]
        public String UserName { get; set; }
        public String Password { get; set; }
        public DateTime Created { get; set; }
    }

    public class MyDataBaseContext : DbContext
    {
        public MyDataBaseContext()
        {
            Accounts.RemoveRange(Accounts);

            Accounts.Add(new AccountLoggin() { UserName = "Johannes", Password = "Johannes", Created = DateTime.Now});
            Accounts.Add(new AccountLoggin() { UserName = "Linda", Password = "Linda", Created = DateTime.Now });
            Accounts.Add(new AccountLoggin() { UserName = "Sam", Password = "Sam", Created = DateTime.Now});

            this.SaveChanges();
        }

        public DbSet<AccountLoggin> Accounts { get; set; }
    }
}