using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm0 : Form
{
	private IContainer icontainer_0;

	public GForm0()
	{
		((Form)this).add_Load((EventHandler)GForm0_Load);
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(232, 38));
		((Control)this).set_Name(Class16.smethod_0(-561835741));
		((Form)this).set_Text(Class16.smethod_0(-561835729));
		((Control)this).ResumeLayout(false);
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		((Control)this).Hide();
		bool flag = true;
		while (flag)
		{
			GForm4 gForm = new GForm4();
			flag = (int)((Form)gForm).ShowDialog() == 6;
		}
		((Form)this).Close();
	}
}
