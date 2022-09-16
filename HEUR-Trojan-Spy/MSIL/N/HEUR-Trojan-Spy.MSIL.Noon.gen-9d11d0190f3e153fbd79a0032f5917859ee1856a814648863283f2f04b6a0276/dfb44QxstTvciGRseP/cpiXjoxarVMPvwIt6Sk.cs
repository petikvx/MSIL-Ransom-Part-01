using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace dfb44QxstTvciGRseP;

public class cpiXjoxarVMPvwIt6Sk : Stream
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Stream fbPuoejVT2;

	public readonly byte[] AY1u1qrwD9;

	public readonly byte[] jDluZrA7Nv;

	private readonly AesManaged wkBurkaZQW;

	private readonly int APCucWBkFn;

	private CryptoStream GEvu7Dsj9q;

	private CryptoStream qg9uHjLqIe;

	private byte KdButv60gy;

	private int siwulxuwBw;

	internal static cpiXjoxarVMPvwIt6Sk IaCO2n7oB4xraQyljet;

	public override bool CanRead => ak5ufku3NM().CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => ak5ufku3NM().CanWrite;

	[Obsolete("This class does not support Length.", true)]
	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	[Obsolete("This class does not support Position.", true)]
	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public Stream ak5ufku3NM()
	{
		return fbPuoejVT2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void rAJuDTkPll(Stream stream_0)
	{
		fbPuoejVT2 = stream_0;
	}

	public cpiXjoxarVMPvwIt6Sk(Stream stream_0, int int_0 = 128, int int_1 = 128)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		KdButv60gy = 0;
		siwulxuwBw = 0;
		base._002Ector();
		rAJuDTkPll(stream_0);
		wkBurkaZQW = new AesManaged
		{
			KeySize = int_0,
			BlockSize = int_1,
			Mode = CipherMode.CBC,
			Padding = PaddingMode.Zeros
		};
		AY1u1qrwD9 = wkBurkaZQW.Key;
		jDluZrA7Nv = (byte[])yRhpnN7jK4xf65qor73(wkBurkaZQW);
		ICryptoTransform cryptoTransform = wkBurkaZQW.CreateEncryptor();
		APCucWBkFn = YtUQxo7EEsHNtW303Wo(cryptoTransform);
		qg9uHjLqIe = new CryptoStream(stream_0, cryptoTransform, CryptoStreamMode.Write);
	}

	public void JHZuyME9GT(byte[] byte_0, byte[] byte_1)
	{
		GEvu7Dsj9q = new CryptoStream(ak5ufku3NM(), wkBurkaZQW.CreateDecryptor(byte_0, byte_1), CryptoStreamMode.Read);
	}

	protected override void Dispose(bool disposing)
	{
		GEvu7Dsj9q = null;
		qg9uHjLqIe = null;
		wkBurkaZQW.Dispose();
	}

	public override void Flush()
	{
		if (KdButv60gy > 0)
		{
			int num = 0;
			if (!pGlxbQ7dPHrRgZBAWNI())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			byte int_ = (byte)(APCucWBkFn - KdButv60gy);
			byte[] byte_ = ((byte)0).MUPhMmcICD((int)int_);
			qg9uHjLqIe.x7LhEAJCht(byte_);
		}
		siwulxuwBw = 0;
		KdButv60gy = 0;
		qg9uHjLqIe.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return GEvu7Dsj9q.Read(buffer, offset, count);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		siwulxuwBw += count;
		KdButv60gy = (byte)(siwulxuwBw % APCucWBkFn);
		qg9uHjLqIe.Write(buffer, offset, count);
	}

	public override int ReadByte()
	{
		return GEvu7Dsj9q.ReadByte();
	}

	public override void WriteByte(byte value)
	{
		siwulxuwBw++;
		KdButv60gy = (byte)(siwulxuwBw % APCucWBkFn);
		HXKxCk7w93jNJjcRoeR(qg9uHjLqIe, value);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	internal static bool pGlxbQ7dPHrRgZBAWNI()
	{
		return IaCO2n7oB4xraQyljet == null;
	}

	internal static cpiXjoxarVMPvwIt6Sk yxijZr7pRg1mN0RFOVU()
	{
		return IaCO2n7oB4xraQyljet;
	}

	internal static object yRhpnN7jK4xf65qor73(object object_0)
	{
		return ((SymmetricAlgorithm)object_0).IV;
	}

	internal static int YtUQxo7EEsHNtW303Wo(object object_0)
	{
		return ((ICryptoTransform)object_0).OutputBlockSize;
	}

	internal static void HXKxCk7w93jNJjcRoeR(object object_0, byte byte_0)
	{
		((Stream)object_0).WriteByte(byte_0);
	}
}
