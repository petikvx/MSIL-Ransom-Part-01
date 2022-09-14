using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[TypeLibType(4160)]
[DefaultMember("FullName")]
[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
public interface IWshShortcut
{
	[DispId(0)]
	string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1000)]
	string Arguments
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1000)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1000)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1001)]
	string Description
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1001)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1001)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1002)]
	string Hotkey
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1002)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1002)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1003)]
	string IconLocation
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1003)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1003)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1004)]
	string RelativePath
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1004)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1005)]
	string TargetPath
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1006)]
	int WindowStyle
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1006)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1006)]
		[param: In]
		set;
	}

	[DispId(1007)]
	string WorkingDirectory
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2000)]
	[TypeLibFunc(64)]
	void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	void Save();
}
