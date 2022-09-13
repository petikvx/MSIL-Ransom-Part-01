namespace Ionic.Zip;

public class AddProgressEventArgs : ZipProgressEventArgs
{
	internal AddProgressEventArgs()
	{
		//Discarded unreachable code: IL_000a, IL_000f, IL_0010, IL_001a, IL_001c, IL_002a, IL_0030
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I8
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	private extern AddProgressEventArgs(string archiveName, ZipProgressEventType flavor);

	internal static extern AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal);

	internal static AddProgressEventArgs Started(string archiveName)
	{
		//Discarded unreachable code: IL_0007, IL_0010, IL_0011, IL_0017, IL_001c, IL_0022, IL_0027
		//IL_000b: Expected O, but got Unknown
		//IL_0019: Expected O, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected F4, but got Unknown
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	internal static extern AddProgressEventArgs Completed(string archiveName);
}
