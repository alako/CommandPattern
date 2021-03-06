﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class PreparePresentationCommand:ICommand
    {
        IWorkerPR worker;
        public PreparePresentationCommand(IWorkerPR w)
        {
            worker = w;
        }
        public void Execute()
        {
            worker.preparePresentation();
        }
    }
}
