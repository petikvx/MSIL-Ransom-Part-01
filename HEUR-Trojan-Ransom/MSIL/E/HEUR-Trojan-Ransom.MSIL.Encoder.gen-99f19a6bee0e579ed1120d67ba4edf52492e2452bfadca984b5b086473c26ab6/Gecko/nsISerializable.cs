using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("91cca981-c26d-44a8-bebe-d9ed4891503a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISerializable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);
}
