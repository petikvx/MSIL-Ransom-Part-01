using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4176)]
[Guid("0002DF05-0000-0000-C000-000000000046")]
[DefaultMember("Name")]
public interface IWebBrowserApp : IWebBrowser
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
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(-515)]
	int HWND
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-515)]
		get;
	}

	[DispId(400)]
	string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(401)]
	string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(401)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(402)]
	bool Visible
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
	bool StatusBar
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
	string StatusText
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
	int ToolBar
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
	bool MenuBar
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
	bool FullScreen
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(407)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(407)]
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
	void Quit();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(301)]
	void ClientToWindow([In][Out] ref int pcx, [In][Out] ref int pcy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(302)]
	void PutProperty([In][MarshalAs(UnmanagedType.BStr)] string Property, [In][MarshalAs(UnmanagedType.Struct)] object vtValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(303)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In][MarshalAs(UnmanagedType.BStr)] string Property);
}
