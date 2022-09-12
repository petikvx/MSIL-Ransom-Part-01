using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("654e296d-fae6-452b-987d-746b20b9514b")]
public interface nsIAccessibleTableCell
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleTable GetTableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColumnIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColumnExtentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRowExtentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetColumnHeaderCellsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetRowHeaderCellsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSelected();
}
