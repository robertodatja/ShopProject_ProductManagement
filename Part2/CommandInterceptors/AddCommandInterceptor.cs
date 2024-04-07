using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.CommandInterceptors
{
    public class AddCommandInterceptor : ICommandInterceptor
    {
        //kthejme gjithmon Add sepse kjo eshte komanda te cilen ne do ekzekutojme kete interceptor  AddCommandInterceptor
        //public string Operation { get{ return "Add";} } //gjate
        public string Operation => "Add"; //shkurt

        public void Execute(Command command)
        {
            Console.WriteLine("Hey, Add interceptor is executed :) ");
        }

        public void ShowDoc()
        {
            throw new NotImplementedException();
        }
    }
}
