using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns1;
using ns2;
using ns6;

namespace ns4;

internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0 = null;

	private Control2 control2_0 = new Control2();

	private Button button_0 = new Button();

	private Button button_1 = new Button();

	private Control1 control1_0 = new Control1(string.Format("{0} attempted to perform an operation not allowed by the security policy.", "a3YMq23RdN9"));

	private Class28 class28_0 = new Class28();

	private void method_0()
	{
		((Control)this).SuspendLayout();
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(100, 24));
		((Control)button_1).set_Location(new Point(408 - ((Control)button_1).get_Width(), 188));
		((Control)button_1).set_TabIndex(0);
		((Control)button_1).set_Text("&Quit");
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(100, 24));
		((Control)button_0).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_0).get_Width() - 6, 188));
		((Control)button_0).set_TabIndex(1);
		((Control)button_0).set_Text("&Continue");
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)control2_0).set_Anchor((AnchorStyles)6);
		((Control)control2_0).SetBounds(6, 186, 120, 32);
		control1_0.method_0(Enum1.const_2);
		((Control)class28_0).set_Anchor((AnchorStyles)13);
		((Control)class28_0).set_Location(new Point(20, 72));
		((Control)class28_0).set_Size(new Size(382, 13));
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(418, 224));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			control2_0,
			(Control)button_0,
			(Control)button_1,
			control1_0,
			(Control)class28_0
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		eventArgs2_0.method_4(bool_3: true);
		((Form)this).Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		eventArgs2_0.method_4(bool_3: false);
		((Form)this).Close();
	}

	public Form1(EventArgs2 eventArgs2_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		method_0();
		((Form)this).set_Icon(Class32.smethod_5());
		((Control)this).set_Text("a3YMq23RdN9");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Security error");
		}
		eventArgs2_0 = eventArgs2_1;
		if (!eventArgs2_1.method_2())
		{
			((Control)button_0).set_Visible(false);
		}
		if (eventArgs2_1.method_1().Length > 0)
		{
			((Control)class28_0).set_Text(eventArgs2_1.method_1());
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "a3YMq23RdN9"));
			if (eventArgs2_1.method_2())
			{
				stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
			}
			stringBuilder.Append(eventArgs2_1.method_0().Message);
			((Control)class28_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)class28_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
