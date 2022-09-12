using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("FC66FFB6-5404-4908-A4A3-27F92FA0579D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIConverterInputStream : nsIUnicharInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Read(char[] aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint ReadSegments(IntPtr aWriter, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint ReadString(uint aCount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.LPStr)] string aCharset, int aBufferSize, char aReplacementChar);
}
