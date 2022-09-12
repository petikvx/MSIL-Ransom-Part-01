using System;
using System.Collections.Generic;
using System.Text;

namespace MySql.Data.Common;

internal class MySqlTokenizer
{
	private string _sql;

	public string Text
	{
		get
		{
			return _sql;
		}
		set
		{
			_sql = value;
			Position = 0;
		}
	}

	public bool AnsiQuotes { get; set; }

	public bool BackslashEscapes { get; set; }

	public bool MultiLine { get; set; }

	public bool SqlServerMode { get; set; }

	public bool Quoted { get; private set; }

	public bool IsComment { get; private set; }

	public int StartIndex { get; set; }

	public int StopIndex { get; set; }

	public int Position { get; set; }

	public bool ReturnComments { get; set; }

	public MySqlTokenizer()
	{
		BackslashEscapes = true;
		MultiLine = true;
		Position = 0;
	}

	public MySqlTokenizer(string input)
		: this()
	{
		_sql = input;
	}

	public List<string> GetAllTokens()
	{
		List<string> list = new List<string>();
		for (string text = NextToken(); text != null; text = NextToken())
		{
			list.Add(text);
		}
		return list;
	}

	public string NextToken()
	{
		if (!FindToken())
		{
			return null;
		}
		return _sql.Substring(StartIndex, StopIndex - StartIndex);
	}

	public static bool IsParameter(string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			return false;
		}
		if (s[0] == '?')
		{
			return true;
		}
		if (s.Length > 1 && s[0] == '@')
		{
			return s[1] != '@';
		}
		return false;
	}

	public string NextParameter()
	{
		while (true)
		{
			if (FindToken())
			{
				if (StopIndex - StartIndex < 2)
				{
					continue;
				}
				char c = _sql[StartIndex];
				char c2 = _sql[StartIndex + 1];
				switch (c)
				{
				case '@':
					if (c2 == '@')
					{
						continue;
					}
					break;
				default:
					continue;
				case '?':
					break;
				}
				break;
			}
			return null;
		}
		return _sql.Substring(StartIndex, StopIndex - StartIndex);
	}

	public bool FindToken()
	{
		Quoted = false;
		IsComment = false;
		int num = -1;
		StopIndex = -1;
		StartIndex = -1;
		while (true)
		{
			if (Position < _sql.Length)
			{
				char c = _sql[Position++];
				if (char.IsWhiteSpace(c))
				{
					continue;
				}
				if (c != '`' && c != '\'' && c != '"' && (c != '[' || !SqlServerMode))
				{
					if (c != '#' && c != '-' && c != '/')
					{
						ReadUnquotedToken();
					}
					else if (!ReadComment(c))
					{
						ReadSpecialToken();
					}
				}
				else
				{
					ReadQuotedToken(c);
				}
				if (StartIndex != -1)
				{
					break;
				}
				continue;
			}
			return false;
		}
		return true;
	}

	public string ReadParenthesis()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		_ = StartIndex;
		string text = NextToken();
		while (true)
		{
			if (text != null)
			{
				stringBuilder.Append(text);
				if (text == ")" && !Quoted)
				{
					break;
				}
				text = NextToken();
				continue;
			}
			throw new InvalidOperationException("Unable to parse SQL");
		}
		return stringBuilder.ToString();
	}

	private bool ReadComment(char c)
	{
		if (c == '/' && (Position >= _sql.Length || _sql[Position] != '*'))
		{
			return false;
		}
		if (c == '-' && (Position + 1 >= _sql.Length || _sql[Position] != '-' || _sql[Position + 1] != ' '))
		{
			return false;
		}
		string text = "\n";
		if (_sql[Position] == '*')
		{
			text = "*/";
		}
		int startIndex = Position - 1;
		int num = _sql.IndexOf(text, Position);
		if (text == "\n")
		{
			num = _sql.IndexOf('\n', Position);
		}
		num = (Position = ((num != -1) ? (num + text.Length) : (_sql.Length - 1)));
		if (ReturnComments)
		{
			StartIndex = startIndex;
			StopIndex = num;
			IsComment = true;
		}
		return true;
	}

	private void CalculatePosition(int start, int stop)
	{
		StartIndex = start;
		StopIndex = stop;
		_ = MultiLine;
	}

	private void ReadUnquotedToken()
	{
		StartIndex = Position - 1;
		if (!IsSpecialCharacter(_sql[StartIndex]))
		{
			while (Position < _sql.Length)
			{
				char c = _sql[Position];
				if (char.IsWhiteSpace(c) || IsSpecialCharacter(c))
				{
					break;
				}
				Position++;
			}
		}
		Quoted = false;
		StopIndex = Position;
	}

	private void ReadSpecialToken()
	{
		StartIndex = Position - 1;
		StopIndex = Position;
		Quoted = false;
	}

	private void ReadQuotedToken(char quoteChar)
	{
		if (quoteChar == '[')
		{
			quoteChar = ']';
		}
		StartIndex = Position - 1;
		bool flag = false;
		bool flag2 = false;
		while (Position < _sql.Length)
		{
			char c = _sql[Position];
			if (c != quoteChar || flag)
			{
				if (flag)
				{
					flag = false;
				}
				else if (c == '\\' && BackslashEscapes)
				{
					flag = true;
				}
				Position++;
				continue;
			}
			flag2 = true;
			break;
		}
		if (flag2)
		{
			Position++;
		}
		Quoted = flag2;
		StopIndex = Position;
	}

	private bool IsQuoteChar(char c)
	{
		if (c != '`' && c != '\'')
		{
			return c == '"';
		}
		return true;
	}

	private bool IsParameterMarker(char c)
	{
		if (c != '@')
		{
			return c == '?';
		}
		return true;
	}

	private bool IsSpecialCharacter(char c)
	{
		if (!char.IsLetterOrDigit(c) && c != '$' && c != '_' && c != '.')
		{
			if (IsParameterMarker(c))
			{
				return false;
			}
			return true;
		}
		return false;
	}
}
