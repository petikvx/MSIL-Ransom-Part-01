using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("729FE2F8-1EA8-11D1-8F85-00C04FC2FBE1")]
[TypeLibType(4160)]
public interface IShellUIHelper
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	[TypeLibFunc(64)]
	void ResetFirstBootMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(2)]
	void ResetSafeMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(3)]
	void RefreshOfflineDesktop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	void AddFavorite([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Title);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(5)]
	void AddChannel([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(6)]
	void AddDesktopComponent([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Left, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Top, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Width, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(7)]
	bool IsSubscribed([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(8)]
	void NavigateAndFind([In][MarshalAs(UnmanagedType.BStr)] string URL, [In][MarshalAs(UnmanagedType.BStr)] string strQuery, [In][MarshalAs(UnmanagedType.Struct)] ref object varTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	void ImportExportFavorites([In] bool fImport, [In][MarshalAs(UnmanagedType.BStr)] string strImpExpPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10)]
	void AutoCompleteSaveForm([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Form);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(11)]
	void AutoScan([In][MarshalAs(UnmanagedType.BStr)] string strSearch, [In][MarshalAs(UnmanagedType.BStr)] string strFailureUrl, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarTargetFrame);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(12)]
	void AutoCompleteAttach([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Reserved);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object ShowBrowserUI([In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.Struct)] ref object pvarIn);
}
