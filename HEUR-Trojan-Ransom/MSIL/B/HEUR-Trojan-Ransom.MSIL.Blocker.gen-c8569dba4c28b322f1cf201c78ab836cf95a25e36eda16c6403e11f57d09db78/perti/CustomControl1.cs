using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl1 : Control
{
	internal delegate byte[] FromBase64(string data);

	private IContainer components;

	public CustomControl1()
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
