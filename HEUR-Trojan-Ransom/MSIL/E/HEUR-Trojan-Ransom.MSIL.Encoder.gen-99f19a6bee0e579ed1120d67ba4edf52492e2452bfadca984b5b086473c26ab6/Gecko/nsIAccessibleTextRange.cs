using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("525b3401-8a67-4822-b35d-661065767cd8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleTextRange
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleText GetStartContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStartOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleText GetEndContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEndOffsetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessible GetContainerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetEmbeddedChildrenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Compare([MarshalAs(UnmanagedType.Interface)] nsIAccessibleTextRange aOtherRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int CompareEndPoints(uint aEndPoint, [MarshalAs(UnmanagedType.Interface)] nsIAccessibleTextRange aOtherRange, uint aOtherRangeEndPoint);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTextAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIArray GetBoundsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Move(uint aUnit, int aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveStart(uint aUnit, int aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MoveEnd(uint aUnit, int aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Normalize(uint aUnit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleTextRange FindText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aText, [MarshalAs(UnmanagedType.U1)] bool aIsBackward, [MarshalAs(UnmanagedType.U1)] bool aIsIgnoreCase);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIAccessibleTextRange FindAttr(uint aAttr, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue, [MarshalAs(UnmanagedType.U1)] bool aIsBackward);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddToSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveFromSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Select();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScrollIntoView(uint aHow);
}
