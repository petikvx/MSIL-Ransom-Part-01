using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace MiniGameEngine;

[DesignerGenerated]
public class Editor : Form
{
	private IContainer icontainer_0;

	public Editor()
	{
		Class11.NQ1E32yzjMukk();
		((Form)this)._002Ector();
		method_0();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		icontainer_0 = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_Text("Editor");
	}
}
