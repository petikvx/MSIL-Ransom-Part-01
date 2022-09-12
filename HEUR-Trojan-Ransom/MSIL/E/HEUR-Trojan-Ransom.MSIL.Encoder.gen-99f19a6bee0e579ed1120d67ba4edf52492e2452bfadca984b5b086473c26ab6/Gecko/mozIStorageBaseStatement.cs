using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("16ca67aa-1325-43e2-aac7-859afd1590b2")]
public interface mozIStorageBaseStatement : mozIStorageBindingParams
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Finalize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindUTF8StringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindStringParameter(uint aParamIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindDoubleParameter(uint aParamIndex, double aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindInt32Parameter(uint aParamIndex, int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindInt64Parameter(uint aParamIndex, long aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindNullParameter(uint aParamIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindStringAsBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindUTF8StringAsBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindAdoptedBlobParameter(uint aParamIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] aValue, uint aValueSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BindParameters(mozIStorageBindingParamsArray aParameters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageBindingParamsArray NewBindingParamsArray();

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStoragePendingStatement ExecuteAsync(mozIStorageStatementCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EscapeStringForLIKE([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue, char aEscapeChar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
}
