using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace o9F5;

[DesignerGenerated]
public class q3K6 : Form
{
	private Panel _Panel1;

	internal IContainer f;

	public q3K6()
	{
		Mc90();
	}

	protected override void s9W5(bool Ff54)
	{
		try
		{
			if (Ff54 && f != null)
			{
				f.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ff54);
		}
	}

	private void Mc90()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		d5QA(new Panel());
		((Control)this).SuspendLayout();
		((Control)Qe3p()).set_Location(new Point(65, 50));
		((Control)Qe3p()).set_Name("Panel1");
		((Control)Qe3p()).set_Size(new Size(651, 343));
		((Control)Qe3p()).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Qe3p());
		((Control)this).set_Name("OlivaPending");
		((Form)this).set_Text("OlivaPending");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Qe3p()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5QA(Panel Bm58)
	{
		_Panel1 = Bm58;
	}
}
