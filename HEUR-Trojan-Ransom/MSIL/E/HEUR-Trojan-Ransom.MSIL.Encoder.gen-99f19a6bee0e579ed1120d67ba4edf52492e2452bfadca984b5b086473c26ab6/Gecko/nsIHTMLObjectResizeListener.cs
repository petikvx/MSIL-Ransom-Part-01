using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("27b00295-349c-429f-ad0c-87b859e77130")]
public interface nsIHTMLObjectResizeListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnStartResizing([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnEndResizing([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aOldWidth, int aOldHeight, int aNewWidth, int aNewHeight);
}
