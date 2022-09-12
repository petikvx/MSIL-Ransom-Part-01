using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns1;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Class1
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(smethod_0("\u1aeaĪ\u18fe\u032cỿ"), typeof(Class1).Assembly));
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

	internal static Bitmap Bitmap_0
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object @object = ResourceManager_0.GetObject(smethod_0("<ţɢ;Ѭվ\u0670ݳ࠳ऽ੫ରర"), cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap Bitmap_1
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object @object = ResourceManager_0.GetObject(smethod_0("cŶɢ\u036fѤ"), cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap Bitmap_2
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			object @object = ResourceManager_0.GetObject(smethod_0("cŢɿ\u0328ѭՠ٭ݯ"), cultureInfo_0);
			return (Bitmap)@object;
		}
	}

	internal Class1()
	{
	}

	private static string smethod_0(string string_0)
	{
		int length = string_0.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = string_0[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
