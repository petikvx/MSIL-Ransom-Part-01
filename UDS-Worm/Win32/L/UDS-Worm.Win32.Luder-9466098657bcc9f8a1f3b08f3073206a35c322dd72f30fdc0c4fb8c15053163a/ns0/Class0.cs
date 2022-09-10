using System.Drawing;
using System.IO;
using System.Reflection;
using ns4;

namespace ns0;

[GAttribute0(3)]
internal sealed class Class0
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("浓牡䅴獳浥汢\u2e79楌散獮\u2e65敒潳牵散\u2e73" + string_0 + "瀮杮");
		if (manifestResourceStream != null)
		{
			return new Bitmap(manifestResourceStream);
		}
		return null;
	}
}
