using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MiniGameEngine;

public class RoundLabel : Label
{
	public RoundLabel()
	{
		Class11.NQ1E32yzjMukk();
		((Label)this)._002Ector();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		val.AddEllipse(0, 0, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height);
		((Control)this).set_Region(new Region(val));
		((Label)this).OnPaint(e);
	}
}
