using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Alphaleonis.Win32.Network;
using Alphaleonis.Win32.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

public static class Path
{
	internal static readonly char[] TrimEndChars = new char[8] { '\t', '\n', '\v', '\f', '\r', ' ', '\u0085', '\u00a0' };

	public static readonly char AltDirectorySeparatorChar = System.IO.Path.AltDirectorySeparatorChar;

	public static readonly string AltDirectorySeparator = AltDirectorySeparatorChar.ToString(CultureInfo.InvariantCulture);

	public static readonly char DirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;

	public static readonly string DirectorySeparator = DirectorySeparatorChar.ToString(CultureInfo.InvariantCulture);

	public const char NetworkDriveSeparatorChar = '$';

	public static readonly string NetworkDriveSeparator = '$'.ToString(CultureInfo.InvariantCulture);

	public static readonly char PathSeparator = System.IO.Path.PathSeparator;

	public static readonly char VolumeSeparatorChar = System.IO.Path.VolumeSeparatorChar;

	public static readonly string VolumeSeparator = VolumeSeparatorChar.ToString(CultureInfo.InvariantCulture);

	public static readonly char StreamSeparatorChar = ':';

	public static readonly string StreamSeparator = StreamSeparatorChar.ToString(CultureInfo.InvariantCulture);

	public static readonly string StreamDataLabel = StreamSeparator + "$DATA";

	public const char StringTerminatorChar = '\0';

	public const char CurrentDirectoryPrefixChar = '.';

	public static readonly string CurrentDirectoryPrefix = '.'.ToString(CultureInfo.InvariantCulture);

	public const char ExtensionSeparatorChar = '.';

	public const string ParentDirectoryPrefix = "..";

	public const char WildcardStarMatchAllChar = '*';

	public static readonly string WildcardStarMatchAll = '*'.ToString(CultureInfo.InvariantCulture);

	public const char WildcardQuestionChar = '?';

	public static readonly string WildcardQuestion = '?'.ToString(CultureInfo.InvariantCulture);

	public static readonly string LongPathPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{0}{1}{0}", new object[2] { DirectorySeparatorChar, WildcardQuestion });

	public static readonly string LogicalDrivePrefix = string.Format(CultureInfo.InvariantCulture, "{0}{0}.{0}", new object[1] { DirectorySeparatorChar });

	public static readonly string PhysicalDrivePrefix = string.Format(CultureInfo.InvariantCulture, "{0}PhysicalDrive", new object[1] { LogicalDrivePrefix });

	public static readonly string GlobalRootPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", new object[3] { LongPathPrefix, "GlobalRoot", DirectorySeparatorChar });

	public static readonly string GlobalRootDevicePrefix = string.Format(CultureInfo.InvariantCulture, "{0}{2}{1}{3}{1}", LongPathPrefix, DirectorySeparatorChar, "GlobalRoot", "Device");

	public static readonly string NonInterpretedPathPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}{1}{0}", new object[2] { DirectorySeparatorChar, WildcardQuestion });

	public static readonly string VolumePrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}", new object[2] { LongPathPrefix, "Volume" });

	public static readonly string DevicePrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}{0}", new object[2] { DirectorySeparatorChar, "Device" });

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lanman")]
	[Obsolete("Unused")]
	public static readonly string DosDeviceLanmanPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", new object[3] { DevicePrefix, "LanmanRedirector", DirectorySeparatorChar });

	[Obsolete("Unused")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Mup")]
	public static readonly string DosDeviceMupPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", new object[3] { DevicePrefix, "Mup", DirectorySeparatorChar });

	public static readonly string UncPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{0}", new object[1] { DirectorySeparatorChar });

	public static readonly string DosDeviceUncPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", new object[3] { NonInterpretedPathPrefix, "UNC", DirectorySeparatorChar });

	public static readonly string LongPathUncPrefix = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", new object[3] { LongPathPrefix, "UNC", DirectorySeparatorChar });

	[SecurityCritical]
	public static string ChangeExtension(string path, string extension)
	{
		return System.IO.Path.ChangeExtension(path, extension);
	}

	[SecurityCritical]
	public static string AddTrailingDirectorySeparator(string path)
	{
		return AddTrailingDirectorySeparator(path, addAlternateSeparator: false);
	}

	[SecurityCritical]
	public static string AddTrailingDirectorySeparator(string path, bool addAlternateSeparator)
	{
		if (path != null)
		{
			char directorySeparatorChar;
			if (!addAlternateSeparator)
			{
				directorySeparatorChar = DirectorySeparatorChar;
				if (path.EndsWith(directorySeparatorChar.ToString(CultureInfo.InvariantCulture), StringComparison.Ordinal))
				{
					return path;
				}
				directorySeparatorChar = DirectorySeparatorChar;
				return path + directorySeparatorChar;
			}
			directorySeparatorChar = AltDirectorySeparatorChar;
			if (path.EndsWith(directorySeparatorChar.ToString(CultureInfo.InvariantCulture), StringComparison.Ordinal))
			{
				return path;
			}
			directorySeparatorChar = AltDirectorySeparatorChar;
			return path + directorySeparatorChar;
		}
		return null;
	}

	[SecurityCritical]
	public static bool IsUncPath(string path)
	{
		return IsUncPathCore(path, isRegularPath: false, checkInvalidPathChars: true);
	}

	[SecurityCritical]
	internal static bool IsUncPathCore(string path, bool isRegularPath, bool checkInvalidPathChars)
	{
		if (!isRegularPath)
		{
			path = GetRegularPathCore(path, checkInvalidPathChars ? GetFullPathOptions.CheckInvalidPathChars : GetFullPathOptions.None, allowEmpty: false);
		}
		else if (checkInvalidPathChars)
		{
			CheckInvalidPathChars(path, checkAdditional: false, allowEmpty: false);
		}
		if (Uri.TryCreate(path, UriKind.Absolute, out var result))
		{
			return result.IsUnc;
		}
		return false;
	}

	[SecurityCritical]
	public static string GetMappedUncName(string path)
	{
		return Host.GetRemoteNameInfoCore(path, continueOnException: true).lpUniversalName;
	}

	public static bool IsValidName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return name.IndexOfAny(GetInvalidFileNameChars()) < 0;
	}

	[SecurityCritical]
	public static bool IsPathRooted(string path)
	{
		return IsPathRooted(path, checkInvalidPathChars: true);
	}

	[SecurityCritical]
	public static bool IsPathRooted(string path, bool checkInvalidPathChars)
	{
		if (path != null)
		{
			if (checkInvalidPathChars)
			{
				CheckInvalidPathChars(path, checkAdditional: false, allowEmpty: true);
			}
			int length = path.Length;
			if ((length >= 1 && IsDVsc(path[0], false)) || (length >= 2 && IsDVsc(path[1], true)))
			{
				return true;
			}
		}
		return false;
	}

	[SecurityCritical]
	public static bool HasExtension(string path)
	{
		return System.IO.Path.HasExtension(path);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	public static bool IsLongPath(string path)
	{
		if (!Utils.IsNullOrWhiteSpace(path))
		{
			return path.StartsWith(LongPathPrefix, StringComparison.Ordinal);
		}
		return false;
	}

	[SecurityCritical]
	public static string GetShort83Path(string path)
	{
		return GetLongShort83PathCore(null, path, getShort: true);
	}

	[SecurityCritical]
	public static string GetShort83PathTransacted(KernelTransaction transaction, string path)
	{
		return GetLongShort83PathCore(transaction, path, getShort: true);
	}

	[SecurityCritical]
	private static string GetLongShort83PathCore(KernelTransaction transaction, string path, bool getShort)
	{
		string fullPathCore = GetFullPathCore(transaction, path, GetFullPathOptions.FullCheck | GetFullPathOptions.AsLongPath);
		StringBuilder stringBuilder = new StringBuilder();
		uint num = (getShort ? NativeMethods.GetShortPathNameW(fullPathCore, null, 0u) : ((uint)path.Length));
		while (num > stringBuilder.Capacity)
		{
			stringBuilder = new StringBuilder((int)num);
			num = (getShort ? NativeMethods.GetShortPathNameW(fullPathCore, stringBuilder, (uint)stringBuilder.Capacity) : ((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.GetLongPathNameW(fullPathCore, stringBuilder, (uint)stringBuilder.Capacity) : NativeMethods.GetLongPathNameTransactedW(fullPathCore, stringBuilder, (uint)stringBuilder.Capacity, transaction.SafeHandle)));
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (num == 0)
			{
				NativeError.ThrowException(lastWin32Error, fullPathCore);
			}
		}
		return GetRegularPathCore(stringBuilder.ToString(), GetFullPathOptions.None, allowEmpty: false);
	}

	[SecurityCritical]
	public static string GetRegularPath(string path)
	{
		return GetRegularPathCore(path, GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false);
	}

	[SecurityCritical]
	internal static string GetRegularPathCore(string path, GetFullPathOptions options, bool allowEmpty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (!allowEmpty && (path.Length == 0 || Utils.IsNullOrWhiteSpace(path)))
		{
			throw new ArgumentException(Resources.Path_Is_Zero_Length_Or_Only_White_Space, "path");
		}
		if (options != 0)
		{
			path = ApplyFullPathOptions(path, options);
		}
		if (!path.StartsWith(DosDeviceUncPrefix, StringComparison.OrdinalIgnoreCase))
		{
			if (!path.StartsWith(NonInterpretedPathPrefix, StringComparison.Ordinal))
			{
				if (!path.StartsWith(GlobalRootPrefix, StringComparison.OrdinalIgnoreCase) && !path.StartsWith(VolumePrefix, StringComparison.OrdinalIgnoreCase) && path.StartsWith(LongPathPrefix, StringComparison.Ordinal))
				{
					if (!path.StartsWith(LongPathUncPrefix, StringComparison.OrdinalIgnoreCase))
					{
						return path.Substring(LongPathPrefix.Length);
					}
					return UncPrefix + path.Substring(LongPathUncPrefix.Length);
				}
				return path;
			}
			return path.Substring(NonInterpretedPathPrefix.Length);
		}
		return UncPrefix + path.Substring(DosDeviceUncPrefix.Length);
	}

	[SecurityCritical]
	public static string GetLongFrom83ShortPath(string path)
	{
		return GetLongShort83PathCore(null, path, getShort: false);
	}

	[SecurityCritical]
	public static string GetLongFrom83ShortPathTransacted(KernelTransaction transaction, string path)
	{
		return GetLongShort83PathCore(transaction, path, getShort: false);
	}

	[SecurityCritical]
	public static string GetLongPath(string path)
	{
		return GetLongPathCore(path, GetFullPathOptions.None);
	}

	[SecurityCritical]
	internal static string GetLongPathCore(string path, GetFullPathOptions options)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (path.Length != 0 && !Utils.IsNullOrWhiteSpace(path))
		{
			if (options != 0)
			{
				path = ApplyFullPathOptions(path, options);
			}
			if (path.Length > 2 && !path.StartsWith(LongPathPrefix, StringComparison.Ordinal) && !path.StartsWith(LogicalDrivePrefix, StringComparison.Ordinal) && !path.StartsWith(NonInterpretedPathPrefix, StringComparison.Ordinal))
			{
				if (path.StartsWith(UncPrefix, StringComparison.Ordinal))
				{
					return LongPathUncPrefix + path.Substring(UncPrefix.Length);
				}
				if (IsPathRooted(path, checkInvalidPathChars: false) && IsLogicalDriveCore(path, isRegularPath: false, PathFormat.LongFullPath))
				{
					return LongPathPrefix + path;
				}
				return path;
			}
			return path;
		}
		throw new ArgumentException(Resources.Path_Is_Zero_Length_Or_Only_White_Space, "path");
	}

	[SecurityCritical]
	public static string GetSuffixedDirectoryName(string path)
	{
		return GetSuffixedDirectoryNameCore(null, path);
	}

	[SecurityCritical]
	public static string GetSuffixedDirectoryNameTransacted(KernelTransaction transaction, string path)
	{
		return GetSuffixedDirectoryNameCore(transaction, path);
	}

	[SecurityCritical]
	private static string GetSuffixedDirectoryNameCore(KernelTransaction transaction, string path)
	{
		DirectoryInfo parentCore = Directory.GetParentCore(transaction, path, PathFormat.RelativePath);
		if (null != parentCore && null != parentCore.Parent && parentCore.Name != null)
		{
			return AddTrailingDirectorySeparator(CombineCore(false, parentCore.Parent.FullName, parentCore.Name), addAlternateSeparator: false);
		}
		return null;
	}

	[SecurityCritical]
	public static string RemoveTrailingDirectorySeparator(string path)
	{
		return path?.TrimEnd(DirectorySeparatorChar, AltDirectorySeparatorChar);
	}

	[SecurityCritical]
	public static string RemoveTrailingDirectorySeparator(string path, bool removeAlternateSeparator)
	{
		return path?.TrimEnd(new char[1] { removeAlternateSeparator ? AltDirectorySeparatorChar : DirectorySeparatorChar });
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[SecurityCritical]
	public static string GetTempFileName()
	{
		return System.IO.Path.GetTempFileName();
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[SecurityCritical]
	public static string GetRandomFileName()
	{
		return System.IO.Path.GetRandomFileName();
	}

	[SecurityCritical]
	public static string GetDirectoryName(string path)
	{
		return GetDirectoryName(path, checkInvalidPathChars: true);
	}

	[SecurityCritical]
	public static string GetDirectoryName(string path, bool checkInvalidPathChars)
	{
		if (path != null)
		{
			int rootLength = GetRootLength(path, checkInvalidPathChars);
			if (path.Length > rootLength)
			{
				int num = path.Length;
				if (num == rootLength)
				{
					return null;
				}
				while (num > rootLength && path[--num] != DirectorySeparatorChar && path[num] != AltDirectorySeparatorChar)
				{
				}
				return path.Substring(0, num).Replace(AltDirectorySeparatorChar, DirectorySeparatorChar);
			}
		}
		return null;
	}

	[SecurityCritical]
	public static string GetDirectoryNameWithoutRoot(string path)
	{
		return GetDirectoryNameWithoutRootTransacted(null, path);
	}

	[SecurityCritical]
	public static string GetDirectoryNameWithoutRootTransacted(KernelTransaction transaction, string path)
	{
		if (path == null)
		{
			return null;
		}
		DirectoryInfo parentCore = Directory.GetParentCore(transaction, path, PathFormat.RelativePath);
		if (null != parentCore && null != parentCore.Parent)
		{
			return parentCore.Name;
		}
		return null;
	}

	[SecurityCritical]
	public static string GetExtension(string path)
	{
		return GetExtension(path, !Utils.IsNullOrWhiteSpace(path));
	}

	[SecurityCritical]
	public static string GetExtension(string path, bool checkInvalidPathChars)
	{
		if (path == null)
		{
			return null;
		}
		if (checkInvalidPathChars)
		{
			CheckInvalidPathChars(path, checkAdditional: false, allowEmpty: true);
		}
		int length = path.Length;
		int num = length;
		while (--num >= 0)
		{
			char c = path[num];
			if (c != '.')
			{
				if (IsDVsc(c, null))
				{
					break;
				}
				continue;
			}
			if (num == length - 1)
			{
				return string.Empty;
			}
			return path.Substring(num, length - num);
		}
		return string.Empty;
	}

	[SecurityCritical]
	public static string GetFileName(string path)
	{
		return GetFileName(path, checkInvalidPathChars: true);
	}

	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	public static string GetFileName(string path, bool checkInvalidPathChars)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			return path;
		}
		if (checkInvalidPathChars)
		{
			CheckInvalidPathChars(path, checkAdditional: false, allowEmpty: true);
		}
		int length = path.Length;
		int num = length;
		do
		{
			if (--num < 0)
			{
				return path;
			}
		}
		while (!IsDVsc(path[num], null));
		return path.Substring(num + 1, length - num - 1);
	}

	[SecurityCritical]
	public static string GetFileNameWithoutExtension(string path)
	{
		return GetFileNameWithoutExtension(path, checkInvalidPathChars: true);
	}

	[SecurityCritical]
	public static string GetFileNameWithoutExtension(string path, bool checkInvalidPathChars)
	{
		path = GetFileName(path, checkInvalidPathChars);
		if (path == null)
		{
			return null;
		}
		int length;
		if ((length = path.LastIndexOf('.')) != -1)
		{
			return path.Substring(0, length);
		}
		return path;
	}

	[SecurityCritical]
	public static char[] GetInvalidFileNameChars()
	{
		return System.IO.Path.GetInvalidFileNameChars();
	}

	[SecurityCritical]
	public static char[] GetInvalidPathChars()
	{
		return System.IO.Path.GetInvalidPathChars();
	}

	public static string GetRelativePath(string startPath, string selectedPath)
	{
		if (string.IsNullOrEmpty(startPath))
		{
			throw new ArgumentNullException("startPath");
		}
		if (string.IsNullOrEmpty(selectedPath))
		{
			throw new ArgumentNullException("selectedPath");
		}
		string[] array = startPath.Split(new char[1] { DirectorySeparatorChar });
		string[] array2 = selectedPath.Split(new char[1] { DirectorySeparatorChar });
		int num = array.Length;
		int num2 = array2.Length;
		int num3 = Math.Min(num, num2);
		int num4 = -1;
		for (int i = 0; i < num3 && string.Compare(array[i], array2[i], StringComparison.OrdinalIgnoreCase) == 0; i++)
		{
			num4 = i;
		}
		if (num4 == -1)
		{
			return selectedPath;
		}
		num4++;
		StringBuilder stringBuilder = new StringBuilder();
		for (int j = num4; j < num; j++)
		{
			if (array[j].Length > 0)
			{
				stringBuilder.Append(".." + DirectorySeparator);
			}
		}
		num2--;
		for (int k = num4; k < num2; k++)
		{
			stringBuilder.Append(array2[k] + DirectorySeparator);
		}
		stringBuilder.Append(array2[num2]);
		return stringBuilder.ToString();
	}

	public static string ResolveRelativePath(string startPath, string selectedPath)
	{
		return GetFullPath(Combine(IsPathRooted(startPath) ? startPath : (DirectorySeparator + startPath), IsPathRooted(selectedPath) ? selectedPath : (DirectorySeparator + selectedPath)), GetFullPathOptions.FullCheck);
	}

	public static bool IsLogicalDrive(string path)
	{
		return IsLogicalDriveCore(path, isRegularPath: false, PathFormat.FullPath);
	}

	internal static bool IsLogicalDriveCore(string path, bool isRegularPath, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath)
		{
			if (Utils.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentNullException("path");
			}
			CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
		}
		if (!isRegularPath)
		{
			path = GetRegularPathCore(path, GetFullPathOptions.None, allowEmpty: false);
		}
		string obj = (path.StartsWith(LogicalDrivePrefix, StringComparison.OrdinalIgnoreCase) ? path.Substring(LogicalDrivePrefix.Length) : path);
		char c = obj.ToUpperInvariant()[0];
		if (obj[1] == VolumeSeparatorChar && c >= 'A')
		{
			return c <= 'Z';
		}
		return false;
	}

	[SecurityCritical]
	public static string GetMappedConnectionName(string path)
	{
		return Host.GetRemoteNameInfoCore(path, continueOnException: true).lpConnectionName;
	}

	internal static void CheckInvalidUncPath(string path)
	{
		if (!IsLongPath(path) && path.StartsWith(UncPrefix, StringComparison.Ordinal))
		{
			string text = GetRegularPathCore(path, GetFullPathOptions.None, allowEmpty: false).TrimStart(DirectorySeparatorChar, AltDirectorySeparatorChar);
			if (text.Length >= 2 && text[0] == '.')
			{
				throw new ArgumentException(Resources.UNC_Path_Should_Match_Format, "path");
			}
		}
	}

	internal static void CheckSupportedPathFormat(string path, bool checkInvalidPathChars, bool checkAdditional)
	{
		if (Utils.IsNullOrWhiteSpace(path) || path.Length == 1)
		{
			return;
		}
		string regularPathCore = GetRegularPathCore(path, GetFullPathOptions.None, allowEmpty: false);
		bool flag;
		if ((flag = regularPathCore[0] == VolumeSeparatorChar) || (regularPathCore.Length >= 2 && regularPathCore.IndexOf(VolumeSeparatorChar, 2) != -1))
		{
			if (flag)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Resources.Unsupported_Path_Format, new object[1] { regularPathCore }), "path");
			}
			throw new NotSupportedException(string.Format(CultureInfo.InvariantCulture, Resources.Unsupported_Path_Format, new object[1] { regularPathCore }));
		}
		if (checkInvalidPathChars)
		{
			CheckInvalidPathChars(path, checkAdditional, allowEmpty: false);
		}
	}

	[SecurityCritical]
	private static void CheckInvalidPathChars(string path, bool checkAdditional, bool allowEmpty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (!allowEmpty && (path.Trim().Length == 0 || Utils.IsNullOrWhiteSpace(path)))
		{
			throw new ArgumentException(Resources.Path_Is_Zero_Length_Or_Only_White_Space, "path");
		}
		string text = GetRegularPathCore(path, GetFullPathOptions.None, allowEmpty);
		if (text.StartsWith(GlobalRootPrefix, StringComparison.OrdinalIgnoreCase))
		{
			text = text.ReplaceIgnoreCase(GlobalRootPrefix, string.Empty);
		}
		if (text.StartsWith(VolumePrefix, StringComparison.OrdinalIgnoreCase))
		{
			text = text.ReplaceIgnoreCase(VolumePrefix, string.Empty);
		}
		int num = 0;
		int length = text.Length;
		int num2;
		while (true)
		{
			if (num >= length)
			{
				return;
			}
			num2 = text[num];
			switch (num2)
			{
			default:
				if (num2 >= 32 && (!checkAdditional || (num2 != 63 && num2 != 42)))
				{
					goto IL_00bf;
				}
				break;
			case 34:
			case 60:
			case 62:
			case 124:
				break;
			}
			break;
			IL_00bf:
			num++;
		}
		throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Resources.Illegal_Characters_In_Path, new object[1] { (char)num2 }), "path");
	}

	[SecurityCritical]
	internal static string GetCleanExceptionPath(string path)
	{
		return GetRegularPathCore(path, GetFullPathOptions.None, allowEmpty: true).TrimEnd(DirectorySeparatorChar, '*');
	}

	[SecurityCritical]
	internal static string GetExtendedLengthPathCore(KernelTransaction transaction, string path, PathFormat pathFormat, GetFullPathOptions options)
	{
		if (path == null)
		{
			return null;
		}
		switch (pathFormat)
		{
		default:
			throw new ArgumentException("Invalid value: " + pathFormat, "pathFormat");
		case PathFormat.RelativePath:
			options &= ~GetFullPathOptions.TrimEnd;
			return GetFullPathCore(transaction, path, GetFullPathOptions.AsLongPath | options);
		case PathFormat.FullPath:
			return GetLongPathCore(path, GetFullPathOptions.None);
		case PathFormat.LongFullPath:
			if (options != 0)
			{
				options &= ~GetFullPathOptions.CheckAdditional;
				options &= ~GetFullPathOptions.CheckInvalidPathChars;
				options &= ~GetFullPathOptions.FullCheck;
				options &= ~GetFullPathOptions.TrimEnd;
				path = ApplyFullPathOptions(path, options);
			}
			return path;
		}
	}

	[SecurityCritical]
	internal static int GetRootLength(string path, bool checkInvalidPathChars)
	{
		if (checkInvalidPathChars)
		{
			CheckInvalidPathChars(path, checkAdditional: false, allowEmpty: false);
		}
		int i = 0;
		int length = path.Length;
		if (length >= 1 && IsDVsc(path[0], false))
		{
			i = 1;
			if (length >= 2 && IsDVsc(path[1], false))
			{
				i = 2;
				int num = 2;
				for (; i < length; i++)
				{
					if (IsDVsc(path[i], false) && --num <= 0)
					{
						break;
					}
				}
			}
		}
		else if (length >= 2 && IsDVsc(path[1], true))
		{
			i = 2;
			if (length >= 3 && IsDVsc(path[2], false))
			{
				i++;
			}
		}
		return i;
	}

	[SecurityCritical]
	internal static bool IsDVsc(char c, bool? checkSeparatorChar)
	{
		if (checkSeparatorChar.HasValue)
		{
			if (!checkSeparatorChar.Value)
			{
				if (c != DirectorySeparatorChar)
				{
					return c == AltDirectorySeparatorChar;
				}
				return true;
			}
			return c == VolumeSeparatorChar;
		}
		if (c != DirectorySeparatorChar && c != AltDirectorySeparatorChar)
		{
			return c == VolumeSeparatorChar;
		}
		return true;
	}

	[SuppressMessage("Microsoft.Performance", "CA1809:AvoidExcessiveLocals")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static string NormalizePath(string path, GetFullPathOptions options)
	{
		StringBuilder stringBuilder = new StringBuilder(32700);
		int num = 0;
		uint num2 = 0u;
		uint num3 = 0u;
		bool flag = false;
		uint num4 = 0u;
		int num5 = -1;
		bool startedWithVolumeSeparator = false;
		bool flag2 = true;
		int num6 = 0;
		if (path.Trim().Length > 0 && (path[0] == DirectorySeparatorChar || path[0] == AltDirectorySeparatorChar))
		{
			stringBuilder.Append(DirectorySeparatorChar);
			num++;
			num5 = 0;
		}
		while (true)
		{
			if (num < path.Length)
			{
				char c = path[num];
				if (c != DirectorySeparatorChar && c != AltDirectorySeparatorChar)
				{
					switch (c)
					{
					case '.':
						num3++;
						break;
					default:
						flag = false;
						if (flag2 && c == VolumeSeparatorChar)
						{
							char c2 = ((num > 0) ? path[num - 1] : ' ');
							if (num3 != 0 || num4 < 1 || c2 == ' ')
							{
								throw new ArgumentException(path, "path");
							}
							startedWithVolumeSeparator = true;
							if (num4 > 1)
							{
								int i;
								for (i = 0; i < stringBuilder.Length && stringBuilder[i] == ' '; i++)
								{
								}
								if (num4 - i == 1L)
								{
									stringBuilder.Length = 0;
									stringBuilder.Append(c2);
								}
							}
							num4 = 0u;
						}
						else
						{
							num4 += 1 + num3 + num2;
						}
						if (num3 != 0 || num2 != 0)
						{
							int num7 = ((num5 >= 0) ? (num - num5 - 1) : num);
							if (num7 > 0)
							{
								for (int j = 0; j < num7; j++)
								{
									stringBuilder.Append(path[num5 + 1 + j]);
								}
							}
							num3 = 0u;
							num2 = 0u;
						}
						stringBuilder.Append(c);
						num5 = num;
						break;
					case ' ':
						num2++;
						break;
					}
				}
				else
				{
					if (num4 == 0)
					{
						if (num3 != 0)
						{
							stringBuilder.Append((object?)NormalizePathDotSpaceHandler(path, num5, num3, startedWithVolumeSeparator));
							flag = false;
						}
						if (num2 != 0 && flag2 && num + 1 < path.Length && (path[num + 1] == DirectorySeparatorChar || path[num + 1] == AltDirectorySeparatorChar))
						{
							stringBuilder.Append(DirectorySeparatorChar);
						}
					}
					num3 = 0u;
					num2 = 0u;
					if (!flag)
					{
						flag = true;
						stringBuilder.Append(DirectorySeparatorChar);
					}
					num4 = 0u;
					num5 = num;
					startedWithVolumeSeparator = false;
					flag2 = false;
					int num8 = stringBuilder.Length - 1;
					if (num8 - num6 - 1 > 255)
					{
						throw new PathTooLongException(path);
					}
					num6 = num8;
				}
				num++;
				continue;
			}
			if (stringBuilder.Length - 1 - num6 > 255)
			{
				throw new PathTooLongException(path);
			}
			if (num4 == 0 && num3 != 0)
			{
				stringBuilder.Append((object?)NormalizePathDotSpaceHandler(path, num5, num3, startedWithVolumeSeparator));
			}
			if (stringBuilder.Length == 0)
			{
				throw new ArgumentException(path, "path");
			}
			if ((options & GetFullPathOptions.FullCheck) != 0)
			{
				string text = stringBuilder.ToString();
				if (text.StartsWith(Uri.UriSchemeHttp + ":", StringComparison.OrdinalIgnoreCase) || text.StartsWith(Uri.UriSchemeFile + ":", StringComparison.OrdinalIgnoreCase))
				{
					throw new ArgumentException(path, "path");
				}
			}
			if (stringBuilder.Length <= 1 || stringBuilder[0] != DirectorySeparatorChar || stringBuilder[1] != DirectorySeparatorChar)
			{
				break;
			}
			int k;
			for (k = 2; k < 1; k++)
			{
				if (stringBuilder[k] == DirectorySeparatorChar)
				{
					k++;
					break;
				}
			}
			if (k != 1)
			{
				break;
			}
			throw new ArgumentException(path, "path");
		}
		return stringBuilder.ToString();
	}

	private static StringBuilder NormalizePathDotSpaceHandler(string path, int lastSigChar, uint numDots, bool startedWithVolumeSeparator)
	{
		StringBuilder stringBuilder = new StringBuilder(32700);
		int num = lastSigChar + 1;
		if (path[num] != '.')
		{
			throw new ArgumentException(path, "path");
		}
		if (numDots >= 2)
		{
			if (startedWithVolumeSeparator && numDots > 2)
			{
				throw new ArgumentException(path, "path");
			}
			if (path[num + 1] == '.')
			{
				for (int i = num + 2; i < num + numDots; i++)
				{
					if (path[i] != '.')
					{
						throw new ArgumentException(path, "path");
					}
				}
				numDots = 2u;
			}
			else
			{
				if (numDots > 1)
				{
					throw new ArgumentException(path, "path");
				}
				numDots = 1u;
			}
		}
		if (numDots == 2)
		{
			stringBuilder.Append('.');
		}
		stringBuilder.Append('.');
		return stringBuilder;
	}

	[SecurityCritical]
	public static string GetPathRoot(string path)
	{
		return GetPathRoot(path, checkInvalidPathChars: true);
	}

	[SecurityCritical]
	public static string GetPathRoot(string path, bool checkInvalidPathChars)
	{
		if (path == null)
		{
			return null;
		}
		if (path.Trim().Length == 0)
		{
			throw new ArgumentException(Resources.Path_Is_Zero_Length_Or_Only_White_Space, "path");
		}
		string regularPathCore = GetRegularPathCore(path, checkInvalidPathChars ? GetFullPathOptions.CheckInvalidPathChars : GetFullPathOptions.None, allowEmpty: false);
		int rootLength = GetRootLength(path, checkInvalidPathChars: false);
		int rootLength2 = GetRootLength(regularPathCore, checkInvalidPathChars: false);
		if (rootLength2 == 0 && path.StartsWith(LongPathPrefix, StringComparison.Ordinal))
		{
			return GetLongPathCore(path.Substring(0, rootLength), GetFullPathOptions.None);
		}
		if (!path.StartsWith(LongPathUncPrefix, StringComparison.OrdinalIgnoreCase))
		{
			return path.Substring(0, rootLength);
		}
		return GetLongPathCore(regularPathCore.Substring(0, rootLength2), GetFullPathOptions.None);
	}

	[SecurityCritical]
	public static string GetFinalPathNameByHandle(SafeFileHandle handle)
	{
		return GetFinalPathNameByHandleCore(handle, FinalPathFormats.None);
	}

	[SecurityCritical]
	public static string GetFinalPathNameByHandle(SafeFileHandle handle, FinalPathFormats finalPath)
	{
		return GetFinalPathNameByHandleCore(handle, finalPath);
	}

	[SecurityCritical]
	internal static string GetFinalPathNameByHandleCore(SafeFileHandle handle, FinalPathFormats finalPath)
	{
		NativeMethods.IsValidHandle(handle);
		StringBuilder stringBuilder = new StringBuilder(32700);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			if (NativeMethods.IsAtLeastWindowsVista)
			{
				bool num = NativeMethods.GetFinalPathNameByHandleW(handle, stringBuilder, (uint)stringBuilder.Capacity, finalPath) == 0;
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!num && lastWin32Error != 0L)
				{
					NativeError.ThrowException(lastWin32Error);
				}
				return stringBuilder.ToString();
			}
		}
		if (!NativeMethods.GetFileSizeEx(handle, out var lpFileSize) && lpFileSize == 0L)
		{
			return string.Empty;
		}
		using (SafeFileHandle hFileMappingObject = NativeMethods.CreateFileMappingW(handle, null, 2u, 0u, 1u, null))
		{
			NativeMethods.IsValidHandle(handle, Marshal.GetLastWin32Error());
			using SafeLocalMemoryBufferHandle safeLocalMemoryBufferHandle = NativeMethods.MapViewOfFile(hFileMappingObject, 4u, 0u, 0u, (UIntPtr)1uL);
			if (NativeMethods.IsValidHandle(safeLocalMemoryBufferHandle, Marshal.GetLastWin32Error()) && NativeMethods.GetMappedFileNameW(Process.GetCurrentProcess().Handle, safeLocalMemoryBufferHandle, stringBuilder, (uint)stringBuilder.Capacity))
			{
				NativeMethods.UnmapViewOfFile(safeLocalMemoryBufferHandle);
			}
		}
		string text = ((stringBuilder.Length > 0) ? stringBuilder.ToString() : string.Empty);
		switch (finalPath)
		{
		case FinalPathFormats.VolumeNameGuid:
		{
			string text2 = DosDeviceToDosPath(text, null);
			if (!Utils.IsNullOrWhiteSpace(text2))
			{
				string driveLetter = RemoveTrailingDirectorySeparator(GetPathRoot(text2, checkInvalidPathChars: false));
				string fileName = GetFileName(text2, checkInvalidPathChars: true);
				if (!Utils.IsNullOrWhiteSpace(fileName))
				{
					using IEnumerator<string> enumerator = (from drv in Directory.EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: false)
						select drv.Name into drv
						where driveLetter.Equals(RemoveTrailingDirectorySeparator(drv), StringComparison.OrdinalIgnoreCase)
						select drv).GetEnumerator();
					if (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						return CombineCore(false, Volume.GetUniqueVolumeNameForPath(current), GetSuffixedDirectoryNameWithoutRootCore(null, text2), fileName);
					}
				}
			}
			goto default;
		}
		case FinalPathFormats.VolumeNameNT:
			return text;
		default:
			if (Utils.IsNullOrWhiteSpace(text))
			{
				return string.Empty;
			}
			return LongPathPrefix + DosDeviceToDosPath(text, null);
		case FinalPathFormats.VolumeNameNone:
			return DosDeviceToDosPath(text, string.Empty);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SecurityCritical]
	private static string DosDeviceToDosPath(string dosDevice, string deviceReplacement)
	{
		if (Utils.IsNullOrWhiteSpace(dosDevice))
		{
			return string.Empty;
		}
		string path;
		foreach (string item in from drv in Directory.EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: false)
			select drv.Name)
		{
			try
			{
				path = RemoveTrailingDirectorySeparator(item);
				string[] array = (from device in Volume.QueryAllDosDevices()
					where device.StartsWith(path, StringComparison.OrdinalIgnoreCase)
					select device).ToArray();
				int num = 0;
				if (0 >= array.Length)
				{
					continue;
				}
				string oldValue = array[num];
				return dosDevice.ReplaceIgnoreCase(oldValue, deviceReplacement ?? path);
			}
			catch
			{
			}
		}
		return string.Empty;
	}

	[SecurityCritical]
	public static string Combine(params string[] paths)
	{
		return CombineCore(checkInvalidPathChars: true, paths);
	}

	[SecurityCritical]
	internal static string CombineCore(bool checkInvalidPathChars, params string[] paths)
	{
		if (paths == null)
		{
			throw new ArgumentNullException("paths");
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = paths.Length;
		StringBuilder stringBuilder;
		while (true)
		{
			if (num3 < num4)
			{
				if (paths[num3] != null)
				{
					if (paths[num3].Length != 0)
					{
						if (IsPathRooted(paths[num3], checkInvalidPathChars))
						{
							num2 = num3;
							num = paths[num3].Length;
						}
						else
						{
							num += paths[num3].Length;
						}
						if (!IsDVsc(paths[num3][paths[num3].Length - 1], null))
						{
							num++;
						}
					}
					num3++;
					continue;
				}
				throw new ArgumentNullException("paths");
			}
			stringBuilder = new StringBuilder(num);
			for (int i = num2; i < paths.Length; i++)
			{
				if (paths[i].Length == 0)
				{
					continue;
				}
				if (stringBuilder.Length == 0)
				{
					stringBuilder.Append(paths[i]);
					continue;
				}
				if (!IsDVsc(stringBuilder[stringBuilder.Length - 1], null))
				{
					stringBuilder.Append(DirectorySeparatorChar);
				}
				stringBuilder.Append(paths[i]);
			}
			break;
		}
		return stringBuilder.ToString();
	}

	[SecurityCritical]
	public static string GetFullPath(string path)
	{
		return GetFullPathTackleCore(null, path, GetFullPathOptions.None);
	}

	[SecurityCritical]
	public static string GetFullPath(string path, GetFullPathOptions options)
	{
		return GetFullPathTackleCore(null, path, options);
	}

	[SecurityCritical]
	public static string GetFullPathTransacted(KernelTransaction transaction, string path)
	{
		return GetFullPathTackleCore(transaction, path, GetFullPathOptions.None);
	}

	[SecurityCritical]
	public static string GetFullPathTransacted(KernelTransaction transaction, string path, GetFullPathOptions options)
	{
		return GetFullPathTackleCore(transaction, path, options);
	}

	[SecurityCritical]
	internal static string GetFullPathCore(KernelTransaction transaction, string path, GetFullPathOptions options)
	{
		if (path != null && (path.StartsWith(GlobalRootPrefix, StringComparison.OrdinalIgnoreCase) || path.StartsWith(VolumePrefix, StringComparison.OrdinalIgnoreCase) || path.StartsWith(NonInterpretedPathPrefix, StringComparison.Ordinal)))
		{
			return path;
		}
		if (options != 0)
		{
			if ((options & GetFullPathOptions.CheckInvalidPathChars) != 0)
			{
				bool flag = (options & GetFullPathOptions.CheckAdditional) != 0;
				CheckInvalidPathChars(path, flag, allowEmpty: false);
				options &= ~GetFullPathOptions.CheckInvalidPathChars;
				if (flag)
				{
					options &= ~GetFullPathOptions.CheckAdditional;
				}
			}
			if (path == null || path.Length <= 3 || (!path.StartsWith(LongPathPrefix, StringComparison.Ordinal) && path[1] != VolumeSeparatorChar))
			{
				options &= ~GetFullPathOptions.RemoveTrailingDirectorySeparator;
			}
		}
		string longPathCore = GetLongPathCore(path, options);
		uint num = 32700u;
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			StringBuilder stringBuilder;
			while (true)
			{
				stringBuilder = new StringBuilder((int)num);
				uint num2 = ((transaction == null || !NativeMethods.IsAtLeastWindowsVista) ? NativeMethods.GetFullPathNameW(longPathCore, num, stringBuilder, IntPtr.Zero) : NativeMethods.GetFullPathNameTransactedW(longPathCore, num, stringBuilder, IntPtr.Zero, transaction.SafeHandle));
				if (num2 != 0)
				{
					if (num2 <= num)
					{
						break;
					}
					num = num2;
					continue;
				}
				if ((options & GetFullPathOptions.ContinueOnNonExist) != 0)
				{
					return null;
				}
				NativeError.ThrowException(num2, longPathCore);
				break;
			}
			string path2 = (((options & GetFullPathOptions.AsLongPath) != 0) ? GetLongPathCore(stringBuilder.ToString(), GetFullPathOptions.None) : GetRegularPathCore(stringBuilder.ToString(), GetFullPathOptions.None, allowEmpty: false));
			path2 = NormalizePath(path2, options);
			if ((options & GetFullPathOptions.KeepDotOrSpace) != 0)
			{
				if (longPathCore.EndsWith(CurrentDirectoryPrefix, StringComparison.Ordinal))
				{
					path2 += CurrentDirectoryPrefix;
				}
				char c = longPathCore[longPathCore.Length - 1];
				if (char.IsWhiteSpace(c))
				{
					path2 += c;
				}
			}
			return path2;
		}
	}

	private static string GetFullPathTackleCore(KernelTransaction transaction, string path, GetFullPathOptions options)
	{
		if (path != null)
		{
			if (path.StartsWith(GlobalRootPrefix, StringComparison.OrdinalIgnoreCase) || path.StartsWith(VolumePrefix, StringComparison.OrdinalIgnoreCase))
			{
				return path;
			}
			CheckInvalidUncPath(path);
		}
		CheckSupportedPathFormat(path, checkInvalidPathChars: true, checkAdditional: true);
		return GetFullPathCore(transaction, path, options);
	}

	private static string ApplyFullPathOptions(string path, GetFullPathOptions options)
	{
		if ((options & GetFullPathOptions.TrimEnd) != 0 && (options & GetFullPathOptions.KeepDotOrSpace) == 0)
		{
			path = path.TrimEnd(new char[0]);
		}
		if ((options & GetFullPathOptions.AddTrailingDirectorySeparator) != 0)
		{
			path = AddTrailingDirectorySeparator(path, addAlternateSeparator: false);
		}
		if ((options & GetFullPathOptions.RemoveTrailingDirectorySeparator) != 0)
		{
			path = RemoveTrailingDirectorySeparator(path);
		}
		if ((options & GetFullPathOptions.CheckInvalidPathChars) != 0)
		{
			CheckInvalidPathChars(path, (options & GetFullPathOptions.CheckAdditional) != 0, allowEmpty: false);
		}
		if ((options & GetFullPathOptions.KeepDotOrSpace) == 0)
		{
			path = path.TrimStart(new char[0]);
		}
		return path;
	}

	[SecurityCritical]
	public static string GetSuffixedDirectoryNameWithoutRoot(string path)
	{
		return GetSuffixedDirectoryNameWithoutRootCore(null, path);
	}

	[SecurityCritical]
	public static string GetSuffixedDirectoryNameWithoutRootTransacted(KernelTransaction transaction, string path)
	{
		return GetSuffixedDirectoryNameWithoutRootCore(transaction, path);
	}

	[SecurityCritical]
	private static string GetSuffixedDirectoryNameWithoutRootCore(KernelTransaction transaction, string path)
	{
		DirectoryInfo parentCore = Directory.GetParentCore(transaction, path, PathFormat.RelativePath);
		if (!(null == parentCore) && !(null == parentCore.Parent))
		{
			DirectoryInfo directoryInfo = parentCore;
			string text;
			do
			{
				text = directoryInfo.DisplayPath.Replace(parentCore.Root.ToString(), string.Empty);
				if (null != directoryInfo.Parent)
				{
					directoryInfo = parentCore.Parent.Parent;
				}
			}
			while (null != directoryInfo && null != directoryInfo.Root.Parent && null != directoryInfo.Parent && !Utils.IsNullOrWhiteSpace(directoryInfo.Parent.ToString()));
			if (!Utils.IsNullOrWhiteSpace(text))
			{
				return AddTrailingDirectorySeparator(text.TrimStart(new char[1] { DirectorySeparatorChar }), addAlternateSeparator: false);
			}
			return null;
		}
		return null;
	}

	[SecurityCritical]
	public static string LocalToUnc(string localPath)
	{
		return LocalToUncCore(localPath, PathFormat.RelativePath, GetFullPathOptions.None);
	}

	[SecurityCritical]
	public static string LocalToUnc(string localPath, PathFormat pathFormat)
	{
		return LocalToUncCore(localPath, pathFormat, GetFullPathOptions.None);
	}

	[SecurityCritical]
	public static string LocalToUnc(string localPath, PathFormat pathFormat, GetFullPathOptions fullPathOptions)
	{
		return LocalToUncCore(localPath, pathFormat, fullPathOptions);
	}

	[SecurityCritical]
	public static string LocalToUnc(string localPath, GetFullPathOptions fullPathOptions)
	{
		return LocalToUncCore(localPath, PathFormat.RelativePath, fullPathOptions);
	}

	[SecurityCritical]
	internal static string LocalToUncCore(string localPath, PathFormat pathFormat, GetFullPathOptions fullPathOptions)
	{
		if (Utils.IsNullOrWhiteSpace(localPath))
		{
			return null;
		}
		if (pathFormat == PathFormat.RelativePath)
		{
			CheckSupportedPathFormat(localPath, checkInvalidPathChars: true, checkAdditional: true);
		}
		bool flag = (fullPathOptions & GetFullPathOptions.AddTrailingDirectorySeparator) != 0;
		bool flag2 = (fullPathOptions & GetFullPathOptions.RemoveTrailingDirectorySeparator) != 0;
		if (flag && flag2)
		{
			throw new ArgumentException(Resources.GetFullPathOptions_Add_And_Remove_DirectorySeparator_Invalid, "fullPathOptions");
		}
		if (!flag2 && !flag && localPath.EndsWith(DirectorySeparator, StringComparison.Ordinal))
		{
			fullPathOptions &= ~GetFullPathOptions.RemoveTrailingDirectorySeparator;
			fullPathOptions |= GetFullPathOptions.AddTrailingDirectorySeparator;
		}
		bool flag3 = (fullPathOptions & GetFullPathOptions.AsLongPath) != 0;
		string text = GetRegularPathCore(localPath, fullPathOptions | GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false);
		if (!IsUncPathCore(text, isRegularPath: true, checkInvalidPathChars: false))
		{
			if (text[0] == '.' || !IsPathRooted(text, checkInvalidPathChars: false))
			{
				text = GetFullPathCore(null, text, GetFullPathOptions.None);
			}
			if (Utils.IsNullOrWhiteSpace(GetPathRoot(text, checkInvalidPathChars: false)))
			{
				return text;
			}
			Alphaleonis.Win32.Network.NativeMethods.REMOTE_NAME_INFO remoteNameInfoCore = Host.GetRemoteNameInfoCore(text, continueOnException: true);
			if (!Utils.IsNullOrWhiteSpace(remoteNameInfoCore.lpUniversalName))
			{
				if (!flag3)
				{
					return GetRegularPathCore(remoteNameInfoCore.lpUniversalName, fullPathOptions, allowEmpty: false);
				}
				return GetLongPathCore(remoteNameInfoCore.lpUniversalName, fullPathOptions);
			}
			if (!Utils.IsNullOrWhiteSpace(remoteNameInfoCore.lpConnectionName))
			{
				if (!flag3)
				{
					return GetRegularPathCore(remoteNameInfoCore.lpConnectionName, fullPathOptions, allowEmpty: false);
				}
				return GetLongPathCore(remoteNameInfoCore.lpConnectionName, fullPathOptions);
			}
			string[] array = text.Split(new char[1] { VolumeSeparatorChar });
			text = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{3}{4}", Host.GetUncName(), DirectorySeparator, array[0], NetworkDriveSeparator, array[1]);
		}
		if (!flag3)
		{
			return GetRegularPathCore(text, fullPathOptions, allowEmpty: false);
		}
		return GetLongPathCore(text, fullPathOptions);
	}

	[SecurityCritical]
	public static string GetTempPath()
	{
		return System.IO.Path.GetTempPath();
	}

	[SecurityCritical]
	public static string GetTempPath(string combinePath)
	{
		string tempPath = GetTempPath();
		if (Utils.IsNullOrWhiteSpace(combinePath))
		{
			return tempPath;
		}
		return CombineCore(false, tempPath, combinePath);
	}
}
