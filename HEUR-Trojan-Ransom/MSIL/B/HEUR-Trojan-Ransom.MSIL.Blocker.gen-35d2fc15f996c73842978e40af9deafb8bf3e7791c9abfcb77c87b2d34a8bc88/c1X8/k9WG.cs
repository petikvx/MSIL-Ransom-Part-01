using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hr4g;
using Microsoft.VisualBasic.CompilerServices;
using f4L;

namespace c1X8;

[DesignerGenerated]
public class k9WG : Form
{
	private IContainer components;

	private Label _lblChange;

	private Label _lblTotalCost;

	private Label _lblSeats;

	private Label _lblID;

	private Label _Label5;

	private Label _Label3;

	private Label _Label1;

	private Label _Label6;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox19;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox6;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox2;

	public int MytotalCost;

	public int MytotalPayment;

	public int MyChange;

	public int MySeats;

	public string MycustomerID;

	public string MyfirstName;

	internal GroupBox k;

	internal Label P;

	internal Label Q;

	internal Label g;

	internal Label r;

	internal Label d;

	internal Label A;

	internal Label f;

	internal PictureBox y;

	internal PictureBox t;

	internal PictureBox C;

	internal PictureBox B;

	internal PictureBox o;

	internal PictureBox L;

	internal PictureBox h;

	internal PictureBox U;

	internal PictureBox s;

	internal PictureBox N;

	public k9WG()
	{
		((Form)this).add_Load((EventHandler)k5M);
		Dc4n();
	}

	protected override void Rf02(bool Cy56)
	{
		try
		{
			if (Cy56 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cy56);
		}
	}

	private void Dc4n()
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
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected O, but got Unknown
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0b: Expected O, but got Unknown
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected O, but got Unknown
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected O, but got Unknown
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected O, but got Unknown
		//IL_0e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Expected O, but got Unknown
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected O, but got Unknown
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f23: Expected O, but got Unknown
		//IL_0f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f95: Expected O, but got Unknown
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected O, but got Unknown
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1076: Expected O, but got Unknown
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e1: Expected O, but got Unknown
		//IL_1145: Unknown result type (might be due to invalid IL or missing references)
		//IL_114f: Expected O, but got Unknown
		//IL_11b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bd: Expected O, but got Unknown
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_122b: Expected O, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected O, but got Unknown
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1307: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(k9WG));
		Jx8z(new GroupBox());
		g0K1(new Label());
		z6Y1(new Label());
		y3E8(new Label());
		f6Z7(new Label());
		b9A5(new Label());
		Ff3z(new Label());
		Bp07(new Label());
		a3T1(new Label());
		f1X(new Label());
		a4Y(new Label());
		Fw6(new Label());
		i9D(new Label());
		Sm1(new Label());
		m1Z(new Label());
		Bc4(new Label());
		Hk4(new PictureBox());
		q5Z(new PictureBox());
		Jp4(new PictureBox());
		e9K(new PictureBox());
		Se4(new PictureBox());
		Kr2(new PictureBox());
		q4Z(new PictureBox());
		Gj8(new PictureBox());
		r3Y(new PictureBox());
		p8G(new PictureBox());
		x3Z(new PictureBox());
		Fp4(new PictureBox());
		Xs6(new PictureBox());
		Sp8(new PictureBox());
		j8D(new PictureBox());
		Bw8(new PictureBox());
		a5L(new PictureBox());
		a9M(new PictureBox());
		Rq2(new PictureBox());
		k4S(new PictureBox());
		((Control)Ha2e()).SuspendLayout();
		((ISupportInitialize)Yz9()).BeginInit();
		((ISupportInitialize)f4G()).BeginInit();
		((ISupportInitialize)m9Y()).BeginInit();
		((ISupportInitialize)Be8()).BeginInit();
		((ISupportInitialize)b1E()).BeginInit();
		((ISupportInitialize)t0S()).BeginInit();
		((ISupportInitialize)g7G()).BeginInit();
		((ISupportInitialize)Zc1()).BeginInit();
		((ISupportInitialize)Tg1()).BeginInit();
		((ISupportInitialize)Po9()).BeginInit();
		((ISupportInitialize)k4H()).BeginInit();
		((ISupportInitialize)b2X()).BeginInit();
		((ISupportInitialize)k9Q()).BeginInit();
		((ISupportInitialize)Wx7()).BeginInit();
		((ISupportInitialize)k2J()).BeginInit();
		((ISupportInitialize)g9M()).BeginInit();
		((ISupportInitialize)Kn8()).BeginInit();
		((ISupportInitialize)q7X()).BeginInit();
		((ISupportInitialize)w7F()).BeginInit();
		((ISupportInitialize)Qy1()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Ha2e()).set_BackColor(Color.Transparent);
		((Control)Ha2e()).get_Controls().Add((Control)(object)Tn70());
		((Control)Ha2e()).get_Controls().Add((Control)(object)Ji9q());
		((Control)Ha2e()).get_Controls().Add((Control)(object)Lq8x());
		((Control)Ha2e()).get_Controls().Add((Control)(object)Hd82());
		((Control)Ha2e()).get_Controls().Add((Control)(object)De86());
		((Control)Ha2e()).get_Controls().Add((Control)(object)Cm63());
		((Control)Ha2e()).get_Controls().Add((Control)(object)Am5i());
		((Control)Ha2e()).get_Controls().Add((Control)(object)i8FZ());
		((Control)Ha2e()).get_Controls().Add((Control)(object)Zk0());
		((Control)Ha2e()).get_Controls().Add((Control)(object)z7N());
		((Control)Ha2e()).get_Controls().Add((Control)(object)n3X());
		((Control)Ha2e()).get_Controls().Add((Control)(object)m5E());
		((Control)Ha2e()).get_Controls().Add((Control)(object)p6M());
		((Control)Ha2e()).get_Controls().Add((Control)(object)w4Y());
		((Control)Ha2e()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ha2e()).set_Location(new Point(56, 185));
		((Control)Ha2e()).set_Name("GroupBox1");
		((Control)Ha2e()).set_Size(new Size(296, 192));
		((Control)Ha2e()).set_TabIndex(45);
		Ha2e().set_TabStop(false);
		Tn70().set_AutoSize(true);
		((Control)Tn70()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Tn70()).set_Location(new Point(150, 164));
		((Control)Tn70()).set_Name("lblChange");
		((Control)Tn70()).set_Size(new Size(50, 13));
		((Control)Tn70()).set_TabIndex(13);
		Tn70().set_Text("Change");
		Ji9q().set_AutoSize(true);
		((Control)Ji9q()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ji9q()).set_Location(new Point(150, 140));
		((Control)Ji9q()).set_Name("lblTotalPayment");
		((Control)Ji9q()).set_Size(new Size(88, 13));
		((Control)Ji9q()).set_TabIndex(12);
		Ji9q().set_Text("Total Payment");
		Lq8x().set_AutoSize(true);
		((Control)Lq8x()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Lq8x()).set_Location(new Point(150, 116));
		((Control)Lq8x()).set_Name("lblTotalCost");
		((Control)Lq8x()).set_Size(new Size(65, 13));
		((Control)Lq8x()).set_TabIndex(11);
		Lq8x().set_Text("Total Cost");
		Hd82().set_AutoSize(true);
		((Control)Hd82()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Hd82()).set_Location(new Point(150, 92));
		((Control)Hd82()).set_Name("lblSeats");
		((Control)Hd82()).set_Size(new Size(97, 13));
		((Control)Hd82()).set_TabIndex(10);
		Hd82().set_Text("Seats Reserved");
		De86().set_AutoSize(true);
		((Control)De86()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)De86()).set_Location(new Point(150, 68));
		((Control)De86()).set_Name("lblName");
		((Control)De86()).set_Size(new Size(39, 13));
		((Control)De86()).set_TabIndex(9);
		De86().set_Text("Name");
		Cm63().set_AutoSize(true);
		((Control)Cm63()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Cm63()).set_Location(new Point(150, 44));
		((Control)Cm63()).set_Name("lblID");
		((Control)Cm63()).set_Size(new Size(72, 13));
		((Control)Cm63()).set_TabIndex(8);
		Cm63().set_Text("CustomerID");
		Am5i().set_AutoSize(true);
		((Control)Am5i()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Am5i()).set_Location(new Point(150, 20));
		((Control)Am5i()).set_Name("Label15");
		((Control)Am5i()).set_Size(new Size(164, 13));
		((Control)Am5i()).set_TabIndex(7);
		Am5i().set_Text("AVENGERS INFINITY WAR");
		i8FZ().set_AutoSize(true);
		((Control)i8FZ()).set_Location(new Point(36, 164));
		((Control)i8FZ()).set_Name("Label8");
		((Control)i8FZ()).set_Size(new Size(44, 13));
		((Control)i8FZ()).set_TabIndex(6);
		i8FZ().set_Text("Change");
		Zk0().set_AutoSize(true);
		((Control)Zk0()).set_Location(new Point(36, 140));
		((Control)Zk0()).set_Name("Label7");
		((Control)Zk0()).set_Size(new Size(75, 13));
		((Control)Zk0()).set_TabIndex(5);
		Zk0().set_Text("Total Payment");
		z7N().set_AutoSize(true);
		((Control)z7N()).set_Location(new Point(36, 116));
		((Control)z7N()).set_Name("Label5");
		((Control)z7N()).set_Size(new Size(55, 13));
		((Control)z7N()).set_TabIndex(4);
		z7N().set_Text("Total Cost");
		n3X().set_AutoSize(true);
		((Control)n3X()).set_Location(new Point(36, 92));
		((Control)n3X()).set_Name("Label4");
		((Control)n3X()).set_Size(new Size(83, 13));
		((Control)n3X()).set_TabIndex(3);
		n3X().set_Text("Seats Reserved");
		m5E().set_AutoSize(true);
		((Control)m5E()).set_Location(new Point(36, 68));
		((Control)m5E()).set_Name("Label3");
		((Control)m5E()).set_Size(new Size(35, 13));
		((Control)m5E()).set_TabIndex(2);
		m5E().set_Text("Name");
		p6M().set_AutoSize(true);
		((Control)p6M()).set_Location(new Point(36, 44));
		((Control)p6M()).set_Name("Label2");
		((Control)p6M()).set_Size(new Size(62, 13));
		((Control)p6M()).set_TabIndex(1);
		p6M().set_Text("CustomerID");
		w4Y().set_AutoSize(true);
		((Control)w4Y()).set_Location(new Point(36, 20));
		((Control)w4Y()).set_Name("Label1");
		((Control)w4Y()).set_Size(new Size(36, 13));
		((Control)w4Y()).set_TabIndex(0);
		w4Y().set_Text("Movie");
		q6N().set_AutoSize(true);
		((Control)q6N()).set_BackColor(Color.Transparent);
		((Control)q6N()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)q6N()).set_ForeColor(Color.White);
		((Control)q6N()).set_Location(new Point(142, 417));
		((Control)q6N()).set_Name("Label6");
		((Control)q6N()).set_Size(new Size(72, 25));
		((Control)q6N()).set_TabIndex(44);
		q6N().set_Text("PASS");
		Yz9().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)Yz9()).set_Location(new Point(106, 451));
		((Control)Yz9()).set_Name("PictureBox15");
		((Control)Yz9()).set_Size(new Size(19, 20));
		Yz9().set_TabIndex(43);
		Yz9().set_TabStop(false);
		f4G().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)f4G()).set_Location(new Point(143, 451));
		((Control)f4G()).set_Name("PictureBox16");
		((Control)f4G()).set_Size(new Size(19, 20));
		f4G().set_TabIndex(42);
		f4G().set_TabStop(false);
		m9Y().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)m9Y()).set_Location(new Point(217, 451));
		((Control)m9Y()).set_Name("PictureBox17");
		((Control)m9Y()).set_Size(new Size(19, 20));
		m9Y().set_TabIndex(41);
		m9Y().set_TabStop(false);
		Be8().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)Be8()).set_Location(new Point(180, 451));
		((Control)Be8()).set_Name("PictureBox18");
		((Control)Be8()).set_Size(new Size(19, 20));
		Be8().set_TabIndex(40);
		Be8().set_TabStop(false);
		b1E().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)b1E()).set_Location(new Point(254, 451));
		((Control)b1E()).set_Name("PictureBox19");
		((Control)b1E()).set_Size(new Size(19, 20));
		b1E().set_TabIndex(39);
		b1E().set_TabStop(false);
		t0S().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)t0S()).set_Location(new Point(69, 451));
		((Control)t0S()).set_Name("PictureBox20");
		((Control)t0S()).set_Size(new Size(19, 20));
		t0S().set_TabIndex(38);
		t0S().set_TabStop(false);
		g7G().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)g7G()).set_Location(new Point(105, 387));
		((Control)g7G()).set_Name("PictureBox14");
		((Control)g7G()).set_Size(new Size(19, 20));
		g7G().set_TabIndex(37);
		g7G().set_TabStop(false);
		Zc1().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)Zc1()).set_Location(new Point(142, 387));
		((Control)Zc1()).set_Name("PictureBox13");
		((Control)Zc1()).set_Size(new Size(19, 20));
		Zc1().set_TabIndex(36);
		Zc1().set_TabStop(false);
		Tg1().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)Tg1()).set_Location(new Point(216, 387));
		((Control)Tg1()).set_Name("PictureBox12");
		((Control)Tg1()).set_Size(new Size(19, 20));
		Tg1().set_TabIndex(35);
		Tg1().set_TabStop(false);
		Po9().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)Po9()).set_Location(new Point(179, 387));
		((Control)Po9()).set_Name("PictureBox11");
		((Control)Po9()).set_Size(new Size(19, 20));
		Po9().set_TabIndex(34);
		Po9().set_TabStop(false);
		k4H().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)k4H()).set_Location(new Point(253, 387));
		((Control)k4H()).set_Name("PictureBox10");
		((Control)k4H()).set_Size(new Size(19, 20));
		k4H().set_TabIndex(33);
		k4H().set_TabStop(false);
		b2X().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)b2X()).set_Location(new Point(68, 387));
		((Control)b2X()).set_Name("PictureBox9");
		((Control)b2X()).set_Size(new Size(19, 20));
		b2X().set_TabIndex(32);
		b2X().set_TabStop(false);
		k9Q().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)k9Q()).set_Location(new Point(101, 7));
		((Control)k9Q()).set_Name("PictureBox8");
		((Control)k9Q()).set_Size(new Size(31, 29));
		k9Q().set_TabIndex(31);
		k9Q().set_TabStop(false);
		Wx7().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)Wx7()).set_Location(new Point(155, 7));
		((Control)Wx7()).set_Name("PictureBox7");
		((Control)Wx7()).set_Size(new Size(31, 29));
		Wx7().set_TabIndex(30);
		Wx7().set_TabStop(false);
		k2J().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)k2J()).set_Location(new Point(209, 7));
		((Control)k2J()).set_Name("PictureBox6");
		((Control)k2J()).set_Size(new Size(31, 29));
		k2J().set_TabIndex(29);
		k2J().set_TabStop(false);
		g9M().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)g9M()).set_Location(new Point(263, 7));
		((Control)g9M()).set_Name("PictureBox5");
		((Control)g9M()).set_Size(new Size(31, 29));
		g9M().set_TabIndex(28);
		g9M().set_TabStop(false);
		Kn8().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)Kn8()).set_Location(new Point(47, 7));
		((Control)Kn8()).set_Name("PictureBox4");
		((Control)Kn8()).set_Size(new Size(31, 29));
		Kn8().set_TabIndex(27);
		Kn8().set_TabStop(false);
		q7X().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)q7X()).set_Location(new Point(0, 448));
		((Control)q7X()).set_Name("PictureBox3");
		((Control)q7X()).set_Size(new Size(364, 29));
		q7X().set_TabIndex(26);
		q7X().set_TabStop(false);
		w7F().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)w7F()).set_Location(new Point(0, 383));
		((Control)w7F()).set_Name("PictureBox2");
		((Control)w7F()).set_Size(new Size(364, 29));
		w7F().set_TabIndex(25);
		w7F().set_TabStop(false);
		((Control)Qy1()).set_Dock((DockStyle)1);
		((Control)Qy1()).set_Location(new Point(0, 0));
		((Control)Qy1()).set_Name("PictureBox1");
		((Control)Qy1()).set_Size(new Size(364, 40));
		Qy1().set_SizeMode((PictureBoxSizeMode)1);
		Qy1().set_TabIndex(24);
		Qy1().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 493));
		((Control)this).get_Controls().Add((Control)(object)Ha2e());
		((Control)this).get_Controls().Add((Control)(object)q6N());
		((Control)this).get_Controls().Add((Control)(object)Yz9());
		((Control)this).get_Controls().Add((Control)(object)f4G());
		((Control)this).get_Controls().Add((Control)(object)m9Y());
		((Control)this).get_Controls().Add((Control)(object)Be8());
		((Control)this).get_Controls().Add((Control)(object)b1E());
		((Control)this).get_Controls().Add((Control)(object)t0S());
		((Control)this).get_Controls().Add((Control)(object)g7G());
		((Control)this).get_Controls().Add((Control)(object)Zc1());
		((Control)this).get_Controls().Add((Control)(object)Tg1());
		((Control)this).get_Controls().Add((Control)(object)Po9());
		((Control)this).get_Controls().Add((Control)(object)k4H());
		((Control)this).get_Controls().Add((Control)(object)b2X());
		((Control)this).get_Controls().Add((Control)(object)k9Q());
		((Control)this).get_Controls().Add((Control)(object)Wx7());
		((Control)this).get_Controls().Add((Control)(object)k2J());
		((Control)this).get_Controls().Add((Control)(object)g9M());
		((Control)this).get_Controls().Add((Control)(object)Kn8());
		((Control)this).get_Controls().Add((Control)(object)q7X());
		((Control)this).get_Controls().Add((Control)(object)w7F());
		((Control)this).get_Controls().Add((Control)(object)Qy1());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((Control)Ha2e()).ResumeLayout(false);
		((Control)Ha2e()).PerformLayout();
		((ISupportInitialize)Yz9()).EndInit();
		((ISupportInitialize)f4G()).EndInit();
		((ISupportInitialize)m9Y()).EndInit();
		((ISupportInitialize)Be8()).EndInit();
		((ISupportInitialize)b1E()).EndInit();
		((ISupportInitialize)t0S()).EndInit();
		((ISupportInitialize)g7G()).EndInit();
		((ISupportInitialize)Zc1()).EndInit();
		((ISupportInitialize)Tg1()).EndInit();
		((ISupportInitialize)Po9()).EndInit();
		((ISupportInitialize)k4H()).EndInit();
		((ISupportInitialize)b2X()).EndInit();
		((ISupportInitialize)k9Q()).EndInit();
		((ISupportInitialize)Wx7()).EndInit();
		((ISupportInitialize)k2J()).EndInit();
		((ISupportInitialize)g9M()).EndInit();
		((ISupportInitialize)Kn8()).EndInit();
		((ISupportInitialize)q7X()).EndInit();
		((ISupportInitialize)w7F()).EndInit();
		((ISupportInitialize)Qy1()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox Ha2e()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jx8z(GroupBox c0BQ)
	{
		GroupBox val = (k = c0BQ);
	}

	[SpecialName]
	internal virtual Label Tn70()
	{
		return _lblChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0K1(Label r4TE)
	{
		_lblChange = r4TE;
	}

	[SpecialName]
	internal virtual Label Ji9q()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6Y1(Label j9HM)
	{
		Label val = (P = j9HM);
	}

	[SpecialName]
	internal virtual Label Lq8x()
	{
		return _lblTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3E8(Label Eo6j)
	{
		_lblTotalCost = Eo6j;
	}

	[SpecialName]
	internal virtual Label Hd82()
	{
		return _lblSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6Z7(Label Dd9c)
	{
		_lblSeats = Dd9c;
	}

	[SpecialName]
	internal virtual Label De86()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9A5(Label s0GX)
	{
		Label val = (Q = s0GX);
	}

	[SpecialName]
	internal virtual Label Cm63()
	{
		return _lblID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ff3z(Label Jb86)
	{
		_lblID = Jb86;
	}

	[SpecialName]
	internal virtual Label Am5i()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bp07(Label Sn03)
	{
		Label val = (g = Sn03);
	}

	[SpecialName]
	internal virtual Label i8FZ()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3T1(Label a8J)
	{
		Label val = (r = a8J);
	}

	[SpecialName]
	internal virtual Label Zk0()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1X(Label Xj6)
	{
		Label val = (d = Xj6);
	}

	[SpecialName]
	internal virtual Label z7N()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4Y(Label Kp9)
	{
		_Label5 = Kp9;
	}

	[SpecialName]
	internal virtual Label n3X()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fw6(Label k1W)
	{
		Label val = (A = k1W);
	}

	[SpecialName]
	internal virtual Label m5E()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9D(Label Ej4)
	{
		_Label3 = Ej4;
	}

	[SpecialName]
	internal virtual Label p6M()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sm1(Label b9S)
	{
		Label val = (f = b9S);
	}

	[SpecialName]
	internal virtual Label w4Y()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1Z(Label Nk2)
	{
		_Label1 = Nk2;
	}

	[SpecialName]
	internal virtual Label q6N()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bc4(Label t5C)
	{
		_Label6 = t5C;
	}

	[SpecialName]
	internal virtual PictureBox Yz9()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hk4(PictureBox Br9)
	{
		_PictureBox15 = Br9;
	}

	[SpecialName]
	internal virtual PictureBox f4G()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5Z(PictureBox Ss2)
	{
		PictureBox val = (y = Ss2);
	}

	[SpecialName]
	internal virtual PictureBox m9Y()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp4(PictureBox Qr6)
	{
		PictureBox val = (t = Qr6);
	}

	[SpecialName]
	internal virtual PictureBox Be8()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9K(PictureBox b0W)
	{
		PictureBox val = (C = b0W);
	}

	[SpecialName]
	internal virtual PictureBox b1E()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Se4(PictureBox s6M)
	{
		_PictureBox19 = s6M;
	}

	[SpecialName]
	internal virtual PictureBox t0S()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kr2(PictureBox La1)
	{
		_PictureBox20 = La1;
	}

	[SpecialName]
	internal virtual PictureBox g7G()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4Z(PictureBox Pg8)
	{
		_PictureBox14 = Pg8;
	}

	[SpecialName]
	internal virtual PictureBox Zc1()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gj8(PictureBox k5J)
	{
		PictureBox val = (B = k5J);
	}

	[SpecialName]
	internal virtual PictureBox Tg1()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3Y(PictureBox x3Z)
	{
		_PictureBox12 = x3Z;
	}

	[SpecialName]
	internal virtual PictureBox Po9()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8G(PictureBox x8S)
	{
		PictureBox val = (o = x8S);
	}

	[SpecialName]
	internal virtual PictureBox k4H()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3Z(PictureBox Sz6)
	{
		PictureBox val = (L = Sz6);
	}

	[SpecialName]
	internal virtual PictureBox b2X()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fp4(PictureBox Me2)
	{
		PictureBox val = (h = Me2);
	}

	[SpecialName]
	internal virtual PictureBox k9Q()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xs6(PictureBox d7E)
	{
		PictureBox val = (U = d7E);
	}

	[SpecialName]
	internal virtual PictureBox Wx7()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp8(PictureBox Xo4)
	{
		PictureBox val = (s = Xo4);
	}

	[SpecialName]
	internal virtual PictureBox k2J()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8D(PictureBox b7R)
	{
		_PictureBox6 = b7R;
	}

	[SpecialName]
	internal virtual PictureBox g9M()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bw8(PictureBox Ld3)
	{
		_PictureBox5 = Ld3;
	}

	[SpecialName]
	internal virtual PictureBox Kn8()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5L(PictureBox j8E)
	{
		_PictureBox4 = j8E;
	}

	[SpecialName]
	internal virtual PictureBox q7X()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9M(PictureBox k7H)
	{
		_PictureBox3 = k7H;
	}

	[SpecialName]
	internal virtual PictureBox w7F()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rq2(PictureBox Nj5)
	{
		_PictureBox2 = Nj5;
	}

	[SpecialName]
	internal virtual PictureBox Qy1()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4S(PictureBox s7C)
	{
		PictureBox val = (N = s7C);
	}

	private void k5M(object sender, EventArgs e)
	{
		MytotalCost = Fo9c.Forms.Te4m().totalCost;
		MytotalPayment = Fo9c.Forms.Te4m().totalPayment;
		MyChange = Fo9c.Forms.Te4m().change;
		MycustomerID = Fo9c.Forms.Te4m().customerID;
		MyfirstName = Fo9c.Forms.Te4m().firstName;
		MySeats = Fo9c.Forms.Te4m().seats;
		Cm63().set_Text(MycustomerID);
		De86().set_Text(MyfirstName);
		Hd82().set_Text(Conversions.ToString(MySeats));
		Lq8x().set_Text("$" + Conversions.ToString(MytotalCost));
		Ji9q().set_Text("$" + Conversions.ToString(MytotalPayment));
		Tn70().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static string[] n5E()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(r6C.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				foreach (string item in array2)
				{
					list.Add(item);
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num2 = array3.Length - 1;
				for (num = 0; num <= num2; num++)
				{
					array3[num] = list[num];
				}
				return array3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
