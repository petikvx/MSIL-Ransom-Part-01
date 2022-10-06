using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Cg6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qm3;
using z2C5;

namespace Xc5;

[DesignerGenerated]
public class e9B : Form
{
	private Label _Label5;

	private Label _Label7;

	private TextBox _TxtStat;

	private TextBox _TxtMedic;

	private TextBox _TxtEntertain;

	private TextBox _TxtMarket;

	private TextBox _TxtOther;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox6;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox10;

	private Label _Label9;

	private Label _Label10;

	private GroupBox _GroupBox1;

	private Label _Label11;

	private TextBox _TxtExpenses;

	private SqlCommand Sqlcmd;

	private DataSet Sqlds;

	internal IContainer J;

	internal PictureBox H;

	internal Label F;

	internal Label S;

	internal Label N;

	internal Label c;

	internal Label G;

	internal Label b;

	internal TextBox P;

	internal TextBox o;

	internal TextBox X;

	internal PictureBox E;

	internal PictureBox w;

	internal TextBox Q;

	internal PictureBox m;

	internal Label T;

	internal TextBox u;

	internal PictureBox a;

	internal Button Y;

	internal SqlConnection K;

	internal SqlDataAdapter i;

	public e9B()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)b4B);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		SqlConnection val2 = (K = val);
		Sqlcmd = new SqlCommand();
		SqlDataAdapter val3 = (i = new SqlDataAdapter());
		Sqlds = new DataSet();
		m1A();
	}

	protected override void p2A(bool s5Y)
	{
		try
		{
			if (s5Y && J != null)
			{
				J.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s5Y);
		}
	}

	private void m1A()
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
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		//IL_0920: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Expected O, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected O, but got Unknown
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected O, but got Unknown
		//IL_0ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bae: Expected O, but got Unknown
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4f: Expected O, but got Unknown
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf0: Expected O, but got Unknown
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Expected O, but got Unknown
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected O, but got Unknown
		//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Expected O, but got Unknown
		//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f52: Expected O, but got Unknown
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fea: Expected O, but got Unknown
		//IL_1078: Unknown result type (might be due to invalid IL or missing references)
		//IL_1082: Expected O, but got Unknown
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_111d: Expected O, but got Unknown
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b8: Expected O, but got Unknown
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected O, but got Unknown
		//IL_12e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f0: Expected O, but got Unknown
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Expected O, but got Unknown
		//IL_1433: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Expected O, but got Unknown
		//IL_14d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e3: Expected O, but got Unknown
		//IL_156e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1578: Expected O, but got Unknown
		//IL_1600: Unknown result type (might be due to invalid IL or missing references)
		//IL_160a: Expected O, but got Unknown
		//IL_1795: Unknown result type (might be due to invalid IL or missing references)
		//IL_179f: Expected O, but got Unknown
		//IL_182a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1834: Expected O, but got Unknown
		//IL_18b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c3: Expected O, but got Unknown
		//IL_1962: Unknown result type (might be due to invalid IL or missing references)
		//IL_196c: Expected O, but got Unknown
		//IL_1a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a22: Expected O, but got Unknown
		//IL_1c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(e9B));
		c0G(new PictureBox());
		c9Q(new Label());
		f7W(new Label());
		f3Z(new Label());
		c0L(new Label());
		a4T(new Label());
		y7F(new Label());
		m4T(new Label());
		Bo6(new Label());
		p9P(new TextBox());
		Zy8(new TextBox());
		Pg6(new TextBox());
		p8B(new TextBox());
		Gj6(new TextBox());
		Yo2(new TextBox());
		k8L(new TextBox());
		Mx6(new TextBox());
		Wc1(new PictureBox());
		e5A(new PictureBox());
		Ta2(new PictureBox());
		b9M(new PictureBox());
		e2H(new PictureBox());
		Sg7(new PictureBox());
		q4H(new PictureBox());
		f7K(new PictureBox());
		g1R(new PictureBox());
		Rz9(new TextBox());
		g6S(new Label());
		Tt5(new PictureBox());
		Xe1(new Label());
		e9Q(new Label());
		Tf6(new TextBox());
		Ca4(new GroupBox());
		Lt5(new Label());
		w8G(new TextBox());
		Lc2(new PictureBox());
		b3A(new Button());
		((ISupportInitialize)x4H()).BeginInit();
		((ISupportInitialize)Tg2()).BeginInit();
		((ISupportInitialize)Dz6()).BeginInit();
		((ISupportInitialize)Cr6()).BeginInit();
		((ISupportInitialize)i7F()).BeginInit();
		((ISupportInitialize)m3A()).BeginInit();
		((ISupportInitialize)Km5()).BeginInit();
		((ISupportInitialize)Gb6()).BeginInit();
		((ISupportInitialize)m0Q()).BeginInit();
		((ISupportInitialize)Jj6()).BeginInit();
		((ISupportInitialize)Ld1()).BeginInit();
		((Control)f9S()).SuspendLayout();
		((ISupportInitialize)r7H()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)x4H()).set_Anchor((AnchorStyles)15);
		((Control)x4H()).set_BackColor(Color.Transparent);
		((Control)x4H()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)x4H()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)x4H()).set_Location(new Point(253, 1));
		((Control)x4H()).set_Name("PictureBox1");
		((Control)x4H()).set_Size(new Size(318, 48));
		x4H().set_TabIndex(0);
		x4H().set_TabStop(false);
		((Control)Mz8()).set_Anchor((AnchorStyles)15);
		Mz8().set_AutoSize(true);
		((Control)Mz8()).set_BackColor(Color.AliceBlue);
		((Control)Mz8()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Mz8()).set_ForeColor(Color.Navy);
		((Control)Mz8()).set_Location(new Point(127, 168));
		((Control)Mz8()).set_Name("Label1");
		((Control)Mz8()).set_Size(new Size(58, 21));
		((Control)Mz8()).set_TabIndex(1);
		Mz8().set_Text("Food :");
		((Control)Ec3()).set_Anchor((AnchorStyles)15);
		Ec3().set_AutoSize(true);
		((Control)Ec3()).set_BackColor(Color.AliceBlue);
		((Control)Ec3()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ec3()).set_ForeColor(Color.Navy);
		((Control)Ec3()).set_Location(new Point(518, 174));
		((Control)Ec3()).set_Name("Label2");
		((Control)Ec3()).set_Size(new Size(76, 21));
		((Control)Ec3()).set_TabIndex(2);
		Ec3().set_Text("Clothes :");
		((Control)Hf7()).set_Anchor((AnchorStyles)15);
		Hf7().set_AutoSize(true);
		((Control)Hf7()).set_BackColor(Color.AliceBlue);
		((Control)Hf7()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Hf7()).set_ForeColor(Color.Navy);
		((Control)Hf7()).set_Location(new Point(172, 255));
		((Control)Hf7()).set_Name("Label3");
		((Control)Hf7()).set_Size(new Size(125, 21));
		((Control)Hf7()).set_TabIndex(3);
		Hf7().set_Text("Entertainment :");
		((Control)Hq3()).set_Anchor((AnchorStyles)15);
		Hq3().set_AutoSize(true);
		((Control)Hq3()).set_BackColor(Color.AliceBlue);
		((Control)Hq3()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Hq3()).set_ForeColor(Color.Navy);
		((Control)Hq3()).set_Location(new Point(614, 255));
		((Control)Hq3()).set_Name("Label4");
		((Control)Hq3()).set_Size(new Size(75, 21));
		((Control)Hq3()).set_TabIndex(4);
		Hq3().set_Text("Market :");
		((Control)Fz3()).set_Anchor((AnchorStyles)15);
		Fz3().set_AutoSize(true);
		((Control)Fz3()).set_BackColor(Color.AliceBlue);
		((Control)Fz3()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Fz3()).set_ForeColor(Color.Navy);
		((Control)Fz3()).set_Location(new Point(587, 435));
		((Control)Fz3()).set_Name("Label5");
		((Control)Fz3()).set_Size(new Size(74, 21));
		((Control)Fz3()).set_TabIndex(5);
		Fz3().set_Text("Others :");
		((Control)Xj2()).set_Anchor((AnchorStyles)15);
		Xj2().set_AutoSize(true);
		((Control)Xj2()).set_BackColor(Color.AliceBlue);
		((Control)Xj2()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Xj2()).set_ForeColor(Color.Navy);
		((Control)Xj2()).set_Location(new Point(173, 436));
		((Control)Xj2()).set_Name("Label6");
		((Control)Xj2()).set_Size(new Size(94, 21));
		((Control)Xj2()).set_TabIndex(6);
		Xj2().set_Text("Transport :");
		((Control)Rm4()).set_Anchor((AnchorStyles)15);
		Rm4().set_AutoSize(true);
		((Control)Rm4()).set_BackColor(Color.AliceBlue);
		((Control)Rm4()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Rm4()).set_ForeColor(Color.Navy);
		((Control)Rm4()).set_Location(new Point(527, 346));
		((Control)Rm4()).set_Name("Label7");
		((Control)Rm4()).set_Size(new Size(78, 21));
		((Control)Rm4()).set_TabIndex(7);
		Rm4().set_Text("Medical :");
		((Control)Kk5()).set_Anchor((AnchorStyles)15);
		Kk5().set_AutoSize(true);
		((Control)Kk5()).set_BackColor(Color.AliceBlue);
		((Control)Kk5()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Kk5()).set_ForeColor(Color.Navy);
		((Control)Kk5()).set_Location(new Point(127, 348));
		((Control)Kk5()).set_Name("Label8");
		((Control)Kk5()).set_Size(new Size(99, 21));
		((Control)Kk5()).set_TabIndex(8);
		Kk5().set_Text("Stationary :");
		((Control)p6S()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)p6S()).set_BackColor(Color.Azure);
		((Control)p6S()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)p6S()).set_ForeColor(Color.Navy);
		((Control)p6S()).set_Location(new Point(191, 168));
		p6S().set_Multiline(true);
		((Control)p6S()).set_Name("TxtFood");
		((Control)p6S()).set_Size(new Size(105, 26));
		((Control)p6S()).set_TabIndex(9);
		((Control)Cc0()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Cc0()).set_BackColor(Color.Azure);
		((Control)Cc0()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Cc0()).set_ForeColor(Color.Navy);
		((Control)Cc0()).set_Location(new Point(599, 171));
		Cc0().set_Multiline(true);
		((Control)Cc0()).set_Name("TxtCloth");
		((Control)Cc0()).set_Size(new Size(103, 26));
		((Control)Cc0()).set_TabIndex(10);
		((Control)w9E()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)w9E()).set_BackColor(Color.Azure);
		((Control)w9E()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)w9E()).set_ForeColor(Color.Navy);
		((Control)w9E()).set_Location(new Point(231, 346));
		w9E().set_Multiline(true);
		((Control)w9E()).set_Name("TxtStat");
		((Control)w9E()).set_Size(new Size(103, 26));
		((Control)w9E()).set_TabIndex(11);
		((Control)s8C()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)s8C()).set_BackColor(Color.Azure);
		((Control)s8C()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)s8C()).set_ForeColor(Color.Navy);
		((Control)s8C()).set_Location(new Point(615, 341));
		s8C().set_Multiline(true);
		((Control)s8C()).set_Name("TxtMedic");
		((Control)s8C()).set_Size(new Size(103, 26));
		((Control)s8C()).set_TabIndex(12);
		((Control)Cp8()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Cp8()).set_BackColor(Color.Azure);
		((Control)Cp8()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Cp8()).set_ForeColor(Color.Navy);
		((Control)Cp8()).set_Location(new Point(304, 254));
		Cp8().set_Multiline(true);
		((Control)Cp8()).set_Name("TxtEntertain");
		((Control)Cp8()).set_Size(new Size(103, 26));
		((Control)Cp8()).set_TabIndex(13);
		((Control)b9C()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)b9C()).set_BackColor(Color.Azure);
		((Control)b9C()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)b9C()).set_ForeColor(Color.Navy);
		((Control)b9C()).set_Location(new Point(282, 435));
		b9C().set_Multiline(true);
		((Control)b9C()).set_Name("TxtTrans");
		((Control)b9C()).set_Size(new Size(103, 26));
		((Control)b9C()).set_TabIndex(14);
		((Control)Ts2()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Ts2()).set_BackColor(Color.Azure);
		((Control)Ts2()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Ts2()).set_ForeColor(Color.Navy);
		((Control)Ts2()).set_Location(new Point(699, 254));
		Ts2().set_Multiline(true);
		((Control)Ts2()).set_Name("TxtMarket");
		((Control)Ts2()).set_Size(new Size(103, 26));
		((Control)Ts2()).set_TabIndex(15);
		((Control)i8E()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)i8E()).set_BackColor(Color.Azure);
		((Control)i8E()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)i8E()).set_ForeColor(Color.Navy);
		((Control)i8E()).set_Location(new Point(678, 435));
		i8E().set_Multiline(true);
		((Control)i8E()).set_Name("TxtOther");
		((Control)i8E()).set_Size(new Size(103, 26));
		((Control)i8E()).set_TabIndex(16);
		((Control)Tg2()).set_Anchor((AnchorStyles)15);
		((Control)Tg2()).set_BackColor(Color.Transparent);
		((Control)Tg2()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)Tg2()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Tg2()).set_Location(new Point(3, 1));
		((Control)Tg2()).set_Name("PictureBox2");
		((Control)Tg2()).set_Size(new Size(107, 83));
		Tg2().set_TabIndex(34);
		Tg2().set_TabStop(false);
		((Control)Dz6()).set_Anchor((AnchorStyles)15);
		((Control)Dz6()).set_BackColor(Color.Transparent);
		((Control)Dz6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Dz6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Dz6()).set_Location(new Point(45, 147));
		((Control)Dz6()).set_Name("PictureBox3");
		((Control)Dz6()).set_Size(new Size(76, 66));
		Dz6().set_TabIndex(35);
		Dz6().set_TabStop(false);
		((Control)Cr6()).set_Anchor((AnchorStyles)15);
		((Control)Cr6()).set_BackColor(Color.Transparent);
		((Control)Cr6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)Cr6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Cr6()).set_Location(new Point(82, 232));
		((Control)Cr6()).set_Name("PictureBox4");
		((Control)Cr6()).set_Size(new Size(76, 66));
		Cr6().set_TabIndex(36);
		Cr6().set_TabStop(false);
		((Control)i7F()).set_Anchor((AnchorStyles)15);
		((Control)i7F()).set_BackColor(Color.Transparent);
		((Control)i7F()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox6.BackgroundImage"));
		((Control)i7F()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)i7F()).set_Location(new Point(45, 325));
		((Control)i7F()).set_Name("PictureBox6");
		((Control)i7F()).set_Size(new Size(76, 66));
		i7F().set_TabIndex(37);
		i7F().set_TabStop(false);
		((Control)m3A()).set_Anchor((AnchorStyles)15);
		((Control)m3A()).set_BackColor(Color.Transparent);
		((Control)m3A()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox7.BackgroundImage"));
		((Control)m3A()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)m3A()).set_Location(new Point(82, 414));
		((Control)m3A()).set_Name("PictureBox7");
		((Control)m3A()).set_Size(new Size(76, 66));
		m3A().set_TabIndex(38);
		m3A().set_TabStop(false);
		((Control)Km5()).set_Anchor((AnchorStyles)15);
		((Control)Km5()).set_BackColor(Color.Transparent);
		((Control)Km5()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox8.BackgroundImage"));
		((Control)Km5()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Km5()).set_Location(new Point(442, 325));
		((Control)Km5()).set_Name("PictureBox8");
		((Control)Km5()).set_Size(new Size(70, 66));
		Km5().set_TabIndex(39);
		Km5().set_TabStop(false);
		((Control)Gb6()).set_Anchor((AnchorStyles)15);
		((Control)Gb6()).set_BackColor(Color.Transparent);
		((Control)Gb6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox9.BackgroundImage"));
		((Control)Gb6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Gb6()).set_Location(new Point(431, 147));
		((Control)Gb6()).set_Name("PictureBox9");
		((Control)Gb6()).set_Size(new Size(81, 66));
		Gb6().set_TabIndex(40);
		Gb6().set_TabStop(false);
		((Control)m0Q()).set_Anchor((AnchorStyles)15);
		((Control)m0Q()).set_BackColor(Color.Transparent);
		((Control)m0Q()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox10.BackgroundImage"));
		((Control)m0Q()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)m0Q()).set_Location(new Point(501, 414));
		((Control)m0Q()).set_Name("PictureBox10");
		((Control)m0Q()).set_Size(new Size(70, 66));
		m0Q().set_TabIndex(41);
		m0Q().set_TabStop(false);
		((Control)Jj6()).set_Anchor((AnchorStyles)15);
		((Control)Jj6()).set_BackColor(Color.Transparent);
		((Control)Jj6()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox11.BackgroundImage"));
		((Control)Jj6()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Jj6()).set_Location(new Point(490, 232));
		((Control)Jj6()).set_Name("PictureBox11");
		((Control)Jj6()).set_Size(new Size(81, 66));
		Jj6().set_TabIndex(42);
		Jj6().set_TabStop(false);
		((Control)s7S()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)s7S()).set_BackColor(Color.Azure);
		((Control)s7S()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)s7S()).set_ForeColor(Color.Navy);
		((Control)s7S()).set_Location(new Point(409, 86));
		s7S().set_Multiline(true);
		((Control)s7S()).set_Name("TxtBal");
		((Control)s7S()).set_Size(new Size(162, 26));
		((Control)s7S()).set_TabIndex(44);
		((Control)n2T()).set_Anchor((AnchorStyles)15);
		n2T().set_AutoSize(true);
		((Control)n2T()).set_BackColor(Color.AliceBlue);
		((Control)n2T()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n2T()).set_ForeColor(Color.Navy);
		((Control)n2T()).set_Location(new Point(319, 86));
		((Control)n2T()).set_Name("Label9");
		((Control)n2T()).set_Size(new Size(84, 21));
		((Control)n2T()).set_TabIndex(43);
		n2T().set_Text("Balance : ");
		((Control)Ld1()).set_Anchor((AnchorStyles)15);
		((Control)Ld1()).set_BackColor(Color.Transparent);
		((Control)Ld1()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox13.BackgroundImage"));
		((Control)Ld1()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ld1()).set_Location(new Point(241, 65));
		((Control)Ld1()).set_Name("PictureBox13");
		((Control)Ld1()).set_Size(new Size(72, 58));
		Ld1().set_TabIndex(46);
		Ld1().set_TabStop(false);
		((Control)Fs1()).set_Anchor((AnchorStyles)15);
		Fs1().set_AutoSize(true);
		((Control)Fs1()).set_BackColor(Color.Transparent);
		((Control)Fs1()).set_Font(new Font("AR JULIAN", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Fs1()).set_ForeColor(Color.FromArgb(0, 64, 64));
		((Control)Fs1()).set_Location(new Point(724, 9));
		((Control)Fs1()).set_Name("LblNam");
		((Control)Fs1()).set_Size(new Size(0, 18));
		((Control)Fs1()).set_TabIndex(47);
		Ns2().set_AutoSize(true);
		((Control)Ns2()).set_BackColor(Color.Transparent);
		((Control)Ns2()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ns2()).set_ForeColor(Color.Navy);
		((Control)Ns2()).set_Location(new Point(24, 34));
		((Control)Ns2()).set_Name("Label10");
		((Control)Ns2()).set_Size(new Size(120, 21));
		((Control)Ns2()).set_TabIndex(48);
		Ns2().set_Text("Total Income :");
		((TextBoxBase)j3Y()).set_BackColor(Color.Azure);
		((Control)j3Y()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)j3Y()).set_ForeColor(Color.Navy);
		((Control)j3Y()).set_Location(new Point(162, 29));
		j3Y().set_Multiline(true);
		((Control)j3Y()).set_Name("TxtIncome");
		((Control)j3Y()).set_Size(new Size(126, 26));
		((Control)j3Y()).set_TabIndex(49);
		((Control)f9S()).set_Anchor((AnchorStyles)15);
		((Control)f9S()).set_BackColor(Color.Transparent);
		((Control)f9S()).get_Controls().Add((Control)(object)Zi0());
		((Control)f9S()).get_Controls().Add((Control)(object)Ay9());
		((Control)f9S()).get_Controls().Add((Control)(object)r7H());
		((Control)f9S()).get_Controls().Add((Control)(object)Db4());
		((Control)f9S()).get_Controls().Add((Control)(object)Ns2());
		((Control)f9S()).get_Controls().Add((Control)(object)j3Y());
		((Control)f9S()).set_Location(new Point(62, 486));
		((Control)f9S()).set_Name("GroupBox1");
		((Control)f9S()).set_Size(new Size(710, 121));
		((Control)f9S()).set_TabIndex(50);
		f9S().set_TabStop(false);
		Zi0().set_AutoSize(true);
		((Control)Zi0()).set_BackColor(Color.Transparent);
		((Control)Zi0()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Zi0()).set_ForeColor(Color.Navy);
		((Control)Zi0()).set_Location(new Point(392, 34));
		((Control)Zi0()).set_Name("Label11");
		((Control)Zi0()).set_Size(new Size(125, 21));
		((Control)Zi0()).set_TabIndex(52);
		Zi0().set_Text("Total Expense :");
		((TextBoxBase)Ay9()).set_BackColor(Color.Azure);
		((Control)Ay9()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Ay9()).set_ForeColor(Color.Navy);
		((Control)Ay9()).set_Location(new Point(530, 29));
		Ay9().set_Multiline(true);
		((Control)Ay9()).set_Name("TxtExpenses");
		((Control)Ay9()).set_Size(new Size(126, 26));
		((Control)Ay9()).set_TabIndex(53);
		((Control)r7H()).set_BackColor(Color.Transparent);
		((Control)r7H()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)r7H()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)r7H()).set_Location(new Point(274, 77));
		((Control)r7H()).set_Name("PictureBox5");
		((Control)r7H()).set_Size(new Size(52, 35));
		r7H().set_TabIndex(51);
		r7H().set_TabStop(false);
		((ButtonBase)Db4()).set_BackColor(Color.Azure);
		((Control)Db4()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Db4()).set_FlatStyle((FlatStyle)0);
		((Control)Db4()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Db4()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)Db4()).set_Location(new Point(322, 86));
		((Control)Db4()).set_Name("Button9");
		((Control)Db4()).set_Size(new Size(110, 26));
		((Control)Db4()).set_TabIndex(50);
		((ButtonBase)Db4()).set_Text("&Main Menu");
		((ButtonBase)Db4()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)Db4()).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(843, 619));
		((Control)this).get_Controls().Add((Control)(object)f9S());
		((Control)this).get_Controls().Add((Control)(object)Fs1());
		((Control)this).get_Controls().Add((Control)(object)Ld1());
		((Control)this).get_Controls().Add((Control)(object)s7S());
		((Control)this).get_Controls().Add((Control)(object)n2T());
		((Control)this).get_Controls().Add((Control)(object)Jj6());
		((Control)this).get_Controls().Add((Control)(object)m0Q());
		((Control)this).get_Controls().Add((Control)(object)Gb6());
		((Control)this).get_Controls().Add((Control)(object)Km5());
		((Control)this).get_Controls().Add((Control)(object)m3A());
		((Control)this).get_Controls().Add((Control)(object)i7F());
		((Control)this).get_Controls().Add((Control)(object)Cr6());
		((Control)this).get_Controls().Add((Control)(object)Dz6());
		((Control)this).get_Controls().Add((Control)(object)Tg2());
		((Control)this).get_Controls().Add((Control)(object)i8E());
		((Control)this).get_Controls().Add((Control)(object)Ts2());
		((Control)this).get_Controls().Add((Control)(object)b9C());
		((Control)this).get_Controls().Add((Control)(object)Cp8());
		((Control)this).get_Controls().Add((Control)(object)s8C());
		((Control)this).get_Controls().Add((Control)(object)w9E());
		((Control)this).get_Controls().Add((Control)(object)Cc0());
		((Control)this).get_Controls().Add((Control)(object)p6S());
		((Control)this).get_Controls().Add((Control)(object)Kk5());
		((Control)this).get_Controls().Add((Control)(object)Rm4());
		((Control)this).get_Controls().Add((Control)(object)Xj2());
		((Control)this).get_Controls().Add((Control)(object)Fz3());
		((Control)this).get_Controls().Add((Control)(object)Hq3());
		((Control)this).get_Controls().Add((Control)(object)Hf7());
		((Control)this).get_Controls().Add((Control)(object)Ec3());
		((Control)this).get_Controls().Add((Control)(object)Mz8());
		((Control)this).get_Controls().Add((Control)(object)x4H());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form12");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Expense Manager");
		((ISupportInitialize)x4H()).EndInit();
		((ISupportInitialize)Tg2()).EndInit();
		((ISupportInitialize)Dz6()).EndInit();
		((ISupportInitialize)Cr6()).EndInit();
		((ISupportInitialize)i7F()).EndInit();
		((ISupportInitialize)m3A()).EndInit();
		((ISupportInitialize)Km5()).EndInit();
		((ISupportInitialize)Gb6()).EndInit();
		((ISupportInitialize)m0Q()).EndInit();
		((ISupportInitialize)Jj6()).EndInit();
		((ISupportInitialize)Ld1()).EndInit();
		((Control)f9S()).ResumeLayout(false);
		((Control)f9S()).PerformLayout();
		((ISupportInitialize)r7H()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox x4H()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0G(PictureBox Ym8)
	{
		PictureBox val = (H = Ym8);
	}

	[SpecialName]
	internal virtual Label Mz8()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9Q(Label Qp6)
	{
		Label val = (F = Qp6);
	}

	[SpecialName]
	internal virtual Label Ec3()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7W(Label Yn0)
	{
		Label val = (S = Yn0);
	}

	[SpecialName]
	internal virtual Label Hf7()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3Z(Label a2R)
	{
		Label val = (N = a2R);
	}

	[SpecialName]
	internal virtual Label Hq3()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0L(Label Wd8)
	{
		Label val = (c = Wd8);
	}

	[SpecialName]
	internal virtual Label Fz3()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4T(Label j8J)
	{
		_Label5 = j8J;
	}

	[SpecialName]
	internal virtual Label Xj2()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7F(Label Cq5)
	{
		Label val = (G = Cq5);
	}

	[SpecialName]
	internal virtual Label Rm4()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4T(Label x4K)
	{
		_Label7 = x4K;
	}

	[SpecialName]
	internal virtual Label Kk5()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bo6(Label Qr8)
	{
		Label val = (b = Qr8);
	}

	[SpecialName]
	internal virtual TextBox p6S()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9P(TextBox Wn7)
	{
		TextBox val = (P = Wn7);
	}

	[SpecialName]
	internal virtual TextBox Cc0()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zy8(TextBox Ka0)
	{
		TextBox val = (o = Ka0);
	}

	[SpecialName]
	internal virtual TextBox w9E()
	{
		return _TxtStat;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg6(TextBox c5E)
	{
		_TxtStat = c5E;
	}

	[SpecialName]
	internal virtual TextBox s8C()
	{
		return _TxtMedic;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8B(TextBox w0E)
	{
		_TxtMedic = w0E;
	}

	[SpecialName]
	internal virtual TextBox Cp8()
	{
		return _TxtEntertain;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gj6(TextBox Qx1)
	{
		_TxtEntertain = Qx1;
	}

	[SpecialName]
	internal virtual TextBox b9C()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yo2(TextBox Eb7)
	{
		TextBox val = (X = Eb7);
	}

	[SpecialName]
	internal virtual TextBox Ts2()
	{
		return _TxtMarket;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8L(TextBox z2M)
	{
		_TxtMarket = z2M;
	}

	[SpecialName]
	internal virtual TextBox i8E()
	{
		return _TxtOther;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mx6(TextBox Mw6)
	{
		_TxtOther = Mw6;
	}

	[SpecialName]
	internal virtual PictureBox Tg2()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wc1(PictureBox Re3)
	{
		_PictureBox2 = Re3;
	}

	[SpecialName]
	internal virtual PictureBox Dz6()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5A(PictureBox Be9)
	{
		_PictureBox3 = Be9;
	}

	[SpecialName]
	internal virtual PictureBox Cr6()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ta2(PictureBox j4T)
	{
		_PictureBox4 = j4T;
	}

	[SpecialName]
	internal virtual PictureBox i7F()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9M(PictureBox Lx5)
	{
		_PictureBox6 = Lx5;
	}

	[SpecialName]
	internal virtual PictureBox m3A()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2H(PictureBox Dx5)
	{
		_PictureBox7 = Dx5;
	}

	[SpecialName]
	internal virtual PictureBox Km5()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg7(PictureBox Kb0)
	{
		_PictureBox8 = Kb0;
	}

	[SpecialName]
	internal virtual PictureBox Gb6()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4H(PictureBox Tj4)
	{
		PictureBox val = (E = Tj4);
	}

	[SpecialName]
	internal virtual PictureBox m0Q()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7K(PictureBox s7W)
	{
		_PictureBox10 = s7W;
	}

	[SpecialName]
	internal virtual PictureBox Jj6()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1R(PictureBox Nf9)
	{
		PictureBox val = (w = Nf9);
	}

	[SpecialName]
	internal virtual TextBox s7S()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rz9(TextBox p5P)
	{
		TextBox val = (Q = p5P);
	}

	[SpecialName]
	internal virtual Label n2T()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6S(Label o0J)
	{
		_Label9 = o0J;
	}

	[SpecialName]
	internal virtual PictureBox Ld1()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt5(PictureBox Xf1)
	{
		PictureBox val = (m = Xf1);
	}

	[SpecialName]
	internal virtual Label Fs1()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xe1(Label Wg1)
	{
		Label val = (T = Wg1);
	}

	[SpecialName]
	internal virtual Label Ns2()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9Q(Label g9R)
	{
		_Label10 = g9R;
	}

	[SpecialName]
	internal virtual TextBox j3Y()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tf6(TextBox Se3)
	{
		TextBox val = (u = Se3);
	}

	[SpecialName]
	internal virtual GroupBox f9S()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ca4(GroupBox z6N)
	{
		_GroupBox1 = z6N;
	}

	[SpecialName]
	internal virtual Label Zi0()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lt5(Label n4K)
	{
		_Label11 = n4K;
	}

	[SpecialName]
	internal virtual TextBox Ay9()
	{
		return _TxtExpenses;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w8G(TextBox Pt6)
	{
		_TxtExpenses = Pt6;
	}

	[SpecialName]
	internal virtual PictureBox r7H()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc2(PictureBox Jo2)
	{
		PictureBox val = (a = Jo2);
	}

	[SpecialName]
	internal virtual Button Db4()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3A(Button Bf1)
	{
		EventHandler eventHandler = Gk9;
		Button y = Y;
		if (y != null)
		{
			((Control)y).remove_Click(eventHandler);
		}
		Button val = (Y = Bf1);
		y = Y;
		if (y != null)
		{
			((Control)y).add_Click(eventHandler);
		}
	}

	public bool o2Y()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			K.Open();
			K.Close();
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	internal static bool d9A(string Ps4)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Ps4);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	private void b4B(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		Fs1().set_Text(Gf87.UsrNam);
		string identity = Gf87.Identity;
		if (o2Y())
		{
			try
			{
				if (K.get_State() != ConnectionState.Open)
				{
					K.Open();
				}
				Sqlds.Clear();
				SqlCommand val = new SqlCommand("SELECT isnull(SUM(Food),0) As TotFo FROM [" + identity + " ]", K);
				SqlDataAdapter val2 = (i = new SqlDataAdapter(val));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				p6S().set_Text(text);
				Sqlds.Clear();
				SqlCommand val3 = new SqlCommand("SELECT isnull(SUM(Clothes),0) As TotCl FROM [" + identity + " ]", K);
				SqlDataAdapter val4 = (i = new SqlDataAdapter(val3));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text2 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				Cc0().set_Text(text2);
				Sqlds.Clear();
				SqlCommand val5 = new SqlCommand("SELECT isnull(SUM(Stationary),0) As TotSt FROM [" + identity + " ]", K);
				SqlDataAdapter val6 = (i = new SqlDataAdapter(val5));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text3 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				w9E().set_Text(text3);
				Sqlds.Clear();
				SqlCommand val7 = new SqlCommand("SELECT isnull(SUM(Market),0) As TotMa FROM [" + identity + " ]", K);
				SqlDataAdapter val8 = (i = new SqlDataAdapter(val7));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text4 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				Ts2().set_Text(text4);
				Sqlds.Clear();
				SqlCommand val9 = new SqlCommand("SELECT isnull(SUM(Entertainment),0) As TotEn FROM [" + identity + " ]", K);
				SqlDataAdapter val10 = (i = new SqlDataAdapter(val9));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text5 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				Cp8().set_Text(text5);
				Sqlds.Clear();
				SqlCommand val11 = new SqlCommand("SELECT isnull(SUM(Medical),0) As TotMe FROM [" + identity + " ]", K);
				SqlDataAdapter val12 = (i = new SqlDataAdapter(val11));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text6 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				s8C().set_Text(text6);
				Sqlds.Clear();
				SqlCommand val13 = new SqlCommand("SELECT isnull(SUM(Transport),0) As Tottr FROM [" + identity + " ]", K);
				SqlDataAdapter val14 = (i = new SqlDataAdapter(val13));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text7 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				b9C().set_Text(text7);
				Sqlds.Clear();
				SqlCommand val15 = new SqlCommand("SELECT isnull(SUM(Others),0) As TotOt FROM [" + identity + " ]", K);
				SqlDataAdapter val16 = (i = new SqlDataAdapter(val15));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text8 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				i8E().set_Text(text8);
				Sqlds.Clear();
				SqlCommand val17 = new SqlCommand("SELECT isnull(SUM(Income),0) As TotInc FROM [" + identity + " ]", K);
				SqlDataAdapter val18 = (i = new SqlDataAdapter(val17));
				Sqlds = new DataSet();
				((DbDataAdapter)(object)i).Fill(Sqlds);
				string text9 = Conversions.ToString(Sqlds.Tables[0].Rows[0][0]);
				j3Y().set_Text(text9);
				string text10 = Conversions.ToString(Conversion.Val(text) + Conversion.Val(text2) + Conversion.Val(text5) + Conversion.Val(text4) + Conversion.Val(text6) + Conversion.Val(text8) + Conversion.Val(text3) + Conversion.Val(text7));
				Ay9().set_Text(text10);
				string text11 = Conversions.ToString(Conversion.Val(text9));
				string text12 = (Gf87.FinBalance = Conversions.ToString(Conversions.ToDouble(text11) - Conversions.ToDouble(text10)));
				s7S().set_Text(text12);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		K.Close();
	}

	internal static string Cw5(string[] Bj3, int Jk4, int w3T)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Jk4; i <= w3T; i = checked(i + 1))
		{
			stringBuilder.Append(Bj3[i]);
		}
		return stringBuilder.ToString();
	}

	private void Gk9(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ft0()).Show();
		((Form)this).Close();
	}

	internal static byte[] Ep7(int r6W)
	{
		return g0Z.y0K(r6W, checked(r6W + 1 - 38));
	}
}
