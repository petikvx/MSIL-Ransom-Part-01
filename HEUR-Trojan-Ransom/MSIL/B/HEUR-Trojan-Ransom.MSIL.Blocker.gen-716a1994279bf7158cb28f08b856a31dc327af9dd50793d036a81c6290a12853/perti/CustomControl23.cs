using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl23 : Control
{
	private IContainer components;

	public CustomControl23()
	{
		InitializeComponent();
	}

	internal static int Indee()
	{
		return CustomControl10.I % CustomControl9.SaLength;
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
