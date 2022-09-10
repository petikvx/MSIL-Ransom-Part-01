using System.Drawing;
using System.IO;
using System.Reflection;
using ns4;

namespace ns2;

[GAttribute0(15)]
internal class Class2
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("浓牡䅴獳浥汢\u2e79浓牡䕴捸灥楴湯䍳牯\u2e65敒潳牵散\u2e73" + string_0 + "瀮杮");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon smethod_1(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("浓牡䅴獳浥汢\u2e79浓牡䕴捸灥楴湯䍳牯\u2e65敒潳牵散\u2e73" + string_0 + "椮潣");
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}
}
