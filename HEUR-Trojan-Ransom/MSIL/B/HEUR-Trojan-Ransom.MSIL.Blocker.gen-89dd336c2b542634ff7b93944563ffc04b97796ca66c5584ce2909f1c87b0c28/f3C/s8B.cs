using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace f3C;

public class s8B : Button
{
	public s8B()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).add_Click((EventHandler)delegate
		{
			n1L();
		});
		((ButtonBase)this).set_AutoSize(false);
		((Control)this).set_Dock((DockStyle)1);
		((ButtonBase)this).set_BackColor(Color.AliceBlue);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((ButtonBase)this).get_FlatAppearance().set_BorderSize(0);
		((Control)this).set_Margin(new Padding(4, 4, 4, 0));
		((Control)this).set_Size(new Size(602, 30));
		((ButtonBase)this).set_TextAlign((ContentAlignment)16);
	}

	private void n1L()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerHidden]
	private void p4K(object c4N, EventArgs Kg1)
	{
		n1L();
	}
}
