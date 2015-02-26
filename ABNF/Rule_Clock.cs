/* -----------------------------------------------------------------------------
 * Rule_Clock.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Wed Feb 25 22:32:20 EST 2015
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

sealed public class Rule_Clock:Rule
{
  private Rule_Clock(String spelling, List<Rule> rules) :
  base(spelling, rules)
  {
  }

  public override Object Accept(Visitor visitor)
  {
    return visitor.Visit(this);
  }

  public static Rule_Clock Parse(ParserContext context)
  {
    context.Push("Clock");

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
          rule = Rule_Hours.Parse(context);
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
        bool f1 = true;
        int c1 = 0;
        for (int i1 = 0; i1 < 1 && f1; i1++)
        {
          rule = Rule_Separator.Parse(context);
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
        bool f1 = true;
        int c1 = 0;
        for (int i1 = 0; i1 < 1 && f1; i1++)
        {
          rule = Rule_Minutes.Parse(context);
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
        bool f1 = true;
        int c1 = 0;
        for (int i1 = 0; i1 < 1 && f1; i1++)
        {
          int g1 = context.index;
          List<ParserAlternative> as2 = new List<ParserAlternative>();
          parsed = false;
          {
            int s2 = context.index;
            ParserAlternative a2 = new ParserAlternative(s2);
            parsed = true;
            if (parsed)
            {
              bool f2 = true;
              int c2 = 0;
              for (int i2 = 0; i2 < 1 && f2; i2++)
              {
                rule = Rule_Separator.Parse(context);
                if ((f2 = rule != null))
                {
                  a2.Add(rule, context.index);
                  c2++;
                }
              }
              parsed = c2 == 1;
            }
            if (parsed)
            {
              bool f2 = true;
              int c2 = 0;
              for (int i2 = 0; i2 < 1 && f2; i2++)
              {
                rule = Rule_Seconds.Parse(context);
                if ((f2 = rule != null))
                {
                  a2.Add(rule, context.index);
                  c2++;
                }
              }
              parsed = c2 == 1;
            }
            if (parsed)
            {
              as2.Add(a2);
            }
            context.index = s2;
          }

          b = ParserAlternative.GetBest(as2);

          parsed = b != null;

          if (parsed)
          {
            a1.Add(b.rules, b.end);
            context.index = b.end;
          }
          f1 = context.index > g1;
          if (parsed) c1++;
        }
        parsed = true;
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
        rule = new Rule_Clock(context.text.Substring(a0.start, a0.end - a0.start), a0.rules);
    }
    else
    {
        context.index = s0;
    }

    context.Pop("Clock", parsed);

    return (Rule_Clock)rule;
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
