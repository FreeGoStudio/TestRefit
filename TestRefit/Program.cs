using Refit;
using Serilog;
using System;
using System.Threading.Tasks;
using TestRefit.Service;

namespace TestRefit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //日志
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .MinimumLevel.Verbose()
            .CreateLogger();

            //使用Refit内置的RestService
            var theCatAPI = RestService.For<ITheCatAPI>("https://api.thecatapi.com/");
            //调用接口,接收结果
            var searchResult = await theCatAPI.Search("bengal");

            //打印日志
            Log.Debug("{results}", searchResult);
            Console.ReadKey();
        }
    }
}
