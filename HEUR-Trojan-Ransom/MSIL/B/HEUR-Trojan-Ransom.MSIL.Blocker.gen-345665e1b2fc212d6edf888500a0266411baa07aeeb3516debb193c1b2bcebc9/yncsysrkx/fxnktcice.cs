using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using utivltgvy;
using wcuwtlpza;
using zzkmfezkx;

namespace yncsysrkx;

internal sealed class fxnktcice
{
	internal static Stream D;

	internal static ICryptoTransform f;

	internal static byte[] F;

	internal static int v;

	internal static int Q;

	internal static byte[] L;

	internal static int s;

	internal static int j;

	internal static wboypfjkb w;

	internal static bool c;

	internal static bool f;

	internal static bool G;

	[CompilerGenerated]
	private readonly bool L;

	public bool d
	{
		[CompilerGenerated]
		get
		{
			return L;
		}
	}

	public fxnktcice(Stream stream_0, ICryptoTransform icryptoTransform_0, wboypfjkb wboypfjkb_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, wboypfjkb_0, bool_0: false, bool_0)
	{
	}

	public fxnktcice(Stream stream_0, ICryptoTransform icryptoTransform_0, wboypfjkb wboypfjkb_0, bool bool_0, bool bool_1)
	{
		D = stream_0;
		w = wboypfjkb_0;
		fxnktcice.f = icryptoTransform_0;
		f = bool_0;
		G = bool_1;
		switch (w)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case wboypfjkb.Write:
			if (!D.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			L = true;
			break;
		case wboypfjkb.Read:
			if (!D.CanRead)
			{
				throw new ArgumentException("stream");
			}
			c = true;
			break;
		}
		F();
	}

	private void F()
	{
		if (fxnktcice.f != null)
		{
			Q = fxnktcice.f.InputBlockSize;
			fxnktcice.F = new byte[Q];
			j = fxnktcice.f.OutputBlockSize;
			fxnktcice.L = new byte[j];
		}
	}

	public void I(byte[] byte_0, int int_0, int int_1)
	{
		if (!d)
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
		if (!ieilgcrzc.D(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			wlpdbozyb.x(byte_0, int_2, int_3, out var _);
		}
	}
}
