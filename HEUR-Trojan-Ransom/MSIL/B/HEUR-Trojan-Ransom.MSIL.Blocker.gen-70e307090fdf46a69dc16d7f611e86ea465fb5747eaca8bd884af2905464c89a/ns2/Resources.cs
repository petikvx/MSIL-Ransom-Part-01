using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns2;

[GeneratedCode("", "")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Resources
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 88)]
	private struct Struct0
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly object object_0;

	private static readonly object object_1 = new char[44];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager("", typeof(Resources).Assembly);
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

	static Resources()
	{
		char[] array = new char[8];
		array[0] = 'ᙘ';
		array[7] = '౨';
		array[6] = 'ԇ';
		array[4] = '◣';
		array[5] = '౼';
		array[1] = '\u008a';
		array[3] = '\u20eb';
		array[2] = '㒆';
		object_2 = new string[6];
		object_0 = array;
	}
}
