using System;
using Microsoft.Scripting.Hosting;

namespace InteropConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = IronRuby.Ruby.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            engine.Execute("require 'factories.rb'", scope);
            for (int i = 0; i < 20; i++)
            {
                dynamic user = engine.Execute<FactoryGirlSpike.Poco.User>("u = Factory.build(:user)", scope);
                Console.WriteLine(user);
            }
        }
    }
}
