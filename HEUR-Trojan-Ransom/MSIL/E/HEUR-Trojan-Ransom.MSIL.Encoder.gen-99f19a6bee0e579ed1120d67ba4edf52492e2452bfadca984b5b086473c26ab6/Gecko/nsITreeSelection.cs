using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ab6fe746-300b-4ab4-abb9-1c0e3977874c")]
public interface nsITreeSelection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeBoxObject GetTreeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTreeAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeBoxObject aTree);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSingleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSelected(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Select(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TimedSelect(int index, int delay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToggleSelect(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RangedSelect(int startIndex, int endIndex, [MarshalAs(UnmanagedType.U1)] bool augment);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearRange(int startIndex, int endIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvertSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetRangeCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRangeAt(int i, ref int min, ref int max);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AdjustSelection(int index, int count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSelectEventsSuppressedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectEventsSuppressedAttribute([MarshalAs(UnmanagedType.U1)] bool aSelectEventsSuppressed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCurrentIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentIndexAttribute(int aCurrentIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITreeColumn GetCurrentColumnAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCurrentColumnAttribute([MarshalAs(UnmanagedType.Interface)] nsITreeColumn aCurrentColumn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetShiftSelectPivotAttribute();
}
