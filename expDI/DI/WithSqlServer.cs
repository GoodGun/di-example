using expDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expDI.DI
{
    public class WithSqlServer : IInsert
    {
        public string Insert() {

            return "Sql server ile insert işlemi gerceklestirdim";
        }
    }
}