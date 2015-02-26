/* -----------------------------------------------------------------------------
 * Visitor.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Wed Feb 25 22:32:20 EST 2015
 *
 * -----------------------------------------------------------------------------
 */

using System;

public interface Visitor
{
  Object Visit(Rule_Clock rule);
  Object Visit(Rule_Hours rule);
  Object Visit(Rule_Minutes rule);
  Object Visit(Rule_Seconds rule);
  Object Visit(Rule_Separator rule);

  Object Visit(Terminal_StringValue value);
  Object Visit(Terminal_NumericValue value);
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
