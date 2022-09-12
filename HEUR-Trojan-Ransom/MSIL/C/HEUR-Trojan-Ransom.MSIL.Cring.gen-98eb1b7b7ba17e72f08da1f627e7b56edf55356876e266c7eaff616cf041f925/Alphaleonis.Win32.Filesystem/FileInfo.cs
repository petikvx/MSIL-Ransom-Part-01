using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using Alphaleonis.Win32.Security;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public sealed class FileInfo : FileSystemInfo
{
	private string _name;

	public DirectoryInfo Directory
	{
		get
		{
			string directoryName = DirectoryName;
			if (directoryName != null)
			{
				return new DirectoryInfo(base.Transaction, directoryName, PathFormat.FullPath);
			}
			return null;
		}
	}

	public string DirectoryName
	{
		[SecurityCritical]
		get
		{
			return Path.GetDirectoryName(FullPath, checkInvalidPathChars: false);
		}
	}

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
				FileAttributes dwFileAttributes = Win32AttributeData.dwFileAttributes;
				return DataInitialised == 0 && File.HasValidAttributes(dwFileAttributes) && !base.IsDirectory;
			}
			catch
			{
				return false;
			}
		}
	}

	public bool IsReadOnly
	{
		get
		{
			if (base.EntryInfo != null)
			{
				return base.EntryInfo.IsReadOnly;
			}
			return true;
		}
		set
		{
			if (value)
			{
				base.Attributes |= FileAttributes.ReadOnly;
			}
			else
			{
				base.Attributes &= ~FileAttributes.ReadOnly;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations")]
	public long Length
	{
		[SecurityCritical]
		get
		{
			if (DataInitialised == -1)
			{
				Win32AttributeData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				Refresh();
			}
			if (DataInitialised != 0)
			{
				NativeError.ThrowException(DataInitialised, FullName);
			}
			FileAttributes dwFileAttributes = Win32AttributeData.dwFileAttributes;
			if (!File.HasValidAttributes(dwFileAttributes))
			{
				NativeError.ThrowException(2u, FullName);
			}
			if (File.IsDirectory(dwFileAttributes))
			{
				NativeError.ThrowException(2u, string.Format(CultureInfo.InvariantCulture, Resources.Target_File_Is_A_Directory, new object[1] { FullName }));
			}
			return Win32AttributeData.FileSize;
		}
	}

	public override string Name => _name;

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[Obsolete("Use GetFileIdInfo method.")]
	[SecurityCritical]
	public FileIdInfo GetFileId()
	{
		return File.GetFileIdInfoCore(base.Transaction, isFolder: false, base.LongFullName, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public FileIdInfo GetFileIdInfo()
	{
		return File.GetFileIdInfoCore(base.Transaction, isFolder: false, base.LongFullName, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public bool IsLocked()
	{
		return File.IsLockedCore(base.Transaction, base.LongFullName, PathFormat.LongFullPath);
	}

	public string GetHash(HashType hashType)
	{
		return File.GetHashCore(base.Transaction, base.LongFullName, hashType, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public new void RefreshEntryInfo()
	{
		base.RefreshEntryInfo();
	}

	[SecurityCritical]
	public IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreams()
	{
		return File.EnumerateAlternateDataStreamsCore(base.Transaction, isFolder: false, base.LongFullName, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Decompress()
	{
		Device.ToggleCompressionCore(base.Transaction, base.LongFullName, compress: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Compress()
	{
		Device.ToggleCompressionCore(base.Transaction, base.LongFullName, compress: true, PathFormat.LongFullPath);
	}

	public override string ToString()
	{
		return base.DisplayPath;
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void SetAccessControl(FileSecurity fileSecurity)
	{
		File.SetAccessControlCore(base.LongFullName, null, fileSecurity, AccessControlSections.All, PathFormat.LongFullPath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public void SetAccessControl(FileSecurity fileSecurity, AccessControlSections includeSections)
	{
		File.SetAccessControlCore(base.LongFullName, null, fileSecurity, includeSections, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName)
	{
		return Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
	{
		return Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName, PathFormat pathFormat)
	{
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(base.Transaction, destinationFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		string destinationBackupFileName2 = ((destinationBackupFileName != null) ? Path.GetExtendedLengthPathCore(base.Transaction, destinationBackupFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator) : null);
		File.ReplaceCore(base.LongFullName, extendedLengthPathCore, destinationBackupFileName2, ignoreMetadataErrors: false, PathFormat.LongFullPath);
		return new FileInfo(base.Transaction, extendedLengthPathCore, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors, PathFormat pathFormat)
	{
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(base.Transaction, destinationFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		string destinationBackupFileName2 = ((destinationBackupFileName != null) ? Path.GetExtendedLengthPathCore(base.Transaction, destinationBackupFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator) : null);
		File.ReplaceCore(base.LongFullName, extendedLengthPathCore, destinationBackupFileName2, ignoreMetadataErrors, PathFormat.LongFullPath);
		return new FileInfo(base.Transaction, extendedLengthPathCore, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileStream OpenWrite()
	{
		return File.OpenCore(base.Transaction, base.LongFullName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SecurityCritical]
	public StreamReader OpenText()
	{
		return new StreamReader(File.OpenCore(base.Transaction, base.LongFullName, FileMode.Open, FileAccess.Read, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath), NativeMethods.DefaultFileEncoding);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public StreamReader OpenText(Encoding encoding)
	{
		return new StreamReader(File.OpenCore(base.Transaction, base.LongFullName, FileMode.Open, FileAccess.Read, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath), encoding);
	}

	[SecurityCritical]
	public FileStream OpenRead()
	{
		return File.OpenCore(base.Transaction, base.LongFullName, FileMode.Open, FileAccess.Read, FileShare.Read, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileStream Open(FileMode mode)
	{
		return File.OpenCore(base.Transaction, base.LongFullName, mode, FileAccess.Read, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileStream Open(FileMode mode, FileAccess access)
	{
		return File.OpenCore(base.Transaction, base.LongFullName, mode, access, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileStream Open(FileMode mode, FileAccess access, FileShare share)
	{
		return File.OpenCore(base.Transaction, base.LongFullName, mode, access, share, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileStream Open(FileMode mode, FileSystemRights rights)
	{
		return File.OpenCore(base.Transaction, base.LongFullName, mode, rights, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileStream Open(FileMode mode, FileSystemRights rights, FileShare share)
	{
		return File.OpenCore(base.Transaction, base.LongFullName, mode, rights, share, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileSecurity GetAccessControl()
	{
		return File.GetAccessControlCore<FileSecurity>(isFolder: false, base.LongFullName, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileSecurity GetAccessControl(AccessControlSections includeSections)
	{
		return File.GetAccessControlCore<FileSecurity>(isFolder: false, base.LongFullName, includeSections, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Encrypt()
	{
		File.EncryptDecryptFileCore(isFolder: false, base.LongFullName, encrypt: true, PathFormat.LongFullPath);
	}

	public override void Delete()
	{
		File.DeleteFileCore(base.Transaction, base.LongFullName, ignoreReadOnly: false, PathFormat.LongFullPath);
	}

	public void Delete(bool ignoreReadOnly)
	{
		File.DeleteFileCore(base.Transaction, base.LongFullName, ignoreReadOnly, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public void Decrypt()
	{
		File.EncryptDecryptFileCore(isFolder: false, base.LongFullName, encrypt: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public StreamWriter CreateText()
	{
		return new StreamWriter(File.CreateFileStreamCore(base.Transaction, base.LongFullName, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, PathFormat.LongFullPath), NativeMethods.DefaultFileEncoding);
	}

	[SecurityCritical]
	public FileStream Create()
	{
		return File.CreateFileStreamCore(base.Transaction, base.LongFullName, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath)
	{
		CopyToMoveToCore(destinationPath, CopyOptions.FailIfExists, null, preserveDates: false, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath, bool overwrite)
	{
		CopyToMoveToCore(destinationPath, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, preserveDates: false, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, CopyOptions.FailIfExists, null, preserveDates: false, null, null, out var longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath, bool overwrite, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, preserveDates: false, null, null, out var longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath, CopyOptions copyOptions)
	{
		CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates: false, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates: false, null, null, out var longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates)
	{
		CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates, null, null, out var longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates: false, progressHandler, userProgressData, out longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates: false, progressHandler, userProgressData, out longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates, progressHandler, userProgressData, out longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public CopyMoveResult CopyTo(string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, copyOptions, null, preserveDates, progressHandler, userProgressData, out longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	public void MoveTo(string destinationPath)
	{
		CopyToMoveToCore(destinationPath, null, MoveOptions.CopyAllowed, preserveDates: false, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
	}

	[SecurityCritical]
	public FileInfo MoveTo(string destinationPath, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, null, MoveOptions.CopyAllowed, preserveDates: false, null, null, out var longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo MoveTo(string destinationPath, MoveOptions moveOptions)
	{
		CopyToMoveToCore(destinationPath, null, moveOptions, preserveDates: false, null, null, out var longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
		if (longFullPath == null)
		{
			return null;
		}
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public FileInfo MoveTo(string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
	{
		CopyToMoveToCore(destinationPath, null, moveOptions, preserveDates: false, null, null, out var longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		if (longFullPath == null)
		{
			return null;
		}
		return new FileInfo(base.Transaction, longFullPath, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public CopyMoveResult MoveTo(string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		if ((moveOptions & MoveOptions.DelayUntilReboot) != 0)
		{
			throw new ArgumentException("The DelayUntilReboot flag is invalid for this method.", "moveOptions");
		}
		string longFullPath;
		CopyMoveResult result = CopyToMoveToCore(destinationPath, null, moveOptions, preserveDates: false, progressHandler, userProgressData, out longFullPath, PathFormat.RelativePath);
		UpdateDestinationPath(destinationPath, longFullPath);
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
		CopyMoveResult result = CopyToMoveToCore(destinationPath, null, moveOptions, preserveDates: false, progressHandler, userProgressData, out longFullPath, pathFormat);
		UpdateDestinationPath(destinationPath, longFullPath);
		return result;
	}

	[SecurityCritical]
	private CopyMoveResult CopyToMoveToCore(string destinationPath, CopyOptions? copyOptions, MoveOptions? moveOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, out string longFullPath, PathFormat pathFormat)
	{
		longFullPath = Path.GetExtendedLengthPathCore(base.Transaction, destinationPath, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		return File.CopyMoveCore(base.Transaction, driveChecked: false, isFolder: false, base.LongFullName, longFullPath, copyOptions, moveOptions, preserveDates, progressHandler, userProgressData, null, PathFormat.LongFullPath);
	}

	private void UpdateDestinationPath(string destinationPath, string destinationPathLp)
	{
		_name = Path.GetFileName(destinationPathLp, checkInvalidPathChars: true);
		UpdateSourcePath(destinationPath, destinationPathLp);
	}

	[SecurityCritical]
	public StreamWriter AppendText()
	{
		return File.AppendTextCore(base.Transaction, base.LongFullName, NativeMethods.DefaultFileEncoding, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public StreamWriter AppendText(Encoding encoding)
	{
		return File.AppendTextCore(base.Transaction, base.LongFullName, encoding, PathFormat.LongFullPath);
	}

	public FileInfo(string fileName)
		: this(null, fileName, PathFormat.RelativePath)
	{
	}

	public FileInfo(string fileName, PathFormat pathFormat)
		: this(null, fileName, pathFormat)
	{
	}

	public FileInfo(KernelTransaction transaction, string fileName)
		: this(transaction, fileName, PathFormat.RelativePath)
	{
	}

	public FileInfo(KernelTransaction transaction, string fileName, PathFormat pathFormat)
	{
		InitializeCore(transaction, isFolder: false, fileName, pathFormat);
		_name = Path.GetFileName(Path.RemoveTrailingDirectorySeparator(fileName), pathFormat != PathFormat.LongFullPath);
	}
}
