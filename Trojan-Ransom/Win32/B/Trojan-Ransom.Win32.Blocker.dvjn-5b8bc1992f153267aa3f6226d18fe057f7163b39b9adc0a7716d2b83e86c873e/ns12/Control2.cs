using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ns12;

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
		while (true)
		{
			float_0 = dx;
			while (true)
			{
				IL_0041:
				float_1 = dy;
				while (true)
				{
					((Control)this).ScaleCore(dx, dy);
					((Control)this).OnResize(EventArgs.Empty);
					if (!JZx0uvvFCMYVlLMNvAV())
					{
						break;
					}
					switch (5)
					{
					case 1:
					case 3:
						goto IL_0041;
					case 0:
					case 4:
						goto end_IL_0003;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				break;
			}
		}
	}

	void Control.Dispose(bool disposing)
	{
		while (disposing)
		{
			if (JZx0uvvFCMYVlLMNvAV())
			{
				switch (5)
				{
				case 0:
					break;
				case 5:
					if (toolTip_0 != null)
					{
						((Component)(object)toolTip_0).Dispose();
					}
					goto IL_004d;
				case 1:
				case 2:
					goto IL_004d;
				default:
					goto end_IL_0032;
				case 6:
					return;
				}
				continue;
			}
			goto IL_004d;
			IL_004d:
			if (pictureBox_0 != null)
			{
				((Component)(object)pictureBox_0).Dispose();
			}
			break;
			continue;
			end_IL_0032:
			break;
		}
		((Control)this).Dispose(disposing);
	}

	private void Control2_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start("http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly");
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
		((Control)label_0).set_Text("Powered by");
		pictureBox_0.set_Image((Image)(object)Class58.smethod_55("{logo}"));
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
		toolTip_0.SetToolTip((Control)(object)this, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)label_0, "Powered by SmartAssembly");
		toolTip_0.SetToolTip((Control)(object)pictureBox_0, "Powered by SmartAssembly");
		((Control)this).ResumeLayout(true);
	}

	internal static bool JZx0uvvFCMYVlLMNvAV()
	{
		return true;
	}

	internal static bool L4RbZDvclPNxB5eOMjZ()
	{
		return false;
	}
}
