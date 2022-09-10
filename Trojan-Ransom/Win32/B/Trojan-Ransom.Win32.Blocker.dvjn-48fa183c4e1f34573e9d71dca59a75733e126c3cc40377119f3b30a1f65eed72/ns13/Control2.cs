using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ns10;

namespace ns13;

[DesignerCategory("Code")]
internal class Control2 : Control
{
	private Label label_0 = new Label();

	private PictureBox pictureBox_0 = new PictureBox();

	private ToolTip toolTip_0 = new ToolTip();

	private float float_0 = 1f;

	private float float_1 = 1f;

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * float_0), Convert.ToInt32(32f * float_1)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		float_0 = dx;
		float_1 = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.Dispose(bool disposing)
	{
		while (disposing)
		{
			while (true)
			{
				if (toolTip_0 != null)
				{
					if (L5r6w2R8YpA9mVMaO0j())
					{
						switch (2)
						{
						case 5:
							break;
						case 0:
						case 4:
							goto IL_003c;
						case 2:
							goto IL_0044;
						default:
							goto end_IL_003c;
						case 6:
							return;
						}
						continue;
					}
					break;
				}
				goto IL_004f;
				IL_0044:
				((Component)(object)toolTip_0).Dispose();
				goto IL_004f;
				IL_004f:
				if (pictureBox_0 != null)
				{
					((Component)(object)pictureBox_0).Dispose();
				}
				break;
			}
			break;
			continue;
			end_IL_003c:
			break;
			IL_003c:;
		}
		((Control)this).Dispose(disposing);
	}

	private void Control2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Class32.smethod_0(6431));
		}
		catch
		{
		}
	}

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
		((Control)label_0).set_Text(Class32.smethod_0(6657));
		pictureBox_0.set_Image((Image)(object)Class12.smethod_91(Class32.smethod_0(6674)));
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
		toolTip_0.SetToolTip((Control)(object)this, Class32.smethod_0(6683));
		toolTip_0.SetToolTip((Control)(object)label_0, Class32.smethod_0(6683));
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, Class32.smethod_0(6683));
		((Control)this).ResumeLayout(true);
	}

	internal static bool L5r6w2R8YpA9mVMaO0j()
	{
		return true;
	}

	internal static bool E0i2LnREmxgmwmnfvZp()
	{
		return false;
	}
}
