using Ionic.Zip;

public class GEventArgs3 : GEventArgs0
{
	private int int_1;

	public int Int32_1 => int_1;

	internal GEventArgs3(string archiveName, bool before, int entriesTotal, int entriesSaved, GClass8 entry)
		: base(archiveName, before ? ZipProgressEventType.Saving_BeforeWriteEntry : ZipProgressEventType.Saving_AfterWriteEntry)
	{
		base.Int32_0 = entriesTotal;
		base.GClass8_0 = entry;
		int_1 = entriesSaved;
	}

	internal GEventArgs3()
	{
	}

	internal GEventArgs3(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static GEventArgs3 smethod_0(string string_1, GClass8 gclass8_1, long long_2, long long_3)
	{
		return new GEventArgs3(string_1, ZipProgressEventType.Saving_EntryBytesRead)
		{
			String_0 = string_1,
			GClass8_0 = gclass8_1,
			Int64_0 = long_2,
			Int64_1 = long_3
		};
	}

	internal static GEventArgs3 smethod_1(string string_1)
	{
		return new GEventArgs3(string_1, ZipProgressEventType.Saving_Started);
	}

	internal static GEventArgs3 smethod_2(string string_1)
	{
		return new GEventArgs3(string_1, ZipProgressEventType.Saving_Completed);
	}
}
