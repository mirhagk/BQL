/* -----------------------------------------------------------------------------
 * Visitor.cs
 * -----------------------------------------------------------------------------
 *
 * Producer : com.parse2.aparse.Parser 2.5
 * Produced : Thu Feb 26 09:51:29 EST 2015
 *
 * -----------------------------------------------------------------------------
 */

using System;

public interface Visitor
{
  Object Visit(Rule_Root rule);
  Object Visit(Rule_stmtLine rule);
  Object Visit(Rule_stmtList rule);
  Object Visit(Rule_id rule);
  Object Visit(Rule_stmt rule);
  Object Visit(Rule_createTableStmt rule);
  Object Visit(Rule_tableDefList rule);
  Object Visit(Rule_fieldDef rule);
  Object Visit(Rule_typeName rule);
  Object Visit(Rule_typeParams rule);
  Object Visit(Rule_nullOpt rule);
  Object Visit(Rule_constraintDef rule);
  Object Visit(Rule_constraintTypeOpt rule);
  Object Visit(Rule_idListPar rule);
  Object Visit(Rule_idList rule);
  Object Visit(Rule_constraintType rule);
  Object Visit(Rule_dot rule);
  Object Visit(Rule_comma rule);
  Object Visit(Rule_idSimple rule);
  Object Visit(Rule_number rule);
  Object Visit(Rule_CREATE rule);
  Object Visit(Rule_TABLE rule);
  Object Visit(Rule_NULL rule);
  Object Visit(Rule_NOT rule);
  Object Visit(Rule_CONSTRAINT rule);
  Object Visit(Rule_PRIMARY rule);
  Object Visit(Rule_KEY rule);
  Object Visit(Rule_UNIQUE rule);
  Object Visit(Rule_INDEX rule);
  Object Visit(Rule_ON rule);
  Object Visit(Rule_WITH rule);
  Object Visit(Rule_ALTER rule);
  Object Visit(Rule_ADD rule);
  Object Visit(Rule_COLUMN rule);
  Object Visit(Rule_DROP rule);
  Object Visit(Rule_INSERT rule);
  Object Visit(Rule_INTO rule);
  Object Visit(Rule_VALUES rule);
  Object Visit(Rule_UPDATE rule);
  Object Visit(Rule_SET rule);
  Object Visit(Rule_DELETE rule);
  Object Visit(Rule_FROM rule);
  Object Visit(Rule_SELECT rule);
  Object Visit(Rule_AS rule);
  Object Visit(Rule_COUNT rule);
  Object Visit(Rule_JOIN rule);
  Object Visit(Rule_BY rule);
  Object Visit(Rule_PROJECTION rule);
  Object Visit(Rule_REFERENCES rule);
  Object Visit(Rule_FOREIGN rule);

  Object Visit(Terminal_StringValue value);
  Object Visit(Terminal_NumericValue value);
}

/* -----------------------------------------------------------------------------
 * eof
 * -----------------------------------------------------------------------------
 */
