using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[DefaultMember("Name")]
[TypeLibType(4176)]
[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
public interface IWebBrowser2 : IWebBrowserApp
{
	[DispId(200)]
	new object Application
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(201)]
	new object Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(202)]
	new object Container
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(203)]
	new object Document
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(203)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(204)]
	new bool TopLevelContainer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	new string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(205)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(206)]
	new int Left
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(206)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(206)]
		[param: In]
		set;
	}

	[DispId(207)]
	new int Top
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(207)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(207)]
		[param: In]
		set;
	}

	[DispId(208)]
	new int Width
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(208)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(208)]
		[param: In]
		set;
	}

	[DispId(209)]
	new int Height
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(209)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(209)]
		[param: In]
		set;
	}

	[DispId(210)]
	new string LocationName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	new string LocationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(211)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(212)]
	new bool Busy
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(212)]
		get;
	}

	[DispId(0)]
	new string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(-515)]
	new int HWND
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-515)]
		get;
	}

	[DispId(400)]
	new string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(401)]
	new string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(401)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(402)]
	new bool Visible
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(402)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(402)]
		[param: In]
		set;
	}

	[DispId(403)]
	new bool StatusBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(403)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(403)]
		[param: In]
		set;
	}

	[DispId(404)]
	new string StatusText
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(404)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(404)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(405)]
	new int ToolBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(405)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(405)]
		[param: In]
		set;
	}

	[DispId(406)]
	new bool MenuBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(406)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(406)]
		[param: In]
		set;
	}

	[DispId(407)]
	new bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(407)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(407)]
		[param: In]
		set;
	}

	[DispId(-525)]
	tagREADYSTATE ReadyState
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-525)]
		[TypeLibFunc(4)]
		get;
	}

	[DispId(550)]
	bool Offline
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(550)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(550)]
		[param: In]
		set;
	}

	[DispId(551)]
	bool Silent
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(551)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(551)]
		[param: In]
		set;
	}

	[DispId(552)]
	bool RegisterAsBrowser
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(552)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(552)]
		[param: In]
		set;
	}

	[DispId(553)]
	bool RegisterAsDropTarget
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(553)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(553)]
		[param: In]
		set;
	}

	[DispId(554)]
	bool TheaterMode
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(554)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(554)]
		[param: In]
		set;
	}

	[DispId(555)]
	bool AddressBar
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(555)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(555)]
		[param: In]
		set;
	}

	[DispId(556)]
	bool Resizable
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(556)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(556)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(100)]
	new void GoBack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(101)]
	new void GoForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(102)]
	new void GoHome();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(103)]
	new void GoSearch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(104)]
	new void Navigate([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-550)]
	new void Refresh();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(105)]
	new void Refresh2([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Level);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(106)]
	new void Stop();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(300)]
	new void Quit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(301)]
	new void ClientToWindow([In][Out] ref int pcx, [In][Out] ref int pcy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(302)]
	new void PutProperty([In][MarshalAs(UnmanagedType.BStr)] string Property, [In][MarshalAs(UnmanagedType.Struct)] object vtValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(303)]
	[return: MarshalAs(UnmanagedType.Struct)]
	new object GetProperty([In][MarshalAs(UnmanagedType.BStr)] string Property);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(500)]
	void Navigate2([In][MarshalAs(UnmanagedType.Struct)] ref object URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(501)]
	OLECMDF QueryStatusWB([In] OLECMDID cmdID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(502)]
	void ExecWB([In] OLECMDID cmdID, [In] OLECMDEXECOPT cmdexecopt, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvaIn, [Optional][In][Out][MarshalAs(UnmanagedType.Struct)] ref object pvaOut);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(503)]
	void ShowBrowserBar([In][MarshalAs(UnmanagedType.Struct)] ref object pvaClsid, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarShow, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object pvarSize);
}
