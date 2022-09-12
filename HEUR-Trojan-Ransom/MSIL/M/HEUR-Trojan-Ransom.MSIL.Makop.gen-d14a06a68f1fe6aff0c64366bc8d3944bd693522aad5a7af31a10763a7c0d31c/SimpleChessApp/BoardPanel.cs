using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SimpleChessApp.Game;

namespace SimpleChessApp;

public class BoardPanel : UserControl
{
	public Board Board;

	private IContainer components = null;

	private Panel centerPanel;

	private Panel panel2;

	private TableLayoutPanel tableLayoutPanel1;

	private Panel panel1;

	private TableLayoutPanel tableLayoutPanel2;

	private Panel panel3;

	private Panel panel4;

	private Panel panel5;

	private Panel panel10;

	private Panel panel15;

	private Panel panel20;

	private Panel panel25;

	private Panel panel26;

	private Panel panel27;

	private TableLayoutPanel tableLayoutPanel11;

	private Panel panel28;

	private TableLayoutPanel tableLayoutPanel12;

	private Panel panel29;

	private Panel panel21;

	private Panel panel22;

	private TableLayoutPanel tableLayoutPanel9;

	private Panel panel23;

	private TableLayoutPanel tableLayoutPanel10;

	private Panel panel24;

	private Panel panel16;

	private Panel panel17;

	private TableLayoutPanel tableLayoutPanel7;

	private Panel panel18;

	private TableLayoutPanel tableLayoutPanel8;

	private Panel panel19;

	private Panel panel11;

	private Panel panel12;

	private TableLayoutPanel tableLayoutPanel5;

	private Panel panel13;

	private TableLayoutPanel tableLayoutPanel6;

	private Panel panel14;

	private Panel panel6;

	private Panel panel7;

	private TableLayoutPanel tableLayoutPanel3;

	private Panel panel8;

	private TableLayoutPanel tableLayoutPanel4;

	private Panel panel9;

	public BoardPanel()
	{
		InitializeComponent();
		Color color_ = BoardPanel.smethod_0("#252526");
		BoardPanel.smethod_1((Control)(object)this, color_);
		for (int i = 0; i < 8; i++)
		{
			TableLayoutControlCollection tableLayoutControlCollection_ = BoardPanel.smethod_2(tableLayoutPanel1);
			BoardLabel control_ = new BoardLabel();
			BoardPanel.smethod_3((Control)(object)control_, (8 - i).ToString());
			BoardPanel.smethod_4(tableLayoutControlCollection_, (Control)(object)control_, 0, i);
			TableLayoutControlCollection tableLayoutControlCollection_2 = BoardPanel.smethod_2(tableLayoutPanel2);
			BoardLabel boardLabel = new BoardLabel();
			BoardPanel.smethod_5((Label)(object)boardLabel, (ContentAlignment)4);
			BoardPanel.smethod_3((Control)(object)boardLabel, BoardPanel.smethod_6("abcdefgh", i).ToString());
			BoardPanel.smethod_4(tableLayoutControlCollection_2, (Control)(object)boardLabel, i, 0);
		}
	}

	public void SetBoard(ImageLayout pawnSize = 2, bool flipped = false, bool allMoves = false, bool selected = false)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Board = new Board(centerPanel, pawnSize, flipped, allMoves, selected);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			BoardPanel.smethod_7((IDisposable)components);
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Unknown result type (might be due to invalid IL or missing references)
		//IL_1401: Unknown result type (might be due to invalid IL or missing references)
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1754: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_186b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_199c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_218f: Unknown result type (might be due to invalid IL or missing references)
		//IL_221c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2294: Unknown result type (might be due to invalid IL or missing references)
		//IL_230f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2333: Unknown result type (might be due to invalid IL or missing references)
		//IL_2384: Unknown result type (might be due to invalid IL or missing references)
		//IL_243f: Unknown result type (might be due to invalid IL or missing references)
		centerPanel = BoardPanel.smethod_8();
		tableLayoutPanel1 = BoardPanel.smethod_9();
		tableLayoutPanel2 = BoardPanel.smethod_9();
		panel1 = BoardPanel.smethod_8();
		panel2 = BoardPanel.smethod_8();
		panel3 = BoardPanel.smethod_8();
		panel4 = BoardPanel.smethod_8();
		panel5 = BoardPanel.smethod_8();
		tableLayoutPanel3 = BoardPanel.smethod_9();
		tableLayoutPanel4 = BoardPanel.smethod_9();
		panel6 = BoardPanel.smethod_8();
		panel7 = BoardPanel.smethod_8();
		panel8 = BoardPanel.smethod_8();
		panel9 = BoardPanel.smethod_8();
		panel10 = BoardPanel.smethod_8();
		tableLayoutPanel5 = BoardPanel.smethod_9();
		tableLayoutPanel6 = BoardPanel.smethod_9();
		panel11 = BoardPanel.smethod_8();
		panel12 = BoardPanel.smethod_8();
		panel13 = BoardPanel.smethod_8();
		panel14 = BoardPanel.smethod_8();
		panel15 = BoardPanel.smethod_8();
		tableLayoutPanel7 = BoardPanel.smethod_9();
		tableLayoutPanel8 = BoardPanel.smethod_9();
		panel16 = BoardPanel.smethod_8();
		panel17 = BoardPanel.smethod_8();
		panel18 = BoardPanel.smethod_8();
		panel19 = BoardPanel.smethod_8();
		panel20 = BoardPanel.smethod_8();
		tableLayoutPanel9 = BoardPanel.smethod_9();
		tableLayoutPanel10 = BoardPanel.smethod_9();
		panel21 = BoardPanel.smethod_8();
		panel22 = BoardPanel.smethod_8();
		panel23 = BoardPanel.smethod_8();
		panel24 = BoardPanel.smethod_8();
		panel25 = BoardPanel.smethod_8();
		tableLayoutPanel11 = BoardPanel.smethod_9();
		tableLayoutPanel12 = BoardPanel.smethod_9();
		panel26 = BoardPanel.smethod_8();
		panel27 = BoardPanel.smethod_8();
		panel28 = BoardPanel.smethod_8();
		panel29 = BoardPanel.smethod_8();
		BoardPanel.smethod_10((Control)(object)centerPanel);
		BoardPanel.smethod_10((Control)(object)panel1);
		BoardPanel.smethod_10((Control)(object)panel2);
		BoardPanel.smethod_10((Control)(object)panel5);
		BoardPanel.smethod_10((Control)(object)panel7);
		BoardPanel.smethod_10((Control)(object)panel8);
		BoardPanel.smethod_10((Control)(object)panel10);
		BoardPanel.smethod_10((Control)(object)panel12);
		BoardPanel.smethod_10((Control)(object)panel13);
		BoardPanel.smethod_10((Control)(object)panel15);
		BoardPanel.smethod_10((Control)(object)panel17);
		BoardPanel.smethod_10((Control)(object)panel18);
		BoardPanel.smethod_10((Control)(object)panel20);
		BoardPanel.smethod_10((Control)(object)panel22);
		BoardPanel.smethod_10((Control)(object)panel23);
		BoardPanel.smethod_10((Control)(object)panel27);
		BoardPanel.smethod_10((Control)(object)panel28);
		BoardPanel.smethod_11((Control)(object)this);
		BoardPanel.smethod_1((Control)(object)centerPanel, BoardPanel.smethod_12());
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)centerPanel), (Control)(object)panel5);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)centerPanel), (Control)(object)panel6);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)centerPanel), (Control)(object)panel7);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)centerPanel), (Control)(object)panel8);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)centerPanel), (Control)(object)panel9);
		BoardPanel.smethod_15((Control)(object)centerPanel, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)centerPanel, new Point(8, 8));
		BoardPanel.smethod_17((Control)(object)centerPanel, new Padding(0));
		BoardPanel.smethod_18((Control)(object)centerPanel, "centerPanel");
		BoardPanel.smethod_19((Control)(object)centerPanel, new Size(384, 384));
		BoardPanel.smethod_20((Control)(object)centerPanel, 3);
		BoardPanel.smethod_21(tableLayoutPanel1, 1);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel1), BoardPanel.smethod_23((SizeType)2, 100f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel1, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel1, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel1, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel1, "tableLayoutPanel1");
		BoardPanel.smethod_25(tableLayoutPanel1, 8);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel1), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel1, new Size(8, 384));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel1, 0);
		BoardPanel.smethod_21(tableLayoutPanel2, 8);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel2), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel2, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel2, new Point(8, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel2, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel2, "tableLayoutPanel2");
		BoardPanel.smethod_25(tableLayoutPanel2, 1);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel2), BoardPanel.smethod_27((SizeType)2, 50f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel2, new Size(384, 8));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel2, 1);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel1), (Control)(object)tableLayoutPanel2);
		BoardPanel.smethod_15((Control)(object)panel1, (DockStyle)2);
		BoardPanel.smethod_16((Control)(object)panel1, new Point(0, 392));
		BoardPanel.smethod_17((Control)(object)panel1, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel1, "panel1");
		BoardPanel.smethod_29((Control)(object)panel1, new Padding(8, 0, 8, 0));
		BoardPanel.smethod_19((Control)(object)panel1, new Size(400, 8));
		BoardPanel.smethod_20((Control)(object)panel1, 2);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel2), (Control)(object)tableLayoutPanel1);
		BoardPanel.smethod_15((Control)(object)panel2, (DockStyle)3);
		BoardPanel.smethod_16((Control)(object)panel2, new Point(0, 8));
		BoardPanel.smethod_17((Control)(object)panel2, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel2, "panel2");
		BoardPanel.smethod_19((Control)(object)panel2, new Size(8, 384));
		BoardPanel.smethod_20((Control)(object)panel2, 3);
		BoardPanel.smethod_15((Control)(object)panel3, (DockStyle)1);
		BoardPanel.smethod_16((Control)(object)panel3, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)panel3, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel3, "panel3");
		BoardPanel.smethod_19((Control)(object)panel3, new Size(400, 8));
		BoardPanel.smethod_20((Control)(object)panel3, 4);
		BoardPanel.smethod_15((Control)(object)panel4, (DockStyle)4);
		BoardPanel.smethod_16((Control)(object)panel4, new Point(392, 8));
		BoardPanel.smethod_17((Control)(object)panel4, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel4, "panel4");
		BoardPanel.smethod_19((Control)(object)panel4, new Size(8, 384));
		BoardPanel.smethod_20((Control)(object)panel4, 5);
		BoardPanel.smethod_1((Control)(object)panel5, BoardPanel.smethod_12());
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel5), (Control)(object)panel10);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel5), (Control)(object)panel11);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel5), (Control)(object)panel12);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel5), (Control)(object)panel13);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel5), (Control)(object)panel14);
		BoardPanel.smethod_15((Control)(object)panel5, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)panel5, new Point(8, 8));
		BoardPanel.smethod_17((Control)(object)panel5, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel5, "panel5");
		BoardPanel.smethod_19((Control)(object)panel5, new Size(368, 368));
		BoardPanel.smethod_20((Control)(object)panel5, 7);
		BoardPanel.smethod_21(tableLayoutPanel3, 1);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel3), BoardPanel.smethod_23((SizeType)2, 100f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel3, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel3, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel3, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel3, "tableLayoutPanel3");
		BoardPanel.smethod_25(tableLayoutPanel3, 8);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel3), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel3, new Size(8, 368));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel3, 0);
		BoardPanel.smethod_21(tableLayoutPanel4, 8);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel4), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel4, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel4, new Point(8, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel4, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel4, "tableLayoutPanel4");
		BoardPanel.smethod_25(tableLayoutPanel4, 1);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel4), BoardPanel.smethod_27((SizeType)2, 50f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel4, new Size(368, 8));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel4, 1);
		BoardPanel.smethod_15((Control)(object)panel6, (DockStyle)4);
		BoardPanel.smethod_16((Control)(object)panel6, new Point(376, 8));
		BoardPanel.smethod_17((Control)(object)panel6, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel6, "panel6");
		BoardPanel.smethod_19((Control)(object)panel6, new Size(8, 368));
		BoardPanel.smethod_20((Control)(object)panel6, 10);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel7), (Control)(object)tableLayoutPanel3);
		BoardPanel.smethod_15((Control)(object)panel7, (DockStyle)3);
		BoardPanel.smethod_16((Control)(object)panel7, new Point(0, 8));
		BoardPanel.smethod_17((Control)(object)panel7, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel7, "panel7");
		BoardPanel.smethod_19((Control)(object)panel7, new Size(8, 368));
		BoardPanel.smethod_20((Control)(object)panel7, 8);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel8), (Control)(object)tableLayoutPanel4);
		BoardPanel.smethod_15((Control)(object)panel8, (DockStyle)2);
		BoardPanel.smethod_16((Control)(object)panel8, new Point(0, 376));
		BoardPanel.smethod_17((Control)(object)panel8, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel8, "panel8");
		BoardPanel.smethod_29((Control)(object)panel8, new Padding(8, 0, 8, 0));
		BoardPanel.smethod_19((Control)(object)panel8, new Size(384, 8));
		BoardPanel.smethod_20((Control)(object)panel8, 6);
		BoardPanel.smethod_15((Control)(object)panel9, (DockStyle)1);
		BoardPanel.smethod_16((Control)(object)panel9, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)panel9, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel9, "panel9");
		BoardPanel.smethod_19((Control)(object)panel9, new Size(384, 8));
		BoardPanel.smethod_20((Control)(object)panel9, 9);
		BoardPanel.smethod_1((Control)(object)panel10, BoardPanel.smethod_12());
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel10), (Control)(object)panel15);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel10), (Control)(object)panel16);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel10), (Control)(object)panel17);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel10), (Control)(object)panel18);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel10), (Control)(object)panel19);
		BoardPanel.smethod_15((Control)(object)panel10, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)panel10, new Point(8, 8));
		BoardPanel.smethod_17((Control)(object)panel10, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel10, "panel10");
		BoardPanel.smethod_19((Control)(object)panel10, new Size(352, 352));
		BoardPanel.smethod_20((Control)(object)panel10, 7);
		BoardPanel.smethod_21(tableLayoutPanel5, 1);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel5), BoardPanel.smethod_23((SizeType)2, 100f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel5, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel5, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel5, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel5, "tableLayoutPanel5");
		BoardPanel.smethod_25(tableLayoutPanel5, 8);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel5), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel5, new Size(8, 352));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel5, 0);
		BoardPanel.smethod_21(tableLayoutPanel6, 8);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel6), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel6, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel6, new Point(8, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel6, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel6, "tableLayoutPanel6");
		BoardPanel.smethod_25(tableLayoutPanel6, 1);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel6), BoardPanel.smethod_27((SizeType)2, 50f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel6, new Size(352, 8));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel6, 1);
		BoardPanel.smethod_15((Control)(object)panel11, (DockStyle)4);
		BoardPanel.smethod_16((Control)(object)panel11, new Point(360, 8));
		BoardPanel.smethod_17((Control)(object)panel11, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel11, "panel11");
		BoardPanel.smethod_19((Control)(object)panel11, new Size(8, 352));
		BoardPanel.smethod_20((Control)(object)panel11, 10);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel12), (Control)(object)tableLayoutPanel5);
		BoardPanel.smethod_15((Control)(object)panel12, (DockStyle)3);
		BoardPanel.smethod_16((Control)(object)panel12, new Point(0, 8));
		BoardPanel.smethod_17((Control)(object)panel12, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel12, "panel12");
		BoardPanel.smethod_19((Control)(object)panel12, new Size(8, 352));
		BoardPanel.smethod_20((Control)(object)panel12, 8);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel13), (Control)(object)tableLayoutPanel6);
		BoardPanel.smethod_15((Control)(object)panel13, (DockStyle)2);
		BoardPanel.smethod_16((Control)(object)panel13, new Point(0, 360));
		BoardPanel.smethod_17((Control)(object)panel13, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel13, "panel13");
		BoardPanel.smethod_29((Control)(object)panel13, new Padding(8, 0, 8, 0));
		BoardPanel.smethod_19((Control)(object)panel13, new Size(368, 8));
		BoardPanel.smethod_20((Control)(object)panel13, 6);
		BoardPanel.smethod_15((Control)(object)panel14, (DockStyle)1);
		BoardPanel.smethod_16((Control)(object)panel14, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)panel14, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel14, "panel14");
		BoardPanel.smethod_19((Control)(object)panel14, new Size(368, 8));
		BoardPanel.smethod_20((Control)(object)panel14, 9);
		BoardPanel.smethod_1((Control)(object)panel15, BoardPanel.smethod_12());
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel15), (Control)(object)panel20);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel15), (Control)(object)panel21);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel15), (Control)(object)panel22);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel15), (Control)(object)panel23);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel15), (Control)(object)panel24);
		BoardPanel.smethod_15((Control)(object)panel15, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)panel15, new Point(8, 8));
		BoardPanel.smethod_17((Control)(object)panel15, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel15, "panel15");
		BoardPanel.smethod_19((Control)(object)panel15, new Size(336, 336));
		BoardPanel.smethod_20((Control)(object)panel15, 7);
		BoardPanel.smethod_21(tableLayoutPanel7, 1);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel7), BoardPanel.smethod_23((SizeType)2, 100f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel7, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel7, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel7, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel7, "tableLayoutPanel7");
		BoardPanel.smethod_25(tableLayoutPanel7, 8);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel7), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel7, new Size(8, 336));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel7, 0);
		BoardPanel.smethod_21(tableLayoutPanel8, 8);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel8), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel8, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel8, new Point(8, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel8, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel8, "tableLayoutPanel8");
		BoardPanel.smethod_25(tableLayoutPanel8, 1);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel8), BoardPanel.smethod_27((SizeType)2, 50f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel8, new Size(336, 8));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel8, 1);
		BoardPanel.smethod_15((Control)(object)panel16, (DockStyle)4);
		BoardPanel.smethod_16((Control)(object)panel16, new Point(344, 8));
		BoardPanel.smethod_17((Control)(object)panel16, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel16, "panel16");
		BoardPanel.smethod_19((Control)(object)panel16, new Size(8, 336));
		BoardPanel.smethod_20((Control)(object)panel16, 10);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel17), (Control)(object)tableLayoutPanel7);
		BoardPanel.smethod_15((Control)(object)panel17, (DockStyle)3);
		BoardPanel.smethod_16((Control)(object)panel17, new Point(0, 8));
		BoardPanel.smethod_17((Control)(object)panel17, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel17, "panel17");
		BoardPanel.smethod_19((Control)(object)panel17, new Size(8, 336));
		BoardPanel.smethod_20((Control)(object)panel17, 8);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel18), (Control)(object)tableLayoutPanel8);
		BoardPanel.smethod_15((Control)(object)panel18, (DockStyle)2);
		BoardPanel.smethod_16((Control)(object)panel18, new Point(0, 344));
		BoardPanel.smethod_17((Control)(object)panel18, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel18, "panel18");
		BoardPanel.smethod_29((Control)(object)panel18, new Padding(8, 0, 8, 0));
		BoardPanel.smethod_19((Control)(object)panel18, new Size(352, 8));
		BoardPanel.smethod_20((Control)(object)panel18, 6);
		BoardPanel.smethod_15((Control)(object)panel19, (DockStyle)1);
		BoardPanel.smethod_16((Control)(object)panel19, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)panel19, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel19, "panel19");
		BoardPanel.smethod_19((Control)(object)panel19, new Size(352, 8));
		BoardPanel.smethod_20((Control)(object)panel19, 9);
		BoardPanel.smethod_1((Control)(object)panel20, BoardPanel.smethod_12());
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel20), (Control)(object)panel25);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel20), (Control)(object)panel26);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel20), (Control)(object)panel27);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel20), (Control)(object)panel28);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel20), (Control)(object)panel29);
		BoardPanel.smethod_15((Control)(object)panel20, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)panel20, new Point(8, 8));
		BoardPanel.smethod_17((Control)(object)panel20, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel20, "panel20");
		BoardPanel.smethod_19((Control)(object)panel20, new Size(320, 320));
		BoardPanel.smethod_20((Control)(object)panel20, 7);
		BoardPanel.smethod_21(tableLayoutPanel9, 1);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel9), BoardPanel.smethod_23((SizeType)2, 100f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel9, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel9, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel9, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel9, "tableLayoutPanel9");
		BoardPanel.smethod_25(tableLayoutPanel9, 8);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel9), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel9, new Size(8, 320));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel9, 0);
		BoardPanel.smethod_21(tableLayoutPanel10, 8);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel10), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel10, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel10, new Point(8, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel10, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel10, "tableLayoutPanel10");
		BoardPanel.smethod_25(tableLayoutPanel10, 1);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel10), BoardPanel.smethod_27((SizeType)2, 50f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel10, new Size(320, 8));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel10, 1);
		BoardPanel.smethod_15((Control)(object)panel21, (DockStyle)4);
		BoardPanel.smethod_16((Control)(object)panel21, new Point(328, 8));
		BoardPanel.smethod_17((Control)(object)panel21, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel21, "panel21");
		BoardPanel.smethod_19((Control)(object)panel21, new Size(8, 320));
		BoardPanel.smethod_20((Control)(object)panel21, 10);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel22), (Control)(object)tableLayoutPanel9);
		BoardPanel.smethod_15((Control)(object)panel22, (DockStyle)3);
		BoardPanel.smethod_16((Control)(object)panel22, new Point(0, 8));
		BoardPanel.smethod_17((Control)(object)panel22, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel22, "panel22");
		BoardPanel.smethod_19((Control)(object)panel22, new Size(8, 320));
		BoardPanel.smethod_20((Control)(object)panel22, 8);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel23), (Control)(object)tableLayoutPanel10);
		BoardPanel.smethod_15((Control)(object)panel23, (DockStyle)2);
		BoardPanel.smethod_16((Control)(object)panel23, new Point(0, 328));
		BoardPanel.smethod_17((Control)(object)panel23, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel23, "panel23");
		BoardPanel.smethod_29((Control)(object)panel23, new Padding(8, 0, 8, 0));
		BoardPanel.smethod_19((Control)(object)panel23, new Size(336, 8));
		BoardPanel.smethod_20((Control)(object)panel23, 6);
		BoardPanel.smethod_15((Control)(object)panel24, (DockStyle)1);
		BoardPanel.smethod_16((Control)(object)panel24, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)panel24, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel24, "panel24");
		BoardPanel.smethod_19((Control)(object)panel24, new Size(336, 8));
		BoardPanel.smethod_20((Control)(object)panel24, 9);
		BoardPanel.smethod_1((Control)(object)panel25, BoardPanel.smethod_12());
		BoardPanel.smethod_15((Control)(object)panel25, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)panel25, new Point(8, 8));
		BoardPanel.smethod_17((Control)(object)panel25, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel25, "panel25");
		BoardPanel.smethod_19((Control)(object)panel25, new Size(304, 304));
		BoardPanel.smethod_20((Control)(object)panel25, 7);
		BoardPanel.smethod_21(tableLayoutPanel11, 1);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel11), BoardPanel.smethod_23((SizeType)2, 100f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel11, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel11, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel11, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel11, "tableLayoutPanel11");
		BoardPanel.smethod_25(tableLayoutPanel11, 8);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel11), BoardPanel.smethod_27((SizeType)2, 12.5f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel11, new Size(8, 304));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel11, 0);
		BoardPanel.smethod_21(tableLayoutPanel12, 8);
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_24(BoardPanel.smethod_22(tableLayoutPanel12), BoardPanel.smethod_23((SizeType)2, 12.5f));
		BoardPanel.smethod_15((Control)(object)tableLayoutPanel12, (DockStyle)5);
		BoardPanel.smethod_16((Control)(object)tableLayoutPanel12, new Point(8, 0));
		BoardPanel.smethod_17((Control)(object)tableLayoutPanel12, new Padding(0));
		BoardPanel.smethod_18((Control)(object)tableLayoutPanel12, "tableLayoutPanel12");
		BoardPanel.smethod_25(tableLayoutPanel12, 1);
		BoardPanel.smethod_28(BoardPanel.smethod_26(tableLayoutPanel12), BoardPanel.smethod_27((SizeType)2, 50f));
		BoardPanel.smethod_19((Control)(object)tableLayoutPanel12, new Size(304, 8));
		BoardPanel.smethod_20((Control)(object)tableLayoutPanel12, 1);
		BoardPanel.smethod_15((Control)(object)panel26, (DockStyle)4);
		BoardPanel.smethod_16((Control)(object)panel26, new Point(312, 8));
		BoardPanel.smethod_17((Control)(object)panel26, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel26, "panel26");
		BoardPanel.smethod_19((Control)(object)panel26, new Size(8, 304));
		BoardPanel.smethod_20((Control)(object)panel26, 10);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel27), (Control)(object)tableLayoutPanel11);
		BoardPanel.smethod_15((Control)(object)panel27, (DockStyle)3);
		BoardPanel.smethod_16((Control)(object)panel27, new Point(0, 8));
		BoardPanel.smethod_17((Control)(object)panel27, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel27, "panel27");
		BoardPanel.smethod_19((Control)(object)panel27, new Size(8, 304));
		BoardPanel.smethod_20((Control)(object)panel27, 8);
		BoardPanel.smethod_14(BoardPanel.smethod_13((Control)(object)panel28), (Control)(object)tableLayoutPanel12);
		BoardPanel.smethod_15((Control)(object)panel28, (DockStyle)2);
		BoardPanel.smethod_16((Control)(object)panel28, new Point(0, 312));
		BoardPanel.smethod_17((Control)(object)panel28, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel28, "panel28");
		BoardPanel.smethod_29((Control)(object)panel28, new Padding(8, 0, 8, 0));
		BoardPanel.smethod_19((Control)(object)panel28, new Size(320, 8));
		BoardPanel.smethod_20((Control)(object)panel28, 6);
		BoardPanel.smethod_15((Control)(object)panel29, (DockStyle)1);
		BoardPanel.smethod_16((Control)(object)panel29, new Point(0, 0));
		BoardPanel.smethod_17((Control)(object)panel29, new Padding(0));
		BoardPanel.smethod_18((Control)(object)panel29, "panel29");
		BoardPanel.smethod_19((Control)(object)panel29, new Size(320, 8));
		BoardPanel.smethod_20((Control)(object)panel29, 9);
		BoardPanel.smethod_30((ContainerControl)(object)this, new SizeF(6f, 13f));
		BoardPanel.smethod_31((ContainerControl)(object)this, (AutoScaleMode)1);
		BoardPanel.smethod_1((Control)(object)this, BoardPanel.smethod_12());
		BoardPanel.smethod_14(BoardPanel.smethod_32((Control)(object)this), (Control)(object)centerPanel);
		BoardPanel.smethod_14(BoardPanel.smethod_32((Control)(object)this), (Control)(object)panel4);
		BoardPanel.smethod_14(BoardPanel.smethod_32((Control)(object)this), (Control)(object)panel2);
		BoardPanel.smethod_14(BoardPanel.smethod_32((Control)(object)this), (Control)(object)panel1);
		BoardPanel.smethod_14(BoardPanel.smethod_32((Control)(object)this), (Control)(object)panel3);
		BoardPanel.smethod_33((Control)(object)this, new Padding(0));
		BoardPanel.smethod_34((Control)(object)this, "BoardPanel");
		BoardPanel.smethod_35((Control)(object)this, new Size(400, 400));
		BoardPanel.smethod_36((Control)(object)centerPanel, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel1, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel2, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel5, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel7, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel8, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel10, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel12, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel13, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel15, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel17, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel18, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel20, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel22, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel23, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel27, bool_0: false);
		BoardPanel.smethod_36((Control)(object)panel28, bool_0: false);
		BoardPanel.smethod_37((Control)(object)this, bool_0: false);
	}

	static Color smethod_0(string string_0)
	{
		return ColorTranslator.FromHtml(string_0);
	}

	static void smethod_1(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static TableLayoutControlCollection smethod_2(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_Controls();
	}

	static void smethod_3(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_4(TableLayoutControlCollection tableLayoutControlCollection_0, Control control_0, int int_0, int int_1)
	{
		tableLayoutControlCollection_0.Add(control_0, int_0, int_1);
	}

	static void smethod_5(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static char smethod_6(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static void smethod_7(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Panel smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static TableLayoutPanel smethod_9()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TableLayoutPanel();
	}

	static void smethod_10(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static Color smethod_12()
	{
		return SystemColors.Control;
	}

	static ControlCollection smethod_13(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_14(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_15(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_16(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_17(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_18(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_19(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_20(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_21(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_ColumnCount(int_0);
	}

	static TableLayoutColumnStyleCollection smethod_22(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_ColumnStyles();
	}

	static ColumnStyle smethod_23(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ColumnStyle(sizeType_0, float_0);
	}

	static int smethod_24(TableLayoutColumnStyleCollection tableLayoutColumnStyleCollection_0, ColumnStyle columnStyle_0)
	{
		return tableLayoutColumnStyleCollection_0.Add(columnStyle_0);
	}

	static void smethod_25(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_RowCount(int_0);
	}

	static TableLayoutRowStyleCollection smethod_26(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_RowStyles();
	}

	static RowStyle smethod_27(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new RowStyle(sizeType_0, float_0);
	}

	static int smethod_28(TableLayoutRowStyleCollection tableLayoutRowStyleCollection_0, RowStyle rowStyle_0)
	{
		return tableLayoutRowStyleCollection_0.Add(rowStyle_0);
	}

	static void smethod_29(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Padding(padding_0);
	}

	static void smethod_30(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_31(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_32(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_33(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_34(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_35(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_36(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_37(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
