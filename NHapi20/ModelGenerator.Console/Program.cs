using System;

namespace ModelGenerator.Standard
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Args.Configuration.Configure<ModelBuilder>().CreateAndBind(args);

            command.Execute();


            Console.Read();
        }
    }
}
