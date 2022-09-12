using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Lw3q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using b1X;
using f6HE;
using q9A4;

namespace c5Y2;

[DesignerGenerated]
public class Rq6k : Form
{
	private IContainer components;

	private ComboBox _cbomkt;

	private Label _Label1;

	private GroupBox _GroupBox1;

	private ComboBox _cbokh;

	private ComboBox _cbotg;

	private Label _Label9;

	private TextBox _txtdchi;

	private Label _Label6;

	private Label _Label4;

	private TextBox _txtten;

	private Label _Label3;

	private DataGridView _DataGridView2;

	private ComboBox _cbogt;

	private Label _Label10;

	private MenuStrip _MenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem _KhoaToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem_3;

	private Button _Button5;

	private ToolStripMenuItem toolStripMenuItem_4;

	private DataTable dtpkt;

	internal DataGridView B;

	internal GroupBox Y;

	internal Label U;

	internal ComboBox M;

	internal Label n;

	internal TextBox T;

	internal Label D;

	internal Label C;

	internal TextBox F;

	internal MaskedTextBox h;

	internal ToolStripMenuItem W;

	internal ToolStripMenuItem o;

	internal Button a;

	internal Button X;

	internal ToolStripMenuItem S;

	internal ToolTip v;

	internal int e;

	public Rq6k()
	{
		((Form)this).add_Load((EventHandler)Le4j);
		dtpkt = new DataTable();
		Xx6s();
	}

	protected override void Hw7o(bool Wm5q)
	{
		if (Wm5q && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Wm5q);
	}

	private void Xx6s()
	{
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
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected O, but got Unknown
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected O, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected O, but got Unknown
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Expected O, but got Unknown
		//IL_0ca3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cad: Expected O, but got Unknown
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected O, but got Unknown
		//IL_0ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected O, but got Unknown
		//IL_0e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e75: Expected O, but got Unknown
		//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Expected O, but got Unknown
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected O, but got Unknown
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Expected O, but got Unknown
		components = new Container();
		Ts6g(new ComboBox());
		k5A0(new Label());
		j9E0(new DataGridView());
		d2TM(new GroupBox());
		y1Z5(new GroupBox());
		e6XT(new Button());
		Qi6x(new Button());
		Yn36(new Button());
		Ad7i(new DataGridView());
		i3Z8(new ComboBox());
		Fo5a(new Label());
		a9DG(new MaskedTextBox());
		Qq6k(new ComboBox());
		a1NB(new ComboBox());
		Ge02(new ComboBox());
		j1EG(new Label());
		Sw15(new Label());
		He46(new TextBox());
		z1M3(new Label());
		Nq26(new TextBox());
		Rp7d(new Label());
		Cc14(new Label());
		Wm2b(new Label());
		Fx65(new TextBox());
		Cq8r(new Label());
		Be9z(new TextBox());
		c6PT(new Label());
		Zy34(new MenuStrip());
		Jj9k(new ToolStripMenuItem());
		By6k(new ToolStripMenuItem());
		Eb68(new ToolStripMenuItem());
		s0YN(new ToolStripMenuItem());
		e2P3(new ToolStripMenuItem());
		z8A5(new ToolStripMenuItem());
		Rf16(new ToolStripMenuItem());
		f8ZL(new ToolStripMenuItem());
		i9F1(new ToolStripMenuItem());
		f7NC(new ToolTip(components));
		((ISupportInitialize)At84()).BeginInit();
		((Control)Mx0t()).SuspendLayout();
		((Control)m2TE()).SuspendLayout();
		((ISupportInitialize)y8D5()).BeginInit();
		((Control)Ss5k()).SuspendLayout();
		((Control)this).SuspendLayout();
		Mz61().set_DropDownStyle((ComboBoxStyle)2);
		((Control)Mz61()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((ListControl)Mz61()).set_FormattingEnabled(true);
		((Control)Mz61()).set_Location(new Point(97, 26));
		((Control)Mz61()).set_Name("cbomkt");
		((Control)Mz61()).set_Size(new Size(99, 28));
		((Control)Mz61()).set_TabIndex(75);
		k9CF().set_AutoSize(true);
		((Control)k9CF()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)k9CF()).set_Location(new Point(10, 29));
		((Control)k9CF()).set_Name("Label1");
		((Control)k9CF()).set_Size(new Size(81, 20));
		((Control)k9CF()).set_TabIndex(74);
		k9CF().set_Text("Mã ký túc");
		At84().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)At84()).set_Location(new Point(10, 67));
		((Control)At84()).set_Name("DataGridView1");
		((Control)At84()).set_Size(new Size(185, 462));
		((Control)At84()).set_TabIndex(76);
		((Control)Mx0t()).get_Controls().Add((Control)(object)At84());
		((Control)Mx0t()).get_Controls().Add((Control)(object)k9CF());
		((Control)Mx0t()).get_Controls().Add((Control)(object)Mz61());
		((Control)Mx0t()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Mx0t()).set_Location(new Point(12, 48));
		((Control)Mx0t()).set_Name("GroupBox1");
		((Control)Mx0t()).set_Size(new Size(204, 537));
		((Control)Mx0t()).set_TabIndex(77);
		Mx0t().set_TabStop(false);
		Mx0t().set_Text("Chọn phòng");
		((Control)m2TE()).get_Controls().Add((Control)(object)g1R3());
		((Control)m2TE()).get_Controls().Add((Control)(object)Li59());
		((Control)m2TE()).get_Controls().Add((Control)(object)Dz1d());
		((Control)m2TE()).get_Controls().Add((Control)(object)y8D5());
		((Control)m2TE()).get_Controls().Add((Control)(object)Tq94());
		((Control)m2TE()).get_Controls().Add((Control)(object)Dw28());
		((Control)m2TE()).get_Controls().Add((Control)(object)Ac56());
		((Control)m2TE()).get_Controls().Add((Control)(object)s4S7());
		((Control)m2TE()).get_Controls().Add((Control)(object)My2o());
		((Control)m2TE()).get_Controls().Add((Control)(object)k2TW());
		((Control)m2TE()).get_Controls().Add((Control)(object)Fr1p());
		((Control)m2TE()).get_Controls().Add((Control)(object)s3H1());
		((Control)m2TE()).get_Controls().Add((Control)(object)w1AY());
		((Control)m2TE()).get_Controls().Add((Control)(object)m8GE());
		((Control)m2TE()).get_Controls().Add((Control)(object)Ha78());
		((Control)m2TE()).get_Controls().Add((Control)(object)g7SE());
		((Control)m2TE()).get_Controls().Add((Control)(object)Cg8m());
		((Control)m2TE()).get_Controls().Add((Control)(object)e5F1());
		((Control)m2TE()).get_Controls().Add((Control)(object)q3PY());
		((Control)m2TE()).get_Controls().Add((Control)(object)Px19());
		((Control)m2TE()).get_Controls().Add((Control)(object)Bd6q());
		((Control)m2TE()).get_Controls().Add((Control)(object)Si85());
		((Control)m2TE()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)m2TE()).set_Location(new Point(222, 48));
		((Control)m2TE()).set_Name("GroupBox2");
		((Control)m2TE()).set_Size(new Size(745, 537));
		((Control)m2TE()).set_TabIndex(78);
		m2TE().set_TabStop(false);
		m2TE().set_Text("Nhập hồ sơ");
		((Control)g1R3()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)g1R3()).set_Location(new Point(476, 211));
		((Control)g1R3()).set_Name("Button1");
		((Control)g1R3()).set_Size(new Size(127, 33));
		((Control)g1R3()).set_TabIndex(100);
		((ButtonBase)g1R3()).set_Text("Thoát");
		((ButtonBase)g1R3()).set_UseVisualStyleBackColor(true);
		((Control)Li59()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Li59()).set_Location(new Point(314, 211));
		((Control)Li59()).set_Name("Button5");
		((Control)Li59()).set_Size(new Size(127, 33));
		((Control)Li59()).set_TabIndex(99);
		((ButtonBase)Li59()).set_Text("Xóa");
		((ButtonBase)Li59()).set_UseVisualStyleBackColor(true);
		((Control)Dz1d()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Dz1d()).set_Location(new Point(155, 211));
		((Control)Dz1d()).set_Name("Button6");
		((Control)Dz1d()).set_Size(new Size(127, 33));
		((Control)Dz1d()).set_TabIndex(98);
		((ButtonBase)Dz1d()).set_Text("Cập nhật");
		((ButtonBase)Dz1d()).set_UseVisualStyleBackColor(true);
		y8D5().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)y8D5()).set_Location(new Point(6, 263));
		((Control)y8D5()).set_Name("DataGridView2");
		((Control)y8D5()).set_Size(new Size(718, 266));
		((Control)y8D5()).set_TabIndex(97);
		Tq94().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)Tq94()).set_FormattingEnabled(true);
		Tq94().get_Items().AddRange(new object[2] { "Nam", "Nữ" });
		((Control)Tq94()).set_Location(new Point(98, 156));
		((Control)Tq94()).set_Name("cbogt");
		((Control)Tq94()).set_Size(new Size(108, 28));
		((Control)Tq94()).set_TabIndex(96);
		Dw28().set_AutoSize(true);
		((Control)Dw28()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Dw28()).set_Location(new Point(10, 159));
		((Control)Dw28()).set_Name("Label10");
		((Control)Dw28()).set_Size(new Size(71, 20));
		((Control)Dw28()).set_TabIndex(95);
		Dw28().set_Text("Giới tính");
		((Control)Ac56()).set_Location(new Point(98, 90));
		((Control)Ac56()).set_Name("mtb1");
		((Control)Ac56()).set_Size(new Size(108, 26));
		((Control)Ac56()).set_TabIndex(94);
		s4S7().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)s4S7()).set_FormattingEnabled(true);
		s4S7().get_Items().AddRange(new object[2] { "Kinh", "Dân tộc" });
		((Control)s4S7()).set_Location(new Point(98, 122));
		((Control)s4S7()).set_Name("cbodt");
		((Control)s4S7()).set_Size(new Size(108, 28));
		((Control)s4S7()).set_TabIndex(93);
		My2o().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)My2o()).set_FormattingEnabled(true);
		My2o().get_Items().AddRange(new object[5] { "CNTT", "Kinh tế", "Ngân hàng", "Kế toán", "Khoa khác" });
		((Control)My2o()).set_Location(new Point(492, 122));
		((Control)My2o()).set_Name("cbokh");
		((Control)My2o()).set_Size(new Size(143, 28));
		((Control)My2o()).set_TabIndex(92);
		k2TW().set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)k2TW()).set_FormattingEnabled(true);
		k2TW().get_Items().AddRange(new object[4] { "Không", "Đạo Hồi", "Đạo Phật", "Đạo Thiên Chúa" });
		((Control)k2TW()).set_Location(new Point(492, 26));
		((Control)k2TW()).set_Name("cbotg");
		((Control)k2TW()).set_Size(new Size(143, 28));
		((Control)k2TW()).set_TabIndex(91);
		Fr1p().set_AutoSize(true);
		((Control)Fr1p()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Fr1p()).set_Location(new Point(404, 125));
		((Control)Fr1p()).set_Name("Label9");
		((Control)Fr1p()).set_Size(new Size(47, 20));
		((Control)Fr1p()).set_TabIndex(88);
		Fr1p().set_Text("Khoa");
		s3H1().set_AutoSize(true);
		((Control)s3H1()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)s3H1()).set_Location(new Point(10, 125));
		((Control)s3H1()).set_Name("Label8");
		((Control)s3H1()).set_Size(new Size(68, 20));
		((Control)s3H1()).set_TabIndex(86);
		s3H1().set_Text("Dân tộc");
		((Control)w1AY()).set_Location(new Point(492, 90));
		((Control)w1AY()).set_Name("txtlop");
		((Control)w1AY()).set_Size(new Size(108, 26));
		((Control)w1AY()).set_TabIndex(85);
		m8GE().set_AutoSize(true);
		((Control)m8GE()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)m8GE()).set_Location(new Point(404, 93));
		((Control)m8GE()).set_Name("Label7");
		((Control)m8GE()).set_Size(new Size(37, 20));
		((Control)m8GE()).set_TabIndex(84);
		m8GE().set_Text("Lớp");
		((Control)Ha78()).set_Location(new Point(492, 58));
		((Control)Ha78()).set_Name("txtdchi");
		((Control)Ha78()).set_Size(new Size(232, 26));
		((Control)Ha78()).set_TabIndex(83);
		g7SE().set_AutoSize(true);
		((Control)g7SE()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)g7SE()).set_Location(new Point(345, 61));
		((Control)g7SE()).set_Name("Label6");
		((Control)g7SE()).set_Size(new Size(141, 20));
		((Control)g7SE()).set_TabIndex(82);
		g7SE().set_Text("Địa chỉ thường trú");
		Cg8m().set_AutoSize(true);
		((Control)Cg8m()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Cg8m()).set_Location(new Point(413, 29));
		((Control)Cg8m()).set_Name("Label5");
		((Control)Cg8m()).set_Size(new Size(73, 20));
		((Control)Cg8m()).set_TabIndex(80);
		Cg8m().set_Text("Tôn giáo");
		e5F1().set_AutoSize(true);
		((Control)e5F1()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)e5F1()).set_Location(new Point(10, 93));
		((Control)e5F1()).set_Name("Label4");
		((Control)e5F1()).set_Size(new Size(83, 20));
		((Control)e5F1()).set_TabIndex(78);
		e5F1().set_Text("Ngày sinh");
		((Control)q3PY()).set_Location(new Point(98, 58));
		((Control)q3PY()).set_Name("txtten");
		((Control)q3PY()).set_Size(new Size(226, 26));
		((Control)q3PY()).set_TabIndex(77);
		Px19().set_AutoSize(true);
		((Control)Px19()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Px19()).set_Location(new Point(10, 61));
		((Control)Px19()).set_Name("Label3");
		((Control)Px19()).set_Size(new Size(37, 20));
		((Control)Px19()).set_TabIndex(76);
		Px19().set_Text("Tên");
		((Control)Bd6q()).set_Location(new Point(98, 26));
		((Control)Bd6q()).set_Name("txtsp");
		((Control)Bd6q()).set_Size(new Size(108, 26));
		((Control)Bd6q()).set_TabIndex(75);
		Si85().set_AutoSize(true);
		((Control)Si85()).set_Font(new Font("Microsoft Sans Serif", 12.25f));
		((Control)Si85()).set_Location(new Point(10, 29));
		((Control)Si85()).set_Name("Label2");
		((Control)Si85()).set_Size(new Size(74, 20));
		((Control)Si85()).set_TabIndex(74);
		Si85().set_Text("Số phiếu");
		((ToolStrip)Ss5k()).set_Font(new Font("Segoe UI", 12f));
		((ToolStrip)Ss5k()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)La4k(),
			(ToolStripItem)k9BQ(),
			(ToolStripItem)c2K4(),
			(ToolStripItem)k2SM()
		});
		((Control)Ss5k()).set_Location(new Point(0, 0));
		((Control)Ss5k()).set_Name("MenuStrip1");
		((Control)Ss5k()).set_Size(new Size(979, 29));
		((Control)Ss5k()).set_TabIndex(79);
		((Control)Ss5k()).set_Text("MenuStrip1");
		((ToolStripDropDownItem)La4k()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)y7T4(),
			(ToolStripItem)Er5n(),
			(ToolStripItem)f6S0()
		});
		((ToolStripItem)La4k()).set_Name("QuảnLýChungToolStripMenuItem");
		((ToolStripItem)La4k()).set_Size(new Size(123, 25));
		((ToolStripItem)La4k()).set_Text("Quản lý chung");
		((ToolStripItem)y7T4()).set_Name("PhòngToolStripMenuItem");
		((ToolStripItem)y7T4()).set_Size(new Size(125, 26));
		((ToolStripItem)y7T4()).set_Text("Phòng");
		((ToolStripItem)Er5n()).set_Name("KhoaToolStripMenuItem");
		((ToolStripItem)Er5n()).set_Size(new Size(125, 26));
		((ToolStripItem)Er5n()).set_Text("Khoa");
		((ToolStripItem)f6S0()).set_Name("KýTúcToolStripMenuItem");
		((ToolStripItem)f6S0()).set_Size(new Size(125, 26));
		((ToolStripItem)f6S0()).set_Text("Ký túc");
		((ToolStripItem)k9BQ()).set_Name("TìmKiếmToolStripMenuItem");
		((ToolStripItem)k9BQ()).set_Size(new Size(86, 25));
		((ToolStripItem)k9BQ()).set_Text("Tìm kiếm");
		((ToolStripItem)c2K4()).set_Name("CậpNhậtDữLiệuToolStripMenuItem");
		((ToolStripItem)c2K4()).set_Size(new Size(135, 25));
		((ToolStripItem)c2K4()).set_Text("Cập nhật dữ liệu");
		((ToolStripDropDownItem)k2SM()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)Cs23(),
			(ToolStripItem)Ys8k()
		});
		((ToolStripItem)k2SM()).set_Name("HệThốngToolStripMenuItem");
		((ToolStripItem)k2SM()).set_Size(new Size(86, 25));
		((ToolStripItem)k2SM()).set_Text("Hệ thống");
		((ToolStripItem)Cs23()).set_Name("GiớiThiệuToolStripMenuItem");
		((ToolStripItem)Cs23()).set_Size(new Size(148, 26));
		((ToolStripItem)Cs23()).set_Text("Giới thiệu");
		((ToolStripItem)Ys8k()).set_Name("ThoátToolStripMenuItem");
		((ToolStripItem)Ys8k()).set_Size(new Size(148, 26));
		((ToolStripItem)Ys8k()).set_Text("Thoát");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(979, 599));
		((Control)this).get_Controls().Add((Control)(object)m2TE());
		((Control)this).get_Controls().Add((Control)(object)Mx0t());
		((Control)this).get_Controls().Add((Control)(object)Ss5k());
		((Form)this).set_MainMenuStrip(Ss5k());
		((Control)this).set_Name("Form7");
		((Form)this).set_Text("Nhập hồ sơ sinh viên");
		((ISupportInitialize)At84()).EndInit();
		((Control)Mx0t()).ResumeLayout(false);
		((Control)Mx0t()).PerformLayout();
		((Control)m2TE()).ResumeLayout(false);
		((Control)m2TE()).PerformLayout();
		((ISupportInitialize)y8D5()).EndInit();
		((Control)Ss5k()).ResumeLayout(false);
		((Control)Ss5k()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ComboBox Mz61()
	{
		return _cbomkt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ts6g(ComboBox Pz0e)
	{
		EventHandler eventHandler = q1DT;
		ComboBox cbomkt = _cbomkt;
		if (cbomkt != null)
		{
			cbomkt.remove_SelectedIndexChanged(eventHandler);
		}
		_cbomkt = Pz0e;
		cbomkt = _cbomkt;
		if (cbomkt != null)
		{
			cbomkt.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label k9CF()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5A0(Label p5R0)
	{
		_Label1 = p5R0;
	}

	[SpecialName]
	internal virtual DataGridView At84()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9E0(DataGridView m5MN)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(r9A8);
		DataGridView b = B;
		if (b != null)
		{
			b.remove_CellClick(val);
		}
		DataGridView val2 = (B = m5MN);
		b = B;
		if (b != null)
		{
			b.add_CellClick(val);
		}
	}

	[SpecialName]
	internal virtual GroupBox Mx0t()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2TM(GroupBox Ha54)
	{
		_GroupBox1 = Ha54;
	}

	[SpecialName]
	internal virtual GroupBox m2TE()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1Z5(GroupBox j3Y6)
	{
		GroupBox val = (Y = j3Y6);
	}

	[SpecialName]
	internal virtual Label Si85()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6PT(Label Qg0p)
	{
		Label val = (U = Qg0p);
	}

	[SpecialName]
	internal virtual ComboBox s4S7()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qq6k(ComboBox c5K3)
	{
		ComboBox val = (M = c5K3);
	}

	[SpecialName]
	internal virtual ComboBox My2o()
	{
		return _cbokh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1NB(ComboBox y5K8)
	{
		_cbokh = y5K8;
	}

	[SpecialName]
	internal virtual ComboBox k2TW()
	{
		return _cbotg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ge02(ComboBox k9HF)
	{
		_cbotg = k9HF;
	}

	[SpecialName]
	internal virtual Label Fr1p()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1EG(Label k5Y1)
	{
		_Label9 = k5Y1;
	}

	[SpecialName]
	internal virtual Label s3H1()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sw15(Label q0D6)
	{
		Label val = (n = q0D6);
	}

	[SpecialName]
	internal virtual TextBox w1AY()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He46(TextBox w1B4)
	{
		TextBox val = (T = w1B4);
	}

	[SpecialName]
	internal virtual Label m8GE()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1M3(Label x5LM)
	{
		Label val = (D = x5LM);
	}

	[SpecialName]
	internal virtual TextBox Ha78()
	{
		return _txtdchi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nq26(TextBox x8MW)
	{
		_txtdchi = x8MW;
	}

	[SpecialName]
	internal virtual Label g7SE()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rp7d(Label g8B1)
	{
		_Label6 = g8B1;
	}

	[SpecialName]
	internal virtual Label Cg8m()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cc14(Label Mf7x)
	{
		Label val = (C = Mf7x);
	}

	[SpecialName]
	internal virtual Label e5F1()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wm2b(Label e0AE)
	{
		_Label4 = e0AE;
	}

	[SpecialName]
	internal virtual TextBox q3PY()
	{
		return _txtten;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fx65(TextBox Pa0y)
	{
		_txtten = Pa0y;
	}

	[SpecialName]
	internal virtual Label Px19()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cq8r(Label s5PA)
	{
		_Label3 = s5PA;
	}

	[SpecialName]
	internal virtual TextBox Bd6q()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Be9z(TextBox Wi95)
	{
		TextBox val = (F = Wi95);
	}

	[SpecialName]
	internal virtual DataGridView y8D5()
	{
		return _DataGridView2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ad7i(DataGridView Nn78)
	{
		_DataGridView2 = Nn78;
	}

	[SpecialName]
	internal virtual ComboBox Tq94()
	{
		return _cbogt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3Z8(ComboBox p2TF)
	{
		_cbogt = p2TF;
	}

	[SpecialName]
	internal virtual Label Dw28()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo5a(Label Bs82)
	{
		_Label10 = Bs82;
	}

	[SpecialName]
	internal virtual MaskedTextBox Ac56()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9DG(MaskedTextBox Bb7r)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		KeyEventHandler val = new KeyEventHandler(o7F1);
		TypeValidationEventHandler val2 = new TypeValidationEventHandler(Yp61);
		MaskedTextBox val3 = h;
		if (val3 != null)
		{
			((Control)val3).remove_KeyDown(val);
			val3.remove_TypeValidationCompleted(val2);
		}
		MaskedTextBox val4 = (h = Bb7r);
		val3 = h;
		if (val3 != null)
		{
			((Control)val3).add_KeyDown(val);
			val3.add_TypeValidationCompleted(val2);
		}
	}

	[SpecialName]
	internal virtual MenuStrip Ss5k()
	{
		return _MenuStrip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zy34(MenuStrip Rs1d)
	{
		_MenuStrip1 = Rs1d;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem La4k()
	{
		return toolStripMenuItem_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jj9k(ToolStripMenuItem z1R6)
	{
		toolStripMenuItem_0 = z1R6;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem y7T4()
	{
		return toolStripMenuItem_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void By6k(ToolStripMenuItem w3LY)
	{
		EventHandler eventHandler = y0GX;
		ToolStripMenuItem val = toolStripMenuItem_1;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_1 = w3LY;
		val = toolStripMenuItem_1;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Er5n()
	{
		return _KhoaToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb68(ToolStripMenuItem y6L7)
	{
		EventHandler eventHandler = Fo40;
		ToolStripMenuItem khoaToolStripMenuItem = _KhoaToolStripMenuItem;
		if (khoaToolStripMenuItem != null)
		{
			((ToolStripItem)khoaToolStripMenuItem).remove_Click(eventHandler);
		}
		_KhoaToolStripMenuItem = y6L7;
		khoaToolStripMenuItem = _KhoaToolStripMenuItem;
		if (khoaToolStripMenuItem != null)
		{
			((ToolStripItem)khoaToolStripMenuItem).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem f6S0()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0YN(ToolStripMenuItem q1N5)
	{
		EventHandler eventHandler = Zk91;
		ToolStripMenuItem w = W;
		if (w != null)
		{
			((ToolStripItem)w).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (W = q1N5);
		w = W;
		if (w != null)
		{
			((ToolStripItem)w).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem k2SM()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rf16(ToolStripMenuItem Rr7d)
	{
		ToolStripMenuItem val = (o = Rr7d);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Cs23()
	{
		return toolStripMenuItem_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8ZL(ToolStripMenuItem z0GY)
	{
		EventHandler eventHandler = r4CF;
		ToolStripMenuItem val = toolStripMenuItem_2;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_2 = z0GY;
		val = toolStripMenuItem_2;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Ys8k()
	{
		return toolStripMenuItem_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9F1(ToolStripMenuItem p7T5)
	{
		EventHandler eventHandler = c0XZ;
		ToolStripMenuItem val = toolStripMenuItem_3;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_3 = p7T5;
		val = toolStripMenuItem_3;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button g1R3()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6XT(Button r7FS)
	{
		Button val = (a = r7FS);
	}

	[SpecialName]
	internal virtual Button Li59()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qi6x(Button Dn98)
	{
		EventHandler eventHandler = t5MK;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = Dn98;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Dz1d()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yn36(Button De6x)
	{
		EventHandler eventHandler = Gq3s;
		Button x = X;
		if (x != null)
		{
			((Control)x).remove_Click(eventHandler);
		}
		Button val = (X = De6x);
		x = X;
		if (x != null)
		{
			((Control)x).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem k9BQ()
	{
		return toolStripMenuItem_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2P3(ToolStripMenuItem Zk3c)
	{
		EventHandler eventHandler = Az7e;
		ToolStripMenuItem val = toolStripMenuItem_4;
		if (val != null)
		{
			((ToolStripItem)val).remove_Click(eventHandler);
		}
		toolStripMenuItem_4 = Zk3c;
		val = toolStripMenuItem_4;
		if (val != null)
		{
			((ToolStripItem)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem c2K4()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8A5(ToolStripMenuItem Ca1y)
	{
		EventHandler eventHandler = q7GH;
		ToolStripMenuItem s = S;
		if (s != null)
		{
			((ToolStripItem)s).remove_Click(eventHandler);
		}
		ToolStripMenuItem val = (S = Ca1y);
		s = S;
		if (s != null)
		{
			((ToolStripItem)s).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolTip n7M6()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7NC(ToolTip z1XT)
	{
		ToolTip val = (v = z1XT);
	}

	private void c0XZ(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void r4CF(object sender, EventArgs e)
	{
		((Control)Qy2.Forms.Je3()).Show();
	}

	private void y0GX(object sender, EventArgs e)
	{
		((Control)Qy2.Forms.Qx3()).Show();
	}

	private void Fo40(object sender, EventArgs e)
	{
		((Control)Qy2.Forms.Fw2()).Show();
	}

	private void Zk91(object sender, EventArgs e)
	{
		((Control)Qy2.Forms.x0D()).Show();
	}

	private void Az7e(object sender, EventArgs e)
	{
		((Control)Qy2.Forms.Sb3()).Show();
	}

	private void Mz7e()
	{
		j5Q4.q6GS();
		Mz61().get_Items().Clear();
		checked
		{
			int num = Kj81.ds.Tables["kytuc"]!.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Mz61().get_Items().Add(RuntimeHelpers.GetObjectValue(Kj81.ds.Tables["kytuc"]!.Rows[i][0]));
			}
		}
	}

	private void p9Q5(string q1EC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		dtpkt.Clear();
		OleDbCommand val = new OleDbCommand();
		val.set_Connection(Kj81.con);
		val.set_CommandType(CommandType.Text);
		val.set_CommandText(" Select maphong,loaiphong from phong where maktx='" + q1EC + "'");
		Kj81.da.set_SelectCommand(val);
		((DbDataAdapter)(object)Kj81.da).Fill(dtpkt);
		At84().set_DataSource((object)dtpkt);
	}

	private void Le4j(object sender, EventArgs e)
	{
		Ry40.b4KZ();
		y8D5().set_DataSource((object)Kj81.ds.Tables["hoso"]);
		Mz7e();
		At84().set_RowHeadersVisible(false);
		At84().set_AllowUserToAddRows(false);
		At84().set_AllowUserToDeleteRows(false);
		At84().set_ReadOnly(true);
		Ac56().set_Mask("00/00/0000");
		Ac56().set_ValidatingType(typeof(DateTime));
		n7M6().set_IsBalloon(true);
	}

	private void o7F1(object sender, KeyEventArgs e)
	{
		n7M6().Hide((IWin32Window)(object)Ac56());
	}

	private void Yp61(object sender, TypeValidationEventArgs e)
	{
		if (!e.get_IsValidInput())
		{
			n7M6().set_ToolTipTitle("Thời gian không phù hợp");
			n7M6().Show("Bạn phải nhập ngày tháng định dạng dd/mm/yyyy", (IWin32Window)(object)Ac56(), 100, -60, 5000);
			((TextBoxBase)Ac56()).Clear();
		}
	}

	private void q1DT(object sender, EventArgs e)
	{
		p9Q5(Mz61().get_Text());
	}

	private void q7GH(object sender, EventArgs e)
	{
		Mz7e();
	}

	private void Gq3s(object sender, EventArgs e)
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
		if ((this.e < 0) | (Operators.CompareString(Mz61().get_Text(), "", false) == 0) | (Operators.CompareString(Bd6q().get_Text(), "", false) == 0) | (Operators.CompareString(q3PY().get_Text(), "", false) == 0) | (Operators.CompareString(s4S7().get_Text(), "", false) == 0) | (Operators.CompareString(Tq94().get_Text(), "", false) == 0) | (Operators.CompareString(k2TW().get_Text(), "", false) == 0) | (Operators.CompareString(Ha78().get_Text(), "", false) == 0) | (Operators.CompareString(w1AY().get_Text(), "", false) == 0) | (Operators.CompareString(My2o().get_Text(), "", false) == 0))
		{
			Interaction.MsgBox((object)"Bạn phải điền đủ thông tin", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Ry40.Pj20(Bd6q().get_Text()) == 0)
		{
			string text = Ac56().get_Text();
			DateTime result = DateTime.MinValue;
			if (!DateTime.TryParse(text, out result))
			{
				Interaction.MsgBox((object)"Bạn phải nhập đủ thông tin", (MsgBoxStyle)0, (object)null);
				return;
			}
			if (Operators.CompareString(Tq94().get_Text(), "Nam", false) == 0)
			{
				Ry40.f5SF(Bd6q().get_Text(), q3PY().get_Text(), Conversions.ToDate(Ac56().get_Text()), k1MA: true, s4S7().get_Text(), k2TW().get_Text(), Ha78().get_Text(), w1AY().get_Text(), My2o().get_Text(), Conversions.ToString(At84().get_Rows().get_Item(this.e).get_Cells()
					.get_Item(0)
					.get_Value()));
				Interaction.MsgBox((object)"Đã thêm hồ sơ mới", (MsgBoxStyle)64, (object)"Chúc mừng");
			}
			else
			{
				Ry40.f5SF(Bd6q().get_Text(), q3PY().get_Text(), Conversions.ToDate(Ac56().get_Text()), k1MA: false, s4S7().get_Text(), k2TW().get_Text(), Ha78().get_Text(), w1AY().get_Text(), My2o().get_Text(), Conversions.ToString(At84().get_Rows().get_Item(this.e).get_Cells()
					.get_Item(0)
					.get_Value()));
				Interaction.MsgBox((object)"Đã thêm hồ sơ mới", (MsgBoxStyle)64, (object)"Chúc mừng");
			}
		}
		else
		{
			string text2 = Ac56().get_Text();
			DateTime result = DateTime.MinValue;
			if (!DateTime.TryParse(text2, out result))
			{
				Interaction.MsgBox((object)"Bạn phải nhập đủ thông tin", (MsgBoxStyle)0, (object)null);
				return;
			}
			if (Operators.CompareString(Tq94().get_Text(), "Nam", false) == 0)
			{
				long num = (long)Interaction.MsgBox((object)"Hồ sơ đã tồn tại, bạn xác nhận muốn sửa?", (MsgBoxStyle)1, (object)"Thông báo");
				if (num == 1L)
				{
					Ry40.s8CZ(Bd6q().get_Text(), q3PY().get_Text(), Conversions.ToDate(Ac56().get_Text()), Ex06: true, s4S7().get_Text(), k2TW().get_Text(), Ha78().get_Text(), w1AY().get_Text(), My2o().get_Text(), Conversions.ToString(At84().get_Rows().get_Item(this.e).get_Cells()
						.get_Item(0)
						.get_Value()));
					Interaction.MsgBox((object)"Đã sửa hồ sơ", (MsgBoxStyle)64, (object)"Chúc mừng");
					Ed69();
				}
				else
				{
					num = 2L;
					Ed69();
				}
			}
			else
			{
				long num = (long)Interaction.MsgBox((object)"Hồ sơ đã tồn tại, bạn xác nhận muốn sửa?", (MsgBoxStyle)1, (object)"Thông báo");
				if (num == 1L)
				{
					Ry40.s8CZ(Bd6q().get_Text(), q3PY().get_Text(), Conversions.ToDate(Ac56().get_Text()), Ex06: false, s4S7().get_Text(), k2TW().get_Text(), Ha78().get_Text(), w1AY().get_Text(), My2o().get_Text(), Conversions.ToString(At84().get_Rows().get_Item(this.e).get_Cells()
						.get_Item(0)
						.get_Value()));
					Interaction.MsgBox((object)"Đã sửa hồ sơ", (MsgBoxStyle)64, (object)"Chúc mừng");
					Ed69();
				}
				else
				{
					num = 2L;
					Ed69();
				}
			}
		}
		Ed69();
	}

	private void Ed69()
	{
		Mz61().ResetText();
		((TextBoxBase)Bd6q()).Clear();
		((TextBoxBase)q3PY()).Clear();
		((TextBoxBase)Ac56()).Clear();
		k2TW().ResetText();
		s4S7().ResetText();
		s4S7().ResetText();
		((TextBoxBase)w1AY()).Clear();
		My2o().ResetText();
	}

	private void r9A8(object sender, DataGridViewCellEventArgs e)
	{
		int num = (this.e = At84().get_CurrentCell().get_RowIndex());
	}

	private void t5MK(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (Ry40.Pj20(Bd6q().get_Text()) == 0)
		{
			Interaction.MsgBox((object)"Hồ sơ không tồn tại", (MsgBoxStyle)64, (object)"Lỗi");
			return;
		}
		Ry40.i9L8(Bd6q().get_Text());
		Interaction.MsgBox((object)"Đã xóa", (MsgBoxStyle)64, (object)"Lỗi");
		Ed69();
	}
}
