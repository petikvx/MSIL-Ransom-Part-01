using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("WindowsFormsApp1.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] Doomr
	{
		get
		{
			object @object = ResourceManager.GetObject("Doomr", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] Nsbsjemcjq
	{
		get
		{
			object @object = ResourceManager.GetObject("Nsbsjemcjq", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] Ickhgnukmd
	{
		get
		{
			object @object = ResourceManager.GetObject("Ickhgnukmd", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
		Class2.yNfHDGRzxiuFT();
		base._002Ector();
	}
}
