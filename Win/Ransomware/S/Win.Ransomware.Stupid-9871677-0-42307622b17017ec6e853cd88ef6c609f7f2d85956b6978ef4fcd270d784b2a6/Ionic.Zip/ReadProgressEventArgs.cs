namespace Ionic.Zip;

public class ReadProgressEventArgs : ZipProgressEventArgs
{
	internal extern ReadProgressEventArgs();

	private extern ReadProgressEventArgs(string archiveName, ZipProgressEventType flavor);

	internal static ReadProgressEventArgs Before(string archiveName, int entriesTotal)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				int num = checked((int)/*Error near IL_0006: Stack underflow*/);
				if (/*Error near IL_0007: Stack underflow*/ << num >= 24)
				{
					break;
				}
			}
		}
		/*Error near IL_0011: Invalid metadata token*/;
	}

	internal static extern ReadProgressEventArgs After(string archiveName, ZipEntry entry, int entriesTotal);

	internal static extern ReadProgressEventArgs Started(string archiveName);

	internal static extern ReadProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesXferred, long totalBytes);

	internal static ReadProgressEventArgs Completed(string archiveName)
	{
		return (ReadProgressEventArgs)/*Error near IL_0001: Stack underflow*/;
	}
}
