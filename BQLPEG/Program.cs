using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQLPEG
{
    class Program
    {
        static bool RunTest(string test, bool debug = false)
        {
            var bql = File.ReadAllText(Path.ChangeExtension(test, ".bql")).ToUpper();
            var sql = File.ReadAllText(Path.ChangeExtension(test, ".sql"));
            var parser = new Grammar();
            var generator = new SQLGenerator();
            try
            {
                var parseResult = parser.Parse(bql);
                var testSQL = generator.GenerateSQL(parseResult);
                var result = string.Compare(testSQL, sql, StringComparison.OrdinalIgnoreCase) == 0;
                if (!debug || result)
                    return result;
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(parseResult,Newtonsoft.Json.Formatting.Indented));
                Console.WriteLine("Expected:\n" + sql);
                Console.WriteLine("Actual:\n"+ testSQL);
                return result;
            }
            catch (FormatException ex)
            {
                if (debug)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }
            catch (Exception ex)
            {
                if (debug)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }
        }
        static void RunAllTests()
        {
            int passed = 0;
            int total = 0;
            foreach(var test in Directory.EnumerateFiles("tests","*.bql"))
            {
                total++;
                Console.WriteLine("Running test {0}", test);
                var result = RunTest(test, true);
                var consoleColor = Console.ForegroundColor;
                if (result)
                {
                    passed++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failed");
                }
                Console.WriteLine("===============");
                Console.ForegroundColor = consoleColor;
            }
            Console.WriteLine("All tests concluded, passed {0} out of {1}", passed, total);
        }
        static string testSQL = @"CREATE TABLE Test ( a INT NOT NULL, b INT NULL, c NVARCHAR(50))";
        static void Main(string[] args)
        {
            RunAllTests();
            Console.ReadKey();
            return;
            testSQL = testSQL.ToUpper();
            var grammar = new Grammar();
            var generator = new SQLGenerator();
            Console.WriteLine(testSQL);
            IEnumerable<Nodes.StatementNode> parseResult = null;
            try
            {
                parseResult = grammar.Parse(testSQL);
            }
            catch
            {
                Console.WriteLine("Failed to parse");
            }
            if (parseResult != null)
            {
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(parseResult));
                Console.WriteLine(generator.GenerateSQL(parseResult));
            }
            Console.ReadKey();
        }
    }
}
