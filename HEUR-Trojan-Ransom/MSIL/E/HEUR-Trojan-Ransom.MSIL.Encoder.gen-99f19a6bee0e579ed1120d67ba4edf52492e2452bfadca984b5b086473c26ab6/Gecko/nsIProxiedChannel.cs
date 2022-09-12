using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6238f134-8c3f-4354-958f-dfd9d54a4446")]
public interface nsIProxiedChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIProxyInfo GetProxyInfoAttribute();
}
