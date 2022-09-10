using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace cookies_checker.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("cookies_checker.Properties.Resources", typeof(Resources).Assembly));
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

	[SpecialName]
	internal static Bitmap smethod_0()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("111", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_1()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("add-32", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_2()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("Clipboard-32", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_3()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("Copy-32", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_4()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("Delete-32", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_5()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("Gnome-Edit-Clear-32", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_6()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("up-32", cultureInfo_0);
		return (Bitmap)@object;
	}

	[SpecialName]
	internal static Bitmap smethod_7()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object @object = ResourceManager_0.GetObject("up-32 - Copy", cultureInfo_0);
		return (Bitmap)@object;
	}
}
