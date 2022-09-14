using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[TypeLibType(4304)]
[Guid("0AB5A3D0-E5B6-11D0-ABF5-00A0C90FFFC0")]
public interface IFileSystem
{
	[DispId(10010)]
	Drives Drives
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10010)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10000)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string BuildPath([In][MarshalAs(UnmanagedType.BStr)] string Path, [In][MarshalAs(UnmanagedType.BStr)] string Name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10004)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetDriveName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10005)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetParentFolderName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10006)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFileName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10007)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetBaseName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10008)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetExtensionName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10002)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetAbsolutePathName([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10003)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetTempName();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10015)]
	bool DriveExists([In][MarshalAs(UnmanagedType.BStr)] string DriveSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10016)]
	bool FileExists([In][MarshalAs(UnmanagedType.BStr)] string FileSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10017)]
	bool FolderExists([In][MarshalAs(UnmanagedType.BStr)] string FolderSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10011)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Drive GetDrive([In][MarshalAs(UnmanagedType.BStr)] string DriveSpec);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10012)]
	[return: MarshalAs(UnmanagedType.Interface)]
	File GetFile([In][MarshalAs(UnmanagedType.BStr)] string FilePath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10013)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Folder GetFolder([In][MarshalAs(UnmanagedType.BStr)] string FolderPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10014)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Folder GetSpecialFolder([In][ComAliasName("IWshRuntimeLibrary.SpecialFolderConst")] SpecialFolderConst SpecialFolder);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1200)]
	void DeleteFile([In][MarshalAs(UnmanagedType.BStr)] string FileSpec, [In] bool Force = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1201)]
	void DeleteFolder([In][MarshalAs(UnmanagedType.BStr)] string FolderSpec, [In] bool Force = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1204)]
	void MoveFile([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1205)]
	void MoveFolder([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1202)]
	void CopyFile([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination, [In] bool OverWriteFiles = true);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1203)]
	void CopyFolder([In][MarshalAs(UnmanagedType.BStr)] string Source, [In][MarshalAs(UnmanagedType.BStr)] string Destination, [In] bool OverWriteFiles = true);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1120)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Folder CreateFolder([In][MarshalAs(UnmanagedType.BStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1101)]
	[return: MarshalAs(UnmanagedType.Interface)]
	TextStream CreateTextFile([In][MarshalAs(UnmanagedType.BStr)] string FileName, [In] bool Overwrite = true, [In] bool Unicode = false);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1100)]
	[return: MarshalAs(UnmanagedType.Interface)]
	TextStream OpenTextFile([In][MarshalAs(UnmanagedType.BStr)] string FileName, [In] IOMode IOMode = IOMode.ForReading, [In] bool Create = false, [In] Tristate Format = Tristate.TristateFalse);
}
