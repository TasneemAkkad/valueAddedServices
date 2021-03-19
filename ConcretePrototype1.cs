using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    //concrete Prototype
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1 (string Ser, string Opr, string Cir, string Pro, Commission Comm) 
            : base(Ser, Opr, Cir, Pro, Comm)
        {

        }

        public override Prototype Clone()
        {
            //mecvut nesnenin kopyalamasını MemberwiseClone Döndüruyor
            return (Prototype)this.MemberwiseClone();
        }
    }
}
