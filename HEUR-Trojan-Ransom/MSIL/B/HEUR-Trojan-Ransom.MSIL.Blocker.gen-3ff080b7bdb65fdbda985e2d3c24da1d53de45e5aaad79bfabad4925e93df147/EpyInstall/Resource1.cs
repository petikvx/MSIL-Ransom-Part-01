using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EpyInstall;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resource1
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("EpyInstall.Resource1", typeof(Resource1).Assembly));
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

	internal static byte[] epyloader
	{
		get
		{
			object @object = ResourceManager.GetObject("epyloader", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] epys
	{
		get
		{
			object @object = ResourceManager.GetObject("epys", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] epysmng
	{
		get
		{
			object @object = ResourceManager.GetObject("epysmng", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resource1()
	{
	}
}
