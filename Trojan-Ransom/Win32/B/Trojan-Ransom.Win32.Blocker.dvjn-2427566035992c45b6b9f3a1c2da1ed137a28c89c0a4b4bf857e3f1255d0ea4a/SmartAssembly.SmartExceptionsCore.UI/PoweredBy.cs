using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class PoweredBy : Control
{
	private const string PoweredByText = "Powered by SmartAssembly";

	private const string WebLink = "http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly";

	private Label label;

	private PictureBox logo;

	private ToolTip toolTip;

	private float dx;

	private float dy;

	protected override void OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(112f * dx), Convert.ToInt32(32f * dy)));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float dx, float dy)
	{
		this.dx = dx;
		this.dy = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (toolTip != null)
			{
				((Component)(object)toolTip).Dispose();
			}
			if (logo != null)
			{
				((Component)(object)logo).Dispose();
			}
		}
		((Control)this).Dispose(disposing);
	}

	private void OnClick(object sender, EventArgs e)
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		Class2.l4t8M9wzGUypc();
		label = new Label();
		logo = new PictureBox();
		toolTip = new ToolTip();
		dx = 1f;
		dy = 1f;
		((Control)this)._002Ector();
		((Control)this).SuspendLayout();
		label.set_FlatStyle((FlatStyle)3);
		((Control)label).set_Location(new Point(0, 10));
		((Control)label).set_Size(new Size(62, 24));
		((Control)label).set_Text("Powered by");
		logo.set_Image((Image)(object)Resources.GetBitmap("{logo}"));
		((Control)logo).set_Location(new Point(72, 0));
		((Control)logo).set_Size(new Size(32, 32));
		logo.set_SizeMode((PictureBoxSizeMode)1);
		((Control)label).add_Click((EventHandler)OnClick);
		((Control)logo).add_Click((EventHandler)OnClick);
		((Control)this).add_Click((EventHandler)OnClick);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Control)this).set_TabStop(false);
		((Control)this).set_Size(new Size(112, 32));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)logo,
			(Control)label
		});
		toolTip.SetToolTip((Control)(object)this, "Powered by SmartAssembly");
		toolTip.SetToolTip((Control)(object)label, "Powered by SmartAssembly");
		toolTip.SetToolTip((Control)(object)logo, "Powered by SmartAssembly");
		((Control)this).ResumeLayout(true);
	}
}
