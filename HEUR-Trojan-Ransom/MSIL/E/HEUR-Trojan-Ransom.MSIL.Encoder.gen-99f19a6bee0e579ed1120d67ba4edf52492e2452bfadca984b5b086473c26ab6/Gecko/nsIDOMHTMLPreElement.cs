using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a2441b77-ad22-4275-b1dd-1b58c044fd04")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMHTMLPreElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWidthAttribute(int aWidth);
}
