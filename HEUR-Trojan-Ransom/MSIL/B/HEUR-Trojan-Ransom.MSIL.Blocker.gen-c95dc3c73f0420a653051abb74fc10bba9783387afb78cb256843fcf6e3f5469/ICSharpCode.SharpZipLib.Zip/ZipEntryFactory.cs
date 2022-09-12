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

	private DateTime HbupNnvIghcPiISqUrtThOVvMVGi;

	private int BIHgwIdTeYVntcckkHozbLVZuPaQA;

	private bool gAcgPfcCItyJnhhTqhGMdnfaHAzWB;

	private INameTransform RwDJPXdwjQSnmPSSXvWLHFPvKXWg;

	private int lZRRujGSqsIkCKKNDexqDsJdehfJ;

	private TimeSetting FBPOGyQjtKoFeuOursbHDqctPKGT;

	public DateTime FixedDateTime
	{
		get
		{
			return HbupNnvIghcPiISqUrtThOVvMVGi;
		}
		set
		{
			if (value.Year < 1970)
			{
				throw new ArgumentException("Value is too old to be valid", "value");
			}
			HbupNnvIghcPiISqUrtThOVvMVGi = value;
		}
	}

	public int GetAttributes
	{
		get
		{
			return BIHgwIdTeYVntcckkHozbLVZuPaQA;
		}
		set
		{
			BIHgwIdTeYVntcckkHozbLVZuPaQA = value;
		}
	}

	public bool IsUnicodeText
	{
		get
		{
			return gAcgPfcCItyJnhhTqhGMdnfaHAzWB;
		}
		set
		{
			gAcgPfcCItyJnhhTqhGMdnfaHAzWB = value;
		}
	}

	public INameTransform NameTransform
	{
		get
		{
			return RwDJPXdwjQSnmPSSXvWLHFPvKXWg;
		}
		set
		{
			if (value == null)
			{
				RwDJPXdwjQSnmPSSXvWLHFPvKXWg = new ZipNameTransform();
			}
			else
			{
				RwDJPXdwjQSnmPSSXvWLHFPvKXWg = value;
			}
		}
	}

	public int SetAttributes
	{
		get
		{
			return lZRRujGSqsIkCKKNDexqDsJdehfJ;
		}
		set
		{
			lZRRujGSqsIkCKKNDexqDsJdehfJ = value;
		}
	}

	public TimeSetting Setting
	{
		get
		{
			return FBPOGyQjtKoFeuOursbHDqctPKGT;
		}
		set
		{
			FBPOGyQjtKoFeuOursbHDqctPKGT = value;
		}
	}

	public ZipEntryFactory()
	{
		HbupNnvIghcPiISqUrtThOVvMVGi = DateTime.Now;
		BIHgwIdTeYVntcckkHozbLVZuPaQA = -1;
		RwDJPXdwjQSnmPSSXvWLHFPvKXWg = new ZipNameTransform();
	}

	public ZipEntryFactory(TimeSetting timeSetting)
	{
		HbupNnvIghcPiISqUrtThOVvMVGi = DateTime.Now;
		BIHgwIdTeYVntcckkHozbLVZuPaQA = -1;
		FBPOGyQjtKoFeuOursbHDqctPKGT = timeSetting;
		RwDJPXdwjQSnmPSSXvWLHFPvKXWg = new ZipNameTransform();
	}

	public ZipEntryFactory(DateTime time)
	{
		HbupNnvIghcPiISqUrtThOVvMVGi = DateTime.Now;
		BIHgwIdTeYVntcckkHozbLVZuPaQA = -1;
		FBPOGyQjtKoFeuOursbHDqctPKGT = TimeSetting.Fixed;
		FixedDateTime = time;
		RwDJPXdwjQSnmPSSXvWLHFPvKXWg = new ZipNameTransform();
	}

	public ZipEntry MakeDirectoryEntry(string directoryName)
	{
		return MakeDirectoryEntry(directoryName, useFileSystem: true);
	}

	public ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem)
	{
		ZipEntry zipEntry = new ZipEntry(RwDJPXdwjQSnmPSSXvWLHFPvKXWg.TransformDirectory(directoryName))
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
			switch (FBPOGyQjtKoFeuOursbHDqctPKGT)
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
				zipEntry.DateTime = HbupNnvIghcPiISqUrtThOVvMVGi;
				break;
			}
			num = (int)directoryInfo.Attributes & BIHgwIdTeYVntcckkHozbLVZuPaQA;
		}
		else if (FBPOGyQjtKoFeuOursbHDqctPKGT == TimeSetting.Fixed)
		{
			zipEntry.DateTime = HbupNnvIghcPiISqUrtThOVvMVGi;
		}
		num = (zipEntry.ExternalFileAttributes = num | (lZRRujGSqsIkCKKNDexqDsJdehfJ | 0x10));
		return zipEntry;
	}

	public ZipEntry MakeFileEntry(string fileName)
	{
		return MakeFileEntry(fileName, useFileSystem: true);
	}

	public ZipEntry MakeFileEntry(string fileName, bool useFileSystem)
	{
		ZipEntry zipEntry = new ZipEntry(RwDJPXdwjQSnmPSSXvWLHFPvKXWg.TransformFile(fileName))
		{
			IsUnicodeText = gAcgPfcCItyJnhhTqhGMdnfaHAzWB
		};
		int num = 0;
		bool flag = lZRRujGSqsIkCKKNDexqDsJdehfJ != 0;
		FileInfo fileInfo = null;
		if (useFileSystem)
		{
			fileInfo = new FileInfo(fileName);
		}
		if (fileInfo != null && fileInfo.Exists)
		{
			switch (FBPOGyQjtKoFeuOursbHDqctPKGT)
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
				zipEntry.DateTime = HbupNnvIghcPiISqUrtThOVvMVGi;
				break;
			}
			zipEntry.Size = fileInfo.Length;
			flag = true;
			num = (int)fileInfo.Attributes & BIHgwIdTeYVntcckkHozbLVZuPaQA;
		}
		else if (FBPOGyQjtKoFeuOursbHDqctPKGT == TimeSetting.Fixed)
		{
			zipEntry.DateTime = HbupNnvIghcPiISqUrtThOVvMVGi;
		}
		if (flag)
		{
			num = (zipEntry.ExternalFileAttributes = num | lZRRujGSqsIkCKKNDexqDsJdehfJ);
		}
		return zipEntry;
	}
}
