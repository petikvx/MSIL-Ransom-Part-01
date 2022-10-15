namespace Ionic.Zip;

public class ReadProgressEventArgs : ZipProgressEventArgs
{
	internal ReadProgressEventArgs()
	{
	}

	private ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal)
	{
		ReadProgressEventArgs readProgressEventArgs = new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_BeforeReadEntry);
		readProgressEventArgs.EntriesTotal = entriesTotal;
		return readProgressEventArgs;
	}

	internal static ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal)
	{
		ReadProgressEventArgs readProgressEventArgs = new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_AfterReadEntry);
		readProgressEventArgs.EntriesTotal = entriesTotal;
		readProgressEventArgs.CurrentEntry = entry;
		return readProgressEventArgs;
	}

	internal static ReadProgressEventArgs Started(string archiveName)
	{
		return new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_Started);
	}

	internal static ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
	{
		ReadProgressEventArgs readProgressEventArgs = new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_ArchiveBytesRead);
		readProgressEventArgs.CurrentEntry = entry;
		readProgressEventArgs.BytesTransferred = bytesXferred;
		readProgressEventArgs.TotalBytesToTransfer = totalBytes;
		return readProgressEventArgs;
	}

	internal static ReadProgressEventArgs Completed(string archiveName)
	{
		return new ReadProgressEventArgs(archiveName, ZipProgressEventType.Reading_Completed);
	}
}
