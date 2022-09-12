using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LegionLocker;

public class Contact : Form
{
	private IContainer components = null;

	private Label label1;

	public Contact()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Lime);
		((Control)label1).set_Location(new Point(-1, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(514, 144));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("If you want contact us:\r\n\r\n\r\n1.Download tor browser (hxxps://www.torproject.org/)\r\n2.Create account on mail2tor (hxxp://mail2tor2zyjdctd.onion/)\r\n3.Write e-mail to us (CobraLocker@mail2tor.com)");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(510, 189));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Contact");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Contact");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
