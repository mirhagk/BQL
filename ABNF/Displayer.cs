/* -----------------------------------------------------------------------------
 * Displayer.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Thu Feb 26 09:51:29 EST 2015
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

public class Displayer:Visitor
{

  public Object Visit(Rule_Root rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_stmtLine rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_stmtList rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_id rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_stmt rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_createTableStmt rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_tableDefList rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_fieldDef rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_typeName rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_typeParams rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_nullOpt rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_constraintDef rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_constraintTypeOpt rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_idListPar rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_idList rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_constraintType rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_dot rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_comma rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_idSimple rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_number rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_CREATE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_TABLE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_NULL rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_NOT rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_CONSTRAINT rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_PRIMARY rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_KEY rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_UNIQUE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_INDEX rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_ON rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_WITH rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_ALTER rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_ADD rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_COLUMN rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_DROP rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_INSERT rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_INTO rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_VALUES rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_UPDATE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_SET rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_DELETE rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_FROM rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_SELECT rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_AS rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_COUNT rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_JOIN rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_BY rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_PROJECTION rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_REFERENCES rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Rule_FOREIGN rule)
  {
    return VisitRules(rule.rules);
  }

  public Object Visit(Terminal_StringValue value)
  {
    Console.Write(value.spelling);
    return null;
  }

  public Object Visit(Terminal_NumericValue value)
  {
    Console.Write(value.spelling);
    return null;
  }

  private Object VisitRules(List<Rule> rules)
  {
    foreach (Rule rule in rules)
      rule.Accept(this);
    return null;
  }
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
