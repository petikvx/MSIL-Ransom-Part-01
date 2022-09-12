using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class MainWindow : Form
{
	private const int int_0 = 80;

	public static string current_decrypt_file = Class10.smethod_0(22);

	private string string_0 = Class10.smethod_0(22);

	private readonly LinkLabel linkLabel_0;

	private readonly LinkLabel linkLabel_1;

	private Class14 class14_0;

	private int int_1;

	private readonly Class3 class3_0;

	private readonly Class18 class18_0;

	private IContainer icontainer_0;

	private Button button_0;

	private RichTextBox richTextBox_0;

	private Label label_0;

	private PictureBox pictureBox_0;

	private Label label_1;

	private Label label_2;

	private Timer timer_0;

	private TextBox textBox_0;

	private Button button_1;

	private ProgressBar progressBar_0;

	private Label label_3;

	private Timer timer_1;

	private Button button_2;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams obj = Delegate234.smethod_0(this);
			Delegate154.smethod_0(obj, Delegate95.smethod_0(obj) | Class9.smethod_0(188));
			return obj;
		}
	}

	public MainWindow()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		method_13();
		Delegate188.smethod_0(this, (byte)Class9.smethod_0(624) != 0);
		class18_0 = new Class18();
		class3_0 = new Class3();
		class18_0.method_0();
		linkLabel_0 = new LinkLabel();
		linkLabel_1 = new LinkLabel();
		Delegate174.smethod_0(linkLabel_1, new LinkLabelLinkClickedEventHandler(method_7));
		Delegate174.smethod_0(linkLabel_0, new LinkLabelLinkClickedEventHandler(method_5));
	}

	private void method_0(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		Delegate175.smethod_0(label_3);
		Delegate175.smethod_0(progressBar_0);
		Delegate175.smethod_0(button_1);
		Delegate175.smethod_0(textBox_0);
		Delegate148.smethod_0(richTextBox_0);
		method_10();
		Delegate224.smethod_0(linkLabel_0);
		Delegate224.smethod_0(linkLabel_1);
		Delegate224.smethod_0(label_0);
		Delegate184.smethod_0(richTextBox_0, Class10.smethod_0(784));
		Delegate218.smethod_0(linkLabel_1, Class10.smethod_0(897));
		Delegate115.smethod_0(linkLabel_1, (byte)Class9.smethod_0(192) != 0);
		Delegate88.smethod_0(linkLabel_1, Delegate61.smethod_0(richTextBox_0, Delegate76.smethod_0(richTextBox_0)));
		Delegate28.smethod_0(Delegate194.smethod_1(richTextBox_0), (Control)(object)linkLabel_1);
		Delegate184.smethod_0(richTextBox_0, Delegate50.smethod_0(linkLabel_1));
		Delegate184.smethod_0(richTextBox_0, Delegate110.smethod_0((char)Class9.smethod_0(196), Class9.smethod_0(200)));
		Delegate116.smethod_0(richTextBox_0, Delegate76.smethod_0(richTextBox_0));
		Delegate184.smethod_0(richTextBox_0, Class10.smethod_0(906));
		Delegate218.smethod_0(linkLabel_0, Class10.smethod_0(1106));
		Delegate115.smethod_0(linkLabel_0, (byte)Class9.smethod_0(204) != 0);
		Delegate88.smethod_0(linkLabel_0, Delegate61.smethod_0(richTextBox_0, Delegate76.smethod_0(richTextBox_0)));
		Delegate28.smethod_0(Delegate194.smethod_1(richTextBox_0), (Control)(object)linkLabel_0);
		Delegate184.smethod_0(richTextBox_0, Delegate50.smethod_0(linkLabel_0));
		Delegate184.smethod_0(richTextBox_0, Delegate110.smethod_0((char)Class9.smethod_0(208), Class9.smethod_0(212)));
		Delegate116.smethod_0(richTextBox_0, Delegate76.smethod_0(richTextBox_0));
		Delegate184.smethod_0(richTextBox_0, Class10.smethod_0(1121));
		Delegate184.smethod_0(richTextBox_0, Class10.smethod_0(2717));
	}

	private void method_2(object sender, EventArgs e)
	{
		Delegate148.smethod_0(richTextBox_0);
		Delegate175.smethod_0(linkLabel_0);
		Delegate175.smethod_0(linkLabel_1);
		Delegate175.smethod_0(label_0);
		Delegate224.smethod_0(textBox_0);
		Delegate175.smethod_0(button_0);
		Delegate224.smethod_0(button_1);
		Delegate184.smethod_0(richTextBox_0, Class10.smethod_0(3075));
		Delegate212.smethod_0(richTextBox_0, Delegate239.smethod_0(richTextBox_0, Class9.smethod_0(216)), Delegate108.smethod_0(Delegate75.smethod_0(richTextBox_0)[Class9.smethod_0(220)]));
		Delegate227.smethod_0(richTextBox_0, (byte)Class9.smethod_0(224) != 0);
		Delegate31.smethod_0(richTextBox_0);
	}

	private void method_3(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		class14_0 = new Class14();
		class14_0.method_0();
		if (!Delegate22.smethod_0(Delegate50.smethod_0(textBox_0), class14_0.method_1()))
		{
			Delegate36.smethod_0(Class10.smethod_0(3209), Class10.smethod_0(773), (MessageBoxButtons)Class9.smethod_0(228), (MessageBoxIcon)Class9.smethod_0(232));
		}
		else
		{
			Delegate127.smethod_0(timer_0);
			Delegate175.smethod_0(button_1);
			Delegate218.smethod_0(label_2, "");
			Delegate148.smethod_0(richTextBox_0);
			Delegate175.smethod_0(textBox_0);
			Delegate175.smethod_0(label_1);
			Delegate218.smethod_0(label_0, Class10.smethod_0(3242));
			Delegate224.smethod_0(label_0);
			Delegate224.smethod_0(label_3);
			Delegate224.smethod_0(progressBar_0);
			int_1 = Delegate238.smethod_0(progressBar_0) / Delegate146.smethod_0(class3_0.method_0(Class3.string_0));
			Delegate107.smethod_0(timer_1);
			Delegate119.smethod_0(Delegate143.smethod_0(delegate
			{
				Delegate206.smethod_0(Delegate55.smethod_0(), (byte)Class9.smethod_0(888) != 0);
				Class1.smethod_1();
			}));
		}
		class14_0 = null;
	}

	private void method_4(object sender, FormClosingEventArgs e)
	{
		Delegate46.smethod_0(e, (byte)Class9.smethod_0(236) != 0);
	}

	private void method_5(object sender, EventArgs e)
	{
		Delegate208.smethod_0(Class10.smethod_0(3275));
	}

	private void method_6(object sender, EventArgs e)
	{
		Delegate208.smethod_0(Class10.smethod_0(3392));
	}

	private void method_7(object sender, EventArgs e)
	{
		method_11();
	}

	private void method_8(object sender, EventArgs e)
	{
		method_10();
	}

	private void method_9(object sender, EventArgs e)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		if (!Delegate22.smethod_0(Delegate240.smethod_0(class3_0.method_0(Class3.string_0), Class9.smethod_0(240)), Class10.smethod_0(22)))
		{
			if (!Delegate22.smethod_0(string_0, current_decrypt_file))
			{
				string_0 = current_decrypt_file;
				if (Delegate108.smethod_0(current_decrypt_file) > Class9.smethod_0(244))
				{
					Delegate218.smethod_0(label_3, Class7.smethod_0(current_decrypt_file, Class9.smethod_0(248), Class10.smethod_0(3469)));
				}
				else
				{
					Delegate218.smethod_0(label_3, current_decrypt_file);
				}
				Delegate183.smethod_0(progressBar_0, int_1);
			}
		}
		else
		{
			Delegate127.smethod_0(timer_1);
			Delegate33.smethod_0(progressBar_0, Delegate238.smethod_0(progressBar_0));
			Delegate36.smethod_0(Class10.smethod_0(3472), Class10.smethod_0(3571), (MessageBoxButtons)Class9.smethod_0(252), (MessageBoxIcon)Class9.smethod_0(256));
			Delegate123.smethod_0(this, (byte)Class9.smethod_0(260) != 0);
			Class1.smethod_2();
		}
	}

	private void method_10()
	{
		int num = (int)class18_0.method_1();
		if (num < Class9.smethod_0(264))
		{
			Delegate127.smethod_0(timer_0);
			Delegate218.smethod_0(label_2, Class10.smethod_0(3588));
			Delegate123.smethod_0(this, (byte)Class9.smethod_0(268) != 0);
			Class1.smethod_2();
		}
		else
		{
			Label object_ = label_2;
			TimeSpan timeSpan_ = Delegate196.smethod_0(num);
			Delegate218.smethod_0(object_, Delegate104.smethod_0(ref timeSpan_, Class10.smethod_0(3611)));
		}
	}

	private void method_11()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		Delegate181.smethod_0(Delegate163.smethod_0());
	}

	private void method_12(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Delegate191.smethod_0(icontainer_0);
		}
		Delegate17.smethod_0(this, disposing);
	}

	private void method_13()
	{
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_09cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Expected O, but got Unknown
		icontainer_0 = Delegate233.smethod_0();
		ComponentResourceManager object_ = Delegate185.smethod_0(Delegate81.smethod_0(typeof(MainWindow).TypeHandle));
		button_0 = Delegate219.smethod_0();
		richTextBox_0 = Delegate134.smethod_0();
		label_0 = Delegate133.smethod_0();
		pictureBox_0 = Delegate106.smethod_0();
		label_1 = Delegate133.smethod_0();
		label_2 = Delegate133.smethod_0();
		timer_0 = Delegate182.smethod_0(icontainer_0);
		textBox_0 = Delegate235.smethod_0();
		button_1 = Delegate219.smethod_0();
		progressBar_0 = Delegate21.smethod_0();
		label_3 = Delegate133.smethod_0();
		timer_1 = Delegate182.smethod_0(icontainer_0);
		button_2 = Delegate219.smethod_0();
		Delegate1.smethod_0(pictureBox_0);
		Delegate125.smethod_0(this);
		Delegate88.smethod_0(button_0, new Point(Class9.smethod_0(272), Class9.smethod_0(276)));
		Delegate103.smethod_1(button_0, Class10.smethod_0(3640));
		Delegate214.smethod_0(button_0, new Size(Class9.smethod_0(280), Class9.smethod_0(284)));
		Delegate145.smethod_0(button_0, Class9.smethod_0(288));
		Delegate218.smethod_0(button_0, Class10.smethod_0(3655));
		Delegate177.smethod_0(button_0, (byte)Class9.smethod_0(292) != 0);
		Delegate150.smethod_0(button_0, method_2);
		Delegate88.smethod_0(richTextBox_0, new Point(Class9.smethod_0(296), Class9.smethod_0(300)));
		Delegate103.smethod_1(richTextBox_0, Class10.smethod_0(3670));
		Delegate82.smethod_0(richTextBox_0, (byte)Class9.smethod_0(304) != 0);
		Delegate47.smethod_0(richTextBox_0, (RichTextBoxScrollBars)Class9.smethod_0(308));
		Delegate214.smethod_0(richTextBox_0, new Size(Class9.smethod_0(312), Class9.smethod_0(316)));
		Delegate145.smethod_0(richTextBox_0, Class9.smethod_0(320));
		Delegate218.smethod_0(richTextBox_0, "");
		Delegate115.smethod_0(label_0, (byte)Class9.smethod_0(324) != 0);
		Delegate215.smethod_0(label_0, Delegate171.smethod_0(Class10.smethod_0(3685), Class9.smethod_2(328), (FontStyle)Class9.smethod_0(332), (GraphicsUnit)Class9.smethod_0(336), (byte)Class9.smethod_0(340)));
		Delegate88.smethod_0(label_0, new Point(Class9.smethod_0(344), Class9.smethod_0(348)));
		Delegate103.smethod_1(label_0, Class10.smethod_0(3726));
		Delegate214.smethod_0(label_0, new Size(Class9.smethod_0(352), Class9.smethod_0(356)));
		Delegate145.smethod_0(label_0, Class9.smethod_0(360));
		Delegate218.smethod_0(label_0, Class10.smethod_0(3741));
		Delegate223.smethod_0(pictureBox_0, (Image)Delegate86.smethod_0(object_, Class10.smethod_0(3822)));
		Delegate88.smethod_0(pictureBox_0, new Point(Class9.smethod_0(364), Class9.smethod_0(368)));
		Delegate103.smethod_1(pictureBox_0, Class10.smethod_0(3851));
		Delegate214.smethod_0(pictureBox_0, new Size(Class9.smethod_0(372), Class9.smethod_0(376)));
		Delegate228.smethod_0(pictureBox_0, Class9.smethod_0(380));
		Delegate112.smethod_0(pictureBox_0, (byte)Class9.smethod_0(384) != 0);
		Delegate115.smethod_0(label_1, (byte)Class9.smethod_0(388) != 0);
		Delegate215.smethod_0(label_1, Delegate171.smethod_0(Class10.smethod_0(3685), Class9.smethod_2(392), (FontStyle)Class9.smethod_0(396), (GraphicsUnit)Class9.smethod_0(400), (byte)Class9.smethod_0(404)));
		Delegate88.smethod_0(label_1, new Point(Class9.smethod_0(408), Class9.smethod_0(412)));
		Delegate103.smethod_1(label_1, Class10.smethod_0(3868));
		Delegate214.smethod_0(label_1, new Size(Class9.smethod_0(416), Class9.smethod_0(420)));
		Delegate145.smethod_0(label_1, Class9.smethod_0(424));
		Delegate218.smethod_0(label_1, Class10.smethod_0(3891));
		Delegate115.smethod_0(label_2, (byte)Class9.smethod_0(428) != 0);
		Delegate215.smethod_0(label_2, Delegate171.smethod_0(Class10.smethod_0(3685), Class9.smethod_2(432), (FontStyle)Class9.smethod_0(436), (GraphicsUnit)Class9.smethod_0(440), (byte)Class9.smethod_0(444)));
		Delegate88.smethod_0(label_2, new Point(Class9.smethod_0(448), Class9.smethod_0(452)));
		Delegate103.smethod_1(label_2, Class10.smethod_0(3912));
		Delegate214.smethod_0(label_2, new Size(Class9.smethod_0(456), Class9.smethod_0(460)));
		Delegate145.smethod_0(label_2, Class9.smethod_0(464));
		Delegate218.smethod_0(label_2, Class10.smethod_0(3588));
		Delegate153.smethod_0(timer_0, (byte)Class9.smethod_0(468) != 0);
		Delegate241.smethod_0(timer_0, Class9.smethod_0(472));
		Delegate126.smethod_0(timer_0, method_8);
		Delegate88.smethod_0(textBox_0, new Point(Class9.smethod_0(476), Class9.smethod_0(480)));
		Delegate103.smethod_1(textBox_0, Class10.smethod_0(3933));
		Delegate214.smethod_0(textBox_0, new Size(Class9.smethod_0(484), Class9.smethod_0(488)));
		Delegate145.smethod_0(textBox_0, Class9.smethod_0(492));
		Delegate88.smethod_0(button_1, new Point(Class9.smethod_0(496), Class9.smethod_0(500)));
		Delegate103.smethod_1(button_1, Class10.smethod_0(3956));
		Delegate214.smethod_0(button_1, new Size(Class9.smethod_0(504), Class9.smethod_0(508)));
		Delegate145.smethod_0(button_1, Class9.smethod_0(512));
		Delegate218.smethod_0(button_1, Class10.smethod_0(3975));
		Delegate177.smethod_0(button_1, (byte)Class9.smethod_0(516) != 0);
		Delegate150.smethod_0(button_1, method_3);
		Delegate88.smethod_0(progressBar_0, new Point(Class9.smethod_0(520), Class9.smethod_0(524)));
		Delegate103.smethod_1(progressBar_0, Class10.smethod_0(3988));
		Delegate214.smethod_0(progressBar_0, new Size(Class9.smethod_0(528), Class9.smethod_0(532)));
		Delegate145.smethod_0(progressBar_0, Class9.smethod_0(536));
		Delegate115.smethod_0(label_3, (byte)Class9.smethod_0(540) != 0);
		Delegate88.smethod_0(label_3, new Point(Class9.smethod_0(544), Class9.smethod_0(548)));
		Delegate103.smethod_1(label_3, Class10.smethod_0(4023));
		Delegate214.smethod_0(label_3, new Size(Class9.smethod_0(552), Class9.smethod_0(556)));
		Delegate145.smethod_0(label_3, Class9.smethod_0(560));
		Delegate241.smethod_0(timer_1, Class9.smethod_0(564));
		Delegate126.smethod_0(timer_1, method_9);
		Delegate88.smethod_0(button_2, new Point(Class9.smethod_0(568), Class9.smethod_0(572)));
		Delegate103.smethod_1(button_2, Class10.smethod_0(4064));
		Delegate214.smethod_0(button_2, new Size(Class9.smethod_0(576), Class9.smethod_0(580)));
		Delegate145.smethod_0(button_2, Class9.smethod_0(584));
		Delegate218.smethod_0(button_2, Class10.smethod_0(4079));
		Delegate177.smethod_0(button_2, (byte)Class9.smethod_0(588) != 0);
		Delegate150.smethod_0(button_2, method_12);
		Delegate27.smethod_0(this, new SizeF(Class9.smethod_2(592), Class9.smethod_2(596)));
		Delegate109.smethod_0(this, (AutoScaleMode)Class9.smethod_0(600));
		Delegate164.smethod_0(this, new Size(Class9.smethod_0(604), Class9.smethod_0(608)));
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)button_2);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)label_3);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)progressBar_0);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)button_1);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)textBox_0);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)label_2);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)label_1);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)pictureBox_0);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)label_0);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)richTextBox_0);
		Delegate28.smethod_0(Delegate194.smethod_0(this), (Control)(object)button_0);
		Delegate100.smethod_0(this, (FormBorderStyle)Class9.smethod_0(612));
		Delegate65.smethod_0(this, (Icon)Delegate86.smethod_0(object_, Class10.smethod_0(4088)));
		Delegate103.smethod_0(this, Class10.smethod_0(4109));
		Delegate200.smethod_0(this, (byte)Class9.smethod_0(616) != 0);
		Delegate218.smethod_0(this, Class10.smethod_0(4130));
		Delegate64.smethod_0(this, method_0);
		Delegate132.smethod_0(pictureBox_0);
		Delegate102.smethod_0(this, (byte)Class9.smethod_0(620) != 0);
		Delegate62.smethod_0(this);
	}
}
