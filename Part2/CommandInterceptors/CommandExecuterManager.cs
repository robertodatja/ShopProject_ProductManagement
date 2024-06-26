﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.CommandInterceptors
{
    public static class CommandExecuterManager
    {
        private static readonly Dictionary<string,ICommandInterceptor> Interceptors 
            = new Dictionary<string,ICommandInterceptor>();
        static CommandExecuterManager()
        {
            foreach (var interceptor in InterceptorStore.interceptors) { Interceptors.Add(interceptor.Operation, interceptor); }
        }

        public static void Execute(Command command)
        {
            if (Interceptors.TryGetValue(command.Name, out var interceptor)) { interceptor.Execute(command); }
            else { throw new Exception($"Interceptor for command: {command.Name} could not be found."); }
        }
    }
}
