using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using fswwcv;
using hvnlq;
using rxvtd;

namespace essrx;

internal sealed class czltw
{
	internal static Stream m;

	internal static ICryptoTransform A;

	internal static byte[] c;

	internal static int J;

	internal static int i;

	internal static byte[] w;

	internal static int B;

	internal static int W;

	internal static fjate R;

	internal static bool o;

	internal static bool E;

	internal static bool C;

	[CompilerGenerated]
	private readonly bool w;

	public bool f
	{
		[CompilerGenerated]
		get
		{
			return w;
		}
	}

	public czltw(Stream stream_0, ICryptoTransform icryptoTransform_0, fjate fjate_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, fjate_0, bool_0: false, bool_0)
	{
	}

	public czltw(Stream stream_0, ICryptoTransform icryptoTransform_0, fjate fjate_0, bool bool_0, bool bool_1)
	{
		m = stream_0;
		R = fjate_0;
		A = icryptoTransform_0;
		E = bool_0;
		C = bool_1;
		switch (R)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case fjate.Write:
			if (!m.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			w = true;
			break;
		case fjate.Read:
			if (!m.CanRead)
			{
				throw new ArgumentException("stream");
			}
			o = true;
			break;
		}
		q();
	}

	private void q()
	{
		if (A != null)
		{
			i = A.InputBlockSize;
			c = new byte[i];
			W = A.OutputBlockSize;
			czltw.w = new byte[W];
		}
	}

	public void t(byte[] byte_0, int int_0, int int_1)
	{
		if (!f)
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
		if (!lbyxre.V(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			encow.A(byte_0, int_2, int_3, out var _);
		}
	}
}
