using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl33 : Control
{
	private IContainer components;

	public CustomControl33()
	{
		InitializeComponent();
	}

	internal static float Ip()
	{
		return CustomControl10.I++;
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
		this.components = new System.ComponentModel.Container();
	}
}
