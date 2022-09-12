using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using Alphaleonis.Win32.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public static class File
{
	[SecurityCritical]
	[Obsolete("Use GetFileIdInfoTransacted method.")]
	public static FileIdInfo GetFileIdTransacted(KernelTransaction transaction, string path)
	{
		return GetFileIdInfoCore(transaction, isFolder: false, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Use GetFileIdInfoTransacted method.")]
	public static FileIdInfo GetFileIdTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetFileIdInfoCore(transaction, isFolder: false, path, pathFormat);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfo(string path)
	{
		return GetFileIdInfoCore(null, isFolder: false, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfo(string path, PathFormat pathFormat)
	{
		return GetFileIdInfoCore(null, isFolder: false, path, pathFormat);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfoTransacted(KernelTransaction transaction, string path)
	{
		return GetFileIdInfoCore(transaction, isFolder: false, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfoTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetFileIdInfoCore(transaction, isFolder: false, path, pathFormat);
	}

	[SecurityCritical]
	public static FileIdInfo GetFileIdInfo(SafeFileHandle handle)
	{
		NativeMethods.BY_HANDLE_FILE_INFORMATION lpByHandleFileInformation;
		bool fileInformationByHandle = NativeMethods.GetFileInformationByHandle(handle, out lpByHandleFileInformation);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!fileInformationByHandle)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		return new FileIdInfo(lpByHandleFileInformation);
	}

	[SecurityCritical]
	internal static FileIdInfo GetFileIdInfoCore(KernelTransaction transaction, bool isFolder, string path, PathFormat pathFormat)
	{
		using SafeFileHandle safeFileHandle = CreateFileCore(transaction, isFolder, path, ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.ListDirectory, FileShare.ReadWrite, checkPath: true, continueOnException: false, pathFormat);
		if (NativeMethods.IsAtLeastWindows8)
		{
			using (SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(Marshal.SizeOf(typeof(NativeMethods.FILE_ID_INFO))))
			{
				bool fileInformationByHandleEx = NativeMethods.GetFileInformationByHandleEx(safeFileHandle, NativeMethods.FILE_INFO_BY_HANDLE_CLASS.FILE_ID_INFO, safeGlobalMemoryBufferHandle, (uint)safeGlobalMemoryBufferHandle.Capacity);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!fileInformationByHandleEx)
				{
					NativeError.ThrowException(lastWin32Error, isFolder, path);
				}
				return new FileIdInfo(safeGlobalMemoryBufferHandle.PtrToStructure<NativeMethods.FILE_ID_INFO>(0));
			}
		}
		return GetFileIdInfo(safeFileHandle);
	}

	internal static bool AllowEmulate(MoveOptions? moveOptions)
	{
		if (Utils.IsNotNull(moveOptions))
		{
			MoveOptions? moveOptions2 = moveOptions & MoveOptions.CopyAllowed;
			if (moveOptions2.GetValueOrDefault() != 0)
			{
				return true;
			}
			return !moveOptions2.HasValue;
		}
		return false;
	}

	internal static bool CanOverwrite(MoveOptions? moveOptions)
	{
		if (Utils.IsNotNull(moveOptions))
		{
			MoveOptions? moveOptions2 = moveOptions & MoveOptions.ReplaceExisting;
			if (moveOptions2.GetValueOrDefault() != 0)
			{
				return true;
			}
			return !moveOptions2.HasValue;
		}
		return false;
	}

	internal static bool HasCopySymbolicLink(CopyOptions? copyOptions)
	{
		if (Utils.IsNotNull(copyOptions))
		{
			CopyOptions? copyOptions2 = copyOptions & CopyOptions.CopySymbolicLink;
			if (copyOptions2.GetValueOrDefault() != 0)
			{
				return true;
			}
			return !copyOptions2.HasValue;
		}
		return false;
	}

	internal static bool HasDelayUntilReboot(MoveOptions? moveOptions)
	{
		if (Utils.IsNotNull(moveOptions))
		{
			MoveOptions? moveOptions2 = moveOptions & MoveOptions.DelayUntilReboot;
			if (moveOptions2.GetValueOrDefault() != 0)
			{
				return true;
			}
			return !moveOptions2.HasValue;
		}
		return false;
	}

	internal static bool HasValidAttributes(FileAttributes fileAttributes)
	{
		if (Utils.IsNotNull(fileAttributes))
		{
			return !fileAttributes.Equals((FileAttributes)(-1));
		}
		return false;
	}

	internal static bool IsCopyAction(CopyOptions? copyOptions, MoveOptions? moveOptions)
	{
		bool obj;
		bool result = !(obj = Utils.IsNotNull(moveOptions) && object.Equals(null, copyOptions)) && Utils.IsNotNull(copyOptions);
		if (result.Equals(obj))
		{
			throw new NotSupportedException(Resources.Cannot_Determine_Copy_Or_Move);
		}
		return result;
	}

	internal static bool IsDirectory(FileAttributes fileAttributes)
	{
		if (HasValidAttributes(fileAttributes))
		{
			return (fileAttributes & FileAttributes.Directory) != 0;
		}
		return false;
	}

	internal static bool IsHidden(FileAttributes fileAttributes)
	{
		if (HasValidAttributes(fileAttributes))
		{
			return (fileAttributes & FileAttributes.Hidden) != 0;
		}
		return false;
	}

	internal static bool IsReadOnly(FileAttributes fileAttributes)
	{
		if (HasValidAttributes(fileAttributes))
		{
			return (fileAttributes & FileAttributes.ReadOnly) != 0;
		}
		return false;
	}

	internal static bool IsReadOnlyOrHidden(FileAttributes fileAttributes)
	{
		if (!IsReadOnly(fileAttributes))
		{
			return IsHidden(fileAttributes);
		}
		return true;
	}

	[SecurityCritical]
	public static void Move(string sourcePath, string destinationPath)
	{
		CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, MoveOptions.CopyAllowed, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, MoveOptions.CopyAllowed, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, MoveOptions.CopyAllowed, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, MoveOptions.CopyAllowed, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Move(string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult MoveTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, MoveOptions moveOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, null, moveOptions, preserveDates: false, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static void Decompress(string path)
	{
		Device.ToggleCompressionCore(null, path, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Decompress(string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(null, path, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path)
	{
		Device.ToggleCompressionCore(transaction, path, compress: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DecompressTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(transaction, path, compress: false, pathFormat);
	}

	[SecurityCritical]
	public static string GetHash(string fileFullPath, HashType hashType)
	{
		return GetHashCore(null, fileFullPath, hashType, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string GetHash(string fileFullPath, HashType hashType, PathFormat pathFormat)
	{
		return GetHashCore(null, fileFullPath, hashType, pathFormat);
	}

	[SecurityCritical]
	public static string GetHash(KernelTransaction transaction, string fileFullPath, HashType hashType)
	{
		return GetHashCore(transaction, fileFullPath, hashType, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string GetHash(KernelTransaction transaction, string fileFullPath, HashType hashType, PathFormat pathFormat)
	{
		return GetHashCore(transaction, fileFullPath, hashType, pathFormat);
	}

	[SecurityCritical]
	internal static string GetHashCore(KernelTransaction transaction, string fileFullPath, HashType hashType, PathFormat pathFormat)
	{
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, fileFullPath, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		byte[] array = null;
		using (FileStream inputStream = OpenCore(transaction, extendedLengthPathCore, FileMode.Open, FileAccess.Read, FileShare.Read, ExtendedFileAttributes.Normal, null, null, PathFormat.LongFullPath))
		{
			switch (hashType)
			{
			case HashType.CRC32:
			{
				using (Crc32 crc2 = new Crc32())
				{
					array = crc2.ComputeHash(inputStream);
				}
				break;
			}
			case HashType.CRC64ISO3309:
			{
				using (Crc64 crc = new Crc64())
				{
					array = crc.ComputeHash(inputStream);
				}
				break;
			}
			case HashType.MD5:
			{
				using (MD5 mD = MD5.Create())
				{
					array = mD.ComputeHash(inputStream);
				}
				break;
			}
			case HashType.RIPEMD160:
			{
				RIPEMD160 val = RIPEMD160.Create();
				try
				{
					array = ((HashAlgorithm)(object)val).ComputeHash((Stream)inputStream);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				break;
			}
			case HashType.SHA1:
			{
				using (SHA1 sHA4 = SHA1.Create())
				{
					array = sHA4.ComputeHash(inputStream);
				}
				break;
			}
			case HashType.SHA256:
			{
				using (SHA256 sHA3 = SHA256.Create())
				{
					array = sHA3.ComputeHash(inputStream);
				}
				break;
			}
			case HashType.SHA384:
			{
				using (SHA384 sHA2 = SHA384.Create())
				{
					array = sHA2.ComputeHash(inputStream);
				}
				break;
			}
			case HashType.SHA512:
			{
				using (SHA512 sHA = SHA512.Create())
				{
					array = sHA.ComputeHash(inputStream);
				}
				break;
			}
			}
		}
		if (array != null)
		{
			StringBuilder stringBuilder = new StringBuilder(array.Length);
			byte[] array2 = array;
			foreach (byte b in array2)
			{
				stringBuilder.Append(b.ToString("X2", CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString().ToUpperInvariant();
		}
		return string.Empty;
	}

	public static void ExportEncryptedFileRaw(string fileName, Stream outputStream)
	{
		ImportExportEncryptedFileDirectoryRawCore(isExport: true, isFolder: false, outputStream, fileName, PathFormat.RelativePath, overwriteHidden: false);
	}

	public static void ExportEncryptedFileRaw(string fileName, Stream outputStream, PathFormat pathFormat)
	{
		ImportExportEncryptedFileDirectoryRawCore(isExport: true, isFolder: false, outputStream, fileName, pathFormat, overwriteHidden: false);
	}

	public static void ImportEncryptedFileRaw(Stream inputStream, string destinationFilePath)
	{
		ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: false, inputStream, destinationFilePath, PathFormat.RelativePath, overwriteHidden: false);
	}

	public static void ImportEncryptedFileRaw(Stream inputStream, string destinationFilePath, PathFormat pathFormat)
	{
		ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: false, inputStream, destinationFilePath, pathFormat, overwriteHidden: false);
	}

	public static void ImportEncryptedFileRaw(Stream inputStream, string destinationFilePath, bool overwriteHidden)
	{
		ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: false, inputStream, destinationFilePath, PathFormat.RelativePath, overwriteHidden);
	}

	public static void ImportEncryptedFileRaw(Stream inputStream, string destinationFilePath, bool overwriteHidden, PathFormat pathFormat)
	{
		ImportExportEncryptedFileDirectoryRawCore(isExport: false, isFolder: false, inputStream, destinationFilePath, pathFormat, overwriteHidden);
	}

	internal static void ImportExportEncryptedFileDirectoryRawCore(bool isExport, bool isFolder, Stream stream, string destinationPath, PathFormat pathFormat, bool overwriteHidden)
	{
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(null, destinationPath, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.TrimEnd);
		NativeMethods.EncryptedFileRawMode encryptedFileRawMode = ((!isExport) ? NativeMethods.EncryptedFileRawMode.CreateForImport : NativeMethods.EncryptedFileRawMode.CreateForExport);
		if (isFolder)
		{
			encryptedFileRawMode |= NativeMethods.EncryptedFileRawMode.CreateForDir;
		}
		if (overwriteHidden)
		{
			encryptedFileRawMode |= NativeMethods.EncryptedFileRawMode.OverwriteHidden;
		}
		uint num = NativeMethods.OpenEncryptedFileRawW(extendedLengthPathCore, encryptedFileRawMode, out var pvContext);
		try
		{
			if (num != 0)
			{
				NativeError.ThrowException(num, extendedLengthPathCore);
			}
			num = (isExport ? NativeMethods.ReadEncryptedFileRaw(delegate(IntPtr pbData, IntPtr pvCallbackContext, uint length)
			{
				try
				{
					byte[] array2 = new byte[length];
					Marshal.Copy(pbData, array2, 0, (int)length);
					stream.Write(array2, 0, (int)length);
				}
				catch (Exception e2)
				{
					return Marshal.GetHRForException(e2) & 0xFFFF;
				}
				return 0;
			}, IntPtr.Zero, pvContext) : NativeMethods.WriteEncryptedFileRaw(delegate(IntPtr pbData, IntPtr pvCallbackContext, ref uint length)
			{
				try
				{
					byte[] array = new byte[length];
					length = (uint)stream.Read(array, 0, (int)length);
					if (length == 0)
					{
						return 0;
					}
					Marshal.Copy(array, 0, pbData, (int)length);
				}
				catch (Exception e)
				{
					return Marshal.GetHRForException(e) & 0xFFFF;
				}
				return 0;
			}, IntPtr.Zero, pvContext));
			if (num != 0)
			{
				NativeError.ThrowException(num, extendedLengthPathCore);
			}
		}
		finally
		{
			pvContext?.Dispose();
		}
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreams(string path)
	{
		return EnumerateAlternateDataStreamsCore(null, isFolder: false, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreams(string path, PathFormat pathFormat)
	{
		return EnumerateAlternateDataStreamsCore(null, isFolder: false, path, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreamsTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateAlternateDataStreamsCore(transaction, isFolder: false, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreamsTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return EnumerateAlternateDataStreamsCore(transaction, isFolder: false, path, pathFormat);
	}

	internal static IEnumerable<AlternateDataStreamInfo> EnumerateAlternateDataStreamsCore(KernelTransaction transaction, bool isFolder, string path, PathFormat pathFormat)
	{
		using SafeGlobalMemoryBufferHandle buffer = new SafeGlobalMemoryBufferHandle(Marshal.SizeOf(typeof(NativeMethods.WIN32_FIND_STREAM_DATA)));
		string pathLp = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		using SafeFindFileHandle safeHandle = ((transaction == null) ? NativeMethods.FindFirstStreamW(pathLp, NativeMethods.STREAM_INFO_LEVELS.FindStreamInfoStandard, buffer, 0) : NativeMethods.FindFirstStreamTransactedW(pathLp, NativeMethods.STREAM_INFO_LEVELS.FindStreamInfoStandard, buffer, 0, transaction.SafeHandle));
		int lastWin32Error = Marshal.GetLastWin32Error();
		bool flag = lastWin32Error == 38L;
		if (!NativeMethods.IsValidHandle(safeHandle, throwException: false))
		{
			if (flag)
			{
				yield break;
			}
			NativeError.ThrowException(lastWin32Error, pathLp);
		}
		while (true)
		{
			yield return new AlternateDataStreamInfo(pathLp, buffer.PtrToStructure<NativeMethods.WIN32_FIND_STREAM_DATA>(0));
			bool num = NativeMethods.FindNextStreamW(safeHandle, buffer);
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!num)
			{
				if (lastWin32Error == 38L)
				{
					break;
				}
				NativeError.ThrowException(lastWin32Error, isFolder, pathLp);
			}
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlinks")]
	public static IEnumerable<string> EnumerateHardlinks(string path, PathFormat pathFormat)
	{
		return EnumerateHardlinksCore(null, path, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlinks")]
	public static IEnumerable<string> EnumerateHardlinks(string path)
	{
		return EnumerateHardlinksCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlinks")]
	public static IEnumerable<string> EnumerateHardlinksTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return EnumerateHardlinksCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlinks")]
	public static IEnumerable<string> EnumerateHardlinksTransacted(KernelTransaction transaction, string path)
	{
		return EnumerateHardlinksCore(transaction, path, PathFormat.RelativePath);
	}

	internal static IEnumerable<string> EnumerateHardlinksCore(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		uint stringLength = 32700u;
		StringBuilder builder = new StringBuilder(32700);
		while (true)
		{
			using SafeFindFileHandle safeHandle = ((transaction == null) ? NativeMethods.FindFirstFileNameW(extendedLengthPathCore, 0u, out stringLength, builder) : NativeMethods.FindFirstFileNameTransactedW(extendedLengthPathCore, 0u, out stringLength, builder, transaction.SafeHandle));
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (NativeMethods.IsValidHandle(safeHandle, throwException: false))
			{
				goto IL_00f2;
			}
			uint num = (uint)lastWin32Error;
			if (num == 234)
			{
				builder = new StringBuilder((int)stringLength);
				continue;
			}
			NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
			goto IL_00f2;
			IL_00f2:
			yield return builder.ToString();
			while (true)
			{
				if (!NativeMethods.FindNextFileNameW(safeHandle, out stringLength, builder))
				{
					lastWin32Error = Marshal.GetLastWin32Error();
					switch (lastWin32Error)
					{
					default:
						NativeError.ThrowException(lastWin32Error);
						break;
					case 234:
						builder = new StringBuilder((int)stringLength);
						break;
					case 38:
						yield break;
					}
				}
				else
				{
					yield return builder.ToString();
				}
			}
		}
	}

	[Obsolete("Methods with SymbolicLinkTarget parameter are obsolete.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLink(string symlinkFileName, string targetFileName, SymbolicLinkTarget targetType)
	{
		CreateSymbolicLinkCore(null, symlinkFileName, targetFileName, targetType, PathFormat.RelativePath);
	}

	[Obsolete("Methods with SymbolicLinkTarget parameter are obsolete.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLink(string symlinkFileName, string targetFileName, SymbolicLinkTarget targetType, PathFormat pathFormat)
	{
		CreateSymbolicLinkCore(null, symlinkFileName, targetFileName, targetType, pathFormat);
	}

	[Obsolete("Methods with SymbolicLinkTarget parameter are obsolete.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLinkTransacted(KernelTransaction transaction, string symlinkFileName, string targetFileName, SymbolicLinkTarget targetType)
	{
		CreateSymbolicLinkCore(transaction, symlinkFileName, targetFileName, targetType, PathFormat.RelativePath);
	}

	[Obsolete("Methods with SymbolicLinkTarget parameter are obsolete.")]
	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLinkTransacted(KernelTransaction transaction, string symlinkFileName, string targetFileName, SymbolicLinkTarget targetType, PathFormat pathFormat)
	{
		CreateSymbolicLinkCore(transaction, symlinkFileName, targetFileName, targetType, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLink(string symlinkFileName, string targetFileName)
	{
		CreateSymbolicLinkCore(null, symlinkFileName, targetFileName, SymbolicLinkTarget.File, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	[SecurityCritical]
	public static void CreateSymbolicLink(string symlinkFileName, string targetFileName, PathFormat pathFormat)
	{
		CreateSymbolicLinkCore(null, symlinkFileName, targetFileName, SymbolicLinkTarget.File, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLinkTransacted(KernelTransaction transaction, string symlinkFileName, string targetFileName)
	{
		CreateSymbolicLinkCore(transaction, symlinkFileName, targetFileName, SymbolicLinkTarget.File, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "symlink")]
	public static void CreateSymbolicLinkTransacted(KernelTransaction transaction, string symlinkFileName, string targetFileName, PathFormat pathFormat)
	{
		CreateSymbolicLinkCore(transaction, symlinkFileName, targetFileName, SymbolicLinkTarget.File, pathFormat);
	}

	[SecurityCritical]
	internal static void CreateSymbolicLinkCore(KernelTransaction transaction, string symlinkFileName, string targetFileName, SymbolicLinkTarget targetType, PathFormat pathFormat)
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		if (pathFormat != PathFormat.LongFullPath)
		{
			symlinkFileName = Path.GetExtendedLengthPathCore(transaction, symlinkFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			targetFileName = Path.GetExtendedLengthPathCore(transaction, targetFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		}
		targetFileName = Path.GetRegularPathCore(targetFileName, GetFullPathOptions.None, allowEmpty: false);
		if (targetType == SymbolicLinkTarget.Directory)
		{
			ThrowIOExceptionIfFsoExist(transaction, isFolder: false, targetFileName, pathFormat);
			ThrowIOExceptionIfFsoExist(transaction, isFolder: false, symlinkFileName, pathFormat);
		}
		else
		{
			ThrowIOExceptionIfFsoExist(transaction, isFolder: true, targetFileName, pathFormat);
			ThrowIOExceptionIfFsoExist(transaction, isFolder: true, symlinkFileName, pathFormat);
		}
		bool num = ((transaction == null) ? NativeMethods.CreateSymbolicLinkW(symlinkFileName, targetFileName, targetType) : NativeMethods.CreateSymbolicLinkTransactedW(symlinkFileName, targetFileName, targetType, transaction.SafeHandle));
		uint lastWin32Error = (uint)Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, targetFileName, symlinkFileName);
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlink")]
	public static void CreateHardlink(string fileName, string existingFileName)
	{
		CreateHardlinkCore(null, fileName, existingFileName, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlink")]
	public static void CreateHardlink(string fileName, string existingFileName, PathFormat pathFormat)
	{
		CreateHardlinkCore(null, fileName, existingFileName, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlink")]
	public static void CreateHardlinkTransacted(KernelTransaction transaction, string fileName, string existingFileName)
	{
		CreateHardlinkCore(transaction, fileName, existingFileName, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlink")]
	public static void CreateHardlinkTransacted(KernelTransaction transaction, string fileName, string existingFileName, PathFormat pathFormat)
	{
		CreateHardlinkCore(transaction, fileName, existingFileName, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Hardlink")]
	internal static void CreateHardlinkCore(KernelTransaction transaction, string fileName, string existingFileName, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath)
		{
			fileName = Path.GetExtendedLengthPathCore(transaction, fileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			existingFileName = Path.GetExtendedLengthPathCore(transaction, existingFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		}
		if (!((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.CreateHardLinkW(fileName, existingFileName, IntPtr.Zero) : NativeMethods.CreateHardLinkTransactedW(fileName, existingFileName, IntPtr.Zero, transaction.SafeHandle)))
		{
			uint lastWin32Error = (uint)Marshal.GetLastWin32Error();
			if (lastWin32Error == 1)
			{
				throw new NotSupportedException(Resources.HardLinks_Not_Supported);
			}
			NativeError.ThrowException(lastWin32Error, existingFileName, fileName);
		}
	}

	[SecurityCritical]
	public static void Compress(string path)
	{
		Device.ToggleCompressionCore(null, path, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Compress(string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(null, path, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path)
	{
		Device.ToggleCompressionCore(transaction, path, compress: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CompressTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		Device.ToggleCompressionCore(transaction, path, compress: true, pathFormat);
	}

	[SecurityCritical]
	public static void Delete(string path)
	{
		DeleteFileCore(null, path, ignoreReadOnly: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Delete(string path, bool ignoreReadOnly, PathFormat pathFormat)
	{
		DeleteFileCore(null, path, ignoreReadOnly, pathFormat);
	}

	[SecurityCritical]
	public static void Delete(string path, bool ignoreReadOnly)
	{
		DeleteFileCore(null, path, ignoreReadOnly, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path)
	{
		DeleteFileCore(transaction, path, ignoreReadOnly: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path, bool ignoreReadOnly, PathFormat pathFormat)
	{
		DeleteFileCore(transaction, path, ignoreReadOnly, pathFormat);
	}

	[SecurityCritical]
	public static void DeleteTransacted(KernelTransaction transaction, string path, bool ignoreReadOnly)
	{
		DeleteFileCore(transaction, path, ignoreReadOnly, PathFormat.RelativePath);
	}

	[SecurityCritical]
	internal static void DeleteFileCore(KernelTransaction transaction, string path, bool ignoreReadOnly, PathFormat pathFormat)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (pathFormat == PathFormat.RelativePath)
		{
			Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
		}
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		while (!((transaction != null && NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.DeleteFileTransactedW(extendedLengthPathCore, transaction.SafeHandle) : NativeMethods.DeleteFileW(extendedLengthPathCore)))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			switch (lastWin32Error)
			{
			case 5:
			{
				NativeMethods.WIN32_FILE_ATTRIBUTE_DATA win32AttrData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
				int num = FillAttributeInfoCore(transaction, extendedLengthPathCore, ref win32AttrData, tryAgain: false, returnErrorOnNotFound: true);
				if (!IsDirectory(win32AttrData.dwFileAttributes))
				{
					if (IsReadOnly(win32AttrData.dwFileAttributes))
					{
						if (!ignoreReadOnly)
						{
							throw new FileReadOnlyException(extendedLengthPathCore);
						}
						break;
					}
					if (num == 0L)
					{
						NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
					}
					goto default;
				}
				throw new UnauthorizedAccessException(string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
				{
					87u,
					string.Format(CultureInfo.InvariantCulture, Resources.Target_File_Is_A_Directory, new object[1] { extendedLengthPathCore })
				}));
			}
			case 32:
				NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				goto default;
			case 2:
				return;
			case 3:
				NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				return;
			default:
				NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				return;
			}
			SetAttributesCore(transaction, isFolder: false, extendedLengthPathCore, FileAttributes.Normal, PathFormat.LongFullPath);
		}
	}

	[SecurityCritical]
	public static void Decrypt(string path)
	{
		EncryptDecryptFileCore(isFolder: false, path, encrypt: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Decrypt(string path, PathFormat pathFormat)
	{
		EncryptDecryptFileCore(isFolder: false, path, encrypt: false, pathFormat);
	}

	[SecurityCritical]
	public static void Encrypt(string path)
	{
		EncryptDecryptFileCore(isFolder: false, path, encrypt: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Encrypt(string path, PathFormat pathFormat)
	{
		EncryptDecryptFileCore(isFolder: false, path, encrypt: true, pathFormat);
	}

	[SecurityCritical]
	internal static void EncryptDecryptFileCore(bool isFolder, string path, bool encrypt, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath)
		{
			path = Path.GetExtendedLengthPathCore(null, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			pathFormat = PathFormat.LongFullPath;
		}
		NativeMethods.WIN32_FILE_ATTRIBUTE_DATA attributesExCore = GetAttributesExCore<NativeMethods.WIN32_FILE_ATTRIBUTE_DATA>(null, path, pathFormat, returnErrorOnNotFound: true);
		bool num = (attributesExCore.dwFileAttributes & FileAttributes.ReadOnly) != 0;
		if (num)
		{
			SetAttributesCore(null, isFolder, path, attributesExCore.dwFileAttributes &= ~FileAttributes.ReadOnly, pathFormat);
		}
		bool flag = (encrypt ? NativeMethods.EncryptFileW(path) : NativeMethods.DecryptFileW(path, 0u));
		int num2 = Marshal.GetLastWin32Error();
		if (num)
		{
			bool num3 = (attributesExCore.dwFileAttributes & FileAttributes.Hidden) != 0;
			attributesExCore = GetAttributesExCore<NativeMethods.WIN32_FILE_ATTRIBUTE_DATA>(null, path, pathFormat, returnErrorOnNotFound: true);
			attributesExCore.dwFileAttributes |= FileAttributes.ReadOnly;
			if (num3)
			{
				attributesExCore.dwFileAttributes |= FileAttributes.Hidden;
			}
			SetAttributesCore(null, isFolder, path, attributesExCore.dwFileAttributes, pathFormat);
		}
		if (flag)
		{
			return;
		}
		switch (num2)
		{
		default:
			if (num2 == 2L && isFolder)
			{
				num2 = 3;
			}
			NativeError.ThrowException(num2, path);
			break;
		case 6009:
			if (IsDirectory(attributesExCore.dwFileAttributes))
			{
				throw new DirectoryReadOnlyException(path);
			}
			throw new FileReadOnlyException(path);
		case 5:
			if (!string.Equals("NTFS", new DriveInfo(path).DriveFormat, StringComparison.OrdinalIgnoreCase))
			{
				throw new NotSupportedException(string.Format(CultureInfo.InvariantCulture, "The drive does not support NTFS encryption: [{0}]", new object[1] { Path.GetPathRoot(path, checkInvalidPathChars: false) }));
			}
			break;
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamWriter CreateText(string path)
	{
		return CreateTextCore(null, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamWriter CreateText(string path, PathFormat pathFormat)
	{
		return CreateTextCore(null, path, NativeMethods.DefaultFileEncoding, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamWriter CreateText(string path, Encoding encoding, PathFormat pathFormat)
	{
		return CreateTextCore(null, path, encoding, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamWriter CreateTextTransacted(KernelTransaction transaction, string path)
	{
		return CreateTextCore(transaction, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamWriter CreateTextTransacted(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		return CreateTextCore(transaction, path, encoding, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	internal static StreamWriter CreateTextCore(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		return new StreamWriter(CreateFileStreamCore(transaction, path, ExtendedFileAttributes.SequentialScan, null, FileMode.Create, FileAccess.Write, FileShare.Read, 4096, pathFormat), encoding);
	}

	[SecurityCritical]
	public static void Copy(string sourcePath, string destinationPath)
	{
		CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, CopyOptions.FailIfExists, null, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void Copy(string sourcePath, string destinationPath, bool overwrite)
	{
		CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, CopyOptions.FailIfExists, null, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, bool overwrite, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, CopyOptions.FailIfExists, null, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, CopyOptions.FailIfExists, null, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool overwrite)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool overwrite, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, (!overwrite) ? CopyOptions.FailIfExists : CopyOptions.None, null, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult Copy(string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(null, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, null, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, null, null, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates: false, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, progressHandler, userProgressData, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static CopyMoveResult CopyTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions copyOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, PathFormat pathFormat)
	{
		return CopyMoveCore(transaction, driveChecked: false, isFolder: false, sourcePath, destinationPath, copyOptions, null, preserveDates, progressHandler, userProgressData, null, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal static CopyMoveResult CopyMoveCore(KernelTransaction transaction, bool driveChecked, bool isFolder, string sourcePath, string destinationPath, CopyOptions? copyOptions, MoveOptions? moveOptions, bool preserveDates, CopyMoveProgressRoutine progressHandler, object userProgressData, CopyMoveResult copyMoveResult, PathFormat pathFormat)
	{
		ValidateAndUpdatePathsAndOptions(transaction, sourcePath, destinationPath, copyOptions, moveOptions, pathFormat, out var sourcePathLp, out var destinationPathLp, out var isCopy, out var emulateMove, out var delayUntilReboot, out var _);
		if (!driveChecked)
		{
			if (!sourcePathLp.StartsWith(Path.GlobalRootPrefix, StringComparison.OrdinalIgnoreCase))
			{
				Directory.ExistsDriveOrFolderOrFile(transaction, sourcePathLp, isFolder, 0, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: false);
			}
			if (!delayUntilReboot)
			{
				Directory.ExistsDriveOrFolderOrFile(transaction, destinationPathLp, isFolder, 0, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: false);
			}
		}
		NativeMethods.NativeCopyMoveProgressRoutine routine = ((progressHandler != null) ? ((NativeMethods.NativeCopyMoveProgressRoutine)((long totalFileSize, long totalBytesTransferred, long streamSize, long streamBytesTransferred, uint streamNumber, CopyMoveProgressCallbackReason callbackReason, IntPtr sourceFile, IntPtr destinationFile, IntPtr data) => progressHandler(totalFileSize, totalBytesTransferred, streamSize, streamBytesTransferred, (int)streamNumber, callbackReason, userProgressData))) : null);
		CopyMoveResult copyMoveResult2 = copyMoveResult ?? new CopyMoveResult(sourcePath, destinationPath, isCopy, isFolder, preserveDates, emulateMove);
		bool isMove = !isCopy;
		bool flag = (copyMoveResult == null && !isFolder) || copyMoveResult2.IsFile;
		preserveDates = preserveDates && isCopy && !isFolder;
		int lastError;
		do
		{
			copyMoveResult2.ErrorCode = 0;
			if (!CopyMoveNative(transaction, isMove, sourcePathLp, destinationPathLp, routine, copyOptions, moveOptions, out var _, out lastError))
			{
				copyMoveResult2.ErrorCode = lastError;
				copyMoveResult2.IsCanceled = lastError == 1235L;
				continue;
			}
			if (!isFolder)
			{
				copyMoveResult2.TotalFiles++;
			}
			if (flag)
			{
				copyMoveResult2.TotalBytes = GetSizeCore(transaction, null, delayUntilReboot ? sourcePathLp : destinationPathLp, PathFormat.LongFullPath);
			}
			if (preserveDates && !delayUntilReboot)
			{
				CopyTimestampsCore(transaction, isFolder: false, sourcePathLp, destinationPathLp, modifyReparsePoint: false, PathFormat.LongFullPath);
			}
			break;
		}
		while (!copyMoveResult2.IsCanceled && RestartCopyMoveOrThrowException(lastError, isFolder, isMove, transaction, sourcePathLp, destinationPathLp, moveOptions));
		if (flag)
		{
			copyMoveResult2._stopwatch.Stop();
		}
		return copyMoveResult2;
	}

	private static bool CopyMoveNative(KernelTransaction transaction, bool isMove, string sourcePathLp, string destinationPathLp, NativeMethods.NativeCopyMoveProgressRoutine routine, CopyOptions? copyOptions, MoveOptions? moveOptions, out bool cancel, out int lastError)
	{
		cancel = false;
		bool result = ((transaction != null && NativeMethods.IsAtLeastWindowsVista) ? (isMove ? NativeMethods.MoveFileTransactedW(sourcePathLp, destinationPathLp, routine, IntPtr.Zero, moveOptions.Value, transaction.SafeHandle) : NativeMethods.CopyFileTransactedW(sourcePathLp, destinationPathLp, routine, IntPtr.Zero, out cancel, copyOptions.Value, transaction.SafeHandle)) : (isMove ? NativeMethods.MoveFileWithProgressW(sourcePathLp, destinationPathLp, routine, IntPtr.Zero, moveOptions.Value) : NativeMethods.CopyFileExW(sourcePathLp, destinationPathLp, routine, IntPtr.Zero, out cancel, copyOptions.Value)));
		lastError = Marshal.GetLastWin32Error();
		return result;
	}

	private static bool RestartCopyMoveOrThrowException(int lastError, bool isFolder, bool isMove, KernelTransaction transaction, string sourcePathLp, string destinationPathLp, MoveOptions? moveOptions)
	{
		bool result = false;
		bool flag = ExistsCore(transaction, isFolder, sourcePathLp, PathFormat.LongFullPath);
		bool flag2 = ExistsCore(transaction, isFolder, destinationPathLp, PathFormat.LongFullPath);
		switch (lastError)
		{
		case 21:
			Directory.ExistsDriveOrFolderOrFile(transaction, sourcePathLp, isFolder: false, lastError, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: false);
			Directory.ExistsDriveOrFolderOrFile(transaction, destinationPathLp, isFolder: false, lastError, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: false);
			break;
		case 2:
		case 3:
			if (!flag)
			{
				Directory.ExistsDriveOrFolderOrFile(transaction, sourcePathLp, isFolder, lastError, throwIfDriveNotExists: false, throwIfFolderOrFileNotExists: true);
			}
			if (!flag2)
			{
				Directory.ExistsDriveOrFolderOrFile(transaction, destinationPathLp, isFolder, lastError, throwIfDriveNotExists: false, throwIfFolderOrFileNotExists: true);
			}
			break;
		default:
		{
			NativeMethods.WIN32_FILE_ATTRIBUTE_DATA win32AttrData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
			FillAttributeInfoCore(transaction, destinationPathLp, ref win32AttrData, tryAgain: false, returnErrorOnNotFound: false);
			bool flag3;
			if ((flag3 = IsDirectory(win32AttrData.dwFileAttributes)) && flag2)
			{
				NativeError.ThrowException(183u, destinationPathLp);
			}
			if (isMove && !flag)
			{
				NativeError.ThrowException(isFolder ? 3u : 2u, sourcePathLp);
			}
			string writePath = destinationPathLp;
			if (!isFolder)
			{
				using SafeFileHandle safeFileHandle = CreateFileCore(transaction, false, sourcePathLp, ExtendedFileAttributes.Normal, null, FileMode.Open, (FileSystemRights)0, FileShare.Read, checkPath: false, continueOnException: false, PathFormat.LongFullPath);
				if (safeFileHandle != null)
				{
					writePath = sourcePathLp;
				}
			}
			if (lastError == 5L)
			{
				if (flag2 && !isFolder && flag3)
				{
					NativeError.ThrowException(lastError, (string)null, string.Format(CultureInfo.InvariantCulture, Resources.Target_File_Is_A_Directory, new object[1] { destinationPathLp }));
				}
				if (isMove && IsReadOnlyOrHidden(win32AttrData.dwFileAttributes))
				{
					if (CanOverwrite(moveOptions))
					{
						SetAttributesCore(transaction, isFolder, destinationPathLp, FileAttributes.Normal, PathFormat.LongFullPath);
						result = true;
						break;
					}
					throw new FileReadOnlyException(destinationPathLp);
				}
			}
			NativeError.ThrowException(lastError, (string)null, writePath);
			break;
		}
		case 80:
		case 183:
			lastError = (isFolder ? 183 : 80);
			NativeError.ThrowException(lastError, (string)null, destinationPathLp);
			break;
		}
		return result;
	}

	[SuppressMessage("Microsoft.Performance", "CA1820:TestForEmptyStringsUsingStringLength")]
	internal static void ValidateAndUpdatePathsAndOptions(KernelTransaction transaction, string sourcePath, string destinationPath, CopyOptions? copyOptions, MoveOptions? moveOptions, PathFormat pathFormat, out string sourcePathLp, out string destinationPathLp, out bool isCopy, out bool emulateMove, out bool delayUntilReboot, out bool deleteOnStartup)
	{
		if (sourcePath == string.Empty)
		{
			throw new ArgumentException("Empty sourcePath name is not legal.");
		}
		if (destinationPath == string.Empty)
		{
			throw new ArgumentException("Empty destinationPath name is not legal.");
		}
		if (sourcePath != null && sourcePath.Equals(destinationPath, StringComparison.Ordinal))
		{
			NativeError.ThrowException(143u, destinationPath);
		}
		sourcePathLp = sourcePath;
		destinationPathLp = destinationPath;
		isCopy = IsCopyAction(copyOptions, moveOptions);
		bool flag = !isCopy;
		emulateMove = false;
		delayUntilReboot = flag && VerifyDelayUntilReboot(sourcePathLp, moveOptions, pathFormat);
		deleteOnStartup = delayUntilReboot && destinationPath == null;
		if (pathFormat != PathFormat.LongFullPath)
		{
			if (Utils.IsNullOrWhiteSpace(sourcePath))
			{
				throw new ArgumentNullException("sourcePath");
			}
			if (!delayUntilReboot && Utils.IsNullOrWhiteSpace(destinationPath))
			{
				throw new ArgumentNullException("destinationPath");
			}
			if (!sourcePath.StartsWith(Path.GlobalRootPrefix, StringComparison.OrdinalIgnoreCase))
			{
				Path.CheckSupportedPathFormat(sourcePath, checkInvalidPathChars: true, checkAdditional: true);
				sourcePathLp = Path.GetExtendedLengthPathCore(transaction, sourcePath, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			}
			if (!deleteOnStartup)
			{
				Path.CheckSupportedPathFormat(destinationPath, checkInvalidPathChars: true, checkAdditional: true);
				destinationPathLp = Path.GetExtendedLengthPathCore(transaction, destinationPath, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			}
		}
	}

	private static bool VerifyDelayUntilReboot(string sourcePath, MoveOptions? moveOptions, PathFormat pathFormat)
	{
		bool num = HasDelayUntilReboot(moveOptions);
		if (num)
		{
			if (AllowEmulate(moveOptions))
			{
				throw new ArgumentException(Resources.MoveOptionsDelayUntilReboot_Not_Allowed_With_MoveOptionsCopyAllowed, "moveOptions");
			}
			if (Path.IsUncPathCore(sourcePath, pathFormat != PathFormat.LongFullPath, checkInvalidPathChars: false))
			{
				throw new ArgumentException(Resources.MoveOptionsDelayUntilReboot_Not_Allowed_With_NetworkPath, "moveOptions");
			}
		}
		return num;
	}

	public static Collection<Process> GetProcessForFileLock(string filePath)
	{
		return GetProcessForFileLockCore(null, new Collection<string>(new string[1] { filePath }), PathFormat.RelativePath);
	}

	public static Collection<Process> GetProcessForFileLock(string filePath, PathFormat pathFormat)
	{
		return GetProcessForFileLockCore(null, new Collection<string>(new string[1] { filePath }), pathFormat);
	}

	public static Collection<Process> GetProcessForFileLock(Collection<string> filePaths)
	{
		return GetProcessForFileLockCore(null, filePaths, PathFormat.RelativePath);
	}

	public static Collection<Process> GetProcessForFileLock(Collection<string> filePaths, PathFormat pathFormat)
	{
		return GetProcessForFileLockCore(null, filePaths, pathFormat);
	}

	public static Collection<Process> GetProcessForFileLockTransacted(KernelTransaction transaction, string filePath)
	{
		return GetProcessForFileLockCore(transaction, new Collection<string>(new string[1] { filePath }), PathFormat.RelativePath);
	}

	public static Collection<Process> GetProcessForFileLockTransacted(KernelTransaction transaction, string filePath, PathFormat pathFormat)
	{
		return GetProcessForFileLockCore(transaction, new Collection<string>(new string[1] { filePath }), pathFormat);
	}

	public static Collection<Process> GetProcessForFileLockTransacted(KernelTransaction transaction, Collection<string> filePaths)
	{
		return GetProcessForFileLockCore(transaction, filePaths, PathFormat.RelativePath);
	}

	public static Collection<Process> GetProcessForFileLockTransacted(KernelTransaction transaction, Collection<string> filePaths, PathFormat pathFormat)
	{
		return GetProcessForFileLockCore(transaction, filePaths, pathFormat);
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "Alphaleonis.Win32.Filesystem.NativeMethods.RmEndSession(System.UInt32)")]
	internal static Collection<Process> GetProcessForFileLockCore(KernelTransaction transaction, Collection<string> filePaths, PathFormat pathFormat)
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		if (filePaths == null)
		{
			throw new ArgumentNullException("filePaths");
		}
		if (filePaths.Count == 0)
		{
			throw new ArgumentOutOfRangeException("filePaths", "No paths specified.");
		}
		bool num = pathFormat == PathFormat.LongFullPath;
		Collection<string> collection = (num ? new Collection<string>(filePaths) : new Collection<string>());
		if (!num)
		{
			foreach (string filePath in filePaths)
			{
				collection.Add(Path.GetExtendedLengthPathCore(transaction, filePath, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator));
			}
		}
		uint pSessionHandle;
		bool num2 = NativeMethods.RmStartSession(out pSessionHandle, 0, Guid.NewGuid().ToString()) == 0L;
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num2)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		Collection<Process> collection2 = new Collection<Process>();
		try
		{
			uint pnProcInfoNeeded = (uint)Process.GetProcesses().Length;
			uint lpdwRebootReasons = 0u;
			bool num3 = NativeMethods.RmRegisterResources(pSessionHandle, (uint)collection.Count, collection.ToArray(), 0u, null, 0u, null) == 0L;
			lastWin32Error = Marshal.GetLastWin32Error();
			if (!num3)
			{
				NativeError.ThrowException(lastWin32Error);
			}
			NativeMethods.RM_PROCESS_INFO[] array;
			uint pnProcInfo;
			do
			{
				array = new NativeMethods.RM_PROCESS_INFO[pnProcInfoNeeded];
				pnProcInfo = pnProcInfoNeeded;
				lastWin32Error = NativeMethods.RmGetList(pSessionHandle, out pnProcInfoNeeded, ref pnProcInfo, array, ref lpdwRebootReasons);
			}
			while (lastWin32Error == 234L);
			if (lastWin32Error != 0L)
			{
				NativeError.ThrowException(lastWin32Error);
			}
			for (int i = 0; i < pnProcInfo; i++)
			{
				try
				{
					collection2.Add(Process.GetProcessById(array[i].Process.dwProcessId));
				}
				catch (ArgumentException)
				{
				}
			}
		}
		finally
		{
			NativeMethods.RmEndSession(pSessionHandle);
		}
		if (collection2.Count != 0)
		{
			return collection2;
		}
		return null;
	}

	[SecurityCritical]
	public static bool IsLocked(string path)
	{
		return IsLockedCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool IsLocked(string path, PathFormat pathFormat)
	{
		return IsLockedCore(null, path, pathFormat);
	}

	[SecurityCritical]
	public static bool IsLockedTransacted(KernelTransaction transaction, string path)
	{
		return IsLockedCore(transaction, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool IsLockedTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return IsLockedCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	internal static bool IsLockedCore(KernelTransaction transaction, string filePath, PathFormat pathFormat)
	{
		try
		{
			using (OpenCore(transaction, filePath, FileMode.Open, FileAccess.Read, FileShare.None, ExtendedFileAttributes.Normal, null, null, pathFormat))
			{
			}
		}
		catch (IOException e)
		{
			int num = Marshal.GetHRForException(e) & 0xFFFF;
			if (num != 32L && num != 33L)
			{
				throw;
			}
			return true;
		}
		catch (Exception e2)
		{
			NativeError.ThrowException(Marshal.GetHRForException(e2) & 0xFFFF, filePath);
		}
		return false;
	}

	[SecurityCritical]
	[Obsolete("Use new method name: CopyTimestamps")]
	public static void TransferTimestamps(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		CopyTimestamps(sourcePath, destinationPath, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Use new method name: CopyTimestamps")]
	public static void TransferTimestamps(string sourcePath, string destinationPath)
	{
		CopyTimestamps(sourcePath, destinationPath, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[Obsolete("Use new method name: CopyTimestampsTransacted")]
	public static void TransferTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		CopyTimestampsTransacted(transaction, sourcePath, destinationPath, pathFormat);
	}

	[SecurityCritical]
	[Obsolete("Use new method name: CopyTimestampsTransacted")]
	public static void TransferTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		CopyTimestampsTransacted(transaction, sourcePath, destinationPath, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath)
	{
		CopyTimestampsCore(null, isFolder: false, sourcePath, destinationPath, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		CopyTimestampsCore(null, isFolder: false, sourcePath, destinationPath, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath, bool modifyReparsePoint)
	{
		CopyTimestampsCore(null, isFolder: false, sourcePath, destinationPath, modifyReparsePoint, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestamps(string sourcePath, string destinationPath, bool modifyReparsePoint, PathFormat pathFormat)
	{
		CopyTimestampsCore(null, isFolder: false, sourcePath, destinationPath, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath)
	{
		CopyTimestampsCore(transaction, isFolder: false, sourcePath, destinationPath, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, PathFormat pathFormat)
	{
		CopyTimestampsCore(transaction, isFolder: false, sourcePath, destinationPath, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool modifyReparsePoint)
	{
		CopyTimestampsCore(transaction, isFolder: false, sourcePath, destinationPath, modifyReparsePoint, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void CopyTimestampsTransacted(KernelTransaction transaction, string sourcePath, string destinationPath, bool modifyReparsePoint, PathFormat pathFormat)
	{
		CopyTimestampsCore(transaction, isFolder: false, sourcePath, destinationPath, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	internal static void CopyTimestampsCore(KernelTransaction transaction, bool isFolder, string sourcePath, string destinationPath, bool modifyReparsePoint, PathFormat pathFormat)
	{
		NativeMethods.WIN32_FILE_ATTRIBUTE_DATA attributesExCore = GetAttributesExCore<NativeMethods.WIN32_FILE_ATTRIBUTE_DATA>(transaction, sourcePath, pathFormat, returnErrorOnNotFound: true);
		SetFsoDateTimeCore(transaction, isFolder, destinationPath, DateTime.FromFileTimeUtc(attributesExCore.ftCreationTime), DateTime.FromFileTimeUtc(attributesExCore.ftLastAccessTime), DateTime.FromFileTimeUtc(attributesExCore.ftLastWriteTime), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllLines(string path, IEnumerable<string> contents)
	{
		WriteAppendAllLinesCore(null, path, contents, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(null, path, contents, encoding, isAppend: true, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllLines(string path, IEnumerable<string> contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, contents, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, contents, encoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents)
	{
		WriteAppendAllLinesCore(transaction, path, contents, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(transaction, path, contents, encoding, isAppend: true, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, contents, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, contents, encoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllText(string path, string contents)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllText(string path, string contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, encoding, isAppend: true, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllText(string path, string contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllText(string path, string contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, encoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllTextTransacted(KernelTransaction transaction, string path, string contents)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllTextTransacted(KernelTransaction transaction, string path, string contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, encoding, isAppend: true, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void AppendAllTextTransacted(KernelTransaction transaction, string path, string contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, NativeMethods.DefaultFileEncoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void AppendAllTextTransacted(KernelTransaction transaction, string path, string contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, encoding, isAppend: true, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, IEnumerable<string> contents)
	{
		WriteAppendAllLinesCore(null, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, string[] contents)
	{
		WriteAppendAllLinesCore(null, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(null, path, contents, encoding, isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, string[] contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(null, path, contents, encoding, isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, IEnumerable<string> contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, string[] contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, contents, encoding, isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLines(string path, string[] contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, contents, encoding, isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents)
	{
		WriteAppendAllLinesCore(transaction, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, string[] contents)
	{
		WriteAppendAllLinesCore(transaction, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(transaction, path, contents, encoding, isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, string[] contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(transaction, path, contents, encoding, isAppend: false, addNewLine: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, string[] contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, contents, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, IEnumerable<string> contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, contents, encoding, isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllLinesTransacted(KernelTransaction transaction, string path, string[] contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, contents, encoding, isAppend: false, addNewLine: true, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllText(string path, string contents)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllText(string path, string contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, encoding, isAppend: false, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllText(string path, string contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllText(string path, string contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(null, path, new string[1] { contents }, encoding, isAppend: false, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents, Encoding encoding)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, encoding, isAppend: false, addNewLine: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), isAppend: false, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents, Encoding encoding, PathFormat pathFormat)
	{
		WriteAppendAllLinesCore(transaction, path, new string[1] { contents }, encoding, isAppend: false, addNewLine: false, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Disposing is controlled.")]
	internal static void WriteAppendAllLinesCore(KernelTransaction transaction, string path, IEnumerable<string> contents, Encoding encoding, bool isAppend, bool addNewLine, PathFormat pathFormat)
	{
		if (contents == null)
		{
			throw new ArgumentNullException("contents");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		using FileStream fileStream = OpenCore(transaction, path, isAppend ? FileMode.OpenOrCreate : FileMode.Create, FileSystemRights.AppendData, FileShare.ReadWrite, ExtendedFileAttributes.Normal, null, null, pathFormat);
		if (isAppend)
		{
			fileStream.Seek(0L, SeekOrigin.End);
		}
		using StreamWriter streamWriter = new StreamWriter(fileStream, encoding);
		if (addNewLine)
		{
			foreach (string content in contents)
			{
				streamWriter.WriteLine(content);
			}
			return;
		}
		foreach (string content2 in contents)
		{
			streamWriter.Write(content2);
		}
	}

	[SecurityCritical]
	public static StreamWriter AppendText(string path)
	{
		return AppendTextCore(null, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static StreamWriter AppendText(string path, PathFormat pathFormat)
	{
		return AppendTextCore(null, path, NativeMethods.DefaultFileEncoding, pathFormat);
	}

	[SecurityCritical]
	public static StreamWriter AppendText(string path, Encoding encoding, PathFormat pathFormat)
	{
		return AppendTextCore(null, path, encoding, pathFormat);
	}

	[SecurityCritical]
	public static StreamWriter AppendText(string path, Encoding encoding)
	{
		return AppendTextCore(null, path, encoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static StreamWriter AppendTextTransacted(KernelTransaction transaction, string path)
	{
		return AppendTextCore(transaction, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static StreamWriter AppendTextTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return AppendTextCore(transaction, path, NativeMethods.DefaultFileEncoding, pathFormat);
	}

	[SecurityCritical]
	public static StreamWriter AppendTextTransacted(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		return AppendTextCore(transaction, path, encoding, pathFormat);
	}

	[SecurityCritical]
	public static StreamWriter AppendTextTransacted(KernelTransaction transaction, string path, Encoding encoding)
	{
		return AppendTextCore(transaction, path, encoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	internal static StreamWriter AppendTextCore(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		FileStream fileStream = OpenCore(transaction, path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, ExtendedFileAttributes.Normal, null, null, pathFormat);
		try
		{
			fileStream.Seek(0L, SeekOrigin.End);
			return new StreamWriter(fileStream, encoding);
		}
		catch (IOException)
		{
			fileStream.Close();
			throw;
		}
	}

	[SecurityCritical]
	public static FileStream Create(string path)
	{
		return CreateFileStreamCore(null, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Create(string path, int bufferSize)
	{
		return CreateFileStreamCore(null, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Create(string path, int bufferSize, FileOptions options)
	{
		return CreateFileStreamCore(null, path, (ExtendedFileAttributes)options, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity)
	{
		return CreateFileStreamCore(null, path, (ExtendedFileAttributes)options, fileSecurity, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Create(string path, PathFormat pathFormat)
	{
		return CreateFileStreamCore(null, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Create(string path, int bufferSize, PathFormat pathFormat)
	{
		return CreateFileStreamCore(null, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Create(string path, int bufferSize, FileOptions options, PathFormat pathFormat)
	{
		return CreateFileStreamCore(null, path, (ExtendedFileAttributes)options, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity fileSecurity, PathFormat pathFormat)
	{
		return CreateFileStreamCore(null, path, (ExtendedFileAttributes)options, fileSecurity, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, pathFormat);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path)
	{
		return CreateFileStreamCore(transaction, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path, int bufferSize)
	{
		return CreateFileStreamCore(transaction, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path, int bufferSize, FileOptions options)
	{
		return CreateFileStreamCore(transaction, path, (ExtendedFileAttributes)options, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path, int bufferSize, FileOptions options, FileSecurity fileSecurity)
	{
		return CreateFileStreamCore(transaction, path, (ExtendedFileAttributes)options, fileSecurity, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return CreateFileStreamCore(transaction, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, pathFormat);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path, int bufferSize, PathFormat pathFormat)
	{
		return CreateFileStreamCore(transaction, path, ExtendedFileAttributes.Normal, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, pathFormat);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path, int bufferSize, FileOptions options, PathFormat pathFormat)
	{
		return CreateFileStreamCore(transaction, path, (ExtendedFileAttributes)options, null, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, pathFormat);
	}

	[SecurityCritical]
	public static FileStream CreateTransacted(KernelTransaction transaction, string path, int bufferSize, FileOptions options, FileSecurity fileSecurity, PathFormat pathFormat)
	{
		return CreateFileStreamCore(transaction, path, (ExtendedFileAttributes)options, fileSecurity, FileMode.Create, FileAccess.ReadWrite, FileShare.None, bufferSize, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "False positive")]
	internal static FileStream CreateFileStreamCore(KernelTransaction transaction, string path, ExtendedFileAttributes attributes, FileSecurity fileSecurity, FileMode mode, FileAccess access, FileShare share, int bufferSize, PathFormat pathFormat)
	{
		SafeFileHandle safeFileHandle = null;
		try
		{
			safeFileHandle = CreateFileCore(transaction, false, path, attributes, fileSecurity, mode, (FileSystemRights)access, share, checkPath: true, continueOnException: false, pathFormat);
			return new FileStream(safeFileHandle, access, bufferSize, (attributes & ExtendedFileAttributes.Overlapped) != 0);
		}
		catch
		{
			if (safeFileHandle != null && !safeFileHandle.IsClosed)
			{
				safeFileHandle.Close();
			}
			throw;
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Object needs to be disposed by caller.")]
	internal static SafeFileHandle CreateFileCore(KernelTransaction transaction, bool? isFolder, string path, ExtendedFileAttributes attributes, FileSecurity fileSecurity, FileMode fileMode, FileSystemRights fileSystemRights, FileShare fileShare, bool checkPath, bool continueOnException, PathFormat pathFormat)
	{
		if (checkPath && pathFormat == PathFormat.RelativePath)
		{
			Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
		}
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		bool flag;
		if (flag = fileMode == FileMode.Append)
		{
			fileMode = FileMode.OpenOrCreate;
			fileSystemRights |= FileSystemRights.AppendData;
		}
		if (fileSecurity != null)
		{
			fileSystemRights |= (FileSystemRights)268435456;
		}
		using (((fileSystemRights & (FileSystemRights)268435456) != 0 || (fileSystemRights & (FileSystemRights)536870912) != 0) ? new PrivilegeEnabler(Privilege.Security) : null)
		{
			using Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes lpSecurityAttributes = new Alphaleonis.Win32.Security.NativeMethods.SecurityAttributes(fileSecurity);
			SafeFileHandle safeFileHandle = ((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.CreateFileW(extendedLengthPathCore, fileSystemRights, fileShare, lpSecurityAttributes, fileMode, attributes, IntPtr.Zero) : NativeMethods.CreateFileTransactedW(extendedLengthPathCore, fileSystemRights, fileShare, lpSecurityAttributes, fileMode, attributes, IntPtr.Zero, transaction.SafeHandle, IntPtr.Zero, IntPtr.Zero));
			int lastWin32Error = Marshal.GetLastWin32Error();
			NativeMethods.CloseHandleAndPossiblyThrowException(safeFileHandle, lastWin32Error, isFolder, path, !continueOnException);
			if (flag)
			{
				bool num = NativeMethods.SetFilePointerEx(safeFileHandle, 0uL, IntPtr.Zero, SeekOrigin.End);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (!num)
				{
					NativeMethods.CloseHandleAndPossiblyThrowException(safeFileHandle, lastWin32Error, isFolder, path, !continueOnException);
					return null;
				}
			}
			return safeFileHandle;
		}
	}

	internal static void ThrowIOExceptionIfFsoExist(KernelTransaction transaction, bool isFolder, string fsoPath, PathFormat pathFormat)
	{
		if (ExistsCore(transaction, isFolder, fsoPath, pathFormat))
		{
			throw new IOException(string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
			{
				183u,
				string.Format(CultureInfo.InvariantCulture, isFolder ? Resources.Target_File_Is_A_Directory : Resources.Target_Directory_Is_A_File, new object[1] { fsoPath })
			}), 183);
		}
	}

	[SecurityCritical]
	public static bool Exists(string path)
	{
		return ExistsCore(null, isFolder: false, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool Exists(string path, PathFormat pathFormat)
	{
		return ExistsCore(null, isFolder: false, path, pathFormat);
	}

	[SecurityCritical]
	public static bool ExistsTransacted(KernelTransaction transaction, string path)
	{
		return ExistsCore(transaction, isFolder: false, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static bool ExistsTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return ExistsCore(transaction, isFolder: false, path, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	internal static bool ExistsCore(KernelTransaction transaction, bool isFolder, string path, PathFormat pathFormat)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			return false;
		}
		string regularPathCore = Path.GetRegularPathCore(path, GetFullPathOptions.None, allowEmpty: false);
		if (regularPathCore.Length == 2 && Path.IsLogicalDriveCore(regularPathCore, isRegularPath: true, PathFormat.LongFullPath))
		{
			path = regularPathCore;
		}
		try
		{
			string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.TrimEnd | GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.ContinueOnNonExist | GetFullPathOptions.CheckInvalidPathChars);
			NativeMethods.WIN32_FILE_ATTRIBUTE_DATA win32AttrData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
			int num = FillAttributeInfoCore(transaction, extendedLengthPathCore, ref win32AttrData, tryAgain: false, returnErrorOnNotFound: true);
			if (num == 123L || num == 87L)
			{
				num = FillAttributeInfoCore(transaction, regularPathCore, ref win32AttrData, tryAgain: false, returnErrorOnNotFound: true);
			}
			bool flag = IsDirectory(win32AttrData.dwFileAttributes);
			return num == 0L && (isFolder ? flag : (!flag));
		}
		catch
		{
			return false;
		}
	}

	[SecurityCritical]
	public static FileSecurity GetAccessControl(string path)
	{
		return GetAccessControlCore<FileSecurity>(isFolder: false, path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSecurity GetAccessControl(string path, AccessControlSections includeSections)
	{
		return GetAccessControlCore<FileSecurity>(isFolder: false, path, includeSections, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSecurity GetAccessControl(string path, PathFormat pathFormat)
	{
		return GetAccessControlCore<FileSecurity>(isFolder: false, path, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, pathFormat);
	}

	[SecurityCritical]
	public static FileSecurity GetAccessControl(string path, AccessControlSections includeSections, PathFormat pathFormat)
	{
		return GetAccessControlCore<FileSecurity>(isFolder: false, path, includeSections, pathFormat);
	}

	[SecurityCritical]
	public static FileSecurity GetAccessControl(SafeFileHandle handle)
	{
		return GetAccessControlHandleCore<FileSecurity>(internalCall: false, isFolder: false, handle, AccessControlSections.Access | AccessControlSections.Owner | AccessControlSections.Group, SECURITY_INFORMATION.None);
	}

	[SecurityCritical]
	public static FileSecurity GetAccessControl(SafeFileHandle handle, AccessControlSections includeSections)
	{
		return GetAccessControlHandleCore<FileSecurity>(internalCall: false, isFolder: false, handle, includeSections, SECURITY_INFORMATION.None);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Justification = "Disposing is controlled.")]
	internal static T GetAccessControlCore<T>(bool isFolder, string path, AccessControlSections includeSections, PathFormat pathFormat)
	{
		SECURITY_INFORMATION securityInfo = CreateSecurityInformation(includeSections);
		PrivilegeEnabler privilegeEnabler = null;
		if ((includeSections & AccessControlSections.Audit) != 0)
		{
			privilegeEnabler = new PrivilegeEnabler(Privilege.Security);
		}
		using (privilegeEnabler)
		{
			string extendedLengthPathCore = Path.GetExtendedLengthPathCore(null, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			IntPtr pSidOwner;
			IntPtr pSidGroup;
			IntPtr pDacl;
			IntPtr pSacl;
			SafeGlobalMemoryBufferHandle pSecurityDescriptor;
			uint namedSecurityInfoW = Alphaleonis.Win32.Security.NativeMethods.GetNamedSecurityInfoW(extendedLengthPathCore, SE_OBJECT_TYPE.SE_FILE_OBJECT, securityInfo, out pSidOwner, out pSidGroup, out pDacl, out pSacl, out pSecurityDescriptor);
			if (namedSecurityInfoW == 5)
			{
				using (SafeFileHandle handle = CreateFileCore(null, isFolder, extendedLengthPathCore, ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.Read, FileShare.Read, checkPath: false, continueOnException: false, PathFormat.LongFullPath))
				{
					return GetAccessControlHandleCore<T>(internalCall: true, isFolder, handle, includeSections, securityInfo);
				}
			}
			return GetSecurityDescriptor<T>(namedSecurityInfoW, isFolder, extendedLengthPathCore, pSecurityDescriptor);
		}
	}

	internal static T GetAccessControlHandleCore<T>(bool internalCall, bool isFolder, SafeFileHandle handle, AccessControlSections includeSections, SECURITY_INFORMATION securityInfo)
	{
		if (!internalCall)
		{
			securityInfo = CreateSecurityInformation(includeSections);
		}
		PrivilegeEnabler privilegeEnabler = null;
		if (!internalCall && (includeSections & AccessControlSections.Audit) != 0)
		{
			privilegeEnabler = new PrivilegeEnabler(Privilege.Security);
		}
		using (privilegeEnabler)
		{
			IntPtr pSidOwner;
			IntPtr pSidGroup;
			IntPtr pDacl;
			IntPtr pSacl;
			SafeGlobalMemoryBufferHandle pSecurityDescriptor;
			return GetSecurityDescriptor<T>(Alphaleonis.Win32.Security.NativeMethods.GetSecurityInfo(handle, SE_OBJECT_TYPE.SE_FILE_OBJECT, securityInfo, out pSidOwner, out pSidGroup, out pDacl, out pSacl, out pSecurityDescriptor), isFolder, null, pSecurityDescriptor);
		}
	}

	private static SECURITY_INFORMATION CreateSecurityInformation(AccessControlSections includeSections)
	{
		SECURITY_INFORMATION sECURITY_INFORMATION = SECURITY_INFORMATION.None;
		if ((includeSections & AccessControlSections.Access) != 0)
		{
			sECURITY_INFORMATION |= SECURITY_INFORMATION.DACL_SECURITY_INFORMATION;
		}
		if ((includeSections & AccessControlSections.Audit) != 0)
		{
			sECURITY_INFORMATION |= SECURITY_INFORMATION.SACL_SECURITY_INFORMATION;
		}
		if ((includeSections & AccessControlSections.Group) != 0)
		{
			sECURITY_INFORMATION |= SECURITY_INFORMATION.GROUP_SECURITY_INFORMATION;
		}
		if ((includeSections & AccessControlSections.Owner) != 0)
		{
			sECURITY_INFORMATION |= SECURITY_INFORMATION.OWNER_SECURITY_INFORMATION;
		}
		return sECURITY_INFORMATION;
	}

	private static T GetSecurityDescriptor<T>(uint lastError, bool isFolder, string path, SafeGlobalMemoryBufferHandle securityDescriptor)
	{
		ObjectSecurity objectSecurity;
		using (securityDescriptor)
		{
			if (lastError == 2 || lastError == 3)
			{
				lastError = (isFolder ? 3u : 2u);
			}
			if (lastError != 0)
			{
				NativeError.ThrowException(lastError, (!Utils.IsNullOrWhiteSpace(path)) ? path : null);
			}
			if (!NativeMethods.IsValidHandle(securityDescriptor, throwException: false))
			{
				throw new IOException(Resources.Returned_Invalid_Security_Descriptor);
			}
			uint securityDescriptorLength = Alphaleonis.Win32.Security.NativeMethods.GetSecurityDescriptorLength(securityDescriptor);
			byte[] securityDescriptorBinaryForm = securityDescriptor.ToByteArray(0, (int)securityDescriptorLength);
			objectSecurity = (isFolder ? ((FileSystemSecurity)new DirectorySecurity()) : ((FileSystemSecurity)new FileSecurity()));
			objectSecurity.SetSecurityDescriptorBinaryForm(securityDescriptorBinaryForm);
		}
		return (T)(object)objectSecurity;
	}

	[SecurityCritical]
	public static FileAttributes GetAttributes(string path)
	{
		return GetAttributesExCore<FileAttributes>(null, path, PathFormat.RelativePath, returnErrorOnNotFound: true);
	}

	[SecurityCritical]
	public static FileAttributes GetAttributes(string path, PathFormat pathFormat)
	{
		return GetAttributesExCore<FileAttributes>(null, path, pathFormat, returnErrorOnNotFound: true);
	}

	[SecurityCritical]
	public static FileAttributes GetAttributesTransacted(KernelTransaction transaction, string path)
	{
		return GetAttributesExCore<FileAttributes>(transaction, path, PathFormat.RelativePath, returnErrorOnNotFound: true);
	}

	[SecurityCritical]
	public static FileAttributes GetAttributesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetAttributesExCore<FileAttributes>(transaction, path, pathFormat, returnErrorOnNotFound: true);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke", Justification = "Marshal.GetLastWin32Error() is manipulated.")]
	internal static T GetAttributesExCore<T>(KernelTransaction transaction, string path, PathFormat pathFormat, bool returnErrorOnNotFound)
	{
		if (pathFormat == PathFormat.RelativePath)
		{
			Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
		}
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars);
		NativeMethods.WIN32_FILE_ATTRIBUTE_DATA win32AttrData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
		int num = FillAttributeInfoCore(transaction, extendedLengthPathCore, ref win32AttrData, tryAgain: false, returnErrorOnNotFound);
		if (num != 0L)
		{
			NativeError.ThrowException(num, extendedLengthPathCore);
		}
		return (T)(((object)typeof(T) == typeof(FileAttributes)) ? ((object)win32AttrData.dwFileAttributes) : ((object)win32AttrData));
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	internal static int FillAttributeInfoCore(KernelTransaction transaction, string pathLp, ref NativeMethods.WIN32_FILE_ATTRIBUTE_DATA win32AttrData, bool tryAgain, bool returnErrorOnNotFound)
	{
		int lastError = 0;
		if (tryAgain)
		{
			NativeMethods.WIN32_FIND_DATA win32FindData;
			using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
			{
				SafeFindFileHandle safeFindFileHandle = FileSystemInfo.FindFirstFileNative(transaction, pathLp, NativeMethods.FindexInfoLevel, NativeMethods.FINDEX_SEARCH_OPS.SearchNameMatch, NativeMethods.UseLargeCache, out lastError, out win32FindData);
				if (safeFindFileHandle == null)
				{
					uint num = (uint)lastError;
					if ((num - 2 <= 1 || num == 21 || num == 123) && !returnErrorOnNotFound)
					{
						lastError = 0;
						win32AttrData.dwFileAttributes = (FileAttributes)(-1);
					}
					return lastError;
				}
			}
			win32AttrData = new NativeMethods.WIN32_FILE_ATTRIBUTE_DATA(win32FindData);
			return lastError;
		}
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			if (!((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.GetFileAttributesExW(pathLp, NativeMethods.GET_FILEEX_INFO_LEVELS.GetFileExInfoStandard, out win32AttrData) : NativeMethods.GetFileAttributesTransactedW(pathLp, NativeMethods.GET_FILEEX_INFO_LEVELS.GetFileExInfoStandard, out win32AttrData, transaction.SafeHandle)))
			{
				lastError = Marshal.GetLastWin32Error();
				uint num = (uint)lastError;
				if (num - 2 > 1 && num != 21)
				{
					if (!returnErrorOnNotFound)
					{
						lastError = 0;
						win32AttrData.dwFileAttributes = (FileAttributes)(-1);
						return lastError;
					}
					return lastError;
				}
				return FillAttributeInfoCore(transaction, pathLp, ref win32AttrData, tryAgain: true, returnErrorOnNotFound);
			}
			return lastError;
		}
	}

	[SecurityCritical]
	public static DateTime GetCreationTime(string path)
	{
		return GetCreationTimeCore(null, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTime(string path, PathFormat pathFormat)
	{
		return GetCreationTimeCore(null, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeTransacted(KernelTransaction transaction, string path)
	{
		return GetCreationTimeCore(transaction, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetCreationTimeCore(transaction, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtc(string path)
	{
		return GetCreationTimeCore(null, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtc(string path, PathFormat pathFormat)
	{
		return GetCreationTimeCore(null, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return GetCreationTimeCore(transaction, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetCreationTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetCreationTimeCore(transaction, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	internal static DateTime GetCreationTimeCore(KernelTransaction transaction, string path, bool returnUtc, PathFormat pathFormat)
	{
		NativeMethods.FILETIME ftCreationTime = GetAttributesExCore<NativeMethods.WIN32_FILE_ATTRIBUTE_DATA>(transaction, path, pathFormat, returnErrorOnNotFound: false).ftCreationTime;
		if (!returnUtc)
		{
			return DateTime.FromFileTime(ftCreationTime);
		}
		return DateTime.FromFileTimeUtc(ftCreationTime);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTime(string path)
	{
		return GetLastAccessTimeCore(null, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTime(string path, PathFormat pathFormat)
	{
		return GetLastAccessTimeCore(null, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeTransacted(KernelTransaction transaction, string path)
	{
		return GetLastAccessTimeCore(transaction, path, returnUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetLastAccessTimeCore(transaction, path, returnUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtc(string path)
	{
		return GetLastAccessTimeCore(null, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtc(string path, PathFormat pathFormat)
	{
		return GetLastAccessTimeCore(null, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return GetLastAccessTimeCore(transaction, path, returnUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetLastAccessTimeCore(transaction, path, returnUtc: true, pathFormat);
	}

	[SecurityCritical]
	internal static DateTime GetLastAccessTimeCore(KernelTransaction transaction, string path, bool returnUtc, PathFormat pathFormat)
	{
		NativeMethods.FILETIME ftLastAccessTime = GetAttributesExCore<NativeMethods.WIN32_FILE_ATTRIBUTE_DATA>(transaction, path, pathFormat, returnErrorOnNotFound: false).ftLastAccessTime;
		if (!returnUtc)
		{
			return DateTime.FromFileTime(ftLastAccessTime);
		}
		return DateTime.FromFileTimeUtc(ftLastAccessTime);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTime(string path)
	{
		return GetLastWriteTimeCore(null, path, getUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTime(string path, PathFormat pathFormat)
	{
		return GetLastWriteTimeCore(null, path, getUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeTransacted(KernelTransaction transaction, string path)
	{
		return GetLastWriteTimeCore(transaction, path, getUtc: false, PathFormat.RelativePath).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetLastWriteTimeCore(transaction, path, getUtc: false, pathFormat).ToLocalTime();
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtc(string path)
	{
		return GetLastWriteTimeCore(null, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtc(string path, PathFormat pathFormat)
	{
		return GetLastWriteTimeCore(null, path, getUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return GetLastWriteTimeCore(transaction, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetLastWriteTimeCore(transaction, path, getUtc: true, pathFormat);
	}

	[SecurityCritical]
	internal static DateTime GetLastWriteTimeCore(KernelTransaction transaction, string path, bool getUtc, PathFormat pathFormat)
	{
		NativeMethods.FILETIME ftLastWriteTime = GetAttributesExCore<NativeMethods.WIN32_FILE_ATTRIBUTE_DATA>(transaction, path, pathFormat, returnErrorOnNotFound: false).ftLastWriteTime;
		if (!getUtc)
		{
			return DateTime.FromFileTime(ftLastWriteTime);
		}
		return DateTime.FromFileTimeUtc(ftLastWriteTime);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode)
	{
		return OpenCore(null, path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access)
	{
		return OpenCore(null, path, mode, access, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
	{
		return OpenCore(null, path, mode, access, share, ExtendedFileAttributes.Normal, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None, ExtendedFileAttributes.Normal, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, access, FileShare.None, ExtendedFileAttributes.Normal, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, access, share, ExtendedFileAttributes.Normal, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, ExtendedFileAttributes extendedAttributes, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, access, share, extendedAttributes, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
	{
		return OpenCore(null, path, mode, access, share, ExtendedFileAttributes.Normal, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
	{
		return OpenCore(null, path, mode, access, share, ExtendedFileAttributes.Normal | (useAsync ? ExtendedFileAttributes.Overlapped : ExtendedFileAttributes.Normal), bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
	{
		return OpenCore(null, path, mode, access, share, (ExtendedFileAttributes)options, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes)
	{
		return OpenCore(null, path, mode, access, share, extendedAttributes, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, access, share, ExtendedFileAttributes.Normal, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, access, share, ExtendedFileAttributes.Normal | (useAsync ? ExtendedFileAttributes.Overlapped : ExtendedFileAttributes.Normal), bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, access, share, (ExtendedFileAttributes)options, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, access, share, extendedAttributes, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options)
	{
		return OpenCore(null, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes)
	{
		return OpenCore(null, path, mode, rights, share, extendedAttributes, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity security)
	{
		return OpenCore(null, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, security, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, FileSecurity security)
	{
		return OpenCore(null, path, mode, rights, share, extendedAttributes, bufferSize, security, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, rights, share, extendedAttributes, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity security, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, security, pathFormat);
	}

	[SecurityCritical]
	public static FileStream Open(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, FileSecurity security, PathFormat pathFormat)
	{
		return OpenCore(null, path, mode, rights, share, extendedAttributes, bufferSize, security, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode)
	{
		return OpenCore(transaction, path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, (mode == FileMode.Append) ? FileAccess.Write : FileAccess.ReadWrite, FileShare.None, ExtendedFileAttributes.Normal, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access)
	{
		return OpenCore(transaction, path, mode, access, FileShare.None, ExtendedFileAttributes.Normal, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share)
	{
		return OpenCore(transaction, path, mode, access, share, ExtendedFileAttributes.Normal, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access, FileShare.None, ExtendedFileAttributes.Normal, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access, share, ExtendedFileAttributes.Normal, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, ExtendedFileAttributes extendedAttributes, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access, share, extendedAttributes, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
	{
		return OpenCore(transaction, path, mode, access, share, ExtendedFileAttributes.Normal, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
	{
		return OpenCore(transaction, path, mode, access, share, ExtendedFileAttributes.Normal | (useAsync ? ExtendedFileAttributes.Overlapped : ExtendedFileAttributes.Normal), bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
	{
		return OpenCore(transaction, path, mode, access, share, (ExtendedFileAttributes)options, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes)
	{
		return OpenCore(transaction, path, mode, access, share, extendedAttributes, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access, share, ExtendedFileAttributes.Normal, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access, share, ExtendedFileAttributes.Normal | (useAsync ? ExtendedFileAttributes.Overlapped : ExtendedFileAttributes.Normal), bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access, share, (ExtendedFileAttributes)options, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access, share, extendedAttributes, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options)
	{
		return OpenCore(transaction, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes)
	{
		return OpenCore(transaction, path, mode, rights, share, extendedAttributes, bufferSize, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity security)
	{
		return OpenCore(transaction, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, security, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, FileSecurity security)
	{
		return OpenCore(transaction, path, mode, rights, share, extendedAttributes, bufferSize, security, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, rights, share, extendedAttributes, bufferSize, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity security, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, rights, share, (ExtendedFileAttributes)options, bufferSize, security, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenTransacted(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, ExtendedFileAttributes extendedAttributes, FileSecurity security, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, rights, share, extendedAttributes, bufferSize, security, pathFormat);
	}

	internal static FileStream OpenCore(KernelTransaction transaction, string path, FileMode mode, FileAccess access, FileShare share, ExtendedFileAttributes attributes, int? bufferSize, FileSecurity security, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, mode, access switch
		{
			FileAccess.Write => FileSystemRights.Write, 
			FileAccess.Read => FileSystemRights.Read, 
			_ => FileSystemRights.Write | FileSystemRights.Read, 
		}, share, attributes, bufferSize, security, pathFormat);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	internal static FileStream OpenCore(KernelTransaction transaction, string path, FileMode mode, FileSystemRights rights, FileShare share, ExtendedFileAttributes attributes, int? bufferSize, FileSecurity security, PathFormat pathFormat)
	{
		FileAccess access = (((rights & FileSystemRights.ListDirectory) != 0) ? FileAccess.Read : ((FileAccess)0)) | (((rights & FileSystemRights.CreateFiles) != 0 || (rights & FileSystemRights.AppendData) != 0) ? FileAccess.Write : ((FileAccess)0));
		SafeFileHandle safeFileHandle = null;
		try
		{
			safeFileHandle = CreateFileCore(transaction, false, path, attributes, security, mode, rights, share, checkPath: true, continueOnException: false, pathFormat);
			return new FileStream(safeFileHandle, access, bufferSize ?? 4096, (attributes & ExtendedFileAttributes.Overlapped) != 0);
		}
		catch
		{
			if (safeFileHandle != null && !safeFileHandle.IsClosed)
			{
				safeFileHandle.Close();
			}
			throw;
		}
	}

	[SecurityCritical]
	public static byte[] ReadAllBytes(string path)
	{
		return ReadAllBytesCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static byte[] ReadAllBytes(string path, PathFormat pathFormat)
	{
		return ReadAllBytesCore(null, path, pathFormat);
	}

	[SecurityCritical]
	public static byte[] ReadAllBytesTransacted(KernelTransaction transaction, string path)
	{
		return ReadAllBytesCore(transaction, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static byte[] ReadAllBytesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return ReadAllBytesCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	internal static byte[] ReadAllBytesCore(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		using FileStream fileStream = OpenReadTransacted(transaction, path, pathFormat);
		int num = 0;
		long length = fileStream.Length;
		if (length > 2147483647L)
		{
			throw new IOException(string.Format(CultureInfo.InvariantCulture, "File larger than 2GB: [{0}]", new object[1] { path }));
		}
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			if (num3 != 0)
			{
				num += num3;
				num2 -= num3;
				continue;
			}
			throw new IOException("UNEXPECTED end of file found");
		}
		return array;
	}

	[SecurityCritical]
	public static string[] ReadAllLines(string path)
	{
		return ReadAllLinesCore(null, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] ReadAllLines(string path, Encoding encoding)
	{
		return ReadAllLinesCore(null, path, encoding, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] ReadAllLines(string path, PathFormat pathFormat)
	{
		return ReadAllLinesCore(null, path, NativeMethods.DefaultFileEncoding, pathFormat).ToArray();
	}

	[SecurityCritical]
	public static string[] ReadAllLines(string path, Encoding encoding, PathFormat pathFormat)
	{
		return ReadAllLinesCore(null, path, encoding, pathFormat).ToArray();
	}

	[SecurityCritical]
	public static string[] ReadAllLinesTransacted(KernelTransaction transaction, string path)
	{
		return ReadAllLinesCore(transaction, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] ReadAllLinesTransacted(KernelTransaction transaction, string path, Encoding encoding)
	{
		return ReadAllLinesCore(transaction, path, encoding, PathFormat.RelativePath).ToArray();
	}

	[SecurityCritical]
	public static string[] ReadAllLinesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return ReadAllLinesCore(transaction, path, NativeMethods.DefaultFileEncoding, pathFormat).ToArray();
	}

	[SecurityCritical]
	public static string[] ReadAllLinesTransacted(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		return ReadAllLinesCore(transaction, path, encoding, pathFormat).ToArray();
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	internal static IEnumerable<string> ReadAllLinesCore(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		using StreamReader sr = new StreamReader(OpenCore(transaction, path, FileMode.Open, FileAccess.Read, FileShare.Read, ExtendedFileAttributes.SequentialScan, null, null, pathFormat), encoding);
		string text;
		while ((text = sr.ReadLine()) != null)
		{
			yield return text;
		}
	}

	[SecurityCritical]
	public static string ReadAllText(string path)
	{
		return ReadAllTextCore(null, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string ReadAllText(string path, Encoding encoding)
	{
		return ReadAllTextCore(null, path, encoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string ReadAllText(string path, PathFormat pathFormat)
	{
		return ReadAllTextCore(null, path, NativeMethods.DefaultFileEncoding, pathFormat);
	}

	[SecurityCritical]
	public static string ReadAllText(string path, Encoding encoding, PathFormat pathFormat)
	{
		return ReadAllTextCore(null, path, encoding, pathFormat);
	}

	[SecurityCritical]
	public static string ReadAllTextTransacted(KernelTransaction transaction, string path)
	{
		return ReadAllTextCore(transaction, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string ReadAllTextTransacted(KernelTransaction transaction, string path, Encoding encoding)
	{
		return ReadAllTextCore(transaction, path, encoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static string ReadAllTextTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return ReadAllTextCore(transaction, path, NativeMethods.DefaultFileEncoding, pathFormat);
	}

	[SecurityCritical]
	public static string ReadAllTextTransacted(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		return ReadAllTextCore(transaction, path, encoding, pathFormat);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SecurityCritical]
	internal static string ReadAllTextCore(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		using StreamReader streamReader = new StreamReader(OpenCore(transaction, path, FileMode.Open, FileAccess.Read, FileShare.Read, ExtendedFileAttributes.SequentialScan, null, null, pathFormat), encoding);
		return streamReader.ReadToEnd();
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLines(string path)
	{
		return ReadLinesCore(null, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLines(string path, Encoding encoding)
	{
		return ReadLinesCore(null, path, encoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLines(string path, PathFormat pathFormat)
	{
		return ReadLinesCore(null, path, NativeMethods.DefaultFileEncoding, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLines(string path, Encoding encoding, PathFormat pathFormat)
	{
		return ReadLinesCore(null, path, encoding, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLinesTransacted(KernelTransaction transaction, string path)
	{
		return ReadLinesCore(transaction, path, NativeMethods.DefaultFileEncoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLinesTransacted(KernelTransaction transaction, string path, Encoding encoding)
	{
		return ReadLinesCore(transaction, path, encoding, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLinesTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return ReadLinesCore(transaction, path, NativeMethods.DefaultFileEncoding, pathFormat);
	}

	[SecurityCritical]
	public static IEnumerable<string> ReadLinesTransacted(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		return ReadLinesCore(transaction, path, encoding, pathFormat);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SecurityCritical]
	internal static IEnumerable<string> ReadLinesCore(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		using StreamReader sr = new StreamReader(OpenCore(transaction, path, FileMode.Open, FileAccess.Read, FileShare.Read, ExtendedFileAttributes.SequentialScan, null, null, pathFormat), encoding);
		string text;
		while ((text = sr.ReadLine()) != null)
		{
			yield return text;
		}
	}

	[SecurityCritical]
	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
	{
		ReplaceCore(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dest")]
	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
	{
		ReplaceCore(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "dest")]
	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors, PathFormat pathFormat)
	{
		ReplaceCore(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors, pathFormat);
	}

	[SecurityCritical]
	internal static void ReplaceCore(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors, PathFormat pathFormat)
	{
		string text = sourceFileName;
		string text2 = destinationFileName;
		if (pathFormat != PathFormat.LongFullPath)
		{
			text = Path.GetExtendedLengthPathCore(null, sourceFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			text2 = Path.GetExtendedLengthPathCore(null, destinationFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		}
		string lpBackupFileName = ((destinationBackupFileName == null) ? null : Path.GetExtendedLengthPathCore(null, destinationBackupFileName, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator));
		FileSystemRights fileSystemRights = FileSystemRights.ListDirectory;
		if (ignoreMetadataErrors)
		{
			fileSystemRights |= FileSystemRights.CreateFiles;
		}
		bool num = NativeMethods.ReplaceFileW(text2, text, lpBackupFileName, fileSystemRights, IntPtr.Zero, IntPtr.Zero);
		uint lastWin32Error = (uint)Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, text, text2);
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, FileSecurity fileSecurity)
	{
		SetAccessControlCore(path, null, fileSecurity, AccessControlSections.All, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, FileSecurity fileSecurity, AccessControlSections includeSections)
	{
		SetAccessControlCore(path, null, fileSecurity, includeSections, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, FileSecurity fileSecurity, PathFormat pathFormat)
	{
		SetAccessControlCore(path, null, fileSecurity, AccessControlSections.All, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(string path, FileSecurity fileSecurity, AccessControlSections includeSections, PathFormat pathFormat)
	{
		SetAccessControlCore(path, null, fileSecurity, includeSections, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(SafeFileHandle handle, FileSecurity fileSecurity)
	{
		SetAccessControlCore(null, handle, fileSecurity, AccessControlSections.All, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public static void SetAccessControl(SafeFileHandle handle, FileSecurity fileSecurity, AccessControlSections includeSections)
	{
		SetAccessControlCore(null, handle, fileSecurity, includeSections, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal static void SetAccessControlCore(string path, SafeFileHandle handle, ObjectSecurity objectSecurity, AccessControlSections includeSections, PathFormat pathFormat)
	{
		if (pathFormat == PathFormat.RelativePath)
		{
			Path.CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
		}
		if (objectSecurity == null)
		{
			throw new ArgumentNullException("objectSecurity");
		}
		byte[] securityDescriptorBinaryForm = objectSecurity.GetSecurityDescriptorBinaryForm();
		using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(securityDescriptorBinaryForm.Length);
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(null, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars);
		safeGlobalMemoryBufferHandle.CopyFrom(securityDescriptorBinaryForm, 0, securityDescriptorBinaryForm.Length);
		SECURITY_DESCRIPTOR_CONTROL pControl;
		uint lpdwRevision;
		bool securityDescriptorControl = Alphaleonis.Win32.Security.NativeMethods.GetSecurityDescriptorControl(safeGlobalMemoryBufferHandle, out pControl, out lpdwRevision);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!securityDescriptorControl)
		{
			NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
		}
		PrivilegeEnabler privilegeEnabler = null;
		try
		{
			SECURITY_INFORMATION sECURITY_INFORMATION = SECURITY_INFORMATION.None;
			IntPtr pDacl = IntPtr.Zero;
			if ((includeSections & AccessControlSections.Access) != 0)
			{
				bool lpbDaclPresent;
				bool lpbDaclDefaulted;
				bool securityDescriptorDacl = Alphaleonis.Win32.Security.NativeMethods.GetSecurityDescriptorDacl(safeGlobalMemoryBufferHandle, out lpbDaclPresent, out pDacl, out lpbDaclDefaulted);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (!securityDescriptorDacl)
				{
					NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				}
				if (lpbDaclPresent)
				{
					sECURITY_INFORMATION |= SECURITY_INFORMATION.DACL_SECURITY_INFORMATION;
					sECURITY_INFORMATION |= (((pControl & SECURITY_DESCRIPTOR_CONTROL.SE_DACL_PROTECTED) != 0) ? SECURITY_INFORMATION.PROTECTED_DACL_SECURITY_INFORMATION : SECURITY_INFORMATION.UNPROTECTED_DACL_SECURITY_INFORMATION);
				}
			}
			IntPtr pSacl = IntPtr.Zero;
			if ((includeSections & AccessControlSections.Audit) != 0)
			{
				bool lpbSaclPresent;
				bool lpbSaclDefaulted;
				bool securityDescriptorSacl = Alphaleonis.Win32.Security.NativeMethods.GetSecurityDescriptorSacl(safeGlobalMemoryBufferHandle, out lpbSaclPresent, out pSacl, out lpbSaclDefaulted);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (!securityDescriptorSacl)
				{
					NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				}
				if (lpbSaclPresent)
				{
					sECURITY_INFORMATION |= SECURITY_INFORMATION.SACL_SECURITY_INFORMATION;
					sECURITY_INFORMATION |= (((pControl & SECURITY_DESCRIPTOR_CONTROL.SE_SACL_PROTECTED) != 0) ? SECURITY_INFORMATION.PROTECTED_SACL_SECURITY_INFORMATION : SECURITY_INFORMATION.UNPROTECTED_SACL_SECURITY_INFORMATION);
					privilegeEnabler = new PrivilegeEnabler(Privilege.Security);
				}
			}
			IntPtr pOwner = IntPtr.Zero;
			if ((includeSections & AccessControlSections.Owner) != 0)
			{
				bool lpbOwnerDefaulted;
				bool securityDescriptorOwner = Alphaleonis.Win32.Security.NativeMethods.GetSecurityDescriptorOwner(safeGlobalMemoryBufferHandle, out pOwner, out lpbOwnerDefaulted);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (!securityDescriptorOwner)
				{
					NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				}
				if (pOwner != IntPtr.Zero)
				{
					sECURITY_INFORMATION |= SECURITY_INFORMATION.OWNER_SECURITY_INFORMATION;
				}
			}
			IntPtr pGroup = IntPtr.Zero;
			if ((includeSections & AccessControlSections.Group) != 0)
			{
				bool lpbGroupDefaulted;
				bool securityDescriptorGroup = Alphaleonis.Win32.Security.NativeMethods.GetSecurityDescriptorGroup(safeGlobalMemoryBufferHandle, out pGroup, out lpbGroupDefaulted);
				lastWin32Error = Marshal.GetLastWin32Error();
				if (!securityDescriptorGroup)
				{
					NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				}
				if (pGroup != IntPtr.Zero)
				{
					sECURITY_INFORMATION |= SECURITY_INFORMATION.GROUP_SECURITY_INFORMATION;
				}
			}
			if (!Utils.IsNullOrWhiteSpace(extendedLengthPathCore))
			{
				lastWin32Error = (int)Alphaleonis.Win32.Security.NativeMethods.SetNamedSecurityInfoW(extendedLengthPathCore, SE_OBJECT_TYPE.SE_FILE_OBJECT, sECURITY_INFORMATION, pOwner, pGroup, pDacl, pSacl);
				if (lastWin32Error != 0L)
				{
					NativeError.ThrowException(lastWin32Error, extendedLengthPathCore);
				}
			}
			else if (NativeMethods.IsValidHandle(handle))
			{
				lastWin32Error = (int)Alphaleonis.Win32.Security.NativeMethods.SetSecurityInfo(handle, SE_OBJECT_TYPE.SE_FILE_OBJECT, sECURITY_INFORMATION, pOwner, pGroup, pDacl, pSacl);
				if (lastWin32Error != 0L)
				{
					NativeError.ThrowException(lastWin32Error);
				}
			}
		}
		finally
		{
			privilegeEnabler?.Dispose();
		}
	}

	[SecurityCritical]
	public static void SetAttributes(string path, FileAttributes fileAttributes)
	{
		SetAttributesCore(null, isFolder: false, path, fileAttributes, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetAttributes(string path, FileAttributes fileAttributes, PathFormat pathFormat)
	{
		SetAttributesCore(null, isFolder: false, path, fileAttributes, pathFormat);
	}

	[SecurityCritical]
	public static void SetAttributesTransacted(KernelTransaction transaction, string path, FileAttributes fileAttributes)
	{
		SetAttributesCore(transaction, isFolder: false, path, fileAttributes, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetAttributesTransacted(KernelTransaction transaction, string path, FileAttributes fileAttributes, PathFormat pathFormat)
	{
		SetAttributesCore(transaction, isFolder: false, path, fileAttributes, pathFormat);
	}

	[SecurityCritical]
	internal static void SetAttributesCore(KernelTransaction transaction, bool isFolder, string path, FileAttributes fileAttributes, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath)
		{
			path = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		}
		bool num = ((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.SetFileAttributesW(path, fileAttributes) : NativeMethods.SetFileAttributesTransactedW(path, fileAttributes, transaction.SafeHandle));
		int num2 = Marshal.GetLastWin32Error();
		if (num)
		{
			return;
		}
		switch (num2)
		{
		case 87:
			throw new ArgumentException(Resources.Invalid_File_Attribute, "fileAttributes");
		case 2:
		case 3:
			if (isFolder)
			{
				num2 = 3;
			}
			NativeError.ThrowException(num2, path);
			break;
		}
		NativeError.ThrowException(num2, path);
	}

	[SecurityCritical]
	public static void SetCreationTime(string path, DateTime creationTime)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTime(string path, DateTime creationTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTime(string path, DateTime creationTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTimeUtc, null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTimeUtc, null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTimeUtc, null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTimeUtc, null, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTimeUtc, null, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTimeUtc, null, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTime(string path, DateTime lastAccessTime)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTime(string path, DateTime lastAccessTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTime(string path, DateTime lastAccessTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeTransacted(KernelTransaction transaction, string path, DateTime lastAccessTime)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeTransacted(KernelTransaction transaction, string path, DateTime lastAccessTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeTransacted(KernelTransaction transaction, string path, DateTime lastAccessTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, lastAccessTime.ToUniversalTime(), null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, lastAccessTimeUtc, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, lastAccessTimeUtc, null, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastAccessTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastAccessTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, lastAccessTimeUtc, null, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTime(string path, DateTime lastWriteTime)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTime(string path, DateTime lastWriteTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTime(string path, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeTransacted(KernelTransaction transaction, string path, DateTime lastWriteTime)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeTransacted(KernelTransaction transaction, string path, DateTime lastWriteTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeTransacted(KernelTransaction transaction, string path, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, null, lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, null, null, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, null, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetLastWriteTimeUtcTransacted(KernelTransaction transaction, string path, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, null, null, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestamps(string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsTransacted(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsTransacted(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestampsTransacted(KernelTransaction transaction, string path, DateTime creationTime, DateTime lastAccessTime, DateTime lastWriteTime, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTime.ToUniversalTime(), lastAccessTime.ToUniversalTime(), lastWriteTime.ToUniversalTime(), modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestampsUtc(string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(null, isFolder: false, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, pathFormat);
	}

	[SecurityCritical]
	public static void SetTimestampsUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static void SetTimestampsUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, DateTime lastAccessTimeUtc, DateTime lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		SetFsoDateTimeCore(transaction, isFolder: false, path, creationTimeUtc, lastAccessTimeUtc, lastWriteTimeUtc, modifyReparsePoint, pathFormat);
	}

	[SecurityCritical]
	internal static void SetFsoDateTimeCore(KernelTransaction transaction, bool isFolder, string path, DateTime? creationTimeUtc, DateTime? lastAccessTimeUtc, DateTime? lastWriteTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
	{
		if (pathFormat == PathFormat.RelativePath)
		{
			Path.CheckSupportedPathFormat(path, checkInvalidPathChars: false, checkAdditional: false);
		}
		ExtendedFileAttributes extendedFileAttributes = ExtendedFileAttributes.BackupSemantics;
		if (modifyReparsePoint)
		{
			extendedFileAttributes |= ExtendedFileAttributes.OpenReparsePoint;
		}
		using SafeGlobalMemoryBufferHandle lpCreationTime = SafeGlobalMemoryBufferHandle.FromLong(creationTimeUtc.HasValue ? new long?(creationTimeUtc.Value.ToFileTimeUtc()) : null);
		using SafeGlobalMemoryBufferHandle lpLastAccessTime = SafeGlobalMemoryBufferHandle.FromLong(lastAccessTimeUtc.HasValue ? new long?(lastAccessTimeUtc.Value.ToFileTimeUtc()) : null);
		using SafeGlobalMemoryBufferHandle lpLastWriteTime = SafeGlobalMemoryBufferHandle.FromLong(lastWriteTimeUtc.HasValue ? new long?(lastWriteTimeUtc.Value.ToFileTimeUtc()) : null);
		using SafeFileHandle hFile = CreateFileCore(transaction, isFolder, path, extendedFileAttributes, null, FileMode.Open, FileSystemRights.WriteAttributes, FileShare.Write | FileShare.Delete, checkPath: false, continueOnException: false, pathFormat);
		bool num = NativeMethods.SetFileTime(hFile, lpCreationTime, lpLastAccessTime, lpLastWriteTime);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, path);
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes")]
	public static void WriteAllBytes(string path, byte[] bytes)
	{
		WriteAllBytesCore(null, path, bytes, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes")]
	public static void WriteAllBytes(string path, byte[] bytes, PathFormat pathFormat)
	{
		WriteAllBytesCore(null, path, bytes, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes")]
	public static void WriteAllBytesTransacted(KernelTransaction transaction, string path, byte[] bytes)
	{
		WriteAllBytesCore(transaction, path, bytes, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes")]
	public static void WriteAllBytesTransacted(KernelTransaction transaction, string path, byte[] bytes, PathFormat pathFormat)
	{
		WriteAllBytesCore(transaction, path, bytes, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "bytes")]
	internal static void WriteAllBytesCore(KernelTransaction transaction, string path, byte[] bytes, PathFormat pathFormat)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		using FileStream fileStream = OpenCore(transaction, path, FileMode.Create, FileAccess.Write, FileShare.Read, ExtendedFileAttributes.Normal, null, null, pathFormat);
		fileStream.Write(bytes, 0, bytes.Length);
	}

	[SecurityCritical]
	public static DateTime GetChangeTime(string path, PathFormat pathFormat)
	{
		return GetChangeTimeCore(null, null, isFolder: false, path, getUtc: false, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetChangeTime(string path)
	{
		return GetChangeTimeCore(null, null, isFolder: false, path, getUtc: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTime(SafeFileHandle safeFileHandle)
	{
		return GetChangeTimeCore(null, safeFileHandle, isFolder: false, null, getUtc: false, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetChangeTimeCore(transaction, null, isFolder: false, path, getUtc: false, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeTransacted(KernelTransaction transaction, string path)
	{
		return GetChangeTimeCore(transaction, null, isFolder: false, path, getUtc: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtc(string path, PathFormat pathFormat)
	{
		return GetChangeTimeCore(null, null, isFolder: false, path, getUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtc(string path)
	{
		return GetChangeTimeCore(null, null, isFolder: false, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtc(SafeFileHandle safeFileHandle)
	{
		return GetChangeTimeCore(null, safeFileHandle, isFolder: false, null, getUtc: true, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetChangeTimeCore(transaction, null, isFolder: false, path, getUtc: true, pathFormat);
	}

	[SecurityCritical]
	public static DateTime GetChangeTimeUtcTransacted(KernelTransaction transaction, string path)
	{
		return GetChangeTimeCore(transaction, null, isFolder: false, path, getUtc: true, PathFormat.RelativePath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposing is controlled.")]
	internal static DateTime GetChangeTimeCore(KernelTransaction transaction, SafeFileHandle safeFileHandle, bool isFolder, string path, bool getUtc, PathFormat pathFormat)
	{
		if (!NativeMethods.IsAtLeastWindowsVista)
		{
			throw new PlatformNotSupportedException(new Win32Exception(1150).Message);
		}
		bool flag;
		if (!(flag = safeFileHandle != null))
		{
			if (pathFormat != PathFormat.LongFullPath && Utils.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentNullException("path");
			}
			string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars);
			safeFileHandle = CreateFileCore(transaction, isFolder, extendedLengthPathCore, ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.ListDirectory, FileShare.ReadWrite, checkPath: true, continueOnException: false, PathFormat.LongFullPath);
		}
		try
		{
			NativeMethods.IsValidHandle(safeFileHandle);
			using SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(IntPtr.Size + Marshal.SizeOf(typeof(NativeMethods.FILE_BASIC_INFO)));
			NativeMethods.FILE_BASIC_INFO lpFileInformation;
			bool fileInformationByHandleEx_ = NativeMethods.GetFileInformationByHandleEx_1(safeFileHandle, NativeMethods.FILE_INFO_BY_HANDLE_CLASS.FILE_BASIC_INFO, out lpFileInformation, (uint)safeGlobalMemoryBufferHandle.Capacity);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!fileInformationByHandleEx_)
			{
				NativeError.ThrowException(lastWin32Error, (!Utils.IsNullOrWhiteSpace(path)) ? path : null);
			}
			safeGlobalMemoryBufferHandle.StructureToPtr(lpFileInformation, deleteOld: true);
			NativeMethods.FILETIME changeTime = safeGlobalMemoryBufferHandle.PtrToStructure<NativeMethods.FILE_BASIC_INFO>(0).ChangeTime;
			return getUtc ? DateTime.FromFileTimeUtc(changeTime) : DateTime.FromFileTime(changeTime);
		}
		finally
		{
			if (!flag)
			{
				safeFileHandle?.Close();
			}
		}
	}

	[SecurityCritical]
	public static long GetCompressedSize(string path, PathFormat pathFormat)
	{
		return GetCompressedSizeCore(null, path, pathFormat);
	}

	[SecurityCritical]
	public static long GetCompressedSize(string path)
	{
		return GetCompressedSizeCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static long GetCompressedSizeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetCompressedSizeCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	public static long GetCompressedSizeTransacted(KernelTransaction transaction, string path)
	{
		return GetCompressedSizeCore(transaction, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	internal static long GetCompressedSizeCore(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath && Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		uint lpFileSizeHigh;
		uint num = ((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.GetCompressedFileSizeW(extendedLengthPathCore, out lpFileSizeHigh) : NativeMethods.GetCompressedFileSizeTransactedW(extendedLengthPathCore, out lpFileSizeHigh, transaction.SafeHandle));
		if (num == uint.MaxValue && lpFileSizeHigh == 0)
		{
			NativeError.ThrowException(Marshal.GetLastWin32Error(), extendedLengthPathCore);
		}
		return NativeMethods.ToLong(lpFileSizeHigh, num);
	}

	[SecurityCritical]
	public static FileEncryptionStatus GetEncryptionStatus(string path, PathFormat pathFormat)
	{
		return GetEncryptionStatusCore(path, pathFormat);
	}

	[SecurityCritical]
	public static FileEncryptionStatus GetEncryptionStatus(string path)
	{
		return GetEncryptionStatusCore(path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	internal static FileEncryptionStatus GetEncryptionStatusCore(string path, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath && Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		string extendedLengthPathCore = Path.GetExtendedLengthPathCore(null, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		if (!NativeMethods.FileEncryptionStatusW(extendedLengthPathCore, out var lpStatus))
		{
			NativeError.ThrowException(Marshal.GetLastWin32Error(), extendedLengthPathCore);
		}
		return lpStatus;
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandle(string path)
	{
		return GetFileInfoByHandleCore(null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandle(string path, PathFormat pathFormat)
	{
		return GetFileInfoByHandleCore(null, path, pathFormat);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandleTransacted(KernelTransaction transaction, string path)
	{
		return GetFileInfoByHandleCore(transaction, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandleTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetFileInfoByHandleCore(transaction, path, pathFormat);
	}

	[SecurityCritical]
	public static ByHandleFileInfo GetFileInfoByHandle(SafeFileHandle handle)
	{
		NativeMethods.IsValidHandle(handle);
		NativeMethods.BY_HANDLE_FILE_INFORMATION lpByHandleFileInformation;
		bool fileInformationByHandle = NativeMethods.GetFileInformationByHandle(handle, out lpByHandleFileInformation);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!fileInformationByHandle)
		{
			NativeError.ThrowException(lastWin32Error);
		}
		return new ByHandleFileInfo(lpByHandleFileInformation);
	}

	[SecurityCritical]
	internal static ByHandleFileInfo GetFileInfoByHandleCore(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		using SafeFileHandle handle = CreateFileCore(transaction, false, path, ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, FileSystemRights.ListDirectory, FileShare.ReadWrite, checkPath: true, continueOnException: false, pathFormat);
		return GetFileInfoByHandle(handle);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path)
	{
		return GetFileSystemEntryInfoCore(null, isFolder: false, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path, PathFormat pathFormat)
	{
		return GetFileSystemEntryInfoCore(null, isFolder: false, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path, bool continueOnException)
	{
		return GetFileSystemEntryInfoCore(null, isFolder: false, path, continueOnException, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfo(string path, bool continueOnException, PathFormat pathFormat)
	{
		return GetFileSystemEntryInfoCore(null, isFolder: false, path, continueOnException, pathFormat);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path)
	{
		return GetFileSystemEntryInfoCore(transaction, isFolder: false, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetFileSystemEntryInfoCore(transaction, isFolder: false, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path, bool continueOnException)
	{
		return GetFileSystemEntryInfoCore(transaction, isFolder: false, path, continueOnException, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileSystemEntryInfo GetFileSystemEntryInfoTransacted(KernelTransaction transaction, string path, bool continueOnException, PathFormat pathFormat)
	{
		return GetFileSystemEntryInfoCore(transaction, isFolder: false, path, continueOnException, pathFormat);
	}

	[SecurityCritical]
	internal static FileSystemEntryInfo GetFileSystemEntryInfoCore(KernelTransaction transaction, bool isFolder, string path, bool continueOnException, PathFormat pathFormat)
	{
		DirectoryEnumerationOptions value = (continueOnException ? DirectoryEnumerationOptions.ContinueOnException : DirectoryEnumerationOptions.None);
		return new FindFileSystemEntryInfo(transaction, isFolder, path, Path.WildcardStarMatchAll, value, null, pathFormat, typeof(FileSystemEntryInfo)).Get<FileSystemEntryInfo>();
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfo(string path)
	{
		return GetLinkTargetInfoCore(null, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfo(string path, PathFormat pathFormat)
	{
		return GetLinkTargetInfoCore(null, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfoTransacted(KernelTransaction transaction, string path)
	{
		return GetLinkTargetInfoCore(transaction, path, continueOnException: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static LinkTargetInfo GetLinkTargetInfoTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetLinkTargetInfoCore(transaction, path, continueOnException: false, pathFormat);
	}

	[SecurityCritical]
	internal static LinkTargetInfo GetLinkTargetInfoCore(KernelTransaction transaction, string reparsePath, bool continueOnException, PathFormat pathFormat)
	{
		using SafeFileHandle safeFileHandle = CreateFileCore(transaction, false, reparsePath, ExtendedFileAttributes.OpenReparsePoint | ExtendedFileAttributes.BackupSemantics, null, FileMode.Open, (FileSystemRights)0, FileShare.ReadWrite, pathFormat != PathFormat.LongFullPath, continueOnException, pathFormat);
		return (safeFileHandle != null) ? Device.GetLinkTargetInfo(safeFileHandle, reparsePath) : null;
	}

	[SecurityCritical]
	public static long GetSize(string path, PathFormat pathFormat)
	{
		return GetSizeCore(null, null, path, pathFormat);
	}

	[SecurityCritical]
	public static long GetSize(string path)
	{
		return GetSizeCore(null, null, path, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static long GetSize(SafeFileHandle handle)
	{
		return GetSizeCore(null, handle, null, PathFormat.LongFullPath);
	}

	[SecurityCritical]
	public static long GetSizeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return GetSizeCore(transaction, null, path, pathFormat);
	}

	[SecurityCritical]
	public static long GetSizeTransacted(KernelTransaction transaction, string path)
	{
		return GetSizeCore(transaction, null, path, PathFormat.RelativePath);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SecurityCritical]
	internal static long GetSizeCore(KernelTransaction transaction, SafeFileHandle safeHandle, string path, PathFormat pathFormat)
	{
		bool flag;
		if (!(flag = safeHandle != null))
		{
			string extendedLengthPathCore = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
			safeHandle = CreateFileCore(transaction, false, extendedLengthPathCore, ExtendedFileAttributes.Normal, null, FileMode.Open, FileSystemRights.ListDirectory, FileShare.ReadWrite, checkPath: true, continueOnException: false, PathFormat.LongFullPath);
		}
		try
		{
			long lpFileSize;
			bool fileSizeEx = NativeMethods.GetFileSizeEx(safeHandle, out lpFileSize);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!fileSizeEx)
			{
				if (lastWin32Error != 0L)
				{
					NativeError.ThrowException(lastWin32Error, path);
					return lpFileSize;
				}
				return lpFileSize;
			}
			return lpFileSize;
		}
		finally
		{
			if (!flag && safeHandle != null && !safeHandle.IsClosed)
			{
				safeHandle.Close();
			}
		}
	}

	[SecurityCritical]
	public static FileStream OpenRead(string path)
	{
		return Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
	}

	[SecurityCritical]
	public static FileStream OpenRead(string path, PathFormat pathFormat)
	{
		return Open(path, FileMode.Open, FileAccess.Read, FileShare.Read, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenReadTransacted(KernelTransaction transaction, string path)
	{
		return OpenTransacted(transaction, path, FileMode.Open, FileAccess.Read, FileShare.Read);
	}

	[SecurityCritical]
	public static FileStream OpenReadTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return OpenTransacted(transaction, path, FileMode.Open, FileAccess.Read, FileShare.Read, pathFormat);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamReader OpenText(string path)
	{
		return new StreamReader(OpenRead(path), NativeMethods.DefaultFileEncoding);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SecurityCritical]
	public static StreamReader OpenText(string path, PathFormat pathFormat)
	{
		return new StreamReader(OpenRead(path, pathFormat), NativeMethods.DefaultFileEncoding);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamReader OpenText(string path, Encoding encoding, PathFormat pathFormat)
	{
		return new StreamReader(OpenRead(path, pathFormat), encoding);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SecurityCritical]
	public static StreamReader OpenText(string path, Encoding encoding)
	{
		return new StreamReader(OpenRead(path), encoding);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamReader OpenTextTransacted(KernelTransaction transaction, string path)
	{
		return new StreamReader(OpenReadTransacted(transaction, path), NativeMethods.DefaultFileEncoding);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamReader OpenTextTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return new StreamReader(OpenReadTransacted(transaction, path, pathFormat), NativeMethods.DefaultFileEncoding);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamReader OpenTextTransacted(KernelTransaction transaction, string path, Encoding encoding, PathFormat pathFormat)
	{
		return new StreamReader(OpenReadTransacted(transaction, path, pathFormat), encoding);
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static StreamReader OpenTextTransacted(KernelTransaction transaction, string path, Encoding encoding)
	{
		return new StreamReader(OpenReadTransacted(transaction, path), encoding);
	}

	[SecurityCritical]
	public static FileStream OpenWrite(string path)
	{
		return Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
	}

	[SecurityCritical]
	public static FileStream OpenWrite(string path, PathFormat pathFormat)
	{
		return Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenWriteTransacted(KernelTransaction transaction, string path)
	{
		return OpenTransacted(transaction, path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
	}

	[SecurityCritical]
	public static FileStream OpenWriteTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return OpenTransacted(transaction, path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenBackupRead(string path, PathFormat pathFormat)
	{
		return OpenCore(null, path, FileMode.Open, FileSystemRights.ListDirectory, FileShare.None, ExtendedFileAttributes.ReadOnly | ExtendedFileAttributes.BackupSemantics | ExtendedFileAttributes.SequentialScan, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenBackupRead(string path)
	{
		return OpenCore(null, path, FileMode.Open, FileSystemRights.ListDirectory, FileShare.None, ExtendedFileAttributes.ReadOnly | ExtendedFileAttributes.BackupSemantics | ExtendedFileAttributes.SequentialScan, null, null, PathFormat.RelativePath);
	}

	[SecurityCritical]
	public static FileStream OpenBackupReadTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
	{
		return OpenCore(transaction, path, FileMode.Open, FileSystemRights.ListDirectory, FileShare.None, ExtendedFileAttributes.ReadOnly | ExtendedFileAttributes.BackupSemantics | ExtendedFileAttributes.SequentialScan, null, null, pathFormat);
	}

	[SecurityCritical]
	public static FileStream OpenBackupReadTransacted(KernelTransaction transaction, string path)
	{
		return OpenCore(transaction, path, FileMode.Open, FileSystemRights.ListDirectory, FileShare.None, ExtendedFileAttributes.ReadOnly | ExtendedFileAttributes.BackupSemantics | ExtendedFileAttributes.SequentialScan, null, null, PathFormat.RelativePath);
	}
}
