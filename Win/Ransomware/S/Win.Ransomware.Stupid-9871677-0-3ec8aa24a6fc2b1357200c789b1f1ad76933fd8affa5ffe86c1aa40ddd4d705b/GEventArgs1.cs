using Ionic.Zip;

public class GEventArgs1 : GEventArgs0
{
	internal GEventArgs1()
	{
	}

	private GEventArgs1(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static GEventArgs1 smethod_0(string string_1, int int_1)
	{
		return new GEventArgs1(string_1, ZipProgressEventType.Reading_BeforeReadEntry)
		{
			Int32_0 = int_1
		};
	}

	internal static GEventArgs1 smethod_1(string string_1, GClass8 gclass8_1, int int_1)
	{
		return new GEventArgs1(string_1, ZipProgressEventType.Reading_AfterReadEntry)
		{
			Int32_0 = int_1,
			GClass8_0 = gclass8_1
		};
	}

	internal static GEventArgs1 smethod_2(string string_1)
	{
		return new GEventArgs1(string_1, ZipProgressEventType.Reading_Started);
	}

	internal static GEventArgs1 smethod_3(string string_1, GClass8 gclass8_1, long long_2, long long_3)
	{
		return new GEventArgs1(string_1, ZipProgressEventType.Reading_ArchiveBytesRead)
		{
			GClass8_0 = gclass8_1,
			Int64_0 = long_2,
			Int64_1 = long_3
		};
	}

	internal static GEventArgs1 smethod_4(string string_1)
	{
		return new GEventArgs1(string_1, ZipProgressEventType.Reading_Completed);
	}
}
