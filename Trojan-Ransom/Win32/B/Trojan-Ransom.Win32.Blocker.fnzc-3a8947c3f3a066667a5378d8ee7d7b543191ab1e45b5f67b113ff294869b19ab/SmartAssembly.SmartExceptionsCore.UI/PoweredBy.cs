using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class PoweredBy : Control
{
	internal Label label_0;

	internal PictureBox pictureBox_0;

	internal ToolTip toolTip_0;

	internal float float_0;

	internal float float_1;

	protected override void OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * float_0), Convert.ToInt32(32f * float_1)));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float dx, float dy)
	{
		float num = (float_0 = dx);
		float num2 = (float_1 = dy);
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (toolTip_0 != null)
			{
				WaitSendingReportControl.smethod_2((Component)(object)toolTip_0, 486, 396);
			}
			if (pictureBox_0 != null)
			{
				WaitSendingReportControl.smethod_2((Component)(object)pictureBox_0, 1016, 914);
			}
		}
		((Control)this).Dispose(disposing);
	}

	private void PoweredBy_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly");
		}
		catch
		{
		}
	}

	public PoweredBy()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Label val = (label_0 = new Label());
		PictureBox val2 = (pictureBox_0 = new PictureBox());
		ToolTip val3 = (toolTip_0 = new ToolTip());
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		AppRegistryKeys.smethod_0((Control)(object)this, 255, 140);
		Class23.smethod_4(label_0, (FlatStyle)3, 319, 349);
		FeedbackControl.smethod_0((Control)(object)label_0, new Point(0, 10), 512, 632);
		SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_2((Control)(object)label_0, new Size(62, 24), 312, 279);
		AppNameFinder.smethod_3((Control)(object)label_0, "Powered by", 226, 155);
		HeaderControl.smethod_1(pictureBox_0, (Image)(object)Class21.smethod_0("{logo}"), 745, 659);
		FeedbackControl.smethod_0((Control)(object)pictureBox_0, new Point(72, 0), 533, 621);
		SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_2((Control)(object)pictureBox_0, new Size(32, 32), 461, 482);
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		smethod_4((Control)(object)label_0, PoweredBy_Click, 995, 1013);
		smethod_4((Control)(object)pictureBox_0, PoweredBy_Click, 1013, 995);
		((Control)this).add_Click((EventHandler)PoweredBy_Click);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_TabStop(false);
		((Control)this).set_Size(new Size(112, 32));
		SimpleZip.Class9.smethod_0((Control)(object)this, 561, 614).AddRange((Control[])(object)new Control[2]
		{
			(Control)pictureBox_0,
			(Control)label_0
		});
		toolTip_0.SetToolTip((Control)(object)this, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)label_0, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, "Powered by SmartAssembly");
		((Control)this).ResumeLayout(true);
	}

	[SecuritySafeCritical]
	static PoweredBy()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_0(RSACryptoServiceProvider rsacryptoServiceProvider_0, byte[] byte_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 8:
				return rsacryptoServiceProvider_0.Encrypt(byte_0, bool_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static MethodInfo smethod_1(Type type_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				return type_0.GetMethod(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string[] smethod_2(string string_0, char[] char_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return string_0.Split(char_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Font smethod_3(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return control_0.get_Font();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				control_0.add_Click(eventHandler_0);
				return;
			case 23:
				control_0.add_Click(eventHandler_0);
				return;
			}
		}
	}
}
