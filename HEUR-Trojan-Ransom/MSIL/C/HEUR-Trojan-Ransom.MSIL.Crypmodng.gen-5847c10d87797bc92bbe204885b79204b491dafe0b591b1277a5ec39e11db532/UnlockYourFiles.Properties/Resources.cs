using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;

namespace UnlockYourFiles.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class Resources
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5000)]
	private struct Struct1
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct2
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static bool bool_0;

	private static readonly char[] char_2;

	private static readonly char[] char_3 = new char[8];

	private static readonly string[] string_1;

	internal static byte byte_1/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("UnlockYourFiles.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal Resources()
	{
	}

	[SecuritySafeCritical]
	static Resources()
	{
		char[] array = new char[8];
		array[6] = '\u0e83';
		array[0] = 'ͱ';
		array[5] = '\u02d4';
		array[3] = 'ᆇ';
		array[7] = 'ԣ';
		array[4] = 'ₖ';
		array[1] = '㋞';
		array[2] = 'ᔩ';
		string_1 = new string[1];
		char_2 = array;
		char_1 = new char[2500];
		char[] array2 = new char[8];
		array2[4] = 'ϲ';
		array2[5] = 'Ԗ';
		array2[1] = '᧳';
		array2[6] = '㣤';
		array2[0] = 'ᖃ';
		array2[7] = 'ư';
		array2[2] = '㶡';
		array2[3] = 'ᱦ';
		string_0 = new string[190];
		char_0 = array2;
	}
}
