using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
internal sealed class FindFileSystemEntryInfo
{
	[NonSerialized]
	private static readonly Regex WildcardMatchAll = new Regex("^(\\*)+(\\.\\*+)+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	[NonSerialized]
	private Regex _nameFilter;

	[NonSerialized]
	private string _searchPattern = Path.WildcardStarMatchAll;

	public bool AsFileSystemInfo { get; private set; }

	public bool AsLongPath { get; private set; }

	public bool AsString { get; private set; }

	public bool ContinueOnException { get; private set; }

	public bool? FileSystemObjectType { get; private set; }

	public bool IsRelativePath { get; private set; }

	public string OriginalInputPath { get; private set; }

	public string InputPath { get; private set; }

	private string RelativeAbsolutePrefix { get; set; }

	public bool IsDirectory { get; private set; }

	public NativeMethods.FIND_FIRST_EX_FLAGS LargeCache { get; private set; }

	public NativeMethods.FINDEX_INFO_LEVELS FindExInfoLevel { get; private set; }

	public bool Recursive { get; private set; }

	[SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
	public string SearchPattern
	{
		get
		{
			return _searchPattern;
		}
		internal set
		{
			if (value == null)
			{
				throw new ArgumentNullException("SearchPattern");
			}
			_searchPattern = value;
			_nameFilter = ((_searchPattern == Path.WildcardStarMatchAll || WildcardMatchAll.IsMatch(_searchPattern)) ? null : new Regex(string.Format(CultureInfo.InvariantCulture, "^{0}$", new object[1] { Regex.Escape(_searchPattern).Replace("\\*", ".*").Replace("\\?", ".") }), RegexOptions.IgnoreCase | RegexOptions.Compiled));
		}
	}

	public bool SkipReparsePoints { get; private set; }

	public KernelTransaction Transaction { get; private set; }

	public Predicate<FileSystemEntryInfo> InclusionFilter { get; private set; }

	public Predicate<FileSystemEntryInfo> RecursionFilter { get; private set; }

	public ErrorHandler ErrorHandler { get; private set; }

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public FindFileSystemEntryInfo(KernelTransaction transaction, bool isFolder, string path, string searchPattern, DirectoryEnumerationOptions? options, DirectoryEnumerationFilters customFilters, PathFormat pathFormat, Type typeOfT)
	{
		if (!options.HasValue)
		{
			throw new ArgumentNullException("options");
		}
		Transaction = transaction;
		OriginalInputPath = path;
		InputPath = Path.GetExtendedLengthPathCore(transaction, path, pathFormat, GetFullPathOptions.FullCheck | GetFullPathOptions.RemoveTrailingDirectorySeparator);
		IsRelativePath = !Path.IsPathRooted(OriginalInputPath, checkInvalidPathChars: false);
		RelativeAbsolutePrefix = (IsRelativePath ? InputPath.Replace(OriginalInputPath, string.Empty) : null);
		SearchPattern = searchPattern.TrimEnd(Path.TrimEndChars);
		FileSystemObjectType = null;
		DirectoryEnumerationOptions? directoryEnumerationOptions = options & DirectoryEnumerationOptions.ContinueOnException;
		ContinueOnException = directoryEnumerationOptions.GetValueOrDefault() != 0 || !directoryEnumerationOptions.HasValue;
		directoryEnumerationOptions = options & DirectoryEnumerationOptions.AsLongPath;
		AsLongPath = directoryEnumerationOptions.GetValueOrDefault() != 0 || !directoryEnumerationOptions.HasValue;
		AsString = (object)typeOfT == typeof(string);
		AsFileSystemInfo = !AsString && ((object)typeOfT == typeof(FileSystemInfo) || (object)typeOfT.BaseType == typeof(FileSystemInfo));
		directoryEnumerationOptions = options & DirectoryEnumerationOptions.LargeCache;
		LargeCache = ((directoryEnumerationOptions.GetValueOrDefault() != 0 || !directoryEnumerationOptions.HasValue) ? NativeMethods.UseLargeCache : NativeMethods.FIND_FIRST_EX_FLAGS.NONE);
		int findExInfoLevel;
		if (!AsString && !AsFileSystemInfo)
		{
			directoryEnumerationOptions = options & DirectoryEnumerationOptions.BasicSearch;
			if (directoryEnumerationOptions.GetValueOrDefault() == DirectoryEnumerationOptions.None && directoryEnumerationOptions.HasValue)
			{
				findExInfoLevel = 0;
				goto IL_021b;
			}
		}
		findExInfoLevel = (int)NativeMethods.FindexInfoLevel;
		goto IL_021b;
		IL_021b:
		FindExInfoLevel = (NativeMethods.FINDEX_INFO_LEVELS)findExInfoLevel;
		if (customFilters != null)
		{
			InclusionFilter = customFilters.InclusionFilter;
			RecursionFilter = customFilters.RecursionFilter;
			ErrorHandler = customFilters.ErrorFilter;
		}
		if (isFolder)
		{
			IsDirectory = true;
			directoryEnumerationOptions = options & DirectoryEnumerationOptions.Recursive;
			Recursive = directoryEnumerationOptions.GetValueOrDefault() != 0 || !directoryEnumerationOptions.HasValue || RecursionFilter != null;
			directoryEnumerationOptions = options & DirectoryEnumerationOptions.SkipReparsePoints;
			SkipReparsePoints = directoryEnumerationOptions.GetValueOrDefault() != 0 || !directoryEnumerationOptions.HasValue;
			directoryEnumerationOptions = options & DirectoryEnumerationOptions.FilesAndFolders;
			if (directoryEnumerationOptions.GetValueOrDefault() == DirectoryEnumerationOptions.None && directoryEnumerationOptions.HasValue)
			{
				options |= DirectoryEnumerationOptions.FilesAndFolders;
			}
		}
		else
		{
			options &= ~DirectoryEnumerationOptions.Folders;
			options |= DirectoryEnumerationOptions.Files;
		}
		bool? fileSystemObjectType;
		if (((uint?)options & 3u) != 3)
		{
			directoryEnumerationOptions = options & DirectoryEnumerationOptions.Folders;
			fileSystemObjectType = directoryEnumerationOptions.GetValueOrDefault() != 0 || !directoryEnumerationOptions.HasValue;
		}
		else
		{
			fileSystemObjectType = null;
		}
		FileSystemObjectType = fileSystemObjectType;
	}

	private SafeFindFileHandle FindFirstFile(string pathLp, out NativeMethods.WIN32_FIND_DATA win32FindData, bool suppressException = false)
	{
		NativeMethods.FINDEX_SEARCH_OPS searchOption = ((FileSystemObjectType.HasValue && FileSystemObjectType.Value) ? NativeMethods.FINDEX_SEARCH_OPS.SearchLimitToDirectories : NativeMethods.FINDEX_SEARCH_OPS.SearchNameMatch);
		int lastError;
		SafeFindFileHandle safeFindFileHandle = FileSystemInfo.FindFirstFileNative(Transaction, pathLp, FindExInfoLevel, searchOption, LargeCache, out lastError, out win32FindData);
		if (!suppressException && !ContinueOnException && safeFindFileHandle == null)
		{
			uint num = (uint)lastError;
			if (num - 2 <= 1 || num == 21)
			{
				Directory.ExistsDriveOrFolderOrFile(Transaction, pathLp, IsDirectory, lastError, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: true);
			}
			ThrowPossibleException((uint)lastError, pathLp);
		}
		return safeFindFileHandle;
	}

	private FileSystemEntryInfo NewFilesystemEntry(string pathLp, string fileName, NativeMethods.WIN32_FIND_DATA win32FindData)
	{
		string fullPath = (IsRelativePath ? pathLp.Replace(RelativeAbsolutePrefix, string.Empty) : pathLp) + fileName;
		return new FileSystemEntryInfo(win32FindData)
		{
			FullPath = fullPath
		};
	}

	private T NewFileSystemEntryType<T>(bool isFolder, FileSystemEntryInfo fsei, string fileName, string pathLp, NativeMethods.WIN32_FIND_DATA win32FindData)
	{
		if (FileSystemObjectType.HasValue && (!FileSystemObjectType.Value || !isFolder) && (!(!FileSystemObjectType).Value || isFolder))
		{
			return (T)(object)null;
		}
		if (fileName != null && _nameFilter != null && (_nameFilter == null || !_nameFilter.IsMatch(fileName)))
		{
			return (T)(object)null;
		}
		if (fsei == null)
		{
			fsei = NewFilesystemEntry(pathLp, fileName, win32FindData);
		}
		if (!AsString)
		{
			if (InclusionFilter != null && !InclusionFilter(fsei))
			{
				return (T)(object)null;
			}
			if (!AsFileSystemInfo)
			{
				return (T)(object)fsei;
			}
			return (T)(object)(fsei.IsDirectory ? ((FileSystemInfo)new DirectoryInfo(Transaction, fsei.LongFullPath, PathFormat.LongFullPath)
			{
				EntryInfo = fsei
			}) : ((FileSystemInfo)new FileInfo(Transaction, fsei.LongFullPath, PathFormat.LongFullPath)
			{
				EntryInfo = fsei
			}));
		}
		if (InclusionFilter != null && !InclusionFilter(fsei))
		{
			return (T)(object)null;
		}
		return (T)(object)(AsLongPath ? fsei.LongFullPath : fsei.FullPath);
	}

	private void ThrowPossibleException(uint lastError, string pathLp)
	{
		switch (lastError)
		{
		case 18u:
			lastError = 0u;
			break;
		case 2u:
		case 3u:
		case 21u:
			lastError = (IsDirectory ? 3u : 2u);
			break;
		}
		if (lastError != 0)
		{
			string cleanExceptionPath = Path.GetCleanExceptionPath(pathLp);
			if (ErrorHandler == null || !ErrorHandler((int)lastError, new Win32Exception((int)lastError).Message, cleanExceptionPath))
			{
				NativeError.ThrowException(lastError, cleanExceptionPath);
			}
		}
	}

	private void VerifyInstanceType(NativeMethods.WIN32_FIND_DATA win32FindData)
	{
		string cleanExceptionPath = Path.GetCleanExceptionPath(InputPath);
		bool flag = (win32FindData.dwFileAttributes & FileAttributes.Directory) != 0;
		if (IsDirectory)
		{
			if (!flag)
			{
				throw new DirectoryNotFoundException(string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
				{
					3u,
					string.Format(CultureInfo.InvariantCulture, Resources.Target_Directory_Is_A_File, new object[1] { cleanExceptionPath })
				}));
			}
		}
		else if (flag)
		{
			throw new FileNotFoundException(string.Format(CultureInfo.InvariantCulture, "({0}) {1}", new object[2]
			{
				2u,
				string.Format(CultureInfo.InvariantCulture, Resources.Target_File_Is_A_Directory, new object[1] { cleanExceptionPath })
			}));
		}
	}

	[SecurityCritical]
	public IEnumerable<T> Enumerate<T>()
	{
		Queue<string> dirs = new Queue<string>(4096);
		dirs.Enqueue(Path.AddTrailingDirectorySeparator(InputPath, addAlternateSeparator: false));
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			while (dirs.Count > 0)
			{
				string pathLp = dirs.Dequeue();
				NativeMethods.WIN32_FIND_DATA win32FindData;
				using SafeFindFileHandle handle = FindFirstFile(pathLp + Path.WildcardStarMatchAll, out win32FindData);
				if (handle == null)
				{
					continue;
				}
				do
				{
					if (SkipReparsePoints && (win32FindData.dwFileAttributes & FileAttributes.ReparsePoint) != 0)
					{
						continue;
					}
					string cFileName = win32FindData.cFileName;
					bool flag;
					if (!(flag = (win32FindData.dwFileAttributes & FileAttributes.Directory) != 0) || (!cFileName.Equals(Path.CurrentDirectoryPrefix, StringComparison.Ordinal) && !cFileName.Equals("..", StringComparison.Ordinal)))
					{
						FileSystemEntryInfo fileSystemEntryInfo = NewFilesystemEntry(pathLp, cFileName, win32FindData);
						T val = NewFileSystemEntryType<T>(flag, fileSystemEntryInfo, cFileName, pathLp, win32FindData);
						if (flag && Recursive && (RecursionFilter == null || RecursionFilter(fileSystemEntryInfo)))
						{
							dirs.Enqueue(Path.AddTrailingDirectorySeparator(pathLp + cFileName, addAlternateSeparator: false));
						}
						if (val != null)
						{
							yield return val;
						}
					}
				}
				while (NativeMethods.FindNextFileW(handle, out win32FindData));
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!ContinueOnException)
				{
					ThrowPossibleException((uint)lastWin32Error, pathLp);
				}
			}
		}
	}

	[SecurityCritical]
	public T Get<T>()
	{
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			NativeMethods.WIN32_FIND_DATA win32FindData;
			if (!IsDirectory)
			{
				using (SafeFindFileHandle safeFindFileHandle = FindFirstFile(InputPath, out win32FindData))
				{
					if (safeFindFileHandle != null)
					{
						VerifyInstanceType(win32FindData);
						return NewFileSystemEntryType<T>((win32FindData.dwFileAttributes & FileAttributes.Directory) != 0, null, null, InputPath, win32FindData);
					}
					return (T)(object)null;
				}
			}
			using (SafeFindFileHandle safeFindFileHandle2 = FindFirstFile(InputPath, out win32FindData, suppressException: true))
			{
				if (safeFindFileHandle2 == null)
				{
					NativeMethods.WIN32_FILE_ATTRIBUTE_DATA win32AttrData = default(NativeMethods.WIN32_FILE_ATTRIBUTE_DATA);
					int num = File.FillAttributeInfoCore(Transaction, Path.GetRegularPathCore(InputPath, GetFullPathOptions.None, allowEmpty: false), ref win32AttrData, tryAgain: false, returnErrorOnNotFound: true);
					if (num != 0L)
					{
						if (!ContinueOnException)
						{
							uint num2 = (uint)num;
							if (num2 - 2 <= 1 || num2 == 21 || num2 == 67)
							{
								Directory.ExistsDriveOrFolderOrFile(Transaction, InputPath, IsDirectory, num, throwIfDriveNotExists: true, throwIfFolderOrFileNotExists: true);
							}
							ThrowPossibleException((uint)num, InputPath);
						}
						return (T)(object)null;
					}
					NativeMethods.WIN32_FIND_DATA wIN32_FIND_DATA = default(NativeMethods.WIN32_FIND_DATA);
					wIN32_FIND_DATA.cFileName = Path.CurrentDirectoryPrefix;
					wIN32_FIND_DATA.dwFileAttributes = win32AttrData.dwFileAttributes;
					wIN32_FIND_DATA.ftCreationTime = win32AttrData.ftCreationTime;
					wIN32_FIND_DATA.ftLastAccessTime = win32AttrData.ftLastAccessTime;
					wIN32_FIND_DATA.ftLastWriteTime = win32AttrData.ftLastWriteTime;
					wIN32_FIND_DATA.nFileSizeHigh = win32AttrData.nFileSizeHigh;
					wIN32_FIND_DATA.nFileSizeLow = win32AttrData.nFileSizeLow;
					win32FindData = wIN32_FIND_DATA;
				}
				VerifyInstanceType(win32FindData);
			}
			return NewFileSystemEntryType<T>((win32FindData.dwFileAttributes & FileAttributes.Directory) != 0, null, null, InputPath, win32FindData);
		}
	}
}
