using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("899b826b-2eb3-469c-8b31-4c29f5d341a6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBinaryInputStream : nsIInputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Available();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Read(IntPtr aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint ReadSegments(nsWriteSegmentFun aWriter, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsNonBlocking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInputStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ReadBoolean();

	[MethodImpl(MethodImplOptions.InternalCall)]
	byte Read8();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort Read16();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Read32();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong Read64();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float ReadFloat();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double ReadDouble();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadCString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string ReadBytes(uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadByteArray(uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref byte[] aBytes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ReadArrayBuffer(uint aLength, ref JsVal aArrayBuffer, IntPtr jsContext);
}
