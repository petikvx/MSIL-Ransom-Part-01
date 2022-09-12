using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MySql.Data.Common;

internal class QueryNormalizer
{
	private static readonly List<string> Keywords;

	private readonly List<Token> _tokens = new List<Token>();

	private int _pos;

	private string _fullSql;

	private string _queryType;

	public string QueryType => _queryType;

	static QueryNormalizer()
	{
		Keywords = new List<string>();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = "MySql.Data.keywords.txt";
		using Stream stream = executingAssembly.GetManifestResourceStream(text);
		if (stream == null)
		{
			throw new Exception("Resource " + text + " not found in " + executingAssembly.FullName + ".");
		}
		using StreamReader streamReader = new StreamReader(stream);
		for (string text2 = streamReader.ReadLine(); text2 != null; text2 = streamReader.ReadLine())
		{
			Keywords.Add(text2);
		}
	}

	public string Normalize(string sql)
	{
		_tokens.Clear();
		StringBuilder stringBuilder = new StringBuilder();
		_fullSql = sql;
		TokenizeSql(sql);
		DetermineStatementType(_tokens);
		ProcessMathSymbols(_tokens);
		CollapseValueLists(_tokens);
		CollapseInLists(_tokens);
		CollapseWhitespace(_tokens);
		foreach (Token item in _tokens.Where((Token t) => t.Output))
		{
			stringBuilder.Append(item.Text);
		}
		return stringBuilder.ToString();
	}

	private void DetermineStatementType(List<Token> tok)
	{
		using IEnumerator<Token> enumerator = tok.Where((Token t) => t.Type == TokenType.Keyword).GetEnumerator();
		if (enumerator.MoveNext())
		{
			Token current = enumerator.Current;
			_queryType = current.Text.ToUpperInvariant();
		}
	}

	private static void ProcessMathSymbols(List<Token> tok)
	{
		Token token = null;
		foreach (Token item in tok)
		{
			if (item.Type == TokenType.Symbol && (item.Text == "-" || item.Text == "+") && token != null && token.Type != TokenType.Number && token.Type != TokenType.Identifier && (token.Type != TokenType.Symbol || token.Text != ")"))
			{
				item.Output = false;
			}
			if (item.IsRealToken)
			{
				token = item;
			}
		}
	}

	private static void CollapseWhitespace(List<Token> tok)
	{
		Token token = null;
		foreach (Token item in tok)
		{
			if (item.Output && item.Type == TokenType.Whitespace && token != null && token.Type == TokenType.Whitespace)
			{
				item.Output = false;
			}
			if (item.Output)
			{
				token = item;
			}
		}
	}

	private void CollapseValueLists(List<Token> tok)
	{
		int pos = -1;
		while (++pos < tok.Count)
		{
			Token token = tok[pos];
			if (token.Type == TokenType.Keyword && token.Text.StartsWith("VALUE", StringComparison.OrdinalIgnoreCase))
			{
				CollapseValueList(tok, ref pos);
			}
		}
	}

	private void CollapseValueList(List<Token> tok, ref int pos)
	{
		List<int> list = new List<int>();
		while (true)
		{
			if (++pos >= tok.Count || (tok[pos].Type == TokenType.Symbol && tok[pos].Text == ")") || pos == tok.Count - 1)
			{
				list.Add(pos);
				while (++pos < tok.Count && !tok[pos].IsRealToken)
				{
				}
				if (pos == tok.Count)
				{
					break;
				}
				if (!(tok[pos].Text == ","))
				{
					pos--;
					break;
				}
			}
		}
		if (list.Count >= 2)
		{
			int num = list[0];
			tok[++num] = new Token(TokenType.Whitespace, " ");
			tok[++num] = new Token(TokenType.Comment, "/* , ... */");
			num++;
			while (num <= list[list.Count - 1])
			{
				tok[num++].Output = false;
			}
		}
	}

	private void CollapseInLists(List<Token> tok)
	{
		int pos = -1;
		while (++pos < tok.Count)
		{
			Token token = tok[pos];
			if (token.Type == TokenType.Keyword && !(token.Text != "IN"))
			{
				CollapseInList(tok, ref pos);
			}
		}
	}

	private static Token GetNextRealToken(List<Token> tok, ref int pos)
	{
		do
		{
			if (++pos >= tok.Count)
			{
				return null;
			}
		}
		while (!tok[pos].IsRealToken);
		return tok[pos];
	}

	private static void CollapseInList(List<Token> tok, ref int pos)
	{
		Token nextRealToken = GetNextRealToken(tok, ref pos);
		if (nextRealToken == null)
		{
			return;
		}
		nextRealToken = GetNextRealToken(tok, ref pos);
		if (nextRealToken == null || nextRealToken.Type == TokenType.Keyword)
		{
			return;
		}
		int num = pos;
		while (++pos < tok.Count)
		{
			nextRealToken = tok[pos];
			if (nextRealToken.Type == TokenType.CommandComment)
			{
				return;
			}
			if (nextRealToken.IsRealToken)
			{
				if (nextRealToken.Text == "(")
				{
					return;
				}
				if (nextRealToken.Text == ")")
				{
					break;
				}
			}
		}
		for (int num2 = pos; num2 > num; num2--)
		{
			tok.RemoveAt(num2);
		}
		tok.Insert(++num, new Token(TokenType.Whitespace, " "));
		tok.Insert(++num, new Token(TokenType.Comment, "/* , ... */"));
		tok.Insert(++num, new Token(TokenType.Whitespace, " "));
		tok.Insert(++num, new Token(TokenType.Symbol, ")"));
	}

	private void TokenizeSql(string sql)
	{
		_pos = 0;
		while (_pos < sql.Length)
		{
			char c = sql[_pos];
			if (LetterStartsComment(c) && ConsumeComment())
			{
				continue;
			}
			if (char.IsWhiteSpace(c))
			{
				ConsumeWhitespace();
			}
			else if (c != '\'' && c != '"' && c != '`')
			{
				if (!IsSpecialCharacter(c))
				{
					ConsumeUnquotedToken();
				}
				else
				{
					ConsumeSymbol();
				}
			}
			else
			{
				ConsumeQuotedToken(c);
			}
		}
	}

	private bool LetterStartsComment(char c)
	{
		if (c != '#' && c != '/')
		{
			return c == '-';
		}
		return true;
	}

	private bool IsSpecialCharacter(char c)
	{
		if (!char.IsLetterOrDigit(c) && c != '$' && c != '_')
		{
			return c != '.';
		}
		return false;
	}

	private bool ConsumeComment()
	{
		char c = _fullSql[_pos];
		if (c == '/' && (_pos + 1 >= _fullSql.Length || _fullSql[_pos + 1] != '*'))
		{
			return false;
		}
		if (c == '-' && (_pos + 2 >= _fullSql.Length || _fullSql[_pos + 1] != '-' || _fullSql[_pos + 2] != ' '))
		{
			return false;
		}
		string text = "\n";
		if (c == '/')
		{
			text = "*/";
		}
		int num = _fullSql.IndexOf(text, _pos);
		num = ((num != -1) ? (num + text.Length) : (_fullSql.Length - 1));
		string text2 = _fullSql.Substring(_pos, num - _pos);
		if (text2.StartsWith("/*!", StringComparison.Ordinal))
		{
			_tokens.Add(new Token(TokenType.CommandComment, text2));
		}
		_pos = num;
		return true;
	}

	private void ConsumeSymbol()
	{
		char c = _fullSql[_pos++];
		_tokens.Add(new Token(TokenType.Symbol, c.ToString()));
	}

	private void ConsumeQuotedToken(char c)
	{
		bool flag = false;
		int pos = _pos;
		_pos++;
		while (_pos < _fullSql.Length)
		{
			char c2 = _fullSql[_pos];
			if (c2 == c && !flag)
			{
				break;
			}
			if (flag)
			{
				flag = false;
			}
			else if (c2 == '\\')
			{
				flag = true;
			}
			_pos++;
		}
		_pos++;
		_tokens.Add((c == '\'') ? new Token(TokenType.String, "?") : new Token(TokenType.Identifier, _fullSql.Substring(pos, _pos - pos)));
	}

	private void ConsumeUnquotedToken()
	{
		int pos = _pos;
		while (_pos < _fullSql.Length && !IsSpecialCharacter(_fullSql[_pos]))
		{
			_pos++;
		}
		string text = _fullSql.Substring(pos, _pos - pos);
		if (double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out var _))
		{
			_tokens.Add(new Token(TokenType.Number, "?"));
			return;
		}
		Token token = new Token(TokenType.Identifier, text);
		if (IsKeyword(text))
		{
			token.Type = TokenType.Keyword;
			token.Text = token.Text.ToUpperInvariant();
		}
		_tokens.Add(token);
	}

	private void ConsumeWhitespace()
	{
		_tokens.Add(new Token(TokenType.Whitespace, " "));
		while (_pos < _fullSql.Length && char.IsWhiteSpace(_fullSql[_pos]))
		{
			_pos++;
		}
	}

	private static bool IsKeyword(string word)
	{
		return Keywords.Contains(word.ToUpperInvariant());
	}
}
