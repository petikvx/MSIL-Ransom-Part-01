using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("92c898ac-5fde-4b99-87b3-5d486422094b")]
public interface nsIObjectOutputStream : nsIOutputStream, nsIBinaryOutputStream
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Flush();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Write([MarshalAs(UnmanagedType.LPStr)] string aBuf, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint WriteFrom([MarshalAs(UnmanagedType.Interface)] nsIInputStream aFromStream, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint WriteSegments(IntPtr aReader, IntPtr aClosure, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsNonBlocking();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetOutputStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aOutputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteBoolean([MarshalAs(UnmanagedType.U1)] bool aBoolean);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write8(byte aByte);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write16(ushort a16);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write32(uint a32);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write64(ulong a64);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteFloat(float aFloat);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteDouble(double aDouble);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteStringZ([MarshalAs(UnmanagedType.LPStr)] string aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteWStringZ([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteUtf8Z([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteBytes([MarshalAs(UnmanagedType.LPStr)] string aString, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void WriteByteArray([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] aBytes, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteObject([MarshalAs(UnmanagedType.Interface)] nsISupports aObject, [MarshalAs(UnmanagedType.U1)] bool aIsStrongRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteSingleRefObject([MarshalAs(UnmanagedType.Interface)] nsISupports aObject);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteCompoundObject([MarshalAs(UnmanagedType.Interface)] nsISupports aObject, ref Guid aIID, [MarshalAs(UnmanagedType.U1)] bool aIsStrongRef);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteID(IntPtr aID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetBuffer(uint aLength, uint aAlignMask);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PutBuffer(IntPtr aBuffer, uint aLength);
}
