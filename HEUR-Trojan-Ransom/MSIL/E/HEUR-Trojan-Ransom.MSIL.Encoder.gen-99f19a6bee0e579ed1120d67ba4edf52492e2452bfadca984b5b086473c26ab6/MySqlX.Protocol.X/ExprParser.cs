using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mysqlx.Crud;
using Mysqlx.Expr;

namespace MySqlX.Protocol.X;

internal class ExprParser
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
		JSON,
		ARROW,
		DOUBLE_ARROW
	}

	internal class Token
	{
		internal TokenType type;

		internal string value;

		public Token(TokenType x, char c)
		{
			type = x;
			value = c.ToString();
		}

		public Token(TokenType t, string v)
		{
			type = t;
			value = v;
		}

		public override string ToString()
		{
			if (type != TokenType.IDENT && type != TokenType.LNUM_INT && type != TokenType.LNUM_DOUBLE && type != TokenType.LSTRING)
			{
				return type.ToString();
			}
			return type.ToString() + "(" + value + ")";
		}
	}

	private string stringValue;

	internal List<Token> tokens = new List<Token>();

	internal int tokenPos;

	internal Dictionary<string, int> placeholderNameToPosition = new Dictionary<string, int>();

	internal int positionalPlaceholderCount;

	private bool allowRelationalColumns;

	private static Dictionary<string, TokenType> reservedWords;

	public ExprParser(string s)
		: this(s, allowRelationalColumns: true)
	{
	}

	public ExprParser(string s, bool allowRelationalColumns)
	{
		stringValue = s;
		Lex();
		this.allowRelationalColumns = allowRelationalColumns;
	}

	static ExprParser()
	{
		reservedWords = new Dictionary<string, TokenType>();
		reservedWords.Add("and", TokenType.AND);
		reservedWords.Add("or", TokenType.OR);
		reservedWords.Add("xor", TokenType.XOR);
		reservedWords.Add("is", TokenType.IS);
		reservedWords.Add("not", TokenType.NOT);
		reservedWords.Add("like", TokenType.LIKE);
		reservedWords.Add("in", TokenType.IN);
		reservedWords.Add("regexp", TokenType.REGEXP);
		reservedWords.Add("between", TokenType.BETWEEN);
		reservedWords.Add("interval", TokenType.INTERVAL);
		reservedWords.Add("escape", TokenType.ESCAPE);
		reservedWords.Add("div", TokenType.SLASH);
		reservedWords.Add("hex", TokenType.HEX);
		reservedWords.Add("bin", TokenType.BIN);
		reservedWords.Add("true", TokenType.TRUE);
		reservedWords.Add("false", TokenType.FALSE);
		reservedWords.Add("null", TokenType.NULL);
		reservedWords.Add("microsecond", TokenType.MICROSECOND);
		reservedWords.Add("second", TokenType.SECOND);
		reservedWords.Add("minute", TokenType.MINUTE);
		reservedWords.Add("hour", TokenType.HOUR);
		reservedWords.Add("day", TokenType.DAY);
		reservedWords.Add("week", TokenType.WEEK);
		reservedWords.Add("month", TokenType.MONTH);
		reservedWords.Add("quarter", TokenType.QUARTER);
		reservedWords.Add("year", TokenType.YEAR);
		reservedWords.Add("second_microsecond", TokenType.SECOND_MICROSECOND);
		reservedWords.Add("minute_microsecond", TokenType.MINUTE_MICROSECOND);
		reservedWords.Add("minute_second", TokenType.MINUTE_SECOND);
		reservedWords.Add("hour_microsecond", TokenType.HOUR_MICROSECOND);
		reservedWords.Add("hour_second", TokenType.HOUR_SECOND);
		reservedWords.Add("hour_minute", TokenType.HOUR_MINUTE);
		reservedWords.Add("day_microsecond", TokenType.DAY_MICROSECOND);
		reservedWords.Add("day_second", TokenType.DAY_SECOND);
		reservedWords.Add("day_minute", TokenType.DAY_MINUTE);
		reservedWords.Add("day_hour", TokenType.DAY_HOUR);
		reservedWords.Add("year_month", TokenType.YEAR_MONTH);
		reservedWords.Add("asc", TokenType.ORDERBY_ASC);
		reservedWords.Add("desc", TokenType.ORDERBY_DESC);
		reservedWords.Add("as", TokenType.AS);
		reservedWords.Add("cast", TokenType.CAST);
		reservedWords.Add("decimal", TokenType.DECIMAL);
		reservedWords.Add("unsigned", TokenType.UNSIGNED);
		reservedWords.Add("signed", TokenType.SIGNED);
		reservedWords.Add("integer", TokenType.INTEGER);
		reservedWords.Add("date", TokenType.DATE);
		reservedWords.Add("time", TokenType.TIME);
		reservedWords.Add("datetime", TokenType.DATETIME);
		reservedWords.Add("char", TokenType.CHAR);
		reservedWords.Add("binary", TokenType.BINARY);
		reservedWords.Add("json", TokenType.BINARY);
	}

	private bool NextCharEquals(int i, char c)
	{
		if (i + 1 < stringValue.Length)
		{
			return stringValue[i + 1] == c;
		}
		return false;
	}

	private int LexNumber(int i)
	{
		bool flag = true;
		int num = i;
		for (; i < stringValue.Length; i++)
		{
			char c = stringValue[i];
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
				if (!NextCharEquals(i, '-') && !NextCharEquals(i, '+'))
				{
					if (char.IsLetter(stringValue[i + 1]))
					{
						Identifier(ref i, num);
						return i;
					}
				}
				else
				{
					i++;
				}
				continue;
			}
			break;
		}
		if (flag)
		{
			tokens.Add(new Token(TokenType.LNUM_INT, stringValue.Substring(num, i - num)));
		}
		else
		{
			tokens.Add(new Token(TokenType.LNUM_DOUBLE, stringValue.Substring(num, i - num)));
		}
		i--;
		return i;
	}

	private void Lex()
	{
		for (int i = 0; i < stringValue.Length; i++)
		{
			int num = i;
			char c = stringValue[i];
			if (char.IsWhiteSpace(c))
			{
				continue;
			}
			if (char.IsDigit(c))
			{
				if (i != stringValue.Length - 1)
				{
					if (char.IsLetter(stringValue[i + 1]) && !NextCharEquals(i, 'e'))
					{
						Identifier(ref i, num);
					}
					else
					{
						i = LexNumber(i);
					}
				}
				else
				{
					i = LexNumber(i);
				}
			}
			else if (c != '_' && !char.IsLetter(c))
			{
				switch (c)
				{
				case '{':
					tokens.Add(new Token(TokenType.LCURLY, c));
					break;
				case '|':
					if (NextCharEquals(i, '|'))
					{
						i++;
						tokens.Add(new Token(TokenType.OROR, "||"));
					}
					else
					{
						tokens.Add(new Token(TokenType.BITOR, c));
					}
					break;
				case '}':
					tokens.Add(new Token(TokenType.RCURLY, c));
					break;
				case '~':
					tokens.Add(new Token(TokenType.NEG, c));
					break;
				case '[':
					tokens.Add(new Token(TokenType.LSQBRACKET, c));
					break;
				case ']':
					tokens.Add(new Token(TokenType.RSQBRACKET, c));
					break;
				case '^':
					tokens.Add(new Token(TokenType.BITXOR, c));
					break;
				case '!':
					if (NextCharEquals(i, '='))
					{
						i++;
						tokens.Add(new Token(TokenType.NE, "!="));
					}
					else
					{
						tokens.Add(new Token(TokenType.BANG, c));
					}
					break;
				case '$':
					tokens.Add(new Token(TokenType.AT, c));
					break;
				case '%':
					tokens.Add(new Token(TokenType.MOD, c));
					break;
				case '&':
					if (NextCharEquals(i, '&'))
					{
						i++;
						tokens.Add(new Token(TokenType.ANDAND, "&&"));
					}
					else
					{
						tokens.Add(new Token(TokenType.BITAND, c));
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
						c = stringValue[++i];
						while (c != c2 || (i + 1 < stringValue.Length && stringValue[i + 1] == c2))
						{
							if (c == '\\' || c == c2)
							{
								i++;
							}
							stringBuilder.Append(stringValue[i]);
							c = stringValue[++i];
						}
					}
					catch (IndexOutOfRangeException)
					{
						throw new ArgumentException("Unterminated string starting at " + num);
					}
					string text = stringBuilder.ToString();
					tokens.Add(new Token((c2 == '`') ? TokenType.IDENT : TokenType.LSTRING, (text == string.Empty) ? " " : text));
					break;
				}
				case '(':
					tokens.Add(new Token(TokenType.LPAREN, c));
					break;
				case ')':
					tokens.Add(new Token(TokenType.RPAREN, c));
					break;
				case '*':
					if (NextCharEquals(i, '*'))
					{
						i++;
						tokens.Add(new Token(TokenType.DOUBLESTAR, "**"));
					}
					else
					{
						tokens.Add(new Token(TokenType.STAR, c));
					}
					break;
				case '+':
					tokens.Add(new Token(TokenType.PLUS, c));
					break;
				case ',':
					tokens.Add(new Token(TokenType.COMMA, c));
					break;
				case '-':
					if (NextCharEquals(i, '>'))
					{
						i++;
						if (NextCharEquals(i, '>'))
						{
							i++;
							tokens.Add(new Token(TokenType.DOUBLE_ARROW, "->>"));
						}
						else
						{
							tokens.Add(new Token(TokenType.ARROW, "->"));
						}
					}
					else
					{
						tokens.Add(new Token(TokenType.MINUS, c));
					}
					break;
				case '.':
					if (NextCharEquals(i, '*'))
					{
						i++;
						tokens.Add(new Token(TokenType.DOTSTAR, ".*"));
					}
					else if (i + 1 < stringValue.Length && char.IsDigit(stringValue[i + 1]))
					{
						i = LexNumber(i);
					}
					else
					{
						tokens.Add(new Token(TokenType.DOT, c));
					}
					break;
				case '/':
					tokens.Add(new Token(TokenType.SLASH, c));
					break;
				case ':':
					tokens.Add(new Token(TokenType.COLON, c));
					break;
				case '<':
					if (NextCharEquals(i, '<'))
					{
						i++;
						tokens.Add(new Token(TokenType.LSHIFT, "<<"));
					}
					else if (NextCharEquals(i, '='))
					{
						i++;
						tokens.Add(new Token(TokenType.LE, "<="));
					}
					else
					{
						tokens.Add(new Token(TokenType.LT, c));
					}
					break;
				case '=':
					if (NextCharEquals(i, '='))
					{
						i++;
					}
					tokens.Add(new Token(TokenType.EQ, "=="));
					break;
				case '>':
					if (NextCharEquals(i, '>'))
					{
						i++;
						tokens.Add(new Token(TokenType.RSHIFT, ">>"));
					}
					else if (NextCharEquals(i, '='))
					{
						i++;
						tokens.Add(new Token(TokenType.GE, ">="));
					}
					else
					{
						tokens.Add(new Token(TokenType.GT, c));
					}
					break;
				case '?':
					tokens.Add(new Token(TokenType.EROTEME, c));
					break;
				default:
					throw new ArgumentException("Can't parse at pos: " + i);
				}
			}
			else
			{
				Identifier(ref i, num);
			}
		}
	}

	private void Identifier(ref int i, int start)
	{
		while (i < stringValue.Length && (char.IsLetterOrDigit(stringValue[i]) || stringValue[i] == '_'))
		{
			i++;
		}
		string text = stringValue.Substring(start, i - start);
		string text2 = text.ToLowerInvariant();
		if (i < stringValue.Length)
		{
			i--;
		}
		if (reservedWords.ContainsKey(text2))
		{
			if ("and".Equals(text2))
			{
				tokens.Add(new Token(reservedWords[text2], "&&"));
			}
			else if ("or".Equals(text2))
			{
				tokens.Add(new Token(reservedWords[text2], "||"));
			}
			else if (IsReservedWordFunctionCall(text2, i))
			{
				tokens.Add(new Token(TokenType.IDENT, text));
			}
			else
			{
				tokens.Add(new Token(reservedWords[text2], text2));
			}
		}
		else
		{
			tokens.Add(new Token(TokenType.IDENT, text));
		}
	}

	private bool IsReservedWordFunctionCall(string reservedWord, int position)
	{
		Token token = new Token(reservedWords[reservedWord], reservedWord);
		if (token.type != TokenType.YEAR && token.type != TokenType.MONTH && token.type != TokenType.WEEK && token.type != TokenType.DAY && token.type != TokenType.HOUR && token.type != TokenType.MINUTE && token.type != TokenType.SECOND && token.type != TokenType.MICROSECOND && token.type != TokenType.QUARTER && token.type != TokenType.TIME && token.type != TokenType.DATE && token.type != TokenType.CHAR && token.type != TokenType.HEX && token.type != TokenType.BIN)
		{
			return false;
		}
		if (stringValue.Length >= position + 2)
		{
			return stringValue[position + 1] == '(';
		}
		return false;
	}

	private void AssertTokenAt(int pos, TokenType type)
	{
		if (tokens.Count <= pos)
		{
			throw new ArgumentException(string.Concat("No more tokens when expecting ", type, " at token pos ", pos));
		}
		if (tokens[pos].type != type)
		{
			throw new ArgumentException(string.Concat("Expected token type ", type, " at token pos ", pos));
		}
	}

	private bool CurrentTokenTypeEquals(TokenType t)
	{
		return PosTokenTypeEquals(tokenPos, t);
	}

	private bool NextTokenTypeEquals(TokenType t)
	{
		return PosTokenTypeEquals(tokenPos + 1, t);
	}

	private bool PosTokenTypeEquals(int pos, TokenType t)
	{
		if (tokens.Count > pos)
		{
			return tokens[pos].type == t;
		}
		return false;
	}

	private string ConsumeToken(TokenType t)
	{
		AssertTokenAt(tokenPos, t);
		string value = tokens[tokenPos].value;
		tokenPos++;
		return value;
	}

	private List<Expr> ParenExprList()
	{
		List<Expr> list = new List<Expr>();
		ConsumeToken(TokenType.LPAREN);
		if (!CurrentTokenTypeEquals(TokenType.RPAREN))
		{
			list.Add(GetExpr());
			while (CurrentTokenTypeEquals(TokenType.COMMA))
			{
				ConsumeToken(TokenType.COMMA);
				list.Add(GetExpr());
			}
		}
		ConsumeToken(TokenType.RPAREN);
		return list;
	}

	private Expr ParseFunctionCall()
	{
		Identifier name = ParseIdentifier();
		FunctionCall functionCall = new FunctionCall();
		functionCall.Name = name;
		functionCall.Param.Add(ParenExprList());
		return new Expr
		{
			Type = Expr.Types.Type.FuncCall,
			FunctionCall = functionCall
		};
	}

	private Expr StarOperator()
	{
		Operator @operator = new Operator();
		@operator.Name = "*";
		return new Expr
		{
			Type = Expr.Types.Type.Operator,
			Operator = @operator
		};
	}

	private Identifier ParseIdentifier()
	{
		Identifier identifier = new Identifier();
		AssertTokenAt(tokenPos, TokenType.IDENT);
		if (NextTokenTypeEquals(TokenType.DOT))
		{
			identifier.SchemaName = tokens[tokenPos].value;
			ConsumeToken(TokenType.IDENT);
			ConsumeToken(TokenType.DOT);
			AssertTokenAt(tokenPos, TokenType.IDENT);
		}
		identifier.Name = tokens[tokenPos].value;
		ConsumeToken(TokenType.IDENT);
		return identifier;
	}

	private DocumentPathItem DocPathMember()
	{
		ConsumeToken(TokenType.DOT);
		Token token = tokens[tokenPos];
		string value;
		if (CurrentTokenTypeEquals(TokenType.IDENT))
		{
			if (!token.value.Equals(ExprUnparser.QuoteIdentifier(token.value)))
			{
				throw new ArgumentException("'" + token.value + "' is not a valid JSON/ECMAScript identifier");
			}
			ConsumeToken(TokenType.IDENT);
			value = token.value;
		}
		else
		{
			if (!CurrentTokenTypeEquals(TokenType.LSTRING))
			{
				throw new ArgumentException("Expected token type IDENT or LSTRING in JSON path at token pos " + tokenPos);
			}
			ConsumeToken(TokenType.LSTRING);
			value = token.value;
		}
		return new DocumentPathItem
		{
			Type = DocumentPathItem.Types.Type.Member,
			Value = value
		};
	}

	private DocumentPathItem DocPathArrayLoc()
	{
		DocumentPathItem documentPathItem = new DocumentPathItem();
		ConsumeToken(TokenType.LSQBRACKET);
		if (CurrentTokenTypeEquals(TokenType.STAR))
		{
			ConsumeToken(TokenType.STAR);
			ConsumeToken(TokenType.RSQBRACKET);
			documentPathItem.Type = DocumentPathItem.Types.Type.ArrayIndexAsterisk;
			return documentPathItem;
		}
		if (!CurrentTokenTypeEquals(TokenType.LNUM_INT))
		{
			throw new ArgumentException("Expected token type STAR or LNUM_INT in JSON path array index at token pos " + tokenPos);
		}
		uint index = uint.Parse(tokens[tokenPos].value);
		ConsumeToken(TokenType.LNUM_INT);
		ConsumeToken(TokenType.RSQBRACKET);
		documentPathItem.Type = DocumentPathItem.Types.Type.ArrayIndex;
		documentPathItem.Index = index;
		return documentPathItem;
	}

	internal List<DocumentPathItem> DocumentPath()
	{
		List<DocumentPathItem> list = new List<DocumentPathItem>();
		while (true)
		{
			if (!CurrentTokenTypeEquals(TokenType.DOT))
			{
				if (CurrentTokenTypeEquals(TokenType.DOTSTAR))
				{
					ConsumeToken(TokenType.DOTSTAR);
					list.Add(new DocumentPathItem
					{
						Type = DocumentPathItem.Types.Type.MemberAsterisk
					});
					continue;
				}
				if (CurrentTokenTypeEquals(TokenType.LSQBRACKET))
				{
					list.Add(DocPathArrayLoc());
					continue;
				}
				if (!CurrentTokenTypeEquals(TokenType.DOUBLESTAR))
				{
					break;
				}
				ConsumeToken(TokenType.DOUBLESTAR);
				list.Add(new DocumentPathItem
				{
					Type = DocumentPathItem.Types.Type.DoubleAsterisk
				});
			}
			else
			{
				list.Add(DocPathMember());
			}
		}
		if (list.Count > 0 && list[list.Count - 1].Type == DocumentPathItem.Types.Type.DoubleAsterisk)
		{
			throw new ArgumentException("JSON path may not end in '**' at " + tokenPos);
		}
		return list;
	}

	internal Expr DocumentField()
	{
		ColumnIdentifier columnIdentifier = new ColumnIdentifier();
		if (CurrentTokenTypeEquals(TokenType.IDENT))
		{
			columnIdentifier.DocumentPath.Add(new DocumentPathItem
			{
				Type = DocumentPathItem.Types.Type.Member,
				Value = ConsumeToken(TokenType.IDENT)
			});
		}
		columnIdentifier.DocumentPath.Add(DocumentPath());
		return new Expr
		{
			Type = Expr.Types.Type.Ident,
			Identifier = columnIdentifier
		};
	}

	private Expr ParseColumnIdentifier()
	{
		List<string> list = new List<string>();
		list.Add(ConsumeToken(TokenType.IDENT));
		while (CurrentTokenTypeEquals(TokenType.DOT))
		{
			ConsumeToken(TokenType.DOT);
			list.Add(ConsumeToken(TokenType.IDENT));
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
		if (CurrentTokenTypeEquals(TokenType.ARROW))
		{
			ConsumeToken(TokenType.ARROW);
		}
		else if (CurrentTokenTypeEquals(TokenType.DOUBLE_ARROW))
		{
			throw new NotSupportedException("Operator ->> not supported.");
		}
		if (CurrentTokenTypeEquals(TokenType.AT))
		{
			ConsumeToken(TokenType.AT);
			columnIdentifier.DocumentPath.Add(DocumentPath());
			if (columnIdentifier.DocumentPath.Count == 0)
			{
				throw new ArgumentException("Invalid document path at " + tokenPos);
			}
		}
		return new Expr
		{
			Type = Expr.Types.Type.Ident,
			Identifier = columnIdentifier
		};
	}

	private Expr BuildUnaryOp(string name, Expr param)
	{
		Operator @operator = new Operator();
		@operator.Name = name;
		@operator.Param.Add(param);
		return new Expr
		{
			Type = Expr.Types.Type.Operator,
			Operator = @operator
		};
	}

	private Expr AtomicExpr()
	{
		if (tokenPos >= tokens.Count)
		{
			throw new ArgumentException("No more tokens when expecting one at token pos " + tokenPos);
		}
		Token token = tokens[tokenPos];
		tokenPos++;
		switch (token.type)
		{
		case TokenType.PLUS:
		case TokenType.MINUS:
			if (!CurrentTokenTypeEquals(TokenType.LNUM_INT) && !CurrentTokenTypeEquals(TokenType.LNUM_DOUBLE))
			{
				return BuildUnaryOp(token.value, AtomicExpr());
			}
			tokens[tokenPos].value = token.value + tokens[tokenPos].value;
			return AtomicExpr();
		case TokenType.STAR:
			return StarOperator();
		case TokenType.LPAREN:
		{
			Expr expr2 = GetExpr();
			ConsumeToken(TokenType.RPAREN);
			return expr2;
		}
		case TokenType.LSQBRACKET:
		{
			Mysqlx.Expr.Array builder2 = new Mysqlx.Expr.Array();
			ParseCommaSeparatedList(() => GetExpr()).ForEach(delegate(Expr f)
			{
				builder2.Value.Add(f);
			});
			ConsumeToken(TokenType.RSQBRACKET);
			return new Expr
			{
				Type = Expr.Types.Type.Array,
				Array = builder2
			};
		}
		case TokenType.NULL:
			return ExprUtil.BuildLiteralNullScalar();
		case TokenType.TRUE:
		case TokenType.FALSE:
			return ExprUtil.BuildLiteralScalar(token.type == TokenType.TRUE);
		case TokenType.IDENT:
			tokenPos--;
			if (!NextTokenTypeEquals(TokenType.LPAREN) && (!PosTokenTypeEquals(tokenPos + 1, TokenType.DOT) || !PosTokenTypeEquals(tokenPos + 2, TokenType.IDENT) || !PosTokenTypeEquals(tokenPos + 3, TokenType.LPAREN)))
			{
				if (allowRelationalColumns)
				{
					return ParseColumnIdentifier();
				}
				return DocumentField();
			}
			return ParseFunctionCall();
		case TokenType.LSTRING:
			return ExprUtil.BuildLiteralScalar(token.value);
		case TokenType.LNUM_INT:
			return ExprUtil.BuildLiteralScalar(long.Parse(token.value));
		case TokenType.LNUM_DOUBLE:
			return ExprUtil.BuildLiteralScalar(double.Parse(token.value));
		case TokenType.AT:
			return DocumentField();
		case TokenType.NOT:
		case TokenType.NEG:
		case TokenType.BANG:
			return BuildUnaryOp(token.value, AtomicExpr());
		default:
			throw new ArgumentException("Cannot find atomic expression at token pos: " + (tokenPos - 1));
		case TokenType.CAST:
		{
			ConsumeToken(TokenType.LPAREN);
			Operator @operator = new Operator();
			@operator.Name = TokenType.CAST.ToString().ToLowerInvariant();
			@operator.Param.Add(GetExpr());
			ConsumeToken(TokenType.AS);
			StringBuilder stringBuilder = new StringBuilder(tokens[tokenPos].value.ToUpperInvariant());
			if (CurrentTokenTypeEquals(TokenType.DECIMAL))
			{
				tokenPos++;
				if (CurrentTokenTypeEquals(TokenType.LPAREN))
				{
					stringBuilder.Append(ConsumeToken(TokenType.LPAREN));
					stringBuilder.Append(ConsumeToken(TokenType.LNUM_INT));
					if (CurrentTokenTypeEquals(TokenType.COMMA))
					{
						stringBuilder.Append(ConsumeToken(TokenType.COMMA));
						stringBuilder.Append(ConsumeToken(TokenType.LNUM_INT));
					}
					stringBuilder.Append(ConsumeToken(TokenType.RPAREN));
				}
			}
			else if (!CurrentTokenTypeEquals(TokenType.CHAR) && !CurrentTokenTypeEquals(TokenType.BINARY))
			{
				if (!CurrentTokenTypeEquals(TokenType.UNSIGNED) && !CurrentTokenTypeEquals(TokenType.SIGNED))
				{
					if (!CurrentTokenTypeEquals(TokenType.JSON) && !CurrentTokenTypeEquals(TokenType.DATE) && !CurrentTokenTypeEquals(TokenType.DATETIME) && !CurrentTokenTypeEquals(TokenType.TIME))
					{
						throw new ArgumentException("Expected valid CAST type argument at " + tokenPos);
					}
					tokenPos++;
				}
				else
				{
					tokenPos++;
					if (CurrentTokenTypeEquals(TokenType.INTEGER))
					{
						ConsumeToken(TokenType.INTEGER);
					}
				}
			}
			else
			{
				tokenPos++;
				if (CurrentTokenTypeEquals(TokenType.LPAREN))
				{
					stringBuilder.Append(ConsumeToken(TokenType.LPAREN));
					stringBuilder.Append(ConsumeToken(TokenType.LNUM_INT));
					stringBuilder.Append(ConsumeToken(TokenType.RPAREN));
				}
			}
			ConsumeToken(TokenType.RPAREN);
			@operator.Param.Add(ExprUtil.BuildLiteralScalar(Encoding.UTF8.GetBytes(stringBuilder.ToString())));
			return new Expr
			{
				Type = Expr.Types.Type.Operator,
				Operator = @operator
			};
		}
		case TokenType.LCURLY:
		{
			Mysqlx.Expr.Object builder = new Mysqlx.Expr.Object();
			if (CurrentTokenTypeEquals(TokenType.LSTRING))
			{
				ParseCommaSeparatedList(delegate
				{
					string key = ConsumeToken(TokenType.LSTRING);
					ConsumeToken(TokenType.COLON);
					Expr expr3 = GetExpr();
					return new Mysqlx.Expr.Object.Types.ObjectField
					{
						Key = key,
						Value = expr3
					};
				}).ForEach(delegate(Mysqlx.Expr.Object.Types.ObjectField f)
				{
					builder.Fld.Add(f);
				});
			}
			ConsumeToken(TokenType.RCURLY);
			return new Expr
			{
				Type = Expr.Types.Type.Object,
				Object = builder
			};
		}
		case TokenType.EROTEME:
		case TokenType.COLON:
		{
			string text;
			if (CurrentTokenTypeEquals(TokenType.LNUM_INT))
			{
				text = ConsumeToken(TokenType.LNUM_INT);
			}
			else if (CurrentTokenTypeEquals(TokenType.IDENT))
			{
				text = ConsumeToken(TokenType.IDENT);
			}
			else
			{
				if (token.type != TokenType.EROTEME)
				{
					throw new ArgumentException("Invalid placeholder name at token pos " + tokenPos);
				}
				text = positionalPlaceholderCount.ToString();
			}
			text = text.ToLowerInvariant();
			Expr expr = new Expr();
			expr.Type = Expr.Types.Type.Placeholder;
			if (placeholderNameToPosition.ContainsKey(text))
			{
				expr.Position = (uint)placeholderNameToPosition[text];
			}
			else
			{
				expr.Position = (uint)positionalPlaceholderCount;
				placeholderNameToPosition.Add(text, positionalPlaceholderCount);
				positionalPlaceholderCount++;
			}
			return expr;
		}
		}
	}

	private Expr ParseLeftAssocBinaryOpExpr(TokenType[] types, Func<Expr> innerParser)
	{
		Expr expr = innerParser();
		while (tokenPos < tokens.Count && types.ToList().Contains(tokens[tokenPos].type))
		{
			Operator @operator = new Operator();
			@operator.Name = tokens[tokenPos].value;
			@operator.Param.Add(expr);
			tokenPos++;
			@operator.Param.Add(innerParser());
			expr = new Expr
			{
				Type = Expr.Types.Type.Operator,
				Operator = @operator
			};
		}
		return expr;
	}

	private Expr AddSubIntervalExpr()
	{
		Expr expr = AtomicExpr();
		while ((CurrentTokenTypeEquals(TokenType.PLUS) || CurrentTokenTypeEquals(TokenType.MINUS)) && NextTokenTypeEquals(TokenType.INTERVAL))
		{
			Token token = tokens[tokenPos];
			tokenPos++;
			Operator @operator = new Operator
			{
				Param = { expr }
			};
			ConsumeToken(TokenType.INTERVAL);
			if (token.type == TokenType.PLUS)
			{
				@operator.Name = "date_add";
			}
			else
			{
				@operator.Name = "date_sub";
			}
			@operator.Param.Add(BitExpr());
			if (CurrentTokenTypeEquals(TokenType.MICROSECOND) || CurrentTokenTypeEquals(TokenType.SECOND) || CurrentTokenTypeEquals(TokenType.MINUTE) || CurrentTokenTypeEquals(TokenType.HOUR) || CurrentTokenTypeEquals(TokenType.DAY) || CurrentTokenTypeEquals(TokenType.WEEK) || CurrentTokenTypeEquals(TokenType.MONTH) || CurrentTokenTypeEquals(TokenType.QUARTER) || CurrentTokenTypeEquals(TokenType.YEAR) || CurrentTokenTypeEquals(TokenType.SECOND_MICROSECOND) || CurrentTokenTypeEquals(TokenType.MINUTE_MICROSECOND) || CurrentTokenTypeEquals(TokenType.MINUTE_SECOND) || CurrentTokenTypeEquals(TokenType.HOUR_MICROSECOND) || CurrentTokenTypeEquals(TokenType.HOUR_SECOND) || CurrentTokenTypeEquals(TokenType.HOUR_MINUTE) || CurrentTokenTypeEquals(TokenType.DAY_MICROSECOND) || CurrentTokenTypeEquals(TokenType.DAY_SECOND) || CurrentTokenTypeEquals(TokenType.DAY_MINUTE) || CurrentTokenTypeEquals(TokenType.DAY_HOUR) || CurrentTokenTypeEquals(TokenType.YEAR_MONTH))
			{
				@operator.Param.Add(ExprUtil.BuildLiteralScalar(Encoding.UTF8.GetBytes(tokens[tokenPos].value.ToUpperInvariant())));
				tokenPos++;
				expr = new Expr
				{
					Type = Expr.Types.Type.Operator,
					Operator = @operator
				};
				continue;
			}
			throw new ArgumentException("Expected interval units at " + tokenPos);
		}
		return expr;
	}

	private Expr MulDivExpr()
	{
		return ParseLeftAssocBinaryOpExpr(new TokenType[3]
		{
			TokenType.STAR,
			TokenType.SLASH,
			TokenType.MOD
		}, AddSubIntervalExpr);
	}

	private Expr AddSubExpr()
	{
		return ParseLeftAssocBinaryOpExpr(new TokenType[2]
		{
			TokenType.PLUS,
			TokenType.MINUS
		}, MulDivExpr);
	}

	private Expr ShiftExpr()
	{
		return ParseLeftAssocBinaryOpExpr(new TokenType[2]
		{
			TokenType.LSHIFT,
			TokenType.RSHIFT
		}, AddSubExpr);
	}

	private Expr BitExpr()
	{
		return ParseLeftAssocBinaryOpExpr(new TokenType[3]
		{
			TokenType.BITAND,
			TokenType.BITOR,
			TokenType.BITXOR
		}, ShiftExpr);
	}

	private Expr CompExpr()
	{
		return ParseLeftAssocBinaryOpExpr(new TokenType[6]
		{
			TokenType.GE,
			TokenType.GT,
			TokenType.LE,
			TokenType.LT,
			TokenType.EQ,
			TokenType.NE
		}, BitExpr);
	}

	private Expr IlriExpr()
	{
		Expr expr = CompExpr();
		List<TokenType> list = new List<TokenType>(new TokenType[6]
		{
			TokenType.IS,
			TokenType.IN,
			TokenType.LIKE,
			TokenType.BETWEEN,
			TokenType.REGEXP,
			TokenType.NOT
		});
		while (tokenPos < tokens.Count && list.Contains(tokens[tokenPos].type))
		{
			bool flag = false;
			if (CurrentTokenTypeEquals(TokenType.NOT))
			{
				ConsumeToken(TokenType.NOT);
				flag = true;
			}
			if (tokenPos >= tokens.Count)
			{
				continue;
			}
			List<Expr> list2 = new List<Expr>();
			list2.Add(expr);
			string text = tokens[tokenPos].value.ToLowerInvariant();
			Operator @operator;
			switch (tokens[tokenPos].type)
			{
			case TokenType.IN:
				ConsumeToken(TokenType.IN);
				if (CurrentTokenTypeEquals(TokenType.LPAREN))
				{
					list2.AddRange(ParenExprList());
				}
				else
				{
					text = "cont_in";
					list2.Add(CompExpr());
				}
				goto IL_01d0;
			case TokenType.LIKE:
				ConsumeToken(TokenType.LIKE);
				list2.Add(CompExpr());
				if (CurrentTokenTypeEquals(TokenType.ESCAPE))
				{
					ConsumeToken(TokenType.ESCAPE);
					list2.Add(CompExpr());
				}
				goto IL_01d0;
			case TokenType.REGEXP:
				ConsumeToken(TokenType.REGEXP);
				list2.Add(CompExpr());
				goto IL_01d0;
			case TokenType.BETWEEN:
				ConsumeToken(TokenType.BETWEEN);
				list2.Add(CompExpr());
				AssertTokenAt(tokenPos, TokenType.AND);
				ConsumeToken(TokenType.AND);
				list2.Add(CompExpr());
				goto IL_01d0;
			case TokenType.IS:
				ConsumeToken(TokenType.IS);
				if (CurrentTokenTypeEquals(TokenType.NOT))
				{
					ConsumeToken(TokenType.NOT);
					text = "is_not";
				}
				list2.Add(CompExpr());
				goto IL_01d0;
			default:
				{
					throw new ArgumentException("Unknown token after NOT at pos: " + tokenPos);
				}
				IL_01d0:
				if (flag)
				{
					text = "not_" + text;
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

	private Expr AndExpr()
	{
		return ParseLeftAssocBinaryOpExpr(new TokenType[2]
		{
			TokenType.AND,
			TokenType.ANDAND
		}, IlriExpr);
	}

	private Expr OrExpr()
	{
		return ParseLeftAssocBinaryOpExpr(new TokenType[2]
		{
			TokenType.OR,
			TokenType.OROR
		}, AndExpr);
	}

	private Expr GetExpr()
	{
		return OrExpr();
	}

	public Expr Parse()
	{
		try
		{
			Expr expr = GetExpr();
			if (tokenPos != tokens.Count)
			{
				throw new ArgumentException("Only " + tokenPos + " tokens consumed, out of " + tokens.Count);
			}
			return expr;
		}
		catch (Exception innerException)
		{
			throw new ArgumentException("Unable to parse query '" + stringValue + "'", innerException);
		}
	}

	private List<T> ParseCommaSeparatedList<T>(Func<T> elementParser)
	{
		List<T> list = new List<T>();
		bool flag = true;
		while (flag || CurrentTokenTypeEquals(TokenType.COMMA))
		{
			if (!flag)
			{
				ConsumeToken(TokenType.COMMA);
			}
			else
			{
				flag = false;
			}
			list.Add(elementParser());
		}
		return list;
	}

	internal List<Order> ParseOrderSpec()
	{
		return ParseCommaSeparatedList(delegate
		{
			Order order = new Order
			{
				Expr = GetExpr()
			};
			if (CurrentTokenTypeEquals(TokenType.ORDERBY_ASC))
			{
				ConsumeToken(TokenType.ORDERBY_ASC);
				order.Direction = Order.Types.Direction.Asc;
			}
			else if (CurrentTokenTypeEquals(TokenType.ORDERBY_DESC))
			{
				ConsumeToken(TokenType.ORDERBY_DESC);
				order.Direction = Order.Types.Direction.Desc;
			}
			return order;
		});
	}

	internal List<Projection> ParseTableSelectProjection()
	{
		return ParseCommaSeparatedList(delegate
		{
			Projection projection = new Projection
			{
				Source = GetExpr()
			};
			if (CurrentTokenTypeEquals(TokenType.AS))
			{
				ConsumeToken(TokenType.AS);
				projection.Alias = ConsumeToken(TokenType.IDENT);
			}
			return projection;
		});
	}

	internal Column ParseTableInsertField()
	{
		return new Column
		{
			Name = ConsumeToken(TokenType.IDENT)
		};
	}

	internal ColumnIdentifier ParseTableUpdateField()
	{
		return ParseColumnIdentifier().Identifier;
	}

	internal List<Projection> ParseDocumentProjection()
	{
		allowRelationalColumns = false;
		return ParseCommaSeparatedList(delegate
		{
			Projection projection = new Projection
			{
				Source = GetExpr()
			};
			if (CurrentTokenTypeEquals(TokenType.AS))
			{
				ConsumeToken(TokenType.AS);
				projection.Alias = ConsumeToken(TokenType.IDENT);
			}
			else if (projection.Source.Identifier != null)
			{
				projection.Alias = projection.Source.Identifier.DocumentPath[0].Value;
			}
			return projection;
		});
	}

	internal List<Expr> ParseExprList()
	{
		return ParseCommaSeparatedList(GetExpr);
	}

	public int GetPositionalPlaceholderCount()
	{
		return positionalPlaceholderCount;
	}

	public Dictionary<string, int> GetPlaceholderNameToPositionMap()
	{
		return placeholderNameToPosition;
	}
}
