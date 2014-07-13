using System.Collections.Generic;

namespace AppVeyorToNuGetSample
{
    public static class Foo
    {
        public static IEnumerable<string> Bar(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    yield return "FooBar";
                }
                if (i % 3 == 0)
                {
                    yield return "Foo";
                }
                else if (i % 5 == 0)
                {
                    yield return "Bar";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}
