using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9F82C404-1C7B-11D5-A73C-ECA43CA836FC")]
public interface nsIControllerCommandGroup
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddCommandToGroup([MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.LPStr)] string aGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveCommandFromGroup([MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.LPStr)] string aGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCommandInGroup([MarshalAs(UnmanagedType.LPStr)] string aCommand, [MarshalAs(UnmanagedType.LPStr)] string aGroup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetGroupsEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetEnumeratorForGroup([MarshalAs(UnmanagedType.LPStr)] string aGroup);
}
