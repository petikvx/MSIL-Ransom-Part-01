using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d5e3bd80-6723-4b92-b0c9-22f6162fd94f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUnicharInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Read(char[] aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ReadSegments(IntPtr aWriter, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ReadString(uint aCount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();
}
