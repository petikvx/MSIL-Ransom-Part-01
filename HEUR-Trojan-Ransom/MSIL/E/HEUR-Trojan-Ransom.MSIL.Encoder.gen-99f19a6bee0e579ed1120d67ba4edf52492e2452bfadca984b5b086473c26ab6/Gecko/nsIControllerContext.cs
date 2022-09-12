using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("47B82B60-A36F-4167-8072-6F421151ED50")]
public interface nsIControllerContext
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIControllerCommandTable aCommandTable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCommandContext([MarshalAs(UnmanagedType.Interface)] nsISupports aCommandContext);
}
