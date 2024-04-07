using Part2.CommandInterceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public static class InterceptorStore
    {
        public static List<ICommandInterceptor> interceptors = new List<ICommandInterceptor>()
        {
            //Dhe automatikisht ketu do te shtojme te gjithe interceptors qe kemi ne program
            //per momentin s'kemi ndertuar asnji, keshtu qe po e leme bosh.
            //Por me vone kur t'i shtojme  normalisht do i kemi prezent ketu.

            new AddCommandInterceptor(), //I. bosh at PART2
        };
    }
}
