using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d94ac0a0-bb18-46b8-844e-84159064b0bd")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICancelable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel(int aReason);
}
