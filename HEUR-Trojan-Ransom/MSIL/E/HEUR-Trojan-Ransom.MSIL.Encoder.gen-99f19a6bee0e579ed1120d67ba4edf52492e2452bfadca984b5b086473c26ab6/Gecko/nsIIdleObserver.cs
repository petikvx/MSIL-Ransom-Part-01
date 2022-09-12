using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("37916e05-e062-4f72-96d5-660cfb55e9b6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIIdleObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Onidle();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Onactive();
}
