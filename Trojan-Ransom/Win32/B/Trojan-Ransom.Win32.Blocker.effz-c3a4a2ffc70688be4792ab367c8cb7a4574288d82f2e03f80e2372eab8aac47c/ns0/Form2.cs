using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;

namespace ns0;

[DesignerCategory("Code")]
internal sealed class Form2 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1220)]
	private struct Struct38
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[610];

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal SecurityExceptionEventArgs securityExceptionEventArgs_0;

	internal PoweredBy poweredBy_0;

	internal Button button_0;

	internal Button button_1;

	internal HeaderControl headerControl_0;

	internal AutoHeightLabel autoHeightLabel_0;

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

	public Form2(SecurityExceptionEventArgs securityExceptionEventArgs_1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		PoweredBy poweredBy = (poweredBy_0 = new PoweredBy());
		Button val = (button_0 = new Button());
		Button val2 = (button_1 = new Button());
		HeaderControl headerControl = (headerControl_0 = new HeaderControl(string.Format("{0} attempted to perform an operation not allowed by the security policy.", ".netshrink exe compressor loader")));
		AutoHeightLabel autoHeightLabel = (autoHeightLabel_0 = new AutoHeightLabel());
		((Form)this)._002Ector();
		method_0();
		((Form)this).set_Icon(Win32.GetApplicationIcon());
		((Control)this).set_Text(".netshrink exe compressor loader");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Security error");
		}
		SecurityExceptionEventArgs securityExceptionEventArgs = (securityExceptionEventArgs_0 = securityExceptionEventArgs_1);
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
			stringBuilder.Append(string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", ".netshrink exe compressor loader"));
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

	static Form2()
	{
		char[] array = new char[8];
		array[2] = '\u0ad1';
		array[6] = '\u0873';
		array[1] = '\u073c';
		array[4] = '\u05f5';
		array[7] = '㐠';
		array[5] = 'Ս';
		array[0] = '㏞';
		array[3] = 'Ƽ';
		string_0 = new string[24];
		char_0 = array;
	}
}
