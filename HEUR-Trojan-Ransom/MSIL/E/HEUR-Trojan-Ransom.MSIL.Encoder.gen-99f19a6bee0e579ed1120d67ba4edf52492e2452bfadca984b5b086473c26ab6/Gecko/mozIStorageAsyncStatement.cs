using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("52e49370-3b2e-4a27-a3fc-79e20ad4056b")]
public interface mozIStorageAsyncStatement : mozIStorageBaseStatement, mozIStorageBindingParams
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
}
