using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bp6;
using Ey8t;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nj0;
using s8C;

namespace Qo0e;

[DesignerGenerated]
public class z0Z6 : Form
{
	private Label _Label1;

	private Label _Label9;

	private Label _Label8;

	private Label _Label7;

	private TextBox _txtdchi;

	private Label _Label6;

	private Label _Label5;

	private TextBox _txtten;

	private TextBox _txtsp;

	private DataGridView _DataGridView2;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem _KhoaToolStripMenuItem;

	private Button _Button1;

	private Button _Button5;

	private Button _Button6;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolTip _ToolTip1;

	private int vt;

	internal IContainer N;

	internal ComboBox I;

	internal DataGridView d;

	internal GroupBox U;

	internal GroupBox p;

	internal Label o;

	internal ComboBox E;

	internal ComboBox y;

	internal ComboBox f;

	internal TextBox t;

	internal Label h;

	internal Label M;

	internal ComboBox x;

	internal Label g;

	internal MaskedTextBox a;

	internal MenuStrip c;

	internal ToolStripMenuItem k;

	internal ToolStripMenuItem R;

	internal ToolStripMenuItem B;

	internal ToolStripMenuItem v;

	internal ToolStripMenuItem L;

	internal DataTable S;

	public z0Z6()
	{
		((Form)this).add_Load((EventHandler)Rd3p);
		DataTable dataTable = (S = new DataTable());
		t8G0();
	}

	protected override void Je45(bool Yp7z)
	{
		if (Yp7z && N != null)
		{
			N.Dispose();
		}
		((Form)this).Dispose(Yp7z);
	}

	private void t8G0()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected O, but got Unknown
		//IL_0b64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected O, but got Unknown
		//IL_0be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected O, but got Unknown
		//IL_0ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected O, but got Unknown
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Expected O, but got Unknown
		//IL_0def: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df9: Expected O, but got Unknown
		//IL_0e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e77: Expected O, but got Unknown
		//IL_0f30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3a: Expected O, but got Unknown
		//IL_0ff0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffa: Expected O, but got Unknown
		//IL_105f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1069: Expected O, but got Unknown
		IContainer container = (N = new Container());
		Ar31(new ComboBox());
		Dq6t(new Label());
		Ng76(new DataGridView());
		y5RW(new GroupBox());
		Aj2x(new GroupBox());
		z5H7(new Button());
		Sy09(new Button());
		q3B0(new Button());
		Et58(new DataGridView());
		a8SX(new ComboBox());
		Nz03(new Label());
		p7A2(new MaskedTextBox());
		i0W6(new ComboBox());
		s6SY(new ComboBox());
		Ry06(new ComboBox());
		Bk83(new Label());
		Yr6f(new Label());
		n0P1(new TextBox());
		n9XJ(new Label());
		o8SL(new TextBox());
		So7r(new Label());
		j2PA(new Label());
		g4GF(new Label());
		Bg9p(new TextBox());
		Wd9c(new Label());
		Zo97(new TextBox());
		i2EL(new Label());
		Ta7o(new MenuStrip());
		Db28(new ToolStripMenuItem());
		Dd4o(new ToolStripMenuItem());
		f9SZ(new ToolStripMenuItem());
		Bx96(new ToolStripMenuItem());
		Zk5x(new ToolStripMenuItem());
		Zt1b(new ToolStripMenuItem());
		Lm7p(new ToolStripMenuItem());
		g7B3(new ToolStripMenuItem());
		c2CY(new ToolStripMenuItem());
		Md70(new ToolTip(N));
		((ISupportInitialize)Qy48()).BeginInit();
		((Control)Bp7s()).SuspendLayout();
		((Control)Yq0k()).SuspendLayout();
		((ISupportInitialize)g6E9()).BeginInit();
		((Control)p7C3()).SuspendLayout();
		((Control)this).SuspendLayout();
		r1YP().set_DropDownStyle((ComboBoxStyle)2);
		((Control)r1YP()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)r1YP()).set_FormattingEnabled(true);
		((Control)r1YP()).set_Location(new Point(97, 26));
		((Control)r1YP()).set_Name("cbomkt");
		((Control)r1YP()).set_Size(new Size(99, 28));
		((Control)r1YP()).set_TabIndex(75);
		w4XF().set_AutoSize(true);
		((Control)w4XF()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)w4XF()).set_Location(new Point(10, 29));
		((Control)w4XF()).set_Name("Label1");
		((Control)w4XF()).set_Size(new Size(81, 20));
		((Control)w4XF()).set_TabIndex(74);
		w4XF().set_Text("Mã ký túc");
		Qy48().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Qy48()).set_Location(new Point(10, 67));
		((Control)Qy48()).set_Name("DataGridView1");
		((Control)Qy48()).set_Size(new Size(185, 462));
		((Control)Qy48()).set_TabIndex(76);
		((Control)Bp7s()).get_Controls().Add((Control)(object)Qy48());
		((Control)Bp7s()).get_Controls().Add((Control)(object)w4XF());
		((Control)Bp7s()).get_Controls().Add((Control)(object)r1YP());
		((Control)Bp7s()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Bp7s()).set_Location(new Point(12, 48));
		((Control)Bp7s()).set_Name("GroupBox1");
		((Control)Bp7s()).set_Size(new Size(204, 537));
		((Control)Bp7s()).set_TabIndex(77);
		Bp7s().set_TabStop(false);
		Bp7s().set_Text("Chọn phòng");
		((Control)Yq0k()).get_Controls().Add((Control)(object)Ad39());
		((Control)Yq0k()).get_Controls().Add((Control)(object)i5YB());
		((Control)Yq0k()).get_Controls().Add((Control)(object)m5PN());
		((Control)Yq0k()).get_Controls().Add((Control)(object)g6E9());
		((Control)Yq0k()).get_Controls().Add((Control)(object)t0K3());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Hq08());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Bg1p());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Zz6k());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Yk8p());
		((Control)Yq0k()).get_Controls().Add((Control)(object)n4D2());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Re81());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Fj51());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Mk58());
		((Control)Yq0k()).get_Controls().Add((Control)(object)n7F5());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Fe3q());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Pg5z());
		((Control)Yq0k()).get_Controls().Add((Control)(object)n8B5());
		((Control)Yq0k()).get_Controls().Add((Control)(object)x6K0());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Wd5b());
		((Control)Yq0k()).get_Controls().Add((Control)(object)Jo1r());
		((Control)Yq0k()).get_Controls().Add((Control)(object)q1LR());
		((Control)Yq0k()).get_Controls().Add((Control)(object)p5DB());
		((Control)Yq0k()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Yq0k()).set_Location(new Point(222, 48));
		((Control)Yq0k()).set_Name("GroupBox2");
		((Control)Yq0k()).set_Size(new Size(745, 537));
		((Control)Yq0k()).set_TabIndex(78);
		Yq0k().set_TabStop(false);
		Yq0k().set_Text("Nhập hồ sơ");
		((Control)Ad39()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Ad39()).set_Location(new Point(476, 211));
		((Control)Ad39()).set_Name("Button1");
		((Control)Ad39()).set_Size(new Size(127, 33));
		((Control)Ad39()).set_TabIndex(100);
		((ButtonBase)Ad39()).set_Text("Thoát");
		((ButtonBase)Ad39()).set_UseVisualStyleBackColor(true);
		((Control)i5YB()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)i5YB()).set_Location(new Point(314, 211));
		((Control)i5YB()).set_Name("Button5");
		((Control)i5YB()).set_Size(new Size(127, 33));
		((Control)i5YB()).set_TabIndex(99);
		((ButtonBase)i5YB()).set_Text("Xóa");
		((ButtonBase)i5YB()).set_UseVisualStyleBackColor(true);
		((Control)m5PN()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)m5PN()).set_Location(new Point(155, 211));
		((Control)m5PN()).set_Name("Button6");
		((Control)m5PN()).set_Size(new Size(127, 33));
		((Control)m5PN()).set_TabIndex(98);
		((ButtonBase)m5PN()).set_Text("Cập nhật");
		((ButtonBase)m5PN()).set_UseVisualStyleBackColor(true);
		g6E9().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)g6E9()).set_Location(new Point(6, 263));
		((Control)g6E9()).set_Name("DataGridView2");
		((Control)g6E9()).set_Size(new Size(718, 266));
		((Control)g6E9()).set_TabIndex(97);
		t0K3().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)t0K3()).set_FormattingEnabled(true);
		t0K3().get_Items().AddRange(new object[2] { "Nam", "Nữ" });
		((Control)t0K3()).set_Location(new Point(98, 156));
		((Control)t0K3()).set_Name("cbogt");
		((Control)t0K3()).set_Size(new Size(108, 28));
		((Control)t0K3()).set_TabIndex(96);
		Hq08().set_AutoSize(true);
		((Control)Hq08()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Hq08()).set_Location(new Point(10, 159));
		((Control)Hq08()).set_Name("Label10");
		((Control)Hq08()).set_Size(new Size(71, 20));
		((Control)Hq08()).set_TabIndex(95);
		Hq08().set_Text("Giới tính");
		((Control)Bg1p()).set_Location(new Point(98, 90));
		((Control)Bg1p()).set_Name("mtb1");
		((Control)Bg1p()).set_Size(new Size(108, 26));
		((Control)Bg1p()).set_TabIndex(94);
		Zz6k().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)Zz6k()).set_FormattingEnabled(true);
		Zz6k().get_Items().AddRange(new object[2] { "Kinh", "Dân tộc" });
		((Control)Zz6k()).set_Location(new Point(98, 122));
		((Control)Zz6k()).set_Name("cbodt");
		((Control)Zz6k()).set_Size(new Size(108, 28));
		((Control)Zz6k()).set_TabIndex(93);
		Yk8p().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)Yk8p()).set_FormattingEnabled(true);
		Yk8p().get_Items().AddRange(new object[5] { "CNTT", "Kinh tế", "Ngân hàng", "Kế toán", "Khoa khác" });
		((Control)Yk8p()).set_Location(new Point(492, 122));
		((Control)Yk8p()).set_Name("cbokh");
		((Control)Yk8p()).set_Size(new Size(143, 28));
		((Control)Yk8p()).set_TabIndex(92);
		n4D2().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)n4D2()).set_FormattingEnabled(true);
		n4D2().get_Items().AddRange(new object[4] { "Không", "Đạo Hồi", "Đạo Phật", "Đạo Thiên Chúa" });
		((Control)n4D2()).set_Location(new Point(492, 26));
		((Control)n4D2()).set_Name("cbotg");
		((Control)n4D2()).set_Size(new Size(143, 28));
		((Control)n4D2()).set_TabIndex(91);
		Re81().set_AutoSize(true);
		((Control)Re81()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Re81()).set_Location(new Point(404, 125));
		((Control)Re81()).set_Name("Label9");
		((Control)Re81()).set_Size(new Size(47, 20));
		((Control)Re81()).set_TabIndex(88);
		Re81().set_Text("Khoa");
		Fj51().set_AutoSize(true);
		((Control)Fj51()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Fj51()).set_Location(new Point(10, 125));
		((Control)Fj51()).set_Name("Label8");
		((Control)Fj51()).set_Size(new Size(68, 20));
		((Control)Fj51()).set_TabIndex(86);
		Fj51().set_Text("Dân tộc");
		((Control)Mk58()).set_Location(new Point(492, 90));
		((Control)Mk58()).set_Name("txtlop");
		((Control)Mk58()).set_Size(new Size(108, 26));
		((Control)Mk58()).set_TabIndex(85);
		n7F5().set_AutoSize(true);
		((Control)n7F5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)n7F5()).set_Location(new Point(404, 93));
		((Control)n7F5()).set_Name("Label7");
		((Control)n7F5()).set_Size(new Size(37, 20));
		((Control)n7F5()).set_TabIndex(84);
		n7F5().set_Text("Lớp");
		((Control)Fe3q()).set_Location(new Point(492, 58));
		((Control)Fe3q()).set_Name("txtdchi");
		((Control)Fe3q()).set_Size(new Size(232, 26));
		((Control)Fe3q()).set_TabIndex(83);
		Pg5z().set_AutoSize(true);
		((Control)Pg5z()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Pg5z()).set_Location(new Point(345, 61));
		((Control)Pg5z()).set_Name("Label6");
		((Control)Pg5z()).set_Size(new Size(141, 20));
		((Control)Pg5z()).set_TabIndex(82);
		Pg5z().set_Text("Địa chỉ thường trú");
		n8B5().set_AutoSize(true);
		((Control)n8B5()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)n8B5()).set_Location(new Point(413, 29));
		((Control)n8B5()).set_Name("Label5");
		((Control)n8B5()).set_Size(new Size(73, 20));
		((Control)n8B5()).set_TabIndex(80);
		n8B5().set_Text("Tôn giáo");
		x6K0().set_AutoSize(true);
		((Control)x6K0()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)x6K0()).set_Location(new Point(10, 93));
		((Control)x6K0()).set_Name("Label4");
		((Control)x6K0()).set_Size(new Size(83, 20));
		((Control)x6K0()).set_TabIndex(78);
		x6K0().set_Text("Ngày sinh");
		((Control)Wd5b()).set_Location(new Point(98, 58));
		((Control)Wd5b()).set_Name("txtten");
		((Control)Wd5b()).set_Size(new Size(226, 26));
		((Control)Wd5b()).set_TabIndex(77);
		Jo1r().set_AutoSize(true);
		((Control)Jo1r()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Jo1r()).set_Location(new Point(10, 61));
		((Control)Jo1r()).set_Name("Label3");
		((Control)Jo1r()).set_Size(new Size(37, 20));
		((Control)Jo1r()).set_TabIndex(76);
		Jo1r().set_Text("Tên");
		((Control)q1LR()).set_Location(new Point(98, 26));
		((Control)q1LR()).set_Name("txtsp");
		((Control)q1LR()).set_Size(new Size(108, 26));
		((Control)q1LR()).set_TabIndex(75);
		p5DB().set_AutoSize(true);
		((Control)p5DB()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)p5DB()).set_Location(new Point(10, 29));
		((Control)p5DB()).set_Name("Label2");
		((Control)p5DB()).set_Size(new Size(74, 20));
		((Control)p5DB()).set_TabIndex(74);
		p5DB().set_Text("Số phiếu");
		((ToolStrip)p7C3()).set_Font(new Font("Segoe UI", 12f));
		((ToolStrip)p7C3()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)Yq58(),
			(ToolStripItem)e9KN(),
			(ToolStripItem)Qs1i(),
			(ToolStripItem)e8A4()
		});
		((Control)p7C3()).set_Location(new Point(0, 0));
		((Control)p7C3()).set_Name("MenuStrip1");
		((Control)p7C3()).set_Size(new Size(979, 29));
		((Control)p7C3()).set_TabIndex(79);
		((Control)p7C3()).set_Text("MenuStrip1");
		((ToolStripDropDownItem)Yq58()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)Qc8r(),
			(ToolStripItem)Cj47(),
			(ToolStripItem)Ms06()
		});
		((ToolStripItem)Yq58()).set_Name("QuảnLýChungToolStripMenuItem");
		((ToolStripItem)Yq58()).set_Size(new Size(123, 25));
		((ToolStripItem)Yq58()).set_Text("Quản lý chung");
		((ToolStripItem)Qc8r()).set_Name("PhòngToolStripMenuItem");
		((ToolStripItem)Qc8r()).set_Size(new Size(125, 26));
		((ToolStripItem)Qc8r()).set_Text("Phòng");
		((ToolStripItem)Cj47()).set_Name("KhoaToolStripMenuItem");
		((ToolStripItem)Cj47()).set_Size(new Size(125, 26));
		((ToolStripItem)Cj47()).set_Text("Khoa");
		((ToolStripItem)Ms06()).set_Name("KýTúcToolStripMenuItem");
		((ToolStripItem)Ms06()).set_Size(new Size(125, 26));
		((ToolStripItem)Ms06()).set_Text("Ký túc");
		((ToolStripItem)e9KN()).set_Name("TìmKiếmToolStripMenuItem");
		((ToolStripItem)e9KN()).set_Size(new Size(86, 25));
		((ToolStripItem)e9KN()).set_Text("Tìm kiếm");
		((ToolStripItem)Qs1i()).set_Name("CậpNhậtDữLiệuToolStripMenuItem");
		((ToolStripItem)Qs1i()).set_Size(new Size(135, 25));
		((ToolStripItem)Qs1i()).set_Text("Cập nhật dữ liệu");
		((ToolStripDropDownItem)e8A4()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)b1RN(),
			(ToolStripItem)z6G4()
		});
		((ToolStripItem)e8A4()).set_Name("HệThốngToolStripMenuItem");
		((ToolStripItem)e8A4()).set_Size(new Size(86, 25));
		((ToolStripItem)e8A4()).set_Text("Hệ thống");
		((ToolStripItem)b1RN()).set_Name("GiớiThiệuToolStripMenuItem");
		((ToolStripItem)b1RN()).set_Size(new Size(148, 26));
		((ToolStripItem)b1RN()).set_Text("Giới thiệu");
		((ToolStripItem)z6G4()).set_Name("ThoátToolStripMenuItem");
		((ToolStripItem)z6G4()).set_Size(new Size(148, 26));
		((ToolStripItem)z6G4()).set_Text("Thoát");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(979, 599));
		((Control)this).get_Controls().Add((Control)(object)Yq0k());
		((Control)this).get_Controls().Add((Control)(object)Bp7s());
		((Control)this).get_Controls().Add((Control)(object)p7C3());
		((Form)this).set_MainMenuStrip(p7C3());
		((Control)this).set_Name("Form7");
		((Form)this).set_Text("Nhập hồ sơ sinh viên");
		((ISupportInitialize)Qy48()).EndInit();
		((Control)Bp7s()).ResumeLayout(false);
		((Control)Bp7s()).PerformLayout();
		((Control)Yq0k()).ResumeLayout(false);
		((Control)Yq0k()).PerformLayout();
		((ISupportInitialize)g6E9()).EndInit();
		((Control)p7C3()).ResumeLayout(false);
		((Control)p7C3()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ComboBox r1YP()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar31(ComboBox n0LB)
	{
		EventHandler eventHandler = f1SN;
		ComboBox i = I;
		if (i != null)
		{
			i.remove_SelectedIndexChanged(eventHandler);
		}
		ComboBox val = (I = n0LB);
		i = I;
		if (i != null)
		{
			i.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label w4XF()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dq6t(Label t9MJ)
	{
		_Label1 = t9MJ;
	}

	[SpecialName]
	internal virtual DataGridView Qy48()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng76(DataGridView m9WH)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(Pw1r);
		DataGridView val2 = d;
		if (val2 != null)
		{
			val2.remove_CellClick(val);
		}
		DataGridView val3 = (d = m9WH);
		val2 = d;
		if (val2 != null)
		{
			val2.add_CellClick(val);
		}
	}

	[SpecialName]
	internal virtual GroupBox Bp7s()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5RW(GroupBox s7BN)
	{
		GroupBox val = (U = s7BN);
	}

	[SpecialName]
	internal virtual GroupBox Yq0k()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj2x(GroupBox s7W4)
	{
		GroupBox val = (p = s7W4);
	}

	[SpecialName]
	internal virtual Label p5DB()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2EL(Label Yb6i)
	{
		Label val = (o = Yb6i);
	}

	[SpecialName]
	internal virtual ComboBox Zz6k()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0W6(ComboBox m3MY)
	{
		ComboBox val = (E = m3MY);
	}

	[SpecialName]
	internal virtual ComboBox Yk8p()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6SY(ComboBox f4Y8)
	{
		ComboBox val = (y = f4Y8);
	}

	[SpecialName]
	internal virtual ComboBox n4D2()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ry06(ComboBox Yy60)
	{
		ComboBox val = (f = Yy60);
	}

	[SpecialName]
	internal virtual Label Re81()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk83(Label a2Y8)
	{
		_Label9 = a2Y8;
	}

	[SpecialName]
	internal virtual Label Fj51()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yr6f(Label At93)
	{
		_Label8 = At93;
	}

	[SpecialName]
	internal virtual TextBox Mk58()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0P1(TextBox Sz5c)
	{
		TextBox val = (t = Sz5c);
	}

	[SpecialName]
	internal virtual Label n7F5()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9XJ(Label w4GM)
	{
		_Label7 = w4GM;
	}

	[SpecialName]
	internal virtual TextBox Fe3q()
	{
		return _txtdchi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8SL(TextBox Yc7y)
	{
		_txtdchi = Yc7y;
	}

	[SpecialName]
	internal virtual Label Pg5z()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So7r(Label Cb3g)
	{
		_Label6 = Cb3g;
	}

	[SpecialName]
	internal virtual Label n8B5()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2PA(Label r0TB)
	{
		_Label5 = r0TB;
	}

	[SpecialName]
	internal virtual Label x6K0()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4GF(Label d0FJ)
	{
		Label val = (h = d0FJ);
	}

	[SpecialName]
	internal virtual TextBox Wd5b()
	{
		return _txtten;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bg9p(TextBox Ry7a)
	{
		_txtten = Ry7a;
	}

	[SpecialName]
	internal virtual Label Jo1r()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wd9c(Label Rf8p)
	{
		Label val = (M = Rf8p);
	}

	[SpecialName]
	internal virtual TextBox q1LR()
	{
		return _txtsp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zo97(TextBox s3SH)
	{
		_txtsp = s3SH;
	}

	[SpecialName]
	internal virtual DataGridView g6E9()
	{
		return _DataGridView2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et58(DataGridView n1RA)
	{
		_DataGridView2 = n1RA;
	}

	[SpecialName]
	internal virtual ComboBox t0K3()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8SX(ComboBox r0J7)
	{
		ComboBox val = (x = r0J7);
	}

	[SpecialName]
	internal virtual Label Hq08()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nz03(Label o5JK)
	{
		Label val = (g = o5JK);
	}

	[SpecialName]
	internal virtual MaskedTextBox Bg1p()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7A2(MaskedTextBox Ki15)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		KeyEventHandler val = new KeyEventHandler(Lz12);
		TypeValidationEventHandler val2 = new TypeValidationEventHandler(Rw1i);
		MaskedTextBox val3 = a;
		if (val3 != null)
		{
			((Control)val3).remove_KeyDown(val);
			val3.remove_TypeValidationCompleted(val2);
		}
		MaskedTextBox val4 = (a = Ki15);
		val3 = a;
		if (val3 != null)
		{
			((Control)val3).add_KeyDown(val);
			val3.add_TypeValidationCompleted(val2);
		}
	}

	[SpecialName]
	internal virtual MenuStrip p7C3()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ta7o(MenuStrip w4R0)
	{
		MenuStrip val = (c = w4R0);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Yq58()
	{
		return toolStripMenuItem_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Db28(ToolStripMenuItem Ci67)
	{
		toolStripMenuItem_0 = Ci67;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Qc8r()
	{
		return toolStripMenuItem_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd4o(ToolStripMenuItem d7RH)
	{
		EventHandler eventHandler = k3G9;
		ToolStripMenuItem val = toolStripMenuItem_1;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_1 = d7RH;
		val = toolStripMenuItem_1;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Cj47()
	{
		return _KhoaToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9SZ(ToolStripMenuItem Cd94)
	{
		EventHandler eventHandler = Le20;
		ToolStripMenuItem khoaToolStripMenuItem = _KhoaToolStripMenuItem;
		if (khoaToolStripMenuItem != null)
		{
			((ToolStripItem)khoaToolStripMenuItem).remove_Click(eventHandler);
		}
		_KhoaToolStripMenuItem = Cd94;
		khoaToolStripMenuItem = _KhoaToolStripMenuItem;
		if (khoaToolStripMenuItem != null)
		{
			((ToolStripItem)khoaToolStripMenuItem).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Ms06()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx96(ToolStripMenuItem f1YM)
	{
		EventHandler eventHandler = i2TH;
		ToolStripMenuItem val = k;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		ToolStripMenuItem val2 = (k = f1YM);
		val = k;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem e8A4()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lm7p(ToolStripMenuItem Fs0c)
	{
		ToolStripMenuItem val = (R = Fs0c);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem b1RN()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7B3(ToolStripMenuItem o4S7)
	{
		EventHandler eventHandler = m4FT;
		ToolStripMenuItem b = B;
		if (b != null)
		{
			((ToolStripItem)b).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (B = o4S7);
		b = B;
		if (b != null)
		{
			((ToolStripItem)b).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem z6G4()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2CY(ToolStripMenuItem Zf84)
	{
		EventHandler eventHandler = x9D0;
		ToolStripMenuItem val = v;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		ToolStripMenuItem val2 = (v = Zf84);
		val = v;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ad39()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5H7(Button Wa39)
	{
		_Button1 = Wa39;
	}

	[SpecialName]
	internal virtual Button i5YB()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sy09(Button j7A9)
	{
		EventHandler eventHandler = p1M8;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = j7A9;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button m5PN()
	{
		return _Button6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3B0(Button n4EH)
	{
		EventHandler eventHandler = g0YH;
		Button button = _Button6;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button6 = n4EH;
		button = _Button6;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem e9KN()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk5x(ToolStripMenuItem m9HT)
	{
		EventHandler eventHandler = n8YQ;
		ToolStripMenuItem l = L;
		if (l != null)
		{
			((ToolStripItem)l).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (L = m9HT);
		l = L;
		if (l != null)
		{
			((ToolStripItem)l).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Qs1i()
	{
		return toolStripMenuItem_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt1b(ToolStripMenuItem Dx96)
	{
		EventHandler eventHandler = Xr7t;
		ToolStripMenuItem val = toolStripMenuItem_2;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_2 = Dx96;
		val = toolStripMenuItem_2;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolTip p8W4()
	{
		return _ToolTip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Md70(ToolTip Wm40)
	{
		_ToolTip1 = Wm40;
	}

	private void x9D0(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void m4FT(object sender, EventArgs e)
	{
		((Control)p8H.Forms.Wd9()).Show();
	}

	private void k3G9(object sender, EventArgs e)
	{
		((Control)p8H.Forms.Sf6()).Show();
	}

	private void Le20(object sender, EventArgs e)
	{
		((Control)p8H.Forms.Sm7()).Show();
	}

	private void i2TH(object sender, EventArgs e)
	{
		((Control)p8H.Forms.Bs5()).Show();
	}

	private void n8YQ(object sender, EventArgs e)
	{
		((Control)p8H.Forms.n3G()).Show();
	}

	private void Ko3w()
	{
		d0N.Wk01();
		r1YP().get_Items().Clear();
		checked
		{
			int num = Nn6.ds.Tables["kytuc"]!.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				r1YP().get_Items().Add(RuntimeHelpers.GetObjectValue(Nn6.ds.Tables["kytuc"]!.Rows[i][0]));
			}
		}
	}

	private void o1N6(string q0RA)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		S.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Nn6.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" Select maphong,loaiphong from phong where maktx='" + q0RA + "'");
		Nn6.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Nn6.da).Fill(S);
		Qy48().set_DataSource((object)S);
	}

	private void Rd3p(object sender, EventArgs e)
	{
		z6A.Sq7();
		g6E9().set_DataSource((object)Nn6.ds.Tables["hoso"]);
		Ko3w();
		Qy48().set_RowHeadersVisible(false);
		Qy48().set_AllowUserToAddRows(false);
		Qy48().set_AllowUserToDeleteRows(false);
		Qy48().set_ReadOnly(true);
		Bg1p().set_Mask("00/00/0000");
		Bg1p().set_ValidatingType(typeof(DateTime));
		p8W4().set_IsBalloon(true);
	}

	private void Lz12(object sender, KeyEventArgs e)
	{
		p8W4().Hide((IWin32Window)(object)Bg1p());
	}

	private void Rw1i(object sender, TypeValidationEventArgs e)
	{
		if (!e.get_IsValidInput())
		{
			p8W4().set_ToolTipTitle("Thời gian không phù hợp");
			p8W4().Show("Bạn phải nhập ngày tháng định dạng dd/mm/yyyy", (IWin32Window)(object)Bg1p(), 100, -60, 5000);
			((TextBoxBase)Bg1p()).Clear();
		}
	}

	private void f1SN(object sender, EventArgs e)
	{
		o1N6(r1YP().get_Text());
	}

	private void Xr7t(object sender, EventArgs e)
	{
		Ko3w();
	}

	private void g0YH(object sender, EventArgs e)
	{
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		if ((vt < 0) | (Operators.CompareString(r1YP().get_Text(), "", false) == 0) | (Operators.CompareString(q1LR().get_Text(), "", false) == 0) | (Operators.CompareString(Wd5b().get_Text(), "", false) == 0) | (Operators.CompareString(Zz6k().get_Text(), "", false) == 0) | (Operators.CompareString(t0K3().get_Text(), "", false) == 0) | (Operators.CompareString(n4D2().get_Text(), "", false) == 0) | (Operators.CompareString(Fe3q().get_Text(), "", false) == 0) | (Operators.CompareString(Mk58().get_Text(), "", false) == 0) | (Operators.CompareString(Yk8p().get_Text(), "", false) == 0))
		{
			Interaction.MsgBox((object)"Bạn phải điền đủ thông tin", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (z6A.Cx3(q1LR().get_Text()) == 0)
		{
			string text = Bg1p().get_Text();
			DateTime result = DateTime.MinValue;
			if (!DateTime.TryParse(text, out result))
			{
				Interaction.MsgBox((object)"Bạn phải nhập đủ thông tin", (MsgBoxStyle)0, (object)null);
				return;
			}
			if (Operators.CompareString(t0K3().get_Text(), "Nam", false) == 0)
			{
				z6A.Wp1(q1LR().get_Text(), Wd5b().get_Text(), Conversions.ToDate(Bg1p().get_Text()), s9W: true, Zz6k().get_Text(), n4D2().get_Text(), Fe3q().get_Text(), Mk58().get_Text(), Yk8p().get_Text(), Conversions.ToString(Qy48().get_Rows().get_Item(vt).get_Cells()
					.get_Item(0)
					.get_Value()));
				Interaction.MsgBox((object)"Đã thêm hồ sơ mới", (MsgBoxStyle)64, (object)"Chúc mừng");
			}
			else
			{
				z6A.Wp1(q1LR().get_Text(), Wd5b().get_Text(), Conversions.ToDate(Bg1p().get_Text()), s9W: false, Zz6k().get_Text(), n4D2().get_Text(), Fe3q().get_Text(), Mk58().get_Text(), Yk8p().get_Text(), Conversions.ToString(Qy48().get_Rows().get_Item(vt).get_Cells()
					.get_Item(0)
					.get_Value()));
				Interaction.MsgBox((object)"Đã thêm hồ sơ mới", (MsgBoxStyle)64, (object)"Chúc mừng");
			}
		}
		else
		{
			string text2 = Bg1p().get_Text();
			DateTime result = DateTime.MinValue;
			if (!DateTime.TryParse(text2, out result))
			{
				Interaction.MsgBox((object)"Bạn phải nhập đủ thông tin", (MsgBoxStyle)0, (object)null);
				return;
			}
			if (Operators.CompareString(t0K3().get_Text(), "Nam", false) == 0)
			{
				long num = (long)Interaction.MsgBox((object)"Hồ sơ đã tồn tại, bạn xác nhận muốn sửa?", (MsgBoxStyle)1, (object)"Thông báo");
				if (num == 1L)
				{
					z6A.c7F(q1LR().get_Text(), Wd5b().get_Text(), Conversions.ToDate(Bg1p().get_Text()), s0F: true, Zz6k().get_Text(), n4D2().get_Text(), Fe3q().get_Text(), Mk58().get_Text(), Yk8p().get_Text(), Conversions.ToString(Qy48().get_Rows().get_Item(vt).get_Cells()
						.get_Item(0)
						.get_Value()));
					Interaction.MsgBox((object)"Đã sửa hồ sơ", (MsgBoxStyle)64, (object)"Chúc mừng");
					Pr42();
				}
				else
				{
					num = 2L;
					Pr42();
				}
			}
			else
			{
				long num = (long)Interaction.MsgBox((object)"Hồ sơ đã tồn tại, bạn xác nhận muốn sửa?", (MsgBoxStyle)1, (object)"Thông báo");
				if (num == 1L)
				{
					z6A.c7F(q1LR().get_Text(), Wd5b().get_Text(), Conversions.ToDate(Bg1p().get_Text()), s0F: false, Zz6k().get_Text(), n4D2().get_Text(), Fe3q().get_Text(), Mk58().get_Text(), Yk8p().get_Text(), Conversions.ToString(Qy48().get_Rows().get_Item(vt).get_Cells()
						.get_Item(0)
						.get_Value()));
					Interaction.MsgBox((object)"Đã sửa hồ sơ", (MsgBoxStyle)64, (object)"Chúc mừng");
					Pr42();
				}
				else
				{
					num = 2L;
					Pr42();
				}
			}
		}
		Pr42();
	}

	private void Pr42()
	{
		r1YP().ResetText();
		((TextBoxBase)q1LR()).Clear();
		((TextBoxBase)Wd5b()).Clear();
		((TextBoxBase)Bg1p()).Clear();
		n4D2().ResetText();
		Zz6k().ResetText();
		Zz6k().ResetText();
		((TextBoxBase)Mk58()).Clear();
		Yk8p().ResetText();
	}

	private void Pw1r(object sender, DataGridViewCellEventArgs e)
	{
		vt = Qy48().get_CurrentCell().get_RowIndex();
	}

	private void p1M8(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (z6A.Cx3(q1LR().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Hồ sơ không tồn tại", (MsgBoxStyle)64, (object)"Lỗi");
			return;
		}
		z6A.Pd2(q1LR().get_Text());
		Interaction.MsgBox((object)"Đã xóa", (MsgBoxStyle)64, (object)"Lỗi");
		Pr42();
	}
}
