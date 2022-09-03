using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Unk;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
internal class PayM3
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Unk.PayM3", typeof(PayM3).Assembly));
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

	internal static Point backgroundWorker1_TrayLocation
	{
		get
		{
			object @object = ResourceManager.GetObject("backgroundWorker1.TrayLocation", resourceCulture);
			return (Point)@object;
		}
	}

	internal static Bitmap pictureBox1_Image
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("pictureBox1.Image", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static string textBox3_Text => ResourceManager.GetString("textBox3.Text", resourceCulture);

	internal PayM3()
	{
	}
}
