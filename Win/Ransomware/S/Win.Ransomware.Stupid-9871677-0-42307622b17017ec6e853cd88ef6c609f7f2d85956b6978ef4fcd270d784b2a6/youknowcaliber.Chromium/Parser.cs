namespace youknowcaliber.Chromium;

internal sealed class Parser
{
	public static string separator;

	public static extern string RemoveLatest(string data);

	public unsafe static bool DetectTitle(string data)
	{
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
		_ = -1;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	public static extern string Get(string data, int index);

	public extern Parser();
}
