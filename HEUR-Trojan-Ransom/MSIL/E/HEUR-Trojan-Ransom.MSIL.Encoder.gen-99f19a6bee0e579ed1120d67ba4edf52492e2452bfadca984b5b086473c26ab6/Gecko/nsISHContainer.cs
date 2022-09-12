using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("67dd0357-8372-4122-bff6-217435e8b7e4")]
public interface nsISHContainer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetChildCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddChild([MarshalAs(UnmanagedType.Interface)] nsISHEntry child, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveChild([MarshalAs(UnmanagedType.Interface)] nsISHEntry child);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISHEntry GetChildAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsISHEntry aNewChild);
}
