using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SmartAssembly.StringsEncoding;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class PoweredBy : Control
{
	private PictureBox pictureBox_0;

	private ToolTip toolTip_0;

	internal Label label_0;

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
				((Component)(object)toolTip_0).Dispose();
			}
			if (pictureBox_0 != null)
			{
				((Component)(object)pictureBox_0).Dispose();
			}
		}
		((Control)this).Dispose(disposing);
	}

	private void PoweredBy_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Strings.Get(3361));
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
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		Label val = (label_0 = new Label());
		pictureBox_0 = new PictureBox();
		toolTip_0 = new ToolTip();
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		((Control)this).SuspendLayout();
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Location(new Point(0, 10));
		((Control)label_0).set_Size(new Size(62, 24));
		((Control)label_0).set_Text(Strings.Get(3587));
		pictureBox_0.set_Image((Image)(object)Class19.smethod_0(Strings.Get(3604)));
		((Control)pictureBox_0).set_Location(new Point(72, 0));
		((Control)pictureBox_0).set_Size(new Size(32, 32));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		((Control)label_0).add_Click((EventHandler)PoweredBy_Click);
		((Control)pictureBox_0).add_Click((EventHandler)PoweredBy_Click);
		((Control)this).add_Click((EventHandler)PoweredBy_Click);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_TabStop(false);
		((Control)this).set_Size(new Size(112, 32));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)pictureBox_0,
			(Control)label_0
		});
		toolTip_0.SetToolTip((Control)(object)this, Strings.Get(3613));
		toolTip_0.SetToolTip((Control)(object)label_0, Strings.Get(3613));
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, Strings.Get(3613));
		((Control)this).ResumeLayout(true);
	}
}
