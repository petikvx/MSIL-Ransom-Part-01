using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.AccessControl;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public sealed class DirectoryInfo : FileSystemInfo
{
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public override bool Exists
	{
		[SecurityCritical]
		get
		{
			try
			{
				if (DataInitialised == -1)
				{
					Refresh();
				}
				return DataInitialised == 0 && base.IsDirectory;
			}
			catch
			{
				return false;
			}
		}
	}

	public override string Name
	{
		get
		{
			if (FullPath.Length <= 3)
			{
				return FullPath;
			}
			return Path.GetFileName(Path.RemoveTrailingDirectorySeparator(FullPath), checkInvalidPathChars: true);
		}
	}

	public DirectoryInfo Parent
	{
		[SecurityCritical]
		get
		{
			string text = FullPath;
			if (text.Length > 3)
			{
				text = Path.RemoveTrailingDirectorySeparator(FullPath);
			}
			string directoryName = Path.GetDirectoryName(text, checkInvalidPathChars: false);
			if (directoryName != null)
			{
				return new DirectoryInfo(base.Transaction, directoryName, junk1: true, junk2: true);
			}
			return null;
		}
	}

	public DirectoryInfo Root
	{
		[SecurityCritical]
		get
		{
			return new DirectoryInfo(base.Transaction, Path.GetPathRoot(FullPath, checkInvalidPathChars: false), PathFormat.RelativePath);
		}
	}

	[SecurityCritical]
	[Obsolete("Use GetFileIdInfo method.")]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public FileIdInfo GetFileId()
	{
		return File.GetFileIdInfoCore(base.Transaction, isFolder: true, base.LongFullName, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public FileIdInfo GetFileIdInfo()
	{
		return File.GetFileIdInfoCore(base.Transaction, isFolder: true, base.LongFullName, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void MoveTo(string destinationPath)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, null, MoveOptions.None, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo MoveTo(string destinationPath, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, null, MoveOptions.None, null, null, out var longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo MoveTo(string destinationPath, MoveOptions moveOptions)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, null, moveOptions, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		if (longFullPath == null)
		{
			return null;
		}
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo MoveTo(string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, null, moveOptions, null, null, out var longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		if (longFullPath == null)
		{
			return null;
		}
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public CopyMoveResult MoveTo(string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		if ((moveOptions & MoveOptions.DelayUntilReboot) != 0)
		{
			throw new ArgumentException("The DelayUntilReboot flag is invalid for this method.", "moveOptions");
		}
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, preserveDates: false, null, moveOptions, progressHandler, userProgressData, out longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public CopyMoveResult MoveTo(string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		if ((moveOptions & MoveOptions.DelayUntilReboot) != 0)
		{
			throw new ArgumentException("The DelayUntilReboot flag is invalid for this method.", "moveOptions");
		}
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, preserveDates: false, null, moveOptions, progressHandler, userProgressData, out longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public void DeleteJunction()
	{
		Directory.DeleteJunctionCore(base.Transaction, null, base.LongFullName, removeDirectory: false, PathFormat.LongFullPath);
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public void DeleteJunction(bool removeDirectory)
	{
		Directory.DeleteJunctionCore(base.Transaction, null, base.LongFullName, removeDirectory, PathFormat.LongFullPath);
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public void CreateJunction(string junctionPath)
	{
		UpdateSourcePath(junctionPath, Directory.CreateJunctionCore(base.Transaction, junctionPath, base.LongFullName, overwrite: false, copyTargetTimestamps: false, PathFormat.RelativePath));
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public void CreateJunction(string junctionPath, PathFormat pathFormat)
	{
		UpdateSourcePath(junctionPath, Directory.CreateJunctionCore(base.Transaction, junctionPath, base.LongFullName, overwrite: false, copyTargetTimestamps: false, pathFormat));
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public void CreateJunction(string junctionPath, bool overwrite)
	{
		UpdateSourcePath(junctionPath, Directory.CreateJunctionCore(base.Transaction, junctionPath, base.LongFullName, overwrite, copyTargetTimestamps: false, PathFormat.RelativePath));
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public void CreateJunction(string junctionPath, bool overwrite, PathFormat pathFormat)
	{
		UpdateSourcePath(junctionPath, Directory.CreateJunctionCore(base.Transaction, junctionPath, base.LongFullName, overwrite, copyTargetTimestamps: false, pathFormat));
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public void CreateJunction(string junctionPath, bool overwrite, bool copyTargetTimestamps)
	{
		UpdateSourcePath(junctionPath, Directory.CreateJunctionCore(base.Transaction, junctionPath, base.LongFullName, overwrite, copyTargetTimestamps, PathFormat.RelativePath));
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public void CreateJunction(string junctionPath, bool overwrite, bool copyTargetTimestamps, PathFormat pathFormat)
	{
		UpdateSourcePath(junctionPath, Directory.CreateJunctionCore(base.Transaction, junctionPath, base.LongFullName, overwrite, copyTargetTimestamps, pathFormat));
		RefreshEntryInfo();
	}

	[SecurityCritical]
	public new void RefreshEntryInfo()
	{
		base.RefreshEntryInfo();
	}

	[SecurityCritical]
	public void Decrypt()
	{
		Directory.EncryptDecryptDirectoryCore(base.LongFullName, encrypt: false, recursive: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Decrypt(bool recursive)
	{
		Directory.EncryptDecryptDirectoryCore(base.LongFullName, encrypt: false, recursive, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void DisableEncryption()
	{
		Directory.EnableDisableEncryptionCore(base.LongFullName, enable: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void EnableEncryption()
	{
		Directory.EnableDisableEncryptionCore(base.LongFullName, enable: true, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Encrypt()
	{
		Directory.EncryptDecryptDirectoryCore(base.LongFullName, encrypt: true, recursive: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Encrypt(bool recursive)
	{
		Directory.EncryptDecryptDirectoryCore(base.LongFullName, encrypt: true, recursive, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void DeleteEmptySubdirectories()
	{
		Directory.DeleteEmptySubdirectoriesCore(base.EntryInfo, base.Transaction, null, recursive: false, ignoreReadOnly: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void DeleteEmptySubdirectories(bool recursive)
	{
		Directory.DeleteEmptySubdirectoriesCore(base.EntryInfo, base.Transaction, null, recursive, ignoreReadOnly: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void DeleteEmptySubdirectories(bool recursive, bool ignoreReadOnly)
	{
		Directory.DeleteEmptySubdirectoriesCore(base.EntryInfo, base.Transaction, null, recursive, ignoreReadOnly, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Compress()
	{
		Directory.CompressDecompressCore(base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, compress: true, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Compress(DirectoryEnumerationOptions options)
	{
		Directory.CompressDecompressCore(base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, options, null, compress: true, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Decompress()
	{
		Directory.CompressDecompressCore(base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, compress: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Decompress(DirectoryEnumerationOptions options)
	{
		Directory.CompressDecompressCore(base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, options, null, compress: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void DisableCompression()
	{
		Device.ToggleCompressionCore(base.Transaction, base.LongFullName, compress: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void EnableCompression()
	{
		Device.ToggleCompressionCore(base.Transaction, base.LongFullName, compress: true, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public long CountFileSystemObjects(DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<string>(null, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, options, null, PathFormat.LongFullPath).Count();
	}

	[SecurityCritical]
	public long CountFileSystemObjects(string searchPattern, DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<string>(null, base.Transaction, base.LongFullName, searchPattern, null, options, null, PathFormat.LongFullPath).Count();
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, CopyOptions.FailIfExists, null, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, CopyOptions.FailIfExists, null, null, null, out var longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath, bool preserveDates)
	{
		CopyToMoveToCore(destinationPath, preserveDates, CopyOptions.FailIfExists, null, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath, bool preserveDates, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, preserveDates, CopyOptions.FailIfExists, null, null, null, out var longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath, CopyOptions copyOptions)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, copyOptions, null, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, preserveDates: false, copyOptions, null, null, null, out var longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates)
	{
		CopyToMoveToCore(destinationPath, preserveDates, copyOptions, null, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, preserveDates, copyOptions, null, null, null, out var longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return new DirectoryInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, preserveDates: false, copyOptions, null, progressHandler, userProgressData, out longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, preserveDates: false, copyOptions, null, progressHandler, userProgressData, out longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, preserveDates, copyOptions, null, progressHandler, userProgressData, out longFullPath, PathFormat.RelativePath);
		UpdateSourcePath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, preserveDates, copyOptions, null, progressHandler, userProgressData, out longFullPath, pathFormat);
		UpdateSourcePath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	private CopyMoveResult CopyToMoveToCore(string destinationPath, bool preserveDates, CopyOptions? copyOptions, MoveOptions? moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, out string longFullPath, PathFormat pathFormat)
	{
		longFullPath = Path.GetExtendedLengthPathCore(base.Transaction, destinationPath, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		return Directory.CopyMoveCore(base.Transaction, base.LongFullName, longFullPath, preserveDates, copyOptions, moveOptions, progressHandler, userProgressData, null, PathFormat.LongFullPath);
	}

	public override string ToString()
	{
		return base.DisplayPath;
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void SetAccessControl(DirectorySecurity directorySecurity)
	{
		File.SetAccessControlCore(base.LongFullName, null, directorySecurity, AccessControlSections.All, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void SetAccessControl(DirectorySecurity directorySecurity, AccessControlSections includeSections)
	{
		File.SetAccessControlCore(base.LongFullName, null, directorySecurity, includeSections, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public FileSystemInfo[] GetFileSystemInfos()
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, searchPattern, null, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, searchPattern, searchOption, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	public FileInfo[] GetFiles()
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	public FileInfo[] GetFiles(string searchPattern)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, searchPattern, null, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, searchPattern, searchOption, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	public DirectoryInfo[] GetDirectories()
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	public DirectoryInfo[] GetDirectories(string searchPattern)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, searchPattern, null, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, searchPattern, searchOption, null, null, PathFormat.LongFullPath).ToArray();
	}

	[SecurityCritical]
	public DirectorySecurity GetAccessControl()
	{
		return File.GetAccessControlCore<DirectorySecurity>(isFolder: true, base.LongFullName, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectorySecurity GetAccessControl(AccessControlSections includeSections)
	{
		return File.GetAccessControlCore<DirectorySecurity>(isFolder: true, base.LongFullName, includeSections, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, searchPattern, null, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, searchPattern, searchOption, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, options, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileSystemInfo>(null, base.Transaction, base.LongFullName, searchPattern, null, options, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<FileInfo> EnumerateFiles()
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, searchPattern, null, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, searchPattern, searchOption, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<FileInfo> EnumerateFiles(DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, options, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<FileInfo>(false, base.Transaction, base.LongFullName, searchPattern, null, options, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<DirectoryInfo> EnumerateDirectories()
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, searchPattern, null, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, searchPattern, searchOption, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<DirectoryInfo> EnumerateDirectories(DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, Path.WildcardStarMatchAll, null, options, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, DirectoryEnumerationOptions options)
	{
		return Directory.EnumerateFileSystemEntryInfosCore<DirectoryInfo>(true, base.Transaction, base.LongFullName, searchPattern, null, options, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public override void Delete()
	{
		Directory.DeleteDirectoryCore(base.Transaction, base.EntryInfo, null, recursive: false, ignoreReadOnly: false, continueOnNotFound: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Delete(bool recursive)
	{
		Directory.DeleteDirectoryCore(base.Transaction, base.EntryInfo, null, recursive, ignoreReadOnly: false, continueOnNotFound: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Delete(bool recursive, bool ignoreReadOnly)
	{
		Directory.DeleteDirectoryCore(base.Transaction, base.EntryInfo, null, recursive, ignoreReadOnly, continueOnNotFound: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Delete(bool recursive, bool ignoreReadOnly, bool continueOnNotFound)
	{
		Directory.DeleteDirectoryCore(base.Transaction, base.EntryInfo, null, recursive, ignoreReadOnly, continueOnNotFound, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public DirectoryInfo CreateSubdirectory(string path)
	{
		return CreateSubdirectoryCore(path, null, null, compress: false);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public DirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity)
	{
		return CreateSubdirectoryCore(path, null, directorySecurity, compress: false);
	}

	[SecurityCritical]
	public DirectoryInfo CreateSubdirectory(string path, bool compress)
	{
		return CreateSubdirectoryCore(path, null, null, compress);
	}

	[SecurityCritical]
	public DirectoryInfo CreateSubdirectory(string path, string templatePath, bool compress)
	{
		return CreateSubdirectoryCore(path, templatePath, null, compress);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public DirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity, bool compress)
	{
		return CreateSubdirectoryCore(path, null, directorySecurity, compress);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public DirectoryInfo CreateSubdirectory(string path, string templatePath, DirectorySecurity directorySecurity, bool compress)
	{
		return CreateSubdirectoryCore(path, templatePath, directorySecurity, compress);
	}

	[SecurityCritical]
	private DirectoryInfo CreateSubdirectoryCore(string path, string templatePath, ObjectSecurity directorySecurity, bool compress)
	{
		string text = Path.CombineCore(false, base.LongFullName, path);
		string templatePath2 = ((templatePath == null) ? null : Path.GetExtendedLengthPathCore(base.Transaction, templatePath, PathFormat.RelativePath, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator));
		if (string.Compare(base.LongFullName, 0, text, 0, base.LongFullName.Length, StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new ArgumentException(Resources.Invalid_Subpath, "path");
		}
		return Directory.CreateDirectoryCore(base.Transaction, text, templatePath2, directorySecurity, compress, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Create()
	{
		Directory.CreateDirectoryCore(base.Transaction, base.LongFullName, null, null, compress: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void Create(DirectorySecurity directorySecurity)
	{
		Directory.CreateDirectoryCore(base.Transaction, base.LongFullName, null, directorySecurity, compress: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void Create(bool compress)
	{
		Directory.CreateDirectoryCore(base.Transaction, base.LongFullName, null, null, compress, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void Create(DirectorySecurity directorySecurity, bool compress)
	{
		Directory.CreateDirectoryCore(base.Transaction, base.LongFullName, null, directorySecurity, compress, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreams()
	{
		return File.EnumerateAlternateDataStreamsCore(base.Transaction, isFolder: true, base.LongFullName, PathFormat.LongFullPath);
	}

	public DirectoryInfo(string path)
		: this(null, path, PathFormat.RelativePath)
	{
	}

	public DirectoryInfo(string path, PathFormat pathFormat)
		: this(null, path, pathFormat)
	{
	}

	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "junk2")]
	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "junk1")]
	private DirectoryInfo(KernelTransaction transaction, string fullPath, bool junk1, bool junk2)
	{
		base.IsDirectory = true;
		base.Transaction = transaction;
		base.LongFullName = Path.GetLongPathCore(fullPath, GetFullPathOptions.None);
		OriginalPath = Path.GetFileName(fullPath, checkInvalidPathChars: true);
		FullPath = fullPath;
		base.DisplayPath = ((OriginalPath.Length != 2 || OriginalPath[1] != Path.VolumeSeparatorChar) ? OriginalPath : Path.CurrentDirectoryPrefix);
	}

	public DirectoryInfo(KernelTransaction transaction, string path)
		: this(transaction, path, PathFormat.RelativePath)
	{
	}

	public DirectoryInfo(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		InitializeCore(transaction, isFolder: true, path, pathFormat);
	}
}
