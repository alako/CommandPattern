using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class WriteReportCommand : ICommand
    {
        IWorker worker;
        public WriteReportCommand(IWorker w)
        {
            worker = w;
        }
        public void Execute()
        {
            worker.writeReport();
        }
    }
}
