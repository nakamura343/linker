using System;
using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Reflection.GetNestedTypes
{
    public class NonPublicAreStillRemoved
    {
        public static void Main()
        {
            foreach (var t in typeof(Foo).GetNestedTypes())
                Console.WriteLine(t.Name);
        }

        [Kept]
        class Foo
        {
            class C
            {
            }
        }
    }
}