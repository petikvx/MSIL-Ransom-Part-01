using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8148E3F1-2E8B-11d5-A86C-00105A183419")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrintPreviewNavigation
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPageCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool NextPage();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PreviousPage();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GoToPage(uint aPageNumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SkipPages(int aNumPages);
}
