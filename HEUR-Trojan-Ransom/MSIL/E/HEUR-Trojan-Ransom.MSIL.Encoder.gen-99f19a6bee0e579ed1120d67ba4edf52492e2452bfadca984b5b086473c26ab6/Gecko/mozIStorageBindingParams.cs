using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2d09f42f-966e-4663-b4b3-b0c8676bf2bf")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIStorageBindingParams
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindUTF8StringByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindStringByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindDoubleByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, double aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindInt32ByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindInt64ByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, long aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindNullByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindBlobByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindStringAsBlobByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindUTF8StringAsBlobByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindAdoptedBlobByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindByIndex(uint aIndex, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindUTF8StringByIndex(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindStringByIndex(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindDoubleByIndex(uint aIndex, double aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindInt32ByIndex(uint aIndex, int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindInt64ByIndex(uint aIndex, long aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindNullByIndex(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindBlobByIndex(uint aIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindStringAsBlobByIndex(uint aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindUTF8StringAsBlobByIndex(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindAdoptedBlobByIndex(uint aIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);
}
