using expDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expDI.DI
{
    public class WithCassandraDB : IInsert
    {
        public string Insert()
        {
            return "Cassandra ile insert işlemi gerçekleştiriyorum.";
        }
    }
}