namespace Ionic.Zip;

public class SaveProgressEventArgs : ZipProgressEventArgs
{
	private int _entriesSaved;

	public int EntriesSaved => _entriesSaved;

	internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, ZipEntry entry)
		: base(archiveName, before ? ZipProgressEventType.Saving_BeforeWriteEntry : ZipProgressEventType.Saving_AfterWriteEntry)
	{
		base.EntriesTotal = entriesTotal;
		base.CurrentEntry = entry;
		_entriesSaved = entriesSaved;
	}

	internal SaveProgressEventArgs()
	{
	}

	internal SaveProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static SaveProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes)
	{
		SaveProgressEventArgs saveProgressEventArgs = new SaveProgressEventArgs(archiveName, ZipProgressEventType.Saving_EntryBytesRead);
		saveProgressEventArgs.ArchiveName = archiveName;
		saveProgressEventArgs.CurrentEntry = entry;
		saveProgressEventArgs.BytesTransferred = bytesXferred;
		saveProgressEventArgs.TotalBytesToTransfer = totalBytes;
		return saveProgressEventArgs;
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
