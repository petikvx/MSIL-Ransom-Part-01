using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Fr92;

public class Dm7i : Button
{
	public Dm7i()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).add_Click((EventHandler)delegate
		{
			i3RF();
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

	private void i3RF()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerHidden]
	private void w2W6(object t7FA, EventArgs q1DG)
	{
		i3RF();
	}
}
