using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Virus.A;

public class Form2 : Form
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private Label label9;

	private Label label10;

	private Label label11;

	private Label label12;

	private Label label13;

	private Button button1;

	public Form2()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
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
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		label9 = new Label();
		label10 = new Label();
		label11 = new Label();
		label12 = new Label();
		label13 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(1, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(201, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Что случилось с моим компьютером?");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(Color.Green);
		((Control)label2).set_Location(new Point(1, 31));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(396, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("- Все данные на нем были уничтожены (картинки, фото, сохранения в играх)");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(1, 54));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(172, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Могу ли я восстановить файлы?");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_ForeColor(Color.Green);
		((Control)label4).set_Location(new Point(4, 71));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(800, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("- Конечно можете! Мы гарантируем то, что вы сможете восстановить легко и быстро ваши файлы. Для этого вам нужна оплата в BTC - 2000р (0,0001 BTC)");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(4, 88));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(0, 13));
		((Control)label5).set_TabIndex(4);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(11, 88));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(169, 13));
		((Control)label6).set_TabIndex(5);
		((Control)label6).set_Text("Ограниченно ли время оплаты?");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_ForeColor(Color.Green);
		((Control)label7).set_Location(new Point(4, 105));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(603, 13));
		((Control)label7).set_TabIndex(6);
		((Control)label7).set_Text("Да, к сожалению ограничено, вам нельзя перезапускать ваш компьютер, иначе у вас сломается диск C:/ (SYSTEM)");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(4, 122));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(127, 13));
		((Control)label8).set_TabIndex(7);
		((Control)label8).set_Text("Куда мне оплачиивать?");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_ForeColor(Color.Green);
		((Control)label9).set_Location(new Point(7, 139));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(194, 13));
		((Control)label9).set_TabIndex(8);
		((Control)label9).set_Text("На BTC Адрес, для этого вам нужно:");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_ForeColor(Color.Green);
		((Control)label10).set_Location(new Point(4, 156));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(365, 13));
		((Control)label10).set_TabIndex(9);
		((Control)label10).set_Text("1.Шаг: Скачать TorBrowser (www.torproject.org), зайди на сайт Bitcoin.og");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_ForeColor(Color.Green);
		((Control)label11).set_Location(new Point(4, 173));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(360, 13));
		((Control)label11).set_TabIndex(10);
		((Control)label11).set_Text("3 шаг.Создайте кошелек, затем пополните его на 2000р (0.0001 BTC)");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_ForeColor(Color.Green);
		((Control)label12).set_Location(new Point(4, 190));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(346, 13));
		((Control)label12).set_TabIndex(11);
		((Control)label12).set_Text("4 шаг.Выберите Адрес:36bUzEo3hksCZfQ4GTCogZnWc5ZTTtv3MD");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_ForeColor(Color.Green);
		((Control)label13).set_Location(new Point(4, 207));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(440, 13));
		((Control)label13).set_TabIndex(12);
		((Control)label13).set_Text("5 Шаг.Сделайте комментарий на почту: jojoshluxa@gmail.com:GTXS-50DS-ZDcV-Z1D1 ");
		((Control)button1).set_Location(new Point(718, 335));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(13);
		((Control)button1).set_Text("return");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label13);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Trojan.Ransom.Artemon.A");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
