using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ac46be8f-c863-4c23-84a2-d0fcc8dfa9f4")]
public interface nsIXULBuilderListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void WillRebuild([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateBuilder aBuilder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DidRebuild([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateBuilder aBuilder);
}
