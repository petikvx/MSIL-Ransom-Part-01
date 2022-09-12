using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class ZipEntryFactory : IEntryFactory
{
	public enum TimeSetting
	{
		LastWriteTime,
		LastWriteTimeUtc,
		CreateTime,
		CreateTimeUtc,
		LastAccessTime,
		LastAccessTimeUtc,
		Fixed
	}

	private DateTime IVywBKNiwQFIcEtFRTqaUVYyohJfb;

	private int WyHAQtXxgjPDtZmRxfcYfeACEgju;

	private bool lEmfBAaQBIhflUBihZOlJVaEtCwK;

	private INameTransform SGDgpaHOzvEwkDmnUMqyKdMqxrBxA;

	private int oRRRzQcmiFrqQvSmIsnZtUAqEHev;

	private TimeSetting CjBqKJqRtzlemPZJogmavadecpDv;

	public DateTime FixedDateTime
	{
		get
		{
			return IVywBKNiwQFIcEtFRTqaUVYyohJfb;
		}
		set
		{
			if (value.Year < 1970)
			{
				throw new ArgumentException("Value is too old to be valid", "value");
			}
			IVywBKNiwQFIcEtFRTqaUVYyohJfb = value;
		}
	}

	public int GetAttributes
	{
		get
		{
			return WyHAQtXxgjPDtZmRxfcYfeACEgju;
		}
		set
		{
			WyHAQtXxgjPDtZmRxfcYfeACEgju = value;
		}
	}

	public bool IsUnicodeText
	{
		get
		{
			return lEmfBAaQBIhflUBihZOlJVaEtCwK;
		}
		set
		{
			lEmfBAaQBIhflUBihZOlJVaEtCwK = value;
		}
	}

	public INameTransform NameTransform
	{
		get
		{
			return SGDgpaHOzvEwkDmnUMqyKdMqxrBxA;
		}
		set
		{
			if (value != null)
			{
				SGDgpaHOzvEwkDmnUMqyKdMqxrBxA = value;
			}
			else
			{
				SGDgpaHOzvEwkDmnUMqyKdMqxrBxA = new ZipNameTransform();
			}
		}
	}

	public int SetAttributes
	{
		get
		{
			return oRRRzQcmiFrqQvSmIsnZtUAqEHev;
		}
		set
		{
			oRRRzQcmiFrqQvSmIsnZtUAqEHev = value;
		}
	}

	public TimeSetting Setting
	{
		get
		{
			return CjBqKJqRtzlemPZJogmavadecpDv;
		}
		set
		{
			CjBqKJqRtzlemPZJogmavadecpDv = value;
		}
	}

	public ZipEntryFactory()
	{
		IVywBKNiwQFIcEtFRTqaUVYyohJfb = DateTime.Now;
		WyHAQtXxgjPDtZmRxfcYfeACEgju = -1;
		SGDgpaHOzvEwkDmnUMqyKdMqxrBxA = new ZipNameTransform();
	}

	public ZipEntryFactory(TimeSetting timeSetting)
	{
		IVywBKNiwQFIcEtFRTqaUVYyohJfb = DateTime.Now;
		WyHAQtXxgjPDtZmRxfcYfeACEgju = -1;
		CjBqKJqRtzlemPZJogmavadecpDv = timeSetting;
		SGDgpaHOzvEwkDmnUMqyKdMqxrBxA = new ZipNameTransform();
	}

	public ZipEntryFactory(DateTime time)
	{
		IVywBKNiwQFIcEtFRTqaUVYyohJfb = DateTime.Now;
		WyHAQtXxgjPDtZmRxfcYfeACEgju = -1;
		CjBqKJqRtzlemPZJogmavadecpDv = TimeSetting.Fixed;
		FixedDateTime = time;
		SGDgpaHOzvEwkDmnUMqyKdMqxrBxA = new ZipNameTransform();
	}

	public ZipEntry MakeDirectoryEntry(string directoryName)
	{
		return MakeDirectoryEntry(directoryName, useFileSystem: true);
	}

	public ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem)
	{
		ZipEntry zipEntry = new ZipEntry(SGDgpaHOzvEwkDmnUMqyKdMqxrBxA.TransformDirectory(directoryName))
		{
			Size = 0L
		};
		int num = 0;
		DirectoryInfo directoryInfo = null;
		if (useFileSystem)
		{
			directoryInfo = new DirectoryInfo(directoryName);
		}
		if (directoryInfo != null && directoryInfo.Exists)
		{
			switch (CjBqKJqRtzlemPZJogmavadecpDv)
			{
			default:
				throw new ZipException("Unhandled time setting in MakeDirectoryEntry");
			case TimeSetting.LastWriteTime:
				zipEntry.DateTime = directoryInfo.LastWriteTime;
				break;
			case TimeSetting.LastWriteTimeUtc:
				zipEntry.DateTime = directoryInfo.LastWriteTimeUtc;
				break;
			case TimeSetting.CreateTime:
				zipEntry.DateTime = directoryInfo.CreationTime;
				break;
			case TimeSetting.CreateTimeUtc:
				zipEntry.DateTime = directoryInfo.CreationTimeUtc;
				break;
			case TimeSetting.LastAccessTime:
				zipEntry.DateTime = directoryInfo.LastAccessTime;
				break;
			case TimeSetting.LastAccessTimeUtc:
				zipEntry.DateTime = directoryInfo.LastAccessTimeUtc;
				break;
			case TimeSetting.Fixed:
				zipEntry.DateTime = IVywBKNiwQFIcEtFRTqaUVYyohJfb;
				break;
			}
			num = (int)directoryInfo.Attributes & WyHAQtXxgjPDtZmRxfcYfeACEgju;
		}
		else if (CjBqKJqRtzlemPZJogmavadecpDv == TimeSetting.Fixed)
		{
			zipEntry.DateTime = IVywBKNiwQFIcEtFRTqaUVYyohJfb;
		}
		num = (zipEntry.ExternalFileAttributes = num | (oRRRzQcmiFrqQvSmIsnZtUAqEHev | 0x10));
		return zipEntry;
	}

	public ZipEntry MakeFileEntry(string fileName)
	{
		return MakeFileEntry(fileName, useFileSystem: true);
	}

	public ZipEntry MakeFileEntry(string fileName, bool useFileSystem)
	{
		ZipEntry zipEntry = new ZipEntry(SGDgpaHOzvEwkDmnUMqyKdMqxrBxA.TransformFile(fileName))
		{
			IsUnicodeText = lEmfBAaQBIhflUBihZOlJVaEtCwK
		};
		int num = 0;
		bool flag = oRRRzQcmiFrqQvSmIsnZtUAqEHev != 0;
		FileInfo fileInfo = null;
		if (useFileSystem)
		{
			fileInfo = new FileInfo(fileName);
		}
		if (fileInfo == null || !fileInfo.Exists)
		{
			if (CjBqKJqRtzlemPZJogmavadecpDv == TimeSetting.Fixed)
			{
				zipEntry.DateTime = IVywBKNiwQFIcEtFRTqaUVYyohJfb;
			}
		}
		else
		{
			switch (CjBqKJqRtzlemPZJogmavadecpDv)
			{
			default:
				throw new ZipException("Unhandled time setting in MakeFileEntry");
			case TimeSetting.LastWriteTime:
				zipEntry.DateTime = fileInfo.LastWriteTime;
				break;
			case TimeSetting.LastWriteTimeUtc:
				zipEntry.DateTime = fileInfo.LastWriteTimeUtc;
				break;
			case TimeSetting.CreateTime:
				zipEntry.DateTime = fileInfo.CreationTime;
				break;
			case TimeSetting.CreateTimeUtc:
				zipEntry.DateTime = fileInfo.CreationTimeUtc;
				break;
			case TimeSetting.LastAccessTime:
				zipEntry.DateTime = fileInfo.LastAccessTime;
				break;
			case TimeSetting.LastAccessTimeUtc:
				zipEntry.DateTime = fileInfo.LastAccessTimeUtc;
				break;
			case TimeSetting.Fixed:
				zipEntry.DateTime = IVywBKNiwQFIcEtFRTqaUVYyohJfb;
				break;
			}
			zipEntry.Size = fileInfo.Length;
			flag = true;
			num = (int)fileInfo.Attributes & WyHAQtXxgjPDtZmRxfcYfeACEgju;
		}
		if (flag)
		{
			num = (zipEntry.ExternalFileAttributes = num | oRRRzQcmiFrqQvSmIsnZtUAqEHev);
		}
		return zipEntry;
	}
}
