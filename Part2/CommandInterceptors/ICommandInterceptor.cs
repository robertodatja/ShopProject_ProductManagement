using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.CommandInterceptors
{
    public interface ICommandInterceptor
    {
        public string Operation { get;} //prop per veprimin
        void Execute(Command command); //metode qe do te ekzekuton interceptorin
        void ShowDoc(); //metode qe do te shfaq dokumentacionin
    }
}
