using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[DefaultMember("Path")]
[TypeLibType(4304)]
[Guid("C7C3F5A2-88A3-11D0-ABCB-00A0C90FFFC0")]
public interface IFolder
{
	[DispId(0)]
	string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1000)]
	string Name
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

	[DispId(1002)]
	string ShortPath
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1002)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1001)]
	string ShortName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1001)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1004)]
	Drive Drive
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1004)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1005)]
	Folder ParentFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1003)]
	[ComAliasName("IWshRuntimeLibrary.FileAttribute")]
	FileAttribute Attributes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1003)]
		[return: ComAliasName("IWshRuntimeLibrary.FileAttribute")]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1003)]
		[param: In]
		[param: ComAliasName("IWshRuntimeLibrary.FileAttribute")]
		set;
	}

	[DispId(1006)]
	DateTime DateCreated
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1006)]
		get;
	}

	[DispId(1007)]
	DateTime DateLastModified
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		get;
	}

	[DispId(1008)]
	DateTime DateLastAccessed
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1008)]
		get;
	}

	[DispId(1010)]
	string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1010)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10000)]
	bool IsRootFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10000)]
		get;
	}

	[DispId(1009)]
	object Size
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1009)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10001)]
	Folders SubFolders
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10001)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(10002)]
	Files Files
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10002)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1201)]
	void Delete([In] bool Force = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1203)]
	void Copy([In][MarshalAs(UnmanagedType.BStr)] string Destination, [In] bool OverWriteFiles = true);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1205)]
	void Move([In][MarshalAs(UnmanagedType.BStr)] string Destination);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1101)]
	[return: MarshalAs(UnmanagedType.Interface)]
	TextStream CreateTextFile([In][MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool Overwrite = true, [In] bool Unicode = false);
}
