using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
public sealed class DiskSpaceInfo
{
	[NonSerialized]
	private readonly bool _initGetClusterInfo = true;

	[NonSerialized]
	private readonly bool _initGetSpaceInfo = true;

	[NonSerialized]
	private readonly CultureInfo _cultureInfo = CultureInfo.CurrentCulture;

	[NonSerialized]
	private readonly bool _continueOnAccessError;

	public string AvailableFreeSpacePercent => PercentCalculate(TotalNumberOfBytes - (TotalNumberOfBytes - TotalNumberOfFreeBytes), 0.0, TotalNumberOfBytes).ToString("0.##", _cultureInfo) + "%";

	public string AvailableFreeSpaceUnitSize => Utils.UnitSizeToText(TotalNumberOfFreeBytes, _cultureInfo);

	public long ClusterSize => SectorsPerCluster * BytesPerSector;

	public string DriveName { get; private set; }

	public string TotalSizeUnitSize => Utils.UnitSizeToText(TotalNumberOfBytes, _cultureInfo);

	public string UsedSpacePercent => PercentCalculate(TotalNumberOfBytes - FreeBytesAvailable, 0.0, TotalNumberOfBytes).ToString("0.##", _cultureInfo) + "%";

	public string UsedSpaceUnitSize => Utils.UnitSizeToText(TotalNumberOfBytes - FreeBytesAvailable, _cultureInfo);

	public long FreeBytesAvailable { get; private set; }

	public long TotalNumberOfBytes { get; private set; }

	public long TotalNumberOfFreeBytes { get; private set; }

	public int BytesPerSector { get; private set; }

	public int NumberOfFreeClusters { get; private set; }

	public int SectorsPerCluster { get; private set; }

	public long TotalNumberOfClusters { get; private set; }

	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	[SecurityCritical]
	public DiskSpaceInfo(string drivePath)
	{
		if (Utils.IsNullOrWhiteSpace(drivePath))
		{
			throw new ArgumentNullException("drivePath");
		}
		string text;
		if (drivePath.Length != 1)
		{
			text = Path.GetPathRoot(drivePath, checkInvalidPathChars: false);
		}
		else
		{
			string text2 = drivePath;
			char volumeSeparatorChar = Path.VolumeSeparatorChar;
			text = text2 + volumeSeparatorChar;
		}
		drivePath = text;
		if (Utils.IsNullOrWhiteSpace(drivePath))
		{
			throw new ArgumentException(Resources.InvalidDriveLetterArgument, "drivePath");
		}
		DriveName = Path.AddTrailingDirectorySeparator(drivePath, addAlternateSeparator: false);
	}

	[SecurityCritical]
	public DiskSpaceInfo(string drivePath, bool? spaceInfoType, bool refresh, bool continueOnException)
		: this(drivePath)
	{
		if (!spaceInfoType.HasValue)
		{
			_initGetClusterInfo = true;
			_initGetSpaceInfo = true;
		}
		else
		{
			_initGetSpaceInfo = (!spaceInfoType).Value;
			_initGetClusterInfo = spaceInfoType.Value;
		}
		_continueOnAccessError = continueOnException;
		if (refresh)
		{
			Refresh();
		}
	}

	public void Refresh()
	{
		Reset();
		using (new NativeMethods.ChangeErrorMode(NativeMethods.ErrorMode.FailCriticalErrors))
		{
			if (_initGetSpaceInfo)
			{
				long lpFreeBytesAvailable;
				long lpTotalNumberOfBytes;
				long lpTotalNumberOfFreeBytes;
				bool diskFreeSpaceExW = NativeMethods.GetDiskFreeSpaceExW(DriveName, out lpFreeBytesAvailable, out lpTotalNumberOfBytes, out lpTotalNumberOfFreeBytes);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!diskFreeSpaceExW && !_continueOnAccessError && lastWin32Error != 21L)
				{
					NativeError.ThrowException(lastWin32Error, DriveName);
				}
				FreeBytesAvailable = lpFreeBytesAvailable;
				TotalNumberOfBytes = lpTotalNumberOfBytes;
				TotalNumberOfFreeBytes = lpTotalNumberOfFreeBytes;
			}
			if (_initGetClusterInfo)
			{
				int lpSectorsPerCluster;
				int lpBytesPerSector;
				int lpNumberOfFreeClusters;
				uint lpTotalNumberOfClusters;
				bool diskFreeSpaceW = NativeMethods.GetDiskFreeSpaceW(DriveName, out lpSectorsPerCluster, out lpBytesPerSector, out lpNumberOfFreeClusters, out lpTotalNumberOfClusters);
				int lastWin32Error = Marshal.GetLastWin32Error();
				if (!diskFreeSpaceW && !_continueOnAccessError && lastWin32Error != 21L)
				{
					NativeError.ThrowException(lastWin32Error, DriveName);
				}
				BytesPerSector = lpBytesPerSector;
				NumberOfFreeClusters = lpNumberOfFreeClusters;
				SectorsPerCluster = lpSectorsPerCluster;
				TotalNumberOfClusters = lpTotalNumberOfClusters;
			}
		}
	}

	private void Reset()
	{
		if (_initGetSpaceInfo)
		{
			FreeBytesAvailable = 0L;
			TotalNumberOfBytes = 0L;
			TotalNumberOfFreeBytes = 0L;
		}
		if (_initGetClusterInfo)
		{
			BytesPerSector = 0;
			NumberOfFreeClusters = 0;
			SectorsPerCluster = 0;
			TotalNumberOfClusters = 0L;
		}
	}

	public override string ToString()
	{
		return DriveName;
	}

	private static double PercentCalculate(double currentValue, double minimumValue, double maximumValue)
	{
		if (!(currentValue < 0.0) && !(maximumValue <= 0.0))
		{
			return currentValue * 100.0 / (maximumValue - minimumValue);
		}
		return 0.0;
	}
}
