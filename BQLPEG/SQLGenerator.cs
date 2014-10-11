using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BQLPEG.Nodes;

namespace BQLPEG
{
    class SQLGenerator
    {
        public string GenerateSQL(IEnumerable<Nodes.StatementNode> statements)
        {
            string result = "";
            foreach(var statement in statements)
            {
                result = GenerateSQL(statement);
            }
            return result;
        }

        private string GenerateSQL(StatementNode statement)
        {
            var goStatement = statement as GoStatementNode;
            var createTableStatement = statement as CreateTableNode;
            if (goStatement != null)
                return "GO";
            if (createTableStatement != null)
            {
                return string.Format("CREATE TABLE {0} ({1})", createTableStatement.Name, GenerateSQL(createTableStatement.Fields));
            }
            throw new ArgumentException(string.Format("Did not understand statement of type ", statement.GetType()));
        }

        private string GenerateSQL(IEnumerable<FieldNode> fields)
        {
            return string.Join(", ", fields.Select(field =>
            {
                string fieldResult = field.Name + " " + field.Type;
                if (field.TypeParams != null && field.TypeParams.Any())
                    fieldResult += "(" + string.Join(",", field.TypeParams) + ")";
                fieldResult += field.Nullable ? " NULL" : " NOT NULL";
                return fieldResult;
            }));
        }
    }
}
