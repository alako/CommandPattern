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
            WorkerIT workerIT = new WorkerIT();
            WorkerPR workerPR = new WorkerPR();

            WriteReportCommand writeReportCommandIT = new WriteReportCommand(workerIT);
            WriteReportCommand writeReportCommandPR = new WriteReportCommand(workerPR);

            PreparePresentationCommand preparePresentationCommand =
               new PreparePresentationCommand(workerPR);

            WriteCodeCommand writeCodeCommand = new WriteCodeCommand(workerIT);

            manager.setCommand(writeReportCommandIT);
            manager.orderCommand();

            manager.setCommand(preparePresentationCommand);
            manager.orderCommand();

            manager.setCommand(writeCodeCommand);
            manager.orderCommand();

            Console.ReadLine();
        }
    }
}
