using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Security;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
[SecurityCritical]
public sealed class DriveInfo
{
	[NonSerialized]
	private readonly VolumeInfo _volumeInfo;

	[NonSerialized]
	private readonly DiskSpaceInfo _dsi;

	[NonSerialized]
	private bool _initDsie;

	[NonSerialized]
	private DriveType? _driveType;

	[NonSerialized]
	private string _dosDeviceName;

	[NonSerialized]
	private DirectoryInfo _rootDirectory;

	[NonSerialized]
	private readonly string _name;

	public long AvailableFreeSpace
	{
		get
		{
			GetDeviceInfo(3, 0);
			if (_dsi != null)
			{
				return _dsi.FreeBytesAvailable;
			}
			return 0L;
		}
	}

	public string DriveFormat => (string)GetDeviceInfo(0, 1);

	public DriveType DriveType => (DriveType)GetDeviceInfo(2, 0);

	public bool IsReady => File.ExistsCore(null, isFolder: true, Name, PathFormat.LongFullPath);

	public string Name => _name;

	public DirectoryInfo RootDirectory => (DirectoryInfo)GetDeviceInfo(2, 1);

	public long TotalFreeSpace
	{
		get
		{
			GetDeviceInfo(3, 0);
			if (_dsi != null)
			{
				return _dsi.TotalNumberOfFreeBytes;
			}
			return 0L;
		}
	}

	public long TotalSize
	{
		get
		{
			GetDeviceInfo(3, 0);
			if (_dsi != null)
			{
				return _dsi.TotalNumberOfBytes;
			}
			return 0L;
		}
	}

	public string VolumeLabel
	{
		get
		{
			return (string)GetDeviceInfo(0, 2);
		}
		set
		{
			Volume.SetVolumeLabel(Name, value);
		}
	}

	public DiskSpaceInfo DiskSpaceInfo
	{
		get
		{
			GetDeviceInfo(3, 0);
			return _dsi;
		}
	}

	public string DosDeviceName => (string)GetDeviceInfo(1, 0);

	public bool IsDosDeviceSubstitute
	{
		get
		{
			if (!Utils.IsNullOrWhiteSpace(DosDeviceName))
			{
				return DosDeviceName.StartsWith(Path.NonInterpretedPathPrefix, StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}
	}

	public bool IsUnc
	{
		get
		{
			if (!IsDosDeviceSubstitute && DriveType == DriveType.Network)
			{
				return true;
			}
			if (Name.StartsWith(Path.UncPrefix, StringComparison.Ordinal) && DriveType == DriveType.NoRootDirectory)
			{
				return DriveFormat.Equals(DriveType.Unknown.ToString(), StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}
	}

	public bool IsVolume => GetDeviceInfo(0, 0) != null;

	public VolumeInfo VolumeInfo => (VolumeInfo)GetDeviceInfo(0, 0);

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Justification = "Utils.IsNullOrWhiteSpace validates arguments.")]
	public DriveInfo(string driveName)
	{
		if (Utils.IsNullOrWhiteSpace(driveName))
		{
			throw new ArgumentNullException("driveName");
		}
		string text;
		if (driveName.Length != 1)
		{
			text = Path.GetPathRoot(driveName, checkInvalidPathChars: false);
		}
		else
		{
			string text2 = driveName;
			char volumeSeparatorChar = Path.VolumeSeparatorChar;
			text = text2 + volumeSeparatorChar;
		}
		driveName = text;
		if (Utils.IsNullOrWhiteSpace(driveName))
		{
			throw new ArgumentException(Resources.InvalidDriveLetterArgument, "driveName");
		}
		_name = Path.AddTrailingDirectorySeparator(driveName, addAlternateSeparator: false);
		_volumeInfo = new VolumeInfo(_name, refresh: false, continueOnException: true);
		_dsi = new DiskSpaceInfo(_name, null, refresh: false, continueOnException: true);
	}

	[SecurityCritical]
	public static DriveInfo[] GetDrives()
	{
		return Directory.EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: false).ToArray();
	}

	public override string ToString()
	{
		return _name;
	}

	[SecurityCritical]
	public static IEnumerable<DriveInfo> EnumerateDrives(bool fromEnvironment, bool isReady)
	{
		return Directory.EnumerateLogicalDrivesCore(fromEnvironment, isReady);
	}

	public static char GetFreeDriveLetter()
	{
		return GetFreeDriveLetter(getLastAvailable: false);
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public static char GetFreeDriveLetter(bool getLastAvailable)
	{
		IEnumerable<char> source = "CDEFGHIJKLMNOPQRSTUVWXYZ".Except(from d in Directory.EnumerateLogicalDrivesCore(fromEnvironment: false, isReady: false)
			select d.Name[0]);
		try
		{
			return getLastAvailable ? source.Last() : source.First();
		}
		catch
		{
			throw new ArgumentOutOfRangeException(Resources.No_Drive_Letters_Available);
		}
	}

	[SecurityCritical]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private object GetDeviceInfo(int type, int mode)
	{
		try
		{
			switch (type)
			{
			case 0:
				if (Utils.IsNullOrWhiteSpace(_volumeInfo.FullPath))
				{
					_volumeInfo.Refresh();
				}
				switch (mode)
				{
				case 0:
					return _volumeInfo;
				case 1:
					return (_volumeInfo == null) ? DriveType.Unknown.ToString() : (_volumeInfo.FileSystemName ?? DriveType.Unknown.ToString());
				case 2:
					return (_volumeInfo == null) ? string.Empty : (_volumeInfo.Name ?? string.Empty);
				}
				break;
			case 1:
				if (mode == 0)
				{
					return _dosDeviceName ?? (_dosDeviceName = Volume.GetVolumeDeviceName(Name));
				}
				break;
			case 2:
				switch (mode)
				{
				case 1:
					return _rootDirectory ?? (_rootDirectory = new DirectoryInfo(null, Name, PathFormat.RelativePath));
				case 0:
					return _driveType ?? (_driveType = Volume.GetDriveType(Name));
				}
				break;
			case 3:
				if (mode == 0 && !_initDsie)
				{
					_dsi.Refresh();
					_initDsie = true;
				}
				break;
			}
		}
		catch
		{
		}
		if (type == 0 && mode > 0)
		{
			return string.Empty;
		}
		return null;
	}
}
