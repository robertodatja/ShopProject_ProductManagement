using Part6.CommandInterceptors;

namespace Part6
{
    public static class InterceptorStore
    {
        public static List<ICommandInterceptor> interceptors = new List<ICommandInterceptor>()
        {
            new AddCommandInterceptor(), //I. at PART2 PART3
            new ListCommandInterceptor(),     //II. at PART4
            new ListAllCommandInterceptor(),  //III.at PART5 
            new ClearCmdCommandInterceptor(),  //IV.at PART6
            new DeleteCommandInterceptor(),    //V. at PART6
            new UpdateCommandInterceptor(),   //VI. at PART6
        };
    }
}
