using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQLPEG
{
    class Program
    {
        static string testSQL = @"CREATE TABLE Test ( a INT NOT NULL, b INT NULL, c NVARCHAR(50))";
        static void Main(string[] args)
        {
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
