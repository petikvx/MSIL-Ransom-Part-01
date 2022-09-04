using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace n.Delegates.T;

[StandardModule]
public sealed class T
{
	private delegate void DELappendText(ref Form Frm, ref byte[] D);

	public static void appendText(ref Form Frm, ref byte[] D)
	{
		if (Frm != null && !((Control)Frm).get_IsDisposed())
		{
			if (((Control)Frm).get_InvokeRequired())
			{
				DELappendText dELappendText = appendText;
				((Control)Frm).Invoke((Delegate)dELappendText, new object[2] { Frm, D });
			}
			else
			{
				IND.ind(D);
			}
		}
	}
}
