using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class WriteCodeCommand: ICommand
    {
        WorkerIT worker;
        public WriteCodeCommand(WorkerIT w)
        {
            worker = w;
        }
        public void Execute()
        {
            worker.writeCode();
        }
    }
}
