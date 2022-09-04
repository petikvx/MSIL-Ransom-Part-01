using System.Drawing;
using System.IO;
using System.Reflection;
using ns9;

namespace ns8;

internal sealed class Class37
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class15.smethod_0(951399) + string_0 + Class15.smethod_0(951460));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Class15.smethod_0(951399) + string_0 + Class15.smethod_0(951469));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}
}
