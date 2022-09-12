using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Gxyizcn.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager iii;

	private static CultureInfo iij;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager acm
	{
		get
		{
			if (iii == null)
			{
				ResourceManager resourceManager = (iii = new ResourceManager("Gxyizcn.Properties.Resources", typeof(Resources).Assembly));
			}
			return iii;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo acn
	{
		get
		{
			return iij;
		}
		set
		{
			iij = value;
		}
	}

	internal static byte[] aco
	{
		get
		{
			object @object = acm.GetObject("Meyaxnwzriggsy", iij);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
