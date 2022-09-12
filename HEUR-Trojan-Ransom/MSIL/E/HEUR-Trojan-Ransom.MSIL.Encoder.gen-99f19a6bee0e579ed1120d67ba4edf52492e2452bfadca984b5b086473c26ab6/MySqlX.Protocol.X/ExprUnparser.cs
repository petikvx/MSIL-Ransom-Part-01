using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace MySqlX.Protocol.X;

internal class ExprUnparser
{
	private static HashSet<string> infixOperators;

	static ExprUnparser()
	{
		infixOperators = new HashSet<string>();
		infixOperators.Add("and");
		infixOperators.Add("or");
	}

	private static string ScalarToString(Scalar e)
	{
		switch (e.Type)
		{
		case Scalar.Types.Type.VSint:
			return string.Concat(e.VSignedInt);
		case Scalar.Types.Type.VNull:
			return "NULL";
		case Scalar.Types.Type.VOctets:
			return "\"" + EscapeLiteral(e.VOctets.Value.ToStringUtf8()) + "\"";
		case Scalar.Types.Type.VDouble:
			return e.VDouble.ToString();
		default:
			throw new ArgumentException("Unknown type tag: " + e.Type);
		case Scalar.Types.Type.VBool:
			if (!e.VBool)
			{
				return "FALSE";
			}
			return "TRUE";
		case Scalar.Types.Type.VString:
			return "\"" + EscapeLiteral(e.VString.Value.ToStringUtf8()) + "\"";
		}
	}

	private static string DocumentPathToString(IList<DocumentPathItem> items)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (DocumentPathItem item in items)
		{
			switch (item.Type)
			{
			case DocumentPathItem.Types.Type.Member:
				stringBuilder.Append(".").Append(QuoteDocumentPathMember(item.Value));
				break;
			case DocumentPathItem.Types.Type.MemberAsterisk:
				stringBuilder.Append(".*");
				break;
			case DocumentPathItem.Types.Type.ArrayIndex:
				stringBuilder.Append("[").Append(string.Concat(item.Index)).Append("]");
				break;
			case DocumentPathItem.Types.Type.ArrayIndexAsterisk:
				stringBuilder.Append("[*]");
				break;
			case DocumentPathItem.Types.Type.DoubleAsterisk:
				stringBuilder.Append("**");
				break;
			}
		}
		return stringBuilder.ToString();
	}

	private static string ColumnIdentifierToString(ColumnIdentifier e)
	{
		string text = QuoteIdentifier(e.Name);
		if (!string.IsNullOrEmpty(e.TableName))
		{
			text = QuoteIdentifier(e.TableName) + "." + text;
		}
		if (!string.IsNullOrEmpty(e.SchemaName))
		{
			text = QuoteIdentifier(e.SchemaName) + "." + text;
		}
		if (e.DocumentPath.Count > 0)
		{
			text = text + "$" + DocumentPathToString(e.DocumentPath);
		}
		return text;
	}

	private static string FunctionCallToString(FunctionCall e)
	{
		Identifier name = e.Name;
		string text = QuoteIdentifier(name.Name);
		if (!string.IsNullOrEmpty(name.SchemaName))
		{
			text = QuoteIdentifier(name.SchemaName) + "." + text;
		}
		text += "(";
		foreach (Expr item in e.Param)
		{
			text = text + ExprToString(item) + ", ";
		}
		text = Regex.Replace(text, ", $", "");
		return text + ")";
	}

	private static string ParamListToString(List<string> parameters)
	{
		string text = "(";
		bool flag = true;
		foreach (string parameter in parameters)
		{
			if (!flag)
			{
				text += ", ";
			}
			flag = false;
			text += parameter;
		}
		return text + ")";
	}

	private static string OperatorToString(Operator e)
	{
		string name = e.Name;
		List<string> list = new List<string>();
		foreach (Expr item in e.Param)
		{
			list.Add(ExprToString(item));
		}
		if (!"between".Equals(name) && !"not_between".Equals(name))
		{
			if (!"in".Equals(name) && !"not_in".Equals(name))
			{
				if (!"like".Equals(name) && !"not_like".Equals(name))
				{
					if (!"regexp".Equals(name) && !"not_regexp".Equals("name"))
					{
						if ("cast".Equals(name))
						{
							return string.Format("cast({0} AS {1})", list[0], list[1].Replace("\"", ""));
						}
						if ((name.Length < 3 || infixOperators.Contains(name)) && list.Count == 2)
						{
							return $"({list[0]} {name} {list[1]})";
						}
						if (list.Count == 1)
						{
							return $"{name}{list[0]}";
						}
						if (list.Count == 0)
						{
							return name;
						}
						return name + ParamListToString(list);
					}
					name = name.Replace("not_regexp", "not regexp");
					return $"({list[0]} {name} {list[1]})";
				}
				name = name.Replace("not_like", "not like");
				string text = $"{list[0]} {name} {list[1]}";
				if (list.Count == 3)
				{
					text = text + " ESCAPE " + list[2];
				}
				return text;
			}
			name = name.Replace("not_in", "not in");
			return $"{list[0]} {name}{ParamListToString(list.GetRange(1, list.Count - 1))}";
		}
		name = name.Replace("not_between", "not between");
		return $"({list[0]} {name} {list[1]} AND {list[2]})";
	}

	private static string ObjectToString(Mysqlx.Expr.Object o)
	{
		IEnumerable<string> values = o.Fld.Select((Mysqlx.Expr.Object.Types.ObjectField f) => $"'{QuoteJsonKey(f.Key)}':{ExprToString(f.Value)}");
		return "{" + string.Join(", ", values) + "}";
	}

	public static string EscapeLiteral(string s)
	{
		return s.Replace("\"", "\"\"");
	}

	public static string QuoteIdentifier(string ident)
	{
		if (!ident.Contains("`") && !ident.Contains("\"") && !ident.Contains("'") && !ident.Contains("$") && !ident.Contains("."))
		{
			return ident;
		}
		return "`" + ident.Replace("`", "``") + "`";
	}

	public static string QuoteJsonKey(string key)
	{
		return key.Replace("'", "\\\\'");
	}

	public static string QuoteDocumentPathMember(string member)
	{
		if (!Regex.IsMatch(member, "[a-zA-Z0-9_]*"))
		{
			return "\"" + member.Replace("\"", "\\\\\"") + "\"";
		}
		return member;
	}

	public static string ExprToString(Expr e)
	{
		return e.Type switch
		{
			Expr.Types.Type.Ident => ColumnIdentifierToString(e.Identifier), 
			Expr.Types.Type.Literal => ScalarToString(e.Literal), 
			Expr.Types.Type.Variable => "@" + QuoteIdentifier(e.Variable), 
			Expr.Types.Type.FuncCall => FunctionCallToString(e.FunctionCall), 
			Expr.Types.Type.Operator => OperatorToString(e.Operator), 
			Expr.Types.Type.Placeholder => ":" + e.Position, 
			Expr.Types.Type.Object => ObjectToString(e.Object), 
			_ => throw new ArgumentException("Unknown type tag: " + e.Type), 
		};
	}
}
