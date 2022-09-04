using System.Drawing;
using System.IO;
using System.Reflection;

namespace SmartAssembly.SmartExceptionsCore;

internal class Resources
{
	public static Bitmap GetBitmap(string key)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + key + ".png");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon GetIcon(string key)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + key + ".ico");
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public Resources()
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
	}
}
