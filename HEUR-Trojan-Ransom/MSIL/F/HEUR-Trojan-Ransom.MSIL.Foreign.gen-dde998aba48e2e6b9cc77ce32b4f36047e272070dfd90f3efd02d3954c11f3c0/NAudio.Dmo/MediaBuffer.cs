using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Dmo;

public sealed class MediaBuffer : IDisposable, IMediaBuffer
{
	private IntPtr buffer;

	private int length;

	private int maxLength;

	[NonSerialized]
	internal static GetString _0083;

	public int Length
	{
		get
		{
			return length;
		}
		set
		{
			if (length > maxLength)
			{
				throw new ArgumentException(_0083(107391523));
			}
			length = value;
		}
	}

	public MediaBuffer(int maxLength)
	{
		buffer = Marshal.AllocCoTaskMem(maxLength);
		this.maxLength = maxLength;
	}

	public void Dispose()
	{
		if (buffer != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(buffer);
			buffer = IntPtr.Zero;
			GC.SuppressFinalize(this);
		}
	}

	~MediaBuffer()
	{
		Dispose();
	}

	int IMediaBuffer.SetLength(int length)
	{
		if (length > maxLength)
		{
			return -2147483645;
		}
		this.length = length;
		return 0;
	}

	int IMediaBuffer.GetMaxLength(out int maxLength)
	{
		maxLength = this.maxLength;
		return 0;
	}

	int IMediaBuffer.GetBufferAndLength(IntPtr bufferPointerPointer, IntPtr validDataLengthPointer)
	{
		if (bufferPointerPointer != IntPtr.Zero)
		{
			Marshal.WriteIntPtr(bufferPointerPointer, buffer);
		}
		if (validDataLengthPointer != IntPtr.Zero)
		{
			Marshal.WriteInt32(validDataLengthPointer, length);
		}
		return 0;
	}

	public void LoadData(byte[] data, int bytes)
	{
		Length = bytes;
		Marshal.Copy(data, 0, buffer, bytes);
	}

	public void RetrieveData(byte[] data, int offset)
	{
		Marshal.Copy(buffer, data, offset, Length);
	}

	static MediaBuffer()
	{
		Strings.CreateGetStringDelegate(typeof(MediaBuffer));
	}
}
