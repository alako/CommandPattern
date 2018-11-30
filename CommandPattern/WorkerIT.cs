using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class WorkerIT: IWorker, IWorkerIT
    {
        public void writeReport()
        {
            Console.WriteLine("I am writing an awesome report!");
        }
        public void writeCode()
        {
            Console.WriteLine("I am preparing an awesome code!");
        }
    }
}
