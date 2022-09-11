using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Mysqlx.Crud;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;

namespace MySqlX.Protocol.X;

internal sealed class ExprParser
{
	public enum TokenType
	{
		NOT,
		AND,
		ANDAND,
		OR,
		OROR,
		XOR,
		IS,
		LPAREN,
		RPAREN,
		LSQBRACKET,
		RSQBRACKET,
		BETWEEN,
		TRUE,
		NULL,
		FALSE,
		IN,
		LIKE,
		INTERVAL,
		REGEXP,
		ESCAPE,
		IDENT,
		LSTRING,
		LNUM_INT,
		LNUM_DOUBLE,
		DOT,
		AT,
		COMMA,
		EQ,
		NE,
		GT,
		GE,
		LT,
		LE,
		BITAND,
		BITOR,
		BITXOR,
		LSHIFT,
		RSHIFT,
		PLUS,
		MINUS,
		STAR,
		SLASH,
		HEX,
		BIN,
		NEG,
		BANG,
		EROTEME,
		MICROSECOND,
		SECOND,
		MINUTE,
		HOUR,
		DAY,
		WEEK,
		MONTH,
		QUARTER,
		YEAR,
		SECOND_MICROSECOND,
		MINUTE_MICROSECOND,
		MINUTE_SECOND,
		HOUR_MICROSECOND,
		HOUR_SECOND,
		HOUR_MINUTE,
		DAY_MICROSECOND,
		DAY_SECOND,
		DAY_MINUTE,
		DAY_HOUR,
		YEAR_MONTH,
		DOUBLESTAR,
		MOD,
		COLON,
		ORDERBY_ASC,
		ORDERBY_DESC,
		AS,
		LCURLY,
		RCURLY,
		DOTSTAR,
		CAST,
		DECIMAL,
		UNSIGNED,
		SIGNED,
		INTEGER,
		DATE,
		TIME,
		DATETIME,
		CHAR,
		BINARY,
		JSON
	}

	internal sealed class Class100
	{
		internal TokenType tokenType_0;

		internal string string_0;

		[NonSerialized]
		internal static GetString getString_0;

		public Class100(TokenType tokenType_1, char char_0)
		{
			tokenType_0 = tokenType_1;
			string_0 = char_0.ToString();
		}

		public Class100(TokenType tokenType_1, string string_1)
		{
			tokenType_0 = tokenType_1;
			string_0 = string_1;
		}

		string object.ToString()
		{
			if (tokenType_0 != TokenType.IDENT && tokenType_0 != TokenType.LNUM_INT && tokenType_0 != TokenType.LNUM_DOUBLE && tokenType_0 != TokenType.LSTRING)
			{
				return tokenType_0.ToString();
			}
			return tokenType_0.ToString() + getString_0(107409308) + string_0 + getString_0(107409303);
		}

		static Class100()
		{
			Strings.CreateGetStringDelegate(typeof(Class100));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397931), getString_0(107397926)).Replace(getString_0(107397889), getString_0(107397884)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397879)))
			{
				throw new SecurityException(getString_0(107397854));
			}
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	[CompilerGenerated]
	private sealed class Class101
	{
		public Mysqlx.Expr.Array array_0;

		internal void method_0(Expr expr_0)
		{
			array_0.Value.Add(expr_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class102
	{
		public Mysqlx.Expr.Object object_0;

		internal void method_0(Mysqlx.Expr.Object.Types.ObjectField objectField_0)
		{
			object_0.Fld.Add(objectField_0);
		}
	}

	private string string_0;

	internal List<Class100> list_0 = new List<Class100>();

	private int int_0;

	internal Dictionary<string, int> dictionary_0 = new Dictionary<string, int>();

	internal int int_1;

	private bool bool_0;

	private static Dictionary<string, TokenType> dictionary_1;

	[NonSerialized]
	internal static GetString getString_0;

	public ExprParser(string s)
		: this(s, allowRelationalColumns: true)
	{
	}

	public ExprParser(string s, bool allowRelationalColumns)
	{
		string_0 = s;
		method_2();
		bool_0 = allowRelationalColumns;
	}

	static ExprParser()
	{
		Strings.CreateGetStringDelegate(typeof(ExprParser));
		dictionary_1 = new Dictionary<string, TokenType>();
		dictionary_1.Add(getString_0(107406677), TokenType.AND);
		dictionary_1.Add(getString_0(107406672), TokenType.OR);
		dictionary_1.Add(getString_0(107406667), TokenType.XOR);
		dictionary_1.Add(getString_0(107406630), TokenType.IS);
		dictionary_1.Add(getString_0(107406625), TokenType.NOT);
		dictionary_1.Add(getString_0(107406620), TokenType.LIKE);
		dictionary_1.Add(getString_0(107406643), TokenType.IN);
		dictionary_1.Add(getString_0(107406638), TokenType.REGEXP);
		dictionary_1.Add(getString_0(107406085), TokenType.BETWEEN);
		dictionary_1.Add(getString_0(107406104), TokenType.INTERVAL);
		dictionary_1.Add(getString_0(107406091), TokenType.ESCAPE);
		dictionary_1.Add(getString_0(107406050), TokenType.SLASH);
		dictionary_1.Add(getString_0(107406045), TokenType.HEX);
		dictionary_1.Add(getString_0(107406072), TokenType.BIN);
		dictionary_1.Add(getString_0(107409226), TokenType.TRUE);
		dictionary_1.Add(getString_0(107406067), TokenType.FALSE);
		dictionary_1.Add(getString_0(107408821), TokenType.NULL);
		dictionary_1.Add(getString_0(107406026), TokenType.MICROSECOND);
		dictionary_1.Add(getString_0(107406041), TokenType.SECOND);
		dictionary_1.Add(getString_0(107406032), TokenType.MINUTE);
		dictionary_1.Add(getString_0(107405991), TokenType.HOUR);
		dictionary_1.Add(getString_0(107405982), TokenType.DAY);
		dictionary_1.Add(getString_0(107406009), TokenType.WEEK);
		dictionary_1.Add(getString_0(107406000), TokenType.MONTH);
		dictionary_1.Add(getString_0(107405959), TokenType.QUARTER);
		dictionary_1.Add(getString_0(107405978), TokenType.YEAR);
		dictionary_1.Add(getString_0(107405969), TokenType.SECOND_MICROSECOND);
		dictionary_1.Add(getString_0(107405944), TokenType.MINUTE_MICROSECOND);
		dictionary_1.Add(getString_0(107405887), TokenType.MINUTE_SECOND);
		dictionary_1.Add(getString_0(107405866), TokenType.HOUR_MICROSECOND);
		dictionary_1.Add(getString_0(107405873), TokenType.HOUR_SECOND);
		dictionary_1.Add(getString_0(107406336), TokenType.HOUR_MINUTE);
		dictionary_1.Add(getString_0(107406351), TokenType.DAY_MICROSECOND);
		dictionary_1.Add(getString_0(107406330), TokenType.DAY_SECOND);
		dictionary_1.Add(getString_0(107406281), TokenType.DAY_MINUTE);
		dictionary_1.Add(getString_0(107406296), TokenType.DAY_HOUR);
		dictionary_1.Add(getString_0(107406283), TokenType.YEAR_MONTH);
		dictionary_1.Add(getString_0(107406266), TokenType.ORDERBY_ASC);
		dictionary_1.Add(getString_0(107406261), TokenType.ORDERBY_DESC);
		dictionary_1.Add(getString_0(107406252), TokenType.AS);
		dictionary_1.Add(getString_0(107406215), TokenType.CAST);
		dictionary_1.Add(getString_0(107406206), TokenType.DECIMAL);
		dictionary_1.Add(getString_0(107406225), TokenType.UNSIGNED);
		dictionary_1.Add(getString_0(107406180), TokenType.SIGNED);
		dictionary_1.Add(getString_0(107406171), TokenType.INTEGER);
		dictionary_1.Add(getString_0(107406190), TokenType.DATE);
		dictionary_1.Add(getString_0(107406149), TokenType.TIME);
		dictionary_1.Add(getString_0(107406140), TokenType.DATETIME);
		dictionary_1.Add(getString_0(107406159), TokenType.CHAR);
		dictionary_1.Add(getString_0(107406811), TokenType.BINARY);
		dictionary_1.Add(getString_0(107406118), TokenType.BINARY);
	}

	private bool method_0(int int_2, char char_0)
	{
		if (int_2 + 1 < string_0.Length)
		{
			return string_0[int_2 + 1] == char_0;
		}
		return false;
	}

	private int method_1(int int_2)
	{
		bool flag = true;
		int num = int_2;
		for (; int_2 < string_0.Length; int_2++)
		{
			char c = string_0[int_2];
			switch (c)
			{
			case '.':
				flag = false;
				continue;
			default:
				if (char.IsDigit(c))
				{
					continue;
				}
				break;
			case 'E':
			case 'e':
				flag = false;
				if (method_0(int_2, '-') || method_0(int_2, '+'))
				{
					int_2++;
				}
				continue;
			}
			break;
		}
		if (flag)
		{
			list_0.Add(new Class100(TokenType.LNUM_INT, string_0.Substring(num, int_2 - num)));
		}
		else
		{
			list_0.Add(new Class100(TokenType.LNUM_DOUBLE, string_0.Substring(num, int_2 - num)));
		}
		int_2--;
		return int_2;
	}

	private void method_2()
	{
		for (int i = 0; i < string_0.Length; i++)
		{
			int num = i;
			char c = string_0[i];
			if (char.IsWhiteSpace(c))
			{
				continue;
			}
			if (char.IsDigit(c))
			{
				i = method_1(i);
				continue;
			}
			if (c != '_' && !char.IsLetter(c))
			{
				switch (c)
				{
				case '{':
					list_0.Add(new Class100(TokenType.LCURLY, c));
					break;
				case '|':
					if (method_0(i, '|'))
					{
						i++;
						list_0.Add(new Class100(TokenType.OROR, getString_0(107397314)));
					}
					else
					{
						list_0.Add(new Class100(TokenType.BITOR, c));
					}
					break;
				case '}':
					list_0.Add(new Class100(TokenType.RCURLY, c));
					break;
				case '~':
					list_0.Add(new Class100(TokenType.NEG, c));
					break;
				case '[':
					list_0.Add(new Class100(TokenType.LSQBRACKET, c));
					break;
				case ']':
					list_0.Add(new Class100(TokenType.RSQBRACKET, c));
					break;
				case '^':
					list_0.Add(new Class100(TokenType.BITXOR, c));
					break;
				case '!':
					if (method_0(i, '='))
					{
						i++;
						list_0.Add(new Class100(TokenType.NE, getString_0(107406126)));
					}
					else
					{
						list_0.Add(new Class100(TokenType.BANG, c));
					}
					break;
				case '$':
					list_0.Add(new Class100(TokenType.AT, c));
					break;
				case '%':
					list_0.Add(new Class100(TokenType.MOD, c));
					break;
				case '&':
					if (method_0(i, '&'))
					{
						i++;
						list_0.Add(new Class100(TokenType.ANDAND, getString_0(107406131)));
					}
					else
					{
						list_0.Add(new Class100(TokenType.BITAND, c));
					}
					break;
				case '"':
				case '\'':
				case '`':
				{
					char c2 = c;
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						c = string_0[++i];
						while (c != c2 || (i + 1 < string_0.Length && string_0[i + 1] == c2))
						{
							if (c == '\\' || c == c2)
							{
								i++;
							}
							stringBuilder.Append(string_0[i]);
							c = string_0[++i];
						}
					}
					catch (IndexOutOfRangeException)
					{
						throw new ArgumentException(getString_0(107405584) + num);
					}
					string text = stringBuilder.ToString();
					list_0.Add(new Class100((c2 == '`') ? TokenType.IDENT : TokenType.LSTRING, (text == string.Empty) ? getString_0(107395940) : text));
					break;
				}
				case '(':
					list_0.Add(new Class100(TokenType.LPAREN, c));
					break;
				case ')':
					list_0.Add(new Class100(TokenType.RPAREN, c));
					break;
				case '*':
					if (method_0(i, '*'))
					{
						i++;
						list_0.Add(new Class100(TokenType.DOUBLESTAR, getString_0(107406109)));
					}
					else
					{
						list_0.Add(new Class100(TokenType.STAR, c));
					}
					break;
				case '+':
					list_0.Add(new Class100(TokenType.PLUS, c));
					break;
				case ',':
					list_0.Add(new Class100(TokenType.COMMA, c));
					break;
				case '-':
					list_0.Add(new Class100(TokenType.MINUS, c));
					break;
				case '.':
					if (method_0(i, '*'))
					{
						i++;
						list_0.Add(new Class100(TokenType.DOTSTAR, getString_0(107405589)));
					}
					else if (i + 1 < string_0.Length && char.IsDigit(string_0[i + 1]))
					{
						i = method_1(i);
					}
					else
					{
						list_0.Add(new Class100(TokenType.DOT, c));
					}
					break;
				case '/':
					list_0.Add(new Class100(TokenType.SLASH, c));
					break;
				case ':':
					list_0.Add(new Class100(TokenType.COLON, c));
					break;
				case '<':
					if (method_0(i, '<'))
					{
						i++;
						list_0.Add(new Class100(TokenType.LSHIFT, getString_0(107405577)));
					}
					else if (method_0(i, '='))
					{
						i++;
						list_0.Add(new Class100(TokenType.LE, getString_0(107405572)));
					}
					else
					{
						list_0.Add(new Class100(TokenType.LT, c));
					}
					break;
				case '=':
					if (method_0(i, '='))
					{
						i++;
					}
					list_0.Add(new Class100(TokenType.EQ, getString_0(107406136)));
					break;
				case '>':
					if (method_0(i, '>'))
					{
						i++;
						list_0.Add(new Class100(TokenType.RSHIFT, getString_0(107405567)));
					}
					else if (method_0(i, '='))
					{
						i++;
						list_0.Add(new Class100(TokenType.GE, getString_0(107405594)));
					}
					else
					{
						list_0.Add(new Class100(TokenType.GT, c));
					}
					break;
				case '?':
					list_0.Add(new Class100(TokenType.EROTEME, c));
					break;
				default:
					throw new ArgumentException(getString_0(107405507) + i);
				}
				continue;
			}
			for (; i < string_0.Length && (char.IsLetterOrDigit(string_0[i]) || string_0[i] == '_'); i++)
			{
			}
			string text2 = string_0.Substring(num, i - num);
			string text3 = text2.ToLowerInvariant();
			if (i < string_0.Length)
			{
				i--;
			}
			if (dictionary_1.ContainsKey(text3))
			{
				if (getString_0(107406677).Equals(text3))
				{
					list_0.Add(new Class100(dictionary_1[text3], getString_0(107406131)));
				}
				else if (getString_0(107406672).Equals(text3))
				{
					list_0.Add(new Class100(dictionary_1[text3], getString_0(107397314)));
				}
				else if (method_3(text3, i))
				{
					list_0.Add(new Class100(TokenType.IDENT, text2));
				}
				else
				{
					list_0.Add(new Class100(dictionary_1[text3], text3));
				}
			}
			else
			{
				list_0.Add(new Class100(TokenType.IDENT, text2));
			}
		}
	}

	private bool method_3(string string_1, int int_2)
	{
		Class100 @class = new Class100(dictionary_1[string_1], string_1);
		if (@class.tokenType_0 != TokenType.YEAR && @class.tokenType_0 != TokenType.MONTH && @class.tokenType_0 != TokenType.WEEK && @class.tokenType_0 != TokenType.DAY && @class.tokenType_0 != TokenType.HOUR && @class.tokenType_0 != TokenType.MINUTE && @class.tokenType_0 != TokenType.SECOND && @class.tokenType_0 != TokenType.MICROSECOND && @class.tokenType_0 != TokenType.QUARTER && @class.tokenType_0 != TokenType.TIME && @class.tokenType_0 != TokenType.DATE && @class.tokenType_0 != TokenType.CHAR && @class.tokenType_0 != TokenType.HEX && @class.tokenType_0 != TokenType.BIN)
		{
			return false;
		}
		if (string_0.Length >= int_2 + 2)
		{
			return string_0[int_2 + 1] == '(';
		}
		return false;
	}

	private void method_4(int int_2, TokenType tokenType_0)
	{
		if (list_0.Count <= int_2)
		{
			throw new ArgumentException(string.Concat(getString_0(107405478), tokenType_0, getString_0(107405437), int_2));
		}
		if (list_0[int_2].tokenType_0 != tokenType_0)
		{
			throw new ArgumentException(string.Concat(getString_0(107405416), tokenType_0, getString_0(107405437), int_2));
		}
	}

	private bool method_5(TokenType tokenType_0)
	{
		return method_7(int_0, tokenType_0);
	}

	private bool method_6(TokenType tokenType_0)
	{
		return method_7(int_0 + 1, tokenType_0);
	}

	private bool method_7(int int_2, TokenType tokenType_0)
	{
		if (list_0.Count > int_2)
		{
			return list_0[int_2].tokenType_0 == tokenType_0;
		}
		return false;
	}

	private string method_8(TokenType tokenType_0)
	{
		method_4(int_0, tokenType_0);
		string result = list_0[int_0].string_0;
		int_0++;
		return result;
	}

	private List<Expr> method_9()
	{
		List<Expr> list = new List<Expr>();
		method_8(TokenType.LPAREN);
		if (!method_5(TokenType.RPAREN))
		{
			list.Add(method_30());
			while (method_5(TokenType.COMMA))
			{
				method_8(TokenType.COMMA);
				list.Add(method_30());
			}
		}
		method_8(TokenType.RPAREN);
		return list;
	}

	private Expr method_10()
	{
		Identifier name = method_12();
		FunctionCall functionCall = new FunctionCall();
		functionCall.Name = name;
		functionCall.Param.Add(method_9());
		return new Expr
		{
			Type = Expr.Types.Type.FuncCall,
			FunctionCall = functionCall
		};
	}

	private Expr method_11()
	{
		Operator @operator = new Operator();
		@operator.Name = getString_0(107405419);
		return new Expr
		{
			Type = Expr.Types.Type.Operator,
			Operator = @operator
		};
	}

	private Identifier method_12()
	{
		Identifier identifier = new Identifier();
		method_4(int_0, TokenType.IDENT);
		if (method_6(TokenType.DOT))
		{
			identifier.SchemaName = list_0[int_0].string_0;
			method_8(TokenType.IDENT);
			method_8(TokenType.DOT);
			method_4(int_0, TokenType.IDENT);
		}
		identifier.Name = list_0[int_0].string_0;
		method_8(TokenType.IDENT);
		return identifier;
	}

	private DocumentPathItem method_13()
	{
		method_8(TokenType.DOT);
		Class100 @class = list_0[int_0];
		string value;
		if (method_5(TokenType.IDENT))
		{
			if (!@class.string_0.Equals(ExprUnparser.smethod_8(@class.string_0)))
			{
				throw new ArgumentException(getString_0(107407930) + @class.string_0 + getString_0(107405382));
			}
			method_8(TokenType.IDENT);
			value = @class.string_0;
		}
		else
		{
			if (!method_5(TokenType.LSTRING))
			{
				throw new ArgumentException(getString_0(107405833) + int_0);
			}
			method_8(TokenType.LSTRING);
			value = @class.string_0;
		}
		return new DocumentPathItem
		{
			Type = DocumentPathItem.Class27.Enum9.const_1,
			Value = value
		};
	}

	private DocumentPathItem method_14()
	{
		DocumentPathItem documentPathItem = new DocumentPathItem();
		method_8(TokenType.LSQBRACKET);
		if (method_5(TokenType.STAR))
		{
			method_8(TokenType.STAR);
			method_8(TokenType.RSQBRACKET);
			documentPathItem.Type = DocumentPathItem.Class27.Enum9.const_4;
			return documentPathItem;
		}
		if (!method_5(TokenType.LNUM_INT))
		{
			throw new ArgumentException(getString_0(107405699) + int_0);
		}
		uint index = uint.Parse(list_0[int_0].string_0);
		method_8(TokenType.LNUM_INT);
		method_8(TokenType.RSQBRACKET);
		documentPathItem.Type = DocumentPathItem.Class27.Enum9.const_3;
		documentPathItem.Index = index;
		return documentPathItem;
	}

	internal List<DocumentPathItem> method_15()
	{
		List<DocumentPathItem> list = new List<DocumentPathItem>();
		while (true)
		{
			if (!method_5(TokenType.DOT))
			{
				if (method_5(TokenType.DOTSTAR))
				{
					method_8(TokenType.DOTSTAR);
					list.Add(new DocumentPathItem
					{
						Type = DocumentPathItem.Class27.Enum9.const_2
					});
					continue;
				}
				if (method_5(TokenType.LSQBRACKET))
				{
					list.Add(method_14());
					continue;
				}
				if (!method_5(TokenType.DOUBLESTAR))
				{
					break;
				}
				method_8(TokenType.DOUBLESTAR);
				list.Add(new DocumentPathItem
				{
					Type = DocumentPathItem.Class27.Enum9.const_5
				});
			}
			else
			{
				list.Add(method_13());
			}
		}
		if (list.Count > 0 && list[list.Count - 1].Type == DocumentPathItem.Class27.Enum9.const_5)
		{
			throw new ArgumentException(getString_0(107405598) + int_0);
		}
		return list;
	}

	internal Expr method_16()
	{
		ColumnIdentifier columnIdentifier = new ColumnIdentifier();
		if (method_5(TokenType.IDENT))
		{
			columnIdentifier.DocumentPath.Add(new DocumentPathItem
			{
				Type = DocumentPathItem.Class27.Enum9.const_1,
				Value = method_8(TokenType.IDENT)
			});
		}
		columnIdentifier.DocumentPath.Add(method_15());
		return new Expr
		{
			Type = Expr.Types.Type.Ident,
			Identifier = columnIdentifier
		};
	}

	private Expr method_17()
	{
		List<string> list = new List<string>();
		list.Add(method_8(TokenType.IDENT));
		while (method_5(TokenType.DOT))
		{
			method_8(TokenType.DOT);
			list.Add(method_8(TokenType.IDENT));
			if (list.Count == 3)
			{
				break;
			}
		}
		list.Reverse();
		ColumnIdentifier columnIdentifier = new ColumnIdentifier();
		for (int i = 0; i < list.Count; i++)
		{
			switch (i)
			{
			case 0:
				columnIdentifier.Name = list[0];
				break;
			case 1:
				columnIdentifier.TableName = list[1];
				break;
			case 2:
				columnIdentifier.SchemaName = list[2];
				break;
			}
		}
		if (method_5(TokenType.AT))
		{
			method_8(TokenType.AT);
			columnIdentifier.DocumentPath.Add(method_15());
			if (columnIdentifier.DocumentPath.Count == 0)
			{
				throw new ArgumentException(getString_0(107405073) + int_0);
			}
		}
		return new Expr
		{
			Type = Expr.Types.Type.Ident,
			Identifier = columnIdentifier
		};
	}

	private Expr method_18(string string_1, Expr expr_0)
	{
		Operator @operator = new Operator();
		@operator.Name = string_1;
		@operator.Param.Add(expr_0);
		return new Expr
		{
			Type = Expr.Types.Type.Operator,
			Operator = @operator
		};
	}

	private Expr method_19()
	{
		if (int_0 >= list_0.Count)
		{
			throw new ArgumentException(getString_0(107405036) + int_0);
		}
		Class100 @class = list_0[int_0];
		int_0++;
		switch (@class.tokenType_0)
		{
		case TokenType.PLUS:
		case TokenType.MINUS:
			if (!method_5(TokenType.LNUM_INT) && !method_5(TokenType.LNUM_DOUBLE))
			{
				return method_18(@class.string_0, method_19());
			}
			list_0[int_0].string_0 = @class.string_0 + list_0[int_0].string_0;
			return method_19();
		case TokenType.STAR:
			return method_11();
		case TokenType.LPAREN:
		{
			Expr result = method_30();
			method_8(TokenType.RPAREN);
			return result;
		}
		case TokenType.LSQBRACKET:
		{
			Mysqlx.Expr.Array array_0 = new Mysqlx.Expr.Array();
			method_32(() => method_30()).ForEach(delegate(Expr expr_0)
			{
				array_0.Value.Add(expr_0);
			});
			method_8(TokenType.RSQBRACKET);
			return new Expr
			{
				Type = Expr.Types.Type.Array,
				Array = array_0
			};
		}
		case TokenType.NULL:
			return Class103.smethod_0();
		case TokenType.TRUE:
		case TokenType.FALSE:
			return Class103.smethod_6(@class.tokenType_0 == TokenType.TRUE);
		case TokenType.IDENT:
			int_0--;
			if (!method_6(TokenType.LPAREN) && (!method_7(int_0 + 1, TokenType.DOT) || !method_7(int_0 + 2, TokenType.IDENT) || !method_7(int_0 + 3, TokenType.LPAREN)))
			{
				if (bool_0)
				{
					return method_17();
				}
				return method_16();
			}
			return method_10();
		case TokenType.LSTRING:
			return Class103.smethod_4(@class.string_0);
		case TokenType.LNUM_INT:
			return Class103.smethod_2(long.Parse(@class.string_0));
		case TokenType.LNUM_DOUBLE:
			return Class103.smethod_1(double.Parse(@class.string_0));
		case TokenType.AT:
			return method_16();
		case TokenType.NOT:
		case TokenType.NEG:
		case TokenType.BANG:
			return method_18(@class.string_0, method_19());
		default:
			throw new ArgumentException(getString_0(107404833) + (int_0 - 1));
		case TokenType.CAST:
		{
			method_8(TokenType.LPAREN);
			Operator @operator = new Operator();
			@operator.Name = TokenType.CAST.ToString().ToLowerInvariant();
			@operator.Param.Add(method_30());
			method_8(TokenType.AS);
			StringBuilder stringBuilder = new StringBuilder(list_0[int_0].string_0.ToUpperInvariant());
			if (method_5(TokenType.DECIMAL))
			{
				int_0++;
				if (method_5(TokenType.LPAREN))
				{
					stringBuilder.Append(method_8(TokenType.LPAREN));
					stringBuilder.Append(method_8(TokenType.LNUM_INT));
					if (method_5(TokenType.COMMA))
					{
						stringBuilder.Append(method_8(TokenType.COMMA));
						stringBuilder.Append(method_8(TokenType.LNUM_INT));
					}
					stringBuilder.Append(method_8(TokenType.RPAREN));
				}
			}
			else if (!method_5(TokenType.CHAR) && !method_5(TokenType.BINARY))
			{
				if (!method_5(TokenType.UNSIGNED) && !method_5(TokenType.SIGNED))
				{
					if (!method_5(TokenType.JSON) && !method_5(TokenType.DATE) && !method_5(TokenType.DATETIME) && !method_5(TokenType.TIME))
					{
						throw new ArgumentException(getString_0(107404918) + int_0);
					}
					int_0++;
				}
				else
				{
					int_0++;
					if (method_5(TokenType.INTEGER))
					{
						method_8(TokenType.INTEGER);
					}
				}
			}
			else
			{
				int_0++;
				if (method_5(TokenType.LPAREN))
				{
					stringBuilder.Append(method_8(TokenType.LPAREN));
					stringBuilder.Append(method_8(TokenType.LNUM_INT));
					stringBuilder.Append(method_8(TokenType.RPAREN));
				}
			}
			method_8(TokenType.RPAREN);
			@operator.Param.Add(Class103.smethod_5(Encoding.UTF8.GetBytes(stringBuilder.ToString())));
			return new Expr
			{
				Type = Expr.Types.Type.Operator,
				Operator = @operator
			};
		}
		case TokenType.LCURLY:
		{
			Mysqlx.Expr.Object object_0 = new Mysqlx.Expr.Object();
			if (method_5(TokenType.LSTRING))
			{
				method_32(delegate
				{
					string key = method_8(TokenType.LSTRING);
					method_8(TokenType.COLON);
					Expr value = method_30();
					return new Mysqlx.Expr.Object.Types.ObjectField
					{
						Key = key,
						Value = value
					};
				}).ForEach(delegate(Mysqlx.Expr.Object.Types.ObjectField objectField_0)
				{
					object_0.Fld.Add(objectField_0);
				});
			}
			method_8(TokenType.RCURLY);
			return new Expr
			{
				Type = Expr.Types.Type.Object,
				Object = object_0
			};
		}
		case TokenType.EROTEME:
		case TokenType.COLON:
		{
			string text;
			if (method_5(TokenType.LNUM_INT))
			{
				text = method_8(TokenType.LNUM_INT);
			}
			else if (method_5(TokenType.IDENT))
			{
				text = method_8(TokenType.IDENT);
			}
			else
			{
				if (@class.tokenType_0 != TokenType.EROTEME)
				{
					throw new ArgumentException(getString_0(107404971) + int_0);
				}
				text = int_1.ToString();
			}
			text = text.ToLowerInvariant();
			Expr expr = new Expr();
			expr.Type = Expr.Types.Type.Placeholder;
			if (dictionary_0.ContainsKey(text))
			{
				expr.Position = (uint)dictionary_0[text];
			}
			else
			{
				expr.Position = (uint)int_1;
				dictionary_0.Add(text, int_1);
				int_1++;
			}
			return expr;
		}
		}
	}

	private Expr method_20(TokenType[] tokenType_0, Func<Expr> func_0)
	{
		Expr expr = func_0();
		while (int_0 < list_0.Count && tokenType_0.ToList().Contains(list_0[int_0].tokenType_0))
		{
			Operator @operator = new Operator();
			@operator.Name = list_0[int_0].string_0;
			@operator.Param.Add(expr);
			int_0++;
			@operator.Param.Add(func_0());
			expr = new Expr
			{
				Type = Expr.Types.Type.Operator,
				Operator = @operator
			};
		}
		return expr;
	}

	private Expr method_21()
	{
		Expr expr = method_19();
		while ((method_5(TokenType.PLUS) || method_5(TokenType.MINUS)) && method_6(TokenType.INTERVAL))
		{
			Class100 @class = list_0[int_0];
			int_0++;
			Operator @operator = new Operator
			{
				Param = { expr }
			};
			method_8(TokenType.INTERVAL);
			if (@class.tokenType_0 == TokenType.PLUS)
			{
				@operator.Name = getString_0(107405284);
			}
			else
			{
				@operator.Name = getString_0(107405303);
			}
			@operator.Param.Add(method_25());
			if (method_5(TokenType.MICROSECOND) || method_5(TokenType.SECOND) || method_5(TokenType.MINUTE) || method_5(TokenType.HOUR) || method_5(TokenType.DAY) || method_5(TokenType.WEEK) || method_5(TokenType.MONTH) || method_5(TokenType.QUARTER) || method_5(TokenType.YEAR) || method_5(TokenType.SECOND_MICROSECOND) || method_5(TokenType.MINUTE_MICROSECOND) || method_5(TokenType.MINUTE_SECOND) || method_5(TokenType.HOUR_MICROSECOND) || method_5(TokenType.HOUR_SECOND) || method_5(TokenType.HOUR_MINUTE) || method_5(TokenType.DAY_MICROSECOND) || method_5(TokenType.DAY_SECOND) || method_5(TokenType.DAY_MINUTE) || method_5(TokenType.DAY_HOUR) || method_5(TokenType.YEAR_MONTH))
			{
				@operator.Param.Add(Class103.smethod_5(Encoding.UTF8.GetBytes(list_0[int_0].string_0.ToUpperInvariant())));
				int_0++;
				expr = new Expr
				{
					Type = Expr.Types.Type.Operator,
					Operator = @operator
				};
				continue;
			}
			throw new ArgumentException(getString_0(107405258) + int_0);
		}
		return expr;
	}

	private Expr method_22()
	{
		return method_20(new TokenType[3]
		{
			TokenType.STAR,
			TokenType.SLASH,
			TokenType.MOD
		}, method_21);
	}

	private Expr method_23()
	{
		return method_20(new TokenType[2]
		{
			TokenType.PLUS,
			TokenType.MINUS
		}, method_22);
	}

	private Expr method_24()
	{
		return method_20(new TokenType[2]
		{
			TokenType.LSHIFT,
			TokenType.RSHIFT
		}, method_23);
	}

	private Expr method_25()
	{
		return method_20(new TokenType[3]
		{
			TokenType.BITAND,
			TokenType.BITOR,
			TokenType.BITXOR
		}, method_24);
	}

	private Expr method_26()
	{
		return method_20(new TokenType[6]
		{
			TokenType.GE,
			TokenType.GT,
			TokenType.LE,
			TokenType.LT,
			TokenType.EQ,
			TokenType.NE
		}, method_25);
	}

	private Expr method_27()
	{
		Expr expr = method_26();
		List<TokenType> list = new List<TokenType>(new TokenType[6]
		{
			TokenType.IS,
			TokenType.IN,
			TokenType.LIKE,
			TokenType.BETWEEN,
			TokenType.REGEXP,
			TokenType.NOT
		});
		while (int_0 < list_0.Count && list.Contains(list_0[int_0].tokenType_0))
		{
			bool flag = false;
			if (method_5(TokenType.NOT))
			{
				method_8(TokenType.NOT);
				flag = true;
			}
			if (int_0 >= list_0.Count)
			{
				continue;
			}
			List<Expr> list2 = new List<Expr>();
			list2.Add(expr);
			string text = list_0[int_0].string_0.ToLowerInvariant();
			Operator @operator;
			switch (list_0[int_0].tokenType_0)
			{
			case TokenType.IN:
				method_8(TokenType.IN);
				if (method_5(TokenType.LPAREN))
				{
					list2.AddRange(method_9());
				}
				else
				{
					text = getString_0(107405212);
					list2.Add(method_26());
				}
				goto IL_01e7;
			case TokenType.LIKE:
				method_8(TokenType.LIKE);
				list2.Add(method_26());
				if (method_5(TokenType.ESCAPE))
				{
					method_8(TokenType.ESCAPE);
					list2.Add(method_26());
				}
				goto IL_01e7;
			case TokenType.REGEXP:
				method_8(TokenType.REGEXP);
				list2.Add(method_26());
				goto IL_01e7;
			case TokenType.BETWEEN:
				method_8(TokenType.BETWEEN);
				list2.Add(method_26());
				method_4(int_0, TokenType.AND);
				method_8(TokenType.AND);
				list2.Add(method_26());
				goto IL_01e7;
			case TokenType.IS:
				method_8(TokenType.IS);
				if (method_5(TokenType.NOT))
				{
					method_8(TokenType.NOT);
					text = getString_0(107405221);
				}
				list2.Add(method_26());
				goto IL_01e7;
			default:
				{
					throw new ArgumentException(getString_0(107405231) + int_0);
				}
				IL_01e7:
				if (flag)
				{
					text = getString_0(107405154) + text;
				}
				@operator = new Operator();
				@operator.Name = text;
				@operator.Param.Add(list2);
				expr = new Expr
				{
					Type = Expr.Types.Type.Operator,
					Operator = @operator
				};
				break;
			}
		}
		return expr;
	}

	private Expr method_28()
	{
		return method_20(new TokenType[2]
		{
			TokenType.AND,
			TokenType.ANDAND
		}, method_27);
	}

	private Expr method_29()
	{
		return method_20(new TokenType[2]
		{
			TokenType.OR,
			TokenType.OROR
		}, method_28);
	}

	private Expr method_30()
	{
		return method_29();
	}

	public Expr method_31()
	{
		try
		{
			Expr result = method_30();
			if (int_0 != list_0.Count)
			{
				throw new ArgumentException(getString_0(107405177) + int_0 + getString_0(107405168) + list_0.Count);
			}
			return result;
		}
		catch (Exception innerException)
		{
			throw new ArgumentException(getString_0(107405131) + string_0 + getString_0(107407930), innerException);
		}
	}

	private List<T> method_32<T>(Func<T> func_0)
	{
		List<T> list = new List<T>();
		bool flag = true;
		while (flag || method_5(TokenType.COMMA))
		{
			if (!flag)
			{
				method_8(TokenType.COMMA);
			}
			else
			{
				flag = false;
			}
			list.Add(func_0());
		}
		return list;
	}

	internal List<Order> method_33()
	{
		return method_32(delegate
		{
			Order order = new Order
			{
				Expr = method_30()
			};
			if (method_5(TokenType.ORDERBY_ASC))
			{
				method_8(TokenType.ORDERBY_ASC);
				order.Direction = Order.Class33.Enum19.const_1;
			}
			else if (method_5(TokenType.ORDERBY_DESC))
			{
				method_8(TokenType.ORDERBY_DESC);
				order.Direction = Order.Class33.Enum19.const_2;
			}
			return order;
		});
	}

	internal List<Projection> method_34()
	{
		return method_32(delegate
		{
			Projection projection = new Projection
			{
				Source = method_30()
			};
			if (method_5(TokenType.AS))
			{
				method_8(TokenType.AS);
				projection.Alias = method_8(TokenType.IDENT);
			}
			return projection;
		});
	}

	internal Column method_35()
	{
		return new Column
		{
			Name = method_8(TokenType.IDENT)
		};
	}

	internal ColumnIdentifier method_36()
	{
		return method_17().Identifier;
	}

	internal List<Projection> method_37()
	{
		bool_0 = false;
		return method_32(delegate
		{
			Projection obj = new Projection
			{
				Source = method_30()
			};
			method_8(TokenType.AS);
			obj.Alias = method_8(TokenType.IDENT);
			return obj;
		});
	}

	internal List<Expr> method_38()
	{
		return method_32(method_30);
	}

	public int method_39()
	{
		return int_1;
	}

	public Dictionary<string, int> method_40()
	{
		return dictionary_0;
	}

	[CompilerGenerated]
	private Expr method_41()
	{
		return method_30();
	}

	[CompilerGenerated]
	private Mysqlx.Expr.Object.Types.ObjectField method_42()
	{
		string key = method_8(TokenType.LSTRING);
		method_8(TokenType.COLON);
		Expr value = method_30();
		return new Mysqlx.Expr.Object.Types.ObjectField
		{
			Key = key,
			Value = value
		};
	}

	[CompilerGenerated]
	private Order method_43()
	{
		Order order = new Order
		{
			Expr = method_30()
		};
		if (method_5(TokenType.ORDERBY_ASC))
		{
			method_8(TokenType.ORDERBY_ASC);
			order.Direction = Order.Class33.Enum19.const_1;
		}
		else if (method_5(TokenType.ORDERBY_DESC))
		{
			method_8(TokenType.ORDERBY_DESC);
			order.Direction = Order.Class33.Enum19.const_2;
		}
		return order;
	}

	[CompilerGenerated]
	private Projection method_44()
	{
		Projection projection = new Projection
		{
			Source = method_30()
		};
		if (method_5(TokenType.AS))
		{
			method_8(TokenType.AS);
			projection.Alias = method_8(TokenType.IDENT);
		}
		return projection;
	}

	[CompilerGenerated]
	private Projection method_45()
	{
		Projection obj = new Projection
		{
			Source = method_30()
		};
		method_8(TokenType.AS);
		obj.Alias = method_8(TokenType.IDENT);
		return obj;
	}
}
