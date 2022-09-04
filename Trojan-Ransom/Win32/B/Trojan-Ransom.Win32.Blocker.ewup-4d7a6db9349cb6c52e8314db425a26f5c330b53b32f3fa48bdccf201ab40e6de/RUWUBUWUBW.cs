using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
internal class RUWUBUWUBW : Form
{
	private IContainer WERBWEBBWER;

	public RUWUBUWUBW()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && WERBWEBBWER != null)
			{
				WERBWEBBWER.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		Label val = new Label();
		((Control)this).SuspendLayout();
		((Control)val).set_AccessibleDescription("descript1");
		((Control)val).set_AccessibleName("dfsfsdfs");
		((Control)val).set_AccessibleRole((AccessibleRole)54);
		val.set_AutoSize(false);
		((Control)val).set_BackColor(SystemColors.HighlightText);
		val.set_BorderStyle((BorderStyle)1);
		((Control)val).set_Cursor(Cursors.get_SizeWE());
		((Control)val).set_Dock((DockStyle)5);
		((Control)val).set_Enabled(true);
		((Control)val).set_ContextMenuStrip((ContextMenuStrip)null);
		((Control)val).set_Font(new Font("Segoe Print", 6.25f, (FontStyle)12, (GraphicsUnit)3, (byte)0));
		((Control)val).set_ForeColor(Color.CadetBlue);
		Size clientSize = new Size(298, 183);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).set_Name("lup");
		((Form)this).set_Text("sem");
		((Control)this).ResumeLayout(false);
	}
}
