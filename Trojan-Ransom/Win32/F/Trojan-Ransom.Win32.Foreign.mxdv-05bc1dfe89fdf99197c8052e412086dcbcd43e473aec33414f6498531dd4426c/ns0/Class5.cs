using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
internal sealed class Class5
{
	internal sealed class Class6
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 13075)]
		private struct Struct1
		{
		}

		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
		private struct Struct2
		{
		}

		internal static byte byte_0/* Not supported: data(00) */;

		private static readonly char[] char_0;

		private static readonly char[] char_1;

		private static readonly string[] string_0;

		internal static byte byte_1/* Not supported: data(00) */;

		static Class6()
		{
			char_1 = new char[8];
			char[] array = new char[8];
			array[4] = '\u05b3';
			array[2] = 'ᑉ';
			array[3] = '㈀';
			array[6] = 'ዡ';
			array[7] = '\u0c03';
			array[1] = '\u1ddf';
			array[0] = '\u0f99';
			array[5] = 'Ậ';
			string_0 = new string[1];
			char_0 = array;
		}
	}

	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

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

	[SpecialName]
	internal static byte[] smethod_0()
	{
		return (byte[])RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("server", cultureInfo_0));
	}
}
