using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[InterfaceType(2)]
[Guid("EAB22AC2-30C1-11CF-A7EB-0000C05BAE0B")]
[TypeLibType(4112)]
public interface DWebBrowserEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(100)]
	void BeforeNavigate([In][MarshalAs(UnmanagedType.BStr)] string URL, int Flags, [MarshalAs(UnmanagedType.BStr)] string TargetFrameName, [MarshalAs(UnmanagedType.Struct)] ref object PostData, [MarshalAs(UnmanagedType.BStr)] string Headers, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(101)]
	void NavigateComplete([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(102)]
	void StatusTextChange([In][MarshalAs(UnmanagedType.BStr)] string Text);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(108)]
	void ProgressChange([In] int Progress, [In] int ProgressMax);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(104)]
	void DownloadComplete();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(105)]
	void CommandStateChange([In] int Command, [In] bool Enable);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(106)]
	void DownloadBegin();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(107)]
	void NewWindow([In][MarshalAs(UnmanagedType.BStr)] string URL, [In] int Flags, [In][MarshalAs(UnmanagedType.BStr)] string TargetFrameName, [In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [In][MarshalAs(UnmanagedType.BStr)] string Headers, [In][Out] ref bool Processed);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(113)]
	void TitleChange([In][MarshalAs(UnmanagedType.BStr)] string Text);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(200)]
	void FrameBeforeNavigate([In][MarshalAs(UnmanagedType.BStr)] string URL, int Flags, [MarshalAs(UnmanagedType.BStr)] string TargetFrameName, [MarshalAs(UnmanagedType.Struct)] ref object PostData, [MarshalAs(UnmanagedType.BStr)] string Headers, [In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(201)]
	void FrameNavigateComplete([In][MarshalAs(UnmanagedType.BStr)] string URL);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(204)]
	void FrameNewWindow([In][MarshalAs(UnmanagedType.BStr)] string URL, [In] int Flags, [In][MarshalAs(UnmanagedType.BStr)] string TargetFrameName, [In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [In][MarshalAs(UnmanagedType.BStr)] string Headers, [In][Out] ref bool Processed);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(103)]
	void Quit([In][Out] ref bool Cancel);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(109)]
	void WindowMove();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(110)]
	void WindowResize();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(111)]
	void WindowActivate();

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(112)]
	void PropertyChange([In][MarshalAs(UnmanagedType.BStr)] string Property);
}
