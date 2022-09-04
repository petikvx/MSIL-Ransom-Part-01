using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl34 : Control
{
	private IContainer components;

	public CustomControl34()
	{
		InitializeComponent();
	}

	internal static int Index()
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
