using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Classes
{
    public static class DBConnection
    {
        public static readonly string ConnectionString =
            @"Data Source=localhost;Initial Catalog=NewDB;Integrated Security=True;";
    }
}
