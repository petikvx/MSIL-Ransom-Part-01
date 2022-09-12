using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("92584002-d0e2-4b88-9af9-fa6ff59ee002")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMXPathEvaluator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports Evaluate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase expression, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode contextNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode resolver, ushort type, [MarshalAs(UnmanagedType.Interface)] nsISupports result);
}
