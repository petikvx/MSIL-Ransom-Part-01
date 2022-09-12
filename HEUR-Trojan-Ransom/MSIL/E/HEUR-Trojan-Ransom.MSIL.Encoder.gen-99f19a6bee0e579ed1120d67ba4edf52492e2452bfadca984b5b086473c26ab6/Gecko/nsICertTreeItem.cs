using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d0180863-606e-49e6-8324-cf45ed4dd891")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICertTreeItem
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert GetCertAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHostPortAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHostPort);
}
