using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl31 : Control
{
	private IContainer components;

	public CustomControl31()
	{
		InitializeComponent();
	}

	internal static float Iz()
	{
		CustomControl10.I = 0;
		return 0f;
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
