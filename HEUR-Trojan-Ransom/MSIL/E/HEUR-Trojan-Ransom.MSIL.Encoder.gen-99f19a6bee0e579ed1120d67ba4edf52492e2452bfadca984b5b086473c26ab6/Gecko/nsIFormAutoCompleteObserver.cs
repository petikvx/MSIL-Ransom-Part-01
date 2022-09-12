using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("604419ab-55a0-4831-9eca-1b9e67cc4751")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFormAutoCompleteObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnSearchCompletion([MarshalAs(UnmanagedType.Interface)] nsIAutoCompleteResult result);
}
