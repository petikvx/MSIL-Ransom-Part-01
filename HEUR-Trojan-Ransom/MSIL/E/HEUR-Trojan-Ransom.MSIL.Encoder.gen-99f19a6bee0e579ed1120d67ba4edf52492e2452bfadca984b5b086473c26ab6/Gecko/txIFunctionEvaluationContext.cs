using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0ecbb00c-6a78-11d9-9791-000a95dc234c")]
public interface txIFunctionEvaluationContext
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetPositionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSizeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetContextNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetStateAttribute();
}
