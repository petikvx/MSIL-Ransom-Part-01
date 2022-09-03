using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class5
{
	internal sealed class Class6
	{
		internal sealed class Class7
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 75982)]
			private struct Struct0
			{
			}

			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 60110)]
			private struct Struct1
			{
			}

			internal static byte byte_0/* Not supported: data(00) */;

			private static readonly char[] char_0;

			private static readonly char[] char_1;

			private static readonly string[] string_0;

			internal static byte byte_1/* Not supported: data(00) */;

			static Class7()
			{
				char_1 = new char[30055];
				char[] array = new char[8];
				array[5] = '㽽';
				array[3] = '\u1c4c';
				array[2] = 'ᳩ';
				array[7] = '㙙';
				array[4] = '\u1a5c';
				array[6] = 'ƌ';
				array[1] = 'ϣ';
				array[0] = 'ဈ';
				string_0 = new string[390];
				char_0 = array;
			}
		}

		private static bool bool_0;
	}

	internal sealed class Class8
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct2
	{
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[8];

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns0.Class5", typeof(Class5).Assembly));
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

	internal Class5()
	{
	}

	[SpecialName]
	internal static Bitmap smethod_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)ResourceManager_0.GetObject("icons8-key-150", cultureInfo_0);
	}

	[SpecialName]
	internal static Bitmap smethod_1()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)ResourceManager_0.GetObject("icons8-lock-150", cultureInfo_0);
	}

	[SpecialName]
	internal static Bitmap smethod_2()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)ResourceManager_0.GetObject("Key0", cultureInfo_0);
	}

	[SecuritySafeCritical]
	static Class5()
	{
		char[] array = new char[8];
		array[0] = '\u1dda';
		array[4] = 'ኣ';
		array[6] = '႑';
		array[5] = 'ሻ';
		array[1] = '\u0e4c';
		array[3] = '⑱';
		array[7] = 'ઞ';
		array[2] = '㜢';
		string_0 = new string[1];
		char_0 = array;
	}
}
