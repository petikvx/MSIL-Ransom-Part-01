using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[ClassInterface(0)]
[Guid("64AB4BB7-111E-11D1-8F79-00C04FC2FBE1")]
[TypeLibType(2)]
public class ShellUIHelperClass : IShellUIHelper, ShellUIHelper
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern ShellUIHelperClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	[TypeLibFunc(64)]
	public virtual extern void ResetFirstBootMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(2)]
	public virtual extern void ResetSafeMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(3)]
	public virtual extern void RefreshOfflineDesktop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	public virtual extern void AddFavorite([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Title);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(5)]
	public virtual extern void AddChannel([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(6)]
	public virtual extern void AddDesktopComponent([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Left, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Top, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Width, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(7)]
	public virtual extern bool IsSubscribed([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(8)]
	public virtual extern void NavigateAndFind([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string strQuery, [In][MarshalAs(UnmanagedType.Struct)] ref object varTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	public virtual extern void ImportExportFavorites([In] bool fImport, [In][MarshalAs(UnmanagedType.BStr)] string strImpExpPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10)]
	public virtual extern void AutoCompleteSaveForm([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Form);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(11)]
	public virtual extern void AutoScan([In][MarshalAs(UnmanagedType.BStr)] string strSearch, [In][MarshalAs(UnmanagedType.BStr)] string strFailureUrl, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	[TypeLibFunc(64)]
	public virtual extern void AutoCompleteAttach([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Reserved);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object ShowBrowserUI([In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarIn);
}
