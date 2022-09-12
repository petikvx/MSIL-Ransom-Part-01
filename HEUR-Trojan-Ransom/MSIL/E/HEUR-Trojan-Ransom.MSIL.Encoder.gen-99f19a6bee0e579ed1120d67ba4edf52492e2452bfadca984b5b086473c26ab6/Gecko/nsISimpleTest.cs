using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f2f71d91-0451-47ec-aaa0-166663a7711a")]
public interface nsISimpleTest
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int Add(int a, int b);
}
