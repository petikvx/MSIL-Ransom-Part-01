using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AjScript.Interpreter;

public class Lexer : IDisposable
{
	private const char StringChar = '"';

	private const char QuotedStringChar = '\'';

	private const string Operators = "!~+-*/%&|^<>=.\\@";

	private const string Separators = "()[]{},:;";

	private static string[] otherOperators = new string[15]
	{
		"++", "--", "<=", ">=", "==", "!=", "&&", "||", "*=", "/=",
		"%=", "+=", "-=", "===", "!=="
	};

	private TextReader reader;

	private Stack<Token> tokens;

	private char lastChar;

	private bool hasChar;

	private bool isConsole;

	private bool isFirstChar = true;

	public Lexer(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		reader = new StringReader(text);
		isConsole = false;
	}

	public Lexer(TextReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		this.reader = reader;
		isConsole = reader.Equals(Console.In);
	}

	public Token PeekToken()
	{
		Token token = NextToken();
		PushToken(token);
		return token;
	}

	public Token NextToken()
	{
		if (tokens != null && tokens.Count > 0)
		{
			return tokens.Pop();
		}
		char c;
		try
		{
			c = NextCharSkipBlanks();
		}
		catch (EndOfInputException)
		{
			return null;
		}
		if (char.IsDigit(c))
		{
			return NextInteger(c);
		}
		if (!char.IsLetter(c))
		{
			switch (c)
			{
			case '"':
				return NextString();
			case '\'':
				return NextQuotedString();
			default:
				if (Enumerable.Contains("()[]{},:;", c))
				{
					return NextSeparator(c);
				}
				if (Enumerable.Contains("!~+-*/%&|^<>=.\\@", c))
				{
					return NextOperator(c);
				}
				throw new InvalidDataException(string.Format(CultureInfo.InvariantCulture, "Unknown input '{0}'", new object[1] { c }));
			case '_':
				break;
			}
		}
		return NextName(c);
	}

	public void Dispose()
	{
		Dispose(dispose: true);
		GC.SuppressFinalize(this);
	}

	public void Dispose(bool dispose)
	{
		if (dispose && reader != null)
		{
			reader.Dispose();
		}
	}

	public void PushToken(Token token)
	{
		if (tokens == null)
		{
			tokens = new Stack<Token>();
		}
		tokens.Push(token);
	}

	private Token NextOperator(char ch)
	{
		try
		{
			char ch2 = NextChar();
			string text = ch.ToString() + ch2;
			if (otherOperators.Contains(text))
			{
				try
				{
					char ch3 = NextChar();
					string value = text + ch3;
					if (otherOperators.Contains(value))
					{
						return new Token
						{
							TokenType = TokenType.Operator,
							Value = value
						};
					}
					PushChar(ch3);
				}
				catch (EndOfInputException)
				{
				}
				return new Token
				{
					TokenType = TokenType.Operator,
					Value = text
				};
			}
			PushChar(ch2);
		}
		catch (EndOfInputException)
		{
		}
		return new Token
		{
			TokenType = TokenType.Operator,
			Value = ch.ToString()
		};
	}

	private Token NextSeparator(char ch)
	{
		return new Token
		{
			TokenType = TokenType.Separator,
			Value = ch.ToString()
		};
	}

	private Token NextString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		char c = '\0';
		char c2 = NextChar();
		while (c2 != '"' || c == '\\')
		{
			if (c == '\\')
			{
				switch (c2)
				{
				case 'a':
					stringBuilder.Length--;
					stringBuilder.Append('\a');
					break;
				case 'b':
					stringBuilder.Length--;
					stringBuilder.Append('\b');
					break;
				case 'e':
					stringBuilder.Length--;
					stringBuilder.Append('\u001b');
					break;
				case 'f':
					stringBuilder.Length--;
					stringBuilder.Append('\f');
					break;
				case 'r':
					stringBuilder.Length--;
					stringBuilder.Append('\r');
					break;
				case 't':
					stringBuilder.Length--;
					stringBuilder.Append('\t');
					break;
				default:
					stringBuilder.Length--;
					stringBuilder.Append(c2);
					break;
				case 'v':
					stringBuilder.Length--;
					stringBuilder.Append('\v');
					break;
				case 'n':
					stringBuilder.Length--;
					stringBuilder.Append('\n');
					break;
				case '\\':
					break;
				}
				c = '\0';
			}
			else
			{
				stringBuilder.Append(c2);
				c = c2;
			}
			c2 = NextChar();
		}
		return new Token
		{
			Value = stringBuilder.ToString(),
			TokenType = TokenType.String
		};
	}

	private Token NextQuotedString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (char c = NextChar(); c != '\''; c = NextChar())
		{
			stringBuilder.Append(c);
		}
		return new Token
		{
			Value = stringBuilder.ToString(),
			TokenType = TokenType.String
		};
	}

	private Token NextInteger(char ch)
	{
		string text = ch.ToString();
		try
		{
			ch = NextChar();
			while (char.IsDigit(ch))
			{
				text += ch;
				ch = NextChar();
			}
			if (ch == '.')
			{
				return NextReal(text);
			}
			PushChar(ch);
		}
		catch (EndOfInputException)
		{
		}
		return new Token
		{
			Value = text,
			TokenType = TokenType.Integer
		};
	}

	private Token NextReal(string integerPart)
	{
		string text = integerPart + ".";
		try
		{
			char c = NextChar();
			while (char.IsDigit(c))
			{
				text += c;
				c = NextChar();
			}
			PushChar(c);
		}
		catch (EndOfInputException)
		{
		}
		return new Token
		{
			Value = text,
			TokenType = TokenType.Real
		};
	}

	private Token NextName(char ch)
	{
		string text = ch.ToString();
		try
		{
			ch = NextChar();
			while (char.IsLetterOrDigit(ch) || ch == '_')
			{
				text += ch;
				ch = NextChar();
			}
			PushChar(ch);
		}
		catch (EndOfInputException)
		{
		}
		Token token = new Token();
		token.Value = text;
		token.TokenType = TokenType.Name;
		if (text == "true" || text == "false")
		{
			token.TokenType = TokenType.Boolean;
		}
		if (text == "null" || text == "undefined")
		{
			token.TokenType = TokenType.Object;
		}
		return token;
	}

	private char NextCharSkipBlanks()
	{
		char c = NextChar();
		while (char.IsWhiteSpace(c) || c == '/')
		{
			if (c == '/')
			{
				char c2 = NextChar();
				switch (c2)
				{
				case '/':
					SkipToEndOfLine();
					break;
				case '*':
					SkipToEndOfComment();
					break;
				default:
					PushChar(c2);
					return c;
				}
			}
			c = NextChar();
		}
		return c;
	}

	private void SkipToEndOfLine()
	{
		char c = NextChar();
		while (c != '\r' && c != '\n')
		{
			c = NextChar();
		}
		PushChar(c);
	}

	private void SkipToEndOfComment()
	{
		char c = NextChar();
		while (true)
		{
			if (c != '*')
			{
				c = NextChar();
				continue;
			}
			char c2 = NextChar();
			if (c2 == '/')
			{
				break;
			}
			c = c2;
		}
	}

	private void PushChar(char ch)
	{
		lastChar = ch;
		hasChar = true;
	}

	private char NextChar()
	{
		if (hasChar)
		{
			hasChar = false;
			return lastChar;
		}
		if (isConsole && (isFirstChar || reader.Peek() < 0))
		{
			Console.Out.Write("> ");
			Console.Out.Flush();
		}
		isFirstChar = false;
		int num = reader.Read();
		if (num < 0)
		{
			throw new EndOfInputException();
		}
		return Convert.ToChar(num);
	}
}
