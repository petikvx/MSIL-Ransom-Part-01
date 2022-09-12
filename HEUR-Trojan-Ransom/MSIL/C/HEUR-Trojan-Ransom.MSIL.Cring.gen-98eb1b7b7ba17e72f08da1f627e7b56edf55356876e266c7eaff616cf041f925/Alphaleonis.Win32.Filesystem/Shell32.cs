using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Alphaleonis.Win32.Filesystem;

public static class Shell32
{
	[Flags]
	public enum AssociationAttributes
	{
		None = 0,
		InitNoRemapClsid = 1,
		InitByExeName = 2,
		InitDefaultToStar = 4,
		InitDefaultToFolder = 8,
		NoUserSettings = 0x10,
		NoTruncate = 0x20,
		Verify = 0x40,
		RemapRunDll = 0x80,
		[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "FixUps")]
		NoFixUps = 0x100,
		IgnoreBaseClass = 0x200,
		InitIgnoreUnknown = 0x400,
		InitFixedProgId = 0x800,
		IsProtocol = 0x1000
	}

	public enum AssociationString
	{
		None,
		Command,
		Executable,
		FriendlyDocName,
		FriendlyAppName,
		NoOpen,
		ShellNewValue,
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dde")]
		DdeCommand,
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dde")]
		DdeIfExec,
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dde")]
		DdeApplication,
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dde")]
		DdeTopic,
		InfoTip,
		QuickTip,
		TileInfo,
		ContentType,
		DefaultIcon,
		ShellExtension,
		DropTarget,
		DelegateExecute,
		SupportedUriProtocols,
		Max
	}

	[Flags]
	[SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	public enum FileAttributes
	{
		LargeIcon = 0,
		SmallIcon = 1,
		OpenIcon = 2,
		ShellIconSize = 4,
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pidl")]
		Pidl = 8,
		UseFileAttributes = 0x10,
		AddOverlays = 0x20,
		OverlayIndex = 0x40,
		Icon = 0x100,
		DisplayName = 0x200,
		TypeName = 0x400,
		Attributes = 0x800,
		IconLocation = 0x1000,
		ExeType = 0x2000,
		SysIconIndex = 0x4000,
		LinkOverlay = 0x8000,
		Selected = 0x10000,
		AttributesSpecified = 0x20000
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sh")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Sh")]
	[SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes")]
	public struct FileInfo
	{
		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public readonly IntPtr IconHandle;

		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public int IconIndex;

		[MarshalAs(UnmanagedType.U4)]
		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public readonly GetAttributesOf Attributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public string DisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		[SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
		public string TypeName;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Sh")]
	[SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Sh")]
	[Flags]
	[SuppressMessage("Microsoft.Usage", "CA2217:DoNotMarkEnumsWithFlags")]
	[SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
	public enum GetAttributesOf
	{
		None = 0,
		CanCopy = 1,
		CanMove = 2,
		CanLink = 4,
		Storage = 8,
		CanRename = 0x10,
		CanDelete = 0x20,
		HasPropSheet = 0x40,
		DropTarget = 0x100,
		System = 0x1000,
		Encrypted = 0x2000,
		IsSlow = 0x4000,
		Ghosted = 0x8000,
		Link = 0x10000,
		Share = 0x20000,
		ReadOnly = 0x40000,
		Hidden = 0x80000,
		NonEnumerated = 0x100000,
		NewContent = 0x200000,
		Stream = 0x400000,
		StorageAncestor = 0x800000,
		Validate = 0x1000000,
		Removable = 0x2000000,
		Compressed = 0x4000000,
		Browsable = 0x8000000,
		FileSysAncestor = 0x10000000,
		Folder = 0x20000000,
		FileSystem = 0x40000000,
		[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "SubFolder")]
		HasSubFolder = int.MinValue
	}

	public enum UrlType
	{
		IsUrl,
		IsOpaque,
		IsNoHistory,
		IsFileUrl,
		[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Appliable")]
		IsAppliable,
		IsDirectory,
		IsHasQuery
	}

	public static void DestroyIcon(IntPtr iconHandle)
	{
		if (IntPtr.Zero != iconHandle)
		{
			NativeMethods.DestroyIcon(iconHandle);
		}
	}

	[SecurityCritical]
	public static string GetFileAssociation(string path)
	{
		return GetFileAssociationCore(path, AssociationAttributes.Verify, AssociationString.Executable);
	}

	[SecurityCritical]
	public static string GetFileContentType(string path)
	{
		return GetFileAssociationCore(path, AssociationAttributes.Verify, AssociationString.ContentType);
	}

	[SecurityCritical]
	public static string GetFileDefaultIcon(string path)
	{
		return GetFileAssociationCore(path, AssociationAttributes.Verify, AssociationString.DefaultIcon);
	}

	[SecurityCritical]
	public static string GetFileFriendlyAppName(string path)
	{
		return GetFileAssociationCore(path, AssociationAttributes.InitByExeName, AssociationString.FriendlyAppName);
	}

	[SecurityCritical]
	public static string GetFileFriendlyDocName(string path)
	{
		return GetFileAssociationCore(path, AssociationAttributes.Verify, AssociationString.FriendlyDocName);
	}

	[SecurityCritical]
	public static IntPtr GetFileIcon(string filePath, FileAttributes iconAttributes)
	{
		if (Utils.IsNullOrWhiteSpace(filePath))
		{
			return IntPtr.Zero;
		}
		FileInfo fileInfoCore = GetFileInfoCore(filePath, System.IO.FileAttributes.Normal, FileAttributes.Icon | iconAttributes, checkInvalidPathChars: true, continueOnException: true);
		if (!(fileInfoCore.IconHandle == IntPtr.Zero))
		{
			return fileInfoCore.IconHandle;
		}
		return IntPtr.Zero;
	}

	[SecurityCritical]
	public static FileInfo GetFileInfo(string filePath, System.IO.FileAttributes attributes, FileAttributes fileAttributes, bool continueOnException)
	{
		return GetFileInfoCore(filePath, attributes, fileAttributes, checkInvalidPathChars: true, continueOnException);
	}

	[SecurityCritical]
	public static Shell32Info GetShell32Info(string path)
	{
		return new Shell32Info(path);
	}

	[SecurityCritical]
	public static Shell32Info GetShell32Info(string path, PathFormat pathFormat)
	{
		return new Shell32Info(path, pathFormat);
	}

	[SecurityCritical]
	public static string GetFileOpenWithAppName(string path)
	{
		return GetFileAssociationCore(path, AssociationAttributes.Verify, AssociationString.FriendlyAppName);
	}

	[SecurityCritical]
	public static string GetFileVerbCommand(string path)
	{
		return GetFileAssociationCore(path, AssociationAttributes.Verify, AssociationString.Command);
	}

	[SecurityCritical]
	internal static string PathCreateFromUrl(string urlPath)
	{
		if (urlPath == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(32700);
		uint pcchPath = (uint)stringBuilder.Capacity;
		if (NativeMethods.PathCreateFromUrlW(urlPath, stringBuilder, ref pcchPath, 0u) != 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	internal static string PathCreateFromUrlAlloc(string urlPath)
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		if (urlPath == null)
		{
			return null;
		}
		if (NativeMethods.PathCreateFromUrlAlloc(urlPath, out var pszPath, 0u) != 0)
		{
			return string.Empty;
		}
		return pszPath.ToString();
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "lastError")]
	public static bool PathFileExists(string path)
	{
		if (!Utils.IsNullOrWhiteSpace(path))
		{
			return NativeMethods.PathFileExistsW(Path.GetFullPathCore(null, path, GetFullPathOptions.FullCheck | GetFullPathOptions.AsLongPath | GetFullPathOptions.ContinueOnNonExist));
		}
		return false;
	}

	[SecurityCritical]
	internal static bool UrlIs(string url, UrlType urlType)
	{
		return NativeMethods.UrlIsW(url, urlType);
	}

	[SecurityCritical]
	internal static string UrlCreateFromPath(string path)
	{
		if (path == null)
		{
			return null;
		}
		string regularPathCore = Path.GetRegularPathCore(path, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false);
		StringBuilder stringBuilder = new StringBuilder(32700);
		uint pcchUrl = (uint)stringBuilder.Capacity;
		uint num = NativeMethods.UrlCreateFromPathW(regularPathCore, stringBuilder, ref pcchUrl, 0u);
		string text = stringBuilder.ToString();
		if (Utils.IsNullOrWhiteSpace(text))
		{
			text = string.Empty;
		}
		if (num != 0)
		{
			return string.Empty;
		}
		return text;
	}

	[SecurityCritical]
	internal static bool UrlIsFileUrl(string url)
	{
		return NativeMethods.UrlIsW(url, UrlType.IsFileUrl);
	}

	[SecurityCritical]
	internal static bool UrlIsNoHistory(string url)
	{
		return NativeMethods.UrlIsW(url, UrlType.IsNoHistory);
	}

	[SecurityCritical]
	internal static bool UrlIsOpaque(string url)
	{
		return NativeMethods.UrlIsW(url, UrlType.IsOpaque);
	}

	[SecurityCritical]
	private static string GetFileAssociationCore(string path, AssociationAttributes attributes, AssociationString associationType)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		attributes = attributes | AssociationAttributes.NoTruncate | AssociationAttributes.RemapRunDll;
		uint pcchOut = 260u;
		StringBuilder stringBuilder;
		uint num;
		do
		{
			stringBuilder = new StringBuilder((int)pcchOut);
			num = NativeMethods.AssocQueryStringW(attributes, associationType, path, null, stringBuilder, out pcchOut);
		}
		while (num == 2147500035u);
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	internal static FileInfo GetFileInfoCore(string path, System.IO.FileAttributes attributes, FileAttributes fileAttributes, bool checkInvalidPathChars, bool continueOnException)
	{
		FileInfo fileInfo = default(FileInfo);
		fileInfo.DisplayName = string.Empty;
		fileInfo.TypeName = string.Empty;
		fileInfo.IconIndex = 0;
		FileInfo psfi = fileInfo;
		if (!Utils.IsNullOrWhiteSpace(path) && NativeMethods.SHGetFileInfoW(Path.GetRegularPathCore(path, checkInvalidPathChars ? GetFullPathOptions.CheckInvalidPathChars : GetFullPathOptions.None, allowEmpty: false), attributes, out psfi, (uint)Marshal.SizeOf((object)psfi), fileAttributes) == IntPtr.Zero && !continueOnException)
		{
			NativeError.ThrowException(Marshal.GetLastWin32Error(), path);
		}
		return psfi;
	}
}
