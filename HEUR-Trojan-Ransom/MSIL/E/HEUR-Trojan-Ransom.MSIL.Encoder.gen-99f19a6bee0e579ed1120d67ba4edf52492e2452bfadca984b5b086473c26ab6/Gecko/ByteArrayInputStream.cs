using System;
using System.Runtime.InteropServices;

namespace Gecko;

public class ByteArrayInputStream : nsIInputStream
{
	private byte[] _data;

	private int _position;

	private ByteArrayInputStream(byte[] data)
	{
		_data = data;
	}

	public static ByteArrayInputStream Create(byte[] data)
	{
		return (data == null) ? null : new ByteArrayInputStream(data);
	}

	public void Close()
	{
	}

	public uint Available()
	{
		return (uint)(_data.Length - _position);
	}

	public uint Read(IntPtr aBuf, uint aCount)
	{
		uint num = Math.Min(aCount, Available());
		if (num != 0)
		{
			Marshal.Copy(_data, _position, aBuf, (int)num);
			for (int i = 0; i < num; i++)
			{
			}
			_position += (int)num;
		}
		return num;
	}

	public unsafe uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount)
	{
		int num = (int)Math.Min(aCount, Available());
		int aWriteCount = 0;
		if (num > 0)
		{
			fixed (byte* ptr = &_data[_position])
			{
				aWriter(this, aClosure, (IntPtr)ptr, _position, num, out aWriteCount);
			}
			_position += aWriteCount;
		}
		return (uint)aWriteCount;
	}

	public bool IsNonBlocking()
	{
		return true;
	}
}
