using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class1
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class1()
	{
	}

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("DVstarter.Properties.Resources", typeof(Class1).Assembly));
		}
		return resourceManager_0;
	}

	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}

	internal static Bitmap smethod_3()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("bg", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_4()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("check", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_5()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("checka", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_6()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("checkna", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_7()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("db", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_8()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("dbo", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static string smethod_9()
	{
		return smethod_0().GetString("downloadid", cultureInfo_0);
	}

	internal static Bitmap smethod_10()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("downvision", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static byte[] smethod_11()
	{
		object @object = smethod_0().GetObject("DownVisionInstaller", cultureInfo_0);
		return (byte[])@object;
	}

	internal static Bitmap smethod_12()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("icon", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_13()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("icon1", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_14()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("logo", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_15()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("logo1", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_16()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("logo2", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_17()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("logoft", cultureInfo_0);
		return (Bitmap)@object;
	}

	internal static Bitmap smethod_18()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = smethod_0().GetObject("panel", cultureInfo_0);
		return (Bitmap)@object;
	}
}
