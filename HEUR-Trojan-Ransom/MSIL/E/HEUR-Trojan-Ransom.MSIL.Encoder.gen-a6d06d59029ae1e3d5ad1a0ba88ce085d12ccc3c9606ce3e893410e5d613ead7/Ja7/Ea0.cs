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
using Ag2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ty6;
using s8Z;

namespace Ja7;

[DesignerGenerated]
public class Ea0 : Form
{
	private Label _Label1;

	private Label _Label7;

	private TextBox _TxtFood;

	private TextBox _TxtStat;

	private TextBox _TxtEntertain;

	private TextBox _TxtMarket;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox10;

	private Label _Label9;

	private Label _LblNam;

	private Label _Label10;

	private TextBox _TxtIncome;

	private GroupBox _GroupBox1;

	private Label _Label11;

	private SqlConnection Sqlcn;

	private SqlCommand Sqlcmd;

	private SqlDataAdapter Sqlda;

	internal IContainer B;

	internal PictureBox k;

	internal Label L;

	internal Label O;

	internal Label w;

	internal Label j;

	internal Label D;

	internal Label n;

	internal TextBox a;

	internal TextBox E;

	internal TextBox Q;

	internal TextBox r;

	internal PictureBox h;

	internal PictureBox v;

	internal PictureBox x;

	internal PictureBox U;

	internal PictureBox Y;

	internal TextBox i;

	internal PictureBox c;

	internal TextBox P;

	internal PictureBox F;

	internal Button s;

	internal DataSet m;

	public Ea0()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Sm4);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		Sqlcn = val;
		Sqlcmd = new SqlCommand();
		Sqlda = new SqlDataAdapter();
		DataSet dataSet = (m = new DataSet());
		Po2();
	}

	protected override void w3R(bool Cp5)
	{
		try
		{
			if (Cp5 && B != null)
			{
				B.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cp5);
		}
	}

	private void Po2()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ea0));
		w1P(new PictureBox());
		e3K(new Label());
		p0D(new Label());
		d7P(new Label());
		z6H(new Label());
		k3L(new Label());
		Zm0(new Label());
		a7X(new Label());
		p8G(new Label());
		e7D(new TextBox());
		Ta7(new TextBox());
		m6Q(new TextBox());
		y9Z(new TextBox());
		Nn4(new TextBox());
		i3Y(new TextBox());
		q2R(new TextBox());
		Kf6(new TextBox());
		Fd7(new PictureBox());
		f9D(new PictureBox());
		a8D(new PictureBox());
		Qn8(new PictureBox());
		Hw0(new PictureBox());
		Yy3(new PictureBox());
		p0R(new PictureBox());
		Yx8(new PictureBox());
		Xa6(new PictureBox());
		q2W(new TextBox());
		j5M(new Label());
		y9B(new PictureBox());
		Yg6(new Label());
		Yc4(new Label());
		i4A(new TextBox());
		r6C(new GroupBox());
		Ww0(new Label());
		Zz3(new TextBox());
		Pb9(new PictureBox());
		Kk8(new Button());
		((ISupportInitialize)e2N()).BeginInit();
		((ISupportInitialize)e8T()).BeginInit();
		((ISupportInitialize)Hn0()).BeginInit();
		((ISupportInitialize)g7S()).BeginInit();
		((ISupportInitialize)e8X()).BeginInit();
		((ISupportInitialize)Ab5()).BeginInit();
		((ISupportInitialize)s2G()).BeginInit();
		((ISupportInitialize)Tk1()).BeginInit();
		((ISupportInitialize)Na3()).BeginInit();
		((ISupportInitialize)w8K()).BeginInit();
		((ISupportInitialize)Fp4()).BeginInit();
		((Control)x5N()).SuspendLayout();
		((ISupportInitialize)Cy2()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)e2N()).set_Anchor((AnchorStyles)15);
		((Control)e2N()).set_BackColor(Color.Transparent);
		((Control)e2N()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)e2N()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)e2N()).set_Location(new Point(253, 1));
		((Control)e2N()).set_Name("PictureBox1");
		((Control)e2N()).set_Size(new Size(318, 48));
		e2N().set_TabIndex(0);
		e2N().set_TabStop(false);
		((Control)Ec0()).set_Anchor((AnchorStyles)15);
		Ec0().set_AutoSize(true);
		((Control)Ec0()).set_BackColor(Color.AliceBlue);
		((Control)Ec0()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ec0()).set_ForeColor(Color.Navy);
		((Control)Ec0()).set_Location(new Point(127, 168));
		((Control)Ec0()).set_Name("Label1");
		((Control)Ec0()).set_Size(new Size(58, 21));
		((Control)Ec0()).set_TabIndex(1);
		Ec0().set_Text("Food :");
		((Control)n9L()).set_Anchor((AnchorStyles)15);
		n9L().set_AutoSize(true);
		((Control)n9L()).set_BackColor(Color.AliceBlue);
		((Control)n9L()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n9L()).set_ForeColor(Color.Navy);
		((Control)n9L()).set_Location(new Point(518, 174));
		((Control)n9L()).set_Name("Label2");
		((Control)n9L()).set_Size(new Size(76, 21));
		((Control)n9L()).set_TabIndex(2);
		n9L().set_Text("Clothes :");
		((Control)La7()).set_Anchor((AnchorStyles)15);
		La7().set_AutoSize(true);
		((Control)La7()).set_BackColor(Color.AliceBlue);
		((Control)La7()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)La7()).set_ForeColor(Color.Navy);
		((Control)La7()).set_Location(new Point(172, 255));
		((Control)La7()).set_Name("Label3");
		((Control)La7()).set_Size(new Size(125, 21));
		((Control)La7()).set_TabIndex(3);
		La7().set_Text("Entertainment :");
		((Control)j3L()).set_Anchor((AnchorStyles)15);
		j3L().set_AutoSize(true);
		((Control)j3L()).set_BackColor(Color.AliceBlue);
		((Control)j3L()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)j3L()).set_ForeColor(Color.Navy);
		((Control)j3L()).set_Location(new Point(614, 255));
		((Control)j3L()).set_Name("Label4");
		((Control)j3L()).set_Size(new Size(75, 21));
		((Control)j3L()).set_TabIndex(4);
		j3L().set_Text("Market :");
		((Control)z9Y()).set_Anchor((AnchorStyles)15);
		z9Y().set_AutoSize(true);
		((Control)z9Y()).set_BackColor(Color.AliceBlue);
		((Control)z9Y()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z9Y()).set_ForeColor(Color.Navy);
		((Control)z9Y()).set_Location(new Point(587, 435));
		((Control)z9Y()).set_Name("Label5");
		((Control)z9Y()).set_Size(new Size(74, 21));
		((Control)z9Y()).set_TabIndex(5);
		z9Y().set_Text("Others :");
		((Control)Bg8()).set_Anchor((AnchorStyles)15);
		Bg8().set_AutoSize(true);
		((Control)Bg8()).set_BackColor(Color.AliceBlue);
		((Control)Bg8()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Bg8()).set_ForeColor(Color.Navy);
		((Control)Bg8()).set_Location(new Point(173, 436));
		((Control)Bg8()).set_Name("Label6");
		((Control)Bg8()).set_Size(new Size(94, 21));
		((Control)Bg8()).set_TabIndex(6);
		Bg8().set_Text("Transport :");
		((Control)p5S()).set_Anchor((AnchorStyles)15);
		p5S().set_AutoSize(true);
		((Control)p5S()).set_BackColor(Color.AliceBlue);
		((Control)p5S()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)p5S()).set_ForeColor(Color.Navy);
		((Control)p5S()).set_Location(new Point(527, 346));
		((Control)p5S()).set_Name("Label7");
		((Control)p5S()).set_Size(new Size(78, 21));
		((Control)p5S()).set_TabIndex(7);
		p5S().set_Text("Medical :");
		((Control)n7H()).set_Anchor((AnchorStyles)15);
		n7H().set_AutoSize(true);
		((Control)n7H()).set_BackColor(Color.AliceBlue);
		((Control)n7H()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n7H()).set_ForeColor(Color.Navy);
		((Control)n7H()).set_Location(new Point(127, 348));
		((Control)n7H()).set_Name("Label8");
		((Control)n7H()).set_Size(new Size(99, 21));
		((Control)n7H()).set_TabIndex(8);
		n7H().set_Text("Stationary :");
		((Control)n3P()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)n3P()).set_BackColor(Color.Azure);
		((Control)n3P()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)n3P()).set_ForeColor(Color.Navy);
		((Control)n3P()).set_Location(new Point(191, 168));
		n3P().set_Multiline(true);
		((Control)n3P()).set_Name("TxtFood");
		((Control)n3P()).set_Size(new Size(105, 26));
		((Control)n3P()).set_TabIndex(9);
		((Control)Ys1()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Ys1()).set_BackColor(Color.Azure);
		((Control)Ys1()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Ys1()).set_ForeColor(Color.Navy);
		((Control)Ys1()).set_Location(new Point(599, 171));
		Ys1().set_Multiline(true);
		((Control)Ys1()).set_Name("TxtCloth");
		((Control)Ys1()).set_Size(new Size(103, 26));
		((Control)Ys1()).set_TabIndex(10);
		((Control)z0J()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)z0J()).set_BackColor(Color.Azure);
		((Control)z0J()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)z0J()).set_ForeColor(Color.Navy);
		((Control)z0J()).set_Location(new Point(231, 346));
		z0J().set_Multiline(true);
		((Control)z0J()).set_Name("TxtStat");
		((Control)z0J()).set_Size(new Size(103, 26));
		((Control)z0J()).set_TabIndex(11);
		((Control)x0H()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)x0H()).set_BackColor(Color.Azure);
		((Control)x0H()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)x0H()).set_ForeColor(Color.Navy);
		((Control)x0H()).set_Location(new Point(615, 341));
		x0H().set_Multiline(true);
		((Control)x0H()).set_Name("TxtMedic");
		((Control)x0H()).set_Size(new Size(103, 26));
		((Control)x0H()).set_TabIndex(12);
		((Control)o9F()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)o9F()).set_BackColor(Color.Azure);
		((Control)o9F()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)o9F()).set_ForeColor(Color.Navy);
		((Control)o9F()).set_Location(new Point(304, 254));
		o9F().set_Multiline(true);
		((Control)o9F()).set_Name("TxtEntertain");
		((Control)o9F()).set_Size(new Size(103, 26));
		((Control)o9F()).set_TabIndex(13);
		((Control)m6C()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)m6C()).set_BackColor(Color.Azure);
		((Control)m6C()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)m6C()).set_ForeColor(Color.Navy);
		((Control)m6C()).set_Location(new Point(282, 435));
		m6C().set_Multiline(true);
		((Control)m6C()).set_Name("TxtTrans");
		((Control)m6C()).set_Size(new Size(103, 26));
		((Control)m6C()).set_TabIndex(14);
		((Control)Cs7()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Cs7()).set_BackColor(Color.Azure);
		((Control)Cs7()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Cs7()).set_ForeColor(Color.Navy);
		((Control)Cs7()).set_Location(new Point(699, 254));
		Cs7().set_Multiline(true);
		((Control)Cs7()).set_Name("TxtMarket");
		((Control)Cs7()).set_Size(new Size(103, 26));
		((Control)Cs7()).set_TabIndex(15);
		((Control)b4B()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)b4B()).set_BackColor(Color.Azure);
		((Control)b4B()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)b4B()).set_ForeColor(Color.Navy);
		((Control)b4B()).set_Location(new Point(678, 435));
		b4B().set_Multiline(true);
		((Control)b4B()).set_Name("TxtOther");
		((Control)b4B()).set_Size(new Size(103, 26));
		((Control)b4B()).set_TabIndex(16);
		((Control)e8T()).set_Anchor((AnchorStyles)15);
		((Control)e8T()).set_BackColor(Color.Transparent);
		((Control)e8T()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)e8T()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)e8T()).set_Location(new Point(3, 1));
		((Control)e8T()).set_Name("PictureBox2");
		((Control)e8T()).set_Size(new Size(107, 83));
		e8T().set_TabIndex(34);
		e8T().set_TabStop(false);
		((Control)Hn0()).set_Anchor((AnchorStyles)15);
		((Control)Hn0()).set_BackColor(Color.Transparent);
		((Control)Hn0()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Hn0()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Hn0()).set_Location(new Point(45, 147));
		((Control)Hn0()).set_Name("PictureBox3");
		((Control)Hn0()).set_Size(new Size(76, 66));
		Hn0().set_TabIndex(35);
		Hn0().set_TabStop(false);
		((Control)g7S()).set_Anchor((AnchorStyles)15);
		((Control)g7S()).set_BackColor(Color.Transparent);
		((Control)g7S()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)g7S()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)g7S()).set_Location(new Point(82, 232));
		((Control)g7S()).set_Name("PictureBox4");
		((Control)g7S()).set_Size(new Size(76, 66));
		g7S().set_TabIndex(36);
		g7S().set_TabStop(false);
		((Control)e8X()).set_Anchor((AnchorStyles)15);
		((Control)e8X()).set_BackColor(Color.Transparent);
		((Control)e8X()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox6.BackgroundImage"));
		((Control)e8X()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)e8X()).set_Location(new Point(45, 325));
		((Control)e8X()).set_Name("PictureBox6");
		((Control)e8X()).set_Size(new Size(76, 66));
		e8X().set_TabIndex(37);
		e8X().set_TabStop(false);
		((Control)Ab5()).set_Anchor((AnchorStyles)15);
		((Control)Ab5()).set_BackColor(Color.Transparent);
		((Control)Ab5()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox7.BackgroundImage"));
		((Control)Ab5()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Ab5()).set_Location(new Point(82, 414));
		((Control)Ab5()).set_Name("PictureBox7");
		((Control)Ab5()).set_Size(new Size(76, 66));
		Ab5().set_TabIndex(38);
		Ab5().set_TabStop(false);
		((Control)s2G()).set_Anchor((AnchorStyles)15);
		((Control)s2G()).set_BackColor(Color.Transparent);
		((Control)s2G()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox8.BackgroundImage"));
		((Control)s2G()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)s2G()).set_Location(new Point(442, 325));
		((Control)s2G()).set_Name("PictureBox8");
		((Control)s2G()).set_Size(new Size(70, 66));
		s2G().set_TabIndex(39);
		s2G().set_TabStop(false);
		((Control)Tk1()).set_Anchor((AnchorStyles)15);
		((Control)Tk1()).set_BackColor(Color.Transparent);
		((Control)Tk1()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox9.BackgroundImage"));
		((Control)Tk1()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Tk1()).set_Location(new Point(431, 147));
		((Control)Tk1()).set_Name("PictureBox9");
		((Control)Tk1()).set_Size(new Size(81, 66));
		Tk1().set_TabIndex(40);
		Tk1().set_TabStop(false);
		((Control)Na3()).set_Anchor((AnchorStyles)15);
		((Control)Na3()).set_BackColor(Color.Transparent);
		((Control)Na3()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox10.BackgroundImage"));
		((Control)Na3()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Na3()).set_Location(new Point(501, 414));
		((Control)Na3()).set_Name("PictureBox10");
		((Control)Na3()).set_Size(new Size(70, 66));
		Na3().set_TabIndex(41);
		Na3().set_TabStop(false);
		((Control)w8K()).set_Anchor((AnchorStyles)15);
		((Control)w8K()).set_BackColor(Color.Transparent);
		((Control)w8K()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox11.BackgroundImage"));
		((Control)w8K()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)w8K()).set_Location(new Point(490, 232));
		((Control)w8K()).set_Name("PictureBox11");
		((Control)w8K()).set_Size(new Size(81, 66));
		w8K().set_TabIndex(42);
		w8K().set_TabStop(false);
		((Control)s5E()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)s5E()).set_BackColor(Color.Azure);
		((Control)s5E()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)s5E()).set_ForeColor(Color.Navy);
		((Control)s5E()).set_Location(new Point(409, 86));
		s5E().set_Multiline(true);
		((Control)s5E()).set_Name("TxtBal");
		((Control)s5E()).set_Size(new Size(162, 26));
		((Control)s5E()).set_TabIndex(44);
		((Control)a8J()).set_Anchor((AnchorStyles)15);
		a8J().set_AutoSize(true);
		((Control)a8J()).set_BackColor(Color.AliceBlue);
		((Control)a8J()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)a8J()).set_ForeColor(Color.Navy);
		((Control)a8J()).set_Location(new Point(319, 86));
		((Control)a8J()).set_Name("Label9");
		((Control)a8J()).set_Size(new Size(84, 21));
		((Control)a8J()).set_TabIndex(43);
		a8J().set_Text("Balance : ");
		((Control)Fp4()).set_Anchor((AnchorStyles)15);
		((Control)Fp4()).set_BackColor(Color.Transparent);
		((Control)Fp4()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox13.BackgroundImage"));
		((Control)Fp4()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Fp4()).set_Location(new Point(241, 65));
		((Control)Fp4()).set_Name("PictureBox13");
		((Control)Fp4()).set_Size(new Size(72, 58));
		Fp4().set_TabIndex(46);
		Fp4().set_TabStop(false);
		((Control)z1C()).set_Anchor((AnchorStyles)15);
		z1C().set_AutoSize(true);
		((Control)z1C()).set_BackColor(Color.Transparent);
		((Control)z1C()).set_Font(new Font("AR JULIAN", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z1C()).set_ForeColor(Color.FromArgb(0, 64, 64));
		((Control)z1C()).set_Location(new Point(724, 9));
		((Control)z1C()).set_Name("LblNam");
		((Control)z1C()).set_Size(new Size(0, 18));
		((Control)z1C()).set_TabIndex(47);
		Sp2().set_AutoSize(true);
		((Control)Sp2()).set_BackColor(Color.Transparent);
		((Control)Sp2()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Sp2()).set_ForeColor(Color.Navy);
		((Control)Sp2()).set_Location(new Point(24, 34));
		((Control)Sp2()).set_Name("Label10");
		((Control)Sp2()).set_Size(new Size(120, 21));
		((Control)Sp2()).set_TabIndex(48);
		Sp2().set_Text("Total Income :");
		((TextBoxBase)d6W()).set_BackColor(Color.Azure);
		((Control)d6W()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)d6W()).set_ForeColor(Color.Navy);
		((Control)d6W()).set_Location(new Point(162, 29));
		d6W().set_Multiline(true);
		((Control)d6W()).set_Name("TxtIncome");
		((Control)d6W()).set_Size(new Size(126, 26));
		((Control)d6W()).set_TabIndex(49);
		((Control)x5N()).set_Anchor((AnchorStyles)15);
		((Control)x5N()).set_BackColor(Color.Transparent);
		((Control)x5N()).get_Controls().Add((Control)(object)Ck8());
		((Control)x5N()).get_Controls().Add((Control)(object)Tn4());
		((Control)x5N()).get_Controls().Add((Control)(object)Cy2());
		((Control)x5N()).get_Controls().Add((Control)(object)t9S());
		((Control)x5N()).get_Controls().Add((Control)(object)Sp2());
		((Control)x5N()).get_Controls().Add((Control)(object)d6W());
		((Control)x5N()).set_Location(new Point(62, 486));
		((Control)x5N()).set_Name("GroupBox1");
		((Control)x5N()).set_Size(new Size(710, 121));
		((Control)x5N()).set_TabIndex(50);
		x5N().set_TabStop(false);
		Ck8().set_AutoSize(true);
		((Control)Ck8()).set_BackColor(Color.Transparent);
		((Control)Ck8()).set_Font(new Font("Comic Sans MS", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Ck8()).set_ForeColor(Color.Navy);
		((Control)Ck8()).set_Location(new Point(392, 34));
		((Control)Ck8()).set_Name("Label11");
		((Control)Ck8()).set_Size(new Size(125, 21));
		((Control)Ck8()).set_TabIndex(52);
		Ck8().set_Text("Total Expense :");
		((TextBoxBase)Tn4()).set_BackColor(Color.Azure);
		((Control)Tn4()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Tn4()).set_ForeColor(Color.Navy);
		((Control)Tn4()).set_Location(new Point(530, 29));
		Tn4().set_Multiline(true);
		((Control)Tn4()).set_Name("TxtExpenses");
		((Control)Tn4()).set_Size(new Size(126, 26));
		((Control)Tn4()).set_TabIndex(53);
		((Control)Cy2()).set_BackColor(Color.Transparent);
		((Control)Cy2()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox5.BackgroundImage"));
		((Control)Cy2()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Cy2()).set_Location(new Point(274, 77));
		((Control)Cy2()).set_Name("PictureBox5");
		((Control)Cy2()).set_Size(new Size(52, 35));
		Cy2().set_TabIndex(51);
		Cy2().set_TabStop(false);
		((ButtonBase)t9S()).set_BackColor(Color.Azure);
		((Control)t9S()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)t9S()).set_FlatStyle((FlatStyle)0);
		((Control)t9S()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)t9S()).set_ForeColor(Color.FromArgb(0, 0, 64));
		((Control)t9S()).set_Location(new Point(322, 86));
		((Control)t9S()).set_Name("Button9");
		((Control)t9S()).set_Size(new Size(110, 26));
		((Control)t9S()).set_TabIndex(50);
		((ButtonBase)t9S()).set_Text("&Main Menu");
		((ButtonBase)t9S()).set_TextAlign((ContentAlignment)2);
		((ButtonBase)t9S()).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(843, 619));
		((Control)this).get_Controls().Add((Control)(object)x5N());
		((Control)this).get_Controls().Add((Control)(object)z1C());
		((Control)this).get_Controls().Add((Control)(object)Fp4());
		((Control)this).get_Controls().Add((Control)(object)s5E());
		((Control)this).get_Controls().Add((Control)(object)a8J());
		((Control)this).get_Controls().Add((Control)(object)w8K());
		((Control)this).get_Controls().Add((Control)(object)Na3());
		((Control)this).get_Controls().Add((Control)(object)Tk1());
		((Control)this).get_Controls().Add((Control)(object)s2G());
		((Control)this).get_Controls().Add((Control)(object)Ab5());
		((Control)this).get_Controls().Add((Control)(object)e8X());
		((Control)this).get_Controls().Add((Control)(object)g7S());
		((Control)this).get_Controls().Add((Control)(object)Hn0());
		((Control)this).get_Controls().Add((Control)(object)e8T());
		((Control)this).get_Controls().Add((Control)(object)b4B());
		((Control)this).get_Controls().Add((Control)(object)Cs7());
		((Control)this).get_Controls().Add((Control)(object)m6C());
		((Control)this).get_Controls().Add((Control)(object)o9F());
		((Control)this).get_Controls().Add((Control)(object)x0H());
		((Control)this).get_Controls().Add((Control)(object)z0J());
		((Control)this).get_Controls().Add((Control)(object)Ys1());
		((Control)this).get_Controls().Add((Control)(object)n3P());
		((Control)this).get_Controls().Add((Control)(object)n7H());
		((Control)this).get_Controls().Add((Control)(object)p5S());
		((Control)this).get_Controls().Add((Control)(object)Bg8());
		((Control)this).get_Controls().Add((Control)(object)z9Y());
		((Control)this).get_Controls().Add((Control)(object)j3L());
		((Control)this).get_Controls().Add((Control)(object)La7());
		((Control)this).get_Controls().Add((Control)(object)n9L());
		((Control)this).get_Controls().Add((Control)(object)Ec0());
		((Control)this).get_Controls().Add((Control)(object)e2N());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form12");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Expense Manager");
		((ISupportInitialize)e2N()).EndInit();
		((ISupportInitialize)e8T()).EndInit();
		((ISupportInitialize)Hn0()).EndInit();
		((ISupportInitialize)g7S()).EndInit();
		((ISupportInitialize)e8X()).EndInit();
		((ISupportInitialize)Ab5()).EndInit();
		((ISupportInitialize)s2G()).EndInit();
		((ISupportInitialize)Tk1()).EndInit();
		((ISupportInitialize)Na3()).EndInit();
		((ISupportInitialize)w8K()).EndInit();
		((ISupportInitialize)Fp4()).EndInit();
		((Control)x5N()).ResumeLayout(false);
		((Control)x5N()).PerformLayout();
		((ISupportInitialize)Cy2()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox e2N()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1P(PictureBox x4L)
	{
		PictureBox val = (k = x4L);
	}

	[SpecialName]
	internal virtual Label Ec0()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3K(Label f3P)
	{
		_Label1 = f3P;
	}

	[SpecialName]
	internal virtual Label n9L()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0D(Label Gn9)
	{
		Label val = (L = Gn9);
	}

	[SpecialName]
	internal virtual Label La7()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7P(Label Ey2)
	{
		Label val = (O = Ey2);
	}

	[SpecialName]
	internal virtual Label j3L()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6H(Label So8)
	{
		Label val = (w = So8);
	}

	[SpecialName]
	internal virtual Label z9Y()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3L(Label d6E)
	{
		Label val = (j = d6E);
	}

	[SpecialName]
	internal virtual Label Bg8()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zm0(Label Qe7)
	{
		Label val = (D = Qe7);
	}

	[SpecialName]
	internal virtual Label p5S()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7X(Label n7Y)
	{
		_Label7 = n7Y;
	}

	[SpecialName]
	internal virtual Label n7H()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8G(Label f8K)
	{
		Label val = (n = f8K);
	}

	[SpecialName]
	internal virtual TextBox n3P()
	{
		return _TxtFood;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7D(TextBox m0Q)
	{
		_TxtFood = m0Q;
	}

	[SpecialName]
	internal virtual TextBox Ys1()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ta7(TextBox q1J)
	{
		TextBox val = (a = q1J);
	}

	[SpecialName]
	internal virtual TextBox z0J()
	{
		return _TxtStat;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6Q(TextBox s2G)
	{
		_TxtStat = s2G;
	}

	[SpecialName]
	internal virtual TextBox x0H()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9Z(TextBox c8A)
	{
		TextBox val = (E = c8A);
	}

	[SpecialName]
	internal virtual TextBox o9F()
	{
		return _TxtEntertain;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn4(TextBox Ap5)
	{
		_TxtEntertain = Ap5;
	}

	[SpecialName]
	internal virtual TextBox m6C()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3Y(TextBox Gk0)
	{
		TextBox val = (Q = Gk0);
	}

	[SpecialName]
	internal virtual TextBox Cs7()
	{
		return _TxtMarket;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2R(TextBox Hr2)
	{
		_TxtMarket = Hr2;
	}

	[SpecialName]
	internal virtual TextBox b4B()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kf6(TextBox c9B)
	{
		TextBox val = (r = c9B);
	}

	[SpecialName]
	internal virtual PictureBox e8T()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fd7(PictureBox j6P)
	{
		PictureBox val = (h = j6P);
	}

	[SpecialName]
	internal virtual PictureBox Hn0()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9D(PictureBox t4A)
	{
		_PictureBox3 = t4A;
	}

	[SpecialName]
	internal virtual PictureBox g7S()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8D(PictureBox k4E)
	{
		PictureBox val = (v = k4E);
	}

	[SpecialName]
	internal virtual PictureBox e8X()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn8(PictureBox Rp3)
	{
		PictureBox val = (x = Rp3);
	}

	[SpecialName]
	internal virtual PictureBox Ab5()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hw0(PictureBox i5B)
	{
		_PictureBox7 = i5B;
	}

	[SpecialName]
	internal virtual PictureBox s2G()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yy3(PictureBox Dk6)
	{
		PictureBox val = (U = Dk6);
	}

	[SpecialName]
	internal virtual PictureBox Tk1()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0R(PictureBox Bi5)
	{
		_PictureBox9 = Bi5;
	}

	[SpecialName]
	internal virtual PictureBox Na3()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yx8(PictureBox w4R)
	{
		_PictureBox10 = w4R;
	}

	[SpecialName]
	internal virtual PictureBox w8K()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xa6(PictureBox d1Y)
	{
		PictureBox val = (Y = d1Y);
	}

	[SpecialName]
	internal virtual TextBox s5E()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2W(TextBox Jr1)
	{
		TextBox val = (i = Jr1);
	}

	[SpecialName]
	internal virtual Label a8J()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5M(Label Xt9)
	{
		_Label9 = Xt9;
	}

	[SpecialName]
	internal virtual PictureBox Fp4()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9B(PictureBox Rt3)
	{
		PictureBox val = (c = Rt3);
	}

	[SpecialName]
	internal virtual Label z1C()
	{
		return _LblNam;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yg6(Label Qz4)
	{
		_LblNam = Qz4;
	}

	[SpecialName]
	internal virtual Label Sp2()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yc4(Label Yg5)
	{
		_Label10 = Yg5;
	}

	[SpecialName]
	internal virtual TextBox d6W()
	{
		return _TxtIncome;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4A(TextBox t0T)
	{
		_TxtIncome = t0T;
	}

	[SpecialName]
	internal virtual GroupBox x5N()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6C(GroupBox Xs9)
	{
		_GroupBox1 = Xs9;
	}

	[SpecialName]
	internal virtual Label Ck8()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ww0(Label Pc4)
	{
		_Label11 = Pc4;
	}

	[SpecialName]
	internal virtual TextBox Tn4()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zz3(TextBox k5S)
	{
		TextBox val = (P = k5S);
	}

	[SpecialName]
	internal virtual PictureBox Cy2()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pb9(PictureBox Fm1)
	{
		PictureBox val = (F = Fm1);
	}

	[SpecialName]
	internal virtual Button t9S()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kk8(Button Gb2)
	{
		EventHandler eventHandler = Nd8;
		Button val = s;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (s = Gb2);
		val = s;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	public bool m0X()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Sqlcn.Open();
			Sqlcn.Close();
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

	internal static bool k6Q(string Yr8)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Yr8);
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

	private void Sm4(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		z1C().set_Text(c5W.UsrNam);
		string identity = c5W.Identity;
		if (m0X())
		{
			try
			{
				if (Sqlcn.get_State() != ConnectionState.Open)
				{
					Sqlcn.Open();
				}
				m.Clear();
				SqlCommand val = new SqlCommand("SELECT isnull(SUM(Food),0) As TotFo FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val);
				DataSet dataSet = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text = Conversions.ToString(m.Tables[0].Rows[0][0]);
				n3P().set_Text(text);
				m.Clear();
				SqlCommand val2 = new SqlCommand("SELECT isnull(SUM(Clothes),0) As TotCl FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val2);
				DataSet dataSet2 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text2 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				Ys1().set_Text(text2);
				m.Clear();
				SqlCommand val3 = new SqlCommand("SELECT isnull(SUM(Stationary),0) As TotSt FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val3);
				DataSet dataSet3 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text3 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				z0J().set_Text(text3);
				m.Clear();
				SqlCommand val4 = new SqlCommand("SELECT isnull(SUM(Market),0) As TotMa FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val4);
				DataSet dataSet4 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text4 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				Cs7().set_Text(text4);
				m.Clear();
				SqlCommand val5 = new SqlCommand("SELECT isnull(SUM(Entertainment),0) As TotEn FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val5);
				DataSet dataSet5 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text5 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				o9F().set_Text(text5);
				m.Clear();
				SqlCommand val6 = new SqlCommand("SELECT isnull(SUM(Medical),0) As TotMe FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val6);
				DataSet dataSet6 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text6 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				x0H().set_Text(text6);
				m.Clear();
				SqlCommand val7 = new SqlCommand("SELECT isnull(SUM(Transport),0) As Tottr FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val7);
				DataSet dataSet7 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text7 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				m6C().set_Text(text7);
				m.Clear();
				SqlCommand val8 = new SqlCommand("SELECT isnull(SUM(Others),0) As TotOt FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val8);
				DataSet dataSet8 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text8 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				b4B().set_Text(text8);
				m.Clear();
				SqlCommand val9 = new SqlCommand("SELECT isnull(SUM(Income),0) As TotInc FROM [" + identity + " ]", Sqlcn);
				Sqlda = new SqlDataAdapter(val9);
				DataSet dataSet9 = (m = new DataSet());
				((DbDataAdapter)(object)Sqlda).Fill(m);
				string text9 = Conversions.ToString(m.Tables[0].Rows[0][0]);
				d6W().set_Text(text9);
				string text10 = Conversions.ToString(Conversion.Val(text) + Conversion.Val(text2) + Conversion.Val(text5) + Conversion.Val(text4) + Conversion.Val(text6) + Conversion.Val(text8) + Conversion.Val(text3) + Conversion.Val(text7));
				Tn4().set_Text(text10);
				string text11 = Conversions.ToString(Conversion.Val(text9));
				string text12 = (c5W.FinBalance = Conversions.ToString(Conversions.ToDouble(text11) - Conversions.ToDouble(text10)));
				s5E().set_Text(text12);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		Sqlcn.Close();
	}

	internal static string Fo5(string[] x0M, int Pe7, int x9R)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Pe7; i <= x9R; i = checked(i + 1))
		{
			stringBuilder.Append(x0M[i]);
		}
		return stringBuilder.ToString();
	}

	private void Nd8(object sender, EventArgs e)
	{
		((Control)i1B.Forms.i5C()).Show();
		((Form)this).Close();
	}

	internal static byte[] x6L(int We9)
	{
		return Fx0.Kk7(We9, checked(We9 + 1 - 38));
	}
}
