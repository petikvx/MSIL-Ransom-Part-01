using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using nzjzssxgb;
using slqhntepa;
using zndtztukj;

namespace betcmswos;

internal sealed class ldwqswnax
{
	internal static Stream B;

	internal static ICryptoTransform o;

	internal static byte[] w;

	internal static int y;

	internal static int K;

	internal static byte[] j;

	internal static int t;

	internal static int C;

	internal static gujxibroh l;

	internal static bool u;

	internal static bool n;

	internal static bool W;

	internal bool K;

	public bool T
	{
		[CompilerGenerated]
		get
		{
			return K;
		}
	}

	public ldwqswnax(Stream stream_0, ICryptoTransform icryptoTransform_0, gujxibroh gujxibroh_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, gujxibroh_0, bool_0: false, bool_0)
	{
	}

	public ldwqswnax(Stream stream_0, ICryptoTransform icryptoTransform_0, gujxibroh gujxibroh_0, bool bool_0, bool bool_1)
	{
		B = stream_0;
		l = gujxibroh_0;
		o = icryptoTransform_0;
		n = bool_0;
		W = bool_1;
		switch (l)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case gujxibroh.Write:
			if (!B.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			K = true;
			break;
		case gujxibroh.Read:
			if (!B.CanRead)
			{
				throw new ArgumentException("stream");
			}
			u = true;
			break;
		}
		w();
	}

	private void w()
	{
		if (o != null)
		{
			ldwqswnax.K = o.InputBlockSize;
			ldwqswnax.w = new byte[ldwqswnax.K];
			C = o.OutputBlockSize;
			j = new byte[C];
		}
	}

	public void S(byte[] byte_0, int int_0, int int_1)
	{
		if (!T)
		{
			throw new NotSupportedException("NotSupported_UnwritableStream");
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "ArgumentOutOfRange_NeedNonNegNum");
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException("count", "ArgumentOutOfRange_NeedNonNegNum");
		}
		if (byte_0.Length - int_0 < int_1)
		{
			throw new ArgumentException("Argument_InvalidOffLen");
		}
		int int_2 = int_1;
		int int_3 = int_0;
		if (!fxrfsgqmx.e(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			mvgioqslu.n(byte_0, int_2, int_3, out var _);
		}
	}
}
