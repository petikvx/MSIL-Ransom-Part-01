using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;

namespace ns0;

[DesignerCategory("Code")]
internal sealed class Form1 : Form
{
	private SecurityExceptionEventArgs securityExceptionEventArgs_0;

	private PoweredBy poweredBy_0 = new PoweredBy();

	private HeaderControl headerControl_0;

	private AutoHeightLabel autoHeightLabel_0;

	internal Button button_0;

	internal Button button_1;

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
		((Control)poweredBy_0).set_Anchor((AnchorStyles)6);
		((Control)poweredBy_0).SetBounds(6, 186, 120, 32);
		headerControl_0.IconState = IconState.Warning;
		((Control)autoHeightLabel_0).set_Anchor((AnchorStyles)13);
		((Control)autoHeightLabel_0).set_Location(new Point(20, 72));
		((Control)autoHeightLabel_0).set_Size(new Size(382, 13));
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(418, 224));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			poweredBy_0,
			(Control)button_0,
			(Control)button_1,
			headerControl_0,
			(Control)autoHeightLabel_0
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
		securityExceptionEventArgs_0.TryToContinue = true;
		((Form)this).Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		securityExceptionEventArgs_0.TryToContinue = false;
		((Form)this).Close();
	}

	public Form1(SecurityExceptionEventArgs securityExceptionEventArgs_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		Button val = (button_0 = new Button());
		Button val2 = (button_1 = new Button());
		headerControl_0 = new HeaderControl(string.Format("{0} attempted to perform an operation not allowed by the security policy.", "ybgcy1txEhE"));
		autoHeightLabel_0 = new AutoHeightLabel();
		((Form)this)._002Ector();
		method_0();
		((Form)this).set_Icon(Win32.GetApplicationIcon());
		((Control)this).set_Text("ybgcy1txEhE");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Security error");
		}
		securityExceptionEventArgs_0 = securityExceptionEventArgs_1;
		if (!securityExceptionEventArgs_1.CanContinue)
		{
			((Control)button_0).set_Visible(false);
		}
		if (securityExceptionEventArgs_1.SecurityMessage.Length > 0)
		{
			((Control)autoHeightLabel_0).set_Text(securityExceptionEventArgs_1.SecurityMessage);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "ybgcy1txEhE"));
			if (securityExceptionEventArgs_1.CanContinue)
			{
				stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
			}
			stringBuilder.Append(securityExceptionEventArgs_1.SecurityException.Message);
			((Control)autoHeightLabel_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)autoHeightLabel_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
