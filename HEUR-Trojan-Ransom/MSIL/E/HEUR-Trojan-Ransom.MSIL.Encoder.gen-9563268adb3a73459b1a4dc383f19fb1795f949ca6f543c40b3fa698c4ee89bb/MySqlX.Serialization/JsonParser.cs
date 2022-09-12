using System;
using System.Collections.Generic;
using System.Globalization;
using MySqlX.XDevAPI;

namespace MySqlX.Serialization;

public class JsonParser
{
	private int _pos;

	private string _input;

	public static Dictionary<string, object> Parse(string s)
	{
		return new JsonParser().ParseInternal(s);
	}

	private Dictionary<string, object> ParseInternal(string s)
	{
		_input = s;
		Dictionary<string, object> result = ReadGroup();
		if (_pos != _input.Length)
		{
			throw new IndexOutOfRangeException("It's not the end of stream.");
		}
		return result;
	}

	private Dictionary<string, object> ReadGroup()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		RequireToken('{');
		if (PeekToken() != '}')
		{
			while (true)
			{
				string text = ReadQuotedToken();
				if (text == null)
				{
					break;
				}
				RequireToken(':');
				object obj2 = (dictionary[text] = ReadValue());
				if (PeekToken() == '}')
				{
					break;
				}
				RequireToken(',');
			}
		}
		RequireToken('}');
		return dictionary;
	}

	private object ReadValue()
	{
		switch (PeekToken())
		{
		case '"':
			return ReadQuotedToken();
		case '{':
			return ReadGroup();
		case '[':
			return ReadArray();
		default:
		{
			string text = ReadUntilToken(',', '}', ']');
			if (bool.TryParse(text, out var result))
			{
				return result;
			}
			if (text.Trim() == "null")
			{
				return null;
			}
			if (int.TryParse(text, out var result2))
			{
				return result2;
			}
			if (long.TryParse(text, out var result3))
			{
				return result3;
			}
			if (double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out var result4))
			{
				return result4;
			}
			int num = 0;
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '(')
				{
					num++;
				}
				else if (text[i] == ')')
				{
					num--;
				}
			}
			while (num > 0)
			{
				text = text + ReadUntilToken(')') + ")";
				RequireToken(')');
				num--;
			}
			return new MySqlExpression(text);
		}
		}
	}

	private object[] ReadArray()
	{
		List<object> list = new List<object>();
		RequireToken('[');
		while (true)
		{
			list.Add(ReadValue());
			if (PeekToken() == ']')
			{
				break;
			}
			RequireToken(',');
		}
		RequireToken(']');
		return list.ToArray();
	}

	private char PeekToken()
	{
		SkipWhite();
		if (_pos == _input.Length)
		{
			throw new Exception("Unexpected end of stream found.");
		}
		return _input[_pos];
	}

	private string ReadQuotedToken()
	{
		RequireToken('"');
		string result = ReadUntilToken('"');
		RequireToken('"');
		return result;
	}

	private bool TokenInGroup(char[] tokens, char c)
	{
		int num = 0;
		while (true)
		{
			if (num < tokens.Length)
			{
				if (tokens[num] == c)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private string ReadUntilToken(params char[] end)
	{
		string text = "";
		bool flag = false;
		while (true)
		{
			if (_pos < _input.Length)
			{
				char c = _input[_pos++];
				if (!flag)
				{
					if (c == '\\')
					{
						flag = true;
					}
					else if (TokenInGroup(end, c))
					{
						break;
					}
				}
				else if (c == '"')
				{
					flag = false;
				}
				text += c;
				continue;
			}
			throw new Exception("Failed to find ending '\"' while reading stream.");
		}
		_pos--;
		return text;
	}

	private void RequireToken(char token)
	{
		if (!ReadToken(token))
		{
			throw new Exception("Expected token '" + token + "'");
		}
	}

	private bool ReadToken(char token)
	{
		SkipWhite();
		if (_pos == _input.Length)
		{
			return false;
		}
		return _input[_pos++] == token;
	}

	private void SkipWhite()
	{
		while (char.IsWhiteSpace(_input[_pos]))
		{
			_pos++;
		}
	}
}
