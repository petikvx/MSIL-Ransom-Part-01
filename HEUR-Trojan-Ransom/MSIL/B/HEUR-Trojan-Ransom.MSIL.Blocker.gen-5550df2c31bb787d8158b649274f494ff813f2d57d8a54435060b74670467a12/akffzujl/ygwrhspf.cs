using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using enzyqkgi;
using pqjibgvy;
using xanqrouu;

namespace akffzujl;

internal sealed class ygwrhspf
{
	internal static Stream s;

	internal static ICryptoTransform V;

	internal static byte[] E;

	internal static int H;

	internal static int U;

	internal static byte[] d;

	internal static int s;

	internal static int M;

	internal static tjdhjhmf H;

	internal static bool D;

	internal static bool f;

	internal static bool C;

	internal bool g;

	public bool j
	{
		[CompilerGenerated]
		get
		{
			return g;
		}
	}

	public ygwrhspf(Stream stream_0, ICryptoTransform icryptoTransform_0, tjdhjhmf tjdhjhmf_0, bool bool_0)
		: this(stream_0, icryptoTransform_0, tjdhjhmf_0, bool_0: false, bool_0)
	{
	}

	public ygwrhspf(Stream stream_0, ICryptoTransform icryptoTransform_0, tjdhjhmf tjdhjhmf_0, bool bool_0, bool bool_1)
	{
		ygwrhspf.s = stream_0;
		H = tjdhjhmf_0;
		V = icryptoTransform_0;
		f = bool_0;
		C = bool_1;
		switch (H)
		{
		default:
			throw new ArgumentException("Argument_InvalidValue");
		case tjdhjhmf.Write:
			if (!ygwrhspf.s.CanWrite)
			{
				throw new ArgumentException("stream");
			}
			g = true;
			break;
		case tjdhjhmf.Read:
			if (!ygwrhspf.s.CanRead)
			{
				throw new ArgumentException("stream");
			}
			D = true;
			break;
		}
		p();
	}

	private void p()
	{
		if (V != null)
		{
			U = V.InputBlockSize;
			E = new byte[U];
			M = V.OutputBlockSize;
			d = new byte[M];
		}
	}

	public void o(byte[] byte_0, int int_0, int int_1)
	{
		if (!j)
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
		if (!xunfsjvw.C(byte_0, int_0, int_1, ref int_3, ref int_2))
		{
			hvwlmdan.J(byte_0, int_2, int_3, out var _);
		}
	}
}
