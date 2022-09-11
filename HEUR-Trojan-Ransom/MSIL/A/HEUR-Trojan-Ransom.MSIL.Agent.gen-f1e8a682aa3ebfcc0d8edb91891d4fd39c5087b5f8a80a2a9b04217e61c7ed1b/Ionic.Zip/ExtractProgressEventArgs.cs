namespace Ionic.Zip;

public class ExtractProgressEventArgs : ZipProgressEventArgs
{
	private int _entriesExtracted;

	private string _target;

	public int EntriesExtracted => _entriesExtracted;

	public string ExtractLocation => _target;

	internal ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, ZipEntry entry, string extractLocation)
		: base(archiveName, before ? ZipProgressEventType.Extracting_BeforeExtractEntry : ZipProgressEventType.Extracting_AfterExtractEntry)
	{
		base.EntriesTotal = entriesTotal;
		base.CurrentEntry = entry;
		_entriesExtracted = entriesExtracted;
		_target = extractLocation;
	}

	internal ExtractProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal ExtractProgressEventArgs()
	{
	}

	internal static ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
	{
		return new ExtractProgressEventArgs
		{
			ArchiveName = archiveName,
			EventType = ZipProgressEventType.Extracting_BeforeExtractEntry,
			CurrentEntry = entry,
			_target = extractLocation
		};
	}

	internal static ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation)
	{
		return new ExtractProgressEventArgs
		{
			ArchiveName = archiveName,
			EventType = ZipProgressEventType.Extracting_ExtractEntryWouldOverwrite,
			CurrentEntry = entry,
			_target = extractLocation
		};
	}

	internal static ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
	{
		return new ExtractProgressEventArgs
		{
			ArchiveName = archiveName,
			EventType = ZipProgressEventType.Extracting_AfterExtractEntry,
			CurrentEntry = entry,
			_target = extractLocation
		};
	}

	internal static ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation)
	{
		ExtractProgressEventArgs extractProgressEventArgs = new ExtractProgressEventArgs(archiveName, ZipProgressEventType.Extracting_BeforeExtractAll);
		extractProgressEventArgs._target = extractLocation;
		return extractProgressEventArgs;
	}

	internal static ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation)
	{
		ExtractProgressEventArgs extractProgressEventArgs = new ExtractProgressEventArgs(archiveName, ZipProgressEventType.Extracting_AfterExtractAll);
		extractProgressEventArgs._target = extractLocation;
		return extractProgressEventArgs;
	}

	internal static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes)
	{
		ExtractProgressEventArgs extractProgressEventArgs = new ExtractProgressEventArgs(archiveName, ZipProgressEventType.Extracting_EntryBytesWritten);
		extractProgressEventArgs.ArchiveName = archiveName;
		extractProgressEventArgs.CurrentEntry = entry;
		extractProgressEventArgs.BytesTransferred = bytesWritten;
		extractProgressEventArgs.TotalBytesToTransfer = totalBytes;
		return extractProgressEventArgs;
	}
}
