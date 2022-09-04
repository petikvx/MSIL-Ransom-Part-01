using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns4;
using ns5;

namespace ns6;

internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0;

	internal Control2 control2_0;

	internal Button button_0;

	internal Button button_1;

	internal Control1 control1_0;

	internal Class34 class34_0;

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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		Class42.hMqjKD0znI7T7();
		control2_0 = new Control2();
		button_0 = new Button();
		button_1 = new Button();
		control1_0 = new Control1(string.Format("{0} attempted to perform an operation not allowed by the security policy.", "1234"));
		class34_0 = new Class34();
		((Form)this)._002Ector();
		Class24.smethod_134(this);
		((Form)this).set_Icon(Class24.smethod_127());
		((Control)this).set_Text("1234");
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
			((Control)class34_0).set_Text(eventArgs2_1.string_0);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "1234"));
			if (eventArgs2_1.bool_2)
			{
				stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
			}
			stringBuilder.Append(((Exception)eventArgs2_1.object_0).Message);
			((Control)class34_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)class34_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
