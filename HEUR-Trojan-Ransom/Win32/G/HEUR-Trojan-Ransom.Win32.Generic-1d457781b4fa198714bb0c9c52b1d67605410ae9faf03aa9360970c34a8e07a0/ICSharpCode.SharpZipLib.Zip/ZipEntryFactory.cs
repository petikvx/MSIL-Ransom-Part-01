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

	private INameTransform nameTransform_;

	private DateTime fixedDateTime_ = DateTime.Now;

	private TimeSetting timeSetting_;

	private bool isUnicodeText_;

	private int getAttributes_ = -1;

	private int setAttributes_;

	public INameTransform NameTransform
	{
		get
		{
			return nameTransform_;
		}
		set
		{
			if (value == null)
			{
				nameTransform_ = new ZipNameTransform();
			}
			else
			{
				nameTransform_ = value;
			}
		}
	}

	public TimeSetting Setting
	{
		get
		{
			return timeSetting_;
		}
		set
		{
			timeSetting_ = value;
		}
	}

	public DateTime FixedDateTime
	{
		get
		{
			return fixedDateTime_;
		}
		set
		{
			if (value.Year < 1970)
			{
				throw new ArgumentException("Value is too old to be valid", "value");
			}
			fixedDateTime_ = value;
		}
	}

	public int GetAttributes
	{
		get
		{
			return getAttributes_;
		}
		set
		{
			getAttributes_ = value;
		}
	}

	public int SetAttributes
	{
		get
		{
			return setAttributes_;
		}
		set
		{
			setAttributes_ = value;
		}
	}

	public bool IsUnicodeText
	{
		get
		{
			return isUnicodeText_;
		}
		set
		{
			isUnicodeText_ = value;
		}
	}

	public ZipEntryFactory()
	{
		nameTransform_ = new ZipNameTransform();
	}

	public ZipEntryFactory(TimeSetting timeSetting)
	{
		timeSetting_ = timeSetting;
		nameTransform_ = new ZipNameTransform();
	}

	public ZipEntryFactory(DateTime time)
	{
		timeSetting_ = TimeSetting.Fixed;
		FixedDateTime = time;
		nameTransform_ = new ZipNameTransform();
	}

	public ZipEntry MakeFileEntry(string fileName)
	{
		return MakeFileEntry(fileName, useFileSystem: true);
	}

	public ZipEntry MakeFileEntry(string fileName, bool useFileSystem)
	{
		ZipEntry zipEntry = new ZipEntry(nameTransform_.TransformFile(fileName));
		zipEntry.IsUnicodeText = isUnicodeText_;
		int num = 0;
		bool flag = setAttributes_ != 0;
		FileInfo fileInfo = null;
		if (useFileSystem)
		{
			fileInfo = new FileInfo(fileName);
		}
		if (fileInfo != null && fileInfo.Exists)
		{
			switch (timeSetting_)
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
				zipEntry.DateTime = fixedDateTime_;
				break;
			}
			zipEntry.Size = fileInfo.Length;
			flag = true;
			num = (int)fileInfo.Attributes & getAttributes_;
		}
		else if (timeSetting_ == TimeSetting.Fixed)
		{
			zipEntry.DateTime = fixedDateTime_;
		}
		if (flag)
		{
			num = (zipEntry.ExternalFileAttributes = num | setAttributes_);
		}
		return zipEntry;
	}

	public ZipEntry MakeDirectoryEntry(string directoryName)
	{
		return MakeDirectoryEntry(directoryName, useFileSystem: true);
	}

	public ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem)
	{
		ZipEntry zipEntry = new ZipEntry(nameTransform_.TransformDirectory(directoryName));
		zipEntry.IsUnicodeText = isUnicodeText_;
		zipEntry.Size = 0L;
		int num = 0;
		DirectoryInfo directoryInfo = null;
		if (useFileSystem)
		{
			directoryInfo = new DirectoryInfo(directoryName);
		}
		if (directoryInfo != null && directoryInfo.Exists)
		{
			switch (timeSetting_)
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
				zipEntry.DateTime = fixedDateTime_;
				break;
			}
			num = (int)directoryInfo.Attributes & getAttributes_;
		}
		else if (timeSetting_ == TimeSetting.Fixed)
		{
			zipEntry.DateTime = fixedDateTime_;
		}
		num = (zipEntry.ExternalFileAttributes = num | (setAttributes_ | 0x10));
		return zipEntry;
	}
}
