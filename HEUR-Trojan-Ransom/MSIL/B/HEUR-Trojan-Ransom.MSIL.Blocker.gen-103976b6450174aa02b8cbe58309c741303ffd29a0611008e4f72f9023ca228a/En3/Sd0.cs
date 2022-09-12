using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dz5;
using Microsoft.VisualBasic.CompilerServices;
using i9M;

namespace En3;

[DesignerGenerated]
public class Sd0 : Form
{
	private IContainer components;

	private Label _lblChange;

	private Label _lblTotalCost;

	private Label _lblSeats;

	private Label _lblName;

	private Label _Label4;

	private Label _Label3;

	private Label _Label2;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox19;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox10;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox3;

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

	public Sd0()
	{
		((Form)this).add_Load((EventHandler)m6P);
		Sm1();
	}

	protected override void Zp6(bool Ko5)
	{
		try
		{
			if (Ko5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ko5);
		}
	}

	private void Sm1()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Sd0));
		y5K(new GroupBox());
		r4C(new Label());
		c7A(new Label());
		Wd1(new Label());
		d8Q(new Label());
		Hd1(new Label());
		r5R(new Label());
		x4A(new Label());
		g9Z(new Label());
		Af2(new Label());
		f4J(new Label());
		r0W(new Label());
		Lt0(new Label());
		Zt5(new Label());
		Cp3(new Label());
		Fw5(new Label());
		Qn6(new PictureBox());
		Sr9(new PictureBox());
		q4M(new PictureBox());
		w5E(new PictureBox());
		Et9(new PictureBox());
		e4E(new PictureBox());
		n5K(new PictureBox());
		g5B(new PictureBox());
		g9Y(new PictureBox());
		Ar1(new PictureBox());
		Yo4(new PictureBox());
		Ns3(new PictureBox());
		y7K(new PictureBox());
		Ci4(new PictureBox());
		x6P(new PictureBox());
		Jw3(new PictureBox());
		n8E(new PictureBox());
		Pj2(new PictureBox());
		Xw4(new PictureBox());
		Wq3(new PictureBox());
		((Control)Ef9()).SuspendLayout();
		((ISupportInitialize)p2P()).BeginInit();
		((ISupportInitialize)Rp4()).BeginInit();
		((ISupportInitialize)n8F()).BeginInit();
		((ISupportInitialize)s7C()).BeginInit();
		((ISupportInitialize)Gz5()).BeginInit();
		((ISupportInitialize)y7D()).BeginInit();
		((ISupportInitialize)z4D()).BeginInit();
		((ISupportInitialize)y2A()).BeginInit();
		((ISupportInitialize)Hn4()).BeginInit();
		((ISupportInitialize)t0P()).BeginInit();
		((ISupportInitialize)j4E()).BeginInit();
		((ISupportInitialize)Bx9()).BeginInit();
		((ISupportInitialize)d3Z()).BeginInit();
		((ISupportInitialize)r6W()).BeginInit();
		((ISupportInitialize)Lk9()).BeginInit();
		((ISupportInitialize)g1H()).BeginInit();
		((ISupportInitialize)Cz1()).BeginInit();
		((ISupportInitialize)Wg1()).BeginInit();
		((ISupportInitialize)Xi4()).BeginInit();
		((ISupportInitialize)Bo1()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Ef9()).set_BackColor(Color.Transparent);
		((Control)Ef9()).get_Controls().Add((Control)(object)m4R());
		((Control)Ef9()).get_Controls().Add((Control)(object)x2D());
		((Control)Ef9()).get_Controls().Add((Control)(object)y6E());
		((Control)Ef9()).get_Controls().Add((Control)(object)Ee3());
		((Control)Ef9()).get_Controls().Add((Control)(object)t1W());
		((Control)Ef9()).get_Controls().Add((Control)(object)Cc7());
		((Control)Ef9()).get_Controls().Add((Control)(object)g3E());
		((Control)Ef9()).get_Controls().Add((Control)(object)b9X());
		((Control)Ef9()).get_Controls().Add((Control)(object)a8E());
		((Control)Ef9()).get_Controls().Add((Control)(object)z4J());
		((Control)Ef9()).get_Controls().Add((Control)(object)Tx3());
		((Control)Ef9()).get_Controls().Add((Control)(object)g0X());
		((Control)Ef9()).get_Controls().Add((Control)(object)y7P());
		((Control)Ef9()).get_Controls().Add((Control)(object)Aj2());
		((Control)Ef9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ef9()).set_Location(new Point(56, 183));
		((Control)Ef9()).set_Name("GroupBox1");
		((Control)Ef9()).set_Size(new Size(296, 192));
		((Control)Ef9()).set_TabIndex(89);
		Ef9().set_TabStop(false);
		m4R().set_AutoSize(true);
		((Control)m4R()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)m4R()).set_Location(new Point(150, 164));
		((Control)m4R()).set_Name("lblChange");
		((Control)m4R()).set_Size(new Size(50, 13));
		((Control)m4R()).set_TabIndex(13);
		m4R().set_Text("Change");
		x2D().set_AutoSize(true);
		((Control)x2D()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)x2D()).set_Location(new Point(150, 140));
		((Control)x2D()).set_Name("lblTotalPayment");
		((Control)x2D()).set_Size(new Size(88, 13));
		((Control)x2D()).set_TabIndex(12);
		x2D().set_Text("Total Payment");
		y6E().set_AutoSize(true);
		((Control)y6E()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)y6E()).set_Location(new Point(150, 116));
		((Control)y6E()).set_Name("lblTotalCost");
		((Control)y6E()).set_Size(new Size(65, 13));
		((Control)y6E()).set_TabIndex(11);
		y6E().set_Text("Total Cost");
		Ee3().set_AutoSize(true);
		((Control)Ee3()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ee3()).set_Location(new Point(150, 92));
		((Control)Ee3()).set_Name("lblSeats");
		((Control)Ee3()).set_Size(new Size(97, 13));
		((Control)Ee3()).set_TabIndex(10);
		Ee3().set_Text("Seats Reserved");
		t1W().set_AutoSize(true);
		((Control)t1W()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)t1W()).set_Location(new Point(150, 68));
		((Control)t1W()).set_Name("lblName");
		((Control)t1W()).set_Size(new Size(39, 13));
		((Control)t1W()).set_TabIndex(9);
		t1W().set_Text("Name");
		Cc7().set_AutoSize(true);
		((Control)Cc7()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Cc7()).set_Location(new Point(150, 44));
		((Control)Cc7()).set_Name("lblID");
		((Control)Cc7()).set_Size(new Size(72, 13));
		((Control)Cc7()).set_TabIndex(8);
		Cc7().set_Text("CustomerID");
		g3E().set_AutoSize(true);
		((Control)g3E()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)g3E()).set_Location(new Point(150, 20));
		((Control)g3E()).set_Name("Label15");
		((Control)g3E()).set_Size(new Size(59, 13));
		((Control)g3E()).set_TabIndex(7);
		g3E().set_Text("JUMANJI");
		b9X().set_AutoSize(true);
		((Control)b9X()).set_Location(new Point(36, 164));
		((Control)b9X()).set_Name("Label8");
		((Control)b9X()).set_Size(new Size(44, 13));
		((Control)b9X()).set_TabIndex(6);
		b9X().set_Text("Change");
		a8E().set_AutoSize(true);
		((Control)a8E()).set_Location(new Point(36, 140));
		((Control)a8E()).set_Name("Label7");
		((Control)a8E()).set_Size(new Size(75, 13));
		((Control)a8E()).set_TabIndex(5);
		a8E().set_Text("Total Payment");
		z4J().set_AutoSize(true);
		((Control)z4J()).set_Location(new Point(36, 116));
		((Control)z4J()).set_Name("Label5");
		((Control)z4J()).set_Size(new Size(55, 13));
		((Control)z4J()).set_TabIndex(4);
		z4J().set_Text("Total Cost");
		Tx3().set_AutoSize(true);
		((Control)Tx3()).set_Location(new Point(36, 92));
		((Control)Tx3()).set_Name("Label4");
		((Control)Tx3()).set_Size(new Size(83, 13));
		((Control)Tx3()).set_TabIndex(3);
		Tx3().set_Text("Seats Reserved");
		g0X().set_AutoSize(true);
		((Control)g0X()).set_Location(new Point(36, 68));
		((Control)g0X()).set_Name("Label3");
		((Control)g0X()).set_Size(new Size(35, 13));
		((Control)g0X()).set_TabIndex(2);
		g0X().set_Text("Name");
		y7P().set_AutoSize(true);
		((Control)y7P()).set_Location(new Point(36, 44));
		((Control)y7P()).set_Name("Label2");
		((Control)y7P()).set_Size(new Size(62, 13));
		((Control)y7P()).set_TabIndex(1);
		y7P().set_Text("CustomerID");
		Aj2().set_AutoSize(true);
		((Control)Aj2()).set_Location(new Point(36, 20));
		((Control)Aj2()).set_Name("Label1");
		((Control)Aj2()).set_Size(new Size(36, 13));
		((Control)Aj2()).set_TabIndex(0);
		Aj2().set_Text("Movie");
		Ad6().set_AutoSize(true);
		((Control)Ad6()).set_BackColor(Color.Transparent);
		((Control)Ad6()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ad6()).set_ForeColor(Color.White);
		((Control)Ad6()).set_Location(new Point(142, 415));
		((Control)Ad6()).set_Name("Label6");
		((Control)Ad6()).set_Size(new Size(72, 25));
		((Control)Ad6()).set_TabIndex(88);
		Ad6().set_Text("PASS");
		p2P().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)p2P()).set_Location(new Point(106, 449));
		((Control)p2P()).set_Name("PictureBox15");
		((Control)p2P()).set_Size(new Size(19, 20));
		p2P().set_TabIndex(87);
		p2P().set_TabStop(false);
		Rp4().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)Rp4()).set_Location(new Point(143, 449));
		((Control)Rp4()).set_Name("PictureBox16");
		((Control)Rp4()).set_Size(new Size(19, 20));
		Rp4().set_TabIndex(86);
		Rp4().set_TabStop(false);
		n8F().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)n8F()).set_Location(new Point(217, 449));
		((Control)n8F()).set_Name("PictureBox17");
		((Control)n8F()).set_Size(new Size(19, 20));
		n8F().set_TabIndex(85);
		n8F().set_TabStop(false);
		s7C().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)s7C()).set_Location(new Point(180, 449));
		((Control)s7C()).set_Name("PictureBox18");
		((Control)s7C()).set_Size(new Size(19, 20));
		s7C().set_TabIndex(84);
		s7C().set_TabStop(false);
		Gz5().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)Gz5()).set_Location(new Point(254, 449));
		((Control)Gz5()).set_Name("PictureBox19");
		((Control)Gz5()).set_Size(new Size(19, 20));
		Gz5().set_TabIndex(83);
		Gz5().set_TabStop(false);
		y7D().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)y7D()).set_Location(new Point(69, 449));
		((Control)y7D()).set_Name("PictureBox20");
		((Control)y7D()).set_Size(new Size(19, 20));
		y7D().set_TabIndex(82);
		y7D().set_TabStop(false);
		z4D().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)z4D()).set_Location(new Point(105, 385));
		((Control)z4D()).set_Name("PictureBox14");
		((Control)z4D()).set_Size(new Size(19, 20));
		z4D().set_TabIndex(81);
		z4D().set_TabStop(false);
		y2A().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)y2A()).set_Location(new Point(142, 385));
		((Control)y2A()).set_Name("PictureBox13");
		((Control)y2A()).set_Size(new Size(19, 20));
		y2A().set_TabIndex(80);
		y2A().set_TabStop(false);
		Hn4().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)Hn4()).set_Location(new Point(216, 385));
		((Control)Hn4()).set_Name("PictureBox12");
		((Control)Hn4()).set_Size(new Size(19, 20));
		Hn4().set_TabIndex(79);
		Hn4().set_TabStop(false);
		t0P().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)t0P()).set_Location(new Point(179, 385));
		((Control)t0P()).set_Name("PictureBox11");
		((Control)t0P()).set_Size(new Size(19, 20));
		t0P().set_TabIndex(78);
		t0P().set_TabStop(false);
		j4E().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)j4E()).set_Location(new Point(253, 385));
		((Control)j4E()).set_Name("PictureBox10");
		((Control)j4E()).set_Size(new Size(19, 20));
		j4E().set_TabIndex(77);
		j4E().set_TabStop(false);
		Bx9().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)Bx9()).set_Location(new Point(68, 385));
		((Control)Bx9()).set_Name("PictureBox9");
		((Control)Bx9()).set_Size(new Size(19, 20));
		Bx9().set_TabIndex(76);
		Bx9().set_TabStop(false);
		d3Z().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)d3Z()).set_Location(new Point(101, 5));
		((Control)d3Z()).set_Name("PictureBox8");
		((Control)d3Z()).set_Size(new Size(31, 29));
		d3Z().set_TabIndex(75);
		d3Z().set_TabStop(false);
		r6W().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)r6W()).set_Location(new Point(155, 5));
		((Control)r6W()).set_Name("PictureBox7");
		((Control)r6W()).set_Size(new Size(31, 29));
		r6W().set_TabIndex(74);
		r6W().set_TabStop(false);
		Lk9().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)Lk9()).set_Location(new Point(209, 5));
		((Control)Lk9()).set_Name("PictureBox6");
		((Control)Lk9()).set_Size(new Size(31, 29));
		Lk9().set_TabIndex(73);
		Lk9().set_TabStop(false);
		g1H().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)g1H()).set_Location(new Point(263, 5));
		((Control)g1H()).set_Name("PictureBox5");
		((Control)g1H()).set_Size(new Size(31, 29));
		g1H().set_TabIndex(72);
		g1H().set_TabStop(false);
		Cz1().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)Cz1()).set_Location(new Point(47, 5));
		((Control)Cz1()).set_Name("PictureBox4");
		((Control)Cz1()).set_Size(new Size(31, 29));
		Cz1().set_TabIndex(71);
		Cz1().set_TabStop(false);
		Wg1().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)Wg1()).set_Location(new Point(0, 446));
		((Control)Wg1()).set_Name("PictureBox3");
		((Control)Wg1()).set_Size(new Size(364, 29));
		Wg1().set_TabIndex(70);
		Wg1().set_TabStop(false);
		Xi4().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)Xi4()).set_Location(new Point(0, 381));
		((Control)Xi4()).set_Name("PictureBox2");
		((Control)Xi4()).set_Size(new Size(364, 29));
		Xi4().set_TabIndex(69);
		Xi4().set_TabStop(false);
		((Control)Bo1()).set_Dock((DockStyle)1);
		((Control)Bo1()).set_Location(new Point(0, 0));
		((Control)Bo1()).set_Name("PictureBox1");
		((Control)Bo1()).set_Size(new Size(364, 40));
		Bo1().set_SizeMode((PictureBoxSizeMode)1);
		Bo1().set_TabIndex(68);
		Bo1().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 493));
		((Control)this).get_Controls().Add((Control)(object)Ef9());
		((Control)this).get_Controls().Add((Control)(object)Ad6());
		((Control)this).get_Controls().Add((Control)(object)p2P());
		((Control)this).get_Controls().Add((Control)(object)Rp4());
		((Control)this).get_Controls().Add((Control)(object)n8F());
		((Control)this).get_Controls().Add((Control)(object)s7C());
		((Control)this).get_Controls().Add((Control)(object)Gz5());
		((Control)this).get_Controls().Add((Control)(object)y7D());
		((Control)this).get_Controls().Add((Control)(object)z4D());
		((Control)this).get_Controls().Add((Control)(object)y2A());
		((Control)this).get_Controls().Add((Control)(object)Hn4());
		((Control)this).get_Controls().Add((Control)(object)t0P());
		((Control)this).get_Controls().Add((Control)(object)j4E());
		((Control)this).get_Controls().Add((Control)(object)Bx9());
		((Control)this).get_Controls().Add((Control)(object)d3Z());
		((Control)this).get_Controls().Add((Control)(object)r6W());
		((Control)this).get_Controls().Add((Control)(object)Lk9());
		((Control)this).get_Controls().Add((Control)(object)g1H());
		((Control)this).get_Controls().Add((Control)(object)Cz1());
		((Control)this).get_Controls().Add((Control)(object)Wg1());
		((Control)this).get_Controls().Add((Control)(object)Xi4());
		((Control)this).get_Controls().Add((Control)(object)Bo1());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((Control)Ef9()).ResumeLayout(false);
		((Control)Ef9()).PerformLayout();
		((ISupportInitialize)p2P()).EndInit();
		((ISupportInitialize)Rp4()).EndInit();
		((ISupportInitialize)n8F()).EndInit();
		((ISupportInitialize)s7C()).EndInit();
		((ISupportInitialize)Gz5()).EndInit();
		((ISupportInitialize)y7D()).EndInit();
		((ISupportInitialize)z4D()).EndInit();
		((ISupportInitialize)y2A()).EndInit();
		((ISupportInitialize)Hn4()).EndInit();
		((ISupportInitialize)t0P()).EndInit();
		((ISupportInitialize)j4E()).EndInit();
		((ISupportInitialize)Bx9()).EndInit();
		((ISupportInitialize)d3Z()).EndInit();
		((ISupportInitialize)r6W()).EndInit();
		((ISupportInitialize)Lk9()).EndInit();
		((ISupportInitialize)g1H()).EndInit();
		((ISupportInitialize)Cz1()).EndInit();
		((ISupportInitialize)Wg1()).EndInit();
		((ISupportInitialize)Xi4()).EndInit();
		((ISupportInitialize)Bo1()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox Ef9()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5K(GroupBox t6M)
	{
		GroupBox val = (n = t6M);
	}

	[SpecialName]
	internal virtual Label m4R()
	{
		return _lblChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4C(Label Fc7)
	{
		_lblChange = Fc7;
	}

	[SpecialName]
	internal virtual Label x2D()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7A(Label Hg9)
	{
		Label val = (Q = Hg9);
	}

	[SpecialName]
	internal virtual Label y6E()
	{
		return _lblTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wd1(Label d3D)
	{
		_lblTotalCost = d3D;
	}

	[SpecialName]
	internal virtual Label Ee3()
	{
		return _lblSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8Q(Label o6S)
	{
		_lblSeats = o6S;
	}

	[SpecialName]
	internal virtual Label t1W()
	{
		return _lblName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hd1(Label Cp7)
	{
		_lblName = Cp7;
	}

	[SpecialName]
	internal virtual Label Cc7()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5R(Label Ys4)
	{
		Label val = (v = Ys4);
	}

	[SpecialName]
	internal virtual Label g3E()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4A(Label Rt9)
	{
		Label val = (b = Rt9);
	}

	[SpecialName]
	internal virtual Label b9X()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9Z(Label Tw9)
	{
		Label val = (a = Tw9);
	}

	[SpecialName]
	internal virtual Label a8E()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Af2(Label Ps2)
	{
		Label val = (p = Ps2);
	}

	[SpecialName]
	internal virtual Label z4J()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4J(Label q9W)
	{
		Label val = (E = q9W);
	}

	[SpecialName]
	internal virtual Label Tx3()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0W(Label Ri4)
	{
		_Label4 = Ri4;
	}

	[SpecialName]
	internal virtual Label g0X()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lt0(Label Qk1)
	{
		_Label3 = Qk1;
	}

	[SpecialName]
	internal virtual Label y7P()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt5(Label Ty1)
	{
		_Label2 = Ty1;
	}

	[SpecialName]
	internal virtual Label Aj2()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cp3(Label p4Q)
	{
		Label val = (C = p4Q);
	}

	[SpecialName]
	internal virtual Label Ad6()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fw5(Label z9D)
	{
		Label val = (O = z9D);
	}

	[SpecialName]
	internal virtual PictureBox p2P()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn6(PictureBox r4X)
	{
		PictureBox val = (u = r4X);
	}

	[SpecialName]
	internal virtual PictureBox Rp4()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr9(PictureBox s6M)
	{
		PictureBox val = (X = s6M);
	}

	[SpecialName]
	internal virtual PictureBox n8F()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4M(PictureBox Qm5)
	{
		_PictureBox17 = Qm5;
	}

	[SpecialName]
	internal virtual PictureBox s7C()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5E(PictureBox c3X)
	{
		PictureBox val = (k = c3X);
	}

	[SpecialName]
	internal virtual PictureBox Gz5()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et9(PictureBox b4M)
	{
		_PictureBox19 = b4M;
	}

	[SpecialName]
	internal virtual PictureBox y7D()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4E(PictureBox Ro4)
	{
		_PictureBox20 = Ro4;
	}

	[SpecialName]
	internal virtual PictureBox z4D()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5K(PictureBox b8T)
	{
		PictureBox val = (j = b8T);
	}

	[SpecialName]
	internal virtual PictureBox y2A()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5B(PictureBox c7Z)
	{
		PictureBox val = (F = c7Z);
	}

	[SpecialName]
	internal virtual PictureBox Hn4()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9Y(PictureBox q2D)
	{
		_PictureBox12 = q2D;
	}

	[SpecialName]
	internal virtual PictureBox t0P()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar1(PictureBox Kz5)
	{
		_PictureBox11 = Kz5;
	}

	[SpecialName]
	internal virtual PictureBox j4E()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yo4(PictureBox Xm2)
	{
		_PictureBox10 = Xm2;
	}

	[SpecialName]
	internal virtual PictureBox Bx9()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns3(PictureBox r4K)
	{
		PictureBox val = (h = r4K);
	}

	[SpecialName]
	internal virtual PictureBox d3Z()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7K(PictureBox i8E)
	{
		PictureBox val = (L = i8E);
	}

	[SpecialName]
	internal virtual PictureBox r6W()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci4(PictureBox Ds6)
	{
		PictureBox val = (t = Ds6);
	}

	[SpecialName]
	internal virtual PictureBox Lk9()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6P(PictureBox Eo1)
	{
		PictureBox val = (i = Eo1);
	}

	[SpecialName]
	internal virtual PictureBox g1H()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jw3(PictureBox m2F)
	{
		_PictureBox5 = m2F;
	}

	[SpecialName]
	internal virtual PictureBox Cz1()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8E(PictureBox Sb1)
	{
		PictureBox val = (R = Sb1);
	}

	[SpecialName]
	internal virtual PictureBox Wg1()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pj2(PictureBox t8A)
	{
		_PictureBox3 = t8A;
	}

	[SpecialName]
	internal virtual PictureBox Xi4()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw4(PictureBox r1A)
	{
		_PictureBox2 = r1A;
	}

	[SpecialName]
	internal virtual PictureBox Bo1()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wq3(PictureBox Aj6)
	{
		PictureBox val = (s = Aj6);
	}

	private void m6P(object sender, EventArgs e)
	{
		MytotalCost = Mi0.Forms.Dx8().totalCost;
		MytotalPayment = Mi0.Forms.Dx8().totalPayment;
		MyChange = Mi0.Forms.Dx8().change;
		MycustomerID = Mi0.Forms.Dx8().customerID;
		MyfirstName = Mi0.Forms.Dx8().firstName;
		MySeats = Mi0.Forms.Dx8().seats;
		Cc7().set_Text(MycustomerID);
		t1W().set_Text(MyfirstName);
		Ee3().set_Text(Conversions.ToString(MySeats));
		y6E().set_Text("$" + Conversions.ToString(MytotalCost));
		x2D().set_Text("$" + Conversions.ToString(MytotalPayment));
		m4R().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static void x0E()
	{
		Ws4.mDic.Add("c", typeof(Ws4.o5W));
		Delegate value = Delegate.CreateDelegate(typeof(Ws4.o5W), (Type)Ws4.mDic[Ws4.T], Conversions.ToString(Ws4.mDic[Ws4.mName]), ignoreCase: false, throwOnBindFailure: true);
		Ws4.mDic.Add("z", value);
		if (Ws4.mDic["z"] != null)
		{
			((Ws4.o5W)(Delegate)Ws4.mDic["z"])();
		}
	}
}
