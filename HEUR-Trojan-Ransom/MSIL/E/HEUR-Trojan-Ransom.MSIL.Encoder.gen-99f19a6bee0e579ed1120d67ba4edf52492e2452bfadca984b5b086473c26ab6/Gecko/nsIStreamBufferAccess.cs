using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ac923b72-ac87-4892-ac7a-ca385d429435")]
public interface nsIStreamBufferAccess
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetBuffer(uint aLength, uint aAlignMask);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutBuffer(IntPtr aBuffer, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisableBuffering();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnableBuffering();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetUnbufferedStreamAttribute();
}
