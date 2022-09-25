namespace Ionic.Zip;

public class AddProgressEventArgs : ZipProgressEventArgs
{
	internal AddProgressEventArgs()
	{
	}

	private AddProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal)
	{
		return new AddProgressEventArgs(archiveName, ZipProgressEventType.Adding_AfterAddEntry)
		{
			EntriesTotal = entriesTotal,
			CurrentEntry = entry
		};
	}

	internal static AddProgressEventArgs Started(string archiveName)
	{
		return new AddProgressEventArgs(archiveName, ZipProgressEventType.Adding_Started);
	}

	internal static AddProgressEventArgs Completed(string archiveName)
	{
		return new AddProgressEventArgs(archiveName, ZipProgressEventType.Adding_Completed);
	}
}
