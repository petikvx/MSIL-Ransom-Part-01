using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJack;

public class Form2 : Form
{
	private Random rnd = new Random();

	private int count = 0;

	private int playerScore = 0;

	private int PCScore = 0;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label7;

	private Label label8;

	private Label label9;

	private Label label10;

	private Button button1;

	private Label label11;

	private Label label12;

	private Label label13;

	private Label label14;

	private Button button2;

	private Label label5;

	private Label label6;

	private Label label15;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Button button3;

	private Label label16;

	private Label label17;

	private Label label18;

	private Label label19;

	private Label label20;

	private Label label21;

	private Button button4;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private PictureBox pictureBox5;

	private PictureBox pictureBox6;

	private PictureBox pictureBox7;

	private PictureBox pictureBox8;

	private PictureBox pictureBox9;

	private PictureBox pictureBox10;

	public Form2()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		count++;
		if (count == 1)
		{
			int num = rnd.Next(1, 11);
			int num2 = rnd.Next(1, 11);
			int num3 = num + num2;
			((Control)label1).set_Text(num.ToString());
			((Control)label2).set_Text(num2.ToString());
			((Control)label12).set_Text(num3.ToString());
		}
		if (count == 2)
		{
			int num4 = rnd.Next(1, 11);
			((Control)label3).set_Text(num4.ToString());
			int num5 = Convert.ToInt32(((Control)label1).get_Text()) + Convert.ToInt32(((Control)label2).get_Text()) + num4;
			((Control)label12).set_Text(num5.ToString());
		}
		else if (count == 3)
		{
			int num6 = rnd.Next(1, 11);
			((Control)label4).set_Text(num6.ToString());
			int num7 = Convert.ToInt32(((Control)label1).get_Text()) + Convert.ToInt32(((Control)label2).get_Text()) + Convert.ToInt32(((Control)label3).get_Text()) + num6;
			((Control)label12).set_Text(num7.ToString());
		}
		if (((Control)label1).get_Text() == "1")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label1).get_Text() == "2")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label1).get_Text() == "3")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label1).get_Text() == "4")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label1).get_Text() == "5")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label1).get_Text() == "6")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label1).get_Text() == "7")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label1).get_Text() == "8")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label1).get_Text() == "9")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label1).get_Text() == "10")
		{
			pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-10.gif");
		}
		if (((Control)label2).get_Text() == "1")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label2).get_Text() == "2")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label2).get_Text() == "3")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label2).get_Text() == "4")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label2).get_Text() == "5")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label2).get_Text() == "6")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label2).get_Text() == "7")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label2).get_Text() == "8")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label2).get_Text() == "9")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label2).get_Text() == "10")
		{
			pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-vale.gif");
		}
		if (((Control)label3).get_Text() == "1")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label3).get_Text() == "2")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label3).get_Text() == "3")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label3).get_Text() == "4")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label3).get_Text() == "5")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label3).get_Text() == "6")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label3).get_Text() == "7")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label3).get_Text() == "8")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label3).get_Text() == "9")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label3).get_Text() == "10")
		{
			pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-kiz.gif");
		}
		if (((Control)label4).get_Text() == "1")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label4).get_Text() == "2")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label4).get_Text() == "3")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label4).get_Text() == "4")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label4).get_Text() == "5")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label4).get_Text() == "6")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label4).get_Text() == "7")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label4).get_Text() == "8")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label4).get_Text() == "9")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label4).get_Text() == "10")
		{
			pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-papaz.gif");
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		int num = rnd.Next(1, 11);
		int num2 = rnd.Next(1, 11);
		int num3 = num + num2;
		((Control)label10).set_Text(num.ToString());
		((Control)label9).set_Text(num2.ToString());
		((Control)label13).set_Text(num3.ToString());
		if (num3 < 16)
		{
			int num4 = rnd.Next(1, 11);
			((Control)label8).set_Text(num4.ToString());
			num3 += num4;
			((Control)label13).set_Text(num3.ToString());
		}
		if (num3 < 16)
		{
			int num5 = rnd.Next(1, 11);
			((Control)label7).set_Text(num5.ToString());
			num3 += num5;
			((Control)label13).set_Text(num3.ToString());
		}
		if (((Control)label10).get_Text() == "1")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label10).get_Text() == "2")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label10).get_Text() == "3")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label10).get_Text() == "4")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label10).get_Text() == "5")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label10).get_Text() == "6")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label10).get_Text() == "7")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label10).get_Text() == "8")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label10).get_Text() == "9")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label10).get_Text() == "10")
		{
			pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-papaz.gif");
		}
		if (((Control)label9).get_Text() == "1")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label9).get_Text() == "2")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label9).get_Text() == "3")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label9).get_Text() == "4")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label9).get_Text() == "5")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label9).get_Text() == "6")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label9).get_Text() == "7")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label9).get_Text() == "8")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label9).get_Text() == "9")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label9).get_Text() == "10")
		{
			pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-10.gif");
		}
		if (((Control)label8).get_Text() == "1")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label8).get_Text() == "2")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label8).get_Text() == "3")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label8).get_Text() == "4")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label8).get_Text() == "5")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label8).get_Text() == "6")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label8).get_Text() == "7")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label8).get_Text() == "8")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label8).get_Text() == "9")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label8).get_Text() == "10")
		{
			pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-kiz.gif");
		}
		if (((Control)label7).get_Text() == "1")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-1.gif");
		}
		if (((Control)label7).get_Text() == "2")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-2.gif");
		}
		if (((Control)label7).get_Text() == "3")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-3.gif");
		}
		if (((Control)label7).get_Text() == "4")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-4.gif");
		}
		if (((Control)label7).get_Text() == "5")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-5.gif");
		}
		if (((Control)label7).get_Text() == "6")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-6.gif");
		}
		if (((Control)label7).get_Text() == "7")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-7.gif");
		}
		if (((Control)label7).get_Text() == "8")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-8.gif");
		}
		if (((Control)label7).get_Text() == "9")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-9.gif");
		}
		if (((Control)label7).get_Text() == "10")
		{
			pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sinek-vale.gif");
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		((Control)button4).set_Enabled(true);
		((Control)button3).set_Enabled(false);
		int num = Convert.ToInt32(((Control)label12).get_Text());
		int num2 = Convert.ToInt32(((Control)label13).get_Text());
		if (num > num2 && num <= 21)
		{
			playerScore += 10;
			((Control)label20).set_Text(playerScore.ToString());
		}
		if (PCScore > playerScore && PCScore <= 21)
		{
			PCScore += 10;
			((Control)label21).set_Text(PCScore.ToString());
		}
		if (PCScore == playerScore && PCScore <= 21 && playerScore <= 21)
		{
			PCScore += 10;
			playerScore += 10;
			((Control)label20).set_Text(playerScore.ToString());
			((Control)label21).set_Text(PCScore.ToString());
		}
		if (playerScore == 50)
		{
			MessageBox.Show("You are Winner!!!");
		}
		if (PCScore == 50)
		{
			MessageBox.Show("You are Lost,Sorry!!!");
		}
		if (PCScore <= 21 && playerScore > 21)
		{
			PCScore += 10;
			((Control)label21).set_Text(PCScore.ToString());
		}
		if (playerScore <= 21 && PCScore > 21)
		{
			playerScore += 10;
			((Control)label20).set_Text(playerScore.ToString());
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		count = 0;
		((Control)label1).set_Text("0");
		((Control)label2).set_Text("0");
		((Control)label3).set_Text("0");
		((Control)label4).set_Text("0");
		((Control)label7).set_Text("0");
		((Control)label8).set_Text("0");
		((Control)label9).set_Text("0");
		((Control)label10).set_Text("0");
		((Control)label12).set_Text("0");
		((Control)label13).set_Text("0");
		((Control)button3).set_Enabled(true);
		((Control)button4).set_Enabled(false);
		pictureBox3.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
		pictureBox4.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
		pictureBox5.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
		pictureBox6.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
		pictureBox10.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
		pictureBox9.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
		pictureBox8.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
		pictureBox7.set_ImageLocation("C:\\Users\\Yonca\\Desktop\\card\\sirt.gif");
	}

	private void Form2_Load(object sender, EventArgs e)
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected O, but got Unknown
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Expected O, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected O, but got Unknown
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected O, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8c: Expected O, but got Unknown
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected O, but got Unknown
		//IL_0d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected O, but got Unknown
		//IL_0e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e40: Expected O, but got Unknown
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Expected O, but got Unknown
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected O, but got Unknown
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_1021: Expected O, but got Unknown
		//IL_10bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c6: Expected O, but got Unknown
		//IL_1161: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Expected O, but got Unknown
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1204: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label7 = new Label();
		label8 = new Label();
		label9 = new Label();
		label10 = new Label();
		button1 = new Button();
		label11 = new Label();
		label12 = new Label();
		label13 = new Label();
		label14 = new Label();
		button2 = new Button();
		label5 = new Label();
		label6 = new Label();
		label15 = new Label();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		button3 = new Button();
		label16 = new Label();
		label17 = new Label();
		label18 = new Label();
		label19 = new Label();
		label20 = new Label();
		label21 = new Label();
		button4 = new Button();
		pictureBox3 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox5 = new PictureBox();
		pictureBox6 = new PictureBox();
		pictureBox7 = new PictureBox();
		pictureBox8 = new PictureBox();
		pictureBox9 = new PictureBox();
		pictureBox10 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox7).BeginInit();
		((ISupportInitialize)pictureBox8).BeginInit();
		((ISupportInitialize)pictureBox9).BeginInit();
		((ISupportInitialize)pictureBox10).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label1).set_Location(new Point(82, 324));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 17));
		((Control)label1).set_TabIndex(0);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label2).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label2).set_Location(new Point(164, 324));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(0, 17));
		((Control)label2).set_TabIndex(1);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label3).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label3).set_Location(new Point(242, 324));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(0, 17));
		((Control)label3).set_TabIndex(2);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label4).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label4).set_Location(new Point(317, 324));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(0, 17));
		((Control)label4).set_TabIndex(3);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_BackColor(Color.Transparent);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label7).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label7).set_Location(new Point(819, 324));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(57, 17));
		((Control)label7).set_TabIndex(8);
		((Control)label7).set_Text("label 1");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label8).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label8).set_Location(new Point(744, 324));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(57, 17));
		((Control)label8).set_TabIndex(7);
		((Control)label8).set_Text("label 1");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_BackColor(Color.Transparent);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label9).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label9).set_Location(new Point(666, 324));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(57, 17));
		((Control)label9).set_TabIndex(6);
		((Control)label9).set_Text("label 1");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_BackColor(Color.Transparent);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label10).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label10).set_Location(new Point(584, 324));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(57, 17));
		((Control)label10).set_TabIndex(5);
		((Control)label10).set_Text("label 1");
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)button1).set_Location(new Point(148, 425));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(125, 26));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("Get Card");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_BackColor(Color.Transparent);
		((Control)label11).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label11).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label11).set_Location(new Point(178, 374));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(55, 17));
		((Control)label11).set_TabIndex(11);
		((Control)label11).set_Text("Total :");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_BackColor(Color.Transparent);
		((Control)label12).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label12).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label12).set_Location(new Point(244, 374));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(17, 17));
		((Control)label12).set_TabIndex(12);
		((Control)label12).set_Text("0");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_BackColor(Color.Transparent);
		((Control)label13).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label13).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label13).set_Location(new Point(792, 374));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(17, 17));
		((Control)label13).set_TabIndex(14);
		((Control)label13).set_Text("0");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_BackColor(Color.Transparent);
		((Control)label14).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label14).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label14).set_Location(new Point(726, 374));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(60, 17));
		((Control)label14).set_TabIndex(13);
		((Control)label14).set_Text("Total  :");
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)button2).set_Location(new Point(697, 425));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(125, 26));
		((Control)button2).set_TabIndex(15);
		((Control)button2).set_Text("PC Get Card");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label5).set_BackColor(Color.White);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label5).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label5).set_Location(new Point(488, 0));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(23, 500));
		((Control)label5).set_TabIndex(16);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_BackColor(Color.Transparent);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label6).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label6).set_Location(new Point(182, 126));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(68, 17));
		((Control)label6).set_TabIndex(17);
		((Control)label6).set_Text("Player 1");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_BackColor(Color.Transparent);
		((Control)label15).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label15).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label15).set_Location(new Point(730, 126));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(68, 17));
		((Control)label15).set_TabIndex(18);
		((Control)label15).set_Text("Player 2");
		((Control)pictureBox1).set_Location(new Point(171, 23));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(102, 88));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(19);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_Location(new Point(693, 23));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(129, 88));
		pictureBox2.set_TabIndex(20);
		pictureBox2.set_TabStop(false);
		((Control)button3).set_BackColor(Color.Crimson);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)button3).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)button3).set_Location(new Point(443, 151));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(105, 43));
		((Control)button3).set_TabIndex(21);
		((Control)button3).set_Text("Final");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)label16).set_BackColor(Color.White);
		((Control)label16).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label16).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label16).set_Location(new Point(929, 0));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(23, 500));
		((Control)label16).set_TabIndex(22);
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_BackColor(Color.Transparent);
		((Control)label17).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label17).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label17).set_Location(new Point(993, 34));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(58, 17));
		((Control)label17).set_TabIndex(23);
		((Control)label17).set_Text("Scores");
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_BackColor(Color.Transparent);
		((Control)label18).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label18).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label18).set_Location(new Point(958, 77));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(68, 17));
		((Control)label18).set_TabIndex(24);
		((Control)label18).set_Text("Player 1");
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_BackColor(Color.Transparent);
		((Control)label19).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label19).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label19).set_Location(new Point(1029, 77));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(68, 17));
		((Control)label19).set_TabIndex(25);
		((Control)label19).set_Text("Player 2");
		((Control)label20).set_AutoSize(true);
		((Control)label20).set_BackColor(Color.Transparent);
		((Control)label20).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label20).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label20).set_Location(new Point(982, 126));
		((Control)label20).set_Name("label20");
		((Control)label20).set_Size(new Size(17, 17));
		((Control)label20).set_TabIndex(26);
		((Control)label20).set_Text("0");
		((Control)label21).set_AutoSize(true);
		((Control)label21).set_BackColor(Color.Transparent);
		((Control)label21).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)label21).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label21).set_Location(new Point(1046, 126));
		((Control)label21).set_Name("label21");
		((Control)label21).set_Size(new Size(17, 17));
		((Control)label21).set_TabIndex(27);
		((Control)label21).set_Text("0");
		((Control)button4).set_BackColor(Color.Crimson);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)button4).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)button4).set_Location(new Point(443, 230));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(105, 43));
		((Control)button4).set_TabIndex(28);
		((Control)button4).set_Text("ReStart");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)pictureBox3).set_Location(new Point(81, 201));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(58, 89));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox3.set_TabIndex(29);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox4).set_Location(new Point(163, 201));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(58, 89));
		pictureBox4.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox4.set_TabIndex(30);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox5).set_Location(new Point(241, 201));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(58, 89));
		pictureBox5.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox5.set_TabIndex(31);
		pictureBox5.set_TabStop(false);
		((Control)pictureBox6).set_Location(new Point(320, 201));
		((Control)pictureBox6).set_Name("pictureBox6");
		((Control)pictureBox6).set_Size(new Size(58, 89));
		pictureBox6.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox6.set_TabIndex(32);
		pictureBox6.set_TabStop(false);
		((Control)pictureBox7).set_Location(new Point(826, 201));
		((Control)pictureBox7).set_Name("pictureBox7");
		((Control)pictureBox7).set_Size(new Size(58, 89));
		pictureBox7.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox7.set_TabIndex(36);
		pictureBox7.set_TabStop(false);
		((Control)pictureBox8).set_Location(new Point(747, 201));
		((Control)pictureBox8).set_Name("pictureBox8");
		((Control)pictureBox8).set_Size(new Size(58, 89));
		pictureBox8.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox8.set_TabIndex(35);
		pictureBox8.set_TabStop(false);
		((Control)pictureBox9).set_Location(new Point(669, 201));
		((Control)pictureBox9).set_Name("pictureBox9");
		((Control)pictureBox9).set_Size(new Size(58, 89));
		pictureBox9.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox9.set_TabIndex(34);
		pictureBox9.set_TabStop(false);
		((Control)pictureBox10).set_Location(new Point(587, 201));
		((Control)pictureBox10).set_Name("pictureBox10");
		((Control)pictureBox10).set_Size(new Size(58, 89));
		pictureBox10.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox10.set_TabIndex(33);
		pictureBox10.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1099, 498));
		((Control)this).get_Controls().Add((Control)(object)pictureBox7);
		((Control)this).get_Controls().Add((Control)(object)pictureBox8);
		((Control)this).get_Controls().Add((Control)(object)pictureBox9);
		((Control)this).get_Controls().Add((Control)(object)pictureBox10);
		((Control)this).get_Controls().Add((Control)(object)pictureBox6);
		((Control)this).get_Controls().Add((Control)(object)pictureBox5);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)label21);
		((Control)this).get_Controls().Add((Control)(object)label20);
		((Control)this).get_Controls().Add((Control)(object)label19);
		((Control)this).get_Controls().Add((Control)(object)label18);
		((Control)this).get_Controls().Add((Control)(object)label17);
		((Control)this).get_Controls().Add((Control)(object)label16);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label15);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label13);
		((Control)this).get_Controls().Add((Control)(object)label14);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Black Jack");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox7).EndInit();
		((ISupportInitialize)pictureBox8).EndInit();
		((ISupportInitialize)pictureBox9).EndInit();
		((ISupportInitialize)pictureBox10).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
