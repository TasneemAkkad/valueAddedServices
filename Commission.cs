using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Commission
    {
        //gelen ve giden komisyon hesaplamak için
        
        public double IncomingCommission;
        public double OutgoingCommission;

        public Commission(double IncomingComm, double OutgoingComm)
        {
            this.IncomingCommission = IncomingComm;
            this.OutgoingCommission = OutgoingComm;
        }
    }
}
