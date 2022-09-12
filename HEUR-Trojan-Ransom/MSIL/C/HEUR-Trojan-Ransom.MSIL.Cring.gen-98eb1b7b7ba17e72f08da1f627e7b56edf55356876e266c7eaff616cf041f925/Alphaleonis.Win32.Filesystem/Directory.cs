using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using Alphaleonis.Win32.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public static class Directory
{
	public static bool ExistsDrive(string path)
	{
		return ExistsDriveOrFolderOrFile(null, path, isFolder: false, 0, throwIfDriveNotExists: false, throwIfFolderOrFileNotExists: false);
	}

	public static bool ExistsDrive(KernelTransaction transaction, string path)
	{
		return ExistsDriveOrFolderOrFile(transaction, path, isFolder: false, 0, throwIfDriveNotExists: false, throwIfFolderOrFileNotExists: false);
	}

	[Obsolete("This function will be removed.")]
	public static bool ExistsDrive(KernelTransaction transaction, string path, bool throwIfDriveNotExists)
	{
		return ExistsDriveOrFolderOrFile(transaction, path, isFolder: false, 0, throwIfDriveNotExists, throwIfFolderOrFileNotExists: false);
	}

	internal static bool ExistsDriveOrFolderOrFile(KernelTransaction transaction, string path, bool isFolder, int lastError, bool throwIfDriveNotExists, bool throwIfFolderOrFileNotExists)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			return false;
		}
		string directoryRootCore = GetDirectoryRootCore(transaction, path, PathFormat.FullPath);
		bool num = directoryRootCore != null && File.ExistsCore(transaction, isFolder: true, directoryRootCore, PathFormat.FullPath);
		string cleanExceptionPath = Path.GetCleanExceptionPath(path);
		if (!(!num && throwIfDriveNotExists) && lastError != 21L)
		{
			throwIfFolderOrFileNotExists = throwIfFolderOrFileNotExists && (ulong)lastError > 0uL;
			if (throwIfFolderOrFileNotExists && lastError != 0L)
			{
				if (lastError == 3L)
				{
					throw new DirectoryNotFoundException(cleanExceptionPath);
				}
				if (lastError == 2L)
				{
					if (isFolder)
					{
						throw new DirectoryNotFoundException(cleanExceptionPath);
					}
					throw new FileNotFoundException(cleanExceptionPath);
				}
			}
			return num;
		}
		throw new DeviceNotReadyException(directoryRootCore, isPath: true);
	}

	[Obsolete("Use GetFileIdInfoTransacted method.")]
	[SecurityCritical]
	public static FileIdInfo GetFileIdTransacted(KernelTransaction transaction, string path)
	{
		return File.GetFileIdInfoCore(transaction, isFolder: true, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Use GetFileIdInfoTransacted method.")]
	public static FileIdInfo GetFileIdTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetFileIdInfoCore(transaction, isFolder: true, path, pathFormat);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfo(string path)
	{
		return File.GetFileIdInfoCore(null, isFolder: true, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfo(string path, PathFormat pathFormat)
	{
		return File.GetFileIdInfoCore(null, isFolder: true, path, pathFormat);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfoTransacted(KernelTransaction transaction, string path)
	{
		return File.GetFileIdInfoCore(transaction, isFolder: true, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfoTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetFileIdInfoCore(transaction, isFolder: true, path, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<DriveInfo> EnumerateLogicalDrives()
	{
		return EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: true);
	}

	[SecurityCritical]
	public static IEnumerable<DriveInfo> EnumerateLogicalDrives(bool fromEnvironment, bool isReady)
	{
		return EnumerateLogicalDrivesCore(fromEnvironment, isReady);
	}

	[SecurityCritical]
	internal static IEnumerable<DriveInfo> EnumerateLogicalDrivesCore(bool fromEnvironment, bool isReady)
	{
		if (fromEnvironment)
		{
			IEnumerable<string> enumerable = (isReady ? (from ld in Environment.GetLogicalDrives()
				where File.ExistsCore(null, isFolder: true, ld, PathFormat.FullPath)
				select ld) : (from ld in Environment.GetLogicalDrives()
				select (ld)));
			foreach (string item in enumerable)
			{
				if (isReady)
				{
					if (File.ExistsCore(null, isFolder: true, item, PathFormat.FullPath))
					{
						yield return new DriveInfo(item);
					}
				}
				else
				{
					yield return new DriveInfo(item);
				}
			}
			yield break;
		}
		uint logicalDrives = NativeMethods.GetLogicalDrives();
		if (logicalDrives == 0)
		{
			NativeError.ThrowException(logicalDrives);
		}
		uint drives = logicalDrives;
		int count2 = 0;
		while (drives != 0)
		{
			if ((drives & (true ? 1u : 0u)) != 0)
			{
				int num = count2 + 1;
				count2 = num;
			}
			drives >>= 1;
		}
		string[] result = new string[count2];
		char[] root = new char[2]
		{
			'A',
			Path.VolumeSeparatorChar
		};
		drives = logicalDrives;
		count2 = 0;
		while (drives != 0)
		{
			if ((drives & (true ? 1u : 0u)) != 0)
			{
				string drive = new string(root);
				if (isReady)
				{
					if (File.ExistsCore(null, isFolder: true, drive, PathFormat.FullPath))
					{
						yield return new DriveInfo(drive);
					}
				}
				else
				{
					yield return new DriveInfo(drive);
				}
				result[count2++] = drive;
			}
			drives >>= 1;
			root[0] += '\u0001';
		}
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandle(string path)
	{
		return File.GetFileInfoByHandleCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandle(string path, PathFormat pathFormat)
	{
		return File.GetFileInfoByHandleCore(null, path, pathFormat);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandleTransacted(KernelTransaction transaction, string path)
	{
		return File.GetFileInfoByHandleCore(transaction, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandleTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetFileInfoByHandleCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandle(SafeFileHandle handle)
	{
		return File.GetFileInfoByHandle(handle);
	}

	[SecurityCritical]
	public static void Move(string sourcePath, string destinationPath)
	{
		CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, null, MoveOptions.None, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, null, MoveOptions.None, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, null, MoveOptions.None, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, null, MoveOptions.None, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, null, moveOptions, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, null, moveOptions, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, null, moveOptions, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, null, moveOptions, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, null, moveOptions, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, null, moveOptions, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, null, moveOptions, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, null, moveOptions, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static void EnableCompression(string path)
	{
		Device.ToggleCompressionCore(null, path, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void EnableCompression(string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(null, path, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void EnableCompressionTransacted(KernelTransaction transaction, string path)
	{
		Device.ToggleCompressionCore(transaction, path, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void EnableCompressionTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(transaction, path, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void DisableCompression(string path)
	{
		Device.ToggleCompressionCore(null, path, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DisableCompression(string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(null, path, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void DisableCompressionTransacted(KernelTransaction transaction, string path)
	{
		Device.ToggleCompressionCore(transaction, path, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DisableCompressionTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(transaction, path, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void Decompress(string path)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, null, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Decompress(string path, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, null, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void Decompress(string path, DirectoryEnumerationOptions options)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, null, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Decompress(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, null, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void Decompress(string path, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, filters, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Decompress(string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, filters, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void Decompress(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, filters, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Decompress(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, filters, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, null, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, null, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, null, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, null, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, filters, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, filters, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, filters, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, filters, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, CopyOptions.FailIfExists, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, CopyOptions.FailIfExists, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, bool overwrite)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, bool overwrite, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, CopyOptions.FailIfExists, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, CopyOptions.FailIfExists, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool overwrite)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool overwrite, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, copyOptions, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, copyOptions, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates, copyOptions, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates, copyOptions, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, copyOptions, null, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates: false, copyOptions, null, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates, copyOptions, null, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(null, sourcePath, destinationPath, preserveDates, copyOptions, null, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, copyOptions, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, copyOptions, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates, copyOptions, null, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates, copyOptions, null, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, copyOptions, null, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates: false, copyOptions, null, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates, copyOptions, null, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, sourcePath, destinationPath, preserveDates, copyOptions, null, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	internal static CopyMoveResult CopyMoveCore(KernelTransaction transaction, string sourcePath, string destinationPath, bool preserveDates, CopyOptions? copyOptions, MoveOptions? moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, CopyMoveResult copyMoveResult, PathFormat pathFormat)
	{
		File.ValidateAndUpdatePathsAndOptions(transaction, sourcePath, destinationPath, copyOptions, moveOptions, pathFormat, out var sourcePathLp, out var destinationPathLp, out var isCopy, out var emulateMove, out var delayUntilReboot, out var deleteOnStartup);
		bool flag = File.ExistsCore(transaction, isFolder: false, sourcePath, PathFormat.LongFullPath);
		if (!sourcePathLp.StartsWith(Path.GlobalRootPrefix, StringComparison.OrdinalIgnoreCase))
		{
			ExistsDriveOrFolderOrFile(transaction, sourcePathLp, !flag, 0, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: false);
		}
		if (!delayUntilReboot)
		{
			ExistsDriveOrFolderOrFile(transaction, destinationPathLp, !flag, 0, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: false);
		}
		if (!isCopy && !deleteOnStartup)
		{
			ValidateAndUpdateCopyMoveAction(sourcePathLp, destinationPathLp, copyOptions, moveOptions, out copyOptions, out moveOptions, out isCopy, out emulateMove);
		}
		pathFormat = PathFormat.LongFullPath;
		CopyMoveResult copyMoveResult2 = copyMoveResult ?? new CopyMoveResult(sourcePath, destinationPath, isCopy, !flag, preserveDates, emulateMove);
		if (isCopy)
		{
			if (File.HasCopySymbolicLink(copyOptions))
			{
				LinkTargetInfo linkTargetInfoCore = File.GetLinkTargetInfoCore(transaction, sourcePathLp, continueOnException: true, pathFormat);
				if (linkTargetInfoCore != null)
				{
					File.CreateSymbolicLinkCore(transaction, destinationPathLp, linkTargetInfoCore.SubstituteName, SymbolicLinkTarget.Directory, pathFormat);
					copyMoveResult2.TotalFolders = 1L;
				}
			}
			else
			{
				copyMoveResult2 = (flag ? File.CopyMoveCore(transaction, driveChecked: true, isFolder: false, sourcePathLp, destinationPathLp, copyOptions, null, preserveDates, progressHandler, userProgressData, copyMoveResult2, PathFormat.LongFullPath) : CopyDeleteDirectoryCore(transaction, sourcePathLp, destinationPathLp, preserveDates, emulateMove, copyOptions, progressHandler, userProgressData, copyMoveResult2));
			}
		}
		else
		{
			if (!flag && !delayUntilReboot && File.CanOverwrite(moveOptions))
			{
				DeleteDirectoryCore(transaction, null, destinationPathLp, recursive: true, ignoreReadOnly: true, continueOnNotFound: true, pathFormat);
			}
			copyMoveResult2 = File.CopyMoveCore(transaction, driveChecked: true, !flag, sourcePathLp, destinationPathLp, copyOptions, moveOptions, preserveDates, progressHandler, userProgressData, copyMoveResult2, pathFormat);
			if (copyMoveResult2.ErrorCode == 0L)
			{
				copyMoveResult2.TotalFolders = 1L;
			}
		}
		copyMoveResult2._stopwatch.Stop();
		return copyMoveResult2;
	}

	private static CopyMoveResult CopyDeleteDirectoryCore(KernelTransaction transaction, string sourcePathLp, string destinationPathLp, bool preserveDates, bool emulateMove, CopyOptions? copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, CopyMoveResult copyMoveResult)
	{
		CopyMoveResult copyMoveResult2 = copyMoveResult ?? new CopyMoveResult(sourcePathLp, destinationPathLp, isCopy: true, isFolder: true, preserveDates, emulateMove);
		Queue<string> queue = new Queue<string>(4096);
		queue.Enqueue(sourcePathLp);
		while (queue.Count > 0)
		{
			string text = queue.Dequeue();
			string text2 = text.ReplaceIgnoreCase(sourcePathLp, destinationPathLp);
			foreach (FileSystemEntryInfo item in EnumerateFileSystemEntryInfosCore<FileSystemEntryInfo>(null, transaction, text, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath))
			{
				string longFullPath = item.LongFullPath;
				string text3 = Path.CombineCore(false, text2, item.FileName);
				if (item.IsDirectory)
				{
					CreateDirectoryCore(transaction, text3, null, null, compress: false, PathFormat.LongFullPath);
					copyMoveResult2.TotalFolders++;
					queue.Enqueue(longFullPath);
					continue;
				}
				DirectoryInfo parentCore = GetParentCore(transaction, text3, PathFormat.LongFullPath);
				if (null != parentCore)
				{
					string longPathCore = Path.GetLongPathCore(parentCore.FullName, GetFullPathOptions.None);
					CreateDirectoryCore(transaction, longPathCore, null, null, compress: false, PathFormat.LongFullPath);
				}
				copyMoveResult2 = File.CopyMoveCore(transaction, driveChecked: true, isFolder: false, longFullPath, text3, copyOptions, null, preserveDates, progressHandler, userProgressData, copyMoveResult2, PathFormat.LongFullPath);
				if (!copyMoveResult2.IsCanceled)
				{
					if (copyMoveResult2.ErrorCode == 0L)
					{
						copyMoveResult2.TotalBytes += item.FileSize;
						if (emulateMove)
						{
							File.DeleteFileCore(transaction, longFullPath, ignoreReadOnly: true, PathFormat.LongFullPath);
						}
					}
					continue;
				}
				queue.Clear();
				break;
			}
		}
		if (copyMoveResult2.ErrorCode == 0L)
		{
			if (preserveDates)
			{
				string text4 = sourcePathLp.ReplaceIgnoreCase(sourcePathLp, destinationPathLp);
				foreach (FileSystemEntryInfo item2 in EnumerateFileSystemEntryInfosCore<FileSystemEntryInfo>(true, transaction, sourcePathLp, Path.WildcardStarMatchAll, null, null, null, PathFormat.LongFullPath))
				{
					File.CopyTimestampsCore(transaction, isFolder: true, item2.LongFullPath, Path.CombineCore(false, text4, item2.FileName), modifyReparsePoint: false, PathFormat.LongFullPath);
				}
			}
			if (emulateMove)
			{
				DeleteDirectoryCore(transaction, null, sourcePathLp, recursive: true, ignoreReadOnly: true, continueOnNotFound: true, PathFormat.LongFullPath);
			}
		}
		return copyMoveResult2;
	}

	private static void ValidateAndUpdateCopyMoveAction(string sourcePathLp, string destinationPathLp, CopyOptions? copyOptions, MoveOptions? moveOptions, out CopyOptions? newCopyOptions, out MoveOptions? newMoveOptions, out bool isCopy, out bool emulateMove)
	{
		emulateMove = false;
		isCopy = false;
		bool flag2;
		bool flag;
		bool flag3;
		if (!(flag3 = (flag2 = (flag = Path.GetPathRoot(sourcePathLp, checkInvalidPathChars: false).Equals(Path.GetPathRoot(destinationPathLp, checkInvalidPathChars: false), StringComparison.OrdinalIgnoreCase)) || Volume.IsSameVolume(sourcePathLp, destinationPathLp)) && flag) && !(flag3 = File.AllowEmulate(moveOptions)))
		{
			NativeError.ThrowException(17u, sourcePathLp, destinationPathLp);
		}
		if (flag3)
		{
			flag3 = Path.IsUncPathCore(sourcePathLp, isRegularPath: false, checkInvalidPathChars: false) == Path.IsUncPathCore(destinationPathLp, isRegularPath: false, checkInvalidPathChars: false);
		}
		if (!(flag3 = flag3 && flag2 && flag))
		{
			moveOptions = null;
			emulateMove = true;
			isCopy = true;
			copyOptions = CopyOptions.None;
		}
		newCopyOptions = copyOptions;
		newMoveOptions = moveOptions;
	}

	[SecurityCritical]
	public static long CountFileSystemObjects(string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath).Count();
	}

	[SecurityCritical]
	public static long CountFileSystemObjects(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, options, null, pathFormat).Count();
	}

	[SecurityCritical]
	public static long CountFileSystemObjects(string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, options, null, PathFormat.RelativePath).Count();
	}

	[SecurityCritical]
	public static long CountFileSystemObjects(string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, options, null, pathFormat).Count();
	}

	[SecurityCritical]
	public static long CountFileSystemObjectsTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath).Count();
	}

	[SecurityCritical]
	public static long CountFileSystemObjectsTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, options, null, pathFormat).Count();
	}

	[SecurityCritical]
	public static long CountFileSystemObjectsTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, options, null, PathFormat.RelativePath).Count();
	}

	[SecurityCritical]
	public static long CountFileSystemObjectsTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, options, null, pathFormat).Count();
	}

	public static bool ExistsJunction(string junctionPath)
	{
		return ExistsJunctionCore(null, null, junctionPath, PathFormat.RelativePath);
	}

	public static bool ExistsJunction(string junctionPath, PathFormat pathFormat)
	{
		return ExistsJunctionCore(null, null, junctionPath, pathFormat);
	}

	public static bool ExistsJunction(KernelTransaction transaction, string junctionPath)
	{
		return ExistsJunctionCore(transaction, null, junctionPath, PathFormat.RelativePath);
	}

	public static bool ExistsJunction(KernelTransaction transaction, string junctionPath, PathFormat pathFormat)
	{
		return ExistsJunctionCore(transaction, null, junctionPath, pathFormat);
	}

	[SecurityCritical]
	internal static bool ExistsJunctionCore(KernelTransaction transaction, FileSystemEntryInfo fsEntryInfo, string junctionPath, PathFormat pathFormat)
	{
		if (fsEntryInfo == null)
		{
			if (pathFormat != PathFormat.LongFullPath)
			{
				Path.CheckSupportedPathFormat(junctionPath, checkInvalidPathChars: true, checkAdditional: true);
				junctionPath = Path.GetExtendedLengthPathCore(transaction, junctionPath, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars);
				pathFormat = PathFormat.LongFullPath;
			}
			fsEntryInfo = File.GetFileSystemEntryInfoCore(transaction, isFolder: true, junctionPath, continueOnException: true, pathFormat);
		}
		return fsEntryInfo?.IsMountPoint ?? false;
	}

	public static void DeleteJunction(string junctionPath)
	{
		DeleteJunctionCore(null, null, junctionPath, removeDirectory: false, PathFormat.RelativePath);
	}

	public static void DeleteJunction(string junctionPath, PathFormat pathFormat)
	{
		DeleteJunctionCore(null, null, junctionPath, removeDirectory: false, pathFormat);
	}

	public static void DeleteJunction(string junctionPath, bool removeDirectory)
	{
		DeleteJunctionCore(null, null, junctionPath, removeDirectory, PathFormat.RelativePath);
	}

	public static void DeleteJunction(string junctionPath, bool removeDirectory, PathFormat pathFormat)
	{
		DeleteJunctionCore(null, null, junctionPath, removeDirectory, pathFormat);
	}

	public static void DeleteJunction(KernelTransaction transaction, string junctionPath)
	{
		DeleteJunctionCore(transaction, null, junctionPath, removeDirectory: false, PathFormat.RelativePath);
	}

	public static void DeleteJunction(KernelTransaction transaction, string junctionPath, PathFormat pathFormat)
	{
		DeleteJunctionCore(transaction, null, junctionPath, removeDirectory: false, pathFormat);
	}

	public static void DeleteJunction(KernelTransaction transaction, string junctionPath, bool removeDirectory)
	{
		DeleteJunctionCore(transaction, null, junctionPath, removeDirectory, PathFormat.RelativePath);
	}

	public static void DeleteJunction(KernelTransaction transaction, string junctionPath, bool removeDirectory, PathFormat pathFormat)
	{
		DeleteJunctionCore(transaction, null, junctionPath, removeDirectory, pathFormat);
	}

	[SecurityCritical]
	internal static void DeleteJunctionCore(KernelTransaction transaction, FileSystemEntryInfo fsEntryInfo, string junctionPath, bool removeDirectory, PathFormat pathFormat)
	{
		if (fsEntryInfo == null)
		{
			if (pathFormat != PathFormat.LongFullPath)
			{
				Path.CheckSupportedPathFormat(junctionPath, checkInvalidPathChars: true, checkAdditional: true);
				junctionPath = Path.GetExtendedLengthPathCore(transaction, junctionPath, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars);
				pathFormat = PathFormat.LongFullPath;
			}
			fsEntryInfo = File.GetFileSystemEntryInfoCore(transaction, isFolder: true, junctionPath, continueOnException: false, pathFormat);
			if (!fsEntryInfo.IsMountPoint)
			{
				throw new NotAReparsePointException(string.Format(CultureInfo.InvariantCulture, Resources.Directory_Is_Not_A_MountPoint, new object[1] { fsEntryInfo.LongFullPath }), 4390);
			}
		}
		pathFormat = PathFormat.LongFullPath;
		using (SafeFileHandle safeHandle = OpenDirectoryJunction(transaction, fsEntryInfo.LongFullPath, PathFormat.LongFullPath))
		{
			Device.DeleteDirectoryJunction(safeHandle);
		}
		if (removeDirectory)
		{
			DeleteDirectoryCore(transaction, fsEntryInfo, null, recursive: false, ignoreReadOnly: false, continueOnNotFound: true, pathFormat);
		}
	}

	[SecurityCritical]
	public static void CreateJunction(string junctionPath, string directoryPath)
	{
		CreateJunctionCore(null, junctionPath, directoryPath, overwrite: false, copyTargetTimestamps: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CreateJunction(string junctionPath, string directoryPath, PathFormat pathFormat)
	{
		CreateJunctionCore(null, junctionPath, directoryPath, overwrite: false, copyTargetTimestamps: false, pathFormat);
	}

	[SecurityCritical]
	public static void CreateJunction(string junctionPath, string directoryPath, bool overwrite)
	{
		CreateJunctionCore(null, junctionPath, directoryPath, overwrite, copyTargetTimestamps: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CreateJunction(string junctionPath, string directoryPath, bool overwrite, PathFormat pathFormat)
	{
		CreateJunctionCore(null, junctionPath, directoryPath, overwrite, copyTargetTimestamps: false, pathFormat);
	}

	[SecurityCritical]
	public static void CreateJunction(string junctionPath, string directoryPath, bool overwrite, bool copyTargetTimestamps)
	{
		CreateJunctionCore(null, junctionPath, directoryPath, overwrite, copyTargetTimestamps, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CreateJunction(string junctionPath, string directoryPath, bool overwrite, bool copyTargetTimestamps, PathFormat pathFormat)
	{
		CreateJunctionCore(null, junctionPath, directoryPath, overwrite, copyTargetTimestamps, pathFormat);
	}

	[SecurityCritical]
	public static void CreateJunction(KernelTransaction transaction, string junctionPath, string directoryPath)
	{
		CreateJunctionCore(transaction, junctionPath, directoryPath, overwrite: false, copyTargetTimestamps: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CreateJunction(KernelTransaction transaction, string junctionPath, string directoryPath, PathFormat pathFormat)
	{
		CreateJunctionCore(transaction, junctionPath, directoryPath, overwrite: false, copyTargetTimestamps: false, pathFormat);
	}

	[SecurityCritical]
	public static void CreateJunction(KernelTransaction transaction, string junctionPath, string directoryPath, bool overwrite)
	{
		CreateJunctionCore(transaction, junctionPath, directoryPath, overwrite, copyTargetTimestamps: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CreateJunction(KernelTransaction transaction, string junctionPath, string directoryPath, bool overwrite, PathFormat pathFormat)
	{
		CreateJunctionCore(transaction, junctionPath, directoryPath, overwrite, copyTargetTimestamps: false, pathFormat);
	}

	[SecurityCritical]
	public static void CreateJunction(KernelTransaction transaction, string junctionPath, string directoryPath, bool overwrite, bool copyTargetTimestamps)
	{
		CreateJunctionCore(transaction, junctionPath, directoryPath, overwrite, copyTargetTimestamps, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CreateJunction(KernelTransaction transaction, string junctionPath, string directoryPath, bool overwrite, bool copyTargetTimestamps, PathFormat pathFormat)
	{
		CreateJunctionCore(transaction, junctionPath, directoryPath, overwrite, copyTargetTimestamps, pathFormat);
	}

	[SecurityCritical]
	internal static string CreateJunctionCore(KernelTransaction transaction, string junctionPath, string directoryPath, bool overwrite, bool copyTargetTimestamps, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath)
		{
			Path.CheckSupportedPathFormat(directoryPath, checkInvalidPathChars: true, checkAdditional: true);
			Path.CheckSupportedPathFormat(junctionPath, checkInvalidPathChars: true, checkAdditional: true);
			directoryPath = Path.GetExtendedLengthPathCore(transaction, directoryPath, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator);
			junctionPath = Path.GetExtendedLengthPathCore(transaction, junctionPath, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator);
			pathFormat = PathFormat.LongFullPath;
		}
		if (new DriveInfo(directoryPath).IsUnc)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Resources.Network_Path_Not_Allowed, new object[1] { directoryPath }), "directoryPath");
		}
		if (new DriveInfo(junctionPath).IsUnc)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Resources.Network_Path_Not_Allowed, new object[1] { junctionPath }), "junctionPath");
		}
		File.ThrowIOExceptionIfFsoExist(transaction, isFolder: false, directoryPath, pathFormat);
		File.ThrowIOExceptionIfFsoExist(transaction, isFolder: false, junctionPath, pathFormat);
		if (File.ExistsCore(transaction, isFolder: true, junctionPath, pathFormat))
		{
			if (!overwrite)
			{
				if (!IsEmptyCore(transaction, junctionPath, pathFormat))
				{
					throw new DirectoryNotEmptyException(junctionPath, isPath: true);
				}
				throw new AlreadyExistsException(junctionPath, isPath: true);
			}
			DeleteDirectoryCore(transaction, null, junctionPath, recursive: true, ignoreReadOnly: true, continueOnNotFound: true, pathFormat);
			CreateDirectoryCore(transaction, junctionPath, null, null, compress: false, pathFormat);
		}
		CreateDirectoryCore(transaction, junctionPath, null, null, compress: false, pathFormat);
		using (SafeFileHandle safeHandle = OpenDirectoryJunction(transaction, junctionPath, pathFormat))
		{
			Device.CreateDirectoryJunction(safeHandle, directoryPath);
		}
		if (copyTargetTimestamps)
		{
			File.CopyTimestampsCore(transaction, isFolder: true, directoryPath, junctionPath, modifyReparsePoint: true, pathFormat);
		}
		return junctionPath;
	}

	private static SafeFileHandle OpenDirectoryJunction(KernelTransaction transaction, string junctionPath, PathFormat pathFormat)
	{
		return File.CreateFileCore(transaction, true, junctionPath, ExtendedFileAttributes.OpenReparsePoint | ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.CreateFiles, FileShare.ReadWrite, checkPath: false, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectories(string path)
	{
		DeleteEmptySubdirectoriesCore(null, null, path, recursive: false, ignoreReadOnly: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectories(string path, bool recursive)
	{
		DeleteEmptySubdirectoriesCore(null, null, path, recursive, ignoreReadOnly: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectories(string path, bool recursive, PathFormat pathFormat)
	{
		DeleteEmptySubdirectoriesCore(null, null, path, recursive, ignoreReadOnly: false, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectories(string path, bool recursive, bool ignoreReadOnly)
	{
		DeleteEmptySubdirectoriesCore(null, null, path, recursive, ignoreReadOnly, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectories(string path, bool recursive, bool ignoreReadOnly, PathFormat pathFormat)
	{
		DeleteEmptySubdirectoriesCore(null, null, path, recursive, ignoreReadOnly, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectoriesTransacted(KernelTransaction transaction, string path)
	{
		DeleteEmptySubdirectoriesCore(null, transaction, path, recursive: false, ignoreReadOnly: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectoriesTransacted(KernelTransaction transaction, string path, bool recursive)
	{
		DeleteEmptySubdirectoriesCore(null, transaction, path, recursive, ignoreReadOnly: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectoriesTransacted(KernelTransaction transaction, string path, bool recursive, PathFormat pathFormat)
	{
		DeleteEmptySubdirectoriesCore(null, transaction, path, recursive, ignoreReadOnly: false, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectoriesTransacted(KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly)
	{
		DeleteEmptySubdirectoriesCore(null, transaction, path, recursive, ignoreReadOnly, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteEmptySubdirectoriesTransacted(KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly, PathFormat pathFormat)
	{
		DeleteEmptySubdirectoriesCore(null, transaction, path, recursive, ignoreReadOnly, pathFormat);
	}

	[SecurityCritical]
	internal static void DeleteEmptySubdirectoriesCore(FileSystemEntryInfo fsEntryInfo, KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly, PathFormat pathFormat)
	{
		if (fsEntryInfo == null)
		{
			if (pathFormat == PathFormat.RelativePath)
			{
				Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
			}
			if (!File.ExistsCore(transaction, isFolder: true, path, pathFormat))
			{
				NativeError.ThrowException(3u, path);
			}
			fsEntryInfo = File.GetFileSystemEntryInfoCore(transaction, isFolder: true, Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator), continueOnException: false, pathFormat);
			if (fsEntryInfo == null)
			{
				return;
			}
		}
		if (!fsEntryInfo.IsDirectory)
		{
			throw new IOException(string.Format(CultureInfo.InvariantCulture, Resources.Target_Directory_Is_A_File, new object[1] { fsEntryInfo.LongFullPath }));
		}
		Stack<string> stack = new Stack<string>(1000);
		stack.Push(fsEntryInfo.LongFullPath);
		while (stack.Count > 0)
		{
			foreach (FileSystemEntryInfo item in EnumerateFileSystemEntryInfosCore<FileSystemEntryInfo>(true, transaction, stack.Pop(), Path.WildcardStarMatchAll, null, DirectoryEnumerationOptions.ContinueOnException, null, PathFormat.LongFullPath))
			{
				if (IsEmptyCore(transaction, item.LongFullPath, pathFormat))
				{
					DeleteDirectoryCore(transaction, item, null, recursive: false, ignoreReadOnly, continueOnNotFound: true, PathFormat.LongFullPath);
				}
				else if (recursive)
				{
					stack.Push(item.LongFullPath);
				}
			}
		}
	}

	[SecurityCritical]
	public static void Delete(string path)
	{
		DeleteDirectoryCore(null, null, path, recursive: false, ignoreReadOnly: false, continueOnNotFound: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Delete(string path, bool recursive)
	{
		DeleteDirectoryCore(null, null, path, recursive, ignoreReadOnly: false, continueOnNotFound: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Delete(string path, PathFormat pathFormat)
	{
		DeleteDirectoryCore(null, null, path, recursive: false, ignoreReadOnly: false, continueOnNotFound: false, pathFormat);
	}

	[SecurityCritical]
	public static void Delete(string path, bool recursive, PathFormat pathFormat)
	{
		DeleteDirectoryCore(null, null, path, recursive, ignoreReadOnly: false, continueOnNotFound: false, pathFormat);
	}

	[SecurityCritical]
	public static void Delete(string path, bool recursive, bool ignoreReadOnly)
	{
		DeleteDirectoryCore(null, null, path, recursive, ignoreReadOnly, continueOnNotFound: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Delete(string path, bool recursive, bool ignoreReadOnly, PathFormat pathFormat)
	{
		DeleteDirectoryCore(null, null, path, recursive, ignoreReadOnly, continueOnNotFound: false, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path)
	{
		DeleteDirectoryCore(transaction, null, path, recursive: false, ignoreReadOnly: false, continueOnNotFound: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		DeleteDirectoryCore(transaction, null, path, recursive: false, ignoreReadOnly: false, continueOnNotFound: false, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path, bool recursive)
	{
		DeleteDirectoryCore(transaction, null, path, recursive, ignoreReadOnly: false, continueOnNotFound: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path, bool recursive, PathFormat pathFormat)
	{
		DeleteDirectoryCore(transaction, null, path, recursive, ignoreReadOnly: false, continueOnNotFound: false, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly)
	{
		DeleteDirectoryCore(transaction, null, path, recursive, ignoreReadOnly, continueOnNotFound: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path, bool recursive, bool ignoreReadOnly, PathFormat pathFormat)
	{
		DeleteDirectoryCore(transaction, null, path, recursive, ignoreReadOnly, continueOnNotFound: false, pathFormat);
	}

	[SecurityCritical]
	internal static void DeleteDirectoryCore(KernelTransaction transaction, FileSystemEntryInfo fsEntryInfo, string path, bool recursive, bool ignoreReadOnly, bool continueOnNotFound, PathFormat pathFormat)
	{
		if (fsEntryInfo == null)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			if (pathFormat == PathFormat.RelativePath)
			{
				Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
			}
			fsEntryInfo = File.GetFileSystemEntryInfoCore(transaction, isFolder: true, Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator), continueOnNotFound, pathFormat);
			if (fsEntryInfo == null)
			{
				return;
			}
		}
		pathFormat = PathFormat.LongFullPath;
		if (recursive && !fsEntryInfo.IsReparsePoint)
		{
			Stack<string> stack = new Stack<string>(1000);
			foreach (FileSystemEntryInfo item in EnumerateFileSystemEntryInfosCore<FileSystemEntryInfo>(null, transaction, fsEntryInfo.LongFullPath, Path.WildcardStarMatchAll, SearchOption.AllDirectories, null, null, pathFormat))
			{
				if (item.IsDirectory)
				{
					if (item.IsMountPoint)
					{
						DeleteJunctionCore(transaction, item, null, removeDirectory: false, pathFormat);
					}
					stack.Push(item.LongFullPath);
				}
				else
				{
					File.DeleteFileCore(transaction, item.LongFullPath, ignoreReadOnly, pathFormat);
				}
			}
			while (stack.Count > 0)
			{
				DeleteDirectoryCore(transaction, stack.Pop(), ignoreReadOnly, continueOnNotFound);
			}
		}
		if (fsEntryInfo.IsMountPoint)
		{
			DeleteJunctionCore(transaction, fsEntryInfo, null, removeDirectory: false, pathFormat);
		}
		DeleteDirectoryCore(transaction, fsEntryInfo.LongFullPath, ignoreReadOnly, continueOnNotFound);
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static void DeleteDirectoryCore(KernelTransaction transaction, string pathLp, bool ignoreReadOnly, bool continueOnNotFound)
	{
		while (true)
		{
			bool num = ((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.RemoveDirectoryW(pathLp) : NativeMethods.RemoveDirectoryTransactedW(pathLp, transaction.SafeHandle));
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (num)
			{
				break;
			}
			switch (lastWin32Error)
			{
			case 5:
			{
				NativeMethods.WIN32_FILE_ATTRIBUTE_DATA win32AttrData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				int num2 = File.FillAttributeInfoCore(transaction, pathLp, ref win32AttrData, tryAgain: false, returnErrorOnNotFound: true);
				if (File.IsReadOnly(win32AttrData.dwFileAttributes))
				{
					if (ignoreReadOnly)
					{
						goto IL_0060;
					}
					throw new DirectoryReadOnlyException(pathLp);
				}
				if (num2 == 0L)
				{
					NativeError.ThrowException(lastWin32Error, pathLp);
				}
				break;
			}
			case 3:
				if (continueOnNotFound)
				{
					return;
				}
				break;
			case 267:
				if (File.ExistsCore(transaction, isFolder: false, pathLp, PathFormat.LongFullPath))
				{
					throw new DirectoryNotFoundException(string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
					{
						lastWin32Error,
						string.Format(CultureInfo.InvariantCulture, Resources.Target_Directory_Is_A_File, new object[1] { pathLp })
					}));
				}
				break;
			case 145:
				throw new DirectoryNotEmptyException(pathLp, isPath: true);
			case 32:
				NativeError.ThrowException(lastWin32Error, pathLp);
				break;
			}
			NativeError.ThrowException(lastWin32Error, pathLp);
			break;
			IL_0060:
			File.SetAttributesCore(transaction, isFolder: true, pathLp, FileAttributes.Normal, PathFormat.LongFullPath);
		}
	}

	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path)
	{
		return CreateDirectoryCore(null, path, null, null, compress: false, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity)
	{
		return CreateDirectoryCore(null, path, null, directorySecurity, compress: false, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, null, null, compress: false, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, bool compress)
	{
		return CreateDirectoryCore(null, path, null, null, compress, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, null, null, compress, pathFormat);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, null, directorySecurity, compress: false, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity, bool compress)
	{
		return CreateDirectoryCore(null, path, null, directorySecurity, compress, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, null, directorySecurity, compress, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, string templatePath)
	{
		return CreateDirectoryCore(null, path, templatePath, null, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, string templatePath, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, templatePath, null, compress: false, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, string templatePath, bool compress)
	{
		return CreateDirectoryCore(null, path, templatePath, null, compress, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path, string templatePath, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, templatePath, null, compress, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, string templatePath, DirectorySecurity directorySecurity)
	{
		return CreateDirectoryCore(null, path, templatePath, directorySecurity, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, string templatePath, DirectorySecurity directorySecurity, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, templatePath, directorySecurity, compress: false, pathFormat);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectory(string path, string templatePath, DirectorySecurity directorySecurity, bool compress)
	{
		return CreateDirectoryCore(null, path, templatePath, directorySecurity, compress, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectory(string path, string templatePath, DirectorySecurity directorySecurity, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(null, path, templatePath, directorySecurity, compress, pathFormat);
	}

	[SecurityCritical]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path)
	{
		return CreateDirectoryCore(transaction, path, null, null, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, null, null, compress: false, pathFormat);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, bool compress)
	{
		return CreateDirectoryCore(transaction, path, null, null, compress, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, null, null, compress, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, DirectorySecurity directorySecurity)
	{
		return CreateDirectoryCore(transaction, path, null, directorySecurity, compress: false, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, DirectorySecurity directorySecurity, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, null, directorySecurity, compress: false, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, DirectorySecurity directorySecurity, bool compress)
	{
		return CreateDirectoryCore(transaction, path, null, directorySecurity, compress, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, DirectorySecurity directorySecurity, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, null, directorySecurity, compress, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath)
	{
		return CreateDirectoryCore(transaction, path, templatePath, null, compress: false, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, templatePath, null, compress: false, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath, bool compress)
	{
		return CreateDirectoryCore(transaction, path, templatePath, null, compress, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, templatePath, null, compress, pathFormat);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath, DirectorySecurity directorySecurity)
	{
		return CreateDirectoryCore(transaction, path, templatePath, directorySecurity, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath, DirectorySecurity directorySecurity, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, templatePath, directorySecurity, compress: false, pathFormat);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath, DirectorySecurity directorySecurity, bool compress)
	{
		return CreateDirectoryCore(transaction, path, templatePath, directorySecurity, compress, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static DirectoryInfo CreateDirectoryTransacted(KernelTransaction transaction, string path, string templatePath, DirectorySecurity directorySecurity, bool compress, PathFormat pathFormat)
	{
		return CreateDirectoryCore(transaction, path, templatePath, directorySecurity, compress, pathFormat);
	}

	[SecurityCritical]
	internal static DirectoryInfo CreateDirectoryCore(KernelTransaction transaction, string path, string templatePath, ObjectSecurity directorySecurity, bool compress, PathFormat pathFormat)
	{
		string text = path;
		if (pathFormat != PathFormat.LongFullPath)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
			Path.CheckSupportedPathFormat(templatePath, checkInvalidPathChars: true, checkAdditional: true);
			text = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			pathFormat = PathFormat.LongFullPath;
		}
		if (!char.IsWhiteSpace(text[text.Length - 1]) && File.ExistsCore(transaction, isFolder: true, text, pathFormat))
		{
			return new DirectoryInfo(transaction, text, pathFormat);
		}
		if (File.ExistsCore(transaction, isFolder: false, text, pathFormat))
		{
			NativeError.ThrowException(183u, text);
		}
		string text2 = (Utils.IsNullOrWhiteSpace(templatePath) ? null : Path.GetExtendedLengthPathCore(transaction, templatePath, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator));
		string pathNew;
		Stack<string> stack = ConstructFullPath(transaction, text, out pathNew);
		using Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpSecurityAttributes = new Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes(directorySecurity);
		while (stack.Count > 0)
		{
			string text3 = stack.Pop();
			if (!((transaction != null && NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.CreateDirectoryTransactedW(text2, text3, lpSecurityAttributes, transaction.SafeHandle) : ((text2 == null) ? NativeMethods.CreateDirectoryW(text3, lpSecurityAttributes) : NativeMethods.CreateDirectoryExW(text2, text3, lpSecurityAttributes))))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				switch (lastWin32Error)
				{
				case 67:
					NativeError.ThrowException(lastWin32Error, text);
					break;
				case 5:
				{
					DirectoryInfo parent = GetParent(text3);
					NativeError.ThrowException(lastWin32Error, (null != parent) ? parent.FullName : text3);
					break;
				}
				default:
					NativeError.ThrowException(lastWin32Error, text3);
					break;
				case 183:
					if (File.ExistsCore(transaction, isFolder: false, text, pathFormat))
					{
						NativeError.ThrowException(lastWin32Error, text);
					}
					if (File.ExistsCore(transaction, isFolder: false, text3, pathFormat))
					{
						NativeError.ThrowException(3u, null, text3);
					}
					break;
				case 267:
					throw new NotSupportedException(string.Format(CultureInfo.InvariantCulture, Resources.Unsupported_Path_Format, new object[1] { text }));
				}
			}
			else if (compress)
			{
				Device.ToggleCompressionCore(transaction, text3, compress: true, pathFormat);
			}
		}
		return new DirectoryInfo(transaction, text, pathFormat);
	}

	private static Stack<string> ConstructFullPath(KernelTransaction transaction, string path, out string pathNew)
	{
		string text = (Path.IsUncPathCore(path, isRegularPath: false, checkInvalidPathChars: false) ? Path.LongPathUncPrefix : Path.LongPathPrefix);
		path = Path.GetRegularPathCore(path, GetFullPathOptions.None, allowEmpty: false);
		int num = path.Length;
		if (num >= 2 && Path.IsDVsc(path[num - 1], false))
		{
			num--;
		}
		int rootLength = Path.GetRootLength(path, checkInvalidPathChars: false);
		if (num == 2 && Path.IsDVsc(path[1], false))
		{
			throw new ArgumentException(Resources.Cannot_Create_Directory, "path");
		}
		Stack<string> stack = new Stack<string>(100);
		if (num > rootLength)
		{
			for (int num2 = num - 1; num2 >= rootLength; num2--)
			{
				string text2 = path.Substring(0, num2 + 1);
				string text3 = text + text2.TrimStart(new char[1] { '\\' });
				if (!File.ExistsCore(transaction, isFolder: true, text3, PathFormat.LongFullPath))
				{
					stack.Push(text3);
				}
				while (num2 > rootLength && !Path.IsDVsc(path[num2], false))
				{
					num2--;
				}
			}
		}
		pathNew = path;
		return stack;
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, searchOption, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, searchOption, null, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, null, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectories(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, searchOption, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, searchOption, null, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, searchOption, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, searchOption, null, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, searchOption, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, searchOption, null, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, null, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFilesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, null, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, null, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfos<T>(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, null, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, null, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, null, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Infos")]
	public static IEnumerable<T> EnumerateFileSystemEntryInfosTransacted<T>(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<T>(null, transaction, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	internal static IEnumerable<T> EnumerateFileSystemEntryInfosCore<T>(bool? onlyFolders, KernelTransaction transaction, string path, string searchPattern, SearchOption? searchOption, DirectoryEnumerationOptions? options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		if (!options.HasValue)
		{
			options = DirectoryEnumerationOptions.None;
		}
		if (searchOption == SearchOption.AllDirectories)
		{
			options |= DirectoryEnumerationOptions.Recursive;
		}
		if (onlyFolders.HasValue)
		{
			if (onlyFolders.Value)
			{
				options &= ~DirectoryEnumerationOptions.Files;
				options |= DirectoryEnumerationOptions.Folders;
			}
			else
			{
				options &= ~DirectoryEnumerationOptions.Folders;
				options |= DirectoryEnumerationOptions.Files;
			}
		}
		return new FindFileSystemEntryInfo(transaction, isFolder: true, path, searchPattern, options, filters, pathFormat, typeof(T)).Enumerate<T>();
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, searchOption, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, searchOption, null, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, null, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, searchOption, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, null, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, searchOption, null, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, options, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, options, null, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, options, null, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, options, null, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, null, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, null, filters, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, options, filters, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, options, filters, pathFormat);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, options, filters, PathFormat.RelativePath);
	}

	[Obsolete("Argument searchPattern is obsolete. The DirectoryEnumerationFilters argument provides better filter criteria.")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, options, filters, pathFormat);
	}

	[SecurityCritical]
	public static bool IsEmpty(string directoryPath)
	{
		return IsEmptyCore(null, directoryPath, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool IsEmpty(string directoryPath, PathFormat pathFormat)
	{
		return IsEmptyCore(null, directoryPath, pathFormat);
	}

	[SecurityCritical]
	public static bool IsEmptyTransacted(KernelTransaction transaction, string directoryPath)
	{
		return IsEmptyCore(transaction, directoryPath, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool IsEmptyTransacted(KernelTransaction transaction, string directoryPath, PathFormat pathFormat)
	{
		return IsEmptyCore(transaction, directoryPath, pathFormat);
	}

	[SecurityCritical]
	internal static bool IsEmptyCore(KernelTransaction transaction, string directoryPath, PathFormat pathFormat)
	{
		return !EnumerateFileSystemEntryInfosCore<string>(null, transaction, directoryPath, Path.WildcardStarMatchAll, null, null, null, pathFormat).Any();
	}

	[SecurityCritical]
	public static bool Exists(string path)
	{
		return File.ExistsCore(null, isFolder: true, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool Exists(string path, PathFormat pathFormat)
	{
		return File.ExistsCore(null, isFolder: true, path, pathFormat);
	}

	[SecurityCritical]
	public static bool ExistsTransacted(KernelTransaction transaction, string path)
	{
		return File.ExistsCore(transaction, isFolder: true, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool ExistsTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.ExistsCore(transaction, isFolder: true, path, pathFormat);
	}

	[SecurityCritical]
	public static string[] GetDirectories(string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetDirectories(string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, null, path, searchPattern, searchOption, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetDirectoriesTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetDirectoriesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(true, transaction, path, searchPattern, searchOption, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFiles(string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, null, path, searchPattern, searchOption, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFilesTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFilesTransacted(KernelTransaction transaction, string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFilesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(false, transaction, path, searchPattern, searchOption, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static DateTime GetCreationTime(string path)
	{
		return File.GetCreationTimeCore(null, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtc(string path)
	{
		return File.GetCreationTimeCore(null, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetCreationTime(string path, PathFormat pathFormat)
	{
		return File.GetCreationTimeCore(null, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtc(string path, PathFormat pathFormat)
	{
		return File.GetCreationTimeCore(null, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeTransacted(KernelTransaction transaction, string path)
	{
		return File.GetCreationTimeCore(transaction, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetCreationTimeCore(transaction, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return File.GetCreationTimeCore(transaction, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetCreationTimeCore(transaction, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTime(string path)
	{
		return File.GetLastAccessTimeCore(null, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtc(string path)
	{
		return File.GetLastAccessTimeCore(null, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTime(string path, PathFormat pathFormat)
	{
		return File.GetLastAccessTimeCore(null, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtc(string path, PathFormat pathFormat)
	{
		return File.GetLastAccessTimeCore(null, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeTransacted(KernelTransaction transaction, string path)
	{
		return File.GetLastAccessTimeCore(transaction, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetLastAccessTimeCore(transaction, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return File.GetLastAccessTimeCore(transaction, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetLastAccessTimeCore(transaction, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTime(string path)
	{
		return File.GetLastWriteTimeCore(null, path, getUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtc(string path)
	{
		return File.GetLastWriteTimeCore(null, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTime(string path, PathFormat pathFormat)
	{
		return File.GetLastWriteTimeCore(null, path, getUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtc(string path, PathFormat pathFormat)
	{
		return File.GetLastWriteTimeCore(null, path, getUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeTransacted(KernelTransaction transaction, string path)
	{
		return File.GetLastWriteTimeCore(transaction, path, getUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetLastWriteTimeCore(transaction, path, getUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return File.GetLastWriteTimeCore(transaction, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetLastWriteTimeCore(transaction, path, getUtc: true, pathFormat);
	}

	public static bool HasInheritedPermissions(string path)
	{
		return HasInheritedPermissions(path, PathFormat.RelativePath);
	}

	public static bool HasInheritedPermissions(string path, PathFormat pathFormat)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		return (new RawSecurityDescriptor(File.GetAccessControlCore<DirectorySecurity>(isFolder: true, path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, pathFormat).GetSecurityDescriptorBinaryForm(), 0).ControlFlags & ControlFlags.DiscretionaryAclProtected) != ControlFlags.DiscretionaryAclProtected;
	}

	[SecurityCritical]
	public static DirectorySecurity GetAccessControl(string path)
	{
		return File.GetAccessControlCore<DirectorySecurity>(isFolder: true, path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections)
	{
		return File.GetAccessControlCore<DirectorySecurity>(isFolder: true, path, includeSections, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DirectorySecurity GetAccessControl(string path, PathFormat pathFormat)
	{
		return File.GetAccessControlCore<DirectorySecurity>(isFolder: true, path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, pathFormat);
	}

	[SecurityCritical]
	public static DirectorySecurity GetAccessControl(string path, AccessControlSections includeSections, PathFormat pathFormat)
	{
		return File.GetAccessControlCore<DirectorySecurity>(isFolder: true, path, includeSections, pathFormat);
	}

	[SecurityCritical]
	public static DirectorySecurity GetAccessControl(SafeFileHandle handle)
	{
		return File.GetAccessControlHandleCore<DirectorySecurity>(internalCall: false, isFolder: true, handle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, SECURITY_INFORMATION.None);
	}

	[SecurityCritical]
	public static DirectorySecurity GetAccessControl(SafeFileHandle handle, AccessControlSections includeSections)
	{
		return File.GetAccessControlHandleCore<DirectorySecurity>(internalCall: false, isFolder: true, handle, includeSections, SECURITY_INFORMATION.None);
	}

	[SecurityCritical]
	public static DateTime GetChangeTime(string path)
	{
		return File.GetChangeTimeCore(null, null, isFolder: true, path, getUtc: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTime(string path, PathFormat pathFormat)
	{
		return File.GetChangeTimeCore(null, null, isFolder: true, path, getUtc: false, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtc(string path)
	{
		return File.GetChangeTimeCore(null, null, isFolder: true, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtc(string path, PathFormat pathFormat)
	{
		return File.GetChangeTimeCore(null, null, isFolder: true, path, getUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetChangeTime(SafeFileHandle safeFileHandle)
	{
		return File.GetChangeTimeCore(null, safeFileHandle, isFolder: true, null, getUtc: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtc(SafeFileHandle safeFileHandle)
	{
		return File.GetChangeTimeCore(null, safeFileHandle, isFolder: true, null, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeTransacted(KernelTransaction transaction, string path)
	{
		return File.GetChangeTimeCore(transaction, null, isFolder: true, path, getUtc: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetChangeTimeCore(transaction, null, isFolder: true, path, getUtc: false, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return File.GetChangeTimeCore(transaction, null, isFolder: true, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetChangeTimeCore(transaction, null, isFolder: true, path, getUtc: true, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public static string GetCurrentDirectory()
	{
		StringBuilder stringBuilder = new StringBuilder(32700);
		uint currentDirectoryW = NativeMethods.GetCurrentDirectoryW((uint)stringBuilder.Capacity, stringBuilder);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (currentDirectoryW == 0)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		if (currentDirectoryW > 32700)
		{
			throw new PathTooLongException(string.Format(CultureInfo.InvariantCulture, "Path is greater than {0} characters: {1}", new object[2] { 32700, currentDirectoryW }));
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	public static void SetCurrentDirectory(string path)
	{
		SetCurrentDirectory(path, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	[SecurityCritical]
	public static void SetCurrentDirectory(string path, PathFormat pathFormat)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		bool flag = pathFormat == PathFormat.RelativePath;
		Path.CheckSupportedPathFormat(path, flag, flag);
		string text = Path.GetExtendedLengthPathCore(null, path, pathFormat, GetFullPathOptions.AddTrailingDirectorySeparator);
		if (pathFormat == PathFormat.FullPath)
		{
			text = Path.GetRegularPathCore(text, GetFullPathOptions.None, allowEmpty: false);
		}
		bool num = NativeMethods.SetCurrentDirectoryW(text);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, text);
		}
	}

	[SecurityCritical]
	public static string[] GetFileSystemEntries(string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFileSystemEntries(string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, null, path, searchPattern, searchOption, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFileSystemEntriesTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, Path.WildcardStarMatchAll, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, null, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] GetFileSystemEntriesTransacted(KernelTransaction transaction, string path, string searchPattern, SearchOption searchOption)
	{
		return EnumerateFileSystemEntryInfosCore<string>(null, transaction, path, searchPattern, searchOption, null, null, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string GetDirectoryRoot(string path)
	{
		return GetDirectoryRootCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string GetDirectoryRoot(string path, PathFormat pathFormat)
	{
		return GetDirectoryRootCore(null, path, pathFormat);
	}

	[SecurityCritical]
	public static string GetDirectoryRootTransacted(KernelTransaction transaction, string path)
	{
		return GetDirectoryRootCore(transaction, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string GetDirectoryRootTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetDirectoryRootCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	internal static string GetDirectoryRootCore(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		string path2 = path;
		if (pathFormat != PathFormat.LongFullPath)
		{
			Path.CheckInvalidUncPath(path);
			path2 = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.CheckInvalidPathChars);
			path2 = Path.GetRegularPathCore(path2, GetFullPathOptions.None, allowEmpty: false);
		}
		string pathRoot = Path.GetPathRoot(path2, checkInvalidPathChars: false);
		if (!Utils.IsNullOrWhiteSpace(pathRoot))
		{
			return pathRoot;
		}
		return null;
	}

	[SecurityCritical]
	public static string[] GetLogicalDrives()
	{
		return (from drive in EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: false)
			select drive.Name).ToArray();
	}

	[SecurityCritical]
	public static string[] GetLogicalDrives(bool fromEnvironment, bool isReady)
	{
		return (from drive in EnumerateLogicalDrivesCore(fromEnvironment, isReady)
			select drive.Name).ToArray();
	}

	[SecurityCritical]
	public static DirectoryInfo GetParent(string path)
	{
		return GetParentCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DirectoryInfo GetParent(string path, PathFormat pathFormat)
	{
		return GetParentCore(null, path, pathFormat);
	}

	[SecurityCritical]
	public static DirectoryInfo GetParentTransacted(KernelTransaction transaction, string path)
	{
		return GetParentCore(transaction, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DirectoryInfo GetParentTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetParentCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	internal static DirectoryInfo GetParentCore(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		string directoryName = Path.GetDirectoryName(Path.GetRegularPathCore(Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.CheckInvalidPathChars), GetFullPathOptions.None, allowEmpty: false), checkInvalidPathChars: false);
		if (!Utils.IsNullOrWhiteSpace(directoryName))
		{
			return new DirectoryInfo(transaction, directoryName, PathFormat.RelativePath);
		}
		return null;
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, DirectorySecurity directorySecurity)
	{
		File.SetAccessControlCore(path, null, directorySecurity, AccessControlSections.All, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, DirectorySecurity directorySecurity, AccessControlSections includeSections)
	{
		File.SetAccessControlCore(path, null, directorySecurity, includeSections, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, DirectorySecurity directorySecurity, PathFormat pathFormat)
	{
		File.SetAccessControlCore(path, null, directorySecurity, AccessControlSections.All, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, DirectorySecurity directorySecurity, AccessControlSections includeSections, PathFormat pathFormat)
	{
		File.SetAccessControlCore(path, null, directorySecurity, includeSections, pathFormat);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	[SecurityCritical]
	public static void SetAccessControl(SafeFileHandle handle, DirectorySecurity directorySecurity)
	{
		File.SetAccessControlCore(null, handle, directorySecurity, AccessControlSections.All, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(SafeFileHandle handle, DirectorySecurity directorySecurity, AccessControlSections includeSections)
	{
		File.SetAccessControlCore(null, handle, directorySecurity, includeSections, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public static void SetCreationTime(string path, DateTime creationTime)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTimeUtc, null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTime(string path, DateTime creationTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTime(string path, DateTime creationTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTimeUtc, null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTimeUtc, null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTimeUtc, null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTimeUtc, null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTimeUtc, null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTime(string path, DateTime lastAccessTime)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTime(string path, DateTime lastAccessTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTime(string path, DateTime lastAccessTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, lastAccessTimeUtc, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeTransacted(KernelTransaction transaction, string path, DateTime lastAccessTime)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeTransacted(KernelTransaction transaction, string path, DateTime lastAccessTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeTransacted(KernelTransaction transaction, string path, DateTime lastAccessTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, lastAccessTimeUtc, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsTransacted(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestampsTransacted(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsTransacted(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestampsUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Use new method name: CopyTimestamps")]
	public static void TransferTimestamps(string sourcePath, string destinationPath)
	{
		CopyTimestamps(sourcePath, destinationPath);
	}

	[Obsolete("Use new method name: CopyTimestamps")]
	[SecurityCritical]
	public static void TransferTimestamps(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		CopyTimestamps(sourcePath, destinationPath, pathFormat);
	}

	[Obsolete("Use new method name: CopyTimestampsTransacted")]
	[SecurityCritical]
	public static void TransferTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		CopyTimestampsTransacted(transaction, sourcePath, destinationPath, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Use new method name: CopyTimestampsTransacted")]
	public static void TransferTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		CopyTimestampsTransacted(transaction, sourcePath, destinationPath, pathFormat);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath)
	{
		File.CopyTimestampsCore(null, isFolder: true, sourcePath, destinationPath, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		File.CopyTimestampsCore(null, isFolder: true, sourcePath, destinationPath, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath, bool modifyReparsePoint)
	{
		File.CopyTimestampsCore(null, isFolder: true, sourcePath, destinationPath, modifyReparsePoint, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.CopyTimestampsCore(null, isFolder: true, sourcePath, destinationPath, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		File.CopyTimestampsCore(transaction, isFolder: true, sourcePath, destinationPath, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		File.CopyTimestampsCore(transaction, isFolder: true, sourcePath, destinationPath, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool modifyReparsePoint)
	{
		File.CopyTimestampsCore(transaction, isFolder: true, sourcePath, destinationPath, modifyReparsePoint, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.CopyTimestampsCore(transaction, isFolder: true, sourcePath, destinationPath, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTime(string path, DateTime lastWriteTime)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTime(string path, DateTime lastWriteTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTime(string path, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(null, isFolder: true, path, null, null, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeTransacted(KernelTransaction transaction, string path, DateTime lastWriteTime)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeTransacted(KernelTransaction transaction, string path, DateTime lastWriteTime, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeTransacted(KernelTransaction transaction, string path, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		File.SetFsoDateTimeCore(transaction, isFolder: true, path, null, null, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void Compress(string path)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, null, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Compress(string path, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, null, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void Compress(string path, DirectoryEnumerationOptions options)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, null, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Compress(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, null, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void Compress(string path, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, filters, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Compress(string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, null, filters, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void Compress(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, filters, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Compress(string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(null, path, Path.WildcardStarMatchAll, options, filters, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, null, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, null, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, null, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, null, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, filters, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, null, filters, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, filters, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, DirectoryEnumerationFilters filters, PathFormat pathFormat)
	{
		CompressDecompressCore(transaction, path, Path.WildcardStarMatchAll, options, filters, compress: true, pathFormat);
	}

	[SecurityCritical]
	internal static void CompressDecompressCore(KernelTransaction transaction, string path, string searchPattern, DirectoryEnumerationOptions? options, DirectoryEnumerationFilters filters, bool compress, PathFormat pathFormat)
	{
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		if (!options.HasValue)
		{
			options = DirectoryEnumerationOptions.None;
		}
		foreach (string item in EnumerateFileSystemEntryInfosCore<string>(null, transaction, extendedLengthPathCore, searchPattern, null, options | DirectoryEnumerationOptions.AsLongPath, filters, PathFormat.LongFullPath))
		{
			Device.ToggleCompressionCore(transaction, item, compress, PathFormat.LongFullPath);
		}
		Device.ToggleCompressionCore(transaction, extendedLengthPathCore, compress, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public static void Decrypt(string path, PathFormat pathFormat)
	{
		EncryptDecryptDirectoryCore(path, encrypt: false, recursive: false, pathFormat);
	}

	[SecurityCritical]
	public static void Decrypt(string path, bool recursive, PathFormat pathFormat)
	{
		EncryptDecryptDirectoryCore(path, encrypt: false, recursive, pathFormat);
	}

	[SecurityCritical]
	public static void Decrypt(string path)
	{
		EncryptDecryptDirectoryCore(path, encrypt: false, recursive: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Decrypt(string path, bool recursive)
	{
		EncryptDecryptDirectoryCore(path, encrypt: false, recursive, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Encrypt(string path, PathFormat pathFormat)
	{
		EncryptDecryptDirectoryCore(path, encrypt: true, recursive: false, pathFormat);
	}

	[SecurityCritical]
	public static void Encrypt(string path, bool recursive, PathFormat pathFormat)
	{
		EncryptDecryptDirectoryCore(path, encrypt: true, recursive, pathFormat);
	}

	[SecurityCritical]
	public static void Encrypt(string path)
	{
		EncryptDecryptDirectoryCore(path, encrypt: true, recursive: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Encrypt(string path, bool recursive)
	{
		EncryptDecryptDirectoryCore(path, encrypt: true, recursive, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DisableEncryption(string path, PathFormat pathFormat)
	{
		EnableDisableEncryptionCore(path, enable: false, pathFormat);
	}

	[SecurityCritical]
	public static void DisableEncryption(string path)
	{
		EnableDisableEncryptionCore(path, enable: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void EnableEncryption(string path, PathFormat pathFormat)
	{
		EnableDisableEncryptionCore(path, enable: true, pathFormat);
	}

	[SecurityCritical]
	public static void EnableEncryption(string path)
	{
		EnableDisableEncryptionCore(path, enable: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	internal static void EnableDisableEncryptionCore(string path, bool enable, PathFormat pathFormat)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(null, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		bool num = NativeMethods.EncryptionDisable(extendedLengthPathCore, !enable);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
		}
	}

	[SecurityCritical]
	internal static void EncryptDecryptDirectoryCore(string path, bool encrypt, bool recursive, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath)
		{
			path = Path.GetExtendedLengthPathCore(null, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			pathFormat = PathFormat.LongFullPath;
		}
		if (recursive)
		{
			foreach (string item in EnumerateFileSystemEntryInfosCore<string>(null, null, path, Path.WildcardStarMatchAll, SearchOption.AllDirectories, DirectoryEnumerationOptions.AsLongPath, null, pathFormat))
			{
				File.EncryptDecryptFileCore(isFolder: true, item, encrypt, pathFormat);
			}
		}
		File.EncryptDecryptFileCore(isFolder: true, path, encrypt, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path)
	{
		return EnumerateFileIdBothDirectoryInfoCore(null, null, path, FileShare.ReadWrite, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path, PathFormat pathFormat)
	{
		return EnumerateFileIdBothDirectoryInfoCore(null, null, path, FileShare.ReadWrite, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path, FileShare shareMode)
	{
		return EnumerateFileIdBothDirectoryInfoCore(null, null, path, shareMode, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(string path, FileShare shareMode, PathFormat pathFormat)
	{
		return EnumerateFileIdBothDirectoryInfoCore(null, null, path, shareMode, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfo(SafeFileHandle handle)
	{
		return EnumerateFileIdBothDirectoryInfoCore(null, handle, null, FileShare.ReadWrite, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfoTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateFileIdBothDirectoryInfoCore(transaction, null, path, FileShare.ReadWrite, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfoTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return EnumerateFileIdBothDirectoryInfoCore(transaction, null, path, FileShare.ReadWrite, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfoTransacted(KernelTransaction transaction, string path, FileShare shareMode)
	{
		return EnumerateFileIdBothDirectoryInfoCore(transaction, null, path, shareMode, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfoTransacted(KernelTransaction transaction, string path, FileShare shareMode, PathFormat pathFormat)
	{
		return EnumerateFileIdBothDirectoryInfoCore(transaction, null, path, shareMode, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	internal static IEnumerable<FileIdBothDirectoryInfo> EnumerateFileIdBothDirectoryInfoCore(KernelTransaction transaction, SafeFileHandle safeFileHandle, string path, FileShare shareMode, bool continueOnException, PathFormat pathFormat)
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		string pathLp = path;
		bool callerHandle = safeFileHandle != null;
		if (!callerHandle)
		{
			if (Utils.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentNullException("path");
			}
			pathLp = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			safeFileHandle = File.CreateFileCore(transaction, true, pathLp, ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.ListDirectory, shareMode, checkPath: true, continueOnException: false, PathFormat.LongFullPath);
		}
		try
		{
			if (!NativeMethods.IsValidHandle(safeFileHandle, Marshal.GetLastWin32Error(), !continueOnException))
			{
				yield break;
			}
			int fileNameOffset = (int)Marshal.OffsetOf(typeof(NativeMethods.FILE_ID_BOTH_DIR_INFO), "FileName");
			using SafeGlobalMemoryBufferHandle safeBuffer = new SafeGlobalMemoryBufferHandle(4096);
			while (true)
			{
				bool fileInformationByHandleEx = NativeMethods.GetFileInformationByHandleEx(safeFileHandle, NativeMethods.FILE_INFO_BY_HANDLE_CLASS.FILE_ID_BOTH_DIR_INFO, safeBuffer, (uint)safeBuffer.Capacity);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (fileInformationByHandleEx)
				{
					int offset = 0;
					NativeMethods.FILE_ID_BOTH_DIR_INFO fibdi;
					do
					{
						fibdi = safeBuffer.PtrToStructure<NativeMethods.FILE_ID_BOTH_DIR_INFO>(offset);
						string text = safeBuffer.PtrToStringUni(offset + fileNameOffset, (int)(fibdi.FileNameLength / 2u));
						offset += fibdi.NextEntryOffset;
						if (!File.IsDirectory(fibdi.FileAttributes) || (!text.Equals(Path.CurrentDirectoryPrefix, StringComparison.Ordinal) && !text.Equals("..", StringComparison.Ordinal)))
						{
							yield return new FileIdBothDirectoryInfo(fibdi, text);
						}
					}
					while (fibdi.NextEntryOffset != 0);
				}
				else
				{
					switch (lastWin32Error)
					{
					case 234:
						continue;
					case 0:
					case 18:
					case 38:
						yield break;
					}
					NativeError.ThrowException(lastWin32Error, pathLp);
					yield break;
				}
			}
		}
		finally
		{
			if (!callerHandle)
			{
				safeFileHandle?.Close();
			}
		}
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetProperties(string path)
	{
		return GetPropertiesCore(null, path, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetProperties(string path, PathFormat pathFormat)
	{
		return GetPropertiesCore(null, path, null, pathFormat);
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetProperties(string path, DirectoryEnumerationOptions options)
	{
		return GetPropertiesCore(null, path, options, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetProperties(string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return GetPropertiesCore(null, path, options, pathFormat);
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetPropertiesTransacted(KernelTransaction transaction, string path)
	{
		return GetPropertiesCore(transaction, path, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetPropertiesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetPropertiesCore(transaction, path, null, pathFormat);
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetPropertiesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options)
	{
		return GetPropertiesCore(transaction, path, options, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static Dictionary<string, long> GetPropertiesTransacted(KernelTransaction transaction, string path, DirectoryEnumerationOptions options, PathFormat pathFormat)
	{
		return GetPropertiesCore(transaction, path, options, pathFormat);
	}

	[SecurityCritical]
	internal static Dictionary<string, long> GetPropertiesCore(KernelTransaction transaction, string path, DirectoryEnumerationOptions? options, PathFormat pathFormat)
	{
		long num = 0L;
		long num2 = 0L;
		Type typeFromHandle = typeof(FileAttributes);
		Array values = Enum.GetValues(typeFromHandle);
		Dictionary<string, long> dictionary = (from attrs in Enum.GetNames(typeFromHandle)
			orderby attrs
			select attrs).ToDictionary((string name) => name, (string name) => 0L);
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		foreach (FileSystemEntryInfo item in EnumerateFileSystemEntryInfosCore<FileSystemEntryInfo>(null, transaction, extendedLengthPathCore, Path.WildcardStarMatchAll, null, options, null, PathFormat.LongFullPath))
		{
			num++;
			if (!item.IsDirectory)
			{
				num2 += item.FileSize;
			}
			FileSystemEntryInfo fsei1 = item;
			foreach (FileAttributes item2 in from FileAttributes attributeMarker in values
				where (fsei1.Attributes & attributeMarker) != 0
				select attributeMarker)
			{
				dictionary[(((item2 & FileAttributes.Directory) != 0) ? FileAttributes.Directory : item2).ToString()]++;
			}
		}
		dictionary.Add("File", num - dictionary[FileAttributes.Directory.ToString()] - dictionary[FileAttributes.ReparsePoint.ToString()]);
		dictionary.Add("Total", num);
		dictionary.Add("Size", num2);
		return dictionary;
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreams(string path)
	{
		return File.EnumerateAlternateDataStreamsCore(null, isFolder: true, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreams(string path, PathFormat pathFormat)
	{
		return File.EnumerateAlternateDataStreamsCore(null, isFolder: true, path, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreamsTransacted(KernelTransaction transaction, string path)
	{
		return File.EnumerateAlternateDataStreamsCore(transaction, isFolder: true, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreamsTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.EnumerateAlternateDataStreamsCore(transaction, isFolder: true, path, pathFormat);
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfo(string path)
	{
		return File.GetLinkTargetInfoCore(null, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfo(string path, PathFormat pathFormat)
	{
		return File.GetLinkTargetInfoCore(null, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfoTransacted(KernelTransaction transaction, string path)
	{
		return File.GetLinkTargetInfoCore(transaction, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfoTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetLinkTargetInfoCore(transaction, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLink(string symlinkDirectoryName, string targetDirectoryName)
	{
		File.CreateSymbolicLinkCore(null, symlinkDirectoryName, targetDirectoryName, SymbolicLinkTarget.Directory, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	[SecurityCritical]
	public static void CreateSymbolicLink(string symlinkDirectoryName, string targetDirectoryName, PathFormat pathFormat)
	{
		File.CreateSymbolicLinkCore(null, symlinkDirectoryName, targetDirectoryName, SymbolicLinkTarget.Directory, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLinkTransacted(KernelTransaction transaction, string symlinkDirectoryName, string targetDirectoryName)
	{
		File.CreateSymbolicLinkCore(transaction, symlinkDirectoryName, targetDirectoryName, SymbolicLinkTarget.Directory, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLinkTransacted(KernelTransaction transaction, string symlinkDirectoryName, string targetDirectoryName, PathFormat pathFormat)
	{
		File.CreateSymbolicLinkCore(transaction, symlinkDirectoryName, targetDirectoryName, SymbolicLinkTarget.Directory, pathFormat);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path)
	{
		return File.GetFileSystemEntryInfoCore(null, isFolder: true, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path, PathFormat pathFormat)
	{
		return File.GetFileSystemEntryInfoCore(null, isFolder: true, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path, bool continueOnException)
	{
		return File.GetFileSystemEntryInfoCore(null, isFolder: true, path, continueOnException, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path, bool continueOnException, PathFormat pathFormat)
	{
		return File.GetFileSystemEntryInfoCore(null, isFolder: true, path, continueOnException, pathFormat);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path)
	{
		return File.GetFileSystemEntryInfoCore(transaction, isFolder: true, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return File.GetFileSystemEntryInfoCore(transaction, isFolder: true, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path, bool continueOnException)
	{
		return File.GetFileSystemEntryInfoCore(transaction, isFolder: true, path, continueOnException, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path, bool continueOnException, PathFormat pathFormat)
	{
		return File.GetFileSystemEntryInfoCore(transaction, isFolder: true, path, continueOnException, pathFormat);
	}

	public static void ExportEncryptedDirectoryRaw(string fileName, Stream outputStream)
	{
		File.ImportExportEncryptedFileDirectoryRawCore(isExport: true, isFolder: false, outputStream, fileName, PathFormat.RelativePath, overwriteHidden: false);
	}

	public static void ExportEncryptedDirectoryRaw(string fileName, Stream outputStream, PathFormat pathFormat)
	{
		File.ImportExportEncryptedFileDirectoryRawCore(isExport: true, isFolder: false, outputStream, fileName, pathFormat, overwriteHidden: false);
	}

	public static void ImportEncryptedDirectoryRaw(Stream inputStream, string destinationPath)
	{
		File.ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: true, inputStream, destinationPath, PathFormat.RelativePath, overwriteHidden: false);
	}

	public static void ImportEncryptedDirectoryRaw(Stream inputStream, string destinationPath, PathFormat pathFormat)
	{
		File.ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: true, inputStream, destinationPath, pathFormat, overwriteHidden: false);
	}

	public static void ImportEncryptedDirectoryRaw(Stream inputStream, string destinationPath, bool overwriteHidden)
	{
		File.ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: true, inputStream, destinationPath, PathFormat.RelativePath, overwriteHidden);
	}

	public static void ImportEncryptedDirectoryRaw(Stream inputStream, string destinationPath, bool overwriteHidden, PathFormat pathFormat)
	{
		File.ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: true, inputStream, destinationPath, pathFormat, overwriteHidden);
	}
}
