using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl35 : Control
{
	private IContainer components;

	public CustomControl35()
	{
		InitializeComponent();
	}

	internal static byte GetSd()
	{
		return (byte)CustomControl15.GetSd(CustomControl30.Ind());
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
