using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns10;
using ns6;
using ns9;

namespace ns7;

internal sealed class Form1 : Form
{
	private EventArgs2 eventArgs2_0 = null;

	private Control2 control2_0 = new Control2();

	private Button button_0 = new Button();

	private Button button_1 = new Button();

	private Control1 control1_0 = new Control1(string.Format(Class15.smethod_0(953515), Class15.smethod_0(953027)));

	private Class39 class39_0 = new Class39();

	private void method_0()
	{
		((Control)this).SuspendLayout();
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(100, 24));
		((Control)button_1).set_Location(new Point(408 - ((Control)button_1).get_Width(), 188));
		((Control)button_1).set_TabIndex(0);
		((Control)button_1).set_Text(Class15.smethod_0(953493));
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(100, 24));
		((Control)button_0).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_0).get_Width() - 6, 188));
		((Control)button_0).set_TabIndex(1);
		((Control)button_0).set_Text(Class15.smethod_0(953502));
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)control2_0).set_Anchor((AnchorStyles)6);
		((Control)control2_0).SetBounds(6, 186, 120, 32);
		control1_0.method_0(Enum1.const_2);
		((Control)class39_0).set_Anchor((AnchorStyles)13);
		((Control)class39_0).set_Location(new Point(20, 72));
		((Control)class39_0).set_Size(new Size(382, 13));
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(418, 224));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			control2_0,
			(Control)button_0,
			(Control)button_1,
			control1_0,
			(Control)class39_0
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
		((Form)this).set_Icon(Class43.smethod_5());
		((Control)this).set_Text(Class15.smethod_0(953027));
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text(Class15.smethod_0(953616));
		}
		eventArgs2_0 = eventArgs2_1;
		if (!eventArgs2_1.method_2())
		{
			((Control)button_0).set_Visible(false);
		}
		if (eventArgs2_1.method_1().Length > 0)
		{
			((Control)class39_0).set_Text(eventArgs2_1.method_1());
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format(Class15.smethod_0(953637), Class15.smethod_0(953027)));
			if (eventArgs2_1.method_2())
			{
				stringBuilder.Append(Class15.smethod_0(953931));
			}
			stringBuilder.Append(eventArgs2_1.method_0().Message);
			((Control)class39_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)class39_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
