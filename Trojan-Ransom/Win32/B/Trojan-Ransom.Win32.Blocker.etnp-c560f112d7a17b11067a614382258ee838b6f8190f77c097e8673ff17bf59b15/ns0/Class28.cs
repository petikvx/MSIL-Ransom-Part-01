using System.Drawing;
using System.IO;
using System.Reflection;

namespace ns0;

internal sealed class Class28
{
	public static Bitmap smethod_0(string CO_)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class5.smethod_0(81513) + CO_ + Class5.smethod_0(81574));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string CO_)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class5.smethod_0(81513) + CO_ + Class5.smethod_0(81583));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}
}
