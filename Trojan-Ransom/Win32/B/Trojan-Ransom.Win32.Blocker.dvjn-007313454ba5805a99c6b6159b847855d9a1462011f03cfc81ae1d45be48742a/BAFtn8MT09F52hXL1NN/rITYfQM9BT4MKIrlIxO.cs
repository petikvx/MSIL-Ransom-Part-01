using System.Drawing;
using System.IO;
using System.Reflection;
using ProwxkN4F4ab5Fc8FL;

namespace BAFtn8MT09F52hXL1NN;

internal sealed class rITYfQM9BT4MKIrlIxO
{
	public static Bitmap NekK7jcmTv(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680825) + string_0 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680886));
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon rAUKJJjQhB(string string_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680825) + string_0 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(680895));
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	internal static bool fbFyaX4tIvtujyunngR()
	{
		return true;
	}

	internal static bool fuZA2M4iUqjNDnp6P1K()
	{
		return false;
	}
}
