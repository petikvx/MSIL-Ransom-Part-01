using System.Drawing;
using System.IO;
using System.Reflection;

namespace ns0;

internal sealed class Class0
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.License.Resources." + string_0 + ".png");
		if (manifestResourceStream != null)
		{
			return new Bitmap(manifestResourceStream);
		}
		return null;
	}
}
