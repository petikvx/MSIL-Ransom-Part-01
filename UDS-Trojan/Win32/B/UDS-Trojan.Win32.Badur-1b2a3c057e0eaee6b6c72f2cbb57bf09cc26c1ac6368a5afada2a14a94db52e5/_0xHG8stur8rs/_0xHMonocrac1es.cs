using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using _0xHSeltze6s;

namespace _0xHG8stur8rs;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal struct _0xHMonocrac1es
{
	[FieldOffset(0)]
	private int _0xHOve2d2awing;

	[FieldOffset(0)]
	private ushort _0xHIndor5er;

	[FieldOffset(2)]
	private byte _0xHAvau0t;

	[FieldOffset(3)]
	private byte _0xH5imners;

	[FieldOffset(4)]
	private byte _0xHPurs3;

	[FieldOffset(5)]
	private byte _0xHThuy7;

	[FieldOffset(6)]
	private ushort _0xHTeac2psf2l;

	[FieldOffset(8)]
	private long _0xHV3rus;

	public int _0xHEmer0encies => _0xHIndor5er;

	public byte _0xHInland6rs => _0xHAvau0t;

	public byte _0xHAbste2tio2 => _0xH5imners;

	public byte _0xHPu4posefully => _0xHPurs3;

	public byte _0xHS0lfinpyrazone => _0xHThuy7;

	public int _0xHMun6c6pal => _0xHTeac2psf2l;

	public long _0xHM5rc5tos => _0xHV3rus;

	public _0xHMonocrac1es(int traceloggingId, byte level, byte opcode, long keywords)
	{
		_0xHIndor5er = 0;
		_0xHAvau0t = 0;
		_0xH5imners = 0;
		_0xHOve2d2awing = traceloggingId;
		_0xHPurs3 = level;
		_0xHThuy7 = opcode;
		_0xHTeac2psf2l = 0;
		_0xHV3rus = keywords;
	}

	public _0xHMonocrac1es(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)
	{
		if (id < 0)
		{
			throw new ArgumentOutOfRangeException("id", _0xHA2eotropy._0xHSpon8or("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (id > 65535)
		{
			throw new ArgumentOutOfRangeException("id", _0xHA2eotropy._0xHSpon8or("ArgumentOutOfRange_NeedValidId", 1, ushort.MaxValue));
		}
		_0xHOve2d2awing = 0;
		checked
		{
			_0xHIndor5er = (ushort)id;
			_0xHAvau0t = version;
			_0xH5imners = channel;
			_0xHPurs3 = level;
			_0xHThuy7 = opcode;
			_0xHV3rus = keywords;
			if (task < 0)
			{
				throw new ArgumentOutOfRangeException("task", _0xHA2eotropy._0xHSpon8or("ArgumentOutOfRange_NeedNonNegNum"));
			}
			if (task > 65535)
			{
				throw new ArgumentOutOfRangeException("task", _0xHA2eotropy._0xHSpon8or("ArgumentOutOfRange_NeedValidId", 1, ushort.MaxValue));
			}
			_0xHTeac2psf2l = (ushort)task;
		}
	}

	public override bool _0xHQuadr5ll5onths(object _0xHAchie6es)
	{
		if (!(_0xHAchie6es is _0xHMonocrac1es))
		{
			return false;
		}
		return _0xHHydrolyz1((_0xHMonocrac1es)_0xHAchie6es);
	}

	public override int _0xHBoga7ting()
	{
		return _0xHIndor5er ^ _0xHAvau0t ^ _0xH5imners ^ _0xHPurs3 ^ _0xHThuy7 ^ _0xHTeac2psf2l ^ checked((int)_0xHV3rus);
	}

	public bool _0xHHydrolyz1(_0xHMonocrac1es _0xHCocr8at8s)
	{
		if (_0xHIndor5er == _0xHCocr8at8s._0xHIndor5er && _0xHAvau0t == _0xHCocr8at8s._0xHAvau0t && _0xH5imners == _0xHCocr8at8s._0xH5imners && _0xHPurs3 == _0xHCocr8at8s._0xHPurs3 && _0xHThuy7 == _0xHCocr8at8s._0xHThuy7 && _0xHTeac2psf2l == _0xHCocr8at8s._0xHTeac2psf2l && _0xHV3rus == _0xHCocr8at8s._0xHV3rus)
		{
			return true;
		}
		return false;
	}

	public static bool operator ==(_0xHMonocrac1es event1, _0xHMonocrac1es event2)
	{
		return event1._0xHHydrolyz1(event2);
	}

	public static bool operator !=(_0xHMonocrac1es event1, _0xHMonocrac1es event2)
	{
		return !event1._0xHHydrolyz1(event2);
	}
}
