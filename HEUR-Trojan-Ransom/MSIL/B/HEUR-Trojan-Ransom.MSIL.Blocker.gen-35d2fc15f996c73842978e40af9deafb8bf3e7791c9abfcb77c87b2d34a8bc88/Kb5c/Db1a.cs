using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Em42;
using Hr4g;
using Microsoft.VisualBasic.CompilerServices;
using f4L;

namespace Kb5c;

[DesignerGenerated]
public class Db1a : Form
{
	private PictureBox _PictureBox2;

	private PictureBox _PictureBox10;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox16;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox19;

	private PictureBox _PictureBox20;

	private Label _lblID;

	private Label _Label15;

	private Label _Label7;

	private Label _Label5;

	private Label _Label4;

	public int MytotalCost;

	public int MytotalPayment;

	public int MyChange;

	public int MySeats;

	public string MycustomerID;

	public string MyfirstName;

	internal IContainer Y;

	internal PictureBox m;

	internal PictureBox p;

	internal PictureBox f;

	internal PictureBox Q;

	internal PictureBox A;

	internal PictureBox b;

	internal PictureBox K;

	internal PictureBox x;

	internal PictureBox u;

	internal PictureBox E;

	internal Label T;

	internal GroupBox r;

	internal Label i;

	internal Label j;

	internal Label C;

	internal Label o;

	internal Label v;

	internal Label H;

	internal Label s;

	internal Label N;

	internal Label L;

	public Db1a()
	{
		((Form)this).add_Load((EventHandler)b7T0);
		Jc9f();
	}

	protected override void b9SX(bool Ne73)
	{
		try
		{
			if (Ne73 && Y != null)
			{
				Y.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ne73);
		}
	}

	private void Jc9f()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Db1a));
		Tq07(new PictureBox());
		Xd46(new PictureBox());
		t5M9(new PictureBox());
		n1D7(new PictureBox());
		m8L9(new PictureBox());
		c2H4(new PictureBox());
		g8GZ(new PictureBox());
		Rg78(new PictureBox());
		Ea94(new PictureBox());
		Hx46(new PictureBox());
		z5R1(new PictureBox());
		e8J5(new PictureBox());
		Mt01(new PictureBox());
		Hb19(new PictureBox());
		p2M3(new PictureBox());
		d5Y6(new PictureBox());
		Bc09(new PictureBox());
		Zf7n(new PictureBox());
		c4J1(new PictureBox());
		Tw84(new PictureBox());
		Fq4i(new Label());
		Qe91(new GroupBox());
		a1FW(new Label());
		q1M5(new Label());
		g2G1(new Label());
		By87(new Label());
		n8NE(new Label());
		Gm1i(new Label());
		Cc40(new Label());
		f8B4(new Label());
		Xy86(new Label());
		Qx01(new Label());
		y2CK(new Label());
		My06(new Label());
		r0F1(new Label());
		m6Y7(new Label());
		((ISupportInitialize)d0LC()).BeginInit();
		((ISupportInitialize)Ny32()).BeginInit();
		((ISupportInitialize)w2L4()).BeginInit();
		((ISupportInitialize)Kq63()).BeginInit();
		((ISupportInitialize)w2BP()).BeginInit();
		((ISupportInitialize)Ms06()).BeginInit();
		((ISupportInitialize)Xf74()).BeginInit();
		((ISupportInitialize)Cw32()).BeginInit();
		((ISupportInitialize)c0WA()).BeginInit();
		((ISupportInitialize)Dy94()).BeginInit();
		((ISupportInitialize)Ps3c()).BeginInit();
		((ISupportInitialize)Sy46()).BeginInit();
		((ISupportInitialize)c0E5()).BeginInit();
		((ISupportInitialize)Xy2n()).BeginInit();
		((ISupportInitialize)Dr59()).BeginInit();
		((ISupportInitialize)Xe7m()).BeginInit();
		((ISupportInitialize)o3AZ()).BeginInit();
		((ISupportInitialize)j7Z1()).BeginInit();
		((ISupportInitialize)Re48()).BeginInit();
		((ISupportInitialize)Gz04()).BeginInit();
		((Control)p6B3()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)d0LC()).set_Dock((DockStyle)1);
		((Control)d0LC()).set_Location(new Point(0, 0));
		((Control)d0LC()).set_Name("PictureBox1");
		((Control)d0LC()).set_Size(new Size(425, 40));
		d0LC().set_SizeMode((PictureBoxSizeMode)1);
		d0LC().set_TabIndex(0);
		d0LC().set_TabStop(false);
		Ny32().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)Ny32()).set_Location(new Point(0, 369));
		((Control)Ny32()).set_Name("PictureBox2");
		((Control)Ny32()).set_Size(new Size(425, 29));
		Ny32().set_TabIndex(3);
		Ny32().set_TabStop(false);
		w2L4().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)w2L4()).set_Location(new Point(0, 434));
		((Control)w2L4()).set_Name("PictureBox3");
		((Control)w2L4()).set_Size(new Size(425, 29));
		w2L4().set_TabIndex(4);
		w2L4().set_TabStop(false);
		Kq63().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)Kq63()).set_Location(new Point(55, 6));
		((Control)Kq63()).set_Name("PictureBox4");
		((Control)Kq63()).set_Size(new Size(36, 29));
		Kq63().set_TabIndex(5);
		Kq63().set_TabStop(false);
		w2BP().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)w2BP()).set_Location(new Point(307, 6));
		((Control)w2BP()).set_Name("PictureBox5");
		((Control)w2BP()).set_Size(new Size(36, 29));
		w2BP().set_TabIndex(6);
		w2BP().set_TabStop(false);
		Ms06().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)Ms06()).set_Location(new Point(244, 6));
		((Control)Ms06()).set_Name("PictureBox6");
		((Control)Ms06()).set_Size(new Size(36, 29));
		Ms06().set_TabIndex(7);
		Ms06().set_TabStop(false);
		Xf74().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)Xf74()).set_Location(new Point(181, 6));
		((Control)Xf74()).set_Name("PictureBox7");
		((Control)Xf74()).set_Size(new Size(36, 29));
		Xf74().set_TabIndex(8);
		Xf74().set_TabStop(false);
		Cw32().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)Cw32()).set_Location(new Point(118, 6));
		((Control)Cw32()).set_Name("PictureBox8");
		((Control)Cw32()).set_Size(new Size(36, 29));
		Cw32().set_TabIndex(9);
		Cw32().set_TabStop(false);
		c0WA().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)c0WA()).set_Location(new Point(79, 373));
		((Control)c0WA()).set_Name("PictureBox9");
		((Control)c0WA()).set_Size(new Size(22, 20));
		c0WA().set_TabIndex(10);
		c0WA().set_TabStop(false);
		Dy94().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)Dy94()).set_Location(new Point(295, 373));
		((Control)Dy94()).set_Name("PictureBox10");
		((Control)Dy94()).set_Size(new Size(22, 20));
		Dy94().set_TabIndex(11);
		Dy94().set_TabStop(false);
		Ps3c().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)Ps3c()).set_Location(new Point(209, 373));
		((Control)Ps3c()).set_Name("PictureBox11");
		((Control)Ps3c()).set_Size(new Size(22, 20));
		Ps3c().set_TabIndex(12);
		Ps3c().set_TabStop(false);
		Sy46().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)Sy46()).set_Location(new Point(252, 373));
		((Control)Sy46()).set_Name("PictureBox12");
		((Control)Sy46()).set_Size(new Size(22, 20));
		Sy46().set_TabIndex(13);
		Sy46().set_TabStop(false);
		c0E5().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)c0E5()).set_Location(new Point(166, 373));
		((Control)c0E5()).set_Name("PictureBox13");
		((Control)c0E5()).set_Size(new Size(22, 20));
		c0E5().set_TabIndex(14);
		c0E5().set_TabStop(false);
		Xy2n().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)Xy2n()).set_Location(new Point(122, 373));
		((Control)Xy2n()).set_Name("PictureBox14");
		((Control)Xy2n()).set_Size(new Size(22, 20));
		Xy2n().set_TabIndex(15);
		Xy2n().set_TabStop(false);
		Dr59().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)Dr59()).set_Location(new Point(124, 437));
		((Control)Dr59()).set_Name("PictureBox15");
		((Control)Dr59()).set_Size(new Size(22, 20));
		Dr59().set_TabIndex(21);
		Dr59().set_TabStop(false);
		Xe7m().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)Xe7m()).set_Location(new Point(167, 437));
		((Control)Xe7m()).set_Name("PictureBox16");
		((Control)Xe7m()).set_Size(new Size(22, 20));
		Xe7m().set_TabIndex(20);
		Xe7m().set_TabStop(false);
		o3AZ().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)o3AZ()).set_Location(new Point(253, 437));
		((Control)o3AZ()).set_Name("PictureBox17");
		((Control)o3AZ()).set_Size(new Size(22, 20));
		o3AZ().set_TabIndex(19);
		o3AZ().set_TabStop(false);
		j7Z1().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)j7Z1()).set_Location(new Point(210, 437));
		((Control)j7Z1()).set_Name("PictureBox18");
		((Control)j7Z1()).set_Size(new Size(22, 20));
		j7Z1().set_TabIndex(18);
		j7Z1().set_TabStop(false);
		Re48().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)Re48()).set_Location(new Point(296, 437));
		((Control)Re48()).set_Name("PictureBox19");
		((Control)Re48()).set_Size(new Size(22, 20));
		Re48().set_TabIndex(17);
		Re48().set_TabStop(false);
		Gz04().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)Gz04()).set_Location(new Point(80, 437));
		((Control)Gz04()).set_Name("PictureBox20");
		((Control)Gz04()).set_Size(new Size(22, 20));
		Gz04().set_TabIndex(16);
		Gz04().set_TabStop(false);
		Sd6k().set_AutoSize(true);
		((Control)Sd6k()).set_BackColor(Color.Transparent);
		((Control)Sd6k()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Sd6k()).set_ForeColor(Color.White);
		((Control)Sd6k()).set_Location(new Point(166, 403));
		((Control)Sd6k()).set_Name("Label6");
		((Control)Sd6k()).set_Size(new Size(72, 25));
		((Control)Sd6k()).set_TabIndex(22);
		Sd6k().set_Text("PASS");
		((Control)p6B3()).set_BackColor(Color.Transparent);
		((Control)p6B3()).get_Controls().Add((Control)(object)Xf0m());
		((Control)p6B3()).get_Controls().Add((Control)(object)Zs78());
		((Control)p6B3()).get_Controls().Add((Control)(object)m2BT());
		((Control)p6B3()).get_Controls().Add((Control)(object)Cj93());
		((Control)p6B3()).get_Controls().Add((Control)(object)q1DQ());
		((Control)p6B3()).get_Controls().Add((Control)(object)Na9e());
		((Control)p6B3()).get_Controls().Add((Control)(object)c6BP());
		((Control)p6B3()).get_Controls().Add((Control)(object)x4Y0());
		((Control)p6B3()).get_Controls().Add((Control)(object)Re95());
		((Control)p6B3()).get_Controls().Add((Control)(object)Lq8n());
		((Control)p6B3()).get_Controls().Add((Control)(object)Ak7m());
		((Control)p6B3()).get_Controls().Add((Control)(object)Fw9m());
		((Control)p6B3()).get_Controls().Add((Control)(object)Na3e());
		((Control)p6B3()).get_Controls().Add((Control)(object)t7S2());
		((Control)p6B3()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)p6B3()).set_Location(new Point(65, 171));
		((Control)p6B3()).set_Name("GroupBox1");
		((Control)p6B3()).set_Size(new Size(290, 192));
		((Control)p6B3()).set_TabIndex(23);
		p6B3().set_TabStop(false);
		Xf0m().set_AutoSize(true);
		((Control)Xf0m()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Xf0m()).set_Location(new Point(175, 164));
		((Control)Xf0m()).set_Name("lblChange");
		((Control)Xf0m()).set_Size(new Size(50, 13));
		((Control)Xf0m()).set_TabIndex(13);
		Xf0m().set_Text("Change");
		Zs78().set_AutoSize(true);
		((Control)Zs78()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Zs78()).set_Location(new Point(175, 140));
		((Control)Zs78()).set_Name("lblTotalPayment");
		((Control)Zs78()).set_Size(new Size(88, 13));
		((Control)Zs78()).set_TabIndex(12);
		Zs78().set_Text("Total Payment");
		m2BT().set_AutoSize(true);
		((Control)m2BT()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)m2BT()).set_Location(new Point(175, 116));
		((Control)m2BT()).set_Name("lblTotalCost");
		((Control)m2BT()).set_Size(new Size(65, 13));
		((Control)m2BT()).set_TabIndex(11);
		m2BT().set_Text("Total Cost");
		Cj93().set_AutoSize(true);
		((Control)Cj93()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Cj93()).set_Location(new Point(175, 92));
		((Control)Cj93()).set_Name("lblSeats");
		((Control)Cj93()).set_Size(new Size(97, 13));
		((Control)Cj93()).set_TabIndex(10);
		Cj93().set_Text("Seats Reserved");
		q1DQ().set_AutoSize(true);
		((Control)q1DQ()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)q1DQ()).set_Location(new Point(175, 68));
		((Control)q1DQ()).set_Name("lblName");
		((Control)q1DQ()).set_Size(new Size(39, 13));
		((Control)q1DQ()).set_TabIndex(9);
		q1DQ().set_Text("Name");
		Na9e().set_AutoSize(true);
		((Control)Na9e()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Na9e()).set_Location(new Point(175, 44));
		((Control)Na9e()).set_Name("lblID");
		((Control)Na9e()).set_Size(new Size(72, 13));
		((Control)Na9e()).set_TabIndex(8);
		Na9e().set_Text("CustomerID");
		c6BP().set_AutoSize(true);
		((Control)c6BP()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)c6BP()).set_Location(new Point(175, 20));
		((Control)c6BP()).set_Name("Label15");
		((Control)c6BP()).set_Size(new Size(109, 13));
		((Control)c6BP()).set_TabIndex(7);
		c6BP().set_Text("BLACK PANTHER");
		x4Y0().set_AutoSize(true);
		((Control)x4Y0()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)x4Y0()).set_Location(new Point(42, 164));
		((Control)x4Y0()).set_Name("Label8");
		((Control)x4Y0()).set_Size(new Size(44, 13));
		((Control)x4Y0()).set_TabIndex(6);
		x4Y0().set_Text("Change");
		Re95().set_AutoSize(true);
		((Control)Re95()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Re95()).set_Location(new Point(42, 140));
		((Control)Re95()).set_Name("Label7");
		((Control)Re95()).set_Size(new Size(75, 13));
		((Control)Re95()).set_TabIndex(5);
		Re95().set_Text("Total Payment");
		Lq8n().set_AutoSize(true);
		((Control)Lq8n()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lq8n()).set_Location(new Point(42, 116));
		((Control)Lq8n()).set_Name("Label5");
		((Control)Lq8n()).set_Size(new Size(55, 13));
		((Control)Lq8n()).set_TabIndex(4);
		Lq8n().set_Text("Total Cost");
		Ak7m().set_AutoSize(true);
		((Control)Ak7m()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ak7m()).set_Location(new Point(42, 92));
		((Control)Ak7m()).set_Name("Label4");
		((Control)Ak7m()).set_Size(new Size(83, 13));
		((Control)Ak7m()).set_TabIndex(3);
		Ak7m().set_Text("Seats Reserved");
		Fw9m().set_AutoSize(true);
		((Control)Fw9m()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Fw9m()).set_Location(new Point(42, 68));
		((Control)Fw9m()).set_Name("Label3");
		((Control)Fw9m()).set_Size(new Size(35, 13));
		((Control)Fw9m()).set_TabIndex(2);
		Fw9m().set_Text("Name");
		Na3e().set_AutoSize(true);
		((Control)Na3e()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Na3e()).set_Location(new Point(42, 44));
		((Control)Na3e()).set_Name("Label2");
		((Control)Na3e()).set_Size(new Size(62, 13));
		((Control)Na3e()).set_TabIndex(1);
		Na3e().set_Text("CustomerID");
		t7S2().set_AutoSize(true);
		((Control)t7S2()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t7S2()).set_Location(new Point(42, 20));
		((Control)t7S2()).set_Name("Label1");
		((Control)t7S2()).set_Size(new Size(36, 13));
		((Control)t7S2()).set_TabIndex(0);
		t7S2().set_Text("Movie");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		((Form)this).set_ClientSize(new Size(425, 493));
		((Control)this).get_Controls().Add((Control)(object)p6B3());
		((Control)this).get_Controls().Add((Control)(object)Sd6k());
		((Control)this).get_Controls().Add((Control)(object)Dr59());
		((Control)this).get_Controls().Add((Control)(object)Xe7m());
		((Control)this).get_Controls().Add((Control)(object)o3AZ());
		((Control)this).get_Controls().Add((Control)(object)j7Z1());
		((Control)this).get_Controls().Add((Control)(object)Re48());
		((Control)this).get_Controls().Add((Control)(object)Gz04());
		((Control)this).get_Controls().Add((Control)(object)Xy2n());
		((Control)this).get_Controls().Add((Control)(object)c0E5());
		((Control)this).get_Controls().Add((Control)(object)Sy46());
		((Control)this).get_Controls().Add((Control)(object)Ps3c());
		((Control)this).get_Controls().Add((Control)(object)Dy94());
		((Control)this).get_Controls().Add((Control)(object)c0WA());
		((Control)this).get_Controls().Add((Control)(object)Cw32());
		((Control)this).get_Controls().Add((Control)(object)Xf74());
		((Control)this).get_Controls().Add((Control)(object)Ms06());
		((Control)this).get_Controls().Add((Control)(object)w2BP());
		((Control)this).get_Controls().Add((Control)(object)Kq63());
		((Control)this).get_Controls().Add((Control)(object)w2L4());
		((Control)this).get_Controls().Add((Control)(object)Ny32());
		((Control)this).get_Controls().Add((Control)(object)d0LC());
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((ISupportInitialize)d0LC()).EndInit();
		((ISupportInitialize)Ny32()).EndInit();
		((ISupportInitialize)w2L4()).EndInit();
		((ISupportInitialize)Kq63()).EndInit();
		((ISupportInitialize)w2BP()).EndInit();
		((ISupportInitialize)Ms06()).EndInit();
		((ISupportInitialize)Xf74()).EndInit();
		((ISupportInitialize)Cw32()).EndInit();
		((ISupportInitialize)c0WA()).EndInit();
		((ISupportInitialize)Dy94()).EndInit();
		((ISupportInitialize)Ps3c()).EndInit();
		((ISupportInitialize)Sy46()).EndInit();
		((ISupportInitialize)c0E5()).EndInit();
		((ISupportInitialize)Xy2n()).EndInit();
		((ISupportInitialize)Dr59()).EndInit();
		((ISupportInitialize)Xe7m()).EndInit();
		((ISupportInitialize)o3AZ()).EndInit();
		((ISupportInitialize)j7Z1()).EndInit();
		((ISupportInitialize)Re48()).EndInit();
		((ISupportInitialize)Gz04()).EndInit();
		((Control)p6B3()).ResumeLayout(false);
		((Control)p6B3()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox d0LC()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tq07(PictureBox o2E5)
	{
		PictureBox val = (m = o2E5);
	}

	[SpecialName]
	internal virtual PictureBox Ny32()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd46(PictureBox Ln60)
	{
		_PictureBox2 = Ln60;
	}

	[SpecialName]
	internal virtual PictureBox w2L4()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5M9(PictureBox Tg80)
	{
		PictureBox val = (p = Tg80);
	}

	[SpecialName]
	internal virtual PictureBox Kq63()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1D7(PictureBox e3HR)
	{
		PictureBox val = (f = e3HR);
	}

	[SpecialName]
	internal virtual PictureBox w2BP()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8L9(PictureBox Pq8s)
	{
		PictureBox val = (Q = Pq8s);
	}

	[SpecialName]
	internal virtual PictureBox Ms06()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2H4(PictureBox b4F0)
	{
		PictureBox val = (A = b4F0);
	}

	[SpecialName]
	internal virtual PictureBox Xf74()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8GZ(PictureBox b3SX)
	{
		PictureBox val = (b = b3SX);
	}

	[SpecialName]
	internal virtual PictureBox Cw32()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rg78(PictureBox z2Q3)
	{
		PictureBox val = (K = z2Q3);
	}

	[SpecialName]
	internal virtual PictureBox c0WA()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ea94(PictureBox Pf9m)
	{
		PictureBox val = (x = Pf9m);
	}

	[SpecialName]
	internal virtual PictureBox Dy94()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hx46(PictureBox n9R5)
	{
		_PictureBox10 = n9R5;
	}

	[SpecialName]
	internal virtual PictureBox Ps3c()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5R1(PictureBox Se2s)
	{
		PictureBox val = (u = Se2s);
	}

	[SpecialName]
	internal virtual PictureBox Sy46()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8J5(PictureBox p8T7)
	{
		PictureBox val = (E = p8T7);
	}

	[SpecialName]
	internal virtual PictureBox c0E5()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mt01(PictureBox Fm32)
	{
		_PictureBox13 = Fm32;
	}

	[SpecialName]
	internal virtual PictureBox Xy2n()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hb19(PictureBox Ke5y)
	{
		_PictureBox14 = Ke5y;
	}

	[SpecialName]
	internal virtual PictureBox Dr59()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2M3(PictureBox Nt8q)
	{
		_PictureBox15 = Nt8q;
	}

	[SpecialName]
	internal virtual PictureBox Xe7m()
	{
		return _PictureBox16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5Y6(PictureBox Bm95)
	{
		_PictureBox16 = Bm95;
	}

	[SpecialName]
	internal virtual PictureBox o3AZ()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bc09(PictureBox x2RA)
	{
		_PictureBox17 = x2RA;
	}

	[SpecialName]
	internal virtual PictureBox j7Z1()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf7n(PictureBox Co81)
	{
		_PictureBox18 = Co81;
	}

	[SpecialName]
	internal virtual PictureBox Re48()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4J1(PictureBox s3GZ)
	{
		_PictureBox19 = s3GZ;
	}

	[SpecialName]
	internal virtual PictureBox Gz04()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw84(PictureBox o8AJ)
	{
		_PictureBox20 = o8AJ;
	}

	[SpecialName]
	internal virtual Label Sd6k()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fq4i(Label f6R8)
	{
		Label val = (T = f6R8);
	}

	[SpecialName]
	internal virtual GroupBox p6B3()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qe91(GroupBox Nw31)
	{
		GroupBox val = (r = Nw31);
	}

	[SpecialName]
	internal virtual Label Xf0m()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1FW(Label Ea23)
	{
		Label val = (i = Ea23);
	}

	[SpecialName]
	internal virtual Label Zs78()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1M5(Label k1J6)
	{
		Label val = (j = k1J6);
	}

	[SpecialName]
	internal virtual Label m2BT()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2G1(Label Wp3w)
	{
		Label val = (C = Wp3w);
	}

	[SpecialName]
	internal virtual Label Cj93()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void By87(Label Rq1z)
	{
		Label val = (o = Rq1z);
	}

	[SpecialName]
	internal virtual Label q1DQ()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8NE(Label Gr07)
	{
		Label val = (v = Gr07);
	}

	[SpecialName]
	internal virtual Label Na9e()
	{
		return _lblID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gm1i(Label k4ZT)
	{
		_lblID = k4ZT;
	}

	[SpecialName]
	internal virtual Label c6BP()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cc40(Label r6B0)
	{
		_Label15 = r6B0;
	}

	[SpecialName]
	internal virtual Label x4Y0()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8B4(Label z7X8)
	{
		Label val = (H = z7X8);
	}

	[SpecialName]
	internal virtual Label Re95()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xy86(Label x5B7)
	{
		_Label7 = x5B7;
	}

	[SpecialName]
	internal virtual Label Lq8n()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qx01(Label f2T5)
	{
		_Label5 = f2T5;
	}

	[SpecialName]
	internal virtual Label Ak7m()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y2CK(Label q8S1)
	{
		_Label4 = q8S1;
	}

	[SpecialName]
	internal virtual Label Fw9m()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void My06(Label Pa8m)
	{
		Label val = (s = Pa8m);
	}

	[SpecialName]
	internal virtual Label Na3e()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0F1(Label o7H9)
	{
		Label val = (N = o7H9);
	}

	[SpecialName]
	internal virtual Label t7S2()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6Y7(Label Fs71)
	{
		Label val = (L = Fs71);
	}

	private void b7T0(object sender, EventArgs e)
	{
		MytotalCost = Fo9c.Forms.q2Z4().totalCost;
		MytotalPayment = Fo9c.Forms.q2Z4().totalPayment;
		MyChange = Fo9c.Forms.q2Z4().change;
		MycustomerID = Fo9c.Forms.q2Z4().customerID;
		MyfirstName = Fo9c.Forms.q2Z4().firstName;
		MySeats = Fo9c.Forms.q2Z4().seats;
		Na9e().set_Text(MycustomerID);
		q1DQ().set_Text(MyfirstName);
		Cj93().set_Text(Conversions.ToString(MySeats));
		m2BT().set_Text("$" + Conversions.ToString(MytotalCost));
		Zs78().set_Text("$" + Conversions.ToString(MytotalPayment));
		Xf0m().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static void o5MR()
	{
		string[] an = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Dq2a.Sg96(an, 0, 3);
		string value2 = Dq2a.Sg96(an, 4, 7);
		r6C.mDic.Add(r6C.tName, value);
		r6C.mDic.Add(r6C.mName, value2);
	}
}
