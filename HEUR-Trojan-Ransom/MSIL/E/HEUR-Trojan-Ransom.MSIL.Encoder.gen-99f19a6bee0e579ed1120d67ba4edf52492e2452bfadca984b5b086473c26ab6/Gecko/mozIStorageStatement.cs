using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5f567c35-6c32-4140-828c-683ea49cfd3a")]
public interface mozIStorageStatement : mozIStorageBaseStatement, mozIStorageBindingParams
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Finalize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindUTF8StringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindStringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindDoubleParameter(uint aParamIndex, double aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindInt32Parameter(uint aParamIndex, int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindInt64Parameter(uint aParamIndex, long aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindNullParameter(uint aParamIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindStringAsBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindUTF8StringAsBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindAdoptedBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void BindParameters(mozIStorageBindingParamsArray aParameters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new mozIStorageBindingParamsArray NewBindingParamsArray();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new mozIStoragePendingStatement ExecuteAsync(mozIStorageStatementCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void EscapeStringForLIKE([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue, char aEscapeChar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageStatement Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetParameterCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetParameterName(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetParameterIndex([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetColumnCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetColumnName(uint aColumnIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetColumnIndex([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetColumnDecltype(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Execute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ExecuteStep();

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
