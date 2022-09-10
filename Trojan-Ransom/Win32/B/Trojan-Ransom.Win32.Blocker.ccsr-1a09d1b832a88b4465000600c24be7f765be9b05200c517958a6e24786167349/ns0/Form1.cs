using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

[DesignerCategory("Code")]
internal sealed class Form1 : Form
{
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
		UsageCounts.smethod_2((Control)(object)button_1, 0, 527, 553);
		Class24.smethod_0((Control)(object)button_1, "&Quit", 558, 547);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(100, 24));
		((Control)button_0).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_0).get_Width() - 6, 188));
		UsageCounts.smethod_2((Control)(object)button_0, 1, 758, 720);
		Class24.smethod_0((Control)(object)button_0, "&Continue", 922, 919);
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
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		SecurityExceptionEventArgs securityExceptionEventArgs = (securityExceptionEventArgs_0 = null);
		PoweredBy poweredBy = (poweredBy_0 = new PoweredBy());
		Button val = (button_0 = new Button());
		Button val2 = (button_1 = new Button());
		HeaderControl headerControl = (headerControl_0 = new HeaderControl(string.Format("{0} attempted to perform an operation not allowed by the security policy.", "Nc0j6W1Ag")));
		AutoHeightLabel autoHeightLabel = (autoHeightLabel_0 = new AutoHeightLabel());
		((Form)this)._002Ector();
		method_0();
		((Form)this).set_Icon(Win32.GetApplicationIcon());
		Class24.smethod_0((Control)(object)this, "Nc0j6W1Ag", 265, 260);
		if (PoweredBy.smethod_0(SendingReportFeedbackEventArgs1.smethod_0((Control)(object)this, 74, 85), 180, 228) == 0)
		{
			Class24.smethod_0((Control)(object)this, "Security error", 814, 803);
		}
		SecurityExceptionEventArgs securityExceptionEventArgs2 = (securityExceptionEventArgs_0 = securityExceptionEventArgs_1);
		if (!securityExceptionEventArgs_1.CanContinue)
		{
			Class37.smethod_4((Control)(object)button_0, bool_0: false, 465, 424);
		}
		if (PoweredBy.smethod_0(securityExceptionEventArgs_1.SecurityMessage, 308, 356) > 0)
		{
			Class24.smethod_0((Control)(object)autoHeightLabel_0, securityExceptionEventArgs_1.SecurityMessage, 697, 692);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			Class29.smethod_4(stringBuilder, string.Format("{0} attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n", "Nc0j6W1Ag"), 58, 3);
			if (securityExceptionEventArgs_1.CanContinue)
			{
				Class29.smethod_4(stringBuilder, "If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n", 473, 480);
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

	static Form1()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static byte[] smethod_0(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 64:
				return symmetricAlgorithm_0.Key;
			}
		}
	}

	internal static Pen smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 5:
				return SystemPens.get_ControlDark();
			}
		}
	}

	internal static Color smethod_2(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		while (true)
		{
			switch (int_5 ^ int_4)
			{
			case 20:
				return Color.FromArgb(int_0, int_1, int_2, int_3);
			}
		}
	}

	internal static bool smethod_3(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 19:
				return fieldInfo_0.IsLiteral;
			}
		}
	}
}
