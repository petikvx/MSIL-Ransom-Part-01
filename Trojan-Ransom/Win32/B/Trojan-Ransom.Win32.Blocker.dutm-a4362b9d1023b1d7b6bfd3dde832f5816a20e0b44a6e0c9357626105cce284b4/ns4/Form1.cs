using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns5;
using ns8;
using ns9;

namespace ns4;

internal sealed class Form1 : Form
{
	private EventArgs2 eventArgs2_0;

	internal Control2 control2_0 = new Control2();

	internal Button button_0 = new Button();

	internal Button button_1 = new Button();

	internal Control1 control1_0 = new Control1(string.Format("{0} attempted to perform an operation not allowed by the security policy.", "Server.packed"));

	internal Class32 class32_0 = new Class32();

	internal void method_0(object sender, EventArgs e)
	{
		eventArgs2_0.bool_0 = true;
		((Form)this).Close();
	}

	internal void method_1(object sender, EventArgs e)
	{
		eventArgs2_0.bool_0 = false;
		((Form)this).Close();
	}

	public Form1(EventArgs2 eventArgs2_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Class29.smethod_160(this);
		((Form)this).set_Icon(Class29.smethod_119());
		((Control)this).set_Text("Server.packed");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Security error");
		}
		eventArgs2_0 = eventArgs2_1;
		if (!eventArgs2_1.bool_2)
		{
			((Control)button_0).set_Visible(false);
		}
		if (eventArgs2_1.string_0.Length > 0)
		{
			((Control)class32_0).set_Text(eventArgs2_1.string_0);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "Server.packed"));
			if (eventArgs2_1.bool_2)
			{
				stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
			}
			stringBuilder.Append(eventArgs2_1.securityException_0.Message);
			((Control)class32_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)class32_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
