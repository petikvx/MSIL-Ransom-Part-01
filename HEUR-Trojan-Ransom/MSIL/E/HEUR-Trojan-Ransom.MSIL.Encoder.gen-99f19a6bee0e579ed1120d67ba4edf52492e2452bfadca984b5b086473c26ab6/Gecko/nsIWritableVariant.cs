using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5586a590-8c82-11d5-90f3-0010a4e73d9a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWritableVariant : nsIVariant
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetDataTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new byte GetAsInt8();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new short GetAsInt16();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetAsInt32();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetAsInt64();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new byte GetAsUint8();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ushort GetAsUint16();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetAsUint32();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new ulong GetAsUint64();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new float GetAsFloat();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new double GetAsDouble();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetAsBool();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new char GetAsChar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new char GetAsWChar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetAsID(ref IntPtr retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAsAString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAsDOMString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAsACString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetAsAUTF8String([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string GetAsString();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	new string GetAsWString();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISupports GetAsISupports();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new JsVal GetAsJSVal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetAsInterface(ref Guid iid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetAsArray(ref ushort type, ref Guid iid, ref uint count, ref IntPtr ptr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string GetAsStringWithSize(ref uint size);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	new string GetAsWStringWithSize(ref uint size);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWritableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWritableAttribute([MarshalAs(UnmanagedType.U1)] bool aWritable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsInt8(byte aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsInt16(short aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsInt32(int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsInt64(long aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsUint8(byte aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsUint16(ushort aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsUint32(uint aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsUint64(ulong aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsFloat(float aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsDouble(double aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsBool([MarshalAs(UnmanagedType.U1)] bool aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsChar(char aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsWChar(char aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsID(IntPtr aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsAString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsDOMString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsACString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsAUTF8String([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsString([MarshalAs(UnmanagedType.LPStr)] string aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsWString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsISupports([MarshalAs(UnmanagedType.Interface)] nsISupports aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsInterface(ref Guid iid, IntPtr iface);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsArray(ushort type, Guid iid, uint count, IntPtr ptr);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsStringWithSize(uint size, [MarshalAs(UnmanagedType.LPStr)] string str);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsWStringWithSize(uint size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string str);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsVoid();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsEmpty();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAsEmptyArray();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFromVariant([MarshalAs(UnmanagedType.Interface)] nsIVariant aValue);
}
