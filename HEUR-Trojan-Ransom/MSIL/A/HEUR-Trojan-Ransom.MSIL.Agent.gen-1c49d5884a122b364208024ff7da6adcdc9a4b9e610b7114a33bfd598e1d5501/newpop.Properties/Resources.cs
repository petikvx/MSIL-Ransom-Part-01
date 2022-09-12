using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace newpop.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("newpop.Properties.Resources", typeof(Resources).Assembly));
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

	internal static Bitmap _1
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("_1", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap _2
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("_2", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap bsod_errornew
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("bsod_errornew", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap error
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("error", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap fullscreen
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("fullscreen", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap img
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("img", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal Resources()
	{
	}
}
