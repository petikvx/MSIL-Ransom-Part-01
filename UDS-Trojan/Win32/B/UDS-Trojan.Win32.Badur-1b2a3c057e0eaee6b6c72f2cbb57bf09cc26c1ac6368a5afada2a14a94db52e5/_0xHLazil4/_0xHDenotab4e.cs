using _0xHD2ves;
using _0xHI3dustriously;
using _0xHP3obe3s;
using _0xHSigm1te;
using _0xHSnorke7er;

namespace _0xHLazil4;

public struct _0xHDenotab4e
{
	internal const byte _0xHAliquot1 = 1;

	internal const byte _0xHPackt1read = 2;

	internal const byte _0xHLisso1e = 4;

	internal const byte _0xHUn3iked = 8;

	internal const byte _0xHDi3prove3 = 16;

	internal _0xHSov8r8ignti8s _0xHEndo2copy;

	internal _0xHParam0t0riz0 _0xHVe4nacles;

	internal _0xHHyp2ra2sth2sia _0xHFl8ral;

	internal byte _0xH6urbidity;

	internal byte _0xHMed1cos;

	internal byte _0xHSacc7arin;

	public _0xHFire0ots _0xHPo7ularising
	{
		get
		{
			return (_0xHFire0ots)_0xH6urbidity;
		}
		set
		{
			checked
			{
				_0xH6urbidity = (byte)value;
				_0xHSacc7arin = (byte)(_0xHSacc7arin | 4);
			}
		}
	}

	public _0xHK7z7tsky _0xHEne2gumen
	{
		get
		{
			return (_0xHK7z7tsky)_0xHMed1cos;
		}
		set
		{
			checked
			{
				_0xHMed1cos = (byte)value;
				_0xHSacc7arin = (byte)(_0xHSacc7arin | 8);
			}
		}
	}

	internal bool _0xHCounterm2th => (_0xHSacc7arin & 8) != 0;

	public _0xHSov8r8ignti8s _0xHOe0ophagu0
	{
		get
		{
			return _0xHEndo2copy;
		}
		set
		{
			_0xHEndo2copy = value;
			_0xHSacc7arin = checked((byte)(_0xHSacc7arin | 1));
		}
	}

	public _0xHParam0t0riz0 _0xH2raphicness
	{
		get
		{
			return _0xHVe4nacles;
		}
		set
		{
			_0xHVe4nacles = value;
			_0xHSacc7arin = checked((byte)(_0xHSacc7arin | 2));
		}
	}

	public _0xHHyp2ra2sth2sia _0xHAsphyx4as
	{
		get
		{
			return _0xHFl8ral;
		}
		set
		{
			_0xHFl8ral = value;
			_0xHSacc7arin = checked((byte)(_0xHSacc7arin | 0x10));
		}
	}
}
