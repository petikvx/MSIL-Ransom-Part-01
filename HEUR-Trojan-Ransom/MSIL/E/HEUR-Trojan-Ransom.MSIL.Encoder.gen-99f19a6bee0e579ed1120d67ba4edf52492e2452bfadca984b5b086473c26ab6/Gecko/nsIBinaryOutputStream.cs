using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("204ee610-8765-11d3-90cf-0040056a906e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBinaryOutputStream : nsIOutputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Flush();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Write([MarshalAs(UnmanagedType.LPStr)] string aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint WriteFrom([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint WriteSegments(IntPtr aReader, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsNonBlocking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOutputStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aOutputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteBoolean([MarshalAs(UnmanagedType.U1)] bool aBoolean);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Write8(byte aByte);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Write16(ushort a16);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Write32(uint a32);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Write64(ulong a64);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteFloat(float aFloat);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteDouble(double aDouble);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteStringZ([MarshalAs(UnmanagedType.LPStr)] string aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteWStringZ([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteUtf8Z([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteBytes([MarshalAs(UnmanagedType.LPStr)] string aString, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteByteArray([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] aBytes, uint aLength);
}
