using expDI.DI;
using expDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expDI.Organization
{
    public class DbOperations
    {
        IInsert _x;
        public DbOperations(IInsert sql)
        {
            _x = sql;
        }

        public string InsertEt()
        {
            return _x.Insert();
        }
    }
}