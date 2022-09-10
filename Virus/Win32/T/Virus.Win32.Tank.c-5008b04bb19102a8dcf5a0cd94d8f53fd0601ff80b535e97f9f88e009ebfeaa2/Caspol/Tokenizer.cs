using System.IO;
using System.Text;

namespace Caspol;

internal class Tokenizer
{
	internal interface ITokenReader
	{
		int Peek();

		int Read();
	}

	internal class ByteTokenReader : ITokenReader
	{
		private byte[] _array;

		private int _currentIndex;

		private int _arraySize;

		internal ByteTokenReader(byte[] array)
		{
			_array = array;
			_currentIndex = 0;
			_arraySize = array.Length;
		}

		public virtual int Peek()
		{
			if (_currentIndex == _arraySize)
			{
				return -1;
			}
			return _array[_currentIndex];
		}

		public virtual int Read()
		{
			if (_currentIndex == _arraySize)
			{
				return -1;
			}
			return _array[_currentIndex++];
		}
	}

	internal class StringTokenReader : ITokenReader
	{
		private string _input;

		private int _currentIndex;

		private int _inputSize;

		internal StringTokenReader(string input)
		{
			_input = input;
			_currentIndex = 0;
			_inputSize = input.Length;
		}

		public virtual int Peek()
		{
			if (_currentIndex == _inputSize)
			{
				return -1;
			}
			return _input[_currentIndex];
		}

		public virtual int Read()
		{
			if (_currentIndex == _inputSize)
			{
				return -1;
			}
			return _input[_currentIndex++];
		}
	}

	internal class CharTokenReader : ITokenReader
	{
		private char[] _array;

		private int _currentIndex;

		private int _arraySize;

		internal CharTokenReader(char[] array)
		{
			_array = array;
			_currentIndex = 0;
			_arraySize = array.Length;
		}

		public virtual int Peek()
		{
			if (_currentIndex == _arraySize)
			{
				return -1;
			}
			return _array[_currentIndex];
		}

		public virtual int Read()
		{
			if (_currentIndex == _arraySize)
			{
				return -1;
			}
			return _array[_currentIndex++];
		}
	}

	internal class TokenReader : ITokenReader
	{
		private BinaryReader _in;

		internal TokenReader(BinaryReader input)
		{
			_in = input;
		}

		public virtual int Peek()
		{
			return _in.PeekChar();
		}

		public virtual int Read()
		{
			return _in.Read();
		}
	}

	internal class StreamTokenReader : ITokenReader
	{
		internal StreamReader _in;

		internal int _numCharRead;

		internal int NumCharEncountered => _numCharRead;

		internal StreamTokenReader(StreamReader input)
		{
			_in = input;
			_numCharRead = 0;
		}

		public virtual int Peek()
		{
			return _in.Peek();
		}

		public virtual int Read()
		{
			int num = _in.Read();
			if (num != -1)
			{
				_numCharRead++;
			}
			return num;
		}
	}

	private const int _sbmaxsize = 128;

	internal const int bra = 0;

	internal const int ket = 1;

	internal const int slash = 2;

	internal const int cstr = 3;

	internal const int equals = 4;

	internal const int quest = 5;

	internal const int bang = 6;

	internal const int dash = 7;

	internal const int intOpenBracket = 60;

	internal const int intCloseBracket = 62;

	internal const int intSlash = 47;

	internal const int intEquals = 61;

	internal const int intQuote = 34;

	internal const int intQuest = 63;

	internal const int intBang = 33;

	internal const int intDash = 45;

	private ITokenReader _input;

	private bool _fintag;

	private StringBuilder _cstr;

	private char[] _sbarray;

	private int _sbindex;

	public int LineNo;

	internal Tokenizer(string input)
	{
		LineNo = 1;
		_fintag = false;
		_cstr = null;
		_input = new StringTokenReader(input);
		_sbarray = new char[128];
		_sbindex = 0;
	}

	internal Tokenizer(BinaryReader input)
	{
		LineNo = 1;
		_fintag = false;
		_cstr = null;
		_input = new TokenReader(input);
		_sbarray = new char[128];
		_sbindex = 0;
	}

	internal Tokenizer(byte[] array)
	{
		LineNo = 1;
		_fintag = false;
		_cstr = null;
		_input = new ByteTokenReader(array);
		_sbarray = new char[128];
		_sbindex = 0;
	}

	internal Tokenizer(char[] array)
	{
		LineNo = 1;
		_fintag = false;
		_cstr = null;
		_input = new CharTokenReader(array);
		_sbarray = new char[128];
		_sbindex = 0;
	}

	internal Tokenizer(StreamReader input)
	{
		LineNo = 1;
		_fintag = false;
		_cstr = null;
		_input = new StreamTokenReader(input);
		_sbarray = new char[128];
		_sbindex = 0;
	}

	internal Tokenizer(Stream input)
	{
		LineNo = 1;
		_fintag = false;
		_cstr = null;
		_input = new StreamTokenReader(new StreamReader(input));
		_sbarray = new char[128];
		_sbindex = 0;
	}

	internal void ChangeFormat(Encoding encoding)
	{
		if (encoding != null && _input is StreamTokenReader streamTokenReader)
		{
			Stream baseStream = streamTokenReader._in.BaseStream;
			string s = new string(new char[checked((uint)streamTokenReader.NumCharEncountered)]);
			baseStream.Position = streamTokenReader._in.CurrentEncoding.GetByteCount(s);
			_input = new StreamTokenReader(new StreamReader(baseStream, encoding));
		}
	}

	internal Encoding GetEncoding()
	{
		if (!(_input is StreamTokenReader streamTokenReader))
		{
			return null;
		}
		return streamTokenReader._in.CurrentEncoding;
	}

	private bool FIsWhite(int j)
	{
		if (j == 10 && _input.Peek() != -1)
		{
			LineNo++;
		}
		return j == 32 || j == 9 || j == 13 || j == 10;
	}

	private void SBArrayAppend(char c)
	{
		if (_sbindex != 128)
		{
			_sbarray[_sbindex] = c;
			_sbindex++;
			return;
		}
		if (_cstr == null)
		{
			_cstr = new StringBuilder();
		}
		_cstr.Append(_sbarray, 0, 128);
		_sbarray[0] = c;
		_sbindex = 1;
	}

	internal int NextTokenType()
	{
		_cstr = null;
		_sbindex = 0;
		int num = _input.Read();
		while (true)
		{
			switch (num)
			{
			case 63:
				if (_fintag)
				{
					return 5;
				}
				goto default;
			case 45:
				if (_fintag)
				{
					return 7;
				}
				goto default;
			case 47:
				if (_fintag)
				{
					return 2;
				}
				goto default;
			default:
			{
				if (FIsWhite(num))
				{
					do
					{
						num = _input.Read();
					}
					while (FIsWhite(num));
					break;
				}
				bool flag = false;
				if (num == 34)
				{
					flag = true;
					num = _input.Read();
					if (num == 34)
					{
						return 3;
					}
				}
				while (true)
				{
					SBArrayAppend((char)num);
					num = _input.Peek();
					if (flag || (!FIsWhite(num) && num != 60 && (!_fintag || (num != 62 && num != 61 && num != 47))))
					{
						_input.Read();
						if (num != 34 || !flag)
						{
							if (num == -1)
							{
								break;
							}
							continue;
						}
					}
					return 3;
				}
				return -1;
			}
			case 33:
				if (_fintag)
				{
					return 6;
				}
				goto default;
			case -1:
				return -1;
			case 60:
				_fintag = true;
				return 0;
			case 61:
				return 4;
			case 62:
				_fintag = false;
				return 1;
			}
		}
	}

	internal string GetStringToken()
	{
		if (_cstr == null)
		{
			if (_sbindex == 0)
			{
				return "";
			}
			return new string(_sbarray, 0, _sbindex);
		}
		_cstr.Append(_sbarray, 0, _sbindex);
		return _cstr.ToString();
	}
}
