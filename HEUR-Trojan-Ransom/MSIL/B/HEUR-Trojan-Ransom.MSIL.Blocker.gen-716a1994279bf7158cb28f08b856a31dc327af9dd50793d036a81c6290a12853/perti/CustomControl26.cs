using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl26 : Control
{
	private IContainer components;

	public CustomControl26()
	{
		InitializeComponent();
	}

	internal static byte Gsa()
	{
		return (byte)CustomControl8.GetSa(CustomControl24.Inde());
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
