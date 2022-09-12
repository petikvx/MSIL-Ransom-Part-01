using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("62d1b6bd-cbfe-4f9b-aee1-0ead4af4e6dc")]
public interface mozIStorageRow : mozIStorageValueArray
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetNumEntriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetTypeOfIndex(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetInt32(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetInt64(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new double GetDouble(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetString(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetBlob(uint aIndex, ref uint aDataSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref byte[] aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetBlobAsString(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetBlobAsUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsNull(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string GetSharedUTF8String(uint aIndex, ref uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	new string GetSharedString(uint aIndex, ref uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetSharedBlob(uint aIndex, ref uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetResultByIndex(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetResultByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
}
