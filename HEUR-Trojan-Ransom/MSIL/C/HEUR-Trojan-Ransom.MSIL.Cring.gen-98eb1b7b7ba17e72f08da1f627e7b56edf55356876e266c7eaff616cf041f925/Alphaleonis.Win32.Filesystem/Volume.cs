using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

public static class Volume
{
	[SecurityCritical]
	public static void DeleteDosDevice(string deviceName)
	{
		DefineDosDeviceCore(isDefine: false, deviceName, null, DosDeviceAttributes.RemoveDefinition, exactMatch: false);
	}

	[SecurityCritical]
	public static void DeleteDosDevice(string deviceName, string targetPath)
	{
		DefineDosDeviceCore(isDefine: false, deviceName, targetPath, DosDeviceAttributes.RemoveDefinition, exactMatch: false);
	}

	[SecurityCritical]
	public static void DeleteDosDevice(string deviceName, string targetPath, bool exactMatch)
	{
		DefineDosDeviceCore(isDefine: false, deviceName, targetPath, DosDeviceAttributes.RemoveDefinition, exactMatch);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public static void DeleteDosDevice(string deviceName, string targetPath, DosDeviceAttributes deviceAttributes, bool exactMatch)
	{
		DefineDosDeviceCore(isDefine: false, deviceName, targetPath, deviceAttributes, exactMatch);
	}

	[SecurityCritical]
	public static IEnumerable<string> QueryAllDosDevices()
	{
		return QueryDosDeviceCore(null, sort: true);
	}

	[SecurityCritical]
	public static string QueryDosDevice(string deviceName)
	{
		if (Utils.IsNullOrWhiteSpace(deviceName))
		{
			throw new ArgumentNullException("deviceName");
		}
		string text = QueryDosDeviceCore(deviceName, sort: false).ToArray()[0];
		if (Utils.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		return text;
	}

	[SecurityCritical]
	internal static IEnumerable<string> QueryDosDeviceCore(string deviceName, bool sort)
	{
		if (!Utils.IsNullOrWhiteSpace(deviceName))
		{
			if (deviceName.StartsWith(Path.GlobalRootPrefix, StringComparison.OrdinalIgnoreCase))
			{
				yield return deviceName.Substring(Path.GlobalRootPrefix.Length);
				yield break;
			}
			if (deviceName.StartsWith(Path.VolumePrefix, StringComparison.OrdinalIgnoreCase))
			{
				deviceName = deviceName.Substring(Path.LongPathPrefix.Length);
			}
			deviceName = Path.RemoveTrailingDirectorySeparator(deviceName);
		}
		uint returnedBufferSize = 0u;
		uint bufferSize = (sort ? 4096u : 64u);
		List<string> sortedList = new List<string>(sort ? 256 : 0);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			while (returnedBufferSize == 0)
			{
				char[] cBuffer = new char[bufferSize];
				returnedBufferSize = NativeMethods.QueryDosDeviceW(deviceName, cBuffer, bufferSize);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (returnedBufferSize == 0)
				{
					uint num = (uint)lastWin32Error;
					if (num == 122 || num == 234)
					{
						bufferSize *= 2;
						continue;
					}
					NativeError.ThrowException(lastWin32Error, deviceName);
				}
				StringBuilder buffer = new StringBuilder((int)returnedBufferSize);
				for (int i = 0; i < returnedBufferSize; i++)
				{
					if (cBuffer[i] != 0)
					{
						buffer.Append(cBuffer[i]);
					}
					else if (buffer.Length > 0)
					{
						string text = buffer.ToString();
						text = ((!Utils.IsNullOrWhiteSpace(text)) ? text : null);
						if (sort)
						{
							sortedList.Add(text);
						}
						else
						{
							yield return text;
						}
						buffer.Length = 0;
					}
				}
			}
		}
		if (!sort)
		{
			yield break;
		}
		foreach (string item in sortedList.OrderBy((string devName) => devName))
		{
			yield return item;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SecurityCritical]
	public static string GetDriveFormat(string drivePath)
	{
		string fileSystemName = new VolumeInfo(drivePath, refresh: true, continueOnException: true).FileSystemName;
		if (!Utils.IsNullOrWhiteSpace(fileSystemName))
		{
			return fileSystemName;
		}
		return null;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Nt")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Nt")]
	public static string GetDriveNameForNtDeviceName(string deviceName)
	{
		return (from drive in Directory.EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: false)
			where drive.DosDeviceName.Equals(deviceName, StringComparison.OrdinalIgnoreCase)
			select drive.Name).FirstOrDefault();
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public static DriveType GetCurrentDriveType()
	{
		return GetDriveType(null);
	}

	[SecurityCritical]
	public static DriveType GetDriveType(string drivePath)
	{
		drivePath = Path.AddTrailingDirectorySeparator(drivePath, addAlternateSeparator: false);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			return NativeMethods.GetDriveTypeW(drivePath);
		}
	}

	[SecurityCritical]
	public static DiskSpaceInfo GetDiskFreeSpace(string drivePath)
	{
		return new DiskSpaceInfo(drivePath, null, refresh: true, continueOnException: true);
	}

	[SecurityCritical]
	public static DiskSpaceInfo GetDiskFreeSpace(string drivePath, bool? spaceInfoType)
	{
		return new DiskSpaceInfo(drivePath, spaceInfoType, refresh: true, continueOnException: true);
	}

	[SecurityCritical]
	public static bool IsReady(string drivePath)
	{
		return File.ExistsCore(null, isFolder: true, drivePath, PathFormat.FullPath);
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public static string GetUniqueVolumeNameForPath(string volumePathName)
	{
		if (Utils.IsNullOrWhiteSpace(volumePathName))
		{
			throw new ArgumentNullException("volumePathName");
		}
		try
		{
			return GetVolumeGuid(GetVolumePathName(volumePathName));
		}
		catch
		{
			return null;
		}
	}

	[SecurityCritical]
	public static string GetVolumeDeviceName(string volumeName)
	{
		return QueryDosDevice(volumeName);
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SecurityCritical]
	public static string GetVolumeDisplayName(string volumeName)
	{
		string[] smallestMountPoint = new string[1]
		{
			new string('*', 32700)
		};
		try
		{
			foreach (string item in from m in EnumerateVolumePathNames(volumeName)
				where !Utils.IsNullOrWhiteSpace(m) && m.Length < smallestMountPoint[0].Length
				select m)
			{
				smallestMountPoint[0] = item;
			}
		}
		catch
		{
		}
		string text = ((smallestMountPoint[0][0] == '*') ? null : smallestMountPoint[0]);
		if (!Utils.IsNullOrWhiteSpace(text))
		{
			return text;
		}
		return null;
	}

	[SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke", Justification = "Marshal.GetLastWin32Error() is manipulated.")]
	[SecurityCritical]
	public static string GetVolumeGuid(string volumeMountPoint)
	{
		if (Utils.IsNullOrWhiteSpace(volumeMountPoint))
		{
			throw new ArgumentNullException("volumeMountPoint");
		}
		volumeMountPoint = Path.GetFullPathCore(null, volumeMountPoint, GetFullPathOptions.FullCheck | GetFullPathOptions.AddTrailingDirectorySeparator | GetFullPathOptions.AsLongPath);
		StringBuilder stringBuilder = new StringBuilder(100);
		StringBuilder stringBuilder2 = new StringBuilder(100);
		try
		{
			using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
			{
				return (!NativeMethods.GetVolumeNameForVolumeMountPointW(volumeMountPoint, stringBuilder, (uint)stringBuilder.Capacity)) ? null : (NativeMethods.GetVolumeNameForVolumeMountPointW(Path.AddTrailingDirectorySeparator(stringBuilder.ToString(), addAlternateSeparator: false), stringBuilder2, (uint)stringBuilder2.Capacity) ? stringBuilder2.ToString() : null);
			}
		}
		finally
		{
			uint lastWin32Error = (uint)Marshal.GetLastWin32Error();
			switch (lastWin32Error)
			{
			default:
				NativeError.ThrowException(lastWin32Error, volumeMountPoint);
				break;
			case 123u:
				NativeError.ThrowException(lastWin32Error, volumeMountPoint);
				break;
			case 234u:
				break;
			}
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Nt")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Nt")]
	public static string GetVolumeGuidForNtDeviceName(string dosDevice)
	{
		return (from drive in Directory.EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: false)
			where drive.DosDeviceName.Equals(dosDevice, StringComparison.OrdinalIgnoreCase)
			select drive.VolumeInfo.Guid).FirstOrDefault();
	}

	[SecurityCritical]
	public static VolumeInfo GetVolumeInfo(string volumePath)
	{
		return new VolumeInfo(volumePath, refresh: true, continueOnException: false);
	}

	[SecurityCritical]
	public static VolumeInfo GetVolumeInfo(SafeFileHandle volumeHandle)
	{
		return new VolumeInfo(volumeHandle, refresh: true, continueOnException: true);
	}

	[SecurityCritical]
	public static string GetVolumePathName(string path)
	{
		if (Utils.IsNullOrWhiteSpace(path))
		{
			throw new ArgumentNullException("path");
		}
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			StringBuilder stringBuilder = new StringBuilder(1021);
			bool volumePathNameW = NativeMethods.GetVolumePathNameW(Path.GetFullPathCore(null, path, GetFullPathOptions.FullCheck | GetFullPathOptions.AsLongPath), stringBuilder, (uint)stringBuilder.Capacity);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (volumePathNameW)
			{
				return Path.GetRegularPathCore(stringBuilder.ToString(), GetFullPathOptions.None, allowEmpty: false);
			}
			uint num = (uint)lastWin32Error;
			if (num != 18 && num != 87 && num != 123)
			{
				NativeError.ThrowException(lastWin32Error, path);
			}
			return path;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SecurityCritical]
	public static bool IsSameVolume(string path1, string path2)
	{
		try
		{
			VolumeInfo volumeInfo = new VolumeInfo(GetVolumePathName(path1), refresh: true, continueOnException: true);
			VolumeInfo volumeInfo2 = new VolumeInfo(GetVolumePathName(path2), refresh: true, continueOnException: true);
			return volumeInfo.SerialNumber.Equals(volumeInfo2.SerialNumber) || volumeInfo.Guid.Equals(volumeInfo2.Guid, StringComparison.OrdinalIgnoreCase);
		}
		catch
		{
		}
		return false;
	}

	[SecurityCritical]
	public static bool IsVolume(string volumeMountPoint)
	{
		return !Utils.IsNullOrWhiteSpace(GetVolumeGuid(volumeMountPoint));
	}

	[SecurityCritical]
	public static void DeleteCurrentVolumeLabel()
	{
		SetVolumeLabel(null, null);
	}

	[SecurityCritical]
	public static void DeleteVolumeLabel(string rootPathName)
	{
		if (Utils.IsNullOrWhiteSpace(rootPathName))
		{
			throw new ArgumentNullException("rootPathName");
		}
		SetVolumeLabel(rootPathName, null);
	}

	[SecurityCritical]
	public static string GetVolumeLabel(string volumePath)
	{
		return new VolumeInfo(volumePath, refresh: true, continueOnException: true).Name;
	}

	[SecurityCritical]
	public static void SetCurrentVolumeLabel(string volumeName)
	{
		if (Utils.IsNullOrWhiteSpace(volumeName))
		{
			throw new ArgumentNullException("volumeName");
		}
		bool num = NativeMethods.SetVolumeLabelW(null, volumeName);
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (!num)
		{
			NativeError.ThrowException(lastWin32Error, volumeName);
		}
	}

	[SecurityCritical]
	public static void SetVolumeLabel(string volumePath, string volumeName)
	{
		volumePath = Path.AddTrailingDirectorySeparator(volumePath, addAlternateSeparator: false);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			bool num = NativeMethods.SetVolumeLabelW(volumePath, volumeName);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!num)
			{
				NativeError.ThrowException(lastWin32Error, volumePath, volumeName);
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	[SecurityCritical]
	public static void SetVolumeMountPoint(string volumeMountPoint, string volumeGuid)
	{
		if (Utils.IsNullOrWhiteSpace(volumeMountPoint))
		{
			throw new ArgumentNullException("volumeMountPoint");
		}
		if (Utils.IsNullOrWhiteSpace(volumeGuid))
		{
			throw new ArgumentNullException("volumeGuid");
		}
		if (!volumeGuid.StartsWith(Path.VolumePrefix + "{", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(Resources.Not_A_Valid_Guid, "volumeGuid");
		}
		volumeMountPoint = Path.GetFullPathCore(null, volumeMountPoint, GetFullPathOptions.FullCheck | GetFullPathOptions.AddTrailingDirectorySeparator | GetFullPathOptions.AsLongPath);
		volumeGuid = Path.AddTrailingDirectorySeparator(volumeGuid, addAlternateSeparator: false);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			bool num = NativeMethods.SetVolumeMountPointW(volumeMountPoint, volumeGuid);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!num && lastWin32Error != 145L)
			{
				NativeError.ThrowException(lastWin32Error, volumeGuid);
			}
		}
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateVolumePathNames(string volumeGuid)
	{
		if (Utils.IsNullOrWhiteSpace(volumeGuid))
		{
			throw new ArgumentNullException("volumeGuid");
		}
		if (!volumeGuid.StartsWith(Path.VolumePrefix + "{", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(Resources.Not_A_Valid_Guid, "volumeGuid");
		}
		string lpszVolumeName = Path.AddTrailingDirectorySeparator(volumeGuid, addAlternateSeparator: false);
		uint lpcchReturnLength = 10u;
		char[] array = new char[10];
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			while (!NativeMethods.GetVolumePathNamesForVolumeNameW(lpszVolumeName, array, (uint)array.Length, out lpcchReturnLength))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				uint num = (uint)lastWin32Error;
				if (num != 122 && num != 234)
				{
					NativeError.ThrowException(lastWin32Error, volumeGuid);
				}
				else
				{
					array = new char[lpcchReturnLength];
				}
			}
		}
		StringBuilder buffer = new StringBuilder(array.Length);
		char[] array2 = array;
		foreach (char c in array2)
		{
			if (c != 0)
			{
				buffer.Append(c);
			}
			else if (buffer.Length > 0)
			{
				yield return buffer.ToString();
				buffer.Length = 0;
			}
		}
	}

	[SecurityCritical]
	public static IEnumerable<string> EnumerateVolumeMountPoints(string volumeGuid)
	{
		if (Utils.IsNullOrWhiteSpace(volumeGuid))
		{
			throw new ArgumentNullException("volumeGuid");
		}
		if (!volumeGuid.StartsWith(Path.VolumePrefix + "{", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(Resources.Not_A_Valid_Guid, "volumeGuid");
		}
		volumeGuid = Path.AddTrailingDirectorySeparator(volumeGuid, addAlternateSeparator: false);
		StringBuilder buffer = new StringBuilder(32700);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			using SafeFindVolumeMountPointHandle handle = NativeMethods.FindFirstVolumeMountPointW(volumeGuid, buffer, (uint)buffer.Capacity);
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (!NativeMethods.IsValidHandle(handle, throwException: false))
			{
				uint num = (uint)lastWin32Error;
				if (num == 3 || num == 18)
				{
					yield break;
				}
				NativeError.ThrowException(lastWin32Error, volumeGuid);
			}
			yield return buffer.ToString();
			while (NativeMethods.FindNextVolumeMountPointW(handle, buffer, (uint)buffer.Capacity))
			{
				lastWin32Error = Marshal.GetLastWin32Error();
				bool throwException = lastWin32Error != 18L && lastWin32Error != 3L && lastWin32Error != 234L;
				if (NativeMethods.IsValidHandle(handle, lastWin32Error, volumeGuid, throwException))
				{
					yield return buffer.ToString();
					continue;
				}
				yield break;
			}
		}
	}

	[SecurityCritical]
	public static void DeleteVolumeMountPoint(string volumeMountPoint)
	{
		DeleteVolumeMountPointCore(null, volumeMountPoint, continueOnException: false, continueIfJunction: false, PathFormat.RelativePath);
	}

	[SecurityCritical]
	internal static void DeleteVolumeMountPointCore(KernelTransaction transaction, string volumeMountPoint, bool continueOnException, bool continueIfJunction, PathFormat pathFormat)
	{
		if (pathFormat != PathFormat.LongFullPath)
		{
			Path.CheckSupportedPathFormat(volumeMountPoint, checkInvalidPathChars: true, checkAdditional: true);
		}
		volumeMountPoint = Path.GetExtendedLengthPathCore(transaction, volumeMountPoint, pathFormat, GetFullPathOptions.RemoveTrailingDirectorySeparator);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			bool num = NativeMethods.DeleteVolumeMountPointW(Path.AddTrailingDirectorySeparator(volumeMountPoint, addAlternateSeparator: false));
			int num2 = Marshal.GetLastWin32Error();
			if (!num && !continueOnException && !(num2 == 87L && continueIfJunction))
			{
				if (num2 == 2L)
				{
					num2 = 3;
				}
				NativeError.ThrowException(num2, volumeMountPoint);
			}
		}
	}

	[SecurityCritical]
	public static void DefineDosDevice(string deviceName, string targetPath)
	{
		DefineDosDeviceCore(isDefine: true, deviceName, targetPath, DosDeviceAttributes.None, exactMatch: false);
	}

	[SecurityCritical]
	public static void DefineDosDevice(string deviceName, string targetPath, DosDeviceAttributes deviceAttributes)
	{
		DefineDosDeviceCore(isDefine: true, deviceName, targetPath, deviceAttributes, exactMatch: false);
	}

	[SecurityCritical]
	internal static void DefineDosDeviceCore(bool isDefine, string deviceName, string targetPath, DosDeviceAttributes deviceAttributes, bool exactMatch)
	{
		if (Utils.IsNullOrWhiteSpace(deviceName))
		{
			throw new ArgumentNullException("deviceName");
		}
		if (isDefine)
		{
			deviceName = Path.GetRegularPathCore(deviceName, GetFullPathOptions.RemoveTrailingDirectorySeparator | GetFullPathOptions.CheckInvalidPathChars, allowEmpty: false);
			using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
			{
				bool num = NativeMethods.DefineDosDeviceW(deviceAttributes, deviceName, targetPath);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!num)
				{
					NativeError.ThrowException(lastWin32Error, deviceName, targetPath);
				}
				return;
			}
		}
		if (exactMatch && !Utils.IsNullOrWhiteSpace(targetPath))
		{
			deviceAttributes = deviceAttributes | DosDeviceAttributes.ExactMatchOnRemove | DosDeviceAttributes.RawTargetPath;
		}
		DefineDosDevice(deviceName, targetPath, deviceAttributes);
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[SecurityCritical]
	public static IEnumerable<string> EnumerateVolumes()
	{
		StringBuilder buffer = new StringBuilder(32700);
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			using SafeFindVolumeHandle handle = NativeMethods.FindFirstVolumeW(buffer, (uint)buffer.Capacity);
			int lastWin32Error = Marshal.GetLastWin32Error();
			bool throwException = lastWin32Error != 18L && lastWin32Error != 3L;
			if (!NativeMethods.IsValidHandle(handle, lastWin32Error, string.Empty, throwException))
			{
				yield break;
			}
			yield return buffer.ToString();
			while (NativeMethods.FindNextVolumeW(handle, buffer, (uint)buffer.Capacity))
			{
				lastWin32Error = Marshal.GetLastWin32Error();
				throwException = lastWin32Error != 18L && lastWin32Error != 3L && lastWin32Error != 234L;
				if (NativeMethods.IsValidHandle(handle, lastWin32Error, string.Empty, throwException))
				{
					yield return buffer.ToString();
					continue;
				}
				yield break;
			}
		}
	}
}
