using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4160)]
[Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
[DefaultMember("Item")]
public interface IShellWindows : IEnumerable
{
	[DispId(1610743808)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743808)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object Item([Optional][In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	new IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743811)]
	[TypeLibFunc(64)]
	void Register([In][MarshalAs(UnmanagedType.IDispatch)] object pid, [In] int HWND, [In] int swClass, out int plCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(1610743812)]
	void RegisterPending([In] int lThreadId, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarloc, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarlocRoot, [In] int swClass, out int plCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	[TypeLibFunc(64)]
	void Revoke([In] int lCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743814)]
	[TypeLibFunc(64)]
	void OnNavigate([In] int lCookie, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarloc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(1610743815)]
	void OnActivated([In] int lCookie, [In] bool fActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(1610743816)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object FindWindowSW([In][MarshalAs(UnmanagedType.Struct)] ref object pvarloc, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarlocRoot, [In] int swClass, out int pHWND, [In] int swfwOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743817)]
	[TypeLibFunc(64)]
	void OnCreated([In] int lCookie, [In][MarshalAs(UnmanagedType.IUnknown)] object punk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(1610743818)]
	void ProcessAttachDetach([In] bool fAttach);
}
