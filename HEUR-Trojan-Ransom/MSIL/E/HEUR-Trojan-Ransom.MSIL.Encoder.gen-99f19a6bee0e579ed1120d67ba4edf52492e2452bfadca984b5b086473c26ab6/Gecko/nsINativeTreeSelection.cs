using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1bd59678-5cb3-4316-b246-31a91b19aabe")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsINativeTreeSelection : nsITreeSelection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsITreeBoxObject GetTreeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetTreeAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeBoxObject aTree);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetSingleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsSelected(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Select(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void TimedSelect(int index, int delay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ToggleSelect(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RangedSelect(int startIndex, int endIndex, [MarshalAs(UnmanagedType.U1)] bool augment);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ClearRange(int startIndex, int endIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ClearSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InvertSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetRangeCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetRangeAt(int i, ref int min, ref int max);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void InvalidateSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AdjustSelection(int index, int count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetSelectEventsSuppressedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetSelectEventsSuppressedAttribute([MarshalAs(UnmanagedType.U1)] bool aSelectEventsSuppressed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetCurrentIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCurrentIndexAttribute(int aCurrentIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsITreeColumn GetCurrentColumnAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCurrentColumnAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeColumn aCurrentColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetShiftSelectPivotAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnsureNative();
}
