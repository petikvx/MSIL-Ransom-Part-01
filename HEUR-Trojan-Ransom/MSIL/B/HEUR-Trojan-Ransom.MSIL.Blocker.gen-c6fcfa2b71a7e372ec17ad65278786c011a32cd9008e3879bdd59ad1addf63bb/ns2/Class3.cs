using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns2;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
internal class Class3
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns2.Class3", typeof(Class3).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
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

	internal static byte[] Wdsstrxpqjpxmoyooja
	{
		get
		{
			object @object = ResourceManager.GetObject("Wdsstrxpqjpxmoyooja", cultureInfo_0);
			return (byte[])@object;
		}
	}

	internal Class3()
	{
	}
}
