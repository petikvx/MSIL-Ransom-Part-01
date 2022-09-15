using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using RU;

namespace Main.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(Class22.smethod_0("\ue4d2\ue4fe\ue4f6\ue4f1\ue4b1\ue4cf\ue4ed\ue4f0\ue4ef\ue4fa\ue4ed\ue4eb\ue4f6\ue4fa\ue4ec\ue4b1\ue4cd\ue4fa\ue4ec\ue4f0\ue4ea\ue4ed\ue4fc\ue4fa\ue4ec", 58396), typeof(Resources).Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo CultureInfo_0
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

	public static byte[] Byte_0 => (byte[])ResourceManager_0.GetObject(Class22.smethod_0("\uf41f\uf413\uf412\uf41a\uf415\uf41b\uf409\uf40e\uf41d\uf408\uf415\uf413\uf412\uf40f", 62560), cultureInfo_0);

	internal Resources()
	{
	}
}
