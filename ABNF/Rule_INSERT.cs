/* -----------------------------------------------------------------------------
 * Rule_INSERT.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Thu Feb 26 09:51:29 EST 2015
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

sealed public class Rule_INSERT:Rule
{
  private Rule_INSERT(String spelling, List<Rule> rules) :
  base(spelling, rules)
  {
  }

  public override Object Accept(Visitor visitor)
  {
    return visitor.Visit(this);
  }

  public static Rule_INSERT Parse(ParserContext context)
  {
    context.Push("INSERT");

    Rule rule;
    bool parsed = true;
    ParserAlternative b;
    int s0 = context.index;
    ParserAlternative a0 = new ParserAlternative(s0);

    List<ParserAlternative> as1 = new List<ParserAlternative>();
    parsed = false;
    {
      int s1 = context.index;
      ParserAlternative a1 = new ParserAlternative(s1);
      parsed = true;
      if (parsed)
      {
        bool f1 = true;
        int c1 = 0;
        for (int i1 = 0; i1 < 1 && f1; i1++)
        {
          rule = Terminal_StringValue.Parse(context, "INSERT");
          if ((f1 = rule != null))
          {
            a1.Add(rule, context.index);
            c1++;
          }
        }
        parsed = c1 == 1;
      }
      if (parsed)
      {
        as1.Add(a1);
      }
      context.index = s1;
    }

    b = ParserAlternative.GetBest(as1);

    parsed = b != null;

    if (parsed)
    {
      a0.Add(b.rules, b.end);
      context.index = b.end;
    }

    rule = null;
    if (parsed)
    {
        rule = new Rule_INSERT(context.text.Substring(a0.start, a0.end - a0.start), a0.rules);
    }
    else
    {
        context.index = s0;
    }

    context.Pop("INSERT", parsed);

    return (Rule_INSERT)rule;
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
