using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class PreparePresentationCommand:ICommand
    {
        IWorker worker;
        public PreparePresentationCommand(IWorker w)
        {
            worker = w;
        }
        public void Execute()
        {
            worker.preparePresentation();
        }
    }
}
