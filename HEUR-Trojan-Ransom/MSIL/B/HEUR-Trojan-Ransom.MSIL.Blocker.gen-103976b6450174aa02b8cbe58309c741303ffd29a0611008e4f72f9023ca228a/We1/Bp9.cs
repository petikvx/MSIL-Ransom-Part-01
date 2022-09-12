using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dz5;
using Microsoft.VisualBasic.CompilerServices;
using i9M;

namespace We1;

[DesignerGenerated]
public class Bp9 : Form
{
	private IContainer components;

	private Label _lblTotalPayment;

	private Label _lblTotalCost;

	private Label _lblSeats;

	private Label _lblName;

	private Label _Label15;

	private Label _Label5;

	private Label _Label2;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox2;

	public int MytotalCost;

	public int MytotalPayment;

	public int MyChange;

	public int MySeats;

	public string MycustomerID;

	public string MyfirstName;

	internal GroupBox n;

	internal Label Q;

	internal Label v;

	internal Label b;

	internal Label a;

	internal Label p;

	internal Label E;

	internal Label C;

	internal Label O;

	internal PictureBox u;

	internal PictureBox X;

	internal PictureBox k;

	internal PictureBox j;

	internal PictureBox F;

	internal PictureBox h;

	internal PictureBox L;

	internal PictureBox t;

	internal PictureBox i;

	internal PictureBox R;

	internal PictureBox s;

	public Bp9()
	{
		((Form)this).add_Load((EventHandler)Qf9);
		t1B();
	}

	protected override void i5S(bool a0Z)
	{
		try
		{
			if (a0Z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a0Z);
		}
	}

	private void t1B()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bp9));
		i9E(new GroupBox());
		Xp2(new Label());
		p9G(new Label());
		Gp6(new Label());
		Bj3(new Label());
		r8W(new Label());
		Dj5(new Label());
		g5E(new Label());
		Qf1(new Label());
		Xw9(new Label());
		Jw5(new Label());
		w4J(new Label());
		Tk0(new Label());
		Xr0(new Label());
		s3N(new Label());
		Pc3(new Label());
		Ba2(new PictureBox());
		a2D(new PictureBox());
		q8M(new PictureBox());
		Bz5(new PictureBox());
		z8Y(new PictureBox());
		Tt3(new PictureBox());
		Jb6(new PictureBox());
		m8L(new PictureBox());
		y9J(new PictureBox());
		z6E(new PictureBox());
		z3L(new PictureBox());
		g0H(new PictureBox());
		e9G(new PictureBox());
		Tn5(new PictureBox());
		o1X(new PictureBox());
		My3(new PictureBox());
		e4P(new PictureBox());
		Ce7(new PictureBox());
		k6N(new PictureBox());
		Qb9(new PictureBox());
		((Control)Rz9()).SuspendLayout();
		((ISupportInitialize)Qq7()).BeginInit();
		((ISupportInitialize)Br2()).BeginInit();
		((ISupportInitialize)Yf7()).BeginInit();
		((ISupportInitialize)this.Kd5()).BeginInit();
		((ISupportInitialize)Cb0()).BeginInit();
		((ISupportInitialize)Pz6()).BeginInit();
		((ISupportInitialize)Bm7()).BeginInit();
		((ISupportInitialize)g8S()).BeginInit();
		((ISupportInitialize)this.Kd5()).BeginInit();
		((ISupportInitialize)i1W()).BeginInit();
		((ISupportInitialize)b9T()).BeginInit();
		((ISupportInitialize)Jz0()).BeginInit();
		((ISupportInitialize)d9Q()).BeginInit();
		((ISupportInitialize)q6R()).BeginInit();
		((ISupportInitialize)Pe8()).BeginInit();
		((ISupportInitialize)q7N()).BeginInit();
		((ISupportInitialize)Fs2()).BeginInit();
		((ISupportInitialize)o1R()).BeginInit();
		((ISupportInitialize)t9N()).BeginInit();
		((ISupportInitialize)Ca1()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Rz9()).set_BackColor(Color.Transparent);
		((Control)Rz9()).get_Controls().Add((Control)(object)i8M());
		((Control)Rz9()).get_Controls().Add((Control)(object)Xq1());
		((Control)Rz9()).get_Controls().Add((Control)(object)s7K());
		((Control)Rz9()).get_Controls().Add((Control)(object)Tn7());
		((Control)Rz9()).get_Controls().Add((Control)(object)r4Y());
		((Control)Rz9()).get_Controls().Add((Control)(object)o5Q());
		((Control)Rz9()).get_Controls().Add((Control)(object)Xk4());
		((Control)Rz9()).get_Controls().Add((Control)(object)s1X());
		((Control)Rz9()).get_Controls().Add((Control)(object)Nk7());
		((Control)Rz9()).get_Controls().Add((Control)(object)m1J());
		((Control)Rz9()).get_Controls().Add((Control)(object)n5X());
		((Control)Rz9()).get_Controls().Add((Control)(object)Ny4());
		((Control)Rz9()).get_Controls().Add((Control)(object)Tt4());
		((Control)Rz9()).get_Controls().Add((Control)(object)w6F());
		((Control)Rz9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Rz9()).set_Location(new Point(56, 185));
		((Control)Rz9()).set_Name("GroupBox1");
		((Control)Rz9()).set_Size(new Size(296, 192));
		((Control)Rz9()).set_TabIndex(45);
		Rz9().set_TabStop(false);
		i8M().set_AutoSize(true);
		((Control)i8M()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)i8M()).set_Location(new Point(150, 164));
		((Control)i8M()).set_Name("lblChange");
		((Control)i8M()).set_Size(new Size(50, 13));
		((Control)i8M()).set_TabIndex(13);
		i8M().set_Text("Change");
		Xq1().set_AutoSize(true);
		((Control)Xq1()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Xq1()).set_Location(new Point(150, 140));
		((Control)Xq1()).set_Name("lblTotalPayment");
		((Control)Xq1()).set_Size(new Size(88, 13));
		((Control)Xq1()).set_TabIndex(12);
		Xq1().set_Text("Total Payment");
		s7K().set_AutoSize(true);
		((Control)s7K()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)s7K()).set_Location(new Point(150, 116));
		((Control)s7K()).set_Name("lblTotalCost");
		((Control)s7K()).set_Size(new Size(65, 13));
		((Control)s7K()).set_TabIndex(11);
		s7K().set_Text("Total Cost");
		Tn7().set_AutoSize(true);
		((Control)Tn7()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Tn7()).set_Location(new Point(150, 92));
		((Control)Tn7()).set_Name("lblSeats");
		((Control)Tn7()).set_Size(new Size(97, 13));
		((Control)Tn7()).set_TabIndex(10);
		Tn7().set_Text("Seats Reserved");
		r4Y().set_AutoSize(true);
		((Control)r4Y()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)r4Y()).set_Location(new Point(150, 68));
		((Control)r4Y()).set_Name("lblName");
		((Control)r4Y()).set_Size(new Size(39, 13));
		((Control)r4Y()).set_TabIndex(9);
		r4Y().set_Text("Name");
		o5Q().set_AutoSize(true);
		((Control)o5Q()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)o5Q()).set_Location(new Point(150, 44));
		((Control)o5Q()).set_Name("lblID");
		((Control)o5Q()).set_Size(new Size(72, 13));
		((Control)o5Q()).set_TabIndex(8);
		o5Q().set_Text("CustomerID");
		Xk4().set_AutoSize(true);
		((Control)Xk4()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Xk4()).set_Location(new Point(150, 20));
		((Control)Xk4()).set_Name("Label15");
		((Control)Xk4()).set_Size(new Size(164, 13));
		((Control)Xk4()).set_TabIndex(7);
		Xk4().set_Text("AVENGERS INFINITY WAR");
		s1X().set_AutoSize(true);
		((Control)s1X()).set_Location(new Point(36, 164));
		((Control)s1X()).set_Name("Label8");
		((Control)s1X()).set_Size(new Size(44, 13));
		((Control)s1X()).set_TabIndex(6);
		s1X().set_Text("Change");
		Nk7().set_AutoSize(true);
		((Control)Nk7()).set_Location(new Point(36, 140));
		((Control)Nk7()).set_Name("Label7");
		((Control)Nk7()).set_Size(new Size(75, 13));
		((Control)Nk7()).set_TabIndex(5);
		Nk7().set_Text("Total Payment");
		m1J().set_AutoSize(true);
		((Control)m1J()).set_Location(new Point(36, 116));
		((Control)m1J()).set_Name("Label5");
		((Control)m1J()).set_Size(new Size(55, 13));
		((Control)m1J()).set_TabIndex(4);
		m1J().set_Text("Total Cost");
		n5X().set_AutoSize(true);
		((Control)n5X()).set_Location(new Point(36, 92));
		((Control)n5X()).set_Name("Label4");
		((Control)n5X()).set_Size(new Size(83, 13));
		((Control)n5X()).set_TabIndex(3);
		n5X().set_Text("Seats Reserved");
		Ny4().set_AutoSize(true);
		((Control)Ny4()).set_Location(new Point(36, 68));
		((Control)Ny4()).set_Name("Label3");
		((Control)Ny4()).set_Size(new Size(35, 13));
		((Control)Ny4()).set_TabIndex(2);
		Ny4().set_Text("Name");
		Tt4().set_AutoSize(true);
		((Control)Tt4()).set_Location(new Point(36, 44));
		((Control)Tt4()).set_Name("Label2");
		((Control)Tt4()).set_Size(new Size(62, 13));
		((Control)Tt4()).set_TabIndex(1);
		Tt4().set_Text("CustomerID");
		w6F().set_AutoSize(true);
		((Control)w6F()).set_Location(new Point(36, 20));
		((Control)w6F()).set_Name("Label1");
		((Control)w6F()).set_Size(new Size(36, 13));
		((Control)w6F()).set_TabIndex(0);
		w6F().set_Text("Movie");
		Qy2().set_AutoSize(true);
		((Control)Qy2()).set_BackColor(Color.Transparent);
		((Control)Qy2()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Qy2()).set_ForeColor(Color.White);
		((Control)Qy2()).set_Location(new Point(142, 417));
		((Control)Qy2()).set_Name("Label6");
		((Control)Qy2()).set_Size(new Size(72, 25));
		((Control)Qy2()).set_TabIndex(44);
		Qy2().set_Text("PASS");
		Qq7().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)Qq7()).set_Location(new Point(106, 451));
		((Control)Qq7()).set_Name("PictureBox15");
		((Control)Qq7()).set_Size(new Size(19, 20));
		Qq7().set_TabIndex(43);
		Qq7().set_TabStop(false);
		Br2().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)Br2()).set_Location(new Point(143, 451));
		((Control)Br2()).set_Name("PictureBox16");
		((Control)Br2()).set_Size(new Size(19, 20));
		Br2().set_TabIndex(42);
		Br2().set_TabStop(false);
		Yf7().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)Yf7()).set_Location(new Point(217, 451));
		((Control)Yf7()).set_Name("PictureBox17");
		((Control)Yf7()).set_Size(new Size(19, 20));
		Yf7().set_TabIndex(41);
		Yf7().set_TabStop(false);
		this.Kd5().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)this.Kd5()).set_Location(new Point(180, 451));
		((Control)this.Kd5()).set_Name("PictureBox18");
		((Control)this.Kd5()).set_Size(new Size(19, 20));
		this.Kd5().set_TabIndex(40);
		this.Kd5().set_TabStop(false);
		Cb0().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)Cb0()).set_Location(new Point(254, 451));
		((Control)Cb0()).set_Name("PictureBox19");
		((Control)Cb0()).set_Size(new Size(19, 20));
		Cb0().set_TabIndex(39);
		Cb0().set_TabStop(false);
		Pz6().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)Pz6()).set_Location(new Point(69, 451));
		((Control)Pz6()).set_Name("PictureBox20");
		((Control)Pz6()).set_Size(new Size(19, 20));
		Pz6().set_TabIndex(38);
		Pz6().set_TabStop(false);
		Bm7().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)Bm7()).set_Location(new Point(105, 387));
		((Control)Bm7()).set_Name("PictureBox14");
		((Control)Bm7()).set_Size(new Size(19, 20));
		Bm7().set_TabIndex(37);
		Bm7().set_TabStop(false);
		g8S().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)g8S()).set_Location(new Point(142, 387));
		((Control)g8S()).set_Name("PictureBox13");
		((Control)g8S()).set_Size(new Size(19, 20));
		g8S().set_TabIndex(36);
		g8S().set_TabStop(false);
		this.Kd5().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)this.Kd5()).set_Location(new Point(216, 387));
		((Control)this.Kd5()).set_Name("PictureBox12");
		((Control)this.Kd5()).set_Size(new Size(19, 20));
		this.Kd5().set_TabIndex(35);
		this.Kd5().set_TabStop(false);
		i1W().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)i1W()).set_Location(new Point(179, 387));
		((Control)i1W()).set_Name("PictureBox11");
		((Control)i1W()).set_Size(new Size(19, 20));
		i1W().set_TabIndex(34);
		i1W().set_TabStop(false);
		b9T().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)b9T()).set_Location(new Point(253, 387));
		((Control)b9T()).set_Name("PictureBox10");
		((Control)b9T()).set_Size(new Size(19, 20));
		b9T().set_TabIndex(33);
		b9T().set_TabStop(false);
		Jz0().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)Jz0()).set_Location(new Point(68, 387));
		((Control)Jz0()).set_Name("PictureBox9");
		((Control)Jz0()).set_Size(new Size(19, 20));
		Jz0().set_TabIndex(32);
		Jz0().set_TabStop(false);
		d9Q().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)d9Q()).set_Location(new Point(101, 7));
		((Control)d9Q()).set_Name("PictureBox8");
		((Control)d9Q()).set_Size(new Size(31, 29));
		d9Q().set_TabIndex(31);
		d9Q().set_TabStop(false);
		q6R().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)q6R()).set_Location(new Point(155, 7));
		((Control)q6R()).set_Name("PictureBox7");
		((Control)q6R()).set_Size(new Size(31, 29));
		q6R().set_TabIndex(30);
		q6R().set_TabStop(false);
		Pe8().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)Pe8()).set_Location(new Point(209, 7));
		((Control)Pe8()).set_Name("PictureBox6");
		((Control)Pe8()).set_Size(new Size(31, 29));
		Pe8().set_TabIndex(29);
		Pe8().set_TabStop(false);
		q7N().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)q7N()).set_Location(new Point(263, 7));
		((Control)q7N()).set_Name("PictureBox5");
		((Control)q7N()).set_Size(new Size(31, 29));
		q7N().set_TabIndex(28);
		q7N().set_TabStop(false);
		Fs2().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)Fs2()).set_Location(new Point(47, 7));
		((Control)Fs2()).set_Name("PictureBox4");
		((Control)Fs2()).set_Size(new Size(31, 29));
		Fs2().set_TabIndex(27);
		Fs2().set_TabStop(false);
		o1R().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)o1R()).set_Location(new Point(0, 448));
		((Control)o1R()).set_Name("PictureBox3");
		((Control)o1R()).set_Size(new Size(364, 29));
		o1R().set_TabIndex(26);
		o1R().set_TabStop(false);
		t9N().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)t9N()).set_Location(new Point(0, 383));
		((Control)t9N()).set_Name("PictureBox2");
		((Control)t9N()).set_Size(new Size(364, 29));
		t9N().set_TabIndex(25);
		t9N().set_TabStop(false);
		((Control)Ca1()).set_Dock((DockStyle)1);
		((Control)Ca1()).set_Location(new Point(0, 0));
		((Control)Ca1()).set_Name("PictureBox1");
		((Control)Ca1()).set_Size(new Size(364, 40));
		Ca1().set_SizeMode((PictureBoxSizeMode)1);
		Ca1().set_TabIndex(24);
		Ca1().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 493));
		((Control)this).get_Controls().Add((Control)(object)Rz9());
		((Control)this).get_Controls().Add((Control)(object)Qy2());
		((Control)this).get_Controls().Add((Control)(object)Qq7());
		((Control)this).get_Controls().Add((Control)(object)Br2());
		((Control)this).get_Controls().Add((Control)(object)Yf7());
		((Control)this).get_Controls().Add((Control)(object)this.Kd5());
		((Control)this).get_Controls().Add((Control)(object)Cb0());
		((Control)this).get_Controls().Add((Control)(object)Pz6());
		((Control)this).get_Controls().Add((Control)(object)Bm7());
		((Control)this).get_Controls().Add((Control)(object)g8S());
		((Control)this).get_Controls().Add((Control)(object)this.Kd5());
		((Control)this).get_Controls().Add((Control)(object)i1W());
		((Control)this).get_Controls().Add((Control)(object)b9T());
		((Control)this).get_Controls().Add((Control)(object)Jz0());
		((Control)this).get_Controls().Add((Control)(object)d9Q());
		((Control)this).get_Controls().Add((Control)(object)q6R());
		((Control)this).get_Controls().Add((Control)(object)Pe8());
		((Control)this).get_Controls().Add((Control)(object)q7N());
		((Control)this).get_Controls().Add((Control)(object)Fs2());
		((Control)this).get_Controls().Add((Control)(object)o1R());
		((Control)this).get_Controls().Add((Control)(object)t9N());
		((Control)this).get_Controls().Add((Control)(object)Ca1());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((Control)Rz9()).ResumeLayout(false);
		((Control)Rz9()).PerformLayout();
		((ISupportInitialize)Qq7()).EndInit();
		((ISupportInitialize)Br2()).EndInit();
		((ISupportInitialize)Yf7()).EndInit();
		((ISupportInitialize)this.Kd5()).EndInit();
		((ISupportInitialize)Cb0()).EndInit();
		((ISupportInitialize)Pz6()).EndInit();
		((ISupportInitialize)Bm7()).EndInit();
		((ISupportInitialize)g8S()).EndInit();
		((ISupportInitialize)this.Kd5()).EndInit();
		((ISupportInitialize)i1W()).EndInit();
		((ISupportInitialize)b9T()).EndInit();
		((ISupportInitialize)Jz0()).EndInit();
		((ISupportInitialize)d9Q()).EndInit();
		((ISupportInitialize)q6R()).EndInit();
		((ISupportInitialize)Pe8()).EndInit();
		((ISupportInitialize)q7N()).EndInit();
		((ISupportInitialize)Fs2()).EndInit();
		((ISupportInitialize)o1R()).EndInit();
		((ISupportInitialize)t9N()).EndInit();
		((ISupportInitialize)Ca1()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox Rz9()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9E(GroupBox Xj8)
	{
		GroupBox val = (n = Xj8);
	}

	[SpecialName]
	internal virtual Label i8M()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xp2(Label d9L)
	{
		Label val = (Q = d9L);
	}

	[SpecialName]
	internal virtual Label Xq1()
	{
		return _lblTotalPayment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9G(Label o5W)
	{
		_lblTotalPayment = o5W;
	}

	[SpecialName]
	internal virtual Label s7K()
	{
		return _lblTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gp6(Label r7Z)
	{
		_lblTotalCost = r7Z;
	}

	[SpecialName]
	internal virtual Label Tn7()
	{
		return _lblSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bj3(Label Hz7)
	{
		_lblSeats = Hz7;
	}

	[SpecialName]
	internal virtual Label r4Y()
	{
		return _lblName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8W(Label c5J)
	{
		_lblName = c5J;
	}

	[SpecialName]
	internal virtual Label o5Q()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dj5(Label g0M)
	{
		Label val = (v = g0M);
	}

	[SpecialName]
	internal virtual Label Xk4()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5E(Label Dj0)
	{
		_Label15 = Dj0;
	}

	[SpecialName]
	internal virtual Label s1X()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qf1(Label y1S)
	{
		Label val = (b = y1S);
	}

	[SpecialName]
	internal virtual Label Nk7()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw9(Label Eq2)
	{
		Label val = (a = Eq2);
	}

	[SpecialName]
	internal virtual Label m1J()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jw5(Label a9S)
	{
		_Label5 = a9S;
	}

	[SpecialName]
	internal virtual Label n5X()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4J(Label n9C)
	{
		Label val = (p = n9C);
	}

	[SpecialName]
	internal virtual Label Ny4()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tk0(Label m9X)
	{
		Label val = (E = m9X);
	}

	[SpecialName]
	internal virtual Label Tt4()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xr0(Label f1L)
	{
		_Label2 = f1L;
	}

	[SpecialName]
	internal virtual Label w6F()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3N(Label Zi7)
	{
		Label val = (C = Zi7);
	}

	[SpecialName]
	internal virtual Label Qy2()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pc3(Label g5T)
	{
		Label val = (O = g5T);
	}

	[SpecialName]
	internal virtual PictureBox Qq7()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ba2(PictureBox Zw9)
	{
		_PictureBox15 = Zw9;
	}

	[SpecialName]
	internal virtual PictureBox Br2()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2D(PictureBox i1B)
	{
		PictureBox val = (u = i1B);
	}

	[SpecialName]
	internal virtual PictureBox Yf7()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q8M(PictureBox f2M)
	{
		_PictureBox17 = f2M;
	}

	[SpecialName]
	internal virtual PictureBox Kd5()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bz5(PictureBox Hi4)
	{
		PictureBox val = (X = Hi4);
	}

	[SpecialName]
	internal virtual PictureBox Cb0()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8Y(PictureBox w4F)
	{
		PictureBox val = (k = w4F);
	}

	[SpecialName]
	internal virtual PictureBox Pz6()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt3(PictureBox k8M)
	{
		_PictureBox20 = k8M;
	}

	[SpecialName]
	internal virtual PictureBox Bm7()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jb6(PictureBox r9E)
	{
		PictureBox val = (j = r9E);
	}

	[SpecialName]
	internal virtual PictureBox g8S()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8L(PictureBox y6W)
	{
		PictureBox val = (F = y6W);
	}

	[SpecialName]
	internal virtual PictureBox Kd5()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9J(PictureBox Ny9)
	{
		PictureBox val = (h = Ny9);
	}

	[SpecialName]
	internal virtual PictureBox i1W()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6E(PictureBox y8R)
	{
		PictureBox val = (L = y8R);
	}

	[SpecialName]
	internal virtual PictureBox b9T()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3L(PictureBox Xg1)
	{
		PictureBox val = (t = Xg1);
	}

	[SpecialName]
	internal virtual PictureBox Jz0()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0H(PictureBox Bd5)
	{
		_PictureBox9 = Bd5;
	}

	[SpecialName]
	internal virtual PictureBox d9Q()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9G(PictureBox c2N)
	{
		_PictureBox8 = c2N;
	}

	[SpecialName]
	internal virtual PictureBox q6R()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn5(PictureBox Mx1)
	{
		_PictureBox7 = Mx1;
	}

	[SpecialName]
	internal virtual PictureBox Pe8()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1X(PictureBox f6G)
	{
		PictureBox val = (i = f6G);
	}

	[SpecialName]
	internal virtual PictureBox q7N()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void My3(PictureBox Lm7)
	{
		_PictureBox5 = Lm7;
	}

	[SpecialName]
	internal virtual PictureBox Fs2()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4P(PictureBox Zy2)
	{
		_PictureBox4 = Zy2;
	}

	[SpecialName]
	internal virtual PictureBox o1R()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ce7(PictureBox y6X)
	{
		PictureBox val = (R = y6X);
	}

	[SpecialName]
	internal virtual PictureBox t9N()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6N(PictureBox Rw5)
	{
		_PictureBox2 = Rw5;
	}

	[SpecialName]
	internal virtual PictureBox Ca1()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qb9(PictureBox Mc2)
	{
		PictureBox val = (s = Mc2);
	}

	private void Qf9(object sender, EventArgs e)
	{
		MytotalCost = Mi0.Forms.n1J().totalCost;
		MytotalPayment = Mi0.Forms.n1J().totalPayment;
		MyChange = Mi0.Forms.n1J().change;
		MycustomerID = Mi0.Forms.n1J().customerID;
		MyfirstName = Mi0.Forms.n1J().firstName;
		MySeats = Mi0.Forms.n1J().seats;
		o5Q().set_Text(MycustomerID);
		r4Y().set_Text(MyfirstName);
		Tn7().set_Text(Conversions.ToString(MySeats));
		s7K().set_Text("$" + Conversions.ToString(MytotalCost));
		Xq1().set_Text("$" + Conversions.ToString(MytotalPayment));
		i8M().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static string[] Yg4()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(Ws4.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
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
