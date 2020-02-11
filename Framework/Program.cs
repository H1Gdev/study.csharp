namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
#if false
            Test.Font.Test(args);
#endif
#if false
            Test.Runtime.Test(args);
#endif
#if false
            Test.Culture.Test(args);
#endif
#if true
            Test.Spans.Test(args);
#endif
        }
    }
}
