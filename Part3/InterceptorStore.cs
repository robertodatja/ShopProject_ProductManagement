using Part3.CommandInterceptors;

namespace Part3
{
    public static class InterceptorStore
    {
        public static List<ICommandInterceptor> interceptors = new List<ICommandInterceptor>()
        {
            new AddCommandInterceptor(), //I. implemented at PART3
        };
    }
}
