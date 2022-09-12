using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dz5;
using Microsoft.VisualBasic.CompilerServices;
using i9M;
using r5F;

namespace Qz7;

[DesignerGenerated]
public class e0E : Form
{
	private IContainer components;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox6;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox16;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox19;

	private Label _Label6;

	private Label _lblChange;

	private Label _lblName;

	private Label _lblID;

	private Label _Label15;

	private Label _Label8;

	private Label _Label5;

	private Label _Label1;

	public int MytotalCost;

	public int MytotalPayment;

	public int MyChange;

	public int MySeats;

	public string MycustomerID;

	public string MyfirstName;

	internal PictureBox n;

	internal PictureBox j;

	internal PictureBox Q;

	internal PictureBox t;

	internal PictureBox a;

	internal PictureBox U;

	internal PictureBox O;

	internal GroupBox F;

	internal Label r;

	internal Label g;

	internal Label C;

	internal Label K;

	internal Label I;

	internal Label D;

	internal Label B;

	public e0E()
	{
		((Form)this).add_Load((EventHandler)Lm4);
		Xo1();
	}

	protected override void Sf9(bool Yc9)
	{
		try
		{
			if (Yc9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Yc9);
		}
	}

	private void Xo1()
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
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Expected O, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a74: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected O, but got Unknown
		//IL_0dab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Expected O, but got Unknown
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e39: Expected O, but got Unknown
		//IL_0eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Expected O, but got Unknown
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected O, but got Unknown
		//IL_0fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Expected O, but got Unknown
		//IL_1036: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected O, but got Unknown
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected O, but got Unknown
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected O, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Expected O, but got Unknown
		//IL_1236: Unknown result type (might be due to invalid IL or missing references)
		//IL_1240: Expected O, but got Unknown
		//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bd: Expected O, but got Unknown
		//IL_1330: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Expected O, but got Unknown
		//IL_13ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b7: Expected O, but got Unknown
		//IL_142a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1434: Expected O, but got Unknown
		//IL_1644: Unknown result type (might be due to invalid IL or missing references)
		//IL_164e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(e0E));
		Dq8(new PictureBox());
		Ga7(new PictureBox());
		Sd9(new PictureBox());
		Sd5(new PictureBox());
		z1K(new PictureBox());
		w9K(new PictureBox());
		Rg9(new PictureBox());
		j5R(new PictureBox());
		Ap4(new PictureBox());
		Lk8(new PictureBox());
		An0(new PictureBox());
		r6K(new PictureBox());
		De0(new PictureBox());
		y8Y(new PictureBox());
		p0G(new PictureBox());
		Mj6(new PictureBox());
		Bq8(new PictureBox());
		z3J(new PictureBox());
		p3T(new PictureBox());
		e0A(new PictureBox());
		w6A(new Label());
		m7F(new GroupBox());
		Hj8(new Label());
		Fy1(new Label());
		Ra1(new Label());
		r4E(new Label());
		a7Q(new Label());
		j4A(new Label());
		k6L(new Label());
		s4N(new Label());
		Nk4(new Label());
		a1N(new Label());
		a9G(new Label());
		Nm5(new Label());
		c5W(new Label());
		a5X(new Label());
		((ISupportInitialize)m1E()).BeginInit();
		((ISupportInitialize)p3M()).BeginInit();
		((ISupportInitialize)k2C()).BeginInit();
		((ISupportInitialize)b9J()).BeginInit();
		((ISupportInitialize)q8C()).BeginInit();
		((ISupportInitialize)g7B()).BeginInit();
		((ISupportInitialize)p0B()).BeginInit();
		((ISupportInitialize)r0M()).BeginInit();
		((ISupportInitialize)c4L()).BeginInit();
		((ISupportInitialize)d0B()).BeginInit();
		((ISupportInitialize)s2L()).BeginInit();
		((ISupportInitialize)Bw1()).BeginInit();
		((ISupportInitialize)Lm4()).BeginInit();
		((ISupportInitialize)d6K()).BeginInit();
		((ISupportInitialize)Sq4()).BeginInit();
		((ISupportInitialize)k1X()).BeginInit();
		((ISupportInitialize)Rn2()).BeginInit();
		((ISupportInitialize)Sg4()).BeginInit();
		((ISupportInitialize)s2X()).BeginInit();
		((ISupportInitialize)m7J()).BeginInit();
		((Control)m7Z()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)m1E()).set_Dock((DockStyle)1);
		((Control)m1E()).set_Location(new Point(0, 0));
		((Control)m1E()).set_Name("PictureBox1");
		((Control)m1E()).set_Size(new Size(425, 40));
		m1E().set_SizeMode((PictureBoxSizeMode)1);
		m1E().set_TabIndex(0);
		m1E().set_TabStop(false);
		p3M().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)p3M()).set_Location(new Point(0, 369));
		((Control)p3M()).set_Name("PictureBox2");
		((Control)p3M()).set_Size(new Size(425, 29));
		p3M().set_TabIndex(3);
		p3M().set_TabStop(false);
		k2C().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)k2C()).set_Location(new Point(0, 434));
		((Control)k2C()).set_Name("PictureBox3");
		((Control)k2C()).set_Size(new Size(425, 29));
		k2C().set_TabIndex(4);
		k2C().set_TabStop(false);
		b9J().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)b9J()).set_Location(new Point(55, 6));
		((Control)b9J()).set_Name("PictureBox4");
		((Control)b9J()).set_Size(new Size(36, 29));
		b9J().set_TabIndex(5);
		b9J().set_TabStop(false);
		q8C().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)q8C()).set_Location(new Point(307, 6));
		((Control)q8C()).set_Name("PictureBox5");
		((Control)q8C()).set_Size(new Size(36, 29));
		q8C().set_TabIndex(6);
		q8C().set_TabStop(false);
		g7B().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)g7B()).set_Location(new Point(244, 6));
		((Control)g7B()).set_Name("PictureBox6");
		((Control)g7B()).set_Size(new Size(36, 29));
		g7B().set_TabIndex(7);
		g7B().set_TabStop(false);
		p0B().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)p0B()).set_Location(new Point(181, 6));
		((Control)p0B()).set_Name("PictureBox7");
		((Control)p0B()).set_Size(new Size(36, 29));
		p0B().set_TabIndex(8);
		p0B().set_TabStop(false);
		r0M().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)r0M()).set_Location(new Point(118, 6));
		((Control)r0M()).set_Name("PictureBox8");
		((Control)r0M()).set_Size(new Size(36, 29));
		r0M().set_TabIndex(9);
		r0M().set_TabStop(false);
		c4L().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)c4L()).set_Location(new Point(79, 373));
		((Control)c4L()).set_Name("PictureBox9");
		((Control)c4L()).set_Size(new Size(22, 20));
		c4L().set_TabIndex(10);
		c4L().set_TabStop(false);
		d0B().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)d0B()).set_Location(new Point(295, 373));
		((Control)d0B()).set_Name("PictureBox10");
		((Control)d0B()).set_Size(new Size(22, 20));
		d0B().set_TabIndex(11);
		d0B().set_TabStop(false);
		s2L().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)s2L()).set_Location(new Point(209, 373));
		((Control)s2L()).set_Name("PictureBox11");
		((Control)s2L()).set_Size(new Size(22, 20));
		s2L().set_TabIndex(12);
		s2L().set_TabStop(false);
		Bw1().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)Bw1()).set_Location(new Point(252, 373));
		((Control)Bw1()).set_Name("PictureBox12");
		((Control)Bw1()).set_Size(new Size(22, 20));
		Bw1().set_TabIndex(13);
		Bw1().set_TabStop(false);
		Lm4().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)Lm4()).set_Location(new Point(166, 373));
		((Control)Lm4()).set_Name("PictureBox13");
		((Control)Lm4()).set_Size(new Size(22, 20));
		Lm4().set_TabIndex(14);
		Lm4().set_TabStop(false);
		d6K().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)d6K()).set_Location(new Point(122, 373));
		((Control)d6K()).set_Name("PictureBox14");
		((Control)d6K()).set_Size(new Size(22, 20));
		d6K().set_TabIndex(15);
		d6K().set_TabStop(false);
		Sq4().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)Sq4()).set_Location(new Point(124, 437));
		((Control)Sq4()).set_Name("PictureBox15");
		((Control)Sq4()).set_Size(new Size(22, 20));
		Sq4().set_TabIndex(21);
		Sq4().set_TabStop(false);
		k1X().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)k1X()).set_Location(new Point(167, 437));
		((Control)k1X()).set_Name("PictureBox16");
		((Control)k1X()).set_Size(new Size(22, 20));
		k1X().set_TabIndex(20);
		k1X().set_TabStop(false);
		Rn2().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)Rn2()).set_Location(new Point(253, 437));
		((Control)Rn2()).set_Name("PictureBox17");
		((Control)Rn2()).set_Size(new Size(22, 20));
		Rn2().set_TabIndex(19);
		Rn2().set_TabStop(false);
		Sg4().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)Sg4()).set_Location(new Point(210, 437));
		((Control)Sg4()).set_Name("PictureBox18");
		((Control)Sg4()).set_Size(new Size(22, 20));
		Sg4().set_TabIndex(18);
		Sg4().set_TabStop(false);
		s2X().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)s2X()).set_Location(new Point(296, 437));
		((Control)s2X()).set_Name("PictureBox19");
		((Control)s2X()).set_Size(new Size(22, 20));
		s2X().set_TabIndex(17);
		s2X().set_TabStop(false);
		m7J().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)m7J()).set_Location(new Point(80, 437));
		((Control)m7J()).set_Name("PictureBox20");
		((Control)m7J()).set_Size(new Size(22, 20));
		m7J().set_TabIndex(16);
		m7J().set_TabStop(false);
		Ma0().set_AutoSize(true);
		((Control)Ma0()).set_BackColor(Color.Transparent);
		((Control)Ma0()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ma0()).set_ForeColor(Color.White);
		((Control)Ma0()).set_Location(new Point(166, 403));
		((Control)Ma0()).set_Name("Label6");
		((Control)Ma0()).set_Size(new Size(72, 25));
		((Control)Ma0()).set_TabIndex(22);
		Ma0().set_Text("PASS");
		((Control)m7Z()).set_BackColor(Color.Transparent);
		((Control)m7Z()).get_Controls().Add((Control)(object)y6E());
		((Control)m7Z()).get_Controls().Add((Control)(object)z4Y());
		((Control)m7Z()).get_Controls().Add((Control)(object)Gc7());
		((Control)m7Z()).get_Controls().Add((Control)(object)Fx9());
		((Control)m7Z()).get_Controls().Add((Control)(object)r1F());
		((Control)m7Z()).get_Controls().Add((Control)(object)Ee6());
		((Control)m7Z()).get_Controls().Add((Control)(object)b6W());
		((Control)m7Z()).get_Controls().Add((Control)(object)p8S());
		((Control)m7Z()).get_Controls().Add((Control)(object)k2N());
		((Control)m7Z()).get_Controls().Add((Control)(object)Jn3());
		((Control)m7Z()).get_Controls().Add((Control)(object)Kg7());
		((Control)m7Z()).get_Controls().Add((Control)(object)o0Q());
		((Control)m7Z()).get_Controls().Add((Control)(object)i0Z());
		((Control)m7Z()).get_Controls().Add((Control)(object)Az1());
		((Control)m7Z()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)m7Z()).set_Location(new Point(65, 171));
		((Control)m7Z()).set_Name("GroupBox1");
		((Control)m7Z()).set_Size(new Size(290, 192));
		((Control)m7Z()).set_TabIndex(23);
		m7Z().set_TabStop(false);
		y6E().set_AutoSize(true);
		((Control)y6E()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)y6E()).set_Location(new Point(175, 164));
		((Control)y6E()).set_Name("lblChange");
		((Control)y6E()).set_Size(new Size(50, 13));
		((Control)y6E()).set_TabIndex(13);
		y6E().set_Text("Change");
		z4Y().set_AutoSize(true);
		((Control)z4Y()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)z4Y()).set_Location(new Point(175, 140));
		((Control)z4Y()).set_Name("lblTotalPayment");
		((Control)z4Y()).set_Size(new Size(88, 13));
		((Control)z4Y()).set_TabIndex(12);
		z4Y().set_Text("Total Payment");
		Gc7().set_AutoSize(true);
		((Control)Gc7()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Gc7()).set_Location(new Point(175, 116));
		((Control)Gc7()).set_Name("lblTotalCost");
		((Control)Gc7()).set_Size(new Size(65, 13));
		((Control)Gc7()).set_TabIndex(11);
		Gc7().set_Text("Total Cost");
		Fx9().set_AutoSize(true);
		((Control)Fx9()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Fx9()).set_Location(new Point(175, 92));
		((Control)Fx9()).set_Name("lblSeats");
		((Control)Fx9()).set_Size(new Size(97, 13));
		((Control)Fx9()).set_TabIndex(10);
		Fx9().set_Text("Seats Reserved");
		r1F().set_AutoSize(true);
		((Control)r1F()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)r1F()).set_Location(new Point(175, 68));
		((Control)r1F()).set_Name("lblName");
		((Control)r1F()).set_Size(new Size(39, 13));
		((Control)r1F()).set_TabIndex(9);
		r1F().set_Text("Name");
		Ee6().set_AutoSize(true);
		((Control)Ee6()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ee6()).set_Location(new Point(175, 44));
		((Control)Ee6()).set_Name("lblID");
		((Control)Ee6()).set_Size(new Size(72, 13));
		((Control)Ee6()).set_TabIndex(8);
		Ee6().set_Text("CustomerID");
		b6W().set_AutoSize(true);
		((Control)b6W()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b6W()).set_Location(new Point(175, 20));
		((Control)b6W()).set_Name("Label15");
		((Control)b6W()).set_Size(new Size(109, 13));
		((Control)b6W()).set_TabIndex(7);
		b6W().set_Text("BLACK PANTHER");
		p8S().set_AutoSize(true);
		((Control)p8S()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p8S()).set_Location(new Point(42, 164));
		((Control)p8S()).set_Name("Label8");
		((Control)p8S()).set_Size(new Size(44, 13));
		((Control)p8S()).set_TabIndex(6);
		p8S().set_Text("Change");
		k2N().set_AutoSize(true);
		((Control)k2N()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k2N()).set_Location(new Point(42, 140));
		((Control)k2N()).set_Name("Label7");
		((Control)k2N()).set_Size(new Size(75, 13));
		((Control)k2N()).set_TabIndex(5);
		k2N().set_Text("Total Payment");
		Jn3().set_AutoSize(true);
		((Control)Jn3()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Jn3()).set_Location(new Point(42, 116));
		((Control)Jn3()).set_Name("Label5");
		((Control)Jn3()).set_Size(new Size(55, 13));
		((Control)Jn3()).set_TabIndex(4);
		Jn3().set_Text("Total Cost");
		Kg7().set_AutoSize(true);
		((Control)Kg7()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Kg7()).set_Location(new Point(42, 92));
		((Control)Kg7()).set_Name("Label4");
		((Control)Kg7()).set_Size(new Size(83, 13));
		((Control)Kg7()).set_TabIndex(3);
		Kg7().set_Text("Seats Reserved");
		o0Q().set_AutoSize(true);
		((Control)o0Q()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)o0Q()).set_Location(new Point(42, 68));
		((Control)o0Q()).set_Name("Label3");
		((Control)o0Q()).set_Size(new Size(35, 13));
		((Control)o0Q()).set_TabIndex(2);
		o0Q().set_Text("Name");
		i0Z().set_AutoSize(true);
		((Control)i0Z()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i0Z()).set_Location(new Point(42, 44));
		((Control)i0Z()).set_Name("Label2");
		((Control)i0Z()).set_Size(new Size(62, 13));
		((Control)i0Z()).set_TabIndex(1);
		i0Z().set_Text("CustomerID");
		Az1().set_AutoSize(true);
		((Control)Az1()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Az1()).set_Location(new Point(42, 20));
		((Control)Az1()).set_Name("Label1");
		((Control)Az1()).set_Size(new Size(36, 13));
		((Control)Az1()).set_TabIndex(0);
		Az1().set_Text("Movie");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		((Form)this).set_ClientSize(new Size(425, 493));
		((Control)this).get_Controls().Add((Control)(object)m7Z());
		((Control)this).get_Controls().Add((Control)(object)Ma0());
		((Control)this).get_Controls().Add((Control)(object)Sq4());
		((Control)this).get_Controls().Add((Control)(object)k1X());
		((Control)this).get_Controls().Add((Control)(object)Rn2());
		((Control)this).get_Controls().Add((Control)(object)Sg4());
		((Control)this).get_Controls().Add((Control)(object)s2X());
		((Control)this).get_Controls().Add((Control)(object)m7J());
		((Control)this).get_Controls().Add((Control)(object)d6K());
		((Control)this).get_Controls().Add((Control)(object)Lm4());
		((Control)this).get_Controls().Add((Control)(object)Bw1());
		((Control)this).get_Controls().Add((Control)(object)s2L());
		((Control)this).get_Controls().Add((Control)(object)d0B());
		((Control)this).get_Controls().Add((Control)(object)c4L());
		((Control)this).get_Controls().Add((Control)(object)r0M());
		((Control)this).get_Controls().Add((Control)(object)p0B());
		((Control)this).get_Controls().Add((Control)(object)g7B());
		((Control)this).get_Controls().Add((Control)(object)q8C());
		((Control)this).get_Controls().Add((Control)(object)b9J());
		((Control)this).get_Controls().Add((Control)(object)k2C());
		((Control)this).get_Controls().Add((Control)(object)p3M());
		((Control)this).get_Controls().Add((Control)(object)m1E());
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((ISupportInitialize)m1E()).EndInit();
		((ISupportInitialize)p3M()).EndInit();
		((ISupportInitialize)k2C()).EndInit();
		((ISupportInitialize)b9J()).EndInit();
		((ISupportInitialize)q8C()).EndInit();
		((ISupportInitialize)g7B()).EndInit();
		((ISupportInitialize)p0B()).EndInit();
		((ISupportInitialize)r0M()).EndInit();
		((ISupportInitialize)c4L()).EndInit();
		((ISupportInitialize)d0B()).EndInit();
		((ISupportInitialize)s2L()).EndInit();
		((ISupportInitialize)Bw1()).EndInit();
		((ISupportInitialize)Lm4()).EndInit();
		((ISupportInitialize)d6K()).EndInit();
		((ISupportInitialize)Sq4()).EndInit();
		((ISupportInitialize)k1X()).EndInit();
		((ISupportInitialize)Rn2()).EndInit();
		((ISupportInitialize)Sg4()).EndInit();
		((ISupportInitialize)s2X()).EndInit();
		((ISupportInitialize)m7J()).EndInit();
		((Control)m7Z()).ResumeLayout(false);
		((Control)m7Z()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox m1E()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dq8(PictureBox r5X)
	{
		PictureBox val = (n = r5X);
	}

	[SpecialName]
	internal virtual PictureBox p3M()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga7(PictureBox Fr3)
	{
		PictureBox val = (j = Fr3);
	}

	[SpecialName]
	internal virtual PictureBox k2C()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd9(PictureBox Ec3)
	{
		_PictureBox3 = Ec3;
	}

	[SpecialName]
	internal virtual PictureBox b9J()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd5(PictureBox z2N)
	{
		PictureBox val = (Q = z2N);
	}

	[SpecialName]
	internal virtual PictureBox q8C()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1K(PictureBox x6Q)
	{
		PictureBox val = (t = x6Q);
	}

	[SpecialName]
	internal virtual PictureBox g7B()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w9K(PictureBox t7T)
	{
		_PictureBox6 = t7T;
	}

	[SpecialName]
	internal virtual PictureBox p0B()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rg9(PictureBox o7A)
	{
		_PictureBox7 = o7A;
	}

	[SpecialName]
	internal virtual PictureBox r0M()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5R(PictureBox Nw3)
	{
		_PictureBox8 = Nw3;
	}

	[SpecialName]
	internal virtual PictureBox c4L()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap4(PictureBox w3J)
	{
		_PictureBox9 = w3J;
	}

	[SpecialName]
	internal virtual PictureBox d0B()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lk8(PictureBox f1K)
	{
		PictureBox val = (a = f1K);
	}

	[SpecialName]
	internal virtual PictureBox s2L()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void An0(PictureBox Wa5)
	{
		_PictureBox11 = Wa5;
	}

	[SpecialName]
	internal virtual PictureBox Bw1()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6K(PictureBox b4W)
	{
		_PictureBox12 = b4W;
	}

	[SpecialName]
	internal virtual PictureBox Lm4()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void De0(PictureBox Ci9)
	{
		_PictureBox13 = Ci9;
	}

	[SpecialName]
	internal virtual PictureBox d6K()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8Y(PictureBox n0H)
	{
		_PictureBox14 = n0H;
	}

	[SpecialName]
	internal virtual PictureBox Sq4()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0G(PictureBox Zk9)
	{
		_PictureBox15 = Zk9;
	}

	[SpecialName]
	internal virtual PictureBox k1X()
	{
		return _PictureBox16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mj6(PictureBox Zk5)
	{
		_PictureBox16 = Zk5;
	}

	[SpecialName]
	internal virtual PictureBox Rn2()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bq8(PictureBox a4W)
	{
		_PictureBox17 = a4W;
	}

	[SpecialName]
	internal virtual PictureBox Sg4()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3J(PictureBox Nr8)
	{
		PictureBox val = (U = Nr8);
	}

	[SpecialName]
	internal virtual PictureBox s2X()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3T(PictureBox Jg4)
	{
		_PictureBox19 = Jg4;
	}

	[SpecialName]
	internal virtual PictureBox m7J()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0A(PictureBox d5Y)
	{
		PictureBox val = (O = d5Y);
	}

	[SpecialName]
	internal virtual Label Ma0()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6A(Label Xx9)
	{
		_Label6 = Xx9;
	}

	[SpecialName]
	internal virtual GroupBox m7Z()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7F(GroupBox Sz4)
	{
		GroupBox val = (F = Sz4);
	}

	[SpecialName]
	internal virtual Label y6E()
	{
		return _lblChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hj8(Label Ao2)
	{
		_lblChange = Ao2;
	}

	[SpecialName]
	internal virtual Label z4Y()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fy1(Label Gq4)
	{
		Label val = (r = Gq4);
	}

	[SpecialName]
	internal virtual Label Gc7()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ra1(Label k9T)
	{
		Label val = (g = k9T);
	}

	[SpecialName]
	internal virtual Label Fx9()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4E(Label Yi9)
	{
		Label val = (C = Yi9);
	}

	[SpecialName]
	internal virtual Label r1F()
	{
		return _lblName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7Q(Label k5M)
	{
		_lblName = k5M;
	}

	[SpecialName]
	internal virtual Label Ee6()
	{
		return _lblID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4A(Label y4L)
	{
		_lblID = y4L;
	}

	[SpecialName]
	internal virtual Label b6W()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6L(Label Qz9)
	{
		_Label15 = Qz9;
	}

	[SpecialName]
	internal virtual Label p8S()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4N(Label Qg6)
	{
		_Label8 = Qg6;
	}

	[SpecialName]
	internal virtual Label k2N()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nk4(Label g8P)
	{
		Label val = (K = g8P);
	}

	[SpecialName]
	internal virtual Label Jn3()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1N(Label f4R)
	{
		_Label5 = f4R;
	}

	[SpecialName]
	internal virtual Label Kg7()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9G(Label c1X)
	{
		Label val = (I = c1X);
	}

	[SpecialName]
	internal virtual Label o0Q()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nm5(Label Ko9)
	{
		Label val = (D = Ko9);
	}

	[SpecialName]
	internal virtual Label i0Z()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5W(Label p2G)
	{
		Label val = (B = p2G);
	}

	[SpecialName]
	internal virtual Label Az1()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5X(Label x4L)
	{
		_Label1 = x4L;
	}

	private void Lm4(object sender, EventArgs e)
	{
		MytotalCost = Mi0.Forms.w0M().totalCost;
		MytotalPayment = Mi0.Forms.w0M().totalPayment;
		MyChange = Mi0.Forms.w0M().change;
		MycustomerID = Mi0.Forms.w0M().customerID;
		MyfirstName = Mi0.Forms.w0M().firstName;
		MySeats = Mi0.Forms.w0M().seats;
		Ee6().set_Text(MycustomerID);
		r1F().set_Text(MyfirstName);
		Fx9().set_Text(Conversions.ToString(MySeats));
		Gc7().set_Text("$" + Conversions.ToString(MytotalCost));
		z4Y().set_Text("$" + Conversions.ToString(MytotalPayment));
		y6E().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static void f4Z()
	{
		string[] b4Y = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = d9P.Xz1(b4Y, 0, 3);
		string value2 = d9P.Xz1(b4Y, 4, 7);
		Ws4.mDic.Add(Ws4.tName, value);
		Ws4.mDic.Add(Ws4.mName, value2);
	}
}
