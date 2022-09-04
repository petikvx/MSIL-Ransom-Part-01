using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl24 : Control
{
	private IContainer components;

	public CustomControl24()
	{
		InitializeComponent();
	}

	internal static int Inde()
	{
		return (CustomControl10.I + 1) % CustomControl9.SaLength;
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
