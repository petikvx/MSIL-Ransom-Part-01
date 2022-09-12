using System;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko.IO.Native;

public sealed class NativeOutputStream : BaseNativeStream, IDisposable, nsIOutputStream
{
	public NativeOutputStream(int firstSize)
	{
		Init(Marshal.AllocHGlobal(firstSize), firstSize);
	}

	~NativeOutputStream()
	{
		Close();
	}

	public void Dispose()
	{
		Close();
		GC.SuppressFinalize(this);
	}

	public void Close()
	{
		if (base.Buffer != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(base.Buffer);
			Init(IntPtr.Zero, 0);
		}
	}

	private void PreparePointer(int count)
	{
		long num = base.Position + count;
		if (num >= base.Length)
		{
			int num2 = base.Length + 65536;
			long num3 = Math.Max(num2, num);
			IntPtr buffer = Marshal.ReAllocHGlobal(base.Buffer, new IntPtr(num3));
			Init(buffer, (int)num3);
		}
	}

	public void Flush()
	{
	}

	public uint Write(string aBuf, uint aCount)
	{
		throw new NotImplementedException();
	}

	public unsafe uint Write(IntPtr aBuf, uint aCount)
	{
		PreparePointer((int)aCount);
		MemCopy.Copy(aBuf.ToPointer(), base.CurrentPointer, (int)aCount);
		MovePointer(aCount);
		return aCount;
	}

	public unsafe uint WriteFrom(nsIInputStream aFromStream, uint aCount)
	{
		PreparePointer((int)aCount);
		aFromStream.Read(new IntPtr(base.CurrentPointer), aCount);
		MovePointer(aCount);
		return aCount;
	}

	public uint WriteSegments(IntPtr aReader, IntPtr aClosure, uint aCount)
	{
		throw new NotImplementedException();
	}

	public bool IsNonBlocking()
	{
		return false;
	}
}
