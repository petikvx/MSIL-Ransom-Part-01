using System;
using System.Runtime.InteropServices;

namespace Gecko.IO.Native;

public sealed class NativeInputStream : BaseNativeInputStream, IDisposable
{
	private GCHandle _handle;

	private NativeInputStream(byte[] array)
	{
		_handle = GCHandle.Alloc(array, GCHandleType.Pinned);
		Init(_handle.AddrOfPinnedObject(), array.Length);
	}

	~NativeInputStream()
	{
		Close();
	}

	public void Dispose()
	{
		Close();
		GC.SuppressFinalize(this);
	}

	public override void Close()
	{
		if (_handle.IsAllocated)
		{
			_handle.Free();
		}
	}

	public static NativeInputStream Create(byte[] buffer)
	{
		return (buffer == null) ? null : new NativeInputStream(buffer);
	}
}
