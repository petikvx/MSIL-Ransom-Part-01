using Ionic.Zip;

public class GEventArgs2 : GEventArgs0
{
	internal GEventArgs2()
	{
	}

	private GEventArgs2(string archiveName, ZipProgressEventType flavor)
		: base(archiveName, flavor)
	{
	}

	internal static GEventArgs2 smethod_0(string string_1, GClass8 gclass8_1, int int_1)
	{
		return new GEventArgs2(string_1, ZipProgressEventType.Adding_AfterAddEntry)
		{
			Int32_0 = int_1,
			GClass8_0 = gclass8_1
		};
	}

	internal static GEventArgs2 smethod_1(string string_1)
	{
		return new GEventArgs2(string_1, ZipProgressEventType.Adding_Started);
	}

	internal static GEventArgs2 smethod_2(string string_1)
	{
		return new GEventArgs2(string_1, ZipProgressEventType.Adding_Completed);
	}
}
