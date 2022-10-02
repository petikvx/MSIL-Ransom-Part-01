using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace y3Z6;

[DesignerGenerated]
public class d1H6 : Form
{
	internal IContainer I;

	internal Panel L;

	public d1H6()
	{
		z5CB();
	}

	protected override void f2L6(bool Lq46)
	{
		try
		{
			if (Lq46 && I != null)
			{
				I.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lq46);
		}
	}

	private void z5CB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		b2R6(new Panel());
		((Control)this).SuspendLayout();
		((Control)w8HN()).set_Location(new Point(65, 50));
		((Control)w8HN()).set_Name("Panel1");
		((Control)w8HN()).set_Size(new Size(651, 343));
		((Control)w8HN()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)w8HN());
		((Control)this).set_Name("OlivaPending");
		((Form)this).set_Text("OlivaPending");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel w8HN()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2R6(Panel Zf5d)
	{
		Panel val = (L = Zf5d);
	}
}
