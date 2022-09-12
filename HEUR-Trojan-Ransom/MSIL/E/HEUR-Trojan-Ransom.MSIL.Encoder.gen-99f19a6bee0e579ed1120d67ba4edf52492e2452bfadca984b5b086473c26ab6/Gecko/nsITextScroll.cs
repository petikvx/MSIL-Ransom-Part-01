using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("067B28A0-877F-11d3-AF7E-00A024FFC08C")]
public interface nsITextScroll
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollByLines(int numLines);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollByPages(int numPages);
}
