using ConversionBack;

namespace ManualMapInjection.Injection;

internal static class Helpers
{
	internal static string ToStringAnsi(byte[] buffer)
	{
		object[] array = new object[1] { buffer };
		return (string)ConvertBack.Runner(0, 288, 0, array);
	}

	internal static bool _stricmp(char[] str1, char[] str2)
	{
		object[] array = new object[2] { str1, str2 };
		return (bool)ConvertBack.Runner(288, 352, 1, array);
	}
}
