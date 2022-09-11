using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
internal sealed class Class1
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
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("FL.Resources", typeof(Class1).Assembly));
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
		object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("BackGroundPC", cultureInfo_0));
		return (byte[])objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_1()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("loading", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static string smethod_2()
	{
		return ResourceManager_0.GetString("TextFile1", cultureInfo_0);
	}

	[SpecialName]
	internal static string smethod_3()
	{
		return ResourceManager_0.GetString("TextImage", cultureInfo_0);
	}

	[SpecialName]
	internal static string smethod_4()
	{
		return ResourceManager_0.GetString("textTimer", cultureInfo_0);
	}

	[SpecialName]
	internal static Bitmap smethod_5()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject("Valide", cultureInfo_0));
		return (Bitmap)objectValue;
	}
}
