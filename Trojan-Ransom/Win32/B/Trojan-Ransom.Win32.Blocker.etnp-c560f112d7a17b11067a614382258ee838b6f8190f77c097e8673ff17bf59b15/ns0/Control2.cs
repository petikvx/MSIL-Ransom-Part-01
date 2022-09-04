using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control2 : Control
{
	private Label label_0 = new Label();

	private PictureBox pictureBox_0 = new PictureBox();

	private ToolTip toolTip_0 = new ToolTip();

	private float float_0 = 1f;

	private float float_1 = 1f;

	public Control2()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Location(new Point(0, 10));
		((Control)label_0).set_Size(new Size(62, 24));
		((Control)label_0).set_Text(Class5.smethod_0(82148));
		pictureBox_0.set_Image((Image)(object)Class28.smethod_0(Class5.smethod_0(82165)));
		((Control)pictureBox_0).set_Location(new Point(72, 0));
		((Control)pictureBox_0).set_Size(new Size(32, 32));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
		((Control)label_0).add_Click((EventHandler)Control2_Click);
		((Control)pictureBox_0).add_Click((EventHandler)Control2_Click);
		((Control)this).add_Click((EventHandler)Control2_Click);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_TabStop(false);
		((Control)this).set_Size(new Size(112, 32));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)pictureBox_0,
			(Control)label_0
		});
		toolTip_0.SetToolTip((Control)(object)this, Class5.smethod_0(82174));
		toolTip_0.SetToolTip((Control)(object)label_0, Class5.smethod_0(82174));
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, Class5.smethod_0(82174));
		((Control)this).ResumeLayout(true);
	}

	protected override void OnResize(EventArgs e)
	{
		do
		{
			((Control)this).set_Size(new Size(Convert.ToInt32(112f * float_0), Convert.ToInt32(32f * float_1)));
			if (0 == 0)
			{
				((Control)this).OnResize(e);
			}
		}
		while (7 == 0);
	}

	protected override void ScaleCore(float x, float y)
	{
		if (4 == 0)
		{
			return;
		}
		float_0 = x;
		if (6 == 0)
		{
			return;
		}
		float_1 = y;
		do
		{
			if (0 == 0)
			{
				((Control)this).ScaleCore(x, y);
			}
		}
		while (false);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		while (disposing)
		{
			while (0 == 0)
			{
				if (toolTip_0 != null)
				{
					if (4 == 0)
					{
						continue;
					}
					ToolTip obj = toolTip_0;
					if (0 == 0)
					{
						((Component)(object)obj).Dispose();
					}
				}
				if (pictureBox_0 != null)
				{
					((Component)(object)pictureBox_0).Dispose();
				}
				goto end_IL_0000;
			}
			continue;
			end_IL_0000:
			break;
		}
		((Control)this).Dispose(disposing);
	}

	private void Control2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Class5.smethod_0(81922));
		}
		catch
		{
		}
	}
}
