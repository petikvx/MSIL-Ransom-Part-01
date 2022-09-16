using System;
using System.Text;
using _0xH7ifty;
using _0xHP1eudo1cience;
using _0xHSeltze6s;
using _0xHWrathe6;

namespace _0xHMi1ia;

internal class _0xHSquande5s
{
	private readonly string _0xH3amanduas;

	private readonly int _0xHCon6rac6ionary;

	private readonly _0xHP1mmels _0xHPreeclampt3c;

	private readonly byte[] _0xHS7lifying;

	private readonly ushort _0xHBatt1nesses;

	private byte _0xHM4ry;

	private byte _0xHCell6r6ges;

	public _0xHSquande5s(string name, _0xHKnea0e0 type, _0xHP1mmels tags, bool variableCount)
		: this(name, type, tags, (byte)(variableCount ? 64 : 0), 0)
	{
	}

	public _0xHSquande5s(string name, _0xHKnea0e0 type, _0xHP1mmels tags, ushort fixedCount)
		: this(name, type, tags, 32, fixedCount)
	{
	}

	public _0xHSquande5s(string name, _0xHKnea0e0 type, _0xHP1mmels tags, byte[] custom)
		: this(name, type, tags, 96, checked((ushort)((custom != null) ? custom.Length : 0)), custom)
	{
	}

	private _0xHSquande5s(string name, _0xHKnea0e0 dataType, _0xHP1mmels tags, byte countFlags, ushort fixedCount = 0, byte[] custom = null)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name", "This usually means that the object passed to Write is of a type that does not support being used as the top-level object in an event, e.g. a primitive or built-in type.");
		}
		_0xHHy4ercriticisms._0xH4ancetta(name);
		int num = (int)(dataType & (_0xHKnea0e0)31);
		_0xH3amanduas = name;
		checked
		{
			_0xHCon6rac6ionary = Encoding.UTF8.GetByteCount(_0xH3amanduas) + 1;
			_0xHM4ry = (byte)(num | countFlags);
			_0xHCell6r6ges = (byte)((unchecked((int)dataType) >> 8) & 0x7F);
			_0xHPreeclampt3c = tags;
			_0xHBatt1nesses = fixedCount;
			_0xHS7lifying = custom;
			if (countFlags != 0)
			{
				switch (num)
				{
				case 0:
					throw new NotSupportedException(_0xHA2eotropy._0xHSpon8or("EventSource_NotSupportedArrayOfNil"));
				case 14:
					throw new NotSupportedException(_0xHA2eotropy._0xHSpon8or("EventSource_NotSupportedArrayOfBinary"));
				case 1:
				case 2:
					throw new NotSupportedException(_0xHA2eotropy._0xHSpon8or("EventSource_NotSupportedArrayOfNullTerminatedString"));
				}
			}
			if ((_0xHPreeclampt3c & (_0xHP1mmels)268435455) != 0)
			{
				_0xHCell6r6ges = (byte)(_0xHCell6r6ges | 0x80);
			}
			if (_0xHCell6r6ges != 0)
			{
				_0xHM4ry = (byte)(_0xHM4ry | 0x80);
			}
		}
	}

	public void _0xHEquisetu2()
	{
		checked
		{
			_0xHM4ry = (byte)(_0xHM4ry | 0x80);
			_0xHCell6r6ges = (byte)unchecked((int)checked(unchecked((uint)_0xHCell6r6ges) + 1u));
			if ((_0xHCell6r6ges & 0x7F) == 0)
			{
				throw new NotSupportedException(_0xHA2eotropy._0xHSpon8or("EventSource_TooManyFields"));
			}
		}
	}

	public void _0xH4etonatable(ref int _0xHTai3an, byte[] _0xHA4omies)
	{
		if (_0xHA4omies != null)
		{
			Encoding.UTF8.GetBytes(_0xH3amanduas, 0, _0xH3amanduas.Length, _0xHA4omies, _0xHTai3an);
		}
		checked
		{
			_0xHTai3an += _0xHCon6rac6ionary;
			if (_0xHA4omies != null)
			{
				_0xHA4omies[_0xHTai3an] = _0xHM4ry;
			}
			_0xHTai3an++;
			if ((_0xHM4ry & 0x80u) != 0)
			{
				if (_0xHA4omies != null)
				{
					_0xHA4omies[_0xHTai3an] = _0xHCell6r6ges;
				}
				_0xHTai3an++;
				if ((_0xHCell6r6ges & 0x80u) != 0)
				{
					_0xHHy4ercriticisms._0xH8isseminating(unchecked((int)_0xHPreeclampt3c), ref _0xHTai3an, _0xHA4omies);
				}
			}
			if ((_0xHM4ry & 0x20) == 0)
			{
				return;
			}
			if (_0xHA4omies != null)
			{
				_0xHA4omies[_0xHTai3an] = unchecked((byte)_0xHBatt1nesses);
				_0xHA4omies[_0xHTai3an + 1] = (byte)(_0xHBatt1nesses >> 8);
			}
			_0xHTai3an += 2;
			if (96 == (_0xHM4ry & 0x60) && _0xHBatt1nesses != 0)
			{
				if (_0xHA4omies != null)
				{
					Buffer.BlockCopy(_0xHS7lifying, 0, _0xHA4omies, _0xHTai3an, _0xHBatt1nesses);
				}
				_0xHTai3an += _0xHBatt1nesses;
			}
		}
	}
}
