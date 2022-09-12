using System;
using System.Globalization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public struct FileIdInfo : IComparable<FileIdInfo>, IEquatable<FileIdInfo>, IComparable
{
	[NonSerialized]
	private readonly long _volumeSerialNumber;

	[NonSerialized]
	private readonly long _fileIdHighPart;

	[NonSerialized]
	private readonly long _fileIdLowPart;

	internal FileIdInfo(NativeMethods.BY_HANDLE_FILE_INFORMATION fibh)
	{
		_volumeSerialNumber = fibh.dwVolumeSerialNumber;
		_fileIdHighPart = 0L;
		_fileIdLowPart = NativeMethods.ToLong(fibh.nFileIndexHigh, fibh.nFileIndexLow);
	}

	internal FileIdInfo(NativeMethods.FILE_ID_INFO fi)
	{
		_volumeSerialNumber = fi.VolumeSerialNumber;
		ArrayToLong(fi.FileId, 0, 8, out _fileIdLowPart);
		ArrayToLong(fi.FileId, 8, 8, out _fileIdHighPart);
	}

	private static void ArrayToLong(byte[] fileId, int startIndex, int count, out long value)
	{
		value = 0L;
		for (int i = 0; i < count; i++)
		{
			value |= (long)((ulong)fileId[startIndex + i] << 8 * i);
		}
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		if (!(obj is FileIdInfo))
		{
			throw new ArgumentException("Object must be of type FileIdInfo");
		}
		return CompareTo((FileIdInfo)obj);
	}

	public int CompareTo(FileIdInfo other)
	{
		if (_volumeSerialNumber == other._volumeSerialNumber)
		{
			if (_fileIdHighPart == other._fileIdHighPart)
			{
				return Math.Sign(_fileIdLowPart - other._fileIdLowPart);
			}
			return Math.Sign(_fileIdHighPart - other._fileIdHighPart);
		}
		return Math.Sign(_volumeSerialNumber - other._volumeSerialNumber);
	}

	public override bool Equals(object obj)
	{
		if (obj is FileIdInfo)
		{
			return Equals((FileIdInfo)obj);
		}
		return false;
	}

	public bool Equals(FileIdInfo other)
	{
		if (_fileIdLowPart == other._fileIdLowPart && _fileIdHighPart == other._fileIdHighPart)
		{
			return _volumeSerialNumber == other._volumeSerialNumber;
		}
		return false;
	}

	public static bool operator ==(FileIdInfo first, FileIdInfo second)
	{
		if (first._fileIdLowPart == second._fileIdLowPart && first._fileIdHighPart == second._fileIdHighPart)
		{
			return first._volumeSerialNumber == second._volumeSerialNumber;
		}
		return false;
	}

	public static bool operator !=(FileIdInfo first, FileIdInfo second)
	{
		if (first._fileIdLowPart == second._fileIdLowPart && first._fileIdHighPart == second._fileIdHighPart)
		{
			return first._volumeSerialNumber != second._volumeSerialNumber;
		}
		return true;
	}

	public static bool operator <(FileIdInfo first, FileIdInfo second)
	{
		if (first._volumeSerialNumber >= second._volumeSerialNumber && first._fileIdHighPart >= second._fileIdHighPart)
		{
			return first._fileIdLowPart < second._fileIdLowPart;
		}
		return true;
	}

	public static bool operator >(FileIdInfo first, FileIdInfo second)
	{
		if (first._volumeSerialNumber <= second._volumeSerialNumber && first._fileIdHighPart <= second._fileIdHighPart)
		{
			return first._fileIdLowPart > second._fileIdLowPart;
		}
		return true;
	}

	public override int GetHashCode()
	{
		return (int)_fileIdLowPart ^ ((int)(_fileIdLowPart >> 32) | (int)_volumeSerialNumber);
	}

	public override string ToString()
	{
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object[] obj = new object[6]
		{
			((uint)(_volumeSerialNumber >> 32)).ToString("X", CultureInfo.InvariantCulture),
			((ushort)(_volumeSerialNumber >> 16)).ToString("X", CultureInfo.InvariantCulture),
			((ushort)_volumeSerialNumber).ToString("X", CultureInfo.InvariantCulture),
			null,
			null,
			null
		};
		long fileIdHighPart = _fileIdHighPart;
		obj[3] = fileIdHighPart.ToString("X", CultureInfo.InvariantCulture);
		obj[4] = ((uint)(_fileIdLowPart >> 32)).ToString("X", CultureInfo.InvariantCulture);
		obj[5] = ((uint)_fileIdLowPart).ToString("X", CultureInfo.InvariantCulture);
		return string.Format(invariantCulture, "{0}-{1}-{2} : {3}-{4}-{5}", obj);
	}
}
