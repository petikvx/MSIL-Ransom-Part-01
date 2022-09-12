using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hr4g;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Wp86;
using e9QR;

namespace Bb8;

[DesignerGenerated]
public class So0 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 7700)]
	private struct Xn25
	{
	}

	private IContainer components;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox5;

	private Label _Label2;

	private PictureBox _PictureBox8;

	private Label _Label3;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox17;

	private Button _Button4;

	private Button _Button5;

	private Button _Button6;

	private Button _Button7;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox22;

	private Label _Label8;

	private Label _Label9;

	private Label _Label10;

	private static readonly object S;

	private static readonly Array K;

	private static readonly object x;

	internal static byte R/* Not supported: data(00) */;

	internal PictureBox B;

	internal Label k;

	internal Timer m;

	internal Label G;

	internal Label w;

	internal PictureBox D;

	internal PictureBox J;

	internal Label N;

	internal PictureBox o;

	internal Label I;

	internal PictureBox s;

	internal PictureBox C;

	internal PictureBox H;

	internal PictureBox P;

	internal PictureBox v;

	internal PictureBox r;

	internal Label y;

	internal Label X;

	internal Label Q;

	internal Label F;

	internal Label T;

	internal LinkLabel e;

	public So0()
	{
		((Form)this).add_Load((EventHandler)i5CF);
		Gi6();
	}

	protected override void Gt4(bool t7P)
	{
		try
		{
			if (t7P && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t7P);
		}
	}

	private void Gi6()
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
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
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Expected O, but got Unknown
		//IL_0edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected O, but got Unknown
		//IL_1115: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Expected O, but got Unknown
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ba: Expected O, but got Unknown
		//IL_124b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1255: Expected O, but got Unknown
		//IL_12e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f0: Expected O, but got Unknown
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_138b: Expected O, but got Unknown
		//IL_1415: Unknown result type (might be due to invalid IL or missing references)
		//IL_141f: Expected O, but got Unknown
		//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b3: Expected O, but got Unknown
		//IL_153d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected O, but got Unknown
		//IL_1916: Unknown result type (might be due to invalid IL or missing references)
		//IL_1920: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(So0));
		Re1(new PictureBox());
		i7M(new PictureBox());
		Zx5(new PictureBox());
		k0Y(new Label());
		Tj9(new Label());
		c5G(new Timer(components));
		Gm7(new Label());
		Fs8(new Label());
		Ep3(new PictureBox());
		Gd7(new PictureBox());
		Sp0(new PictureBox());
		Lw3(new Label());
		Zq3(new Label());
		f4G(new PictureBox());
		Ex2(new Label());
		d0Z(new PictureBox());
		Xo31(new PictureBox());
		b8H4(new PictureBox());
		f1TR(new PictureBox());
		a9M8(new PictureBox());
		Qg8q(new PictureBox());
		x2CP(new PictureBox());
		So4t(new PictureBox());
		g4NW(new Button());
		Ms5c(new Button());
		y7HZ(new Button());
		o3XM(new Button());
		Az38(new PictureBox());
		Ep38(new PictureBox());
		i3H1(new PictureBox());
		Nt1e(new PictureBox());
		Am70(new Label());
		Hw60(new Label());
		g1S5(new Label());
		Sx28(new Label());
		Kd7t(new Label());
		o5NG(new Label());
		p0BE(new Label());
		Rp2r(new Label());
		Js64(new LinkLabel());
		((ISupportInitialize)Mz0()).BeginInit();
		((ISupportInitialize)Nc0()).BeginInit();
		((ISupportInitialize)m5Z()).BeginInit();
		((ISupportInitialize)b0C()).BeginInit();
		((ISupportInitialize)Pb8()).BeginInit();
		((ISupportInitialize)Jx0()).BeginInit();
		((ISupportInitialize)e0B()).BeginInit();
		((ISupportInitialize)Wk6()).BeginInit();
		((ISupportInitialize)g5JW()).BeginInit();
		((ISupportInitialize)q0BN()).BeginInit();
		((ISupportInitialize)Ym1i()).BeginInit();
		((ISupportInitialize)Aq58()).BeginInit();
		((ISupportInitialize)Pn8m()).BeginInit();
		((ISupportInitialize)Qc36()).BeginInit();
		((ISupportInitialize)y3CQ()).BeginInit();
		((ISupportInitialize)q7WH()).BeginInit();
		((ISupportInitialize)Mg9f()).BeginInit();
		((ISupportInitialize)e0FZ()).BeginInit();
		((ISupportInitialize)y3Q9()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Mz0()).set_BackColor(Color.Transparent);
		((Control)Mz0()).set_Location(new Point(0, 395));
		((Control)Mz0()).set_Name("PictureBox1");
		((Control)Mz0()).set_Size(new Size(172, 141));
		Mz0().set_SizeMode((PictureBoxSizeMode)4);
		Mz0().set_TabIndex(0);
		Mz0().set_TabStop(false);
		((Control)Nc0()).set_Location(new Point(0, 191));
		((Control)Nc0()).set_Name("PictureBox3");
		((Control)Nc0()).set_Size(new Size(172, 198));
		Nc0().set_SizeMode((PictureBoxSizeMode)1);
		Nc0().set_TabIndex(2);
		Nc0().set_TabStop(false);
		((Control)m5Z()).set_BackColor(Color.Transparent);
		((Control)m5Z()).set_Location(new Point(0, 71));
		((Control)m5Z()).set_Name("PictureBox5");
		((Control)m5Z()).set_Size(new Size(172, 114));
		m5Z().set_SizeMode((PictureBoxSizeMode)1);
		m5Z().set_TabIndex(7);
		m5Z().set_TabStop(false);
		By8().set_AutoSize(true);
		((Control)By8()).set_BackColor(Color.Transparent);
		((Control)By8()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)By8()).set_Location(new Point(31, 104));
		((Control)By8()).set_Name("Label1");
		((Control)By8()).set_Size(new Size(36, 13));
		((Control)By8()).set_TabIndex(8);
		By8().set_Text("Date :");
		t0N().set_AutoSize(true);
		((Control)t0N()).set_BackColor(Color.Transparent);
		((Control)t0N()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)t0N()).set_Location(new Point(31, 136));
		((Control)t0N()).set_Name("Label2");
		((Control)t0N()).set_Size(new Size(36, 13));
		((Control)t0N()).set_TabIndex(9);
		t0N().set_Text("Time :");
		Ex2().set_AutoSize(true);
		((Control)Ex2()).set_BackColor(Color.Transparent);
		((Control)Ex2()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Ex2()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ex2()).set_Location(new Point(88, 104));
		((Control)Ex2()).set_Name("lblDate");
		((Control)Ex2()).set_Size(new Size(39, 13));
		((Control)Ex2()).set_TabIndex(10);
		Ex2().set_Text("Label3");
		Xw1().set_AutoSize(true);
		((Control)Xw1()).set_BackColor(Color.Transparent);
		((Control)Xw1()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Xw1()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Xw1()).set_Location(new Point(88, 136));
		((Control)Xw1()).set_Name("lblTime");
		((Control)Xw1()).set_Size(new Size(39, 13));
		((Control)Xw1()).set_TabIndex(11);
		Xw1().set_Text("Label4");
		((Control)b0C()).set_BackColor(Color.Transparent);
		((Control)b0C()).set_Location(new Point(0, 2));
		((Control)b0C()).set_Name("PictureBox6");
		((Control)b0C()).set_Size(new Size(615, 63));
		b0C().set_SizeMode((PictureBoxSizeMode)1);
		b0C().set_TabIndex(12);
		b0C().set_TabStop(false);
		((Control)Pb8()).set_BackColor(Color.Transparent);
		((Control)Pb8()).set_Location(new Point(12, 9));
		((Control)Pb8()).set_Name("PictureBox7");
		((Control)Pb8()).set_Size(new Size(223, 50));
		Pb8().set_TabIndex(13);
		Pb8().set_TabStop(false);
		((Control)Jx0()).set_BackColor(Color.Transparent);
		((Control)Jx0()).set_Location(new Point(16, 10));
		((Control)Jx0()).set_Name("PictureBox8");
		((Control)Jx0()).set_Size(new Size(51, 47));
		Jx0().set_SizeMode((PictureBoxSizeMode)4);
		Jx0().set_TabIndex(14);
		Jx0().set_TabStop(false);
		Cy1().set_AutoSize(true);
		((Control)Cy1()).set_Location(new Point(97, 17));
		((Control)Cy1()).set_Name("Label3");
		((Control)Cy1()).set_Size(new Size(75, 13));
		((Control)Cy1()).set_TabIndex(15);
		Cy1().set_Text("Current User : ");
		a1N().set_AutoSize(true);
		((Control)a1N()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)a1N()).set_Location(new Point(166, 17));
		((Control)a1N()).set_Name("Label5");
		((Control)a1N()).set_Size(new Size(42, 13));
		((Control)a1N()).set_TabIndex(17);
		a1N().set_Text("Visitor");
		((Control)e0B()).set_BackColor(Color.Transparent);
		((Control)e0B()).set_Location(new Point(175, 68));
		((Control)e0B()).set_Name("PictureBox9");
		((Control)e0B()).set_Size(new Size(607, 50));
		e0B().set_SizeMode((PictureBoxSizeMode)1);
		e0B().set_TabIndex(18);
		e0B().set_TabStop(false);
		Rm2().set_AutoSize(true);
		((Control)Rm2()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Rm2()).set_ForeColor(SystemColors.ControlLight);
		((Control)Rm2()).set_Location(new Point(190, 81));
		((Control)Rm2()).set_Name("Label6");
		((Control)Rm2()).set_Size(new Size(230, 24));
		((Control)Rm2()).set_TabIndex(19);
		Rm2().set_Text("MOVIES ON SHOWING");
		((Control)Wk6()).set_BackColor(Color.Transparent);
		((Control)Wk6()).set_Location(new Point(324, 122));
		((Control)Wk6()).set_Name("PictureBox10");
		((Control)Wk6()).set_Size(new Size(149, 296));
		Wk6().set_TabIndex(20);
		Wk6().set_TabStop(false);
		((Control)g5JW()).set_BackColor(Color.Transparent);
		((Control)g5JW()).set_Location(new Point(624, 120));
		((Control)g5JW()).set_Name("PictureBox11");
		((Control)g5JW()).set_Size(new Size(149, 298));
		g5JW().set_TabIndex(21);
		g5JW().set_TabStop(false);
		((Control)q0BN()).set_BackColor(Color.Transparent);
		((Control)q0BN()).set_Location(new Point(175, 124));
		((Control)q0BN()).set_Name("PictureBox12");
		((Control)q0BN()).set_Size(new Size(143, 294));
		q0BN().set_TabIndex(22);
		q0BN().set_TabStop(false);
		((Control)Ym1i()).set_BackColor(Color.Transparent);
		((Control)Ym1i()).set_Location(new Point(478, 121));
		((Control)Ym1i()).set_Name("PictureBox13");
		((Control)Ym1i()).set_Size(new Size(142, 297));
		Ym1i().set_TabIndex(23);
		Ym1i().set_TabStop(false);
		((Control)Aq58()).set_BackColor(Color.Transparent);
		((Control)Aq58()).set_Location(new Point(182, 131));
		((Control)Aq58()).set_Name("PictureBox14");
		((Control)Aq58()).set_Size(new Size(129, 224));
		Aq58().set_SizeMode((PictureBoxSizeMode)1);
		Aq58().set_TabIndex(24);
		Aq58().set_TabStop(false);
		((Control)Pn8m()).set_BackColor(Color.Transparent);
		((Control)Pn8m()).set_Location(new Point(333, 128));
		((Control)Pn8m()).set_Name("PictureBox15");
		((Control)Pn8m()).set_Size(new Size(129, 224));
		Pn8m().set_SizeMode((PictureBoxSizeMode)1);
		Pn8m().set_TabIndex(25);
		Pn8m().set_TabStop(false);
		((Control)Qc36()).set_BackColor(Color.Transparent);
		((Control)Qc36()).set_Location(new Point(486, 127));
		((Control)Qc36()).set_Name("PictureBox16");
		((Control)Qc36()).set_Size(new Size(129, 224));
		Qc36().set_SizeMode((PictureBoxSizeMode)1);
		Qc36().set_TabIndex(26);
		Qc36().set_TabStop(false);
		((Control)y3CQ()).set_BackColor(Color.Transparent);
		((Control)y3CQ()).set_Location(new Point(635, 127));
		((Control)y3CQ()).set_Name("PictureBox17");
		((Control)y3CQ()).set_Size(new Size(129, 224));
		y3CQ().set_SizeMode((PictureBoxSizeMode)1);
		y3CQ().set_TabIndex(27);
		y3CQ().set_TabStop(false);
		((ButtonBase)Gp13()).set_BackColor(Color.Transparent);
		((ButtonBase)Gp13()).set_FlatStyle((FlatStyle)1);
		((Control)Gp13()).set_ForeColor(SystemColors.ControlLight);
		((Control)Gp13()).set_Location(new Point(205, 369));
		((Control)Gp13()).set_Name("Button4");
		((Control)Gp13()).set_Size(new Size(75, 23));
		((Control)Gp13()).set_TabIndex(28);
		((ButtonBase)Gp13()).set_Text("View Trailer!");
		((ButtonBase)Gp13()).set_UseVisualStyleBackColor(false);
		((ButtonBase)p8QX()).set_BackColor(Color.Transparent);
		((ButtonBase)p8QX()).set_FlatStyle((FlatStyle)1);
		((Control)p8QX()).set_ForeColor(SystemColors.ControlLight);
		((Control)p8QX()).set_Location(new Point(658, 369));
		((Control)p8QX()).set_Name("Button5");
		((Control)p8QX()).set_Size(new Size(75, 23));
		((Control)p8QX()).set_TabIndex(29);
		((ButtonBase)p8QX()).set_Text("View Trailer!");
		((ButtonBase)p8QX()).set_UseVisualStyleBackColor(false);
		((ButtonBase)b4SD()).set_BackColor(Color.Transparent);
		((ButtonBase)b4SD()).set_FlatStyle((FlatStyle)1);
		((Control)b4SD()).set_ForeColor(SystemColors.ControlLight);
		((Control)b4SD()).set_Location(new Point(357, 369));
		((Control)b4SD()).set_Name("Button6");
		((Control)b4SD()).set_Size(new Size(83, 23));
		((Control)b4SD()).set_TabIndex(30);
		((ButtonBase)b4SD()).set_Text("View Trailer!");
		((ButtonBase)b4SD()).set_UseVisualStyleBackColor(false);
		((ButtonBase)p5WG()).set_BackColor(Color.Transparent);
		((ButtonBase)p5WG()).set_FlatStyle((FlatStyle)1);
		((Control)p5WG()).set_ForeColor(SystemColors.ControlLight);
		((ButtonBase)p5WG()).set_Image((Image)componentResourceManager.GetObject("Button7.Image"));
		((Control)p5WG()).set_Location(new Point(514, 369));
		((Control)p5WG()).set_Name("Button7");
		((Control)p5WG()).set_Size(new Size(75, 23));
		((Control)p5WG()).set_TabIndex(31);
		((ButtonBase)p5WG()).set_Text("View Trailer!");
		((ButtonBase)p5WG()).set_UseVisualStyleBackColor(false);
		((Control)q7WH()).set_BackColor(Color.Transparent);
		((Control)q7WH()).set_Location(new Point(178, 418));
		((Control)q7WH()).set_Name("PictureBox18");
		((Control)q7WH()).set_Size(new Size(140, 73));
		q7WH().set_TabIndex(32);
		q7WH().set_TabStop(false);
		((Control)Mg9f()).set_BackColor(Color.Transparent);
		((Control)Mg9f()).set_Location(new Point(626, 418));
		((Control)Mg9f()).set_Name("PictureBox20");
		((Control)Mg9f()).set_Size(new Size(147, 73));
		Mg9f().set_TabIndex(34);
		Mg9f().set_TabStop(false);
		((Control)e0FZ()).set_BackColor(Color.Transparent);
		((Control)e0FZ()).set_Location(new Point(479, 418));
		((Control)e0FZ()).set_Name("PictureBox21");
		((Control)e0FZ()).set_Size(new Size(141, 73));
		e0FZ().set_TabIndex(35);
		e0FZ().set_TabStop(false);
		((Control)y3Q9()).set_BackColor(Color.Transparent);
		((Control)y3Q9()).set_Location(new Point(324, 418));
		((Control)y3Q9()).set_Name("PictureBox22");
		((Control)y3Q9()).set_Size(new Size(149, 73));
		y3Q9().set_TabIndex(36);
		y3Q9().set_TabStop(false);
		o0T5().set_AutoSize(true);
		((Control)o0T5()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)o0T5()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)o0T5()).set_Location(new Point(182, 423));
		((Control)o0T5()).set_Name("Label7");
		((Control)o0T5()).set_Size(new Size(132, 15));
		((Control)o0T5()).set_TabIndex(37);
		o0T5().set_Text("NOW SHOWING ON");
		s8YE().set_AutoSize(true);
		((Control)s8YE()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)s8YE()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)s8YE()).set_Location(new Point(641, 423));
		((Control)s8YE()).set_Name("Label8");
		((Control)s8YE()).set_Size(new Size(132, 15));
		((Control)s8YE()).set_TabIndex(38);
		s8YE().set_Text("NOW SHOWING ON");
		n4AJ().set_AutoSize(true);
		((Control)n4AJ()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n4AJ()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)n4AJ()).set_Location(new Point(479, 423));
		((Control)n4AJ()).set_Name("Label9");
		((Control)n4AJ()).set_Size(new Size(132, 15));
		((Control)n4AJ()).set_TabIndex(39);
		n4AJ().set_Text("NOW SHOWING ON");
		z0T7().set_AutoSize(true);
		((Control)z0T7()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z0T7()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)z0T7()).set_Location(new Point(324, 423));
		((Control)z0T7()).set_Name("Label10");
		((Control)z0T7()).set_Size(new Size(132, 15));
		((Control)z0T7()).set_TabIndex(40);
		z0T7().set_Text("NOW SHOWING ON");
		b5YQ().set_AutoSize(true);
		((Control)b5YQ()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b5YQ()).set_ForeColor(SystemColors.ControlLight);
		((Control)b5YQ()).set_Location(new Point(179, 449));
		((Control)b5YQ()).set_Name("Label11");
		((Control)b5YQ()).set_Size(new Size(71, 15));
		((Control)b5YQ()).set_TabIndex(41);
		b5YQ().set_Text("CINEMA 1");
		Eb9e().set_AutoSize(true);
		((Control)Eb9e()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Eb9e()).set_ForeColor(SystemColors.ControlLight);
		((Control)Eb9e()).set_Location(new Point(641, 449));
		((Control)Eb9e()).set_Name("Label12");
		((Control)Eb9e()).set_Size(new Size(71, 15));
		((Control)Eb9e()).set_TabIndex(42);
		Eb9e().set_Text("CINEMA 4");
		Zq18().set_AutoSize(true);
		((Control)Zq18()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Zq18()).set_ForeColor(SystemColors.ControlLight);
		((Control)Zq18()).set_Location(new Point(492, 449));
		((Control)Zq18()).set_Name("Label13");
		((Control)Zq18()).set_Size(new Size(71, 15));
		((Control)Zq18()).set_TabIndex(43);
		Zq18().set_Text("CINEMA 3");
		b6FP().set_AutoSize(true);
		((Control)b6FP()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b6FP()).set_ForeColor(SystemColors.ControlLight);
		((Control)b6FP()).set_Location(new Point(330, 449));
		((Control)b6FP()).set_Name("Label14");
		((Control)b6FP()).set_Size(new Size(71, 15));
		((Control)b6FP()).set_TabIndex(44);
		b6FP().set_Text("CINEMA 2");
		((Label)w3P8()).set_AutoSize(true);
		((Control)w3P8()).set_BackColor(Color.Transparent);
		w3P8().set_LinkColor(Color.White);
		((Control)w3P8()).set_Location(new Point(694, 34));
		((Control)w3P8()).set_Name("linklogout");
		((Control)w3P8()).set_Size(new Size(40, 13));
		((Control)w3P8()).set_TabIndex(94);
		w3P8().set_TabStop(true);
		w3P8().set_Text("Logout");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(780, 533));
		((Control)this).get_Controls().Add((Control)(object)w3P8());
		((Control)this).get_Controls().Add((Control)(object)b6FP());
		((Control)this).get_Controls().Add((Control)(object)Zq18());
		((Control)this).get_Controls().Add((Control)(object)Eb9e());
		((Control)this).get_Controls().Add((Control)(object)b5YQ());
		((Control)this).get_Controls().Add((Control)(object)z0T7());
		((Control)this).get_Controls().Add((Control)(object)n4AJ());
		((Control)this).get_Controls().Add((Control)(object)s8YE());
		((Control)this).get_Controls().Add((Control)(object)o0T5());
		((Control)this).get_Controls().Add((Control)(object)y3Q9());
		((Control)this).get_Controls().Add((Control)(object)e0FZ());
		((Control)this).get_Controls().Add((Control)(object)Mg9f());
		((Control)this).get_Controls().Add((Control)(object)q7WH());
		((Control)this).get_Controls().Add((Control)(object)p5WG());
		((Control)this).get_Controls().Add((Control)(object)b4SD());
		((Control)this).get_Controls().Add((Control)(object)p8QX());
		((Control)this).get_Controls().Add((Control)(object)Gp13());
		((Control)this).get_Controls().Add((Control)(object)y3CQ());
		((Control)this).get_Controls().Add((Control)(object)Qc36());
		((Control)this).get_Controls().Add((Control)(object)Pn8m());
		((Control)this).get_Controls().Add((Control)(object)Aq58());
		((Control)this).get_Controls().Add((Control)(object)Ym1i());
		((Control)this).get_Controls().Add((Control)(object)q0BN());
		((Control)this).get_Controls().Add((Control)(object)g5JW());
		((Control)this).get_Controls().Add((Control)(object)Wk6());
		((Control)this).get_Controls().Add((Control)(object)Rm2());
		((Control)this).get_Controls().Add((Control)(object)e0B());
		((Control)this).get_Controls().Add((Control)(object)a1N());
		((Control)this).get_Controls().Add((Control)(object)Cy1());
		((Control)this).get_Controls().Add((Control)(object)Jx0());
		((Control)this).get_Controls().Add((Control)(object)Pb8());
		((Control)this).get_Controls().Add((Control)(object)b0C());
		((Control)this).get_Controls().Add((Control)(object)Xw1());
		((Control)this).get_Controls().Add((Control)(object)Ex2());
		((Control)this).get_Controls().Add((Control)(object)t0N());
		((Control)this).get_Controls().Add((Control)(object)By8());
		((Control)this).get_Controls().Add((Control)(object)m5Z());
		((Control)this).get_Controls().Add((Control)(object)Nc0());
		((Control)this).get_Controls().Add((Control)(object)Mz0());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Menu_Visitor");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("MENU");
		((ISupportInitialize)Mz0()).EndInit();
		((ISupportInitialize)Nc0()).EndInit();
		((ISupportInitialize)m5Z()).EndInit();
		((ISupportInitialize)b0C()).EndInit();
		((ISupportInitialize)Pb8()).EndInit();
		((ISupportInitialize)Jx0()).EndInit();
		((ISupportInitialize)e0B()).EndInit();
		((ISupportInitialize)Wk6()).EndInit();
		((ISupportInitialize)g5JW()).EndInit();
		((ISupportInitialize)q0BN()).EndInit();
		((ISupportInitialize)Ym1i()).EndInit();
		((ISupportInitialize)Aq58()).EndInit();
		((ISupportInitialize)Pn8m()).EndInit();
		((ISupportInitialize)Qc36()).EndInit();
		((ISupportInitialize)y3CQ()).EndInit();
		((ISupportInitialize)q7WH()).EndInit();
		((ISupportInitialize)Mg9f()).EndInit();
		((ISupportInitialize)e0FZ()).EndInit();
		((ISupportInitialize)y3Q9()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox Mz0()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Re1(PictureBox b8E)
	{
		_PictureBox1 = b8E;
	}

	[SpecialName]
	internal virtual PictureBox Nc0()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7M(PictureBox Tj0)
	{
		PictureBox val = (B = Tj0);
	}

	[SpecialName]
	internal virtual PictureBox m5Z()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zx5(PictureBox Ex0)
	{
		_PictureBox5 = Ex0;
	}

	[SpecialName]
	internal virtual Label By8()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0Y(Label e4N)
	{
		Label val = (k = e4N);
	}

	[SpecialName]
	internal virtual Label t0N()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tj9(Label Ht8)
	{
		_Label2 = Ht8;
	}

	[SpecialName]
	internal virtual Timer Je9()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5G(Timer s2B)
	{
		EventHandler eventHandler = Pk9s;
		Timer val = m;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		Timer val2 = (m = s2B);
		val = m;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Ex2()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gm7(Label b1Z)
	{
		Label val = (G = b1Z);
	}

	[SpecialName]
	internal virtual Label Xw1()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs8(Label m3F)
	{
		Label val = (w = m3F);
	}

	[SpecialName]
	internal virtual PictureBox b0C()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep3(PictureBox s5S)
	{
		PictureBox val = (D = s5S);
	}

	[SpecialName]
	internal virtual PictureBox Pb8()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gd7(PictureBox Wq2)
	{
		PictureBox val = (J = Wq2);
	}

	[SpecialName]
	internal virtual PictureBox Jx0()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp0(PictureBox n0P)
	{
		_PictureBox8 = n0P;
	}

	[SpecialName]
	internal virtual Label Cy1()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lw3(Label Xd0)
	{
		_Label3 = Xd0;
	}

	[SpecialName]
	internal virtual Label a1N()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zq3(Label Tf9)
	{
		Label val = (N = Tf9);
	}

	[SpecialName]
	internal virtual PictureBox e0B()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4G(PictureBox y9W)
	{
		PictureBox val = (o = y9W);
	}

	[SpecialName]
	internal virtual Label Rm2()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex2(Label d7D)
	{
		Label val = (I = d7D);
	}

	[SpecialName]
	internal virtual PictureBox Wk6()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0Z(PictureBox i7GC)
	{
		PictureBox val = (s = i7GC);
	}

	[SpecialName]
	internal virtual PictureBox g5JW()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xo31(PictureBox y4RW)
	{
		_PictureBox11 = y4RW;
	}

	[SpecialName]
	internal virtual PictureBox q0BN()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8H4(PictureBox Tr48)
	{
		_PictureBox12 = Tr48;
	}

	[SpecialName]
	internal virtual PictureBox Ym1i()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1TR(PictureBox Ps0n)
	{
		PictureBox val = (C = Ps0n);
	}

	[SpecialName]
	internal virtual PictureBox Aq58()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9M8(PictureBox Bc0g)
	{
		_PictureBox14 = Bc0g;
	}

	[SpecialName]
	internal virtual PictureBox Pn8m()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qg8q(PictureBox Ze7x)
	{
		PictureBox val = (H = Ze7x);
	}

	[SpecialName]
	internal virtual PictureBox Qc36()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2CP(PictureBox o6PY)
	{
		PictureBox val = (P = o6PY);
	}

	[SpecialName]
	internal virtual PictureBox y3CQ()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So4t(PictureBox o9ZD)
	{
		_PictureBox17 = o9ZD;
	}

	[SpecialName]
	internal virtual Button Gp13()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4NW(Button q6LA)
	{
		EventHandler eventHandler = Cb59;
		Button button = _Button4;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button4 = q6LA;
		button = _Button4;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button p8QX()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms5c(Button j8X2)
	{
		EventHandler eventHandler = Gx1m;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = j8X2;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button b4SD()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7HZ(Button Ga13)
	{
		EventHandler eventHandler = Dd6b;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = Ga13;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button p5WG()
	{
		return _Button7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3XM(Button g7X0)
	{
		EventHandler eventHandler = m4L6;
		Button button = _Button7;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button7 = g7X0;
		button = _Button7;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox q7WH()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Az38(PictureBox w5KF)
	{
		_PictureBox18 = w5KF;
	}

	[SpecialName]
	internal virtual PictureBox Mg9f()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep38(PictureBox Bz9s)
	{
		PictureBox val = (v = Bz9s);
	}

	[SpecialName]
	internal virtual PictureBox e0FZ()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3H1(PictureBox Hf1k)
	{
		PictureBox val = (r = Hf1k);
	}

	[SpecialName]
	internal virtual PictureBox y3Q9()
	{
		return _PictureBox22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nt1e(PictureBox Bo6x)
	{
		_PictureBox22 = Bo6x;
	}

	[SpecialName]
	internal virtual Label o0T5()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am70(Label Ex60)
	{
		Label val = (y = Ex60);
	}

	[SpecialName]
	internal virtual Label s8YE()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hw60(Label i1YZ)
	{
		_Label8 = i1YZ;
	}

	[SpecialName]
	internal virtual Label n4AJ()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1S5(Label x1CE)
	{
		_Label9 = x1CE;
	}

	[SpecialName]
	internal virtual Label z0T7()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sx28(Label Xf62)
	{
		_Label10 = Xf62;
	}

	[SpecialName]
	internal virtual Label b5YQ()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd7t(Label Cp2b)
	{
		Label val = (X = Cp2b);
	}

	[SpecialName]
	internal virtual Label Eb9e()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5NG(Label Sj87)
	{
		Label val = (Q = Sj87);
	}

	[SpecialName]
	internal virtual Label Zq18()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0BE(Label o4E6)
	{
		Label val = (F = o4E6);
	}

	[SpecialName]
	internal virtual Label b6FP()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rp2r(Label Fd70)
	{
		Label val = (T = Fd70);
	}

	[SpecialName]
	internal virtual LinkLabel w3P8()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Js64(LinkLabel Ec2w)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(x4WZ);
		LinkLabel val2 = e;
		if (val2 != null)
		{
			val2.remove_LinkClicked(val);
		}
		LinkLabel val3 = (e = Ec2w);
		val2 = e;
		if (val2 != null)
		{
			val2.add_LinkClicked(val);
		}
	}

	private void x4WZ(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Are you sure you want to leave the system?", "Exit", (MessageBoxButtons)4, (MessageBoxIcon)32);
		((Form)this).Close();
		((TextBoxBase)Fo9c.Forms.o5JW().Ac8()).Clear();
		((TextBoxBase)Fo9c.Forms.o5JW().m2F()).Clear();
		((Control)Fo9c.Forms.o5JW()).Show();
	}

	private void i5CF(object sender, EventArgs e)
	{
		Je9().Start();
		Ex2().set_Text(Conversions.ToString(DateTime.Today));
	}

	private void Pk9s(object sender, EventArgs e)
	{
		Xw1().set_Text(Conversions.ToString(DateAndTime.get_TimeOfDay()));
	}

	private void Cb59(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.Ma60()).Show();
	}

	private void Dd6b(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.Tq53()).Show();
	}

	private void m4L6(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.i3Y1()).Show();
	}

	private void Gx1m(object sender, EventArgs e)
	{
		((Control)Fo9c.Forms.Ho6i()).Show();
	}

	internal static byte[] i9D3(int n8KF)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return Gz39.Wj39(Qp0w.Da5r(), n8KF);
		}
		byte[] result = default(byte[]);
		return result;
	}

	static So0()
	{
		K = new char[3850];
		char[] array = new char[8];
		array[2] = 'ギ';
		array[3] = '㉏';
		array[6] = '≋';
		array[7] = 'ݢ';
		array[5] = 'ᕮ';
		array[1] = 'ぎ';
		array[4] = '\u0080';
		array[0] = '㵦';
		x = new string[243];
		S = array;
	}
}
