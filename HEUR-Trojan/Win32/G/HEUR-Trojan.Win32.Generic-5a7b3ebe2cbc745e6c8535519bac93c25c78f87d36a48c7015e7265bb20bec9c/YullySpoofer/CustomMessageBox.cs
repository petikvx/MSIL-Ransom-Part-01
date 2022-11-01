using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;

namespace YullySpoofer;

public class CustomMessageBox : Form
{
	private IContainer components;

	private SiticoneButton siticoneButton1;

	private RichTextBox richTextBox1;

	public CustomMessageBox(string title, string message)
	{
		InitializeComponent();
		((Control)richTextBox1).set_Text(message);
	}

	private void CustomMessageBox_Load(object sender, EventArgs e)
	{
		((TextBoxBase)richTextBox1).SelectAll();
		richTextBox1.set_SelectionAlignment((HorizontalAlignment)2);
		((TextBoxBase)richTextBox1).DeselectAll();
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		new ComponentResourceManager(typeof(CustomMessageBox));
		siticoneButton1 = new SiticoneButton();
		richTextBox1 = new RichTextBox();
		((Control)this).SuspendLayout();
		((Control)siticoneButton1).set_Font(new Font("Poppins", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)siticoneButton1).set_ForeColor(Color.Black);
		((Control)siticoneButton1).set_Location(new Point(0, 169));
		((Control)siticoneButton1).set_Name("siticoneButton1");
		((Control)siticoneButton1).set_Size(new Size(392, 38));
		((Control)siticoneButton1).set_TabIndex(1);
		((Control)siticoneButton1).set_Text("OK");
		((Control)siticoneButton1).add_Click((EventHandler)siticoneButton1_Click);
		((Control)richTextBox1).set_BackColor(Color.FromArgb(10, 10, 10));
		((TextBoxBase)richTextBox1).set_BorderStyle((BorderStyle)0);
		((Control)richTextBox1).set_Font(new Font("Poppins", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_ForeColor(Color.FromArgb(40, 40, 40));
		((Control)richTextBox1).set_Location(new Point(40, 19));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(312, 134));
		((Control)richTextBox1).set_TabIndex(2);
		((Control)richTextBox1).set_Text("");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(10, 10, 10));
		((Form)this).set_ClientSize(new Size(391, 207));
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)siticoneButton1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("CustomMessageBox");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Yully Spoofer | Notfication");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)CustomMessageBox_Load);
		((Control)this).ResumeLayout(false);
	}

	public static DialogResult Show(string title, string description)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return ((Form)new CustomMessageBox(title, description)).ShowDialog();
	}

	private void siticoneButton1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
