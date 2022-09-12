using System;
using System.Runtime.InteropServices;

namespace Gecko.IO;

public sealed class StringInputStream : InputStream
{
	private nsIStringInputStream _stringInputStream;

	internal StringInputStream(nsIStringInputStream stream)
		: base(stream)
	{
		_stringInputStream = stream;
	}

	public void SetData(string data, int dataLen)
	{
		_stringInputStream.SetData(data, dataLen);
	}

	public void AdoptData(byte[] data)
	{
		AdoptData(data, data.Length);
	}

	public void AdoptData(byte[] data, int dataLen)
	{
		IntPtr intPtr = Xpcom.moz_xmalloc(new IntPtr(dataLen));
		Marshal.Copy(data, 0, intPtr, dataLen);
		_stringInputStream.AdoptData(intPtr, dataLen);
	}

	public void ShareData(string data, int dataLen)
	{
		_stringInputStream.ShareData(data, dataLen);
	}
}
