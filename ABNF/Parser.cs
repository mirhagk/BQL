/* -----------------------------------------------------------------------------
 * Parser.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Thu Feb 26 09:51:29 EST 2015
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

public class Parser
{
  private Parser() {}

  static public void Main(String[] args)
  {
    Dictionary<String, String> arguments = new Dictionary<String, String>();
    String error = "";
    bool ok = args.Length > 0;

    if (ok)
    {
      arguments["Trace"] = "Off";
      arguments["Rule"] = "Root";

      for (int i = 0; i < args.Length; i++)
      {
        if (args[i].Equals("-trace"))
          arguments["Trace"] = "On";
        else if (args[i].Equals("-visitor"))
          arguments["Visitor"] = args[++i];
        else if (args[i].Equals("-file"))
          arguments["File"] = args[++i];
        else if (args[i].Equals("-string"))
          arguments["String"] = args[++i];
        else if (args[i].Equals("-rule"))
          arguments["Rule"] = args[++i];
        else
        {
          error = "unknown argument: " + args[i];
          ok = false;
        }
      }
    }

    if (ok)
    {
      if (!arguments.ContainsKey("File") &&
          !arguments.ContainsKey("String"))
      {
        error = "insufficient arguments: -file or -string required";
        ok = false;
      }
    }

    if (!ok)
    {
      System.Console.WriteLine("error: " + error);
      System.Console.WriteLine("usage: Parser [-rule rulename] [-trace] <-file file | -string string> [-visitor visitor]");
    }
    else
    {
      try
      {
        Rule rule = null;

        if (arguments.ContainsKey("File"))
        {
          rule = 
            Parse(
              arguments["Rule"], 
              new FileStream(arguments["File"], FileMode.Open), 
              arguments["Trace"].Equals("On"));
        }
        else if (arguments.ContainsKey("String"))
        {
          rule = 
            Parse(
              arguments["Rule"], 
              arguments["String"], 
              arguments["Trace"].Equals("On"));
        }

        if (arguments.ContainsKey("Visitor"))
        {
          Type type = Type.GetType(arguments["Visitor"]);

          if (type == null)
          {
            System.Console.WriteLine(
              "visitor error: class not found - " + 
              arguments["Visitor"]);
          }
          else
          {
            Visitor visitor = (Visitor)System.Activator.CreateInstance(type);

            rule.Accept(visitor);
          }
        }
      }
      catch (ArgumentException e)
      {
        System.Console.WriteLine("argument error: " + e.Message);
      }
      catch (IOException e)
      {
        System.Console.WriteLine("io error: " + e.Message);
      }
      catch (ParserException e)
      {
        System.Console.WriteLine("parser error: " + e.Message);
      }
      catch (Exception e)
      {
        System.Console.WriteLine("error: " + e.Message);
      }
    }
  }

  static public Rule Parse(String rulename, String text)
  {
    return Parse(rulename, text, false);
  }

  static public Rule Parse(String rulename, StreamReader input)
  {
    return Parse(rulename, input, false);
  }

  static public Rule Parse(String rulename, FileStream file)
  {
    return Parse(rulename, file, false);
  }

  static private Rule Parse(String rulename, String text, bool trace)
  {
    if (rulename == null)
      throw new ArgumentNullException("null rulename");
    if (text == null)
      throw new ArgumentException("null string");

    ParserContext context = new ParserContext(text, trace);

    Rule rule = null;
    if (rulename.ToLower().Equals("Root".ToLower())) rule = Rule_Root.Parse(context);
    else if (rulename.ToLower().Equals("stmtLine".ToLower())) rule = Rule_stmtLine.Parse(context);
    else if (rulename.ToLower().Equals("stmtList".ToLower())) rule = Rule_stmtList.Parse(context);
    else if (rulename.ToLower().Equals("id".ToLower())) rule = Rule_id.Parse(context);
    else if (rulename.ToLower().Equals("stmt".ToLower())) rule = Rule_stmt.Parse(context);
    else if (rulename.ToLower().Equals("createTableStmt".ToLower())) rule = Rule_createTableStmt.Parse(context);
    else if (rulename.ToLower().Equals("tableDefList".ToLower())) rule = Rule_tableDefList.Parse(context);
    else if (rulename.ToLower().Equals("fieldDef".ToLower())) rule = Rule_fieldDef.Parse(context);
    else if (rulename.ToLower().Equals("typeName".ToLower())) rule = Rule_typeName.Parse(context);
    else if (rulename.ToLower().Equals("typeParams".ToLower())) rule = Rule_typeParams.Parse(context);
    else if (rulename.ToLower().Equals("nullOpt".ToLower())) rule = Rule_nullOpt.Parse(context);
    else if (rulename.ToLower().Equals("constraintDef".ToLower())) rule = Rule_constraintDef.Parse(context);
    else if (rulename.ToLower().Equals("constraintTypeOpt".ToLower())) rule = Rule_constraintTypeOpt.Parse(context);
    else if (rulename.ToLower().Equals("idListPar".ToLower())) rule = Rule_idListPar.Parse(context);
    else if (rulename.ToLower().Equals("idList".ToLower())) rule = Rule_idList.Parse(context);
    else if (rulename.ToLower().Equals("constraintType".ToLower())) rule = Rule_constraintType.Parse(context);
    else if (rulename.ToLower().Equals("dot".ToLower())) rule = Rule_dot.Parse(context);
    else if (rulename.ToLower().Equals("comma".ToLower())) rule = Rule_comma.Parse(context);
    else if (rulename.ToLower().Equals("idSimple".ToLower())) rule = Rule_idSimple.Parse(context);
    else if (rulename.ToLower().Equals("number".ToLower())) rule = Rule_number.Parse(context);
    else if (rulename.ToLower().Equals("CREATE".ToLower())) rule = Rule_CREATE.Parse(context);
    else if (rulename.ToLower().Equals("TABLE".ToLower())) rule = Rule_TABLE.Parse(context);
    else if (rulename.ToLower().Equals("NULL".ToLower())) rule = Rule_NULL.Parse(context);
    else if (rulename.ToLower().Equals("NOT".ToLower())) rule = Rule_NOT.Parse(context);
    else if (rulename.ToLower().Equals("CONSTRAINT".ToLower())) rule = Rule_CONSTRAINT.Parse(context);
    else if (rulename.ToLower().Equals("PRIMARY".ToLower())) rule = Rule_PRIMARY.Parse(context);
    else if (rulename.ToLower().Equals("KEY".ToLower())) rule = Rule_KEY.Parse(context);
    else if (rulename.ToLower().Equals("UNIQUE".ToLower())) rule = Rule_UNIQUE.Parse(context);
    else if (rulename.ToLower().Equals("INDEX".ToLower())) rule = Rule_INDEX.Parse(context);
    else if (rulename.ToLower().Equals("ON".ToLower())) rule = Rule_ON.Parse(context);
    else if (rulename.ToLower().Equals("WITH".ToLower())) rule = Rule_WITH.Parse(context);
    else if (rulename.ToLower().Equals("ALTER".ToLower())) rule = Rule_ALTER.Parse(context);
    else if (rulename.ToLower().Equals("ADD".ToLower())) rule = Rule_ADD.Parse(context);
    else if (rulename.ToLower().Equals("COLUMN".ToLower())) rule = Rule_COLUMN.Parse(context);
    else if (rulename.ToLower().Equals("DROP".ToLower())) rule = Rule_DROP.Parse(context);
    else if (rulename.ToLower().Equals("INSERT".ToLower())) rule = Rule_INSERT.Parse(context);
    else if (rulename.ToLower().Equals("INTO".ToLower())) rule = Rule_INTO.Parse(context);
    else if (rulename.ToLower().Equals("VALUES".ToLower())) rule = Rule_VALUES.Parse(context);
    else if (rulename.ToLower().Equals("UPDATE".ToLower())) rule = Rule_UPDATE.Parse(context);
    else if (rulename.ToLower().Equals("SET".ToLower())) rule = Rule_SET.Parse(context);
    else if (rulename.ToLower().Equals("DELETE".ToLower())) rule = Rule_DELETE.Parse(context);
    else if (rulename.ToLower().Equals("FROM".ToLower())) rule = Rule_FROM.Parse(context);
    else if (rulename.ToLower().Equals("SELECT".ToLower())) rule = Rule_SELECT.Parse(context);
    else if (rulename.ToLower().Equals("AS".ToLower())) rule = Rule_AS.Parse(context);
    else if (rulename.ToLower().Equals("COUNT".ToLower())) rule = Rule_COUNT.Parse(context);
    else if (rulename.ToLower().Equals("JOIN".ToLower())) rule = Rule_JOIN.Parse(context);
    else if (rulename.ToLower().Equals("BY".ToLower())) rule = Rule_BY.Parse(context);
    else if (rulename.ToLower().Equals("PROJECTION".ToLower())) rule = Rule_PROJECTION.Parse(context);
    else if (rulename.ToLower().Equals("REFERENCES".ToLower())) rule = Rule_REFERENCES.Parse(context);
    else if (rulename.ToLower().Equals("FOREIGN".ToLower())) rule = Rule_FOREIGN.Parse(context);
    else throw new ArgumentException("unknown rule");

    if (rule == null)
    {
      throw new ParserException(
        "rule \"" + (String)context.GetErrorStack().Peek() + "\" failed",
        context.text,
        context.GetErrorIndex(),
        context.GetErrorStack());
    }

    if (context.text.Length > context.index)
    {
      ParserException primaryError = 
        new ParserException(
          "extra data found",
          context.text,
          context.index,
          new Stack<String>());

      if (context.GetErrorIndex() > context.index)
      {
        ParserException secondaryError = 
          new ParserException(
            "rule \"" + (String)context.GetErrorStack().Peek() + "\" failed",
            context.text,
            context.GetErrorIndex(),
            context.GetErrorStack());

        primaryError.SetCause(secondaryError);
      }

      throw primaryError;
    }

    return rule;
  }

  static private Rule Parse(String rulename, StreamReader input, bool trace)
  {
    if (rulename == null)
      throw new ArgumentNullException("null rulename");
    if (input == null)
      throw new ArgumentNullException("null input stream");

    int ch = 0;
    StringBuilder output = new StringBuilder();
    while ((ch = input.Read()) != -1)
      output.Append((char)ch);

    return Parse(rulename, output.ToString(), trace);
  }

  static private Rule Parse(String rulename, FileStream file, bool trace)
  {
    if (rulename == null)
      throw new ArgumentNullException("null rulename");
    if (file == null)
      throw new ArgumentNullException("null file");

    StreamReader input = new StreamReader(file);
    int ch = 0;
    StringBuilder output = new StringBuilder();
    while ((ch = input.Read()) != -1)
      output.Append((char)ch);

    input.Close();

    return Parse(rulename, output.ToString(), trace);
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
