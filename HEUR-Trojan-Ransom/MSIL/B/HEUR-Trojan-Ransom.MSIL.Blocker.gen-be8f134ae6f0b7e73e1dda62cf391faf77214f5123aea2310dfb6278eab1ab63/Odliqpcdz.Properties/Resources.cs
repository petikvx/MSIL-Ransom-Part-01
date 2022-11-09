using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Odliqpcdz.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager @class;

	private static CultureInfo observer;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (@class == null)
			{
				ResourceManager resourceManager = (@class = new ResourceManager("Odliqpcdz.Properties.Resources", typeof(Resources).Assembly));
			}
			return @class;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return observer;
		}
		set
		{
			observer = value;
		}
	}

	internal static string MSISMBService => ResourceManager.GetString("MSISMBService", observer);

	internal static string MSISuperIOService => ResourceManager.GetString("MSISuperIOService", observer);

	internal Resources()
	{
	}
}
