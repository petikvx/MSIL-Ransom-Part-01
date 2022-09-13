using Ionic.Zip;

public class GEventArgs4 : GEventArgs0
{
	private int int_1;

	private string string_1;

	public int Int32_1 => int_1;

	public string String_1 => string_1;

	internal GEventArgs4(string archiveName, bool before, int entriesTotal, int entriesExtracted, GClass8 entry, string extractLocation)
		: base(archiveName, before ? ZipProgressEventType.Extracting_BeforeExtractEntry : ZipProgressEventType.Extracting_AfterExtractEntry)
	{
		base.Int32_0 = entriesTotal;
		base.GClass8_0 = entry;
		int_1 = entriesExtracted;
		string_1 = extractLocation;
	}

	internal GEventArgs4(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal GEventArgs4()
	{
	}

	internal static GEventArgs4 smethod_0(string string_2, GClass8 gclass8_1, string string_3)
	{
		return new GEventArgs4
		{
			String_0 = string_2,
			ZipProgressEventType_0 = ZipProgressEventType.Extracting_BeforeExtractEntry,
			GClass8_0 = gclass8_1,
			string_1 = string_3
		};
	}

	internal static GEventArgs4 smethod_1(string string_2, GClass8 gclass8_1, string string_3)
	{
		return new GEventArgs4
		{
			String_0 = string_2,
			ZipProgressEventType_0 = ZipProgressEventType.Extracting_ExtractEntryWouldOverwrite,
			GClass8_0 = gclass8_1,
			string_1 = string_3
		};
	}

	internal static GEventArgs4 smethod_2(string string_2, GClass8 gclass8_1, string string_3)
	{
		return new GEventArgs4
		{
			String_0 = string_2,
			ZipProgressEventType_0 = ZipProgressEventType.Extracting_AfterExtractEntry,
			GClass8_0 = gclass8_1,
			string_1 = string_3
		};
	}

	internal static GEventArgs4 smethod_3(string string_2, string string_3)
	{
		return new GEventArgs4(string_2, ZipProgressEventType.Extracting_BeforeExtractAll)
		{
			string_1 = string_3
		};
	}

	internal static GEventArgs4 smethod_4(string string_2, string string_3)
	{
		return new GEventArgs4(string_2, ZipProgressEventType.Extracting_AfterExtractAll)
		{
			string_1 = string_3
		};
	}

	internal static GEventArgs4 smethod_5(string string_2, GClass8 gclass8_1, long long_2, long long_3)
	{
		return new GEventArgs4(string_2, ZipProgressEventType.Extracting_EntryBytesWritten)
		{
			String_0 = string_2,
			GClass8_0 = gclass8_1,
			Int64_0 = long_2,
			Int64_1 = long_3
		};
	}
}
