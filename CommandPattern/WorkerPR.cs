using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class WorkerPR:IWorker,IWorkerPR
    {
        public void writeReport()
        {
            Console.WriteLine("I am writing a beautiful report!");
        }

        public void preparePresentation()
        {
            Console.WriteLine("I am preparing a beautiful presentation!");
        }
    }
}
