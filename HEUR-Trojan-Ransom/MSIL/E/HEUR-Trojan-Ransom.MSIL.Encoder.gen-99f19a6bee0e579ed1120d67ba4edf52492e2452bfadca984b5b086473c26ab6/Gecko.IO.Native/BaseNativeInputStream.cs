using System;
using Gecko.Interop;

namespace Gecko.IO.Native;

public abstract class BaseNativeInputStream : BaseNativeStream, nsIInputStream
{
	public uint Available()
	{
		return (uint)(base.Length - base.Position);
	}

	public unsafe uint Read(IntPtr aBuf, uint aCount)
	{
		uint num = Math.Min(Available(), aCount);
		if (num == 0)
		{
			return 0u;
		}
		if (base.Buffer == IntPtr.Zero)
		{
			return 0u;
		}
		MemCopy.Copy(base.CurrentPointer, aBuf.ToPointer(), (int)num);
		MovePointer(num);
		return num;
	}

	public unsafe uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount)
	{
		int num = (int)Math.Min(aCount, Available());
		if (num == 0)
		{
			return 0u;
		}
		if (base.Buffer == IntPtr.Zero)
		{
			return 0u;
		}
		aWriter(this, aClosure, new IntPtr(base.CurrentPointer), (int)base.Position, num, out var aWriteCount);
		MovePointer((uint)num);
		return (uint)aWriteCount;
	}

	public bool IsNonBlocking()
	{
		return true;
	}

	public abstract void Close();
}
