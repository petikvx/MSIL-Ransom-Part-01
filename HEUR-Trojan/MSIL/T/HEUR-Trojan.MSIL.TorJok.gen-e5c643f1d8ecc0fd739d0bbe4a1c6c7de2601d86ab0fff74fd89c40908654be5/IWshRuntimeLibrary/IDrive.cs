using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("C7C3F5A0-88A3-11D0-ABCB-00A0C90FFFC0")]
[TypeLibType(4304)]
[DefaultMember("Path")]
public interface IDrive
{
	[DispId(0)]
	string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10000)]
	string DriveLetter
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10000)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10001)]
	string ShareName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10001)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[ComAliasName("IWshRuntimeLibrary.DriveTypeConst")]
	[DispId(10002)]
	DriveTypeConst DriveType
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10002)]
		[return: ComAliasName("IWshRuntimeLibrary.DriveTypeConst")]
		get;
	}

	[DispId(10003)]
	Folder RootFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10003)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(10005)]
	object AvailableSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10005)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10004)]
	object FreeSpace
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10004)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10006)]
	object TotalSize
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10006)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10007)]
	string VolumeName
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
	string FileSystem
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10008)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10009)]
	int SerialNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10009)]
		get;
	}

	[DispId(10010)]
	bool IsReady
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10010)]
		get;
	}
}
