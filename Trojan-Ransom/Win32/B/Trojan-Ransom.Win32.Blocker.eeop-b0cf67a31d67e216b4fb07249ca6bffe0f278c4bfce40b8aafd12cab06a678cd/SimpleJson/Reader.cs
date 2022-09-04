using System;
using System.Collections;
using System.Globalization;
using System.Text;
using e9a0jRW7WM0ZtAYBQW;

namespace SimpleJson;

public class Reader
{
	protected string _src;

	protected int _length;

	protected int _offset;

	public string Source => _src;

	public bool Eol => _length <= _offset;

	public override string ToString()
	{
		return _src;
	}

	protected static bool IsNumeric(char c, bool isFirst)
	{
		if ('-' != c && !char.IsDigit(c))
		{
			if (!isFirst)
			{
				if ('.' != c && 'e' != c)
				{
					return 'E' == c;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	protected static bool IsNumeric(char c)
	{
		return IsNumeric(c, isFirst: false);
	}

	protected static bool IsWhitespace(char c)
	{
		if (' ' != c && '\t' != c && '\r' != c)
		{
			return '\n' == c;
		}
		return true;
	}

	protected static bool IsSeparator(char c)
	{
		if (',' != c)
		{
			return ':' == c;
		}
		return true;
	}

	protected object ReadNumber()
	{
		StringBuilder stringBuilder = new StringBuilder();
		do
		{
			stringBuilder.Append(_src[_offset++]);
		}
		while (!Eol && IsNumeric(_src[_offset]));
		string text = stringBuilder.ToString();
		return (text.Contains(".") || text.Contains("e") || text.Contains("E")) ? double.Parse(text.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator), NumberStyles.Float) : ((double)int.Parse(text, NumberStyles.Integer));
	}

	protected string ReadString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		while (!Eol)
		{
			_offset++;
			char c = _src[_offset];
			if ('"' != c)
			{
				if ('\\' == c)
				{
					_offset++;
					c = _src[_offset];
					switch (c)
					{
					case 'f':
						c = '\f';
						break;
					case 'b':
						c = '\b';
						break;
					case 'r':
						c = '\r';
						break;
					case 't':
						c = '\t';
						break;
					case 'u':
						c = Convert.ToChar(int.Parse(_src.Substring(_offset + 1, 4), NumberStyles.AllowHexSpecifier));
						_offset += 4;
						break;
					case 'n':
						c = '\n';
						break;
					}
				}
				stringBuilder.Append(c);
				continue;
			}
			_offset++;
			break;
		}
		return stringBuilder.ToString();
	}

	protected IList ReadList()
	{
		ArrayList arrayList = new ArrayList();
		while (!Eol)
		{
			object obj = ReadToken();
			if (obj is FinalToken)
			{
				break;
			}
			arrayList.Add(obj);
		}
		return arrayList;
	}

	protected IDictionary ReadDictionary()
	{
		Hashtable hashtable = new Hashtable();
		while (!Eol)
		{
			object obj = ReadToken();
			if (obj is FinalToken)
			{
				break;
			}
			hashtable.Add((string)obj, ReadToken());
		}
		return hashtable;
	}

	protected object ReadToken()
	{
		char c;
		while (true)
		{
			if (!Eol)
			{
				c = _src[_offset];
				if (!IsWhitespace(c) && !IsSeparator(c))
				{
					break;
				}
				_offset++;
				continue;
			}
			return null;
		}
		if ('n' == c)
		{
			_offset += 4;
			return null;
		}
		if ('t' == c)
		{
			_offset += 4;
			return true;
		}
		if ('f' == c)
		{
			_offset += 5;
			return false;
		}
		if (IsNumeric(c, isFirst: true))
		{
			return ReadNumber();
		}
		if ('"' == c)
		{
			return ReadString();
		}
		if ('[' == c)
		{
			_offset++;
			return ReadList();
		}
		if ('{' == c)
		{
			_offset++;
			return ReadDictionary();
		}
		if (']' != c && '}' != c)
		{
			throw new FormatException();
		}
		_offset++;
		return new FinalToken();
	}

	public Reader(string src)
	{
		eZTsNS9ebAJySZpK7R.eLHe04W3E();
		_length = -1;
		base._002Ector();
		_src = src;
		_length = src?.Length ?? (-1);
	}

	public ICollection Read()
	{
		_offset = 0;
		return (ICollection)ReadToken();
	}

	public static ICollection Read(string src)
	{
		return new Reader(src).Read();
	}
}
