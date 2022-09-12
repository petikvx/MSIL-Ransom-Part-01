using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0c9f4f74-ee7e-4fe9-be6b-0ba856368178")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISelectionPrivate : nsISelection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMNode GetAnchorNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetAnchorOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMNode GetFocusNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetFocusOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsCollapsedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool Collapsed();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetRangeCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMRange GetRangeAt(int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Collapse([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CollapseNative(IntPtr parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Extend([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ExtendNative(IntPtr parentNode, int offset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CollapseToStart();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void CollapseToEnd();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool ContainsNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node, [MarshalAs(UnmanagedType.U1)] bool partlyContained);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SelectAllChildren([MarshalAs(UnmanagedType.Interface)] nsIDOMNode parentNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveAllRanges();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DeleteFromDocument();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ToString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Modify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase alter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase granularity);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInterlinePositionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInterlinePositionAttribute([MarshalAs(UnmanagedType.U1)] bool aInterlinePosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetAncestorLimiterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAncestorLimiterAttribute(IntPtr aAncestorLimiter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StartBatchChanges();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EndBatchChanges();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToStringWithFormat([MarshalAs(UnmanagedType.LPStr)] string formatType, uint flags, int wrapColumn, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddSelectionListener([MarshalAs(UnmanagedType.Interface)] nsISelectionListener newListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveSelectionListener([MarshalAs(UnmanagedType.Interface)] nsISelectionListener listenerToRemove);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetTableSelectionType([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanCacheFrameOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCanCacheFrameOffsetAttribute([MarshalAs(UnmanagedType.U1)] bool aCanCacheFrameOffset);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCachedFrameOffset(IntPtr aFrame, int inOffset, IntPtr aPoint);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTextRangeStyle([MarshalAs(UnmanagedType.Interface)] nsIDOMRange range, IntPtr textRangeStyle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	nsDirection GetSelectionDirection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionDirection(nsDirection aDirection);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRangesForInterval([MarshalAs(UnmanagedType.Interface)] nsIDOMNode beginNode, int beginOffset, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode endNode, int endOffset, [MarshalAs(UnmanagedType.U1)] bool allowAdjacent, ref uint resultCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] ref nsIDOMRange[] results);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRangesForIntervalArray(IntPtr beginNode, int beginOffset, IntPtr endNode, int endOffset, [MarshalAs(UnmanagedType.U1)] bool allowAdjacent, IntPtr results);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollIntoView(short aRegion, [MarshalAs(UnmanagedType.U1)] bool aIsSynchronous, short aVPercent, short aHPercent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollIntoViewInternal(short aRegion, [MarshalAs(UnmanagedType.U1)] bool aIsSynchronous, ScrollAxis aVertical, ScrollAxis aHorizontal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SelectionLanguageChange([MarshalAs(UnmanagedType.U1)] bool langRTL);
}
