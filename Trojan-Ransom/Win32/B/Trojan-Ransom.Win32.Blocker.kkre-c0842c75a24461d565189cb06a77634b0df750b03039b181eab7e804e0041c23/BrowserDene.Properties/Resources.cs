using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace BrowserDene.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo tePpmgDe2;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("BrowserDene.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		set
		{
			tePpmgDe2 = value;
		}
	}

	internal Resources()
	{
	}
}
