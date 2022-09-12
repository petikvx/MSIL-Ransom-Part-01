using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using SimpleChessApp.Game;

namespace SimpleChessApp;

public class Promotion : Form
{
	public Pieces Piece;

	private IContainer components = null;

	private SimpleSquare square1;

	private SimpleSquare square2;

	private SimpleSquare square3;

	private SimpleSquare square4;

	private TableLayoutPanel tableLayoutPanel1;

	private SimpleSquare simpleSquare2;

	private SimpleSquare simpleSquare1;

	private ContextMenuStrip contextMenuStrip1;

	private Timer timer1;

	private SerialPort serialPort1;

	public Promotion(Point p)
	{
		InitializeComponent();
		Promotion.smethod_0((Form)(object)this, (FormStartPosition)0);
		Promotion.smethod_1((Form)(object)this, p);
		square1.Piece = new ChessPiece(Pieces.Queen, PieceColor.White);
		square2.Piece = new ChessPiece(Pieces.Rook, PieceColor.White);
		square3.Piece = new ChessPiece(Pieces.Knight, PieceColor.White);
		square4.Piece = new ChessPiece(Pieces.Bishop, PieceColor.White);
		square1.Click += _Click;
		square2.Click += _Click;
		square3.Click += _Click;
		square4.Click += _Click;
	}

	private void _Click(object sender, MouseEventArgs e)
	{
		SimpleSquare simpleSquare = sender as SimpleSquare;
		Piece = simpleSquare.Piece.Kind;
		Promotion.smethod_2((Form)(object)this);
	}

	private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Promotion.smethod_3((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		components = Promotion.smethod_4();
		square1 = new SimpleSquare();
		square2 = new SimpleSquare();
		square3 = new SimpleSquare();
		square4 = new SimpleSquare();
		tableLayoutPanel1 = Promotion.smethod_5();
		contextMenuStrip1 = Promotion.smethod_6(components);
		simpleSquare1 = new SimpleSquare();
		simpleSquare2 = new SimpleSquare();
		timer1 = Promotion.smethod_7(components);
		serialPort1 = Promotion.smethod_8(components);
		Promotion.smethod_9((Control)(object)tableLayoutPanel1);
		Promotion.smethod_10((Control)(object)this);
		Promotion.smethod_11((Control)(object)square1, (AnchorStyles)15);
		Promotion.smethod_12((Control)(object)square1, Color.WhiteSmoke);
		Promotion.smethod_13((Control)(object)square1, (ImageLayout)2);
		square1.IsBlackSquare = false;
		Promotion.smethod_14((Control)(object)square1, new Point(348, 0));
		Promotion.smethod_15((Control)(object)square1, new Padding(0));
		Promotion.smethod_16((Control)(object)square1, "square1");
		square1.Piece = null;
		Promotion.smethod_17((Control)(object)square1, new Size(348, 604));
		Promotion.smethod_18((Control)(object)square1, 0);
		Promotion.smethod_11((Control)(object)square2, (AnchorStyles)15);
		Promotion.smethod_12((Control)(object)square2, Color.WhiteSmoke);
		Promotion.smethod_13((Control)(object)square2, (ImageLayout)2);
		square2.IsBlackSquare = false;
		Promotion.smethod_14((Control)(object)square2, new Point(1044, 0));
		Promotion.smethod_15((Control)(object)square2, new Padding(0));
		Promotion.smethod_16((Control)(object)square2, "square2");
		square2.Piece = null;
		Promotion.smethod_17((Control)(object)square2, new Size(348, 604));
		Promotion.smethod_18((Control)(object)square2, 1);
		Promotion.smethod_11((Control)(object)square3, (AnchorStyles)15);
		Promotion.smethod_12((Control)(object)square3, Color.WhiteSmoke);
		Promotion.smethod_13((Control)(object)square3, (ImageLayout)2);
		square3.IsBlackSquare = false;
		Promotion.smethod_14((Control)(object)square3, new Point(696, 0));
		Promotion.smethod_15((Control)(object)square3, new Padding(0));
		Promotion.smethod_16((Control)(object)square3, "square3");
		square3.Piece = null;
		Promotion.smethod_17((Control)(object)square3, new Size(348, 604));
		Promotion.smethod_18((Control)(object)square3, 2);
		Promotion.smethod_11((Control)(object)square4, (AnchorStyles)15);
		Promotion.smethod_12((Control)(object)square4, Color.WhiteSmoke);
		Promotion.smethod_13((Control)(object)square4, (ImageLayout)2);
		square4.IsBlackSquare = false;
		Promotion.smethod_14((Control)(object)square4, new Point(0, 0));
		Promotion.smethod_15((Control)(object)square4, new Padding(0));
		Promotion.smethod_16((Control)(object)square4, "square4");
		square4.Piece = null;
		Promotion.smethod_17((Control)(object)square4, new Size(348, 604));
		Promotion.smethod_18((Control)(object)square4, 3);
		Promotion.smethod_19(tableLayoutPanel1, 6);
		Promotion.smethod_22(Promotion.smethod_20(tableLayoutPanel1), Promotion.smethod_21((SizeType)2, 25f));
		Promotion.smethod_22(Promotion.smethod_20(tableLayoutPanel1), Promotion.smethod_21((SizeType)2, 25f));
		Promotion.smethod_22(Promotion.smethod_20(tableLayoutPanel1), Promotion.smethod_21((SizeType)2, 25f));
		Promotion.smethod_22(Promotion.smethod_20(tableLayoutPanel1), Promotion.smethod_21((SizeType)2, 25f));
		Promotion.smethod_22(Promotion.smethod_20(tableLayoutPanel1), Promotion.smethod_21((SizeType)1, 20f));
		Promotion.smethod_22(Promotion.smethod_20(tableLayoutPanel1), Promotion.smethod_21((SizeType)1, 20f));
		Promotion.smethod_24(Promotion.smethod_23(tableLayoutPanel1), (Control)(object)simpleSquare2, 5, 0);
		Promotion.smethod_24(Promotion.smethod_23(tableLayoutPanel1), (Control)(object)simpleSquare1, 4, 0);
		Promotion.smethod_24(Promotion.smethod_23(tableLayoutPanel1), (Control)(object)square3, 2, 0);
		Promotion.smethod_24(Promotion.smethod_23(tableLayoutPanel1), (Control)(object)square2, 3, 0);
		Promotion.smethod_24(Promotion.smethod_23(tableLayoutPanel1), (Control)(object)square1, 1, 0);
		Promotion.smethod_24(Promotion.smethod_23(tableLayoutPanel1), (Control)(object)square4, 0, 0);
		Promotion.smethod_25((Control)(object)tableLayoutPanel1, (DockStyle)5);
		Promotion.smethod_14((Control)(object)tableLayoutPanel1, new Point(0, 0));
		Promotion.smethod_16((Control)(object)tableLayoutPanel1, "tableLayoutPanel1");
		Promotion.smethod_26(tableLayoutPanel1, 1);
		Promotion.smethod_29(Promotion.smethod_27(tableLayoutPanel1), Promotion.smethod_28((SizeType)2, 100f));
		Promotion.smethod_17((Control)(object)tableLayoutPanel1, new Size(1433, 604));
		Promotion.smethod_18((Control)(object)tableLayoutPanel1, 4);
		Promotion.smethod_30((Control)(object)tableLayoutPanel1, new PaintEventHandler(tableLayoutPanel1_Paint));
		Promotion.smethod_16((Control)(object)contextMenuStrip1, "contextMenuStrip1");
		Promotion.smethod_17((Control)(object)contextMenuStrip1, new Size(61, 4));
		Promotion.smethod_11((Control)(object)simpleSquare1, (AnchorStyles)15);
		Promotion.smethod_12((Control)(object)simpleSquare1, Color.WhiteSmoke);
		Promotion.smethod_13((Control)(object)simpleSquare1, (ImageLayout)2);
		simpleSquare1.IsBlackSquare = false;
		Promotion.smethod_14((Control)(object)simpleSquare1, new Point(1392, 0));
		Promotion.smethod_15((Control)(object)simpleSquare1, new Padding(0));
		Promotion.smethod_16((Control)(object)simpleSquare1, "simpleSquare1");
		simpleSquare1.Piece = null;
		Promotion.smethod_17((Control)(object)simpleSquare1, new Size(20, 604));
		Promotion.smethod_18((Control)(object)simpleSquare1, 4);
		Promotion.smethod_11((Control)(object)simpleSquare2, (AnchorStyles)15);
		Promotion.smethod_12((Control)(object)simpleSquare2, Color.WhiteSmoke);
		Promotion.smethod_13((Control)(object)simpleSquare2, (ImageLayout)2);
		simpleSquare2.IsBlackSquare = false;
		Promotion.smethod_14((Control)(object)simpleSquare2, new Point(1412, 0));
		Promotion.smethod_15((Control)(object)simpleSquare2, new Padding(0));
		Promotion.smethod_16((Control)(object)simpleSquare2, "simpleSquare2");
		simpleSquare2.Piece = null;
		Promotion.smethod_17((Control)(object)simpleSquare2, new Size(21, 604));
		Promotion.smethod_18((Control)(object)simpleSquare2, 5);
		Promotion.smethod_31((ContainerControl)(object)this, new SizeF(6f, 13f));
		Promotion.smethod_32((ContainerControl)(object)this, (AutoScaleMode)1);
		Promotion.smethod_33((Form)(object)this, new Size(1433, 604));
		Promotion.smethod_35(Promotion.smethod_34((Control)(object)this), (Control)(object)tableLayoutPanel1);
		Promotion.smethod_36((Form)(object)this, (FormBorderStyle)0);
		Promotion.smethod_37((Control)(object)this, "Promotion");
		Promotion.smethod_38((Control)(object)this, "Form2");
		Promotion.smethod_39((Control)(object)tableLayoutPanel1, bool_0: false);
		Promotion.smethod_40((Control)(object)this, bool_0: false);
	}

	static void smethod_0(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_1(Form form_0, Point point_0)
	{
		form_0.set_Location(point_0);
	}

	static void smethod_2(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_4()
	{
		return new Container();
	}

	static TableLayoutPanel smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TableLayoutPanel();
	}

	static ContextMenuStrip smethod_6(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new ContextMenuStrip(icontainer_0);
	}

	static Timer smethod_7(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_0);
	}

	static SerialPort smethod_8(IContainer icontainer_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SerialPort(icontainer_0);
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_10(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_11(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static void smethod_12(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_13(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_14(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_15(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_16(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_17(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_18(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_19(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_ColumnCount(int_0);
	}

	static TableLayoutColumnStyleCollection smethod_20(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_ColumnStyles();
	}

	static ColumnStyle smethod_21(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ColumnStyle(sizeType_0, float_0);
	}

	static int smethod_22(TableLayoutColumnStyleCollection tableLayoutColumnStyleCollection_0, ColumnStyle columnStyle_0)
	{
		return tableLayoutColumnStyleCollection_0.Add(columnStyle_0);
	}

	static TableLayoutControlCollection smethod_23(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_Controls();
	}

	static void smethod_24(TableLayoutControlCollection tableLayoutControlCollection_0, Control control_0, int int_0, int int_1)
	{
		tableLayoutControlCollection_0.Add(control_0, int_0, int_1);
	}

	static void smethod_25(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_26(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_RowCount(int_0);
	}

	static TableLayoutRowStyleCollection smethod_27(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_RowStyles();
	}

	static RowStyle smethod_28(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new RowStyle(sizeType_0, float_0);
	}

	static int smethod_29(TableLayoutRowStyleCollection tableLayoutRowStyleCollection_0, RowStyle rowStyle_0)
	{
		return tableLayoutRowStyleCollection_0.Add(rowStyle_0);
	}

	static void smethod_30(Control control_0, PaintEventHandler paintEventHandler_0)
	{
		control_0.add_Paint(paintEventHandler_0);
	}

	static void smethod_31(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_32(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_33(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_34(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_35(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_36(Form form_0, FormBorderStyle formBorderStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_FormBorderStyle(formBorderStyle_0);
	}

	static void smethod_37(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_38(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_39(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_40(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
