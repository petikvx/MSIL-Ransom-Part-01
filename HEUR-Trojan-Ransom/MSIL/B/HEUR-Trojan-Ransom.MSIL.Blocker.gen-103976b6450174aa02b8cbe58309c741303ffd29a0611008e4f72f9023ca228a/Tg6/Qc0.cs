using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dz5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using i9M;

namespace Tg6;

[DesignerGenerated]
public class Qc0 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4242)]
	private struct Wo1
	{
	}

	private Label _Label14;

	private Label _Label11;

	private Label _Label7;

	private PictureBox _PictureBox22;

	private PictureBox _PictureBox21;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox10;

	private Label _Label5;

	private PictureBox _PictureBox6;

	private Label _Label2;

	private Timer _Timer1;

	private PictureBox _PictureBox1;

	private Button _btnCinema1;

	private Button _btnCinema4;

	private Button _btnCinema2;

	private PictureBox _PictureBox19;

	private static readonly object J;

	private static readonly object s;

	private static readonly object X;

	internal static byte O/* Not supported: data(00) */;

	internal IContainer k;

	internal Label q;

	internal Label g;

	internal Label t;

	internal Label c;

	internal Label v;

	internal PictureBox o;

	internal PictureBox h;

	internal PictureBox W;

	internal PictureBox L;

	internal PictureBox y;

	internal PictureBox i;

	internal PictureBox b;

	internal Label F;

	internal PictureBox S;

	internal Label X;

	internal PictureBox m;

	internal PictureBox p;

	internal Label a;

	internal Label J;

	internal Label r;

	internal PictureBox U;

	internal Button n;

	internal Button E;

	internal LinkLabel D;

	public Qc0()
	{
		((Form)this).add_Load((EventHandler)c5A);
		Rf5();
	}

	protected override void f6F(bool Hw2)
	{
		try
		{
			if (Hw2 && k != null)
			{
				k.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Hw2);
		}
	}

	private void Rf5()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected O, but got Unknown
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccd: Expected O, but got Unknown
		//IL_0dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd4: Expected O, but got Unknown
		//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1003: Expected O, but got Unknown
		//IL_109a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a4: Expected O, but got Unknown
		//IL_19ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b5: Expected O, but got Unknown
		IContainer container = (k = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Qc0));
		z6S(new Label());
		Nc1(new Label());
		Pp0(new Label());
		d2Y(new Label());
		i7Q(new Label());
		Xc6(new Label());
		x6N(new Label());
		Lb0(new Label());
		f0M(new PictureBox());
		q9T(new PictureBox());
		m7F(new PictureBox());
		i8H(new PictureBox());
		Qz4(new PictureBox());
		a8Z(new PictureBox());
		n8L(new PictureBox());
		r0Y(new PictureBox());
		Fa8(new PictureBox());
		b5S(new PictureBox());
		this.z4B(new PictureBox());
		Dw0(new PictureBox());
		d4K(new Label());
		t5C(new PictureBox());
		Xf9(new Label());
		Bf3(new Label());
		this.z4B(new PictureBox());
		Pc7(new PictureBox());
		q2W(new PictureBox());
		z7T(new Label());
		j0H(new Label());
		Cq6(new Label());
		f8M(new Label());
		s7K(new PictureBox());
		Hn3(new Timer(k));
		Tn9(new PictureBox());
		Ga4(new Button());
		b8T(new Button());
		b9X(new Button());
		Sg3(new Button());
		Df3(new Button());
		Nj8(new LinkLabel());
		x6M(new PictureBox());
		((ISupportInitialize)w2D()).BeginInit();
		((ISupportInitialize)d8H()).BeginInit();
		((ISupportInitialize)r2B()).BeginInit();
		((ISupportInitialize)k0D()).BeginInit();
		((ISupportInitialize)Yk1()).BeginInit();
		((ISupportInitialize)b6L()).BeginInit();
		((ISupportInitialize)Qm1()).BeginInit();
		((ISupportInitialize)Jn0()).BeginInit();
		((ISupportInitialize)a9Y()).BeginInit();
		((ISupportInitialize)t7N()).BeginInit();
		((ISupportInitialize)Xa7()).BeginInit();
		((ISupportInitialize)j3W()).BeginInit();
		((ISupportInitialize)o4F()).BeginInit();
		((ISupportInitialize)Re1()).BeginInit();
		((ISupportInitialize)f1A()).BeginInit();
		((ISupportInitialize)No8()).BeginInit();
		((ISupportInitialize)Zd5()).BeginInit();
		((ISupportInitialize)s7Z()).BeginInit();
		((ISupportInitialize)Pg8()).BeginInit();
		((Control)this).SuspendLayout();
		Bs0().set_AutoSize(true);
		((Control)Bs0()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Bs0()).set_ForeColor(SystemColors.ControlLight);
		((Control)Bs0()).set_Location(new Point(329, 446));
		((Control)Bs0()).set_Name("Label14");
		((Control)Bs0()).set_Size(new Size(71, 15));
		((Control)Bs0()).set_TabIndex(88);
		Bs0().set_Text("CINEMA 2");
		s7T().set_AutoSize(true);
		((Control)s7T()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)s7T()).set_ForeColor(SystemColors.ControlLight);
		((Control)s7T()).set_Location(new Point(491, 446));
		((Control)s7T()).set_Name("Label13");
		((Control)s7T()).set_Size(new Size(71, 15));
		((Control)s7T()).set_TabIndex(87);
		s7T().set_Text("CINEMA 3");
		p7A().set_AutoSize(true);
		((Control)p7A()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)p7A()).set_ForeColor(SystemColors.ControlLight);
		((Control)p7A()).set_Location(new Point(640, 446));
		((Control)p7A()).set_Name("Label12");
		((Control)p7A()).set_Size(new Size(71, 15));
		((Control)p7A()).set_TabIndex(86);
		p7A().set_Text("CINEMA 4");
		Tx4().set_AutoSize(true);
		((Control)Tx4()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Tx4()).set_ForeColor(SystemColors.ControlLight);
		((Control)Tx4()).set_Location(new Point(178, 446));
		((Control)Tx4()).set_Name("Label11");
		((Control)Tx4()).set_Size(new Size(71, 15));
		((Control)Tx4()).set_TabIndex(85);
		Tx4().set_Text("CINEMA 1");
		k9R().set_AutoSize(true);
		((Control)k9R()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)k9R()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)k9R()).set_Location(new Point(323, 420));
		((Control)k9R()).set_Name("Label10");
		((Control)k9R()).set_Size(new Size(132, 15));
		((Control)k9R()).set_TabIndex(84);
		k9R().set_Text("NOW SHOWING ON");
		n2B().set_AutoSize(true);
		((Control)n2B()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n2B()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)n2B()).set_Location(new Point(478, 420));
		((Control)n2B()).set_Name("Label9");
		((Control)n2B()).set_Size(new Size(132, 15));
		((Control)n2B()).set_TabIndex(83);
		n2B().set_Text("NOW SHOWING ON");
		k5C().set_AutoSize(true);
		((Control)k5C()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)k5C()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)k5C()).set_Location(new Point(640, 420));
		((Control)k5C()).set_Name("Label8");
		((Control)k5C()).set_Size(new Size(132, 15));
		((Control)k5C()).set_TabIndex(82);
		k5C().set_Text("NOW SHOWING ON");
		Jf4().set_AutoSize(true);
		((Control)Jf4()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Jf4()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Jf4()).set_Location(new Point(181, 420));
		((Control)Jf4()).set_Name("Label7");
		((Control)Jf4()).set_Size(new Size(132, 15));
		((Control)Jf4()).set_TabIndex(81);
		Jf4().set_Text("NOW SHOWING ON");
		((Control)w2D()).set_BackColor(Color.Transparent);
		((Control)w2D()).set_Location(new Point(323, 415));
		((Control)w2D()).set_Name("PictureBox22");
		((Control)w2D()).set_Size(new Size(149, 73));
		w2D().set_TabIndex(80);
		w2D().set_TabStop(false);
		((Control)d8H()).set_BackColor(Color.Transparent);
		((Control)d8H()).set_Location(new Point(478, 415));
		((Control)d8H()).set_Name("PictureBox21");
		((Control)d8H()).set_Size(new Size(141, 73));
		d8H().set_TabIndex(79);
		d8H().set_TabStop(false);
		((Control)r2B()).set_BackColor(Color.Transparent);
		((Control)r2B()).set_Location(new Point(625, 415));
		((Control)r2B()).set_Name("PictureBox20");
		((Control)r2B()).set_Size(new Size(147, 73));
		r2B().set_TabIndex(78);
		r2B().set_TabStop(false);
		((Control)k0D()).set_BackColor(Color.Transparent);
		((Control)k0D()).set_Location(new Point(177, 415));
		((Control)k0D()).set_Name("PictureBox18");
		((Control)k0D()).set_Size(new Size(140, 73));
		k0D().set_TabIndex(77);
		k0D().set_TabStop(false);
		((Control)Yk1()).set_BackColor(Color.Transparent);
		((Control)Yk1()).set_Location(new Point(634, 124));
		((Control)Yk1()).set_Name("PictureBox17");
		((Control)Yk1()).set_Size(new Size(129, 224));
		Yk1().set_SizeMode((PictureBoxSizeMode)1);
		Yk1().set_TabIndex(72);
		Yk1().set_TabStop(false);
		((Control)b6L()).set_BackColor(Color.Transparent);
		((Control)b6L()).set_Location(new Point(485, 124));
		((Control)b6L()).set_Name("PictureBox16");
		((Control)b6L()).set_Size(new Size(129, 224));
		b6L().set_SizeMode((PictureBoxSizeMode)1);
		b6L().set_TabIndex(71);
		b6L().set_TabStop(false);
		((Control)Qm1()).set_BackColor(Color.Transparent);
		((Control)Qm1()).set_Location(new Point(332, 125));
		((Control)Qm1()).set_Name("PictureBox15");
		((Control)Qm1()).set_Size(new Size(129, 224));
		Qm1().set_SizeMode((PictureBoxSizeMode)1);
		Qm1().set_TabIndex(70);
		Qm1().set_TabStop(false);
		((Control)Jn0()).set_BackColor(Color.Transparent);
		((Control)Jn0()).set_Location(new Point(181, 128));
		((Control)Jn0()).set_Name("PictureBox14");
		((Control)Jn0()).set_Size(new Size(129, 224));
		Jn0().set_SizeMode((PictureBoxSizeMode)1);
		Jn0().set_TabIndex(69);
		Jn0().set_TabStop(false);
		((Control)a9Y()).set_BackColor(Color.Transparent);
		((Control)a9Y()).set_Location(new Point(477, 118));
		((Control)a9Y()).set_Name("PictureBox13");
		((Control)a9Y()).set_Size(new Size(142, 297));
		a9Y().set_TabIndex(68);
		a9Y().set_TabStop(false);
		((Control)t7N()).set_BackColor(Color.Transparent);
		((Control)t7N()).set_Location(new Point(174, 121));
		((Control)t7N()).set_Name("PictureBox12");
		((Control)t7N()).set_Size(new Size(143, 294));
		t7N().set_TabIndex(67);
		t7N().set_TabStop(false);
		((Control)Xa7()).set_BackColor(Color.Transparent);
		((Control)Xa7()).set_Location(new Point(623, 117));
		((Control)Xa7()).set_Name("PictureBox11");
		((Control)Xa7()).set_Size(new Size(149, 298));
		Xa7().set_TabIndex(66);
		Xa7().set_TabStop(false);
		((Control)j3W()).set_BackColor(Color.Transparent);
		((Control)j3W()).set_Location(new Point(323, 119));
		((Control)j3W()).set_Name("PictureBox10");
		((Control)j3W()).set_Size(new Size(149, 296));
		j3W().set_TabIndex(65);
		j3W().set_TabStop(false);
		Fy3().set_AutoSize(true);
		((Control)Fy3()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Fy3()).set_ForeColor(SystemColors.ControlLight);
		((Control)Fy3()).set_Location(new Point(189, 78));
		((Control)Fy3()).set_Name("Label6");
		((Control)Fy3()).set_Size(new Size(230, 24));
		((Control)Fy3()).set_TabIndex(64);
		Fy3().set_Text("MOVIES ON SHOWING");
		((Control)o4F()).set_BackColor(Color.Transparent);
		((Control)o4F()).set_Location(new Point(174, 65));
		((Control)o4F()).set_Name("PictureBox9");
		((Control)o4F()).set_Size(new Size(607, 50));
		o4F().set_SizeMode((PictureBoxSizeMode)1);
		o4F().set_TabIndex(63);
		o4F().set_TabStop(false);
		z1N().set_AutoSize(true);
		((Control)z1N()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z1N()).set_Location(new Point(165, 14));
		((Control)z1N()).set_Name("Label5");
		((Control)z1N()).set_Size(new Size(41, 13));
		((Control)z1N()).set_TabIndex(62);
		z1N().set_Text("Admin");
		z9D().set_AutoSize(true);
		((Control)z9D()).set_Location(new Point(96, 14));
		((Control)z9D()).set_Name("Label3");
		((Control)z9D()).set_Size(new Size(75, 13));
		((Control)z9D()).set_TabIndex(60);
		z9D().set_Text("Current User : ");
		((Control)Re1()).set_BackColor(Color.Transparent);
		((Control)Re1()).set_Location(new Point(15, 7));
		((Control)Re1()).set_Name("PictureBox8");
		((Control)Re1()).set_Size(new Size(51, 47));
		Re1().set_SizeMode((PictureBoxSizeMode)4);
		Re1().set_TabIndex(59);
		Re1().set_TabStop(false);
		((Control)f1A()).set_BackColor(Color.Transparent);
		((Control)f1A()).set_Location(new Point(11, 6));
		((Control)f1A()).set_Name("PictureBox7");
		((Control)f1A()).set_Size(new Size(223, 50));
		f1A().set_TabIndex(58);
		f1A().set_TabStop(false);
		((Control)No8()).set_BackColor(Color.Transparent);
		((Control)No8()).set_Location(new Point(-1, -1));
		((Control)No8()).set_Name("PictureBox6");
		((Control)No8()).set_Size(new Size(615, 63));
		No8().set_SizeMode((PictureBoxSizeMode)1);
		No8().set_TabIndex(57);
		No8().set_TabStop(false);
		w8Z().set_AutoSize(true);
		((Control)w8Z()).set_BackColor(Color.Transparent);
		((Control)w8Z()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)w8Z()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)w8Z()).set_Location(new Point(87, 133));
		((Control)w8Z()).set_Name("lblTime");
		((Control)w8Z()).set_Size(new Size(39, 13));
		((Control)w8Z()).set_TabIndex(56);
		w8Z().set_Text("Label4");
		Pk4().set_AutoSize(true);
		((Control)Pk4()).set_BackColor(Color.Transparent);
		((Control)Pk4()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Pk4()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Pk4()).set_Location(new Point(87, 101));
		((Control)Pk4()).set_Name("lblDate");
		((Control)Pk4()).set_Size(new Size(39, 13));
		((Control)Pk4()).set_TabIndex(55);
		Pk4().set_Text("Label3");
		Qx9().set_AutoSize(true);
		((Control)Qx9()).set_BackColor(Color.Transparent);
		((Control)Qx9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Qx9()).set_Location(new Point(30, 133));
		((Control)Qx9()).set_Name("Label2");
		((Control)Qx9()).set_Size(new Size(36, 13));
		((Control)Qx9()).set_TabIndex(54);
		Qx9().set_Text("Time :");
		Gd9().set_AutoSize(true);
		((Control)Gd9()).set_BackColor(Color.Transparent);
		((Control)Gd9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Gd9()).set_Location(new Point(30, 101));
		((Control)Gd9()).set_Name("Label1");
		((Control)Gd9()).set_Size(new Size(36, 13));
		((Control)Gd9()).set_TabIndex(53);
		Gd9().set_Text("Date :");
		((Control)Zd5()).set_BackColor(Color.Transparent);
		((Control)Zd5()).set_Location(new Point(-1, 68));
		((Control)Zd5()).set_Name("PictureBox5");
		((Control)Zd5()).set_Size(new Size(172, 114));
		Zd5().set_SizeMode((PictureBoxSizeMode)1);
		Zd5().set_TabIndex(52);
		Zd5().set_TabStop(false);
		((Control)s7Z()).set_BackColor(Color.Transparent);
		((Control)s7Z()).set_Location(new Point(-1, 392));
		((Control)s7Z()).set_Name("PictureBox1");
		((Control)s7Z()).set_Size(new Size(172, 141));
		s7Z().set_SizeMode((PictureBoxSizeMode)4);
		s7Z().set_TabIndex(45);
		s7Z().set_TabStop(false);
		((ButtonBase)Ri6()).set_BackColor(Color.Transparent);
		((ButtonBase)Ri6()).set_FlatStyle((FlatStyle)1);
		((Control)Ri6()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ri6()).set_Location(new Point(258, 444));
		((Control)Ri6()).set_Name("btnCinema1");
		((Control)Ri6()).set_Size(new Size(55, 23));
		((Control)Ri6()).set_TabIndex(89);
		((ButtonBase)Ri6()).set_Text("Book");
		((ButtonBase)Ri6()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Ro1()).set_BackColor(Color.Transparent);
		((ButtonBase)Ro1()).set_FlatStyle((FlatStyle)1);
		((Control)Ro1()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ro1()).set_Location(new Point(717, 444));
		((Control)Ro1()).set_Name("btnCinema4");
		((Control)Ro1()).set_Size(new Size(46, 23));
		((Control)Ro1()).set_TabIndex(92);
		((ButtonBase)Ro1()).set_Text("Book");
		((ButtonBase)Ro1()).set_UseVisualStyleBackColor(false);
		((ButtonBase)f6A()).set_BackColor(Color.Transparent);
		((ButtonBase)f6A()).set_FlatStyle((FlatStyle)1);
		((Control)f6A()).set_ForeColor(SystemColors.ControlLight);
		((Control)f6A()).set_Location(new Point(414, 443));
		((Control)f6A()).set_Name("btnCinema2");
		((Control)f6A()).set_Size(new Size(47, 23));
		((Control)f6A()).set_TabIndex(92);
		((ButtonBase)f6A()).set_Text("Book");
		((ButtonBase)f6A()).set_UseVisualStyleBackColor(false);
		((ButtonBase)d8T()).set_BackColor(Color.Transparent);
		((ButtonBase)d8T()).set_FlatStyle((FlatStyle)1);
		((Control)d8T()).set_ForeColor(SystemColors.ControlLight);
		((Control)d8T()).set_Location(new Point(568, 442));
		((Control)d8T()).set_Name("btnCinema3");
		((Control)d8T()).set_Size(new Size(47, 23));
		((Control)d8T()).set_TabIndex(92);
		((ButtonBase)d8T()).set_Text("Book");
		((ButtonBase)d8T()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Bp7()).set_BackColor(Color.Transparent);
		((ButtonBase)Bp7()).set_FlatStyle((FlatStyle)1);
		((Control)Bp7()).set_ForeColor(SystemColors.ControlLight);
		((Control)Bp7()).set_Location(new Point(594, 633));
		((Control)Bp7()).set_Name("Button14");
		((Control)Bp7()).set_Size(new Size(58, 23));
		((Control)Bp7()).set_TabIndex(92);
		((ButtonBase)Bp7()).set_Text("Book");
		((ButtonBase)Bp7()).set_UseVisualStyleBackColor(false);
		((Label)a6L()).set_AutoSize(true);
		((Control)a6L()).set_BackColor(Color.Transparent);
		a6L().set_LinkColor(Color.White);
		((Control)a6L()).set_Location(new Point(679, 40));
		((Control)a6L()).set_Name("linklogout");
		((Control)a6L()).set_Size(new Size(40, 13));
		((Control)a6L()).set_TabIndex(93);
		a6L().set_TabStop(true);
		a6L().set_Text("Logout");
		((Control)Pg8()).set_Location(new Point(-1, 188));
		((Control)Pg8()).set_Name("PictureBox19");
		((Control)Pg8()).set_Size(new Size(172, 198));
		Pg8().set_SizeMode((PictureBoxSizeMode)1);
		Pg8().set_TabIndex(94);
		Pg8().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(780, 533));
		((Control)this).get_Controls().Add((Control)(object)Pg8());
		((Control)this).get_Controls().Add((Control)(object)a6L());
		((Control)this).get_Controls().Add((Control)(object)Bp7());
		((Control)this).get_Controls().Add((Control)(object)d8T());
		((Control)this).get_Controls().Add((Control)(object)f6A());
		((Control)this).get_Controls().Add((Control)(object)Ro1());
		((Control)this).get_Controls().Add((Control)(object)Ri6());
		((Control)this).get_Controls().Add((Control)(object)Bs0());
		((Control)this).get_Controls().Add((Control)(object)s7T());
		((Control)this).get_Controls().Add((Control)(object)p7A());
		((Control)this).get_Controls().Add((Control)(object)Tx4());
		((Control)this).get_Controls().Add((Control)(object)k9R());
		((Control)this).get_Controls().Add((Control)(object)n2B());
		((Control)this).get_Controls().Add((Control)(object)k5C());
		((Control)this).get_Controls().Add((Control)(object)Jf4());
		((Control)this).get_Controls().Add((Control)(object)w2D());
		((Control)this).get_Controls().Add((Control)(object)d8H());
		((Control)this).get_Controls().Add((Control)(object)r2B());
		((Control)this).get_Controls().Add((Control)(object)k0D());
		((Control)this).get_Controls().Add((Control)(object)Yk1());
		((Control)this).get_Controls().Add((Control)(object)b6L());
		((Control)this).get_Controls().Add((Control)(object)Qm1());
		((Control)this).get_Controls().Add((Control)(object)Jn0());
		((Control)this).get_Controls().Add((Control)(object)a9Y());
		((Control)this).get_Controls().Add((Control)(object)t7N());
		((Control)this).get_Controls().Add((Control)(object)Xa7());
		((Control)this).get_Controls().Add((Control)(object)j3W());
		((Control)this).get_Controls().Add((Control)(object)Fy3());
		((Control)this).get_Controls().Add((Control)(object)o4F());
		((Control)this).get_Controls().Add((Control)(object)z1N());
		((Control)this).get_Controls().Add((Control)(object)z9D());
		((Control)this).get_Controls().Add((Control)(object)Re1());
		((Control)this).get_Controls().Add((Control)(object)f1A());
		((Control)this).get_Controls().Add((Control)(object)No8());
		((Control)this).get_Controls().Add((Control)(object)w8Z());
		((Control)this).get_Controls().Add((Control)(object)Pk4());
		((Control)this).get_Controls().Add((Control)(object)Qx9());
		((Control)this).get_Controls().Add((Control)(object)Gd9());
		((Control)this).get_Controls().Add((Control)(object)Zd5());
		((Control)this).get_Controls().Add((Control)(object)s7Z());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Menu_Admin");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("MENU");
		((ISupportInitialize)w2D()).EndInit();
		((ISupportInitialize)d8H()).EndInit();
		((ISupportInitialize)r2B()).EndInit();
		((ISupportInitialize)k0D()).EndInit();
		((ISupportInitialize)Yk1()).EndInit();
		((ISupportInitialize)b6L()).EndInit();
		((ISupportInitialize)Qm1()).EndInit();
		((ISupportInitialize)Jn0()).EndInit();
		((ISupportInitialize)a9Y()).EndInit();
		((ISupportInitialize)t7N()).EndInit();
		((ISupportInitialize)Xa7()).EndInit();
		((ISupportInitialize)j3W()).EndInit();
		((ISupportInitialize)o4F()).EndInit();
		((ISupportInitialize)Re1()).EndInit();
		((ISupportInitialize)f1A()).EndInit();
		((ISupportInitialize)No8()).EndInit();
		((ISupportInitialize)Zd5()).EndInit();
		((ISupportInitialize)s7Z()).EndInit();
		((ISupportInitialize)Pg8()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Bs0()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6S(Label Wm8)
	{
		_Label14 = Wm8;
	}

	[SpecialName]
	internal virtual Label s7T()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nc1(Label f8S)
	{
		Label val = (q = f8S);
	}

	[SpecialName]
	internal virtual Label p7A()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp0(Label Tk2)
	{
		Label val = (g = Tk2);
	}

	[SpecialName]
	internal virtual Label Tx4()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2Y(Label Pc9)
	{
		_Label11 = Pc9;
	}

	[SpecialName]
	internal virtual Label k9R()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7Q(Label p7A)
	{
		Label val = (t = p7A);
	}

	[SpecialName]
	internal virtual Label n2B()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xc6(Label Cf1)
	{
		Label val = (c = Cf1);
	}

	[SpecialName]
	internal virtual Label k5C()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6N(Label r9S)
	{
		Label val = (v = r9S);
	}

	[SpecialName]
	internal virtual Label Jf4()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lb0(Label Ei1)
	{
		_Label7 = Ei1;
	}

	[SpecialName]
	internal virtual PictureBox w2D()
	{
		return _PictureBox22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0M(PictureBox n7W)
	{
		_PictureBox22 = n7W;
	}

	[SpecialName]
	internal virtual PictureBox d8H()
	{
		return _PictureBox21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9T(PictureBox q1Z)
	{
		_PictureBox21 = q1Z;
	}

	[SpecialName]
	internal virtual PictureBox r2B()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7F(PictureBox x3N)
	{
		PictureBox val = (o = x3N);
	}

	[SpecialName]
	internal virtual PictureBox k0D()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8H(PictureBox k1W)
	{
		PictureBox val = (h = k1W);
	}

	[SpecialName]
	internal virtual PictureBox Yk1()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz4(PictureBox Qz1)
	{
		PictureBox val = (W = Qz1);
	}

	[SpecialName]
	internal virtual PictureBox b6L()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8Z(PictureBox j8D)
	{
		PictureBox val = (L = j8D);
	}

	[SpecialName]
	internal virtual PictureBox Qm1()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8L(PictureBox s8Q)
	{
		PictureBox val = (y = s8Q);
	}

	[SpecialName]
	internal virtual PictureBox Jn0()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0Y(PictureBox Kk9)
	{
		PictureBox val = (i = Kk9);
	}

	[SpecialName]
	internal virtual PictureBox a9Y()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fa8(PictureBox y0Z)
	{
		_PictureBox13 = y0Z;
	}

	[SpecialName]
	internal virtual PictureBox t7N()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5S(PictureBox a6F)
	{
		PictureBox val = (b = a6F);
	}

	[SpecialName]
	internal virtual PictureBox Xa7()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4B(PictureBox j2A)
	{
		_PictureBox11 = j2A;
	}

	[SpecialName]
	internal virtual PictureBox j3W()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dw0(PictureBox s2P)
	{
		_PictureBox10 = s2P;
	}

	[SpecialName]
	internal virtual Label Fy3()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4K(Label Qp8)
	{
		Label val = (F = Qp8);
	}

	[SpecialName]
	internal virtual PictureBox o4F()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5C(PictureBox r0E)
	{
		PictureBox val = (S = r0E);
	}

	[SpecialName]
	internal virtual Label z1N()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf9(Label r5T)
	{
		_Label5 = r5T;
	}

	[SpecialName]
	internal virtual Label z9D()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bf3(Label Jd2)
	{
		Label val = (X = Jd2);
	}

	[SpecialName]
	internal virtual PictureBox Re1()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4B(PictureBox k9Z)
	{
		PictureBox val = (m = k9Z);
	}

	[SpecialName]
	internal virtual PictureBox f1A()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pc7(PictureBox z4L)
	{
		PictureBox val = (p = z4L);
	}

	[SpecialName]
	internal virtual PictureBox No8()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2W(PictureBox x3S)
	{
		_PictureBox6 = x3S;
	}

	[SpecialName]
	internal virtual Label w8Z()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7T(Label c9H)
	{
		Label val = (a = c9H);
	}

	[SpecialName]
	internal virtual Label Pk4()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0H(Label e3G)
	{
		Label val = (J = e3G);
	}

	[SpecialName]
	internal virtual Label Qx9()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cq6(Label Ad6)
	{
		_Label2 = Ad6;
	}

	[SpecialName]
	internal virtual Label Gd9()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8M(Label Nb4)
	{
		Label val = (r = Nb4);
	}

	[SpecialName]
	internal virtual PictureBox Zd5()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7K(PictureBox Qa1)
	{
		PictureBox val = (U = Qa1);
	}

	[SpecialName]
	internal virtual Timer c1L()
	{
		return _Timer1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hn3(Timer i7K)
	{
		EventHandler eventHandler = f9E;
		Timer timer = _Timer1;
		if (timer != null)
		{
			timer.remove_Tick(eventHandler);
		}
		_Timer1 = i7K;
		timer = _Timer1;
		if (timer != null)
		{
			timer.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox s7Z()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn9(PictureBox Ad2)
	{
		_PictureBox1 = Ad2;
	}

	[SpecialName]
	internal virtual Button Ri6()
	{
		return _btnCinema1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga4(Button Ef2)
	{
		EventHandler eventHandler = p9W;
		Button btnCinema = _btnCinema1;
		if (btnCinema != null)
		{
			((Control)btnCinema).remove_Click(eventHandler);
		}
		_btnCinema1 = Ef2;
		btnCinema = _btnCinema1;
		if (btnCinema != null)
		{
			((Control)btnCinema).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ro1()
	{
		return _btnCinema4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8T(Button y2L)
	{
		EventHandler eventHandler = t9G;
		Button btnCinema = _btnCinema4;
		if (btnCinema != null)
		{
			((Control)btnCinema).remove_Click(eventHandler);
		}
		_btnCinema4 = y2L;
		btnCinema = _btnCinema4;
		if (btnCinema != null)
		{
			((Control)btnCinema).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button f6A()
	{
		return _btnCinema2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9X(Button q3M)
	{
		EventHandler eventHandler = Cd8;
		Button btnCinema = _btnCinema2;
		if (btnCinema != null)
		{
			((Control)btnCinema).remove_Click(eventHandler);
		}
		_btnCinema2 = q3M;
		btnCinema = _btnCinema2;
		if (btnCinema != null)
		{
			((Control)btnCinema).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button d8T()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg3(Button n7K)
	{
		EventHandler eventHandler = f5J;
		Button val = n;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (n = n7K);
		val = n;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Bp7()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Df3(Button Rq8)
	{
		Button val = (E = Rq8);
	}

	[SpecialName]
	internal virtual LinkLabel a6L()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj8(LinkLabel Bk0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(Ts4);
		LinkLabel d = D;
		if (d != null)
		{
			d.remove_LinkClicked(val);
		}
		LinkLabel val2 = (D = Bk0);
		d = D;
		if (d != null)
		{
			d.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual PictureBox Pg8()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6M(PictureBox Ab5)
	{
		_PictureBox19 = Ab5;
	}

	private void Ts4(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Are you sure you want to leave the system?", "Exit", (MessageBoxButtons)4, (MessageBoxIcon)32);
		((Form)this).Close();
		((TextBoxBase)Mi0.Forms.r8Z().f9N()).Clear();
		((TextBoxBase)Mi0.Forms.r8Z().d0M()).Clear();
		((Control)Mi0.Forms.r8Z()).Show();
	}

	private void p9W(object sender, EventArgs e)
	{
		((Control)Mi0.Forms.w0M()).Show();
	}

	private void Cd8(object sender, EventArgs e)
	{
		((Control)Mi0.Forms.n1J()).Show();
	}

	private void f5J(object sender, EventArgs e)
	{
		((Control)Mi0.Forms.Cf4()).Show();
	}

	private void t9G(object sender, EventArgs e)
	{
		((Control)Mi0.Forms.Dx8()).Show();
	}

	private void c5A(object sender, EventArgs e)
	{
		c1L().Start();
		Pk4().set_Text(Conversions.ToString(DateTime.Today));
	}

	private void f9E(object sender, EventArgs e)
	{
		w8Z().set_Text(Conversions.ToString(DateAndTime.get_TimeOfDay()));
	}

	internal static byte[] d3Q(string[] c6J, int Qw9)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[c6J.Length - 1 + 1];
				int num = c6J.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (c6J[i].Contains(value))
						{
							int startIndex = c6J[i].IndexOf(value);
							array[i] = c6J[i].Remove(startIndex, 10);
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Ws4.mDic["AO"]);
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

	static Qc0()
	{
		s = new char[2121];
		char[] array = new char[8];
		array[3] = 'ㅣ';
		array[2] = '\u05bb';
		array[7] = 'ⶠ';
		array[1] = '\u2d6c';
		array[4] = '\u0b7f';
		array[5] = '㽑';
		array[6] = 'ځ';
		array[0] = 'ᴜ';
		Qc0.X = new string[148];
		Qc0.J = array;
	}
}
