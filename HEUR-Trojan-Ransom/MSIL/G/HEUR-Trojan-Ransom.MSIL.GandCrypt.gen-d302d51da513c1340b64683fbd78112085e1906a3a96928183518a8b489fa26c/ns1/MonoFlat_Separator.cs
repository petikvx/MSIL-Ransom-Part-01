using System.Drawing;
using System.Windows.Forms;

namespace ns1;

public class MonoFlat_Separator : Control
{
	public MonoFlat_Separator()
	{
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).set_Size((Size)new Point(120, 10));
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		paintEventArgs_0.get_Graphics().DrawLine(new Pen(Color.FromArgb(45, 57, 68)), 0, 5, ((Control)this).get_Width(), 5);
	}
}
