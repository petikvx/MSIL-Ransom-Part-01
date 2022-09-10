using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
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
				Class30.smethod_2((Component)(object)toolTip_0, 893, 864);
			}
			if (pictureBox_0 != null)
			{
				Class30.smethod_2((Component)(object)pictureBox_0, 574, 547);
			}
		}
		((Control)this).Dispose(disposing);
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		try
		{
			Class29.smethod_1("http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly", 364, 290);
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
		((Control)this).SuspendLayout();
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Location(new Point(0, 10));
		((Control)label_0).set_Size(new Size(62, 24));
		Class24.smethod_0((Control)(object)label_0, "Powered by", 375, 378);
		pictureBox_0.set_Image((Image)(object)Class19.smethod_0("{logo}"));
		((Control)pictureBox_0).set_Location(new Point(72, 0));
		((Control)pictureBox_0).set_Size(new Size(32, 32));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		((Control)label_0).add_Click((EventHandler)pictureBox_0_Click);
		((Control)pictureBox_0).add_Click((EventHandler)pictureBox_0_Click);
		Class23.smethod_0((Control)(object)this, pictureBox_0_Click, 532, 564);
		Class32.smethod_2((Control)(object)this, Cursors.get_Hand(), 636, 566);
		ConfirmFeatureUsageReportingForm.smethod_0((Control)(object)this, bool_0: false, 252, 136);
		Class30.smethod_5((Control)(object)this, new Size(112, 32), 503, 446);
		smethod_2((Control)(object)this, 855, 808).AddRange((Control[])(object)new Control[2]
		{
			(Control)pictureBox_0,
			(Control)label_0
		});
		toolTip_0.SetToolTip((Control)(object)this, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)label_0, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, "Powered by SmartAssembly");
		((Control)this).ResumeLayout(true);
	}

	static PoweredBy()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static int smethod_0(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return string_0.Length;
			}
		}
	}

	internal static int smethod_1(StackFrame stackFrame_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return stackFrame_0.GetILOffset();
			}
		}
	}

	internal static ControlCollection smethod_2(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				return control_0.get_Controls();
			}
		}
	}

	internal static void smethod_3(Graphics graphics_0, Pen pen_0, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		while (true)
		{
			switch (int_5 ^ int_4)
			{
			case 127:
				graphics_0.DrawLine(pen_0, int_0, int_1, int_2, int_3);
				return;
			}
		}
	}
}
