using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace z8AQ;

[DesignerGenerated]
public class w2TA : Form
{
	private IContainer components;

	internal Panel k;

	public w2TA()
	{
		n6E7();
	}

	protected override void Hn0r(bool Wz7t)
	{
		try
		{
			if (Wz7t && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wz7t);
		}
	}

	private void n6E7()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		j8T2(new Panel());
		((Control)this).SuspendLayout();
		((Control)Mf2r()).set_Location(new Point(65, 50));
		((Control)Mf2r()).set_Name("Panel1");
		((Control)Mf2r()).set_Size(new Size(651, 343));
		((Control)Mf2r()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Mf2r());
		((Control)this).set_Name("OlivaPending");
		((Form)this).set_Text("OlivaPending");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Mf2r()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8T2(Panel Kg74)
	{
		Panel val = (k = Kg74);
	}
}
