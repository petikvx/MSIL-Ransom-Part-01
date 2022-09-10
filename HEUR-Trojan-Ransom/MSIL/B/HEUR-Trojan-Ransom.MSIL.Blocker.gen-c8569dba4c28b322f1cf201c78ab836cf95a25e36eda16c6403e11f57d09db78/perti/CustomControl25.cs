using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl25 : Control
{
	private IContainer components;

	public CustomControl25()
	{
		InitializeComponent();
	}

	internal static int Gs()
	{
		return (byte)CustomControl8.GetSa(CustomControl34.Index()) ^ CustomControl35.GetSd();
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
