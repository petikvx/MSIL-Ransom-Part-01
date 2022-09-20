using System;
using System.Windows.Forms;

public class ClientLoaderForm : Form
{
	public ClientLoaderForm()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(ClientLoaderForm_FormClosing));
		((Form)this).add_Shown((EventHandler)ClientLoaderForm_Shown);
		Application.EnableVisualStyles();
		Class8.clientLoaderForm_0 = this;
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class1.smethod_3().method_0());
	}

	private void ClientLoaderForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		Class8.smethod_40(bool_6: false);
		if (Class8.byte_1 != null)
		{
			Class8.smethod_92();
		}
	}

	private void ClientLoaderForm_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		Class8.smethod_0();
	}
}
