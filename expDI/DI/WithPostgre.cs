using expDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expDI.DI
{
    public class WithPostgre : IInsert
    {
        public string Insert() {
            return "Postgre sql ile insert işlemi gercekleştirdim.";
        }
    }
}