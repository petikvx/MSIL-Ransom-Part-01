using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Lexicon_FX_processor_VST_module_with_TAP_delay.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
public class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Lexicon_FX_processor_VST_module_with_TAP_delay.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
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

	public static string firstlbl => ResourceManager.GetString("firstlbl", resourceCulture);

	public static string fourlbl => ResourceManager.GetString("fourlbl", resourceCulture);

	public static string secondlbl => ResourceManager.GetString("secondlbl", resourceCulture);

	public static string thirdbl => ResourceManager.GetString("thirdbl", resourceCulture);

	internal Resources()
	{
	}
}
