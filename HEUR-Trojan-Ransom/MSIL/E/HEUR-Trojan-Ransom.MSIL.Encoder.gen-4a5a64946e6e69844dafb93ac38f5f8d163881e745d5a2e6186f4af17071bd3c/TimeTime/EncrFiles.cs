using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TimeTime;

public class EncrFiles : Form
{
	private IContainer components = null;

	private Label label1;

	private ListBox listBox1;

	public EncrFiles()
	{
		InitializeComponent();
	}

	private void EncrFiles_Load(object sender, EventArgs e)
	{
		((Control)label1).set_Text("We encrypted <count> files.".Replace("<count>", Cryptor.encr_files.Count.ToString() ?? ""));
		listBox1.get_Items().Clear();
		foreach (string encr_file in Cryptor.encr_files)
		{
			listBox1.get_Items().Add((object)encr_file);
		}
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		label1 = new Label();
		listBox1 = new ListBox();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 24));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(350, 37));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("We encrypted <count> files.");
		((Control)listBox1).set_BackColor(Color.FromArgb(32, 32, 32));
		((Control)listBox1).set_ForeColor(Color.White);
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(12, 83));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(797, 316));
		((Control)listBox1).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(32, 32, 32));
		((Form)this).set_ClientSize(new Size(821, 440));
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("EncrFiles");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("What files have been encrypted");
		((Form)this).add_Load((EventHandler)EncrFiles_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
