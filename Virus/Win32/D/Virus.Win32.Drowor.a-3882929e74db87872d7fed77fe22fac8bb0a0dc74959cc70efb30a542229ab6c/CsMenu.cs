using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class CsMenu : UserControl
{
	private IContainer icontainer_0;

	public CsMenu()
	{
		InitializeComponent();
	}

	public void method_0(string string_0)
	{
		Class1 @class = new Class1(string_0);
		((Control)@class).set_Size(new Size(150, 25));
		((Control)@class).set_Dock((DockStyle)1);
		((Control)this).get_Controls().Add((Control)(object)@class);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_Name("CsMenu");
		((Control)this).set_Size(new Size(174, 258));
		((Control)this).ResumeLayout(false);
	}
}
