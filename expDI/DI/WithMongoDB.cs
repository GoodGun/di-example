using expDI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace expDI.DI
{
    public class WithMongoDB : IInsert
    {
        public string Insert()
        {
            return "Mongo DB ile insert işlemi gerçekleştirdim.";
        }
    }
}