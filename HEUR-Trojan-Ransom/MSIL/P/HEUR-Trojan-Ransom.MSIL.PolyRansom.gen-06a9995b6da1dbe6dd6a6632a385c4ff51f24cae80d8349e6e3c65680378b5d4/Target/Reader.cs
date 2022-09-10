using System;
using System.Collections;
using System.Globalization;
using System.Text;

namespace Target;

public class Reader
{
	protected int _length = -1;

	protected int _offset;

	protected string _src;

	public bool Eol => _length <= _offset;

	public string Source => _src;

	public Reader(string src)
	{
		_src = src;
		_length = src?.Length ?? (-1);
	}

	protected static bool IsNumeric(char c)
	{
		return IsNumeric(c, isFirst: false);
	}

	protected static bool IsNumeric(char c, bool isFirst)
	{
		if ('-' == c || char.IsDigit(c))
		{
			return true;
		}
		if (isFirst)
		{
			return false;
		}
		if ('.' == c || 'e' == c)
		{
			return true;
		}
		return 'E' == c;
	}

	protected static bool IsSeparator(char c)
	{
		if (',' == c)
		{
			return true;
		}
		return ':' == c;
	}

	protected static bool IsWhitespace(char c)
	{
		if (' ' == c || '\t' == c || '\r' == c)
		{
			return true;
		}
		return '\n' == c;
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

	protected IDictionary ReadDictionary()
	{
		Hashtable hashtable = new Hashtable();
		while (true)
		{
			if (!Eol)
			{
				object obj = ReadToken();
				if (obj is FinalToken)
				{
					break;
				}
				hashtable.Add((string)obj, ReadToken());
				continue;
			}
			return hashtable;
		}
		return hashtable;
	}

	protected IList ReadList()
	{
		ArrayList arrayList = new ArrayList();
		while (true)
		{
			if (!Eol)
			{
				object obj = ReadToken();
				if (obj is FinalToken)
				{
					break;
				}
				arrayList.Add(obj);
				continue;
			}
			return arrayList;
		}
		return arrayList;
	}

	protected object ReadNumber()
	{
		StringBuilder stringBuilder = new StringBuilder();
		do
		{
			string src = _src;
			int offset = _offset;
			int index = offset;
			_offset = offset + 1;
			stringBuilder.Append(src[index]);
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
					char c2 = c;
					if (c2 > 'f')
					{
						if (c2 == 'n')
						{
							c = '\n';
						}
						else
						{
							switch (c2)
							{
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
							}
						}
					}
					else
					{
						switch (c2)
						{
						case 'b':
							c = '\b';
							break;
						case 'f':
							c = '\f';
							break;
						}
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

	public override string ToString()
	{
		return _src;
	}
}
