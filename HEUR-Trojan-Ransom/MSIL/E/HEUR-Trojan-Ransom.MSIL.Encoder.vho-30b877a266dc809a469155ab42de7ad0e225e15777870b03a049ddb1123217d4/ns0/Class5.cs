using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal sealed class Class5
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = Delegate121.smethod_0("ns0.Class5", Delegate139.smethod_0(Delegate90.smethod_0(typeof(Class5).TypeHandle)));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static Bitmap close => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "close", cultureInfo_0);

	internal static Bitmap close_animation => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "close_animation", cultureInfo_0);

	internal static Bitmap downarrow_off => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "downarrow_off", cultureInfo_0);

	internal static Bitmap downarrow_on => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "downarrow_on", cultureInfo_0);

	internal static Bitmap open => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "open", cultureInfo_0);

	internal static Bitmap open_animation => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "open_animation", cultureInfo_0);

	internal static Bitmap uparrow_off => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "uparrow_off", cultureInfo_0);

	internal static Bitmap uparrow_on => (Bitmap)Delegate68.smethod_0(Delegate1.smethod_0(), "uparrow_on", cultureInfo_0);

	internal Class5()
	{
	}
}
