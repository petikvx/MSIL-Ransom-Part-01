using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8b1345fa-b34c-41b3-8d21-09f961bf8887")]
public interface nsINetworkInterface
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsINetworkInfo GetInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHttpProxyHostAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aHttpProxyHost);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetHttpProxyPortAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMtuAttribute();
}
