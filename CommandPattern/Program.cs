using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            WorkerA workerA = new WorkerA();
            WorkerB workerB = new WorkerB();
            WriteReportCommand writeReportCommandA = new WriteReportCommand(workerA);
            WriteReportCommand writeReportCommandB = new WriteReportCommand(workerB);
            PreparePresentationCommand preparePresentationCommandA = 
                new PreparePresentationCommand(workerA);
            PreparePresentationCommand preparePresentationCommandB =
               new PreparePresentationCommand(workerB);
            manager.setCommand(writeReportCommandA);
            manager.orderCommand();

            manager.setCommand(preparePresentationCommandB);
            manager.orderCommand();

            manager.setCommand(writeReportCommandB);
            manager.orderCommand();

            Console.ReadLine();
        }
    }
}
