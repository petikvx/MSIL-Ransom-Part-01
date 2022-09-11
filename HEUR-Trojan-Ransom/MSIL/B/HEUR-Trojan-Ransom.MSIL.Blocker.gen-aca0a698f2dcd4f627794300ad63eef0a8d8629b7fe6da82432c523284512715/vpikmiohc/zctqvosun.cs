using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using galohbrxn;
using isbazyifg;
using msmyirzej;

namespace vpikmiohc;

internal sealed class zctqvosun
{
	internal static Stream D;

	internal static ICryptoTransform M;

	internal static byte[] j;

	internal static int I;

	internal static int g;

	internal static byte[] W;

	internal static int P;

	internal static int y;

	internal static sprnpuqpe c;

	internal static bool N;

	internal static bool G;

	internal static bool v;

	[CompilerGenerated]
	private readonly bool h;

	public bool L
	{
		[CompilerGenerated]
		get
		{
			return h;
		}
	}

	public zctqvosun(Stream stream_0, ICryptoTransform icryptoTransform_0, sprnpuqpe sprnpuqpe_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, sprnpuqpe_0, bool_0: false, bool_0)
	{
	}

	public zctqvosun(Stream stream_0, ICryptoTransform icryptoTransform_0, sprnpuqpe sprnpuqpe_0, bool bool_0, bool bool_1)
	{
		D = stream_0;
		c = sprnpuqpe_0;
		M = icryptoTransform_0;
		G = bool_0;
		v = bool_1;
		switch (c)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case sprnpuqpe.Write:
			if (!D.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			h = true;
			break;
		case sprnpuqpe.Read:
			if (!D.CanRead)
			{
				throw new ArgumentException("stream");
			}
			N = true;
			break;
		}
		A();
	}

	private void A()
	{
		if (M != null)
		{
			g = M.InputBlockSize;
			j = new byte[g];
			y = M.OutputBlockSize;
			W = new byte[y];
		}
	}

	public void e(byte[] byte_0, int int_0, int int_1)
	{
		if (!L)
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
		if (!vsttdolor.H(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			yognkugum.M(byte_0, int_2, int_3, out var _);
		}
	}
}
