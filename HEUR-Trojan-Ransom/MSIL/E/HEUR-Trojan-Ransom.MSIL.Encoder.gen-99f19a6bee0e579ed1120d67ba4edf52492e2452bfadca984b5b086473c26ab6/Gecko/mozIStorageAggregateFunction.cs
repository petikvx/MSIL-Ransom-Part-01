using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("763217b7-3123-11da-918d-000347412e16")]
public interface mozIStorageAggregateFunction
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStep(mozIStorageValueArray aFunctionArguments);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant OnFinal();
}
