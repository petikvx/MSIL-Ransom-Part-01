using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Polirovka;

public class Form2 : Form
{
	private IContainer icontainer_0;

	private FileSystemWatcher fileSystemWatcher_0;

	private MaskedTextBox maskedTextBox1;

	private ListBox listBox1;

	private Label label1;

	public Form2()
	{
		Class9.T7DkdFQzGSTU8();
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		fileSystemWatcher_0 = new FileSystemWatcher();
		label1 = new Label();
		listBox1 = new ListBox();
		maskedTextBox1 = new MaskedTextBox();
		((ISupportInitialize)fileSystemWatcher_0).BeginInit();
		((Control)this).SuspendLayout();
		fileSystemWatcher_0.EnableRaisingEvents = true;
		fileSystemWatcher_0.SynchronizingObject = (ISynchronizeInvoke?)this;
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(0, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("label1");
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(8, 8));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(120, 95));
		((Control)listBox1).set_TabIndex(1);
		((Control)maskedTextBox1).set_Location(new Point(16, 16));
		((Control)maskedTextBox1).set_Name("maskedTextBox1");
		((Control)maskedTextBox1).set_Size(new Size(100, 20));
		((Control)maskedTextBox1).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((ISupportInitialize)fileSystemWatcher_0).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
