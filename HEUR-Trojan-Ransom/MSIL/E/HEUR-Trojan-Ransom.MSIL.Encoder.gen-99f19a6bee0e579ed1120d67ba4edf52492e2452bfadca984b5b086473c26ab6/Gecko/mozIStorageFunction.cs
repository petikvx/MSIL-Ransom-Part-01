using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9ff02465-21cb-49f3-b975-7d5b38ceec73")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIStorageFunction
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant OnFunctionCall(mozIStorageValueArray aFunctionArguments);
}
