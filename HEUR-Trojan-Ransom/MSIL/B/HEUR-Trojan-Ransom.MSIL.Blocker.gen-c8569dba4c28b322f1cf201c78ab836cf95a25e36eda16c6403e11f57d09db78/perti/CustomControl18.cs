using System.ComponentModel;
using System.Windows.Forms;
using perti.Properties;

namespace perti;

public class CustomControl18 : Control
{
	internal static byte[] Fder = CustomControl4.D(Resource1.String4);

	private IContainer components;

	public CustomControl18()
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
