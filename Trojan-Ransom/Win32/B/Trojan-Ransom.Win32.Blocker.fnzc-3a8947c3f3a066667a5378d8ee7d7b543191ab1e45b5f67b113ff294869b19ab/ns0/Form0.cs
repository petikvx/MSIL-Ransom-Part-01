using System;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Form0 : Form
{
	public Form0(string string_0, string string_1, string string_2)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Label val = default(Label);
		Button val2 = default(Button);
		PictureBox val3 = default(PictureBox);
		Control[] array = default(Control[]);
		try
		{
			val = new Label();
			val2 = new Button();
			val3 = new PictureBox();
			AppRegistryKeys.smethod_0((Control)(object)this, 705, 690);
			HeaderControl.smethod_1(val3, (Image)(object)Class3.smethod_0(string_2), 148, 238);
			FeedbackControl.smethod_0((Control)(object)val3, new Point(8, 8), 746, 658);
			SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_2((Control)(object)val3, new Size(48, 48), 357, 330);
			AppPathFinder.smethod_1(val3, bool_0: false, 508, 506);
			FeedbackControl.smethod_0((Control)(object)val, new Point(64, 24), 319, 327);
			SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_2((Control)(object)val, new Size(308, 108), 453, 490);
			AppNameFinder.smethod_3((Control)(object)val, string_0, 722, 683);
			AppRegistryKeys.smethod_1((ButtonBase)(object)val2, (FlatStyle)3, 774, 791);
			FeedbackControl.smethod_0((Control)(object)val2, new Point(172, 140), 354, 282);
			Class21.smethod_2((Control)(object)val2, 0, 843, 882);
			AppNameFinder.smethod_3((Control)(object)val2, "OK", 433, 456);
			PoweredBy.smethod_4((Control)(object)val2, method_0, 209, 199);
			((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
			AppNameFinder.smethod_4((Form)(object)this, new Size(398, 174), 28, 67);
			ControlCollection obj = SimpleZip.Class9.smethod_0((Control)(object)this, 335, 280);
			array = (Control[])(object)new Control[3]
			{
				(Control)val2,
				(Control)val,
				(Control)val3
			};
			obj.AddRange(array);
			((Form)this).set_AcceptButton((IButtonControl)(object)val2);
			((Form)this).set_CancelButton((IButtonControl)(object)val2);
			((Form)this).set_FormBorderStyle((FormBorderStyle)3);
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimizeBox(false);
			((Control)this).set_Text(string_1);
			((Form)this).set_StartPosition((FormStartPosition)1);
			((Form)this).set_TopMost(true);
			((Control)this).ResumeLayout(false);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, val, val2, val3, array, this, string_0, string_1, string_2);
			throw;
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		try
		{
			SimpleZip.smethod_4((Form)(object)this, 204, 228);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	[SecuritySafeCritical]
	static Form0()
	{
		Class32.smethod_1();
	}
}
