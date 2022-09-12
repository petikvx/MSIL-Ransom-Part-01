using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("655078bf-1675-4aa0-a48d-a133e864ce57")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMDataTransfer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDropEffectAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDropEffect);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDropEffectAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDropEffect);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEffectAllowedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEffectAllowed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEffectAllowedAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aEffectAllowed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMFileList GetFilesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetTypesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase format);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetData([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase format, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDragImage([MarshalAs(UnmanagedType.Interface)] nsIDOMElement image, int x, int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMozItemCountAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMozCursorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMozCursor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMozCursorAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aMozCursor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports MozTypesAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MozClearDataAt([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase format, uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozUserCancelledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetMozSourceNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDropEffectIntAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDropEffectIntAttribute(uint aDropEffectInt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEffectAllowedIntAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEffectAllowedIntAttribute(uint aEffectAllowedInt);
}
