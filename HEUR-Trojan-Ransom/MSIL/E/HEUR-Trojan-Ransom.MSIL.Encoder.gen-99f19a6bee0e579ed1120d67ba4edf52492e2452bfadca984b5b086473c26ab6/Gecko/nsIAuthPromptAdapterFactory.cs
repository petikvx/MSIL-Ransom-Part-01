using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("60e46383-bb9a-4860-8962-80d9c5c05ddc")]
public interface nsIAuthPromptAdapterFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAuthPrompt2 CreateAdapter([MarshalAs(UnmanagedType.Interface)] nsIAuthPrompt aPrompt);
}
