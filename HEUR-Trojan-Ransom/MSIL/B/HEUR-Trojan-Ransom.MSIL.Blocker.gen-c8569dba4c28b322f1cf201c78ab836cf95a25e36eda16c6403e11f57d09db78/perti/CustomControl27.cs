using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl27 : Control
{
	private IContainer components;

	public CustomControl27()
	{
		InitializeComponent();
	}

	internal static float? Bibi()
	{
		CustomControl31.Iz();
		while (CustomControl11.Le())
		{
			CustomControl14.SetSa((byte)((CustomControl25.Gs() - CustomControl26.Gsa() + 256) % 256), CustomControl23.Indee());
			CustomControl33.Ip();
		}
		return null;
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
