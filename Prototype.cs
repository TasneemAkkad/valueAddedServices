using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    //Prototype
    public abstract class Prototype
    {
        //temel özelliklerin değerlerin ayarlamak için
        public Prototype(string Ser, string Opr, string Cir, string Pro, Commission Comm)
        {
            this.Service = Ser;
            this.Operator = Opr;
            this.City = Cir;
            this.Provider = Pro;
            this.Comm = Comm;
        }

        public Commission Comm { get; set; }

        public string Provider { get; set; }

        public string City { get; set; }

        public string Operator { get; set; }

        public string Service { get; set; }

        //kopyalama işlemi yapmak için (abstract)
        public abstract Prototype Clone();
    }
}
