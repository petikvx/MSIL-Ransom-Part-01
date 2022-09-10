using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns1;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class6
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 54)]
	private struct Struct4
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[27];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager("ns1.Class6", typeof(Class6).Assembly);
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

	internal Class6()
	{
	}

	static Class6()
	{
		char[] array = new char[8];
		array[0] = '՛';
		array[7] = 'ᰉ';
		array[4] = 'ᓕ';
		array[2] = '㝂';
		array[5] = '㤖';
		array[6] = 'Ԍ';
		array[3] = 'ᴟ';
		array[1] = 'Ⴡ';
		object_1 = new string[3];
		object_0 = array;
	}
}
