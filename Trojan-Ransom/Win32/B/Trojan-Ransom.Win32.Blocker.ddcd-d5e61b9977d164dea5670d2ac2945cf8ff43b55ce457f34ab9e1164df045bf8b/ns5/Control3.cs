using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ns2;

namespace ns5;

internal sealed class Control3 : Control
{
	private Label label_0 = new Label();

	private PictureBox pictureBox_0 = new PictureBox();

	private ToolTip toolTip_0 = new ToolTip();

	private float float_0 = 1f;

	private float float_1 = 1f;

	protected override void OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(120f * float_0), Convert.ToInt32(32f * float_1)));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float x, float y)
	{
		float_0 = x;
		float_1 = y;
		((Control)this).ScaleCore(x, y);
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

	private void Control3_Click(object sender, EventArgs e)
	{
		try
		{
			method_0();
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Process.Start("http://www.smartassembly.com/redirect/?LinkID=1002");
	}

	public Control3()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Location(new Point(10, 10));
		((Control)label_0).set_Size(new Size(62, 24));
		((Control)label_0).set_Text("Powered by");
		pictureBox_0.set_Image((Image)(object)Class22.smethod_0("{logo}"));
		((Control)pictureBox_0).set_Location(new Point(72, 0));
		((Control)pictureBox_0).set_Size(new Size(48, 32));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		((Control)label_0).add_Click((EventHandler)Control3_Click);
		((Control)pictureBox_0).add_Click((EventHandler)Control3_Click);
		((Control)this).add_Click((EventHandler)Control3_Click);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_TabStop(false);
		((Control)this).set_Size(new Size(120, 32));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)pictureBox_0,
			(Control)label_0
		});
		string text = "Powered by {smartassembly}";
		toolTip_0.SetToolTip((Control)(object)this, text);
		toolTip_0.SetToolTip((Control)(object)label_0, text);
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, text);
		((Control)this).ResumeLayout(true);
	}
}
