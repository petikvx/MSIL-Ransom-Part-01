using System;
using System.Diagnostics.CodeAnalysis;
using _0xHDo2ing;

namespace _0xHUnder1tandingly;

internal struct _0xHAmino4hylline : IDisposable
{
	private int _0xHOv2rprot2ct2d;

	private byte[] _0xH3ingles;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal _0xHAmino4hylline(int begin, int end, byte[] aBuff, bool correlated = false)
	{
		_0xH3ingles = (correlated ? _0xHOwli8hne88._0xHOsc0llates(aBuff, Guid.NewGuid()) : aBuff);
		_0xHOv2rprot2ct2d = end;
		_0xHOwli8hne88._0xHDa8abie8s._0xHAv0cular(begin, _0xH3ingles);
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal _0xHAmino4hylline(int begin, int end, Guid guidData, bool correlated = false)
		: this(begin, end, guidData.ToByteArray(), correlated)
	{
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal _0xHAmino4hylline(int begin, int end, string stringData, bool correlated = false)
		: this(begin, end, _0xHOwli8hne88._0xHMi7yoked(stringData), correlated)
	{
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal _0xHAmino4hylline(int begin, int end, uint uintData, bool correlated = false)
		: this(begin, end, BitConverter.GetBytes(uintData), correlated)
	{
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal _0xHAmino4hylline(int begin, int end, ulong ulongData, bool correlated = false)
		: this(begin, end, BitConverter.GetBytes(ulongData), correlated)
	{
	}

	public void _0xHStando88ishly()
	{
		if (_0xHOv2rprot2ct2d != 0)
		{
			_0xHOwli8hne88._0xHDa8abie8s._0xHAv0cular(_0xHOv2rprot2ct2d, _0xH3ingles);
			_0xHOv2rprot2ct2d = 0;
			_0xH3ingles = null;
		}
	}
}
