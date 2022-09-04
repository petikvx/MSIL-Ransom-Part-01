using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched.My.Resources;

[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("jusched.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

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
}
