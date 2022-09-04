using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MailSpreader.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
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
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("MailSpreader.Properties.Resources", typeof(Resources).Assembly));
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

	internal static byte[] livecv
	{
		get
		{
			object @object = ResourceManager.GetObject("livecv", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] mailpv
	{
		get
		{
			object @object = ResourceManager.GetObject("mailpv", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] nk2edit
	{
		get
		{
			object @object = ResourceManager.GetObject("nk2edit", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
