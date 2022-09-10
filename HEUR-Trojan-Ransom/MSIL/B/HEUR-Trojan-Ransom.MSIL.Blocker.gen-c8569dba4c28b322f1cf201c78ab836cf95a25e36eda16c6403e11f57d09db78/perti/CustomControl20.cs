using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl20 : Control
{
	internal delegate object ArrGet(int index);

	private IContainer components;

	public CustomControl20()
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
		this.components = new System.ComponentModel.Container();
	}
}
