using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager gipemGoxw
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager("WindowsFormsApp1.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal Resources()
	{
		Class9.T7DkdFQzGSTU8();
		base._002Ector();
	}

	[SpecialName]
	internal static string smethod_0()
	{
		return gipemGoxw.GetString("String1", cultureInfo_0);
	}

	static Resources()
	{
		Class10.q1NoWNDUR6sYh();
	}
}
