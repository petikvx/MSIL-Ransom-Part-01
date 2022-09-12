using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("F15398A0-8018-11d3-AF70-00A024FFC08C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebBrowserSetup
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProperty(uint aId, uint aValue);
}
