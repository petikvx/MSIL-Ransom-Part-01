using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8efb03d4-1354-4875-94cf-261336057626")]
public interface nsIAccessibleSelectable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetSelectedItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetSelectedItemCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetSelectedItemAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsItemSelected(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddItemToSelection(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveItemFromSelection(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnselectAll();
}
