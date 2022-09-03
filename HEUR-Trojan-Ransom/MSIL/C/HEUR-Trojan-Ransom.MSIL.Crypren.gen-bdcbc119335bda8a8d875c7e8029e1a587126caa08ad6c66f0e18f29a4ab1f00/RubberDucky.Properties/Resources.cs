using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RubberDucky.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("RubberDucky.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] RubberDucky_Crypt0r
	{
		get
		{
			object @object = ResourceManager.GetObject("RubberDucky_Crypt0r", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
