﻿namespace Spec
{
    class Program
    {
        static void Main(string[] args)
        {
#if false
            Test.Type.Test(args);
#endif
#if false
            Test.ExtensionMethod.Test(args);
#endif
#if true
            Test.Linq.Test(args);
#endif
#if false
            Test.Property.Test(args);
#endif
        }
    }
}
