using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("062ea35a-5158-425a-b7bc-3ae9daa84398")]
public interface nsIDOMDOMCursor
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDoneAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Continue();
}
