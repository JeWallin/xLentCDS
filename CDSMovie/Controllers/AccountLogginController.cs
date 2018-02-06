using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CDSMovie.Database;

namespace CDSMovie.Controllers
{
    public class AccountLogginController : ApiController
    {

        MyDataBaseContext database = new MyDataBaseContext();

        // /api/AccountLoggin
        public IEnumerable<AccountLoggin> GetAllMovies()
        {
            var Accs = from a in database.Accounts select a;
            return Accs;
        }

        // /api/AccountLogin/{id}
        public IHttpActionResult GetProduct(String Account)
        {
            var acc = database.Accounts.Where((a) => a.UserName.Equals(Account));
            if (acc == null)
            {
                return NotFound();
            }
            return Ok(acc);
        }
    }
}
