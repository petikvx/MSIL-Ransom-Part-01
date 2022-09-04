using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4176)]
[Guid("EAB22AC1-30C1-11CF-A7EB-0000C05BAE0B")]
public interface IWebBrowser
{
	[DispId(200)]
	object Application
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(201)]
	object Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(201)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(202)]
	object Container
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(202)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(203)]
	object Document
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(203)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(204)]
	bool TopLevelContainer
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(204)]
		get;
	}

	[DispId(205)]
	string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(205)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(206)]
	int Left
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
	int Top
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
	int Width
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
	int Height
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
	string LocationName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(210)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(211)]
	string LocationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(211)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(212)]
	bool Busy
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(212)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(100)]
	void GoBack();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(101)]
	void GoForward();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(102)]
	void GoHome();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(103)]
	void GoSearch();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(104)]
	void Navigate([In][MarshalAs(UnmanagedType.BStr)] string URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-550)]
	void Refresh();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(105)]
	void Refresh2([Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Level);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(106)]
	void Stop();
}
