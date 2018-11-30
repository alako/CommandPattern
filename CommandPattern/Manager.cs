using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Manager
    {
        ICommand command;

        public Manager()
        {
            command = new NoCommand();

        }
        public void setCommand(ICommand c)
        {
            command = c;
        }

        public void orderCommand()
        {
            command.Execute();
        }



    }
}
