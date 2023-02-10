using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace g7W;

public class Qo2 : Button
{
	public Qo2()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).add_Click((EventHandler)delegate
		{
			b8H();
		});
		((ButtonBase)this).set_AutoSize(false);
		((Control)this).set_Dock((DockStyle)1);
		((ButtonBase)this).set_BackColor(Color.AliceBlue);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((ButtonBase)this).get_FlatAppearance().set_BorderSize(0);
		((Control)this).set_Margin(new Padding(4, 4, 4, 0));
		((Control)this).set_Size(new Size(525, 30));
		((ButtonBase)this).set_TextAlign((ContentAlignment)16);
	}

	private void b8H()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerHidden]
	private void o0H(object p3F, EventArgs Qy8)
	{
		b8H();
	}
}
