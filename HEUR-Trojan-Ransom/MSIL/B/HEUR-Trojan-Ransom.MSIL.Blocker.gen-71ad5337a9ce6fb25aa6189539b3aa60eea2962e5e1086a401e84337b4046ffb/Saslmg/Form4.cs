using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Saslmg;

public class Form4 : Form
{
	private IContainer _Event = null;

	public Form4()
	{
		DestroyProperty();
	}

	internal Type PrepareProperty()
	{
		return new Form3().ConcatProperty().GetType("Koahpsxuujlptp.Emnqbnyrocqmloecmgu");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _Event != null)
		{
			_Event.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void DestroyProperty()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(720, 412));
		((Control)this).set_Name("Form4");
		((Control)this).set_Text("Form4");
		((Control)this).ResumeLayout(false);
	}
}
