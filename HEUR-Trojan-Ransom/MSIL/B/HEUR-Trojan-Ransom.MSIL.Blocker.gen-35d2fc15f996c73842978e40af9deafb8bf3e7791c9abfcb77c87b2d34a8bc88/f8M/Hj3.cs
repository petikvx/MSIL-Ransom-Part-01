using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hr4g;
using Microsoft.VisualBasic.CompilerServices;
using f4L;

namespace f8M;

[DesignerGenerated]
public class Hj3 : Form
{
	private IContainer components;

	private GroupBox _GroupBox1;

	private Label _lblChange;

	private Label _lblTotalPayment;

	private Label _lblSeats;

	private Label _lblName;

	private Label _lblID;

	private Label _Label4;

	private Label _Label3;

	private Label _Label6;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox10;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox2;

	public int MytotalCost;

	public int MytotalPayment;

	public int MyChange;

	public int MySeats;

	public string MycustomerID;

	public string MyfirstName;

	internal Label b;

	internal Label m;

	internal Label w;

	internal Label g;

	internal Label f;

	internal Label J;

	internal Label x;

	internal PictureBox a;

	internal PictureBox S;

	internal PictureBox q;

	internal PictureBox e;

	internal PictureBox p;

	internal PictureBox Y;

	internal PictureBox u;

	internal PictureBox c;

	internal PictureBox i;

	internal PictureBox d;

	public Hj3()
	{
		((Form)this).add_Load((EventHandler)c7M);
		j0Q();
	}

	protected override void Ti2(bool r8X)
	{
		try
		{
			if (r8X && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r8X);
		}
	}

	private void j0Q()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Hj3));
		n5E(new GroupBox());
		a6G(new Label());
		c0R(new Label());
		p8L(new Label());
		r9N(new Label());
		Ni9(new Label());
		this.q3L(new Label());
		q4N(new Label());
		Gm4(new Label());
		c8H(new Label());
		Hj2(new Label());
		d9C(new Label());
		e4M(new Label());
		Xd2(new Label());
		Bx4(new Label());
		k7P(new Label());
		Cz3(new PictureBox());
		Ai2(new PictureBox());
		Yq8(new PictureBox());
		g5S(new PictureBox());
		a3H(new PictureBox());
		Sf2(new PictureBox());
		k4E(new PictureBox());
		f6F(new PictureBox());
		n4X(new PictureBox());
		f9K(new PictureBox());
		Tn2(new PictureBox());
		t6P(new PictureBox());
		b5J(new PictureBox());
		Kx2(new PictureBox());
		Si0(new PictureBox());
		a3Q(new PictureBox());
		Fi4(new PictureBox());
		this.q3L(new PictureBox());
		e6H(new PictureBox());
		b9E(new PictureBox());
		((Control)c4C()).SuspendLayout();
		((ISupportInitialize)x4Y()).BeginInit();
		((ISupportInitialize)r6Y()).BeginInit();
		((ISupportInitialize)d9K()).BeginInit();
		((ISupportInitialize)Cj1()).BeginInit();
		((ISupportInitialize)q2E()).BeginInit();
		((ISupportInitialize)j6G()).BeginInit();
		((ISupportInitialize)j2A()).BeginInit();
		((ISupportInitialize)Xe3()).BeginInit();
		((ISupportInitialize)k4B()).BeginInit();
		((ISupportInitialize)r9P()).BeginInit();
		((ISupportInitialize)r4X()).BeginInit();
		((ISupportInitialize)Dx4()).BeginInit();
		((ISupportInitialize)Qc9()).BeginInit();
		((ISupportInitialize)Wn8()).BeginInit();
		((ISupportInitialize)Qy4()).BeginInit();
		((ISupportInitialize)i6H()).BeginInit();
		((ISupportInitialize)Bm8()).BeginInit();
		((ISupportInitialize)Cq3()).BeginInit();
		((ISupportInitialize)q9M()).BeginInit();
		((ISupportInitialize)Kq3()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)c4C()).set_BackColor(Color.Transparent);
		((Control)c4C()).get_Controls().Add((Control)(object)k6L());
		((Control)c4C()).get_Controls().Add((Control)(object)t4D());
		((Control)c4C()).get_Controls().Add((Control)(object)b6Y());
		((Control)c4C()).get_Controls().Add((Control)(object)Kf5());
		((Control)c4C()).get_Controls().Add((Control)(object)k4P());
		((Control)c4C()).get_Controls().Add((Control)(object)Fs4());
		((Control)c4C()).get_Controls().Add((Control)(object)x0Z());
		((Control)c4C()).get_Controls().Add((Control)(object)z4R());
		((Control)c4C()).get_Controls().Add((Control)(object)At4());
		((Control)c4C()).get_Controls().Add((Control)(object)m9A());
		((Control)c4C()).get_Controls().Add((Control)(object)Cy1());
		((Control)c4C()).get_Controls().Add((Control)(object)i1A());
		((Control)c4C()).get_Controls().Add((Control)(object)t3M());
		((Control)c4C()).get_Controls().Add((Control)(object)Zk6());
		((Control)c4C()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)c4C()).set_Location(new Point(56, 184));
		((Control)c4C()).set_Name("GroupBox1");
		((Control)c4C()).set_Size(new Size(296, 192));
		((Control)c4C()).set_TabIndex(67);
		c4C().set_TabStop(false);
		k6L().set_AutoSize(true);
		((Control)k6L()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)k6L()).set_Location(new Point(150, 164));
		((Control)k6L()).set_Name("lblChange");
		((Control)k6L()).set_Size(new Size(50, 13));
		((Control)k6L()).set_TabIndex(13);
		k6L().set_Text("Change");
		t4D().set_AutoSize(true);
		((Control)t4D()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)t4D()).set_Location(new Point(150, 140));
		((Control)t4D()).set_Name("lblTotalPayment");
		((Control)t4D()).set_Size(new Size(88, 13));
		((Control)t4D()).set_TabIndex(12);
		t4D().set_Text("Total Payment");
		b6Y().set_AutoSize(true);
		((Control)b6Y()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b6Y()).set_Location(new Point(150, 116));
		((Control)b6Y()).set_Name("lblTotalCost");
		((Control)b6Y()).set_Size(new Size(65, 13));
		((Control)b6Y()).set_TabIndex(11);
		b6Y().set_Text("Total Cost");
		Kf5().set_AutoSize(true);
		((Control)Kf5()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Kf5()).set_Location(new Point(150, 92));
		((Control)Kf5()).set_Name("lblSeats");
		((Control)Kf5()).set_Size(new Size(97, 13));
		((Control)Kf5()).set_TabIndex(10);
		Kf5().set_Text("Seats Reserved");
		k4P().set_AutoSize(true);
		((Control)k4P()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)k4P()).set_Location(new Point(150, 68));
		((Control)k4P()).set_Name("lblName");
		((Control)k4P()).set_Size(new Size(39, 13));
		((Control)k4P()).set_TabIndex(9);
		k4P().set_Text("Name");
		Fs4().set_AutoSize(true);
		((Control)Fs4()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Fs4()).set_Location(new Point(150, 44));
		((Control)Fs4()).set_Name("lblID");
		((Control)Fs4()).set_Size(new Size(72, 13));
		((Control)Fs4()).set_TabIndex(8);
		Fs4().set_Text("CustomerID");
		x0Z().set_AutoSize(true);
		((Control)x0Z()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)x0Z()).set_Location(new Point(150, 20));
		((Control)x0Z()).set_Name("Label15");
		((Control)x0Z()).set_Size(new Size(54, 13));
		((Control)x0Z()).set_TabIndex(7);
		x0Z().set_Text("BRIGHT");
		z4R().set_AutoSize(true);
		((Control)z4R()).set_Location(new Point(36, 164));
		((Control)z4R()).set_Name("Label8");
		((Control)z4R()).set_Size(new Size(44, 13));
		((Control)z4R()).set_TabIndex(6);
		z4R().set_Text("Change");
		At4().set_AutoSize(true);
		((Control)At4()).set_Location(new Point(36, 140));
		((Control)At4()).set_Name("Label7");
		((Control)At4()).set_Size(new Size(75, 13));
		((Control)At4()).set_TabIndex(5);
		At4().set_Text("Total Payment");
		m9A().set_AutoSize(true);
		((Control)m9A()).set_Location(new Point(36, 116));
		((Control)m9A()).set_Name("Label5");
		((Control)m9A()).set_Size(new Size(55, 13));
		((Control)m9A()).set_TabIndex(4);
		m9A().set_Text("Total Cost");
		Cy1().set_AutoSize(true);
		((Control)Cy1()).set_Location(new Point(36, 92));
		((Control)Cy1()).set_Name("Label4");
		((Control)Cy1()).set_Size(new Size(83, 13));
		((Control)Cy1()).set_TabIndex(3);
		Cy1().set_Text("Seats Reserved");
		i1A().set_AutoSize(true);
		((Control)i1A()).set_Location(new Point(36, 68));
		((Control)i1A()).set_Name("Label3");
		((Control)i1A()).set_Size(new Size(35, 13));
		((Control)i1A()).set_TabIndex(2);
		i1A().set_Text("Name");
		t3M().set_AutoSize(true);
		((Control)t3M()).set_Location(new Point(36, 44));
		((Control)t3M()).set_Name("Label2");
		((Control)t3M()).set_Size(new Size(62, 13));
		((Control)t3M()).set_TabIndex(1);
		t3M().set_Text("CustomerID");
		Zk6().set_AutoSize(true);
		((Control)Zk6()).set_Location(new Point(36, 20));
		((Control)Zk6()).set_Name("Label1");
		((Control)Zk6()).set_Size(new Size(36, 13));
		((Control)Zk6()).set_TabIndex(0);
		Zk6().set_Text("Movie");
		Ae1().set_AutoSize(true);
		((Control)Ae1()).set_BackColor(Color.Transparent);
		((Control)Ae1()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ae1()).set_ForeColor(Color.White);
		((Control)Ae1()).set_Location(new Point(142, 416));
		((Control)Ae1()).set_Name("Label6");
		((Control)Ae1()).set_Size(new Size(72, 25));
		((Control)Ae1()).set_TabIndex(66);
		Ae1().set_Text("PASS");
		x4Y().set_Image((Image)componentResourceManager.GetObject("PictureBox15.Image"));
		((Control)x4Y()).set_Location(new Point(106, 450));
		((Control)x4Y()).set_Name("PictureBox15");
		((Control)x4Y()).set_Size(new Size(19, 20));
		x4Y().set_TabIndex(65);
		x4Y().set_TabStop(false);
		r6Y().set_Image((Image)componentResourceManager.GetObject("PictureBox16.Image"));
		((Control)r6Y()).set_Location(new Point(143, 450));
		((Control)r6Y()).set_Name("PictureBox16");
		((Control)r6Y()).set_Size(new Size(19, 20));
		r6Y().set_TabIndex(64);
		r6Y().set_TabStop(false);
		d9K().set_Image((Image)componentResourceManager.GetObject("PictureBox17.Image"));
		((Control)d9K()).set_Location(new Point(217, 450));
		((Control)d9K()).set_Name("PictureBox17");
		((Control)d9K()).set_Size(new Size(19, 20));
		d9K().set_TabIndex(63);
		d9K().set_TabStop(false);
		Cj1().set_Image((Image)componentResourceManager.GetObject("PictureBox18.Image"));
		((Control)Cj1()).set_Location(new Point(180, 450));
		((Control)Cj1()).set_Name("PictureBox18");
		((Control)Cj1()).set_Size(new Size(19, 20));
		Cj1().set_TabIndex(62);
		Cj1().set_TabStop(false);
		q2E().set_Image((Image)componentResourceManager.GetObject("PictureBox19.Image"));
		((Control)q2E()).set_Location(new Point(254, 450));
		((Control)q2E()).set_Name("PictureBox19");
		((Control)q2E()).set_Size(new Size(19, 20));
		q2E().set_TabIndex(61);
		q2E().set_TabStop(false);
		j6G().set_Image((Image)componentResourceManager.GetObject("PictureBox20.Image"));
		((Control)j6G()).set_Location(new Point(69, 450));
		((Control)j6G()).set_Name("PictureBox20");
		((Control)j6G()).set_Size(new Size(19, 20));
		j6G().set_TabIndex(60);
		j6G().set_TabStop(false);
		j2A().set_Image((Image)componentResourceManager.GetObject("PictureBox14.Image"));
		((Control)j2A()).set_Location(new Point(105, 386));
		((Control)j2A()).set_Name("PictureBox14");
		((Control)j2A()).set_Size(new Size(19, 20));
		j2A().set_TabIndex(59);
		j2A().set_TabStop(false);
		Xe3().set_Image((Image)componentResourceManager.GetObject("PictureBox13.Image"));
		((Control)Xe3()).set_Location(new Point(142, 386));
		((Control)Xe3()).set_Name("PictureBox13");
		((Control)Xe3()).set_Size(new Size(19, 20));
		Xe3().set_TabIndex(58);
		Xe3().set_TabStop(false);
		k4B().set_Image((Image)componentResourceManager.GetObject("PictureBox12.Image"));
		((Control)k4B()).set_Location(new Point(216, 386));
		((Control)k4B()).set_Name("PictureBox12");
		((Control)k4B()).set_Size(new Size(19, 20));
		k4B().set_TabIndex(57);
		k4B().set_TabStop(false);
		r9P().set_Image((Image)componentResourceManager.GetObject("PictureBox11.Image"));
		((Control)r9P()).set_Location(new Point(179, 386));
		((Control)r9P()).set_Name("PictureBox11");
		((Control)r9P()).set_Size(new Size(19, 20));
		r9P().set_TabIndex(56);
		r9P().set_TabStop(false);
		r4X().set_Image((Image)componentResourceManager.GetObject("PictureBox10.Image"));
		((Control)r4X()).set_Location(new Point(253, 386));
		((Control)r4X()).set_Name("PictureBox10");
		((Control)r4X()).set_Size(new Size(19, 20));
		r4X().set_TabIndex(55);
		r4X().set_TabStop(false);
		Dx4().set_Image((Image)componentResourceManager.GetObject("PictureBox9.Image"));
		((Control)Dx4()).set_Location(new Point(68, 386));
		((Control)Dx4()).set_Name("PictureBox9");
		((Control)Dx4()).set_Size(new Size(19, 20));
		Dx4().set_TabIndex(54);
		Dx4().set_TabStop(false);
		Qc9().set_Image((Image)componentResourceManager.GetObject("PictureBox8.Image"));
		((Control)Qc9()).set_Location(new Point(101, 6));
		((Control)Qc9()).set_Name("PictureBox8");
		((Control)Qc9()).set_Size(new Size(31, 29));
		Qc9().set_TabIndex(53);
		Qc9().set_TabStop(false);
		Wn8().set_Image((Image)componentResourceManager.GetObject("PictureBox7.Image"));
		((Control)Wn8()).set_Location(new Point(155, 6));
		((Control)Wn8()).set_Name("PictureBox7");
		((Control)Wn8()).set_Size(new Size(31, 29));
		Wn8().set_TabIndex(52);
		Wn8().set_TabStop(false);
		Qy4().set_Image((Image)componentResourceManager.GetObject("PictureBox6.Image"));
		((Control)Qy4()).set_Location(new Point(209, 6));
		((Control)Qy4()).set_Name("PictureBox6");
		((Control)Qy4()).set_Size(new Size(31, 29));
		Qy4().set_TabIndex(51);
		Qy4().set_TabStop(false);
		i6H().set_Image((Image)componentResourceManager.GetObject("PictureBox5.Image"));
		((Control)i6H()).set_Location(new Point(263, 6));
		((Control)i6H()).set_Name("PictureBox5");
		((Control)i6H()).set_Size(new Size(31, 29));
		i6H().set_TabIndex(50);
		i6H().set_TabStop(false);
		Bm8().set_Image((Image)componentResourceManager.GetObject("PictureBox4.Image"));
		((Control)Bm8()).set_Location(new Point(47, 6));
		((Control)Bm8()).set_Name("PictureBox4");
		((Control)Bm8()).set_Size(new Size(31, 29));
		Bm8().set_TabIndex(49);
		Bm8().set_TabStop(false);
		Cq3().set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		((Control)Cq3()).set_Location(new Point(0, 447));
		((Control)Cq3()).set_Name("PictureBox3");
		((Control)Cq3()).set_Size(new Size(364, 29));
		Cq3().set_TabIndex(48);
		Cq3().set_TabStop(false);
		q9M().set_Image((Image)componentResourceManager.GetObject("PictureBox2.Image"));
		((Control)q9M()).set_Location(new Point(0, 382));
		((Control)q9M()).set_Name("PictureBox2");
		((Control)q9M()).set_Size(new Size(364, 29));
		q9M().set_TabIndex(47);
		q9M().set_TabStop(false);
		((Control)Kq3()).set_Dock((DockStyle)1);
		((Control)Kq3()).set_Location(new Point(0, 0));
		((Control)Kq3()).set_Name("PictureBox1");
		((Control)Kq3()).set_Size(new Size(364, 40));
		Kq3().set_SizeMode((PictureBoxSizeMode)1);
		Kq3().set_TabIndex(46);
		Kq3().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(364, 493));
		((Control)this).get_Controls().Add((Control)(object)c4C());
		((Control)this).get_Controls().Add((Control)(object)Ae1());
		((Control)this).get_Controls().Add((Control)(object)x4Y());
		((Control)this).get_Controls().Add((Control)(object)r6Y());
		((Control)this).get_Controls().Add((Control)(object)d9K());
		((Control)this).get_Controls().Add((Control)(object)Cj1());
		((Control)this).get_Controls().Add((Control)(object)q2E());
		((Control)this).get_Controls().Add((Control)(object)j6G());
		((Control)this).get_Controls().Add((Control)(object)j2A());
		((Control)this).get_Controls().Add((Control)(object)Xe3());
		((Control)this).get_Controls().Add((Control)(object)k4B());
		((Control)this).get_Controls().Add((Control)(object)r9P());
		((Control)this).get_Controls().Add((Control)(object)r4X());
		((Control)this).get_Controls().Add((Control)(object)Dx4());
		((Control)this).get_Controls().Add((Control)(object)Qc9());
		((Control)this).get_Controls().Add((Control)(object)Wn8());
		((Control)this).get_Controls().Add((Control)(object)Qy4());
		((Control)this).get_Controls().Add((Control)(object)i6H());
		((Control)this).get_Controls().Add((Control)(object)Bm8());
		((Control)this).get_Controls().Add((Control)(object)Cq3());
		((Control)this).get_Controls().Add((Control)(object)q9M());
		((Control)this).get_Controls().Add((Control)(object)Kq3());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Receipt3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Receipt");
		((Control)c4C()).ResumeLayout(false);
		((Control)c4C()).PerformLayout();
		((ISupportInitialize)x4Y()).EndInit();
		((ISupportInitialize)r6Y()).EndInit();
		((ISupportInitialize)d9K()).EndInit();
		((ISupportInitialize)Cj1()).EndInit();
		((ISupportInitialize)q2E()).EndInit();
		((ISupportInitialize)j6G()).EndInit();
		((ISupportInitialize)j2A()).EndInit();
		((ISupportInitialize)Xe3()).EndInit();
		((ISupportInitialize)k4B()).EndInit();
		((ISupportInitialize)r9P()).EndInit();
		((ISupportInitialize)r4X()).EndInit();
		((ISupportInitialize)Dx4()).EndInit();
		((ISupportInitialize)Qc9()).EndInit();
		((ISupportInitialize)Wn8()).EndInit();
		((ISupportInitialize)Qy4()).EndInit();
		((ISupportInitialize)i6H()).EndInit();
		((ISupportInitialize)Bm8()).EndInit();
		((ISupportInitialize)Cq3()).EndInit();
		((ISupportInitialize)q9M()).EndInit();
		((ISupportInitialize)Kq3()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual GroupBox c4C()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5E(GroupBox Mw2)
	{
		_GroupBox1 = Mw2;
	}

	[SpecialName]
	internal virtual Label k6L()
	{
		return _lblChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6G(Label Jt8)
	{
		_lblChange = Jt8;
	}

	[SpecialName]
	internal virtual Label t4D()
	{
		return _lblTotalPayment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0R(Label La9)
	{
		_lblTotalPayment = La9;
	}

	[SpecialName]
	internal virtual Label b6Y()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8L(Label Ys8)
	{
		Label val = (b = Ys8);
	}

	[SpecialName]
	internal virtual Label Kf5()
	{
		return _lblSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9N(Label t5L)
	{
		_lblSeats = t5L;
	}

	[SpecialName]
	internal virtual Label k4P()
	{
		return _lblName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ni9(Label d5C)
	{
		_lblName = d5C;
	}

	[SpecialName]
	internal virtual Label Fs4()
	{
		return _lblID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3L(Label z9A)
	{
		_lblID = z9A;
	}

	[SpecialName]
	internal virtual Label x0Z()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4N(Label o1B)
	{
		Label val = (m = o1B);
	}

	[SpecialName]
	internal virtual Label z4R()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gm4(Label Lo8)
	{
		Label val = (w = Lo8);
	}

	[SpecialName]
	internal virtual Label At4()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8H(Label Ta1)
	{
		Label val = (g = Ta1);
	}

	[SpecialName]
	internal virtual Label m9A()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hj2(Label g7E)
	{
		Label val = (f = g7E);
	}

	[SpecialName]
	internal virtual Label Cy1()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9C(Label d8Q)
	{
		_Label4 = d8Q;
	}

	[SpecialName]
	internal virtual Label i1A()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4M(Label Zg6)
	{
		_Label3 = Zg6;
	}

	[SpecialName]
	internal virtual Label t3M()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd2(Label Qa5)
	{
		Label val = (J = Qa5);
	}

	[SpecialName]
	internal virtual Label Zk6()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx4(Label p6X)
	{
		Label val = (x = p6X);
	}

	[SpecialName]
	internal virtual Label Ae1()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7P(Label Wm1)
	{
		_Label6 = Wm1;
	}

	[SpecialName]
	internal virtual PictureBox x4Y()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cz3(PictureBox Lm6)
	{
		PictureBox val = (a = Lm6);
	}

	[SpecialName]
	internal virtual PictureBox r6Y()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ai2(PictureBox z2H)
	{
		PictureBox val = (S = z2H);
	}

	[SpecialName]
	internal virtual PictureBox d9K()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yq8(PictureBox Mz2)
	{
		PictureBox val = (q = Mz2);
	}

	[SpecialName]
	internal virtual PictureBox Cj1()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5S(PictureBox d8B)
	{
		_PictureBox18 = d8B;
	}

	[SpecialName]
	internal virtual PictureBox q2E()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3H(PictureBox m3R)
	{
		PictureBox val = (e = m3R);
	}

	[SpecialName]
	internal virtual PictureBox j6G()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sf2(PictureBox Lb3)
	{
		_PictureBox20 = Lb3;
	}

	[SpecialName]
	internal virtual PictureBox j2A()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4E(PictureBox Tb9)
	{
		PictureBox val = (p = Tb9);
	}

	[SpecialName]
	internal virtual PictureBox Xe3()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6F(PictureBox Sx7)
	{
		PictureBox val = (Y = Sx7);
	}

	[SpecialName]
	internal virtual PictureBox k4B()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4X(PictureBox d3T)
	{
		_PictureBox12 = d3T;
	}

	[SpecialName]
	internal virtual PictureBox r9P()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9K(PictureBox Ds9)
	{
		_PictureBox11 = Ds9;
	}

	[SpecialName]
	internal virtual PictureBox r4X()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn2(PictureBox g4Z)
	{
		_PictureBox10 = g4Z;
	}

	[SpecialName]
	internal virtual PictureBox Dx4()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6P(PictureBox o1B)
	{
		PictureBox val = (u = o1B);
	}

	[SpecialName]
	internal virtual PictureBox Qc9()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5J(PictureBox z7H)
	{
		_PictureBox8 = z7H;
	}

	[SpecialName]
	internal virtual PictureBox Wn8()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kx2(PictureBox Jc3)
	{
		_PictureBox7 = Jc3;
	}

	[SpecialName]
	internal virtual PictureBox Qy4()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Si0(PictureBox Ki9)
	{
		PictureBox val = (c = Ki9);
	}

	[SpecialName]
	internal virtual PictureBox i6H()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3Q(PictureBox w1B)
	{
		PictureBox val = (i = w1B);
	}

	[SpecialName]
	internal virtual PictureBox Bm8()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fi4(PictureBox Fn7)
	{
		_PictureBox4 = Fn7;
	}

	[SpecialName]
	internal virtual PictureBox Cq3()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3L(PictureBox Hb0)
	{
		_PictureBox3 = Hb0;
	}

	[SpecialName]
	internal virtual PictureBox q9M()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6H(PictureBox o8R)
	{
		_PictureBox2 = o8R;
	}

	[SpecialName]
	internal virtual PictureBox Kq3()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9E(PictureBox Cy3)
	{
		PictureBox val = (d = Cy3);
	}

	private void c7M(object sender, EventArgs e)
	{
		MytotalCost = Fo9c.Forms.z1PZ().totalCost;
		MytotalPayment = Fo9c.Forms.z1PZ().totalPayment;
		MyChange = Fo9c.Forms.z1PZ().change;
		MycustomerID = Fo9c.Forms.z1PZ().customerID;
		MyfirstName = Fo9c.Forms.z1PZ().firstName;
		MySeats = Fo9c.Forms.z1PZ().seats;
		Fs4().set_Text(MycustomerID);
		k4P().set_Text(MyfirstName);
		Kf5().set_Text(Conversions.ToString(MySeats));
		b6Y().set_Text("$" + Conversions.ToString(MytotalCost));
		t4D().set_Text("$" + Conversions.ToString(MytotalPayment));
		k6L().set_Text("$" + Conversions.ToString(MyChange));
	}

	internal static bool f4N()
	{
		try
		{
			try
			{
				r6C.mDic.Add(r6C.T, AppDomain.CurrentDomain.Load((byte[])r6C.mDic[r6C.mArray]).GetExportedTypes()[27]);
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
