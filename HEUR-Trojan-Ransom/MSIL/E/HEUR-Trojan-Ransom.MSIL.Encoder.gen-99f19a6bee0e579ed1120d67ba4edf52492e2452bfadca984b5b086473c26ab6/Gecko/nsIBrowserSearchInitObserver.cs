using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("02256156-16e4-47f1-9979-76ff98ceb590")]
public interface nsIBrowserSearchInitObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnInitComplete(int aStatus);
}
