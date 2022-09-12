using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6044702d-e4a9-420c-b711-558b7d6a3b9f")]
public interface nsIDOMOfflineResourceList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetMozItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MozHasItem([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMozLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MozItem(uint index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MozAdd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MozRemove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase uri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	ushort GetStatusAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Update();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SwapCache();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOncheckingAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOncheckingAttribute(JsVal aOnchecking, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnerrorAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnerrorAttribute(JsVal aOnerror, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnnoupdateAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnnoupdateAttribute(JsVal aOnnoupdate, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOndownloadingAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOndownloadingAttribute(JsVal aOndownloading, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnprogressAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnprogressAttribute(JsVal aOnprogress, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnupdatereadyAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnupdatereadyAttribute(JsVal aOnupdateready, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOncachedAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOncachedAttribute(JsVal aOncached, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetOnobsoleteAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOnobsoleteAttribute(JsVal aOnobsolete, IntPtr jsContext);
}
