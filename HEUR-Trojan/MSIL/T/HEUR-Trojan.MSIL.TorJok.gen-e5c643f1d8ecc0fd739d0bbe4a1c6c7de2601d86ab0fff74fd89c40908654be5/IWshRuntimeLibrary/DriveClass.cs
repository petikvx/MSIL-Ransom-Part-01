using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[ClassInterface(0)]
[DefaultMember("Path")]
[Guid("C7C3F5B1-88A3-11D0-ABCB-00A0C90FFFC0")]
public sealed class DriveClass : IDrive, Drive
{
	[DispId(0)]
	public virtual extern string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10000)]
	public virtual extern string DriveLetter
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10000)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10001)]
	public virtual extern string ShareName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10001)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10002)]
	[ComAliasName("IWshRuntimeLibrary.DriveTypeConst")]
	public virtual extern DriveTypeConst DriveType
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10002)]
		[return: ComAliasName("IWshRuntimeLibrary.DriveTypeConst")]
		get;
	}

	[DispId(10003)]
	public virtual extern Folder RootFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10003)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(10005)]
	public virtual extern object AvailableSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10005)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10004)]
	public virtual extern object FreeSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10004)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10006)]
	public virtual extern object TotalSize
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10006)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10007)]
	public virtual extern string VolumeName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10007)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10007)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(10008)]
	public virtual extern string FileSystem
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10008)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10009)]
	public virtual extern int SerialNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10009)]
		get;
	}

	[DispId(10010)]
	public virtual extern bool IsReady
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10010)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern DriveClass();
}
