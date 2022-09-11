using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

internal sealed class ComStream : Stream, IStream
{
	private Stream stream;

	[NonSerialized]
	internal static GetString _008A;

	public override bool CanRead => stream.CanRead;

	public override bool CanSeek => stream.CanSeek;

	public override bool CanWrite => stream.CanWrite;

	public override long Length => stream.Length;

	public override long Position
	{
		get
		{
			return stream.Position;
		}
		set
		{
			stream.Position = value;
		}
	}

	public ComStream(Stream stream)
		: this(stream, synchronizeStream: true)
	{
	}

	internal ComStream(Stream stream, bool synchronizeStream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException(_008A(107385518));
		}
		if (synchronizeStream)
		{
			stream = Stream.Synchronized(stream);
		}
		this.stream = stream;
	}

	void IStream.Clone(out IStream ppstm)
	{
		ppstm = null;
	}

	void IStream.Commit(int grfCommitFlags)
	{
		stream.Flush();
	}

	void IStream.CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
	{
	}

	void IStream.LockRegion(long libOffset, long cb, int dwLockType)
	{
	}

	void IStream.Read(byte[] pv, int cb, IntPtr pcbRead)
	{
		if (!CanRead)
		{
			throw new InvalidOperationException(_008A(107385989));
		}
		int val = Read(pv, 0, cb);
		if (pcbRead != IntPtr.Zero)
		{
			Marshal.WriteInt32(pcbRead, val);
		}
	}

	void IStream.Revert()
	{
	}

	void IStream.Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
	{
		long val = Seek(dlibMove, (SeekOrigin)dwOrigin);
		if (plibNewPosition != IntPtr.Zero)
		{
			Marshal.WriteInt64(plibNewPosition, val);
		}
	}

	void IStream.SetSize(long libNewSize)
	{
		SetLength(libNewSize);
	}

	void IStream.Stat(out STATSTG pstatstg, int grfStatFlag)
	{
		STATSTG sTATSTG = default(STATSTG);
		sTATSTG.type = 2;
		sTATSTG.cbSize = Length;
		sTATSTG.grfMode = 0;
		STATSTG sTATSTG2 = sTATSTG;
		if (CanWrite && CanRead)
		{
			sTATSTG2.grfMode |= 2;
		}
		else if (CanRead)
		{
			sTATSTG2.grfMode |= 0;
		}
		else
		{
			if (!CanWrite)
			{
				throw new ObjectDisposedException(_008A(107391930));
			}
			sTATSTG2.grfMode |= 1;
		}
		pstatstg = sTATSTG2;
	}

	void IStream.UnlockRegion(long libOffset, long cb, int dwLockType)
	{
	}

	void IStream.Write(byte[] pv, int cb, IntPtr pcbWritten)
	{
		if (!CanWrite)
		{
			throw new InvalidOperationException(_008A(107385956));
		}
		Write(pv, 0, cb);
		if (pcbWritten != IntPtr.Zero)
		{
			Marshal.WriteInt32(pcbWritten, cb);
		}
	}

	public override void Flush()
	{
		stream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return stream.Read(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return stream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		stream.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		stream.Write(buffer, offset, count);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (stream != null)
		{
			stream.Dispose();
			stream = null;
		}
	}

	public override void Close()
	{
		base.Close();
		if (stream != null)
		{
			stream.Close();
			stream = null;
		}
	}

	static ComStream()
	{
		Strings.CreateGetStringDelegate(typeof(ComStream));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008A(107398409), _008A(107398372)), _008A(107398367), _008A(107398362)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008A(107398389)))
		{
			return;
		}
		throw new SecurityException(_008A(107398332));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
