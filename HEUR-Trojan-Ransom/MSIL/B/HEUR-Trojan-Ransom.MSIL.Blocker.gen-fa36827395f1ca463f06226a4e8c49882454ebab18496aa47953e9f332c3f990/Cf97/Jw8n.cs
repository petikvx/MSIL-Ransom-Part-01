using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Fg4e;
using Microsoft.VisualBasic.CompilerServices;
using d3J;
using t0B;

namespace Cf97;

[DesignerGenerated]
public class Jw8n : UserControl
{
	private ContextMenuStrip _ContextMenuStrip1;

	private TextBox _ISBNTextBox1;

	private TextBox _TotalTextBox;

	private DateTimePicker _PublishYearDateTimePicker;

	private TextBox _TitleTextBox;

	private TextBox _PublisherTextBox;

	private Button _myButton;

	private Label _Label1;

	private NumericUpDown _AddNumber;

	private PictureBox _PictureBox1;

	private Button _uploadButton;

	private Label _PriceLabel;

	private MaskedTextBox _PriceBox;

	private Label _TotalLabel;

	private Label _ISBNLabel;

	private Label _PublisherLabel;

	private Label _AuthorLabel;

	private Label _FieldLabel;

	private Label _LocationLabel;

	private Label _PublishYearLabel;

	private Pt8 _DatabaseDataSet1;

	internal IContainer N;

	internal TextBox q;

	internal TextBox m;

	internal TextBox F;

	internal OpenFileDialog c;

	internal Label p;

	internal Label a;

	internal ComboBox b;

	internal Label t;

	internal object S;

	internal string h;

	public Jw8n()
	{
		((UserControl)this).add_Load((EventHandler)Et9d);
		object obj = (S = m2A.Forms.At0().connectionString);
		string text = (h = "");
		i3G4();
	}

	protected override void z8X5(bool x9CS)
	{
		try
		{
			if (x9CS && N != null)
			{
				N.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(x9CS);
		}
	}

	private void i3G4()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected O, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Expected O, but got Unknown
		//IL_0ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected O, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Expected O, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Expected O, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Expected O, but got Unknown
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edb: Expected O, but got Unknown
		//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected O, but got Unknown
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1013: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Expected O, but got Unknown
		//IL_103e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e6: Expected O, but got Unknown
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Expected O, but got Unknown
		//IL_1434: Unknown result type (might be due to invalid IL or missing references)
		IContainer container = (N = new Container());
		c1Y8(new ContextMenuStrip(N));
		Tz9f(new TextBox());
		Qp1m(new TextBox());
		Ct74(new TextBox());
		y9SW(new TextBox());
		Ag1b(new DateTimePicker());
		t4G5(new TextBox());
		Mp17(new TextBox());
		o4AJ(new TextBox());
		Ln91(new Button());
		a1G0(new Label());
		g5FL(new NumericUpDown());
		z2GF(new PictureBox());
		Gf32(new Button());
		Rm35(new OpenFileDialog());
		j9J0(new Label());
		e0XE(new MaskedTextBox());
		Zw3j(new Label());
		Ys08(new Label());
		Wo2x(new Label());
		g7P3(new Label());
		Me23(new Label());
		Tn5x(new Label());
		w4MS(new Label());
		Sk3m(new Label());
		Ar46(new Label());
		g8B7(new Pt8());
		i7YW(new ComboBox());
		g5Q2(new Label());
		((ISupportInitialize)Ag5y()).BeginInit();
		((ISupportInitialize)g1X0()).BeginInit();
		((ISupportInitialize)b9B4()).BeginInit();
		((Control)this).SuspendLayout();
		((ToolStrip)Sx2r()).set_ImageScalingSize(new Size(20, 20));
		((Control)Sx2r()).set_Name("ContextMenuStrip1");
		((Control)Sx2r()).set_Size(new Size(61, 4));
		((Control)Fd2x()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Fd2x()).set_Location(new Point(198, 79));
		((Control)Fd2x()).set_Margin(new Padding(2));
		((Control)Fd2x()).set_Name("ISBNTextBox1");
		((Control)Fd2x()).set_Size(new Size(244, 26));
		((Control)Fd2x()).set_TabIndex(11);
		((Control)i7AJ()).set_Enabled(false);
		((Control)i7AJ()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i7AJ()).set_Location(new Point(198, 117));
		((Control)i7AJ()).set_Margin(new Padding(2));
		((Control)i7AJ()).set_Name("TotalTextBox");
		((Control)i7AJ()).set_Size(new Size(244, 26));
		((Control)i7AJ()).set_TabIndex(13);
		i7AJ().set_Text("0");
		((Control)i7AJ()).set_Visible(false);
		((Control)o4YD()).set_Enabled(false);
		((Control)o4YD()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)o4YD()).set_Location(new Point(198, 148));
		((Control)o4YD()).set_Margin(new Padding(2));
		((Control)o4YD()).set_Name("RemainingTextBox");
		((Control)o4YD()).set_Size(new Size(244, 26));
		((Control)o4YD()).set_TabIndex(15);
		o4YD().set_Text("0");
		((Control)o4YD()).set_Visible(false);
		((Control)Ta4b()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ta4b()).set_Location(new Point(198, 189));
		((Control)Ta4b()).set_Margin(new Padding(2));
		((Control)Ta4b()).set_Name("LocationTextBox");
		((Control)Ta4b()).set_Size(new Size(244, 26));
		((Control)Ta4b()).set_TabIndex(17);
		((Control)Ta4b()).set_Visible(false);
		((Control)Yq1m()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Yq1m()).set_Location(new Point(198, 230));
		((Control)Yq1m()).set_Margin(new Padding(2));
		((Control)Yq1m()).set_Name("PublishYearDateTimePicker");
		((Control)Yq1m()).set_Size(new Size(244, 26));
		((Control)Yq1m()).set_TabIndex(19);
		((Control)Yq1m()).set_Visible(false);
		((Control)Ns9r()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ns9r()).set_Location(new Point(198, 262));
		((Control)Ns9r()).set_Margin(new Padding(2));
		((Control)Ns9r()).set_Name("TitleTextBox");
		((Control)Ns9r()).set_Size(new Size(244, 26));
		((Control)Ns9r()).set_TabIndex(21);
		((Control)Ns9r()).set_Visible(false);
		((Control)r2D3()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)r2D3()).set_Location(new Point(198, 296));
		((Control)r2D3()).set_Margin(new Padding(2));
		((Control)r2D3()).set_Name("AuthorTextBox");
		((Control)r2D3()).set_Size(new Size(244, 26));
		((Control)r2D3()).set_TabIndex(23);
		((Control)r2D3()).set_Visible(false);
		((Control)o3X4()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)o3X4()).set_Location(new Point(198, 330));
		((Control)o3X4()).set_Margin(new Padding(2));
		((Control)o3X4()).set_Name("PublisherTextBox");
		((Control)o3X4()).set_Size(new Size(244, 26));
		((Control)o3X4()).set_TabIndex(25);
		((Control)o3X4()).set_Visible(false);
		((ButtonBase)q5R3()).set_BackColor(Color.MediumSeaGreen);
		((Control)q5R3()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)q5R3()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)q5R3()).set_FlatStyle((FlatStyle)1);
		((Control)q5R3()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)q5R3()).set_ForeColor(Color.White);
		((Control)q5R3()).set_Location(new Point(217, 497));
		((Control)q5R3()).set_Margin(new Padding(2));
		((Control)q5R3()).set_Name("myButton");
		((Control)q5R3()).set_Size(new Size(225, 42));
		((Control)q5R3()).set_TabIndex(30);
		((ButtonBase)q5R3()).set_Text("Search");
		((ButtonBase)q5R3()).set_UseVisualStyleBackColor(false);
		Lf05().set_AutoSize(true);
		((Control)Lf05()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lf05()).set_Location(new Point(87, 444));
		((Control)Lf05()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Lf05()).set_Name("Label1");
		((Control)Lf05()).set_Size(new Size(160, 19));
		((Control)Lf05()).set_TabIndex(32);
		Lf05().set_Text("Number of books to add");
		((Control)Lf05()).set_Visible(false);
		((Control)Ag5y()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ag5y()).set_Location(new Point(271, 442));
		((Control)Ag5y()).set_Margin(new Padding(2));
		Ag5y().set_Maximum(new decimal(new int[4] { 10000, 0, 0, 0 }));
		((Control)Ag5y()).set_Name("AddNumber");
		((Control)Ag5y()).set_Size(new Size(171, 26));
		((Control)Ag5y()).set_TabIndex(33);
		((Control)Ag5y()).set_Visible(false);
		((Control)g1X0()).set_Location(new Point(583, 79));
		((Control)g1X0()).set_Margin(new Padding(2));
		((Control)g1X0()).set_Name("PictureBox1");
		((Control)g1X0()).set_Size(new Size(200, 200));
		g1X0().set_SizeMode((PictureBoxSizeMode)1);
		g1X0().set_TabIndex(34);
		g1X0().set_TabStop(false);
		((Control)g1X0()).set_Visible(false);
		((ButtonBase)w0AB()).set_BackColor(Color.MediumSeaGreen);
		((Control)w0AB()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)w0AB()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)w0AB()).set_FlatStyle((FlatStyle)1);
		((Control)w0AB()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)w0AB()).set_ForeColor(Color.White);
		((Control)w0AB()).set_Location(new Point(583, 308));
		((Control)w0AB()).set_Margin(new Padding(2));
		((Control)w0AB()).set_Name("uploadButton");
		((Control)w0AB()).set_Size(new Size(200, 48));
		((Control)w0AB()).set_TabIndex(35);
		((ButtonBase)w0AB()).set_Text("Upload Image");
		((ButtonBase)w0AB()).set_UseVisualStyleBackColor(false);
		((Control)w0AB()).set_Visible(false);
		((FileDialog)Ap5i()).set_FileName("OpenFileDialog1");
		Tr6q().set_AutoSize(true);
		((Control)Tr6q()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Tr6q()).set_Location(new Point(121, 403));
		((Control)Tr6q()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Tr6q()).set_Name("PriceLabel");
		((Control)Tr6q()).set_Size(new Size(40, 23));
		((Control)Tr6q()).set_TabIndex(36);
		Tr6q().set_Text("Price");
		Tr6q().set_UseCompatibleTextRendering(true);
		((Control)Tr6q()).set_Visible(false);
		((Control)c7L3()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)c7L3()).set_Location(new Point(198, 400));
		((Control)c7L3()).set_Margin(new Padding(2));
		((Control)c7L3()).set_Name("PriceBox");
		((Control)c7L3()).set_Size(new Size(244, 26));
		((Control)c7L3()).set_TabIndex(37);
		((Control)c7L3()).set_Visible(false);
		k8Z1().set_AutoSize(true);
		((Control)k8Z1()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k8Z1()).set_Location(new Point(113, 82));
		((Control)k8Z1()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)k8Z1()).set_Name("ISBNLabel");
		((Control)k8Z1()).set_Size(new Size(48, 19));
		((Control)k8Z1()).set_TabIndex(10);
		k8Z1().set_Text("ISBN:");
		i3QR().set_AutoSize(true);
		((Control)i3QR()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i3QR()).set_Location(new Point(119, 120));
		((Control)i3QR()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)i3QR()).set_Name("TotalLabel");
		((Control)i3QR()).set_Size(new Size(42, 19));
		((Control)i3QR()).set_TabIndex(12);
		i3QR().set_Text("Total:");
		((Control)i3QR()).set_Visible(false);
		s5PW().set_AutoSize(true);
		((Control)s5PW()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)s5PW()).set_Location(new Point(87, 151));
		((Control)s5PW()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)s5PW()).set_Name("RemainingLabel");
		((Control)s5PW()).set_Size(new Size(74, 19));
		((Control)s5PW()).set_TabIndex(14);
		s5PW().set_Text("Remaining:");
		((Control)s5PW()).set_Visible(false);
		r0M4().set_AutoSize(true);
		((Control)r0M4()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)r0M4()).set_Location(new Point(96, 192));
		((Control)r0M4()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)r0M4()).set_Name("LocationLabel");
		((Control)r0M4()).set_Size(new Size(65, 19));
		((Control)r0M4()).set_TabIndex(16);
		r0M4().set_Text("Location:");
		((Control)r0M4()).set_Visible(false);
		Mn52().set_AutoSize(true);
		((Control)Mn52()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Mn52()).set_Location(new Point(75, 236));
		((Control)Mn52()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Mn52()).set_Name("PublishYearLabel");
		((Control)Mn52()).set_Size(new Size(86, 19));
		((Control)Mn52()).set_TabIndex(18);
		Mn52().set_Text("Publish Year:");
		((Control)Mn52()).set_Visible(false);
		c4P9().set_AutoSize(true);
		((Control)c4P9()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)c4P9()).set_Location(new Point(124, 265));
		((Control)c4P9()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)c4P9()).set_Name("TitleLabel");
		((Control)c4P9()).set_Size(new Size(37, 19));
		((Control)c4P9()).set_TabIndex(20);
		c4P9().set_Text("Title:");
		((Control)c4P9()).set_Visible(false);
		a3J5().set_AutoSize(true);
		((Control)a3J5()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)a3J5()).set_Location(new Point(105, 296));
		((Control)a3J5()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)a3J5()).set_Name("AuthorLabel");
		((Control)a3J5()).set_Size(new Size(54, 19));
		((Control)a3J5()).set_TabIndex(22);
		a3J5().set_Text("Author:");
		((Control)a3J5()).set_Visible(false);
		Qa65().set_AutoSize(true);
		((Control)Qa65()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Qa65()).set_Location(new Point(94, 333));
		((Control)Qa65()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Qa65()).set_Name("PublisherLabel");
		((Control)Qa65()).set_Size(new Size(67, 19));
		((Control)Qa65()).set_TabIndex(24);
		Qa65().set_Text("Publisher:");
		((Control)Qa65()).set_Visible(false);
		Qg0q().set_AutoSize(true);
		((Control)Qg0q()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Qg0q()).set_Location(new Point(117, 365));
		((Control)Qg0q()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Qg0q()).set_Name("FieldLabel");
		((Control)Qg0q()).set_Size(new Size(42, 19));
		((Control)Qg0q()).set_TabIndex(26);
		Qg0q().set_Text("Field:");
		((Control)Qg0q()).set_Visible(false);
		b9B4().DataSetName = "DatabaseDataSet";
		b9B4().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)o3L4()).set_AllowDrop(true);
		o3L4().set_DropDownStyle((ComboBoxStyle)2);
		((Control)o3L4()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)o3L4()).set_FormattingEnabled(true);
		o3L4().get_Items().AddRange(new object[11]
		{
			"Biosciences and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engg.", "Design", "Electronics and Electrical Engg.", "Humanities and Social Sciences", "Mathematics", "Mechanical Engineering",
			"Physics"
		});
		((Control)o3L4()).set_Location(new Point(198, 362));
		((Control)o3L4()).set_Margin(new Padding(2));
		((Control)o3L4()).set_Name("FieldTextBox");
		((Control)o3L4()).set_Size(new Size(244, 27));
		((Control)o3L4()).set_TabIndex(38);
		((Control)o3L4()).set_Visible(false);
		Sd85().set_AutoSize(true);
		((Control)Sd85()).set_Font(new Font("Times New Roman", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Sd85()).set_ForeColor(Color.Red);
		((Control)Sd85()).set_Location(new Point(44, 29));
		((Control)Sd85()).set_Name("Label2");
		((Control)Sd85()).set_Size(new Size(95, 23));
		((Control)Sd85()).set_TabIndex(39);
		Sd85().set_Text("Add Book");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Sd85());
		((Control)this).get_Controls().Add((Control)(object)o3L4());
		((Control)this).get_Controls().Add((Control)(object)c7L3());
		((Control)this).get_Controls().Add((Control)(object)Tr6q());
		((Control)this).get_Controls().Add((Control)(object)w0AB());
		((Control)this).get_Controls().Add((Control)(object)g1X0());
		((Control)this).get_Controls().Add((Control)(object)Ag5y());
		((Control)this).get_Controls().Add((Control)(object)Lf05());
		((Control)this).get_Controls().Add((Control)(object)q5R3());
		((Control)this).get_Controls().Add((Control)(object)k8Z1());
		((Control)this).get_Controls().Add((Control)(object)Fd2x());
		((Control)this).get_Controls().Add((Control)(object)i3QR());
		((Control)this).get_Controls().Add((Control)(object)i7AJ());
		((Control)this).get_Controls().Add((Control)(object)s5PW());
		((Control)this).get_Controls().Add((Control)(object)o4YD());
		((Control)this).get_Controls().Add((Control)(object)r0M4());
		((Control)this).get_Controls().Add((Control)(object)Ta4b());
		((Control)this).get_Controls().Add((Control)(object)Mn52());
		((Control)this).get_Controls().Add((Control)(object)Yq1m());
		((Control)this).get_Controls().Add((Control)(object)c4P9());
		((Control)this).get_Controls().Add((Control)(object)Ns9r());
		((Control)this).get_Controls().Add((Control)(object)a3J5());
		((Control)this).get_Controls().Add((Control)(object)r2D3());
		((Control)this).get_Controls().Add((Control)(object)Qa65());
		((Control)this).get_Controls().Add((Control)(object)o3X4());
		((Control)this).get_Controls().Add((Control)(object)Qg0q());
		((Control)this).set_Margin(new Padding(2));
		((Control)this).set_Name("addBook");
		((Control)this).set_Size(new Size(1017, 681));
		((ISupportInitialize)Ag5y()).EndInit();
		((ISupportInitialize)g1X0()).EndInit();
		((ISupportInitialize)b9B4()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ContextMenuStrip Sx2r()
	{
		return _ContextMenuStrip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1Y8(ContextMenuStrip c6B4)
	{
		_ContextMenuStrip1 = c6B4;
	}

	[SpecialName]
	internal virtual TextBox Fd2x()
	{
		return _ISBNTextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tz9f(TextBox s9X7)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		KeyEventHandler val = new KeyEventHandler(z3SP);
		TextBox iSBNTextBox = _ISBNTextBox1;
		if (iSBNTextBox != null)
		{
			((Control)iSBNTextBox).remove_KeyDown(val);
		}
		_ISBNTextBox1 = s9X7;
		iSBNTextBox = _ISBNTextBox1;
		if (iSBNTextBox != null)
		{
			((Control)iSBNTextBox).add_KeyDown(val);
		}
	}

	[SpecialName]
	internal virtual TextBox i7AJ()
	{
		return _TotalTextBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qp1m(TextBox Xy5r)
	{
		_TotalTextBox = Xy5r;
	}

	[SpecialName]
	internal virtual TextBox o4YD()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ct74(TextBox d9AE)
	{
		TextBox val = (q = d9AE);
	}

	[SpecialName]
	internal virtual TextBox Ta4b()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9SW(TextBox a4AR)
	{
		TextBox val = (m = a4AR);
	}

	[SpecialName]
	internal virtual DateTimePicker Yq1m()
	{
		return _PublishYearDateTimePicker;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ag1b(DateTimePicker Mr5c)
	{
		_PublishYearDateTimePicker = Mr5c;
	}

	[SpecialName]
	internal virtual TextBox Ns9r()
	{
		return _TitleTextBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t4G5(TextBox Ji9k)
	{
		_TitleTextBox = Ji9k;
	}

	[SpecialName]
	internal virtual TextBox r2D3()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp17(TextBox Dg0i)
	{
		TextBox val = (F = Dg0i);
	}

	[SpecialName]
	internal virtual TextBox o3X4()
	{
		return _PublisherTextBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4AJ(TextBox d1C8)
	{
		_PublisherTextBox = d1C8;
	}

	[SpecialName]
	internal virtual Button q5R3()
	{
		return _myButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln91(Button Yo90)
	{
		EventHandler eventHandler = q4C7;
		Button myButton = _myButton;
		if (myButton != null)
		{
			((Control)myButton).remove_Click(eventHandler);
		}
		_myButton = Yo90;
		myButton = _myButton;
		if (myButton != null)
		{
			((Control)myButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Lf05()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1G0(Label Qe73)
	{
		_Label1 = Qe73;
	}

	[SpecialName]
	internal virtual NumericUpDown Ag5y()
	{
		return _AddNumber;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5FL(NumericUpDown Mj7d)
	{
		_AddNumber = Mj7d;
	}

	[SpecialName]
	internal virtual PictureBox g1X0()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2GF(PictureBox Sg23)
	{
		_PictureBox1 = Sg23;
	}

	[SpecialName]
	internal virtual Button w0AB()
	{
		return _uploadButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gf32(Button Gg4o)
	{
		EventHandler eventHandler = Cn0t;
		Button uploadButton = _uploadButton;
		if (uploadButton != null)
		{
			((Control)uploadButton).remove_Click(eventHandler);
		}
		_uploadButton = Gg4o;
		uploadButton = _uploadButton;
		if (uploadButton != null)
		{
			((Control)uploadButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual OpenFileDialog Ap5i()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rm35(OpenFileDialog f3CJ)
	{
		OpenFileDialog val = (c = f3CJ);
	}

	[SpecialName]
	internal virtual Label Tr6q()
	{
		return _PriceLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9J0(Label k9SM)
	{
		_PriceLabel = k9SM;
	}

	[SpecialName]
	internal virtual MaskedTextBox c7L3()
	{
		return _PriceBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0XE(MaskedTextBox Pk8s)
	{
		_PriceBox = Pk8s;
	}

	[SpecialName]
	internal virtual Label i3QR()
	{
		return _TotalLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ys08(Label g3DN)
	{
		_TotalLabel = g3DN;
	}

	[SpecialName]
	internal virtual Label k8Z1()
	{
		return _ISBNLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zw3j(Label x8JX)
	{
		_ISBNLabel = x8JX;
	}

	[SpecialName]
	internal virtual Label Qa65()
	{
		return _PublisherLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk3m(Label Ho1n)
	{
		_PublisherLabel = Ho1n;
	}

	[SpecialName]
	internal virtual Label c4P9()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn5x(Label m0C4)
	{
		Label val = (p = m0C4);
	}

	[SpecialName]
	internal virtual Label a3J5()
	{
		return _AuthorLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4MS(Label Rb78)
	{
		_AuthorLabel = Rb78;
	}

	[SpecialName]
	internal virtual Label Qg0q()
	{
		return _FieldLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar46(Label Fr2d)
	{
		_FieldLabel = Fr2d;
	}

	[SpecialName]
	internal virtual Label s5PW()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wo2x(Label y5D4)
	{
		Label val = (a = y5D4);
	}

	[SpecialName]
	internal virtual Label r0M4()
	{
		return _LocationLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7P3(Label Aq5p)
	{
		_LocationLabel = Aq5p;
	}

	[SpecialName]
	internal virtual Label Mn52()
	{
		return _PublishYearLabel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me23(Label n7GH)
	{
		_PublishYearLabel = n7GH;
	}

	[SpecialName]
	internal virtual Pt8 b9B4()
	{
		return _DatabaseDataSet1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8B7(Pt8 g9Z6)
	{
		_DatabaseDataSet1 = g9Z6;
	}

	[SpecialName]
	internal virtual ComboBox o3L4()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7YW(ComboBox j3R6)
	{
		ComboBox val = (b = j3R6);
	}

	[SpecialName]
	internal virtual Label Sd85()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5Q2(Label b0QD)
	{
		Label val = (t = b0QD);
	}

	private void z3SP(object sender, KeyEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I4, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		Regex regex = new Regex("^(97(8|9))?\\d{9}(\\d|X)$");
		Console.Write((int)e.get_KeyCode());
		if ((int)e.get_KeyCode() != 13)
		{
			return;
		}
		string text = (h = "");
		Console.WriteLine(Fd2x().get_Text());
		string text2 = Fd2x().get_Text();
		int num = 0;
		while (true)
		{
			if (num < text2.Length)
			{
				char c = text2[num];
				if ((Operators.CompareString(Conversions.ToString(c), "0", false) >= 0 && Operators.CompareString(Conversions.ToString(c), "9", false) <= 0) | (Operators.CompareString(Conversions.ToString(c), "x", false) == 0) | (Operators.CompareString(Conversions.ToString(c), "X", false) == 0))
				{
					h += Conversions.ToString(c);
				}
				else if (Operators.CompareString(Conversions.ToString(c), "-", false) != 0)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			Console.WriteLine(h);
			if (regex.IsMatch(h) && q0SQ.w7ME(h))
			{
				Lo79();
			}
			else
			{
				MessageBox.Show("Invalid ISBN Number");
			}
			return;
		}
		MessageBox.Show("Invalid ISBN Number");
	}

	private void q4C7(object sender, EventArgs e)
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		int num3;
		int num2;
		checked
		{
			if (Operators.CompareString(((ButtonBase)q5R3()).get_Text(), "Search", false) == 0)
			{
				Regex regex = new Regex("^(97(8|9))?\\d{9}(\\d|X)$");
				string text = (h = "");
				Console.WriteLine(Fd2x().get_Text());
				string text2 = Fd2x().get_Text();
				int num = 0;
				while (true)
				{
					if (num < text2.Length)
					{
						char c = text2[num];
						if ((Operators.CompareString(Conversions.ToString(c), "0", false) >= 0 && Operators.CompareString(Conversions.ToString(c), "9", false) <= 0) | (Operators.CompareString(Conversions.ToString(c), "x", false) == 0) | (Operators.CompareString(Conversions.ToString(c), "X", false) == 0))
						{
							h += Conversions.ToString(c);
						}
						else if (Operators.CompareString(Conversions.ToString(c), "-", false) != 0)
						{
							break;
						}
						num++;
						continue;
					}
					Console.WriteLine(h);
					if (regex.IsMatch(h) && q0SQ.w7ME(h))
					{
						Lo79();
					}
					else
					{
						MessageBox.Show("Invalid ISBN Number");
					}
					return;
				}
				MessageBox.Show("Invalid ISBN Number");
				return;
			}
			OleDbConnection val = new OleDbConnection(Conversions.ToString(S));
			if (!j5L0())
			{
				return;
			}
			string text3 = Fd2x().get_Text();
			if (g1X0().get_Image() == null)
			{
				text3 = "defaultBook";
			}
			val.Open();
			i7AJ().set_Text(Conversions.ToString(decimal.Add(Ag5y().get_Value(), new decimal(Convert.ToInt64(i7AJ().get_Text())))));
			o4YD().set_Text(Conversions.ToString(decimal.Add(Ag5y().get_Value(), new decimal(Convert.ToInt64(o4YD().get_Text())))));
			string text4 = ((Operators.CompareString(((ButtonBase)q5R3()).get_Text(), "Add", false) != 0) ? ("update Books set Total= " + i7AJ().get_Text() + ",Remaining= " + o4YD().get_Text() + ",PublishYear='" + Conversions.ToString(Yq1m().get_Value()) + "',Location= '" + Ta4b().get_Text() + "',Title='" + Ns9r().get_Text() + "',Author='" + r2D3().get_Text() + "',Field='" + o3L4().get_Text() + "' , Publisher='" + o3X4().get_Text() + "' ,BookImage='" + text3 + ".JPG' , Price='" + c7L3().get_Text() + "' where ISBN='" + h + "'") : ("insert into Books values('" + h + "', " + i7AJ().get_Text() + "," + i7AJ().get_Text() + ",'" + Ta4b().get_Text() + "','" + Conversions.ToString(Yq1m().get_Value().Date) + "','" + Ns9r().get_Text() + "','" + r2D3().get_Text() + "','" + o3X4().get_Text() + "','" + o3L4().get_Text() + "','" + text3 + ".JPG','" + c7L3().get_Text() + "', '0', '0')"));
			if (g1X0().get_Image() != null)
			{
				g1X0().get_Image().Save(Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\") + text3 + ".JPG");
			}
			OleDbCommand val2 = new OleDbCommand(text4, val);
			OleDbDataReader val3 = val2.ExecuteReader();
			val3.Close();
			num2 = int.MaxValue;
			num3 = int.MinValue;
			val2.set_CommandText("insert into Borrowed (ISBN) values ('" + h + "') ");
			int num4 = Convert.ToInt32(Ag5y().get_Value());
			for (int i = 1; i <= num4; i++)
			{
				Console.WriteLine(RuntimeHelpers.GetObjectValue(val2.ExecuteScalar()));
				val2.set_CommandText("select @@identity");
				int num5 = Conversions.ToInteger(val2.ExecuteScalar());
				if (num5 > num3)
				{
					num3 = num5;
				}
				if (num5 < num2)
				{
					num2 = num5;
				}
				val2.set_CommandText("insert into Borrowed (ISBN) values ('" + h + "') ");
			}
		}
		if (decimal.Compare(Ag5y().get_Value(), 0m) == 0)
		{
			num2 = 0 - ((num3 == 0) ? 1 : 0);
			MessageBox.Show("The book is modified successfully");
		}
		else
		{
			MessageBox.Show("Please mark the new books with accession numbers from " + Conversions.ToString(num2) + " to " + Conversions.ToString(num3) + ".", "Book Added Successfully");
		}
		m2A.Forms.y3X().q3AS();
	}

	internal static bool Mk0t(int Tk05)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(Tk05 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				Tk05 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				Tk05 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				Tk05 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void Cn0t(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		string fullPath = Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\defaultBook.jpg");
		if ((int)((CommonDialog)Ap5i()).ShowDialog() == 2)
		{
			g1X0().set_ImageLocation(fullPath);
		}
		else
		{
			g1X0().set_ImageLocation(((FileDialog)Ap5i()).get_FileName().ToString());
		}
	}

	public bool Lo79()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(Conversions.ToString(S));
		string text = "select * from Books where ISBN = '" + h + "'";
		val.Open();
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		((ButtonBase)q5R3()).set_Text("Add");
		while (val3.Read())
		{
			string imageLocation = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), val3.get_Item("BookImage")));
			try
			{
				Ns9r().set_Text(Conversions.ToString(val3.get_Item("Title")));
				i7AJ().set_Text(Conversions.ToString(val3.get_Item("Total")));
				o4YD().set_Text(Conversions.ToString(val3.get_Item("Remaining")));
				Ta4b().set_Text(Conversions.ToString(val3.get_Item("Location")));
				o3X4().set_Text(Conversions.ToString(val3.get_Item("Publisher")));
				r2D3().set_Text(Conversions.ToString(val3.get_Item("Author")));
				o3L4().set_Text(Conversions.ToString(val3.get_Item("Field")));
				Yq1m().set_Value(Conversions.ToDate(val3.get_Item("PublishYear")));
				c7L3().set_Text(Conversions.ToString(val3.get_Item("Price")));
				g1X0().set_ImageLocation(imageLocation);
				((ButtonBase)q5R3()).set_Text("Modify");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		val.Close();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				NewLateBinding.LateSet(objectValue, (Type)null, "visible", new object[1] { true }, (string[])null, (Type[])null);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)Fd2x()).set_Enabled(false);
		return true;
	}

	internal static bool z3JZ(string a5XR)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(a5XR);
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

	internal bool j5L0()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Invalid comparison between Unknown and I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Ta4b().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please enter shelf location of the book");
			return false;
		}
		if (Operators.CompareString(Ns9r().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please Enter Title of the Book");
			return false;
		}
		if (Operators.CompareString(r2D3().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please Enter Author of the Book");
			return false;
		}
		if (Operators.CompareString(o3X4().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please Enter Publisher of the Book");
			return false;
		}
		if (Operators.CompareString(o3L4().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please Enter Field of the Book");
			return false;
		}
		if (Operators.CompareString(c7L3().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Please Enter Price of the Book");
			return false;
		}
		string text = r2D3().get_Text();
		int num = 0;
		checked
		{
			while (true)
			{
				if (num < text.Length)
				{
					char c = text[num];
					if (!char.IsLower(c) & !char.IsUpper(c) & (Operators.CompareString(Conversions.ToString(c), " ", false) != 0) & (Operators.CompareString(Conversions.ToString(c), ".", false) != 0) & (Operators.CompareString(Conversions.ToString(c), ",", false) != 0))
					{
						break;
					}
					num++;
					continue;
				}
				bool flag = true;
				string text2 = Ns9r().get_Text();
				foreach (char c2 in text2)
				{
					if (Operators.CompareString(Conversions.ToString(c2), " ", false) != 0)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					MessageBox.Show("Please enter valid title", "Invalid Name");
					return false;
				}
				flag = true;
				string text3 = r2D3().get_Text();
				foreach (char c3 in text3)
				{
					if (Operators.CompareString(Conversions.ToString(c3), " ", false) != 0)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					MessageBox.Show("Please enter valid author", "Invalid Name");
					return false;
				}
				flag = true;
				string text4 = o3X4().get_Text();
				foreach (char c4 in text4)
				{
					if (Operators.CompareString(Conversions.ToString(c4), " ", false) != 0)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					MessageBox.Show("Please enter valid publisher", "Invalid Name");
					return false;
				}
				string text5 = Ta4b().get_Text();
				int num2 = 0;
				while (true)
				{
					if (num2 < text5.Length)
					{
						char c5 = text5[num2];
						if ((Operators.CompareString(Conversions.ToString(c5), ".", false) != 0) & !char.IsNumber(c5))
						{
							break;
						}
						num2++;
						continue;
					}
					int num3 = 0;
					int num4 = c7L3().get_Text().Length - 1;
					int num5 = 0;
					while (true)
					{
						if (num5 <= num4)
						{
							if (Operators.CompareString(Conversions.ToString(c7L3().get_Text()[num5]), ".", false) == 0)
							{
								num3++;
							}
							else if ((Operators.CompareString(Conversions.ToString(c7L3().get_Text()[num5]), "0", false) < 0) | (Operators.CompareString(Conversions.ToString(c7L3().get_Text()[num5]), "9", false) > 0))
							{
								break;
							}
							num5++;
							continue;
						}
						if ((num3 > 1) | (c7L3().get_Text().Length - num3 < 1) | (Operators.CompareString(Conversions.ToString(c7L3().get_Text()[0]), ".", false) == 0) | (Operators.CompareString(Conversions.ToString(c7L3().get_Text()[c7L3().get_Text().Length - 1]), ".", false) == 0))
						{
							return false;
						}
						if (decimal.Compare(Ag5y().get_Value(), 0m) == 0)
						{
							DialogResult val = MessageBox.Show("Are you sure you want to add no copies of this book?", "No copies added", (MessageBoxButtons)4);
							if (unchecked((int)val) == 6)
							{
								return true;
							}
							return false;
						}
						return true;
					}
					MessageBox.Show("Please Enter a valid Price for the book", "Invalid Price");
					return false;
				}
				MessageBox.Show("Enter valid shelf location", "Invalid location");
				return false;
			}
			MessageBox.Show("Author name should contain valid characters.", "Invalid author name");
			return false;
		}
	}

	private void Et9d(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		IEnumerable<TextBox> enumerable = ((IEnumerable)((Control)this).get_Controls()).OfType<TextBox>();
		string fullPath = Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\defaultBook.jpg");
		g1X0().set_ImageLocation(fullPath);
		foreach (TextBox item in enumerable)
		{
			TextBox val = item;
			((Control)val).add_KeyDown(new KeyEventHandler(Cy27));
		}
	}

	public void Cy27(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			SendKeys.Send("{Tab}");
		}
	}
}
