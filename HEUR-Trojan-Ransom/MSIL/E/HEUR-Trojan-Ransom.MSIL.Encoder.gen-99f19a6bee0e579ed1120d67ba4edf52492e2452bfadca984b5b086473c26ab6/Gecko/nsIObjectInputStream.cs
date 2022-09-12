using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6c248606-4eae-46fa-9df0-ba58502368eb")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIObjectInputStream : nsIInputStream, nsIBinaryInputStream
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
	new void SetInputStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool ReadBoolean();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new byte Read8();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort Read16();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Read32();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ulong Read64();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new float ReadFloat();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new double ReadDouble();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ReadCString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ReadString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string ReadBytes(uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ReadByteArray(uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref byte[] aBytes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint ReadArrayBuffer(uint aLength, ref JsVal aArrayBuffer, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports ReadObject([MarshalAs(UnmanagedType.U1)] bool aIsStrongRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int ReadID(ref IntPtr aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetBuffer(uint aLength, uint aAlignMask);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutBuffer(IntPtr aBuffer, uint aLength);
}
