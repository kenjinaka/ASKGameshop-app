using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASKGames.Data.Exception
{
    public class DbException : ApplicationException
    {
        public DbException(string message) : base(message)
        {

        }
    }
}
