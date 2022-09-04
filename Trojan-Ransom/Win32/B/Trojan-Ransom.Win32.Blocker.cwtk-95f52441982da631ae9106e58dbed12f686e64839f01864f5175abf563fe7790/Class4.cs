using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[StandardModule]
internal sealed class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct1
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(Class6.smethod_0("홭깿⾑", 3), typeof(Class4).Assembly));
		}
		return resourceManager_0;
	}

	internal static string smethod_1()
	{
		return smethod_0().GetString("String1", cultureInfo_0);
	}

	static Class4()
	{
		char_1 = new char[8];
		char[] array = new char[8];
		array[2] = 'ᇓ';
		array[6] = 'ᅶ';
		array[4] = 'ݥ';
		array[5] = '୵';
		array[0] = '\u181e';
		array[7] = '\u20ec';
		array[3] = 'ᑮ';
		array[1] = '၊';
		string_0 = new string[1];
		char_0 = array;
		Class3.smethod_0();
	}
}
