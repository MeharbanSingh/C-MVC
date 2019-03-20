using System;

namespace OOPExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //var comp = new Desktop("Generic Computers",Desktop.CaseType.Tower);

            var comp = new Laptop("Generic Laptop", 1024,768);


            Console.WriteLine("Computer Type -" + comp.GetType());

            var isComputer = comp is Computers;

            Console.WriteLine("Is Computer - " + isComputer);
            Console.WriteLine("Computer name - "+comp.name);
            //Console.WriteLine("Computer case - " + comp.caseType);

            comp.togglePower();
            Console.WriteLine("Computer is on :" + comp.isOn);


            var sleepingComp = comp as ISleep;

            if(sleepingComp != null)
            {
                sleepingComp.toggleSleep();
                Console.WriteLine("Computer is sleeping :" + sleepingComp.isSleeping);

                comp.togglePower();
                Console.WriteLine("Computer is on :" + comp.isOn);
            }
            
        }

       
    }
}
