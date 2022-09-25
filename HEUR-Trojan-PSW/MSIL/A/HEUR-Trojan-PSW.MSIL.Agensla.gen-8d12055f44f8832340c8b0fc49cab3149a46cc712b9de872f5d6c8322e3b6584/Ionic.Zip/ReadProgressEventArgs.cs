namespace Ionic.Zip;

public class ReadProgressEventArgs : ZipProgressEventArgs
{
	private ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal)
	{
		return new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_BeforeReadEntry)
		{
			EntriesTotal = entriesTotal
		};
	}

	internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal)
	{
		return new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_AfterReadEntry)
		{
			EntriesTotal = entriesTotal,
			CurrentEntry = entry
		};
	}

	internal static ReadProgressEventArgs Started(string archiveName)
	{
		return new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_Started);
	}

	internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
	{
		return new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_ArchiveBytesRead)
		{
			CurrentEntry = entry,
			BytesTransferred = bytesXferred,
			TotalBytesToTransfer = totalBytes
		};
	}

	internal static ReadProgressEventArgs Completed(string archiveName)
	{
		return new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_Completed);
	}
}
