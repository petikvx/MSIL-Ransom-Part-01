using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[DefaultMember("Path")]
[Guid("C7C3F5B3-88A3-11D0-ABCB-00A0C90FFFC0")]
[ClassInterface(0)]
public sealed class FolderClass : IFolder, Folder
{
	[DispId(0)]
	public virtual extern string Path
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1000)]
	public virtual extern string Name
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
	public virtual extern string ShortPath
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1002)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1001)]
	public virtual extern string ShortName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1001)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1004)]
	public virtual extern Drive Drive
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1004)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1005)]
	public virtual extern Folder ParentFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[ComAliasName("IWshRuntimeLibrary.FileAttribute")]
	[DispId(1003)]
	public virtual extern FileAttribute Attributes
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
	public virtual extern DateTime DateCreated
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1006)]
		get;
	}

	[DispId(1007)]
	public virtual extern DateTime DateLastModified
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		get;
	}

	[DispId(1008)]
	public virtual extern DateTime DateLastAccessed
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1008)]
		get;
	}

	[DispId(1010)]
	public virtual extern string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1010)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(10000)]
	public virtual extern bool IsRootFolder
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10000)]
		get;
	}

	[DispId(1009)]
	public virtual extern object Size
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1009)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(10001)]
	public virtual extern Folders SubFolders
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10001)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(10002)]
	public virtual extern Files Files
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10002)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern FolderClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1201)]
	public virtual extern void Delete([In] bool Force = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1203)]
	public virtual extern void Copy([In][MarshalAs(UnmanagedType.BStr)] string Destination, [In] bool OverWriteFiles = true);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1205)]
	public virtual extern void Move([In][MarshalAs(UnmanagedType.BStr)] string Destination);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1101)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern TextStream CreateTextFile([In][MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool Overwrite = true, [In] bool Unicode = false);
}
