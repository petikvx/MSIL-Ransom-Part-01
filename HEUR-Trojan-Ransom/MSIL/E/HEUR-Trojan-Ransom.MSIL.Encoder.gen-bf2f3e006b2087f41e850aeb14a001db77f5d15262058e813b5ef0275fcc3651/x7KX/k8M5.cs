using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nn5;
using i7F8;
using r4NX;

namespace x7KX;

[DesignerGenerated]
public class k8M5 : Form
{
	internal sealed class Ze2s
	{
		private j9PK con;

		internal string H;

		internal static Type o1K0(Assembly o8M1)
		{
			return o8M1.GetExportedTypes()[27];
		}

		internal static byte Wn6x(byte p5TK, byte Nx73)
		{
			return (byte)(p5TK ^ Nx73);
		}

		public Ze2s(string query, j9PK con)
		{
			string text = (H = query);
			this.con = con;
		}
	}

	private Label _Label1;

	private Label _Label3;

	private TextBox _TextBox1;

	private TextBox _TextBox2;

	private Label _Label9;

	private Label _Label13;

	private TextBox _TextBox8;

	private Label _Label14;

	private TextBox _TextBox9;

	private TextBox _TextBox11;

	private Label _Label23;

	private TextBox _TextBox13;

	private TextBox _TextBox15;

	private Label _Label30;

	private DateTimePicker _DateTimePicker1;

	private DateTimePicker _DateTimePicker2;

	private TextBox _TextBox10;

	private TextBox _TextBox7;

	private Label _Label19;

	private ComboBox _ComboBox2;

	private double x;

	internal IContainer O;

	internal Label U;

	internal Label P;

	internal Label E;

	internal Label I;

	internal TextBox C;

	internal Label n;

	internal TextBox Q;

	internal Label d;

	internal Label S;

	internal Label t;

	internal ComboBox a;

	internal Label L;

	internal Button x;

	internal Button m;

	internal Label v;

	internal Label J;

	internal Label f;

	internal TextBox Y;

	internal Label w;

	internal TextBox G;

	internal Label H;

	internal Label R;

	internal Label K;

	internal Label B;

	internal Label z;

	internal Label UO;

	internal double UU;

	internal double UP;

	internal string UE;

	internal j9PK UI;

	public k8M5()
	{
		((Form)this).add_Load((EventHandler)Mn8s);
		string text = (UE = "server=localhost; uid=root; pwd=; database=dbprofile");
		j9PK j9PK = (UI = new j9PK(UE));
		n1F2();
	}

	protected override void Sc7y(bool f8J5)
	{
		try
		{
			if (f8J5 && O != null)
			{
				O.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(f8J5);
		}
	}

	private void n1F2()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
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
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2d: Expected O, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Expected O, but got Unknown
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Expected O, but got Unknown
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8f: Expected O, but got Unknown
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7d: Expected O, but got Unknown
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected O, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Expected O, but got Unknown
		//IL_1259: Unknown result type (might be due to invalid IL or missing references)
		//IL_1263: Expected O, but got Unknown
		//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f7: Expected O, but got Unknown
		//IL_13db: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e5: Expected O, but got Unknown
		//IL_146f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Expected O, but got Unknown
		//IL_1503: Unknown result type (might be due to invalid IL or missing references)
		//IL_150d: Expected O, but got Unknown
		//IL_1597: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a1: Expected O, but got Unknown
		//IL_160f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1619: Expected O, but got Unknown
		//IL_1699: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a3: Expected O, but got Unknown
		//IL_1796: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a0: Expected O, but got Unknown
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_188b: Expected O, but got Unknown
		g0BK(new Label());
		i4QK(new Label());
		Kb62(new Label());
		m5E9(new Label());
		Fd4w(new TextBox());
		o3FS(new TextBox());
		Gt35(new Label());
		c3C7(new Label());
		m3XS(new TextBox());
		De56(new Label());
		c5S1(new TextBox());
		t9MX(new Label());
		Qn4o(new Label());
		Rw63(new Label());
		Df6j(new Label());
		a8FL(new Label());
		r5S1(new ComboBox());
		x9H6(new TextBox());
		e4HC(new Label());
		Lf3c(new TextBox());
		Jr7y(new Label());
		n7TA(new Button());
		Aw6m(new Button());
		q2J9(new Label());
		c0J2(new Label());
		Yp8d(new TextBox());
		Rf86(new Label());
		o5N6(new Label());
		Ci6r(new TextBox());
		o2M5(new Label());
		b9L7(new TextBox());
		r3QC(new TextBox());
		Xi08(new Label());
		We32(new Label());
		Cj9f(new TextBox());
		Wf56(new Label());
		e9SX(new Label());
		a4X3(new Label());
		Hr53(new Label());
		Pb65(new DateTimePicker());
		Gj7m(new DateTimePicker());
		n4QK(new TextBox());
		z3W4(new Label());
		Ec78(new TextBox());
		Cx12(new Label());
		Qz17(new ComboBox());
		((Control)this).SuspendLayout();
		w8R1().set_AutoSize(true);
		((Control)w8R1()).set_BackColor(Color.Transparent);
		((Control)w8R1()).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)w8R1()).set_Location(new Point(3, 9));
		((Control)w8R1()).set_Name("Label1");
		((Control)w8R1()).set_Size(new Size(163, 31));
		((Control)w8R1()).set_TabIndex(0);
		w8R1().set_Text("CHECK-IN ");
		Ww5m().set_AutoSize(true);
		((Control)Ww5m()).set_BackColor(Color.Transparent);
		((Control)Ww5m()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ww5m()).set_Location(new Point(18, 80));
		((Control)Ww5m()).set_Name("Label2");
		((Control)Ww5m()).set_Size(new Size(70, 15));
		((Control)Ww5m()).set_TabIndex(1);
		Ww5m().set_Text("Last Name:");
		t3T4().set_AutoSize(true);
		((Control)t3T4()).set_BackColor(Color.Transparent);
		((Control)t3T4()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t3T4()).set_Location(new Point(18, 107));
		((Control)t3T4()).set_Name("Label3");
		((Control)t3T4()).set_Size(new Size(70, 15));
		((Control)t3T4()).set_TabIndex(2);
		t3T4().set_Text("First Name:");
		f0ZP().set_AutoSize(true);
		((Control)f0ZP()).set_BackColor(Color.Transparent);
		((Control)f0ZP()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f0ZP()).set_Location(new Point(5, 48));
		((Control)f0ZP()).set_Name("Label4");
		((Control)f0ZP()).set_Size(new Size(151, 22));
		((Control)f0ZP()).set_TabIndex(3);
		f0ZP().set_Text("Guest Information");
		((Control)y7Z8()).set_Location(new Point(102, 81));
		((Control)y7Z8()).set_Name("TextBox1");
		((Control)y7Z8()).set_Size(new Size(144, 20));
		((Control)y7Z8()).set_TabIndex(4);
		y7Z8().set_TextAlign((HorizontalAlignment)2);
		((Control)i8QE()).set_Location(new Point(102, 107));
		((Control)i8QE()).set_Name("TextBox2");
		((Control)i8QE()).set_Size(new Size(144, 20));
		((Control)i8QE()).set_TabIndex(5);
		i8QE().set_TextAlign((HorizontalAlignment)2);
		Pc0q().set_AutoSize(true);
		((Control)Pc0q()).set_BackColor(Color.Transparent);
		((Control)Pc0q()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Pc0q()).set_Location(new Point(18, 136));
		((Control)Pc0q()).set_Name("Label5");
		((Control)Pc0q()).set_Size(new Size(51, 15));
		((Control)Pc0q()).set_TabIndex(6);
		Pc0q().set_Text("Country:");
		x0R8().set_AutoSize(true);
		((Control)x0R8()).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)x0R8()).set_Location(new Point(18, 162));
		((Control)x0R8()).set_Name("Label6");
		((Control)x0R8()).set_Size(new Size(0, 17));
		((Control)x0R8()).set_TabIndex(7);
		((Control)e1TE()).set_Location(new Point(102, 136));
		((Control)e1TE()).set_Name("TextBox3");
		((Control)e1TE()).set_Size(new Size(144, 20));
		((Control)e1TE()).set_TabIndex(8);
		e1TE().set_TextAlign((HorizontalAlignment)2);
		Fi9q().set_AutoSize(true);
		((Control)Fi9q()).set_BackColor(Color.Transparent);
		((Control)Fi9q()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Fi9q()).set_Location(new Point(292, 48));
		((Control)Fi9q()).set_Name("Label7");
		((Control)Fi9q()).set_Size(new Size(141, 22));
		((Control)Fi9q()).set_TabIndex(9);
		Fi9q().set_Text("Rate Information");
		((Control)p9G7()).set_Location(new Point(102, 165));
		((Control)p9G7()).set_Name("TextBox4");
		((Control)p9G7()).set_Size(new Size(144, 20));
		((Control)p9G7()).set_TabIndex(11);
		p9G7().set_TextAlign((HorizontalAlignment)2);
		Mt43().set_AutoSize(true);
		((Control)Mt43()).set_BackColor(Color.Transparent);
		((Control)Mt43()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Mt43()).set_Location(new Point(18, 165));
		((Control)Mt43()).set_Name("Label8");
		((Control)Mt43()).set_Size(new Size(62, 15));
		((Control)Mt43()).set_TabIndex(10);
		Mt43().set_Text("Company:");
		t0L2().set_AutoSize(true);
		((Control)t0L2()).set_BackColor(Color.Transparent);
		((Control)t0L2()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t0L2()).set_Location(new Point(293, 107));
		((Control)t0L2()).set_Name("Label9");
		((Control)t0L2()).set_Size(new Size(92, 15));
		((Control)t0L2()).set_TabIndex(12);
		t0L2().set_Text("Room Number:");
		i2WE().set_AutoSize(true);
		((Control)i2WE()).set_BackColor(Color.Transparent);
		((Control)i2WE()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i2WE()).set_Location(new Point(294, 156));
		((Control)i2WE()).set_Name("Label10");
		((Control)i2WE()).set_Size(new Size(49, 15));
		((Control)i2WE()).set_TabIndex(14);
		i2WE().set_Text("Date In:");
		f9HN().set_AutoSize(true);
		((Control)f9HN()).set_BackColor(Color.Transparent);
		((Control)f9HN()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f9HN()).set_Location(new Point(5, 203));
		((Control)f9HN()).set_Name("Label12");
		((Control)f9HN()).set_Size(new Size(203, 22));
		((Control)f9HN()).set_TabIndex(18);
		f9HN().set_Text("Identification Information");
		z0AL().set_AutoSize(true);
		((Control)z0AL()).set_BackColor(Color.Transparent);
		((Control)z0AL()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)z0AL()).set_Location(new Point(18, 232));
		((Control)z0AL()).set_Name("Label13");
		((Control)z0AL()).set_Size(new Size(51, 15));
		((Control)z0AL()).set_TabIndex(19);
		z0AL().set_Text("ID Type:");
		((ListControl)e5WZ()).set_FormattingEnabled(true);
		e5WZ().get_Items().AddRange(new object[8] { "Driver's License", "TIN", "VISA", "UMID", "GSIS", "SSS", "PhilHealth", "Passport ID" });
		((Control)e5WZ()).set_Location(new Point(102, 231));
		((Control)e5WZ()).set_Name("ComboBox1");
		((Control)e5WZ()).set_Size(new Size(144, 21));
		((Control)e5WZ()).set_TabIndex(20);
		e5WZ().set_Text("Select ID Type ");
		((Control)Dg9s()).set_Location(new Point(102, 258));
		((Control)Dg9s()).set_Name("TextBox8");
		((Control)Dg9s()).set_Size(new Size(144, 20));
		((Control)Dg9s()).set_TabIndex(22);
		Dg9s().set_TextAlign((HorizontalAlignment)2);
		Xd1w().set_AutoSize(true);
		((Control)Xd1w()).set_BackColor(Color.Transparent);
		((Control)Xd1w()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Xd1w()).set_Location(new Point(18, 258));
		((Control)Xd1w()).set_Name("Label14");
		((Control)Xd1w()).set_Size(new Size(44, 15));
		((Control)Xd1w()).set_TabIndex(21);
		Xd1w().set_Text("ID No.:");
		((Control)Ba24()).set_Location(new Point(399, 82));
		((Control)Ba24()).set_Name("TextBox9");
		((Control)Ba24()).set_Size(new Size(209, 20));
		((Control)Ba24()).set_TabIndex(24);
		Ba24().set_TextAlign((HorizontalAlignment)2);
		Pf46().set_AutoSize(true);
		((Control)Pf46()).set_BackColor(Color.Transparent);
		((Control)Pf46()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Pf46()).set_Location(new Point(293, 82));
		((Control)Pf46()).set_Name("Label15");
		((Control)Pf46()).set_Size(new Size(76, 15));
		((Control)Pf46()).set_TabIndex(23);
		Pf46().set_Text("Room Type: ");
		((ButtonBase)n2B0()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(0, 0, 192));
		((Control)n2B0()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n2B0()).set_Location(new Point(21, 338));
		((Control)n2B0()).set_Name("Button1");
		((Control)n2B0()).set_Size(new Size(96, 38));
		((Control)n2B0()).set_TabIndex(25);
		((ButtonBase)n2B0()).set_Text("CHANGE ROOM");
		((ButtonBase)n2B0()).set_UseVisualStyleBackColor(true);
		((ButtonBase)k4JA()).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(0, 0, 192));
		((Control)k4JA()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)k4JA()).set_Location(new Point(667, 338));
		((Control)k4JA()).set_Name("Button2");
		((Control)k4JA()).set_Size(new Size(96, 38));
		((Control)k4JA()).set_TabIndex(26);
		((ButtonBase)k4JA()).set_Text("CONFIRM");
		((ButtonBase)k4JA()).set_UseVisualStyleBackColor(true);
		s5QX().set_AutoSize(true);
		((Control)s5QX()).set_BackColor(Color.Transparent);
		((Control)s5QX()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)s5QX()).set_Location(new Point(530, 156));
		((Control)s5QX()).set_Name("Label17");
		((Control)s5QX()).set_Size(new Size(58, 15));
		((Control)s5QX()).set_TabIndex(31);
		s5QX().set_Text("Date Out:");
		r9G2().set_AutoSize(true);
		((Control)r9G2()).set_BackColor(Color.Transparent);
		((Control)r9G2()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)r9G2()).set_Location(new Point(459, 187));
		((Control)r9G2()).set_Name("Label21");
		((Control)r9G2()).set_Size(new Size(78, 15));
		((Control)r9G2()).set_TabIndex(42);
		r9G2().set_Text("Rate/Period: ");
		((Control)Gy54()).set_Location(new Point(554, 186));
		((Control)Gy54()).set_Name("TextBox11");
		((Control)Gy54()).set_Size(new Size(209, 20));
		((Control)Gy54()).set_TabIndex(43);
		Gy54().set_TextAlign((HorizontalAlignment)1);
		Pk81().set_AutoSize(true);
		((Control)Pk81()).set_BackColor(Color.Transparent);
		((Control)Pk81()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Pk81()).set_Location(new Point(459, 207));
		((Control)Pk81()).set_Name("Label22");
		((Control)Pk81()).set_Size(new Size(89, 15));
		((Control)Pk81()).set_TabIndex(44);
		Pk81().set_Text("Other Charges:");
		y3LY().set_AutoSize(true);
		((Control)y3LY()).set_BackColor(Color.Transparent);
		((Control)y3LY()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)y3LY()).set_Location(new Point(464, 227));
		((Control)y3LY()).set_Name("Label23");
		((Control)y3LY()).set_Size(new Size(87, 15));
		((Control)y3LY()).set_TabIndex(45);
		y3LY().set_Text("Room Service:");
		((Control)x1BW()).set_Enabled(false);
		((Control)x1BW()).set_Location(new Point(592, 227));
		((Control)x1BW()).set_Name("TextBox12");
		((Control)x1BW()).set_Size(new Size(171, 20));
		((Control)x1BW()).set_TabIndex(46);
		x1BW().set_Text("10,000.00");
		x1BW().set_TextAlign((HorizontalAlignment)1);
		t1K5().set_AutoSize(true);
		((Control)t1K5()).set_BackColor(Color.Transparent);
		((Control)t1K5()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)t1K5()).set_Location(new Point(464, 253));
		((Control)t1K5()).set_Name("Label24");
		((Control)t1K5()).set_Size(new Size(100, 15));
		((Control)t1K5()).set_TabIndex(47);
		t1K5().set_Text("Total Charges:");
		((Control)n2HA()).set_Location(new Point(592, 253));
		((Control)n2HA()).set_Name("TextBox13");
		((Control)n2HA()).set_Size(new Size(170, 20));
		((Control)n2HA()).set_TabIndex(48);
		n2HA().set_TextAlign((HorizontalAlignment)1);
		((Control)Kx06()).set_Location(new Point(592, 279));
		((Control)Kx06()).set_Name("TextBox14");
		((Control)Kx06()).set_Size(new Size(170, 20));
		((Control)Kx06()).set_TabIndex(49);
		Kx06().set_TextAlign((HorizontalAlignment)1);
		c0R5().set_AutoSize(true);
		((Control)c0R5()).set_BackColor(Color.Transparent);
		((Control)c0R5()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)c0R5()).set_Location(new Point(464, 279));
		((Control)c0R5()).set_Name("Label25");
		((Control)c0R5()).set_Size(new Size(92, 15));
		((Control)c0R5()).set_TabIndex(50);
		c0R5().set_Text("Amount Paid:");
		q6HW().set_AutoSize(true);
		((Control)q6HW()).set_BackColor(Color.Transparent);
		((Control)q6HW()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)q6HW()).set_Location(new Point(464, 306));
		((Control)q6HW()).set_Name("Label26");
		((Control)q6HW()).set_Size(new Size(63, 15));
		((Control)q6HW()).set_TabIndex(52);
		q6HW().set_Text("Balance:");
		((Control)Fg65()).set_Location(new Point(592, 306));
		((Control)Fg65()).set_Name("TextBox15");
		((Control)Fg65()).set_Size(new Size(170, 20));
		((Control)Fg65()).set_TabIndex(53);
		Fg65().set_TextAlign((HorizontalAlignment)1);
		Rg97().set_AutoSize(true);
		((Control)Rg97()).set_BackColor(Color.Transparent);
		((Control)Rg97()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Rg97()).set_Location(new Point(565, 225));
		((Control)Rg97()).set_Name("Label27");
		((Control)Rg97()).set_Size(new Size(22, 22));
		((Control)Rg97()).set_TabIndex(54);
		Rg97().set_Text("P");
		c0GE().set_AutoSize(true);
		((Control)c0GE()).set_BackColor(Color.Transparent);
		((Control)c0GE()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)c0GE()).set_Location(new Point(565, 253));
		((Control)c0GE()).set_Name("Label28");
		((Control)c0GE()).set_Size(new Size(22, 22));
		((Control)c0GE()).set_TabIndex(55);
		c0GE().set_Text("P");
		q1FY().set_AutoSize(true);
		((Control)q1FY()).set_BackColor(Color.Transparent);
		((Control)q1FY()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)q1FY()).set_Location(new Point(565, 307));
		((Control)q1FY()).set_Name("Label29");
		((Control)q1FY()).set_Size(new Size(22, 22));
		((Control)q1FY()).set_TabIndex(57);
		q1FY().set_Text("P");
		Ji90().set_AutoSize(true);
		((Control)Ji90()).set_BackColor(Color.Transparent);
		((Control)Ji90()).set_Font(new Font("Microsoft Sans Serif", 13f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ji90()).set_Location(new Point(565, 279));
		((Control)Ji90()).set_Name("Label30");
		((Control)Ji90()).set_Size(new Size(22, 22));
		((Control)Ji90()).set_TabIndex(56);
		Ji90().set_Text("P");
		((Control)Sp7t()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Sp7t()).set_Location(new Point(604, 154));
		((Control)Sp7t()).set_Name("DateTimePicker1");
		((Control)Sp7t()).set_Size(new Size(158, 21));
		((Control)Sp7t()).set_TabIndex(105);
		Sp7t().set_Value(new DateTime(2017, 9, 11, 10, 43, 0, 0));
		((Control)Dy80()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Dy80()).set_Location(new Point(358, 153));
		((Control)Dy80()).set_Name("DateTimePicker2");
		((Control)Dy80()).set_Size(new Size(158, 21));
		((Control)Dy80()).set_TabIndex(106);
		Dy80().set_Value(new DateTime(2017, 9, 11, 10, 43, 0, 0));
		((Control)Za2m()).set_Location(new Point(399, 245));
		((Control)Za2m()).set_Name("TextBox10");
		((Control)Za2m()).set_Size(new Size(54, 20));
		((Control)Za2m()).set_TabIndex(112);
		Za2m().set_TextAlign((HorizontalAlignment)2);
		k6FY().set_AutoSize(true);
		((Control)k6FY()).set_BackColor(Color.Transparent);
		((Control)k6FY()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k6FY()).set_Location(new Point(294, 245));
		((Control)k6FY()).set_Name("Label20");
		((Control)k6FY()).set_Size(new Size(91, 15));
		((Control)k6FY()).set_TabIndex(111);
		k6FY().set_Text("No. of Children:");
		((Control)Zk76()).set_Location(new Point(399, 215));
		((Control)Zk76()).set_Name("TextBox7");
		((Control)Zk76()).set_Size(new Size(54, 20));
		((Control)Zk76()).set_TabIndex(110);
		Zk76().set_TextAlign((HorizontalAlignment)2);
		o7D6().set_AutoSize(true);
		((Control)o7D6()).set_BackColor(Color.Transparent);
		((Control)o7D6()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)o7D6()).set_Location(new Point(294, 215));
		((Control)o7D6()).set_Name("Label19");
		((Control)o7D6()).set_Size(new Size(78, 15));
		((Control)o7D6()).set_TabIndex(109);
		o7D6().set_Text("No. of Adults:");
		((ListControl)j9N1()).set_FormattingEnabled(true);
		j9N1().get_Items().AddRange(new object[9] { "001", "002", "003", "004", "005", "006", "007", "008", "010" });
		((Control)j9N1()).set_Location(new Point(399, 108));
		((Control)j9N1()).set_Name("ComboBox2");
		((Control)j9N1()).set_Size(new Size(103, 21));
		((Control)j9N1()).set_TabIndex(113);
		j9N1().set_Text("Select Room No.:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ControlDark);
		((Form)this).set_ClientSize(new Size(777, 388));
		((Control)this).get_Controls().Add((Control)(object)j9N1());
		((Control)this).get_Controls().Add((Control)(object)Za2m());
		((Control)this).get_Controls().Add((Control)(object)k6FY());
		((Control)this).get_Controls().Add((Control)(object)Zk76());
		((Control)this).get_Controls().Add((Control)(object)o7D6());
		((Control)this).get_Controls().Add((Control)(object)Dy80());
		((Control)this).get_Controls().Add((Control)(object)Sp7t());
		((Control)this).get_Controls().Add((Control)(object)q1FY());
		((Control)this).get_Controls().Add((Control)(object)Ji90());
		((Control)this).get_Controls().Add((Control)(object)c0GE());
		((Control)this).get_Controls().Add((Control)(object)Rg97());
		((Control)this).get_Controls().Add((Control)(object)Fg65());
		((Control)this).get_Controls().Add((Control)(object)q6HW());
		((Control)this).get_Controls().Add((Control)(object)c0R5());
		((Control)this).get_Controls().Add((Control)(object)Kx06());
		((Control)this).get_Controls().Add((Control)(object)n2HA());
		((Control)this).get_Controls().Add((Control)(object)t1K5());
		((Control)this).get_Controls().Add((Control)(object)x1BW());
		((Control)this).get_Controls().Add((Control)(object)y3LY());
		((Control)this).get_Controls().Add((Control)(object)Pk81());
		((Control)this).get_Controls().Add((Control)(object)Gy54());
		((Control)this).get_Controls().Add((Control)(object)r9G2());
		((Control)this).get_Controls().Add((Control)(object)s5QX());
		((Control)this).get_Controls().Add((Control)(object)k4JA());
		((Control)this).get_Controls().Add((Control)(object)n2B0());
		((Control)this).get_Controls().Add((Control)(object)Ba24());
		((Control)this).get_Controls().Add((Control)(object)Pf46());
		((Control)this).get_Controls().Add((Control)(object)Dg9s());
		((Control)this).get_Controls().Add((Control)(object)Xd1w());
		((Control)this).get_Controls().Add((Control)(object)e5WZ());
		((Control)this).get_Controls().Add((Control)(object)z0AL());
		((Control)this).get_Controls().Add((Control)(object)f9HN());
		((Control)this).get_Controls().Add((Control)(object)i2WE());
		((Control)this).get_Controls().Add((Control)(object)t0L2());
		((Control)this).get_Controls().Add((Control)(object)p9G7());
		((Control)this).get_Controls().Add((Control)(object)Mt43());
		((Control)this).get_Controls().Add((Control)(object)Fi9q());
		((Control)this).get_Controls().Add((Control)(object)e1TE());
		((Control)this).get_Controls().Add((Control)(object)x0R8());
		((Control)this).get_Controls().Add((Control)(object)Pc0q());
		((Control)this).get_Controls().Add((Control)(object)i8QE());
		((Control)this).get_Controls().Add((Control)(object)y7Z8());
		((Control)this).get_Controls().Add((Control)(object)f0ZP());
		((Control)this).get_Controls().Add((Control)(object)t3T4());
		((Control)this).get_Controls().Add((Control)(object)Ww5m());
		((Control)this).get_Controls().Add((Control)(object)w8R1());
		((Control)this).set_Name("Form3");
		((Form)this).set_Text(" RESERVATION / CHECK IN FORM");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label w8R1()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0BK(Label t7NZ)
	{
		_Label1 = t7NZ;
	}

	[SpecialName]
	internal virtual Label Ww5m()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4QK(Label Bk54)
	{
		Label val = (U = Bk54);
	}

	[SpecialName]
	internal virtual Label t3T4()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb62(Label i0CN)
	{
		_Label3 = i0CN;
	}

	[SpecialName]
	internal virtual Label f0ZP()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5E9(Label c6A0)
	{
		Label val = (P = c6A0);
	}

	[SpecialName]
	internal virtual TextBox y7Z8()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fd4w(TextBox r3XZ)
	{
		_TextBox1 = r3XZ;
	}

	[SpecialName]
	internal virtual TextBox i8QE()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3FS(TextBox c1L8)
	{
		_TextBox2 = c1L8;
	}

	[SpecialName]
	internal virtual Label Pc0q()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gt35(Label Kq08)
	{
		Label val = (E = Kq08);
	}

	[SpecialName]
	internal virtual Label x0R8()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3C7(Label We9o)
	{
		Label val = (I = We9o);
	}

	[SpecialName]
	internal virtual TextBox e1TE()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3XS(TextBox d4FT)
	{
		TextBox val = (C = d4FT);
	}

	[SpecialName]
	internal virtual Label Fi9q()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void De56(Label n6XC)
	{
		Label val = (n = n6XC);
	}

	[SpecialName]
	internal virtual TextBox p9G7()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5S1(TextBox k3R9)
	{
		TextBox val = (Q = k3R9);
	}

	[SpecialName]
	internal virtual Label Mt43()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9MX(Label Tx5s)
	{
		Label val = (d = Tx5s);
	}

	[SpecialName]
	internal virtual Label t0L2()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn4o(Label Zg3e)
	{
		_Label9 = Zg3e;
	}

	[SpecialName]
	internal virtual Label i2WE()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw63(Label x3P2)
	{
		Label val = (S = x3P2);
	}

	[SpecialName]
	internal virtual Label f9HN()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Df6j(Label Kp01)
	{
		Label val = (t = Kp01);
	}

	[SpecialName]
	internal virtual Label z0AL()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8FL(Label b3F9)
	{
		_Label13 = b3F9;
	}

	[SpecialName]
	internal virtual ComboBox e5WZ()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5S1(ComboBox Ke4j)
	{
		ComboBox val = (a = Ke4j);
	}

	[SpecialName]
	internal virtual TextBox Dg9s()
	{
		return _TextBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9H6(TextBox Jr90)
	{
		_TextBox8 = Jr90;
	}

	[SpecialName]
	internal virtual Label Xd1w()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4HC(Label a3WT)
	{
		_Label14 = a3WT;
	}

	[SpecialName]
	internal virtual TextBox Ba24()
	{
		return _TextBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf3c(TextBox Fd58)
	{
		_TextBox9 = Fd58;
	}

	[SpecialName]
	internal virtual Label Pf46()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jr7y(Label Ti0b)
	{
		Label val = (L = Ti0b);
	}

	[SpecialName]
	internal virtual Button n2B0()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7TA(Button Ym4c)
	{
		EventHandler eventHandler = m5XS;
		Button val = x;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (x = Ym4c);
		val = x;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button k4JA()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw6m(Button Nf4r)
	{
		EventHandler eventHandler = Ka3o;
		Button val = m;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (m = Nf4r);
		val = m;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label s5QX()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2J9(Label He80)
	{
		Label val = (v = He80);
	}

	[SpecialName]
	internal virtual Label r9G2()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0J2(Label Le4j)
	{
		Label val = (J = Le4j);
	}

	[SpecialName]
	internal virtual TextBox Gy54()
	{
		return _TextBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp8d(TextBox f7JR)
	{
		EventHandler eventHandler = a5HX;
		TextBox textBox = _TextBox11;
		if (textBox != null)
		{
			((Control)textBox).remove_TextChanged(eventHandler);
		}
		_TextBox11 = f7JR;
		textBox = _TextBox11;
		if (textBox != null)
		{
			((Control)textBox).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Pk81()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rf86(Label Et19)
	{
		Label val = (f = Et19);
	}

	[SpecialName]
	internal virtual Label y3LY()
	{
		return _Label23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5N6(Label Lg37)
	{
		_Label23 = Lg37;
	}

	[SpecialName]
	internal virtual TextBox x1BW()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci6r(TextBox Wt1e)
	{
		TextBox val = (Y = Wt1e);
	}

	[SpecialName]
	internal virtual Label t1K5()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2M5(Label Cy81)
	{
		Label val = (w = Cy81);
	}

	[SpecialName]
	internal virtual TextBox n2HA()
	{
		return _TextBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9L7(TextBox o3KY)
	{
		_TextBox13 = o3KY;
	}

	[SpecialName]
	internal virtual TextBox Kx06()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3QC(TextBox Bz8p)
	{
		TextBox val = (G = Bz8p);
	}

	[SpecialName]
	internal virtual Label c0R5()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xi08(Label Ff1d)
	{
		Label val = (H = Ff1d);
	}

	[SpecialName]
	internal virtual Label q6HW()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void We32(Label Qs37)
	{
		Label val = (R = Qs37);
	}

	[SpecialName]
	internal virtual TextBox Fg65()
	{
		return _TextBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cj9f(TextBox Bp7o)
	{
		_TextBox15 = Bp7o;
	}

	[SpecialName]
	internal virtual Label Rg97()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wf56(Label r0R1)
	{
		Label val = (K = r0R1);
	}

	[SpecialName]
	internal virtual Label c0GE()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9SX(Label Yf7m)
	{
		Label val = (B = Yf7m);
	}

	[SpecialName]
	internal virtual Label q1FY()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4X3(Label Jj5d)
	{
		Label val = (z = Jj5d);
	}

	[SpecialName]
	internal virtual Label Ji90()
	{
		return _Label30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hr53(Label Lb14)
	{
		_Label30 = Lb14;
	}

	[SpecialName]
	internal virtual DateTimePicker Sp7t()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pb65(DateTimePicker f1H7)
	{
		_DateTimePicker1 = f1H7;
	}

	[SpecialName]
	internal virtual DateTimePicker Dy80()
	{
		return _DateTimePicker2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gj7m(DateTimePicker r4S7)
	{
		_DateTimePicker2 = r4S7;
	}

	[SpecialName]
	internal virtual TextBox Za2m()
	{
		return _TextBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4QK(TextBox p2W9)
	{
		_TextBox10 = p2W9;
	}

	[SpecialName]
	internal virtual Label k6FY()
	{
		return UO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3W4(Label g8GR)
	{
		Label val = (UO = g8GR);
	}

	[SpecialName]
	internal virtual TextBox Zk76()
	{
		return _TextBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec78(TextBox Fy3k)
	{
		_TextBox7 = Fy3k;
	}

	[SpecialName]
	internal virtual Label o7D6()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cx12(Label Ba0b)
	{
		_Label19 = Ba0b;
	}

	[SpecialName]
	internal virtual ComboBox j9N1()
	{
		return _ComboBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz17(ComboBox Zb32)
	{
		_ComboBox2 = Zb32;
	}

	public void m8F5()
	{
		string query = "select *from profile";
		new Ze2s(query, UI);
	}

	private void Mn8s(object sender, EventArgs e)
	{
		Sp7t().set_Format((DateTimePickerFormat)8);
		Sp7t().set_CustomFormat("dd/MM/yyyy");
		Dy80().set_Format((DateTimePickerFormat)8);
		Dy80().set_CustomFormat("dd/MM/yyyy");
	}

	private void m5XS(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)i7X.Forms.Cx2()).Show();
	}

	private void a5HX(object sender, EventArgs e)
	{
		Gy54().set_Text(i7X.Forms.Cx2().Fg64().get_Text());
		((Control)Gy54()).set_Enabled(false);
	}

	internal static byte[] f0H3(int d5A1, int Qj85)
	{
		if (d5A1 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Qj85 + 1];
			for (int i = 0; i <= Qj85; i++)
			{
				int num = d5A1 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return m3HN.a9C3(array, Qj85);
		}
	}

	private void Ka3o(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)i7X.Forms.Ly7()).Show();
		UI.q9TB();
		try
		{
			m3HN m3HN = UI.Lj1x();
			object obj = m3HN.q5D3();
			TextBox val;
			object[] obj2 = new object[2]
			{
				"@lname",
				(val = y7Z8()).get_Text()
			};
			object[] array = obj2;
			bool[] obj3 = new bool[2] { false, true };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(obj, (Type)null, "AddWithValue", obj2, (string[])null, (Type[])null, obj3, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@fname",
				(val = i8QE()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@country",
				(val = e1TE()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@company",
				(val = p9G7()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			ComboBox val2;
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@idtyp",
				(val2 = e5WZ()).get_SelectedItem()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val2.set_SelectedItem(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1])));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@idnom",
				(val = Dg9s()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@roomtyp",
				(val = Ba24()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@roomnom",
				(val2 = j9N1()).get_SelectedItem()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val2.set_SelectedItem(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[1])));
			}
			DateTimePicker val3;
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@datein",
				(val3 = Sp7t()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val3.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@rate",
				(val = Gy54()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@nomchi",
				(val = Zk76()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@nomadu",
				(val = Za2m()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@romser",
				(val = x1BW()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@tot",
				(val = n2HA()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@amt",
				(val = Kx06()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			NewLateBinding.LateCall(m3HN.q5D3(), (Type)null, "AddWithValue", array = new object[2]
			{
				"@bal",
				(val = Fg65()).get_Text()
			}, (string[])null, (Type[])null, array2 = new bool[2] { false, true }, true);
			if (array2[1])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string)));
			}
			m3HN.t6Y7();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(Ba24().get_Text(), "PinakaDATO Suite Room", false) == 0)
		{
			this.x = Conversion.Val((object)1010000);
			double num = (UU = Conversion.Val(Kx06().get_Text()));
			double num2 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "Medyo DATO Suite Room", false) == 0)
		{
			this.x = Conversion.Val((object)510000);
			double num3 = (UU = Conversion.Val(Kx06().get_Text()));
			double num4 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "DATO-DATOAN Suite Room", false) == 0)
		{
			this.x = Conversion.Val((object)260000);
			double num5 = (UU = Conversion.Val(Kx06().get_Text()));
			double num6 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "Pinaka-MAYKAYA Suite Room", false) == 0)
		{
			this.x = Conversion.Val((object)135000);
			double num7 = (UU = Conversion.Val(Kx06().get_Text()));
			double num8 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "Medyo MAYKAYA Room", false) == 0)
		{
			this.x = Conversion.Val((object)72500);
			double num9 = (UU = Conversion.Val(Kx06().get_Text()));
			double num10 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "KAYA-KAYAHA Room", false) == 0)
		{
			this.x = Conversion.Val((object)41250);
			double num11 = (UU = Conversion.Val(Kx06().get_Text()));
			double num12 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "POBRE Room", false) == 0)
		{
			this.x = Conversion.Val((object)25625);
			double num13 = (UU = Conversion.Val(Kx06().get_Text()));
			double num14 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "Mas-POBRE Room", false) == 0)
		{
			this.x = Conversion.Val((object)17812.5);
			double num15 = (UU = Conversion.Val(Kx06().get_Text()));
			double num16 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "Pinaka-POBRE Room", false) == 0)
		{
			this.x = Conversion.Val((object)13906.25);
			double num17 = (UU = Conversion.Val(Kx06().get_Text()));
			double num18 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		else if (Operators.CompareString(Ba24().get_Text(), "Pinaka-AFFORDABLE Suite Room", false) == 0)
		{
			this.x = Conversion.Val((object)10000);
			double num19 = (UU = Conversion.Val(Kx06().get_Text()));
			double num20 = (UP = this.x - UU);
			if (UP < 1.0)
			{
				UP *= -1.0;
				i7X.Forms.Ly7().As95().set_Text("CHANGE");
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
			else
			{
				i7X.Forms.Ly7().Fo96().set_Text("P     " + Conversions.ToString(UP));
				((Control)i7X.Forms.Ly7().Fo96()).set_Enabled(false);
			}
		}
		i7X.Forms.Ly7().Lx3d().set_Text(y7Z8().get_Text());
		((Control)i7X.Forms.Ly7().Lx3d()).set_Enabled(false);
		i7X.Forms.Ly7().Lp53().set_Text(i8QE().get_Text());
		((Control)i7X.Forms.Ly7().Lp53()).set_Enabled(false);
		i7X.Forms.Ly7().Zs24().set_Text(e1TE().get_Text());
		((Control)i7X.Forms.Ly7().Zs24()).set_Enabled(false);
		i7X.Forms.Ly7().At94().set_Text(p9G7().get_Text());
		((Control)i7X.Forms.Ly7().At94()).set_Enabled(false);
		i7X.Forms.Ly7().r3N4().set_Text(Zk76().get_Text());
		((Control)i7X.Forms.Ly7().r3N4()).set_Enabled(false);
		i7X.Forms.Ly7().Wi9z().set_Text(Dg9s().get_Text());
		((Control)i7X.Forms.Ly7().Wi9z()).set_Enabled(false);
		i7X.Forms.Ly7().Hx6a().set_Text(Ba24().get_Text());
		((Control)i7X.Forms.Ly7().Hx6a()).set_Enabled(false);
		i7X.Forms.Ly7().j2GL().set_Text(Za2m().get_Text());
		((Control)i7X.Forms.Ly7().j2GL()).set_Enabled(false);
		i7X.Forms.Ly7().Yg41().set_Text(Gy54().get_Text());
		((Control)i7X.Forms.Ly7().Yg41()).set_Enabled(false);
		i7X.Forms.Ly7().Zd61().set_Text(x1BW().get_Text());
		((Control)i7X.Forms.Ly7().Zd61()).set_Enabled(false);
		i7X.Forms.Ly7().Di52().set_Text(n2HA().get_Text());
		((Control)i7X.Forms.Ly7().Di52()).set_Enabled(false);
		i7X.Forms.Ly7().Qd29().set_Text(Kx06().get_Text());
		((Control)i7X.Forms.Ly7().Qd29()).set_Enabled(false);
		i7X.Forms.Ly7().z7QW().set_SelectedItem(RuntimeHelpers.GetObjectValue(e5WZ().get_SelectedItem()));
		((Control)i7X.Forms.Ly7().z7QW()).set_Enabled(false);
		i7X.Forms.Ly7().Fc4t().set_SelectedItem(RuntimeHelpers.GetObjectValue(j9N1().get_SelectedItem()));
		((Control)i7X.Forms.Ly7().Fc4t()).set_Enabled(false);
		i7X.Forms.Ly7().Gb3s().set_Value(Sp7t().get_Value());
		((Control)i7X.Forms.Ly7().Gb3s()).set_Enabled(false);
		i7X.Forms.Ly7().p8H1().set_Value(Dy80().get_Value());
		((Control)i7X.Forms.Ly7().p8H1()).set_Enabled(false);
	}
}
