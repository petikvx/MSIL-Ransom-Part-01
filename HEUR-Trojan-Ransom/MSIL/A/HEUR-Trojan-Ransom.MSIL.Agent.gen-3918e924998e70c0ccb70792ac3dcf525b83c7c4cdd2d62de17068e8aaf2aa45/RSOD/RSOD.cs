using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RSOD;

public class RSOD : Form
{
	private IContainer components;

	private TextBox textBox1;

	public RSOD()
	{
		InitializeComponent();
	}

	private void RSOD_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RSOD));
		textBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_BackColor(SystemColors.WindowText);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Blue);
		((Control)textBox1).set_Location(new Point(12, 256));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(267, 38));
		((Control)textBox1).set_TabIndex(0);
		((Control)textBox1).set_Text("Ransowmare by a kid");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(640, 480));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("RSOD");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("RSOD");
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(RSOD_FormClosing));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
