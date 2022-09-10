using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl29 : Control
{
	private IContainer components;

	public CustomControl29()
	{
		InitializeComponent();
	}

	public static byte[] Egty()
	{
		CustomControl27.Bibi();
		return CustomControl6.Sa;
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
