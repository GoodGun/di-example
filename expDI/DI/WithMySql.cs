using expDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expDI.DI
{
    public class WithMySql : IInsert
    {
        public string Insert()
        {

            return "MySql ile insert işlemi gerceklestirdim";
        }
    }
}