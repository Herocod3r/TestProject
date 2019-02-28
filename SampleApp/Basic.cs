using System;
namespace SampleApp
{
    public static class Basic
    {
        public static int Count { get; set; }


        public static TService ResolveService<TService>()
        {
          

            return Refit.RestService.For<TService>("http://my-json-server.typicode.com/herocod3r/testproject");
        }

    }
}
