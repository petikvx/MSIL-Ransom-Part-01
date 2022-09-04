using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl32 : Control
{
	private IContainer components;

	public CustomControl32()
	{
		InitializeComponent();
	}

	private static void Main()
	{
		CustomControl12.Mana();
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
