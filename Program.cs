using System;

namespace Prototype
{

    //client
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                       Service    Operator    City    Provider     InComm  OutComm");
            Console.WriteLine("");


            //yeni nesneyi oluştırduk
            ConcretePrototype1 CPT1 = new ConcretePrototype1("Topup", "All", "İzmir", "CyberPlat", new Commission(1.0, 0.5));

            Console.WriteLine("Original Object:          {0}       {1}        {2}     {3}      {4}    {5} "
                , CPT1.Service, CPT1.Operator, CPT1.City, CPT1.Provider, CPT1.Comm.IncomingCommission, CPT1.Comm.OutgoingCommission);
            Console.WriteLine("");


            //birinci nesneyi yopyalarak 
            //yeni nesnenin üzerinde değişikler yaptım
            ConcretePrototype1 CPT2 = (ConcretePrototype1)CPT1.Clone();

            Console.WriteLine("new object after Copying the original one:     {0}      {1}      {2}    {3}    {4}     {5}"
                , CPT2.Service, CPT2.Operator, CPT2.City, CPT2.Provider, CPT2.Comm.IncomingCommission, CPT2.Comm.OutgoingCommission);
            Console.WriteLine("");

            CPT2.City = "İstanbul";
            CPT2.Provider = "Euronet";
            CPT2.Comm.IncomingCommission = 0.75;
            CPT2.Comm.OutgoingCommission = 0.25;

            Console.WriteLine("changes in the copied object:        {0}      {1}        {2}   {3}    {4}    {5}"
                , CPT2.Service, CPT2.Operator, CPT2.City, CPT2.Provider, CPT2.Comm.IncomingCommission, CPT2.Comm.OutgoingCommission);
            Console.WriteLine("");

            

            Console.ReadKey();

        }
    }
}
