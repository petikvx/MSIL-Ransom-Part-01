using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9c311778-7c2c-4ad8-b439-b8a2786a20dd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIClearSiteDataCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Callback(int rv);
}
