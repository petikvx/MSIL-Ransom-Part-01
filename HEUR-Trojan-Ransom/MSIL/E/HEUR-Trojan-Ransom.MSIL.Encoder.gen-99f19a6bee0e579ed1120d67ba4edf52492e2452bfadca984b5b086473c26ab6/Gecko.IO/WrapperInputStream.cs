using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Gecko.IO;

public class WrapperInputStream : nsIInputStream
{
	private Stream _stream;

	public WrapperInputStream(Stream stream)
	{
		_stream = stream;
	}

	public void Close()
	{
		_stream.Close();
	}

	public uint Available()
	{
		return (uint)(_stream.Length - _stream.Position);
	}

	public uint Read(IntPtr aBuf, uint aCount)
	{
		byte[] array = new byte[aCount];
		int num = _stream.Read(array, 0, array.Length);
		Marshal.Copy(array, 0, aBuf, num);
		return (uint)num;
	}

	public uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount)
	{
		return 0u;
	}

	public bool IsNonBlocking()
	{
		return true;
	}
}
