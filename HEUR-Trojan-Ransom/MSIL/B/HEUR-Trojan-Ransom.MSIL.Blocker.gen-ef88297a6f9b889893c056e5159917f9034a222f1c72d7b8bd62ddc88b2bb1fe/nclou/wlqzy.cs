using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using asjriml;
using vsvzs;
using whjwk;

namespace nclou;

internal sealed class wlqzy
{
	internal static Stream b;

	internal static ICryptoTransform X;

	internal static byte[] X;

	internal static int s;

	internal static int L;

	internal static byte[] B;

	internal static int E;

	internal static int K;

	internal static gwdjc k;

	internal static bool O;

	internal static bool C;

	internal static bool l;

	[CompilerGenerated]
	private readonly bool h;

	public bool p
	{
		[CompilerGenerated]
		get
		{
			return h;
		}
	}

	public wlqzy(Stream stream_0, ICryptoTransform icryptoTransform_0, gwdjc gwdjc_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, gwdjc_0, bool_0: false, bool_0)
	{
	}

	public wlqzy(Stream stream_0, ICryptoTransform icryptoTransform_0, gwdjc gwdjc_0, bool bool_0, bool bool_1)
	{
		b = stream_0;
		wlqzy.k = gwdjc_0;
		wlqzy.X = icryptoTransform_0;
		C = bool_0;
		l = bool_1;
		switch (wlqzy.k)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case gwdjc.Write:
			if (!b.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			h = true;
			break;
		case gwdjc.Read:
			if (!b.CanRead)
			{
				throw new ArgumentException("stream");
			}
			wlqzy.O = true;
			break;
		}
		k();
	}

	private void k()
	{
		if (wlqzy.X != null)
		{
			L = wlqzy.X.InputBlockSize;
			X = new byte[L];
			K = wlqzy.X.OutputBlockSize;
			B = new byte[K];
		}
	}

	public void O(byte[] byte_0, int int_0, int int_1)
	{
		if (!p)
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
		if (!sapccvb.P(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			vyrbz.A(byte_0, int_2, int_3, out var _);
		}
	}
}
