using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[ComSourceInterfaces("SHDocVw.DShellWindowsEvents\0")]
[ClassInterface(0)]
[Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")]
[TypeLibType(2)]
[DefaultMember("Item")]
public class ShellWindowsClass : IShellWindows, DShellWindowsEvents_Event, ShellWindows, IEnumerable
{
	[DispId(1610743808)]
	public virtual extern int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743808)]
		get;
	}

	public virtual extern event DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;

	public virtual extern event DShellWindowsEvents_WindowRevokedEventHandler WindowRevoked;

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern ShellWindowsClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	public virtual extern object Item([Optional][In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(1610743811)]
	public virtual extern void Register([In][MarshalAs(UnmanagedType.IDispatch)] object pid, [In] int HWND, [In] int swClass, out int plCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(1610743812)]
	public virtual extern void RegisterPending([In] int lThreadId, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarloc, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarlocRoot, [In] int swClass, out int plCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	[TypeLibFunc(64)]
	public virtual extern void Revoke([In] int lCookie);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743814)]
	[TypeLibFunc(64)]
	public virtual extern void OnNavigate([In] int lCookie, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarloc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743815)]
	[TypeLibFunc(64)]
	public virtual extern void OnActivated([In] int lCookie, [In] bool fActive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743816)]
	[TypeLibFunc(64)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	public virtual extern object FindWindowSW([In][MarshalAs(UnmanagedType.Struct)] ref object pvarloc, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarlocRoot, [In] int swClass, out int pHWND, [In] int swfwOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743817)]
	[TypeLibFunc(64)]
	public virtual extern void OnCreated([In] int lCookie, [In][MarshalAs(UnmanagedType.IUnknown)] object punk);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743818)]
	[TypeLibFunc(64)]
	public virtual extern void ProcessAttachDetach([In] bool fAttach);
}
