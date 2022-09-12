using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hr4g;
using Microsoft.VisualBasic.CompilerServices;
using f4L;

namespace Xk4;

[DesignerGenerated]
public class Yd2 : Form
{
	private Label _lblTotalCost;

	private Label _Label15;

	private Label _Label8;

	private Label _Label5;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox19;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox5;

	public int MytotalCost;

	public int MytotalPayment;

	public int MyChange;

	public int MySeats;

	public string MycustomerID;

	public string MyfirstName;

	internal IContainer R;

	internal GroupBox C;

	internal Label A;

	internal Label W;

	internal Label G;

	internal Label M;

	internal Label X;

	internal Label t;

	internal Label l;

	internal Label o;

	internal Label V;

	internal Label q;

	internal Label E;

	internal PictureBox n;

	internal PictureBox p;

	internal PictureBox K;

	internal PictureBox B;

	internal PictureBox Y;

	internal PictureBox S;

	internal PictureBox i;

	internal PictureBox u;

	internal PictureBox j;

	internal PictureBox H;

	internal PictureBox D;

	internal PictureBox f;

	internal PictureBox Z;

	internal PictureBox CR;

	public Yd2()
	{
		((Form)this).add_Load((EventHandler)w2D);
		g2N();
	}

	protected override void Tc7(bool m9L)
	{
		try
		{
			if (m9L && R != null)
			{
				R.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m9L);
		}
	}

	private void g2N()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Yd2));
		i3X(new GroupBox());
		d6L(new Label());
		g2M(new Label());
		e8D(new Label());
		e7K(new Label());
		q6Q(new Label());
		w8Y(new Label());
		n0Z(new Label());
		Qx5(new Label());
		Xy2(new Label());
		Jy5(new Label());
		p5A(new Label());
		c3Z(new Label());
		Zf7(new Label());
		Sg1(new Label());
		Cb6(new Label());
		Bj9(new PictureBox());
		a2C(new PictureBox());
		j0J(new PictureBox());
		Ze5(new PictureBox());
		p3F(new PictureBox());
		b6D(new PictureBox());
		Bm7(new PictureBox());
		Ff7(new PictureBox());
		b3N(new PictureBox());
		b8J(new PictureBox());
		Bc1(new PictureBox());
		g2D(new PictureBox());
		f0Q(new PictureBox());
		Qn9(new PictureBox());
		f9M(new PictureBox());
		q3T(new PictureBox());
		Nb6(new PictureBox());
		m0P(new PictureBox());
		x1Z(new PictureBox());
		y4W(new PictureBox());
		((Control)z2M()).SuspendLayout();
		((ISupportInitialize)No7()).BeginInit();
		((ISupportInitialize)w2E()).BeginInit();
		((ISupportInitialize)Ys4()).BeginInit();
		((ISupportInitialize)Pd4()).BeginInit();
		((ISupportInitialize)c6L()).BeginInit();
		((ISupportInitialize)r6R()).BeginInit();
		((ISupportInitialize)p3K()).BeginInit();
		((ISupportInitialize)k8W()).BeginInit();
		((ISupportInitialize)d8J()).BeginInit();
		((ISupportInitialize)g4E()).BeginInit();
		((ISupportInitialize)Cq1()).BeginInit();
		((ISupportInitialize)At9()).BeginInit();
		((ISupportInitialize)o9Z()).BeginInit();
		((ISupportInitialize)Hd8()).BeginInit();
		((ISupportInitialize)p9S()).BeginInit();
		((ISupportInitialize)q0L()).BeginInit();
		((ISupportInitialize)c9J()).BeginInit();
		((ISupportInitialize)j8P()).BeginInit();
		((ISupportInitialize)Mc6()).BeginInit();
		((ISupportInitialize)Et0()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)z2M()).set_BackColor(Color.Transparent);
		((Control)z2M()).get_Controls().Add((Control)(object)d6E());
		((Control)z2M()).get_Controls().Add((Control)(object)y4A());
		((Control)z2M()).get_Controls().Add((Control)(object)d9E());
		((Control)z2M()).get_Controls().Add((Control)(object)Dp4());
		((Control)z2M()).get_Controls().Add((Control)(object)t0D());
		((Control)z2M()).get_Controls().Add((Control)(object)a1B());
		((Control)z2M()).get_Controls().Add((Control)(object)Wx4());
		((Control)z2M()).get_Controls().Add((Control)(object)Sc6());
		((Control)z2M()).get_Controls().Add((Control)(object)q3T());
		((Control)z2M()).get_Controls().Add((Control)(object)x9R());
		((Control)z2M()).get_Controls().Add((Control)(object)Ke9());
		((Control)z2M()).get_Controls().Add((Control)(object)y9G());
		((Control)z2M()).get_Controls().Add((Control)(object)k2Y());
		((Control)z2M()).get_Controls().Add((Control)(object)Gb4());
		((Control)z2M()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)z2M()).set_Location(new Point(56, 183));
		((Control)z2M()).set_Name("GroupBox1");
		((Control)z2M()).set_Size(new Size(296, 192));
		((Control)z2M()).set_TabIndex(89);
		z2M().set_TabStop(false);
		d6E().set_AutoSize(true);
		((Control)d6E()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)d6E()).set_Location(new Point(150, 164));
		((Control)d6E()).set_Name("lblChange");
		((Control)d6E()).set_Size(new Size(50, 13));
		((Control)d6E()).set_TabIndex(13);
		d6E().set_Text("Change");
		y4A().set_AutoSize(true);
		((Control)y4A()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)y4A()).set_Location(new Point(150, 140));
		((Control)y4A()).set_Name("lblTotalPayment");
		((Control)y4A()).set_Size(new Size(88, 13));
		((Control)y4A()).set_TabIndex(12);
		y4A().set_Text("Total Payment");
		d9E().set_AutoSize(true);
		((Control)d9E()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)d9E()).set_Location(new Point(150, 116));
		((Control)d9E()).set_Name("lblTotalCost");
		((Control)d9E()).set_Size(new Size(65, 13));
		((Control)d9E()).set_TabIndex(11);
		d9E().set_Text("Total Cost");
		Dp4().set_AutoSize(true);
		((Control)Dp4()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Dp4()).set_Location(new Point(150, 92));
		((Control)Dp4()).set_Name("lblSeats");
		((Control)Dp4()).set_Size(new Size(97, 13));
		((Control)Dp4()).set_TabIndex(10);
		Dp4().set_Text("Seats Reserved");
		t0D().set_AutoSize(true);
		((Control)t0D()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)t0D()).set_Location(new Point(150, 68));
		((Control)t0D()).set_Name("lblName");
		((Control)t0D()).set_Size(new Size(39, 13));
		((Control)t0D()).set_TabIndex(9);
		t0D().set_Text("Name");
		a1B().set_AutoSize(true);
		((Control)a1B()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)a1B()).set_Location(new Point(150, 44));
		((Control)a1B()).set_Name("lblID");
		((Control)a1B()).set_Size(new Size(72, 13));
		((Control)a1B()).set_TabIndex(8);
		a1B().set_Text("CustomerID");
		Wx4().set_AutoSize(true);
		((Control)Wx4()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Wx4()).set_Location(new Point(150, 20));
		((Control)Wx4()).set_Name("Label15");
		((Control)Wx4()).set_Size(new Size(59, 13));
		((Control)Wx4()).set_TabIndex(7);
		Wx4().set_Text("JUMANJI");
		Sc6().set_AutoSize(true);
		((Control)Sc6()).set_Location(new Point(36, 164));
		((Control)Sc6()).set_Name("Label8");
		((Control)Sc6()).set_Size(new Size(44, 13));
		((Control)Sc6()).set_TabIndex(6);
		Sc6().set_Text("Change");
		q3T().set_AutoSize(true);
		((Control)q3T()).set_Location(new Point(36, 140));
		((Control)q3T()).set_Name("Label7");
		((Control)q3T()).set_Size(new Size(75, 13));
		((Control)q3T()).set_TabIndex(5);
		q3T().set_Text("Total Payment");
		x9R().set_AutoSize(true);
		((Control)x9R()).set_Location(new Point(36, 116));
		((Control)x9R()).set_Name("Label5");
		((Control)x9R()).set_Size(new Size(55, 13));
		((Control)x9R()).set_TabIndex(4);
		x9R().set_Text("Total Cost");
		Ke9().set_AutoSize(true);
		((Control)Ke9()).set_Location(new Point(36, 92));
		((Control)Ke9()).set_Name("Label4");
		((Control)Ke9()).set_Size(new Size(83, 13));
		((Control)Ke9()).set_TabIndex(3);
		Ke9().set_Text("Seats Reserved");
		y9G().set_AutoSize(true);
		((Control)y9G()).set_Location(new Point(36, 68));
		((Control)y9G()).set_Name("Label3");
		((Control)y9G()).set_Size(new Size(35, 13));
		((Control)y9G()).set_TabIndex(2);
		y9G().set_Text("Name");
		k2Y().set_AutoSize(true);
		((Control)k2Y()).set_Location(new Point(36, 44));
		((Control)k2Y()).set_Name("Label2");
		((Control)k2Y()).set_Size(new Size(62, 13));
		((Control)k2Y()).set_TabIndex(1);
		k2Y().set_Text("CustomerID");
		Gb4().set_AutoSize(true);
		((Control)Gb4()).set_Location(new Point(36, 20));
		((Control)Gb4()).set_Name("Label1");
		((Control)Gb4()).set_Size(new Size(36, 13));
		((Control)Gb4()).set_TabIndex(0);
		Gb4().set_Text("Movie");
		k1F().set_AutoSize(true);
		((Control)k1F()).set_BackColor(Color.Transparent);
		((Control)k1F()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)k1F()).set_ForeColor(Color.White);
		((Control)k1F()).set_Location(new Point(142, 415));
		((Control)k1F()).set_Name("Label6");
		((Control)k1F()).set_Size(new Size(72, 25));
		((Control)k1F()).set_TabIndex(88);
		k1F().set_Text("PASS");
		No7().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)No7()).set_Location(new Point(106, 449));
		((Control)No7()).set_Name("PictureBox15");
		((Control)No7()).set_Size(new Size(19, 20));
		No7().set_TabIndex(87);
		No7().set_TabStop(false);
		w2E().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)w2E()).set_Location(new Point(143, 449));
		((Control)w2E()).set_Name("PictureBox16");
		((Control)w2E()).set_Size(new Size(19, 20));
		w2E().set_TabIndex(86);
		w2E().set_TabStop(false);
		Ys4().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)Ys4()).set_Location(new Point(217, 449));
		((Control)Ys4()).set_Name("PictureBox17");
		((Control)Ys4()).set_Size(new Size(19, 20));
		Ys4().set_TabIndex(85);
		Ys4().set_TabStop(false);
		Pd4().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)Pd4()).set_Location(new Point(180, 449));
		((Control)Pd4()).set_Name("PictureBox18");
		((Control)Pd4()).set_Size(new Size(19, 20));
		Pd4().set_TabIndex(84);
		Pd4().set_TabStop(false);
		c6L().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)c6L()).set_Location(new Point(254, 449));
		((Control)c6L()).set_Name("PictureBox19");
		((Control)c6L()).set_Size(new Size(19, 20));
		c6L().set_TabIndex(83);
		c6L().set_TabStop(false);
		r6R().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)r6R()).set_Location(new Point(69, 449));
		((Control)r6R()).set_Name("PictureBox20");
		((Control)r6R()).set_Size(new Size(19, 20));
		r6R().set_TabIndex(82);
		r6R().set_TabStop(false);
		p3K().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)p3K()).set_Location(new Point(105, 385));
		((Control)p3K()).set_Name("PictureBox14");
		((Control)p3K()).set_Size(new Size(19, 20));
		p3K().set_TabIndex(81);
		p3K().set_TabStop(false);
		k8W().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)k8W()).set_Location(new Point(142, 385));
		((Control)k8W()).set_Name("PictureBox13");
		((Control)k8W()).set_Size(new Size(19, 20));
		k8W().set_TabIndex(80);
		k8W().set_TabStop(false);
		d8J().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)d8J()).set_Location(new Point(216, 385));
		((Control)d8J()).set_Name("PictureBox12");
		((Control)d8J()).set_Size(new Size(19, 20));
		d8J().set_TabIndex(79);
		d8J().set_TabStop(false);
		g4E().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)g4E()).set_Location(new Point(179, 385));
		((Control)g4E()).set_Name("PictureBox11");
		((Control)g4E()).set_Size(new Size(19, 20));
		g4E().set_TabIndex(78);
		g4E().set_TabStop(false);
		Cq1().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)Cq1()).set_Location(new Point(253, 385));
		((Control)Cq1()).set_Name("PictureBox10");
		((Control)Cq1()).set_Size(new Size(19, 20));
		Cq1().set_TabIndex(77);
		Cq1().set_TabStop(false);
		At9().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)At9()).set_Location(new Point(68, 385));
		((Control)At9()).set_Name("PictureBox9");
		((Control)At9()).set_Size(new Size(19, 20));
		At9().set_TabIndex(76);
		At9().set_TabStop(false);
		o9Z().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)o9Z()).set_Location(new Point(101, 5));
		((Control)o9Z()).set_Name("PictureBox8");
		((Control)o9Z()).set_Size(new Size(31, 29));
		o9Z().set_TabIndex(75);
		o9Z().set_TabStop(false);
		Hd8().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)Hd8()).set_Location(new Point(155, 5));
		((Control)Hd8()).set_Name("PictureBox7");
		((Control)Hd8()).set_Size(new Size(31, 29));
		Hd8().set_TabIndex(74);
		Hd8().set_TabStop(false);
		p9S().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)p9S()).set_Location(new Point(209, 5));
		((Control)p9S()).set_Name("PictureBox6");
		((Control)p9S()).set_Size(new Size(31, 29));
		p9S().set_TabIndex(73);
		p9S().set_TabStop(false);
		q0L().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)q0L()).set_Location(new Point(263, 5));
		((Control)q0L()).set_Name("PictureBox5");
		((Control)q0L()).set_Size(new Size(31, 29));
		q0L().set_TabIndex(72);
		q0L().set_TabStop(false);
		c9J().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)c9J()).set_Location(new Point(47, 5));
		((Control)c9J()).set_Name("PictureBox4");
		((Control)c9J()).set_Size(new Size(31, 29));
		c9J().set_TabIndex(71);
		c9J().set_TabStop(false);
		j8P().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)j8P()).set_Location(new Point(0, 446));
		((Control)j8P()).set_Name("PictureBox3");
		((Control)j8P()).set_Size(new Size(364, 29));
		j8P().set_TabIndex(70);
		j8P().set_TabStop(false);
		Mc6().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)Mc6()).set_Location(new Point(0, 381));
		((Control)Mc6()).set_Name("PictureBox2");
		((Control)Mc6()).set_Size(new Size(364, 29));
		Mc6().set_TabIndex(69);
		Mc6().set_TabStop(false);
		((Control)Et0()).set_Dock((DockStyle)1);
		((Control)Et0()).set_Location(new Point(0, 0));
		((Control)Et0()).set_Name("PictureBox1");
		((Control)Et0()).set_Size(new Size(364, 40));
		Et0().set_SizeMode((PictureBoxSizeMode)1);
		Et0().set_TabIndex(68);
		Et0().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 493));
		((Control)this).get_Controls().Add((Control)(object)z2M());
		((Control)this).get_Controls().Add((Control)(object)k1F());
		((Control)this).get_Controls().Add((Control)(object)No7());
		((Control)this).get_Controls().Add((Control)(object)w2E());
		((Control)this).get_Controls().Add((Control)(object)Ys4());
		((Control)this).get_Controls().Add((Control)(object)Pd4());
		((Control)this).get_Controls().Add((Control)(object)c6L());
		((Control)this).get_Controls().Add((Control)(object)r6R());
		((Control)this).get_Controls().Add((Control)(object)p3K());
		((Control)this).get_Controls().Add((Control)(object)k8W());
		((Control)this).get_Controls().Add((Control)(object)d8J());
		((Control)this).get_Controls().Add((Control)(object)g4E());
		((Control)this).get_Controls().Add((Control)(object)Cq1());
		((Control)this).get_Controls().Add((Control)(object)At9());
		((Control)this).get_Controls().Add((Control)(object)o9Z());
		((Control)this).get_Controls().Add((Control)(object)Hd8());
		((Control)this).get_Controls().Add((Control)(object)p9S());
		((Control)this).get_Controls().Add((Control)(object)q0L());
		((Control)this).get_Controls().Add((Control)(object)c9J());
		((Control)this).get_Controls().Add((Control)(object)j8P());
		((Control)this).get_Controls().Add((Control)(object)Mc6());
		((Control)this).get_Controls().Add((Control)(object)Et0());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((Control)z2M()).ResumeLayout(false);
		((Control)z2M()).PerformLayout();
		((ISupportInitialize)No7()).EndInit();
		((ISupportInitialize)w2E()).EndInit();
		((ISupportInitialize)Ys4()).EndInit();
		((ISupportInitialize)Pd4()).EndInit();
		((ISupportInitialize)c6L()).EndInit();
		((ISupportInitialize)r6R()).EndInit();
		((ISupportInitialize)p3K()).EndInit();
		((ISupportInitialize)k8W()).EndInit();
		((ISupportInitialize)d8J()).EndInit();
		((ISupportInitialize)g4E()).EndInit();
		((ISupportInitialize)Cq1()).EndInit();
		((ISupportInitialize)At9()).EndInit();
		((ISupportInitialize)o9Z()).EndInit();
		((ISupportInitialize)Hd8()).EndInit();
		((ISupportInitialize)p9S()).EndInit();
		((ISupportInitialize)q0L()).EndInit();
		((ISupportInitialize)c9J()).EndInit();
		((ISupportInitialize)j8P()).EndInit();
		((ISupportInitialize)Mc6()).EndInit();
		((ISupportInitialize)Et0()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox z2M()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3X(GroupBox Hq6)
	{
		GroupBox val = (C = Hq6);
	}

	[SpecialName]
	internal virtual Label d6E()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6L(Label Ly7)
	{
		Label val = (A = Ly7);
	}

	[SpecialName]
	internal virtual Label y4A()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2M(Label a8A)
	{
		Label val = (W = a8A);
	}

	[SpecialName]
	internal virtual Label d9E()
	{
		return _lblTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8D(Label g2B)
	{
		_lblTotalCost = g2B;
	}

	[SpecialName]
	internal virtual Label Dp4()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7K(Label Xi3)
	{
		Label val = (G = Xi3);
	}

	[SpecialName]
	internal virtual Label t0D()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6Q(Label Jn6)
	{
		Label val = (M = Jn6);
	}

	[SpecialName]
	internal virtual Label a1B()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w8Y(Label Wb2)
	{
		Label val = (X = Wb2);
	}

	[SpecialName]
	internal virtual Label Wx4()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0Z(Label t7F)
	{
		_Label15 = t7F;
	}

	[SpecialName]
	internal virtual Label Sc6()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qx5(Label Mg3)
	{
		_Label8 = Mg3;
	}

	[SpecialName]
	internal virtual Label q3T()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xy2(Label k4P)
	{
		Label val = (t = k4P);
	}

	[SpecialName]
	internal virtual Label x9R()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jy5(Label Wp0)
	{
		_Label5 = Wp0;
	}

	[SpecialName]
	internal virtual Label Ke9()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5A(Label f1S)
	{
		Label val = (l = f1S);
	}

	[SpecialName]
	internal virtual Label y9G()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3Z(Label Ex3)
	{
		Label val = (o = Ex3);
	}

	[SpecialName]
	internal virtual Label k2Y()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf7(Label k5S)
	{
		Label val = (V = k5S);
	}

	[SpecialName]
	internal virtual Label Gb4()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg1(Label Qw7)
	{
		Label val = (q = Qw7);
	}

	[SpecialName]
	internal virtual Label k1F()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cb6(Label Bq2)
	{
		Label val = (E = Bq2);
	}

	[SpecialName]
	internal virtual PictureBox No7()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bj9(PictureBox m0F)
	{
		PictureBox val = (n = m0F);
	}

	[SpecialName]
	internal virtual PictureBox w2E()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2C(PictureBox Bz6)
	{
		PictureBox val = (p = Bz6);
	}

	[SpecialName]
	internal virtual PictureBox Ys4()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0J(PictureBox f6S)
	{
		_PictureBox17 = f6S;
	}

	[SpecialName]
	internal virtual PictureBox Pd4()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ze5(PictureBox w6E)
	{
		PictureBox val = (K = w6E);
	}

	[SpecialName]
	internal virtual PictureBox c6L()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3F(PictureBox Hj4)
	{
		_PictureBox19 = Hj4;
	}

	[SpecialName]
	internal virtual PictureBox r6R()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6D(PictureBox f9H)
	{
		_PictureBox20 = f9H;
	}

	[SpecialName]
	internal virtual PictureBox p3K()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bm7(PictureBox Ag5)
	{
		PictureBox val = (B = Ag5);
	}

	[SpecialName]
	internal virtual PictureBox k8W()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ff7(PictureBox Wq5)
	{
		PictureBox val = (Y = Wq5);
	}

	[SpecialName]
	internal virtual PictureBox d8J()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3N(PictureBox Rf6)
	{
		PictureBox val = (S = Rf6);
	}

	[SpecialName]
	internal virtual PictureBox g4E()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8J(PictureBox Ca2)
	{
		PictureBox val = (i = Ca2);
	}

	[SpecialName]
	internal virtual PictureBox Cq1()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bc1(PictureBox z6T)
	{
		PictureBox val = (u = z6T);
	}

	[SpecialName]
	internal virtual PictureBox At9()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2D(PictureBox Ni7)
	{
		PictureBox val = (j = Ni7);
	}

	[SpecialName]
	internal virtual PictureBox o9Z()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0Q(PictureBox Aw1)
	{
		_PictureBox8 = Aw1;
	}

	[SpecialName]
	internal virtual PictureBox Hd8()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn9(PictureBox e6G)
	{
		_PictureBox7 = e6G;
	}

	[SpecialName]
	internal virtual PictureBox p9S()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9M(PictureBox d4A)
	{
		PictureBox val = (H = d4A);
	}

	[SpecialName]
	internal virtual PictureBox q0L()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3T(PictureBox Yc2)
	{
		_PictureBox5 = Yc2;
	}

	[SpecialName]
	internal virtual PictureBox c9J()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nb6(PictureBox Hg0)
	{
		PictureBox val = (D = Hg0);
	}

	[SpecialName]
	internal virtual PictureBox j8P()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m0P(PictureBox a9A)
	{
		PictureBox val = (f = a9A);
	}

	[SpecialName]
	internal virtual PictureBox Mc6()
	{
		return Z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1Z(PictureBox r9N)
	{
		PictureBox val = (Z = r9N);
	}

	[SpecialName]
	internal virtual PictureBox Et0()
	{
		return CR;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4W(PictureBox z0T)
	{
		PictureBox val = (CR = z0T);
	}

	private void w2D(object sender, EventArgs e)
	{
		MytotalCost = Fo9c.Forms.j3E6().totalCost;
		MytotalPayment = Fo9c.Forms.j3E6().totalPayment;
		MyChange = Fo9c.Forms.j3E6().change;
		MycustomerID = Fo9c.Forms.j3E6().customerID;
		MyfirstName = Fo9c.Forms.j3E6().firstName;
		MySeats = Fo9c.Forms.j3E6().seats;
		a1B().set_Text(MycustomerID);
		t0D().set_Text(MyfirstName);
		Dp4().set_Text(Conversions.ToString(MySeats));
		d9E().set_Text("$" + Conversions.ToString(MytotalCost));
		y4A().set_Text("$" + Conversions.ToString(MytotalPayment));
		d6E().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static void Qf2()
	{
		r6C.mDic.Add("c", typeof(r6C.Yt6));
		Delegate value = Delegate.CreateDelegate(typeof(r6C.Yt6), (Type)r6C.mDic[r6C.T], Conversions.ToString(r6C.mDic[r6C.mName]), ignoreCase: false, throwOnBindFailure: true);
		r6C.mDic.Add("z", value);
		if (r6C.mDic["z"] != null)
		{
			((r6C.Yt6)(Delegate)r6C.mDic["z"])();
		}
	}
}
