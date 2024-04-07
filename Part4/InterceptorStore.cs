using Part4.CommandInterceptors;

namespace Part4
{
    public static class InterceptorStore
    {
        public static List<ICommandInterceptor> interceptors = new List<ICommandInterceptor>()
        {
            new AddCommandInterceptor(), //I. at PART2 PART3
            new ListCommandInterceptor(),     //II. at PART4
        };
    }
}
