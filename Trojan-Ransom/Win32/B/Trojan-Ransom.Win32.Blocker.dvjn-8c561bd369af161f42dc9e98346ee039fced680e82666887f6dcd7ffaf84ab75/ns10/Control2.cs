using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ns7;

namespace ns10;

[DesignerCategory("Code")]
internal class Control2 : Control
{
	private Label label_0;

	private PictureBox pictureBox_0;

	private ToolTip toolTip_0;

	private float float_0;

	private float float_1;

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * float_0), Convert.ToInt32(32f * float_1)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		int num = 3;
		if (NC7qRdr6M7UA8jiVxTv())
		{
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					float_0 = dx;
					num = 4;
					if (NC7qRdr6M7UA8jiVxTv())
					{
						continue;
					}
					return;
				default:
					num = 1;
					if (NC7qRdr6M7UA8jiVxTv())
					{
						continue;
					}
					goto IL_005c;
				case 4:
					break;
				case 1:
				case 2:
					goto IL_005c;
				case 5:
					return;
				}
				break;
			}
		}
		float_1 = dy;
		goto IL_005c;
		IL_005c:
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
					int num = 5;
					if (!DgAo6Ar04e0K2vrUaBg())
					{
					}
					while (true)
					{
						switch (num)
						{
						default:
							num = 4;
							if (NC7qRdr6M7UA8jiVxTv())
							{
								continue;
							}
							break;
						case 1:
						case 3:
							break;
						case 0:
						case 2:
							goto end_IL_0041;
						case 5:
							goto IL_0050;
						case 4:
							goto end_IL_004b;
						case 6:
							return;
						}
						break;
					}
					continue;
				}
				goto IL_005b;
				IL_0050:
				((Component)(object)toolTip_0).Dispose();
				goto IL_005b;
				IL_005b:
				if (pictureBox_0 != null)
				{
					((Component)(object)pictureBox_0).Dispose();
				}
				goto end_IL_004b;
				continue;
				end_IL_0041:
				break;
			}
			continue;
			end_IL_004b:
			break;
		}
		((Control)this).Dispose(disposing);
	}

	private void Control2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Class14.smethod_0(6271));
		}
		catch
		{
		}
	}

	public Control2()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		while (true)
		{
			label_0 = new Label();
			int num = 1;
			if (!DgAo6Ar04e0K2vrUaBg())
			{
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					pictureBox_0 = new PictureBox();
					toolTip_0 = new ToolTip();
					float_0 = 1f;
					float_1 = 1f;
					((Control)this)._002Ector();
					num = 9;
					if (DgAo6Ar04e0K2vrUaBg())
					{
					}
					continue;
				default:
					num = 0;
					if (!DgAo6Ar04e0K2vrUaBg())
					{
						continue;
					}
					goto case 5;
				case 8:
					break;
				case 9:
					((Control)this).SuspendLayout();
					label_0.set_FlatStyle((FlatStyle)3);
					((Control)label_0).set_Location(new Point(0, 10));
					((Control)label_0).set_Size(new Size(62, 24));
					goto case 2;
				case 2:
					((Control)label_0).set_Text(Class14.smethod_0(6497));
					pictureBox_0.set_Image((Image)(object)Class33.smethod_112(Class14.smethod_0(6514)));
					goto case 3;
				case 3:
				case 4:
					((Control)pictureBox_0).set_Location(new Point(72, 0));
					((Control)pictureBox_0).set_Size(new Size(32, 32));
					pictureBox_0.set_SizeMode((PictureBoxSizeMode)1);
					((Control)label_0).add_Click((EventHandler)Control2_Click);
					((Control)pictureBox_0).add_Click((EventHandler)Control2_Click);
					goto case 0;
				case 0:
					((Control)this).add_Click((EventHandler)Control2_Click);
					goto case 5;
				case 5:
				case 6:
					((Control)this).set_Cursor(Cursors.get_Hand());
					((Control)this).set_TabStop(false);
					goto case 7;
				case 7:
					((Control)this).set_Size(new Size(112, 32));
					((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
					{
						(Control)pictureBox_0,
						(Control)label_0
					});
					toolTip_0.SetToolTip((Control)(object)this, Class14.smethod_0(6523));
					toolTip_0.SetToolTip((Control)(object)label_0, Class14.smethod_0(6523));
					toolTip_0.SetToolTip((Control)(object)pictureBox_0, Class14.smethod_0(6523));
					((Control)this).ResumeLayout(true);
					return;
				case 10:
					return;
				}
				break;
			}
		}
	}

	internal static bool NC7qRdr6M7UA8jiVxTv()
	{
		return true;
	}

	internal static bool DgAo6Ar04e0K2vrUaBg()
	{
		return false;
	}
}
