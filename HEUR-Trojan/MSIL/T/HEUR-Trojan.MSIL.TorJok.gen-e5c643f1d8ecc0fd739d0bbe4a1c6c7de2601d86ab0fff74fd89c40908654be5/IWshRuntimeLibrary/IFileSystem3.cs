using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[TypeLibType(4288)]
[Guid("2A0B9D10-4B87-11D3-A97A-00104B365C9F")]
public interface IFileSystem3 : IFileSystem
{
	[DispId(10010)]
	new Drives Drives
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10010)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10000)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string BuildPath([In][MarshalAs(UnmanagedType.BStr)] string Path, [In][MarshalAs(UnmanagedType.BStr)] string Name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10004)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetDriveName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10005)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetParentFolderName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10006)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetFileName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10007)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetBaseName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10008)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetExtensionName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10002)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetAbsolutePathName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10003)]
	[return: MarshalAs(UnmanagedType.BStr)]
	new string GetTempName();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10015)]
	new bool DriveExists([In][MarshalAs(UnmanagedType.BStr)] string DriveSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10016)]
	new bool FileExists([In][MarshalAs(UnmanagedType.BStr)] string FileSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10017)]
	new bool FolderExists([In][MarshalAs(UnmanagedType.BStr)] string FolderSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10011)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new Drive GetDrive([In][MarshalAs(UnmanagedType.BStr)] string DriveSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10012)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new File GetFile([In][MarshalAs(UnmanagedType.BStr)] string FilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10013)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new Folder GetFolder([In][MarshalAs(UnmanagedType.BStr)] string FolderPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10014)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new Folder GetSpecialFolder([In][ComAliasName("IWshRuntimeLibrary.SpecialFolderConst")] SpecialFolderConst SpecialFolder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1200)]
	new void DeleteFile([In][MarshalAs(UnmanagedType.BStr)] string FileSpec, [In] bool Force = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1201)]
	new void DeleteFolder([In][MarshalAs(UnmanagedType.BStr)] string FolderSpec, [In] bool Force = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1204)]
	new void MoveFile([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1205)]
	new void MoveFolder([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1202)]
	new void CopyFile([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination, [In] bool OverWriteFiles = true);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1203)]
	new void CopyFolder([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination, [In] bool OverWriteFiles = true);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1120)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new Folder CreateFolder([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1101)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new TextStream CreateTextFile([In][MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool Overwrite = true, [In] bool Unicode = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1100)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new TextStream OpenTextFile([In][MarshalAs(UnmanagedType.BStr)] string FileName, [In] IOMode IOMode = IOMode.ForReading, [In] bool Create = false, [In] Tristate Format = Tristate.TristateFalse);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(20000)]
	[return: MarshalAs(UnmanagedType.Interface)]
	TextStream GetStandardStream([In][ComAliasName("IWshRuntimeLibrary.StandardStreamTypes")] StandardStreamTypes StandardStreamType, [In] bool Unicode = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(20010)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFileVersion([In][MarshalAs(UnmanagedType.BStr)] string FileName);
}
