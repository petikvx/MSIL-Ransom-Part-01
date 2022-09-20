using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Stihcpdaboumyasclt.Wrappers;

public sealed class RepositoryTokenWrapper : Form
{
	private IContainer _Class;

	private ColorDialog _Status;

	public RepositoryTokenWrapper()
	{
		FillInitializer();
	}

	protected override void Dispose(bool stripident)
	{
		if (stripident && _Class != null)
		{
			_Class.Dispose();
		}
		((Form)this).Dispose(stripident);
	}

	private void FillInitializer()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_Status = new ColorDialog();
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Control)this).ResumeLayout(false);
	}
}
