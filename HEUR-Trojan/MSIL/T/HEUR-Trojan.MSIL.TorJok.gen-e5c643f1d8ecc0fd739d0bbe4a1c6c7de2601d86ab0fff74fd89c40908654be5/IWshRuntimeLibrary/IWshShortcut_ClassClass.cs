using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("F935DC24-1CF0-11D0-ADB9-00C04FD58A0B")]
[TypeLibType(16)]
[ClassInterface(0)]
[DefaultMember("FullName")]
public sealed class IWshShortcut_ClassClass : IWshShortcut, IWshShortcut_Class
{
	[DispId(0)]
	public virtual extern string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1000)]
	public virtual extern string Arguments
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
	public virtual extern string Description
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
	public virtual extern string Hotkey
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
	public virtual extern string IconLocation
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
	public virtual extern string RelativePath
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1004)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1005)]
	public virtual extern string TargetPath
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
	public virtual extern int WindowStyle
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
	public virtual extern string WorkingDirectory
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
	internal extern IWshShortcut_ClassClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(64)]
	[DispId(2000)]
	public virtual extern void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	public virtual extern void Save();
}
