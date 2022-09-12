using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using nhqkchr;
using ofdvedi;
using owbefxc;

namespace jjnmlvx;

internal sealed class dfehscp
{
	internal static Stream U;

	internal static ICryptoTransform W;

	internal static byte[] K;

	internal static int j;

	internal static int I;

	internal static byte[] t;

	internal static int w;

	internal static int S;

	internal static wufmarw g;

	internal static bool b;

	internal static bool S;

	internal static bool a;

	[CompilerGenerated]
	private readonly bool p;

	public bool e
	{
		[CompilerGenerated]
		get
		{
			return p;
		}
	}

	public dfehscp(Stream stream_0, ICryptoTransform icryptoTransform_0, wufmarw wufmarw_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, wufmarw_0, bool_0: false, bool_0)
	{
	}

	public dfehscp(Stream stream_0, ICryptoTransform icryptoTransform_0, wufmarw wufmarw_0, bool bool_0, bool bool_1)
	{
		U = stream_0;
		g = wufmarw_0;
		W = icryptoTransform_0;
		S = bool_0;
		a = bool_1;
		switch (g)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case wufmarw.Write:
			if (!U.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			p = true;
			break;
		case wufmarw.Read:
			if (!U.CanRead)
			{
				throw new ArgumentException("stream");
			}
			b = true;
			break;
		}
		K();
	}

	private void K()
	{
		if (W != null)
		{
			I = W.InputBlockSize;
			dfehscp.K = new byte[I];
			dfehscp.S = W.OutputBlockSize;
			t = new byte[dfehscp.S];
		}
	}

	public void C(byte[] byte_0, int int_0, int int_1)
	{
		if (!e)
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
		if (!brzzchq.C(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			ravvwva.M(byte_0, int_2, int_3, out var _);
		}
	}
}
