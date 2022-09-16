using System;
using System.Collections.Generic;
using _0xH7ifty;
using _0xHMi1ia;
using _0xHP1eudo1cience;
using _0xHSeltze6s;

namespace _0xH6yplays;

internal class _0xHSignalization1
{
	private class _0xHFistul3s
	{
		internal readonly List<_0xHSquande5s> _0xHRoache8 = new List<_0xHSquande5s>();

		internal short _0xHHy8ri8;

		internal sbyte _0xHN3ctarial;

		internal sbyte _0xH3kysurf;

		private int _0xHWash4d;

		private bool _0xHGer7nt7m7rphic;

		public void _0xHAi0shot(int _0xHG5lops)
		{
			checked
			{
				if (_0xHWash4d == 0)
				{
					if (!_0xHGer7nt7m7rphic)
					{
						_0xHN3ctarial++;
					}
					_0xHGer7nt7m7rphic = true;
					_0xHHy8ri8 = (short)(_0xHHy8ri8 + _0xHG5lops);
				}
			}
		}

		public void _0xHChromatolys5s()
		{
			checked
			{
				if (_0xHWash4d == 0)
				{
					_0xHGer7nt7m7rphic = false;
					_0xH3kysurf++;
					_0xHN3ctarial++;
				}
			}
		}

		public void _0xHReincor7orate()
		{
			if (_0xHWash4d == 0)
			{
				_0xHChromatolys5s();
			}
			checked
			{
				_0xHWash4d++;
			}
		}

		public void _0xHSno8shed()
		{
			checked
			{
				_0xHWash4d--;
			}
		}

		public int _0xHBl2ttered(byte[] _0xHRin4ed)
		{
			int _0xHTai3an = 0;
			foreach (_0xHSquande5s item in _0xHRoache8)
			{
				item._0xH4etonatable(ref _0xHTai3an, _0xHRin4ed);
			}
			return _0xHTai3an;
		}
	}

	private readonly _0xHFistul3s _0xHFlailin8;

	private readonly _0xHSquande5s _0xH5ast;

	private int _0xHPsa1ms = int.MinValue;

	internal _0xHP1mmels _0xHYode3s { get; set; }

	internal int _0xH6ocent => _0xHFlailin8._0xHHy8ri8;

	internal int _0xHTo77ee => _0xHFlailin8._0xHN3ctarial;

	internal int _0xHE4dleafs => _0xHFlailin8._0xH3kysurf;

	private bool _0xHZeste7 => _0xHPsa1ms == 0;

	internal _0xHSignalization1()
	{
		_0xHFlailin8 = new _0xHFistul3s();
	}

	private _0xHSignalization1(_0xHSignalization1 other, _0xHSquande5s group)
	{
		_0xHFlailin8 = other._0xHFlailin8;
		_0xH5ast = group;
	}

	public _0xHSignalization1 _0xHReceivable6(string _0xHTe0give0sating)
	{
		_0xHSignalization1 result = this;
		if (_0xHTe0give0sating != null || _0xHZeste7)
		{
			_0xHSquande5s _0xHSquande5s = new _0xHSquande5s(_0xHTe0give0sating, _0xHKnea0e0.Struct, _0xHP1mmels.None, _0xHZeste7);
			_0xHLa0pad(_0xHSquande5s);
			result = new _0xHSignalization1(this, _0xHSquande5s);
		}
		return result;
	}

	public void _0xHGruif1rm(string _0xHOl2o, _0xHKnea0e0 _0xHT2youts)
	{
		int _0xHG5lops;
		switch (_0xHT2youts & (_0xHKnea0e0)31)
		{
		case _0xHKnea0e0.Int8:
		case _0xHKnea0e0.UInt8:
		case _0xHKnea0e0.Char8:
			_0xHG5lops = 1;
			break;
		case _0xHKnea0e0.Int16:
		case _0xHKnea0e0.UInt16:
		case _0xHKnea0e0.Char16:
			_0xHG5lops = 2;
			break;
		case _0xHKnea0e0.Guid:
		case _0xHKnea0e0.SystemTime:
			_0xHG5lops = 16;
			break;
		default:
			throw new ArgumentOutOfRangeException("type");
		case _0xHKnea0e0.Int32:
		case _0xHKnea0e0.UInt32:
		case _0xHKnea0e0.Float:
		case _0xHKnea0e0.Boolean32:
		case _0xHKnea0e0.HexInt32:
			_0xHG5lops = 4;
			break;
		case _0xHKnea0e0.Int64:
		case _0xHKnea0e0.UInt64:
		case _0xHKnea0e0.Double:
		case _0xHKnea0e0.FileTime:
		case _0xHKnea0e0.HexInt64:
			_0xHG5lops = 8;
			break;
		}
		_0xHFlailin8._0xHAi0shot(_0xHG5lops);
		_0xHLa0pad(new _0xHSquande5s(_0xHOl2o, _0xHT2youts, _0xHYode3s, _0xHZeste7));
	}

	public void _0xHBlunder2(string _0xHQuinc6nt6nnial, _0xHKnea0e0 _0xHD4xam4thason4s)
	{
		switch (_0xHD4xam4thason4s & (_0xHKnea0e0)31)
		{
		default:
			throw new ArgumentOutOfRangeException("type");
		case _0xHKnea0e0.Binary:
		case _0xHKnea0e0.CountedUtf16String:
		case _0xHKnea0e0.CountedMbcsString:
			_0xHFlailin8._0xHAi0shot(2);
			_0xHFlailin8._0xHChromatolys5s();
			_0xHLa0pad(new _0xHSquande5s(_0xHQuinc6nt6nnial, _0xHD4xam4thason4s, _0xHYode3s, _0xHZeste7));
			break;
		}
	}

	public void _0xHLuggag6s(string _0xHHisti6in, _0xHKnea0e0 _0xHLavi5hne55)
	{
		switch (_0xHLavi5hne55 & (_0xHKnea0e0)31)
		{
		default:
			throw new ArgumentOutOfRangeException("type");
		case _0xHKnea0e0.Utf16String:
		case _0xHKnea0e0.MbcsString:
		case _0xHKnea0e0.Int8:
		case _0xHKnea0e0.UInt8:
		case _0xHKnea0e0.Int16:
		case _0xHKnea0e0.UInt16:
		case _0xHKnea0e0.Int32:
		case _0xHKnea0e0.UInt32:
		case _0xHKnea0e0.Int64:
		case _0xHKnea0e0.UInt64:
		case _0xHKnea0e0.Float:
		case _0xHKnea0e0.Double:
		case _0xHKnea0e0.Boolean32:
		case _0xHKnea0e0.Guid:
		case _0xHKnea0e0.FileTime:
		case _0xHKnea0e0.HexInt32:
		case _0xHKnea0e0.HexInt64:
		case _0xHKnea0e0.Char8:
		case _0xHKnea0e0.Char16:
			if (_0xHZeste7)
			{
				throw new NotSupportedException(_0xHA2eotropy._0xHSpon8or("EventSource_NotSupportedNestedArraysEnums"));
			}
			_0xHFlailin8._0xHAi0shot(2);
			_0xHFlailin8._0xHChromatolys5s();
			_0xHLa0pad(new _0xHSquande5s(_0xHHisti6in, _0xHLavi5hne55, _0xHYode3s, variableCount: true));
			break;
		}
	}

	public void _0xH0nserfment()
	{
		if (_0xHPsa1ms >= 0)
		{
			throw new NotSupportedException(_0xHA2eotropy._0xHSpon8or("EventSource_NotSupportedNestedArraysEnums"));
		}
		_0xHPsa1ms = 0;
		_0xHFlailin8._0xHReincor7orate();
	}

	public void _0xHDi2re2pect()
	{
		if (_0xHPsa1ms != 1)
		{
			throw new InvalidOperationException(_0xHA2eotropy._0xHSpon8or("EventSource_IncorrentlyAuthoredTypeInfo"));
		}
		_0xHPsa1ms = int.MinValue;
		_0xHFlailin8._0xHSno8shed();
	}

	public void _0xHT4chnics(string _0xHDe5initize, _0xHKnea0e0 _0xH4edlike, byte[] _0xHCr6nodes)
	{
		if (_0xHZeste7)
		{
			throw new NotSupportedException(_0xHA2eotropy._0xHSpon8or("EventSource_NotSupportedCustomSerializedData"));
		}
		_0xHFlailin8._0xHAi0shot(2);
		_0xHFlailin8._0xHChromatolys5s();
		_0xHLa0pad(new _0xHSquande5s(_0xHDe5initize, _0xH4edlike, _0xHYode3s, _0xHCr6nodes));
	}

	internal byte[] _0xH3oggia()
	{
		int num = _0xHFlailin8._0xHBl2ttered(null);
		byte[] array = new byte[num];
		_0xHFlailin8._0xHBl2ttered(array);
		return array;
	}

	private void _0xHLa0pad(_0xHSquande5s _0xHD6ers)
	{
		_0xHYode3s = _0xHP1mmels.None;
		checked
		{
			_0xHPsa1ms++;
			_0xHFlailin8._0xHRoache8.Add(_0xHD6ers);
			if (_0xH5ast != null)
			{
				_0xH5ast._0xHEquisetu2();
			}
		}
	}
}
