using ETicaret2.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicaret2.Models
{
    public class State
    {
        ETicaretDb db = new ETicaretDb();
        public StateModelStyle GetModelState()
        {
            StateModelStyle models = new StateModelStyle();
            models.UrunSayisi = db.Products.Count();
            return models;
        }
        
    }
    public class StateModelStyle
    {
        public int UrunSayisi { get; set; }
    }
}