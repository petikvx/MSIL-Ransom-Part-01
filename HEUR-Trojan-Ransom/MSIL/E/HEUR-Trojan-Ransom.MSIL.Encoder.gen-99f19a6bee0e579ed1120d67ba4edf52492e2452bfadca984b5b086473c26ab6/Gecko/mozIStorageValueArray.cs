using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6e6306f4-ffa7-40f5-96ca-36159ce8f431")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIStorageValueArray
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNumEntriesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTypeOfIndex(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetInt32(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetInt64(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetDouble(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetString(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBlob(uint aIndex, ref uint aDataSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref byte[] aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBlobAsString(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetBlobAsUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsNull(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetSharedUTF8String(uint aIndex, ref uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetSharedString(uint aIndex, ref uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetSharedBlob(uint aIndex, ref uint aLength);
}
