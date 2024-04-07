using Part5.CommandInterceptors;

namespace Part5
{
    public static class InterceptorStore
    {
        public static List<ICommandInterceptor> interceptors = new List<ICommandInterceptor>()
        {
            new AddCommandInterceptor(), //I. at PART2 PART3
            new ListCommandInterceptor(),     //II. at PART4
            new ListAllCommandInterceptor(),  //III.at PART5 
        };
    }
}
