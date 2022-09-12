using System;

namespace Gecko;

internal struct MutableHandle
{
	private IntPtr _ptr;

	public IntPtr Handle => _ptr;

	public MutableHandle(IntPtr ptr)
	{
		_ptr = ptr;
	}
}
