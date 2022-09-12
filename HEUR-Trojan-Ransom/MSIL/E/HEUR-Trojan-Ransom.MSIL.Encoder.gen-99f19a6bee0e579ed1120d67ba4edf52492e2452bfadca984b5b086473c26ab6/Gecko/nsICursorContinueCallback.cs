using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3a75d80a-9258-4ab8-95fd-ec0b5f634df1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICursorContinueCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleContinue();
}
