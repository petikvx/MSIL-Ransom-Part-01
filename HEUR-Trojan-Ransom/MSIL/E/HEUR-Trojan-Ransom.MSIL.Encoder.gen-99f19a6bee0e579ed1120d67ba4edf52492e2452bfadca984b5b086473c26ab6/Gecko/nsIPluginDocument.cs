using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a93a0f0f-24f0-4206-a21b-56a43dcbdd88")]
public interface nsIPluginDocument
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Print();
}
