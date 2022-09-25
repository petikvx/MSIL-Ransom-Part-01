namespace Ionic.Zip;

public class SaveProgressEventArgs : ZipProgressEventArgs
{
	private int _entriesSaved;

	internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry)
		: base(archiveName, before ? ZipProgressEventType.Saving_BeforeWriteEntry : ZipProgressEventType.Saving_AfterWriteEntry)
	{
		base.EntriesTotal = entriesTotal;
		base.CurrentEntry = entry;
		_entriesSaved = entriesSaved;
	}

	internal SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
	{
		return new SaveProgressEventArgs(archiveName, ZipProgressEventType.Saving_EntryBytesRead)
		{
			ArchiveName = archiveName,
			CurrentEntry = entry,
			BytesTransferred = bytesXferred,
			TotalBytesToTransfer = totalBytes
		};
	}

	internal static SaveProgressEventArgs Started(string archiveName)
	{
		return new SaveProgressEventArgs(archiveName, ZipProgressEventType.Saving_Started);
	}

	internal static SaveProgressEventArgs Completed(string archiveName)
	{
		return new SaveProgressEventArgs(archiveName, ZipProgressEventType.Saving_Completed);
	}
}
