using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl10 : Control
{
	internal static int I;

	private IContainer components;

	public CustomControl10()
	{
		InitializeComponent();
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		((Control)this).OnPaint(pe);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((Control)this).set_Text("A");
		((Control)this).ResumeLayout(false);
	}
}
