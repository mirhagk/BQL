/* -----------------------------------------------------------------------------
 * XmlDisplayer.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Thu Feb 26 09:51:29 EST 2015
 *
 * -----------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;

public class XmlDisplayer:Visitor
{
  private bool terminal = true;

  public Object Visit(Rule_Root rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<Root>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</Root>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_stmtLine rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<stmtLine>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</stmtLine>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_stmtList rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<stmtList>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</stmtList>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_id rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<id>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</id>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_stmt rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<stmt>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</stmt>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_createTableStmt rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<createTableStmt>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</createTableStmt>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_tableDefList rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<tableDefList>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</tableDefList>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_fieldDef rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<fieldDef>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</fieldDef>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_typeName rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<typeName>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</typeName>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_typeParams rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<typeParams>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</typeParams>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_nullOpt rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<nullOpt>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</nullOpt>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_constraintDef rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<constraintDef>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</constraintDef>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_constraintTypeOpt rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<constraintTypeOpt>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</constraintTypeOpt>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_idListPar rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<idListPar>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</idListPar>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_idList rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<idList>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</idList>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_constraintType rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<constraintType>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</constraintType>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_dot rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<dot>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</dot>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_comma rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<comma>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</comma>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_idSimple rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<idSimple>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</idSimple>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_number rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<number>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</number>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_CREATE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<CREATE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</CREATE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_TABLE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<TABLE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</TABLE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_NULL rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<NULL>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</NULL>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_NOT rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<NOT>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</NOT>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_CONSTRAINT rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<CONSTRAINT>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</CONSTRAINT>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_PRIMARY rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<PRIMARY>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</PRIMARY>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_KEY rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<KEY>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</KEY>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_UNIQUE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<UNIQUE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</UNIQUE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_INDEX rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<INDEX>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</INDEX>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_ON rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<ON>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</ON>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_WITH rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<WITH>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</WITH>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_ALTER rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<ALTER>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</ALTER>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_ADD rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<ADD>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</ADD>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_COLUMN rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<COLUMN>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</COLUMN>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_DROP rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<DROP>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</DROP>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_INSERT rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<INSERT>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</INSERT>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_INTO rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<INTO>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</INTO>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_VALUES rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<VALUES>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</VALUES>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_UPDATE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<UPDATE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</UPDATE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_SET rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<SET>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</SET>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_DELETE rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<DELETE>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</DELETE>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_FROM rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<FROM>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</FROM>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_SELECT rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<SELECT>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</SELECT>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_AS rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<AS>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</AS>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_COUNT rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<COUNT>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</COUNT>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_JOIN rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<JOIN>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</JOIN>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_BY rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<BY>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</BY>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_PROJECTION rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<PROJECTION>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</PROJECTION>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_REFERENCES rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<REFERENCES>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</REFERENCES>");
    terminal = false;
    return null;
  }

  public Object Visit(Rule_FOREIGN rule)
  {
    if (!terminal) System.Console.WriteLine();
    Console.Write("<FOREIGN>");
    terminal = false;
    VisitRules(rule.rules);
    if (!terminal) System.Console.WriteLine();
    Console.Write("</FOREIGN>");
    terminal = false;
    return null;
  }

  public Object Visit(Terminal_StringValue value)
  {
    Console.Write(value.spelling);
    terminal = true;
    return null;
  }

  public Object Visit(Terminal_NumericValue value)
  {
    Console.Write(value.spelling);
    terminal = true;
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
