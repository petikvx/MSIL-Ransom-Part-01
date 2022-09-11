using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using hwtwu;
using rnbcx;
using yoovq;

namespace earce;

internal sealed class qfnvk
{
	internal static Stream L;

	internal static ICryptoTransform F;

	internal static byte[] M;

	internal static int Y;

	internal static int s;

	internal static byte[] N;

	internal static int M;

	internal static int a;

	internal static ejacj H;

	internal static bool V;

	internal static bool s;

	internal static bool w;

	[CompilerGenerated]
	private readonly bool g;

	public bool Y
	{
		[CompilerGenerated]
		get
		{
			return g;
		}
	}

	public qfnvk(Stream stream_0, ICryptoTransform icryptoTransform_0, ejacj ejacj_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, ejacj_0, bool_0: false, bool_0)
	{
	}

	public qfnvk(Stream stream_0, ICryptoTransform icryptoTransform_0, ejacj ejacj_0, bool bool_0, bool bool_1)
	{
		L = stream_0;
		H = ejacj_0;
		F = icryptoTransform_0;
		s = bool_0;
		qfnvk.w = bool_1;
		switch (H)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case ejacj.Write:
			if (!L.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			g = true;
			break;
		case ejacj.Read:
			if (!L.CanRead)
			{
				throw new ArgumentException("stream");
			}
			V = true;
			break;
		}
		w();
	}

	private void w()
	{
		if (F != null)
		{
			qfnvk.s = F.InputBlockSize;
			qfnvk.M = new byte[qfnvk.s];
			a = F.OutputBlockSize;
			N = new byte[a];
		}
	}

	public void C(byte[] byte_0, int int_0, int int_1)
	{
		if (!Y)
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
		if (!vjdhn.S(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			qftyk.M(byte_0, int_2, int_3, out var _);
		}
	}
}
