using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("81e4c2de-acac-4ad6-901a-b5fb1b851a0d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIVariant
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetDataTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	byte GetAsInt8();

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetAsInt16();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAsInt32();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetAsInt64();

	[MethodImpl(MethodImplOptions.InternalCall)]
	byte GetAsUint8();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetAsUint16();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAsUint32();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetAsUint64();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetAsFloat();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetAsDouble();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAsBool();

	[MethodImpl(MethodImplOptions.InternalCall)]
	char GetAsChar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	char GetAsWChar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAsID(ref IntPtr retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsAString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsDOMString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsACString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsAUTF8String([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetAsString();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetAsWString();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetAsISupports();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetAsJSVal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetAsInterface(ref Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetAsArray(ref ushort type, ref Guid iid, ref uint count, ref IntPtr ptr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetAsStringWithSize(ref uint size);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetAsWStringWithSize(ref uint size);
}
