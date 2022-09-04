using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns3;
using ns5;
using ns8;

namespace ns6;

internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0 = null;

	internal Control2 control2_0 = new Control2();

	internal Button button_0 = new Button();

	internal Button button_1 = new Button();

	internal Control1 control1_0 = new Control1(string.Format("{0} attempted to perform an operation not allowed by the security policy.", "svchost"));

	internal Class35 class35_0 = new Class35();

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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		Class24.smethod_16(this);
		((Form)this).set_Icon(Class24.smethod_98());
		((Control)this).set_Text("svchost");
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
			((Control)class35_0).set_Text(eventArgs2_1.string_0);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "svchost"));
			if (eventArgs2_1.bool_2)
			{
				stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
			}
			stringBuilder.Append(eventArgs2_1.securityException_0.Message);
			((Control)class35_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)class35_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
