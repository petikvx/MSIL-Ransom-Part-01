using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleChessApp.Game;

public class Board : UserControl
{
	public Square[,] Squares = new Square[8, 8];

	public Dictionary<int, ChessPiece> WhitePieces = new Dictionary<int, ChessPiece>();

	public Dictionary<int, ChessPiece> BlackPieces = new Dictionary<int, ChessPiece>();

	public Square From;

	public MoveFinder lights;

	public bool ShowAllMoves;

	public bool ShowSelectedPieceMoves;

	public PieceColor WhosPlaying;

	public bool DisableTurns;

	public ChessPiece lastPassantPawn;

	public bool WhiteCanCastleKingSide;

	public bool BlackCanCastleKingSide;

	public bool WhiteCanCastleQueenSide;

	public bool BlackCanCastleQueenSide;

	private int idd = 0;

	public bool Flipped;

	internal static PossibleMoves lastValidPassantMove;

	private IContainer components = null;

	private TableLayoutPanel table;

	private TableLayoutPanel tableLayoutPanel5;

	private TableLayoutPanel tableLayoutPanel4;

	private TableLayoutPanel tableLayoutPanel7;

	private TableLayoutPanel tableLayoutPanel6;

	private TableLayoutPanel tableLayoutPanel1;

	private TableLayoutPanel tableLayoutPanel2;

	private TableLayoutPanel tableLayoutPanel3;

	public int id => ++idd;

	public Square this[int File, int Rank] => Squares[File, Rank];

	public Square this[Square x] => Squares[x.File, x.Rank];

	public Board()
	{
		InitializeComponent();
	}

	public Board(Panel p, ImageLayout layout = 2, bool flipped = false, bool allMoves = false, bool selected = false)
		: this()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		ShowSelectedPieceMoves = selected;
		ShowAllMoves = allMoves;
		Flipped = flipped;
		Board.smethod_0((Control)(object)this, (DockStyle)5);
		lights = new MoveFinder(this);
		build(layout, flipped);
		Board.smethod_2(Board.smethod_1((Control)(object)p), (Control)(object)this);
	}

	private void build(ImageLayout layout, bool flipped)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		int num = (flipped ? 1 : 0);
		Board.smethod_4((ControlCollection)(object)Board.smethod_3(table));
		for (int i = 0; i < 8; i++)
		{
			bool isBlackSquare = num++ % 2 == 0;
			for (int j = 0; j < 8; j++)
			{
				Square square = new Square(j, i, this);
				Board.smethod_0((Control)(object)square, (DockStyle)5);
				square.IsBlackSquare = isBlackSquare;
				Board.smethod_5((Control)(object)square, layout);
				isBlackSquare = num++ % 2 == 0;
				Squares[j, i] = square;
				Board.smethod_6(Board.smethod_3(table), (Control)(object)square, j, flipped ? i : (7 - i));
			}
		}
		Restart();
	}

	internal void Restart()
	{
		ClearBoard();
		setBlackPieces();
		setWhitePieces();
		lights.FindAllMoves();
	}

	internal void ClearBoard()
	{
		idd = 0;
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				Squares[i, j].Piece = null;
			}
		}
		if (From != null)
		{
			From.ClearHighLight();
		}
		From = null;
		if (lights == null)
		{
			lights = new MoveFinder(this);
		}
		lights.Clear();
		lastPassantPawn = null;
		WhosPlaying = PieceColor.White;
		DisableTurns = false;
		WhiteCanCastleKingSide = true;
		BlackCanCastleKingSide = true;
		WhiteCanCastleQueenSide = true;
		BlackCanCastleQueenSide = true;
		WhitePieces.Clear();
		BlackPieces.Clear();
	}

	private void setBlackPieces()
	{
		for (int i = 0; i < 8; i++)
		{
			addBlack(i, 6, Pieces.Pawn);
		}
		addBlack(0, 7, Pieces.Rook);
		addBlack(1, 7, Pieces.Knight);
		addBlack(2, 7, Pieces.Bishop);
		addBlack(3, 7, Pieces.Queen);
		addBlack(4, 7, Pieces.King);
		addBlack(5, 7, Pieces.Bishop);
		addBlack(6, 7, Pieces.Knight);
		addBlack(7, 7, Pieces.Rook);
	}

	private void setWhitePieces()
	{
		for (int i = 0; i < 8; i++)
		{
			addWhite(i, 1, Pieces.Pawn);
		}
		addWhite(0, 0, Pieces.Rook);
		addWhite(1, 0, Pieces.Knight);
		addWhite(2, 0, Pieces.Bishop);
		addWhite(3, 0, Pieces.Queen);
		addWhite(4, 0, Pieces.King);
		addWhite(5, 0, Pieces.Bishop);
		addWhite(6, 0, Pieces.Knight);
		addWhite(7, 0, Pieces.Rook);
	}

	private void add(int v1, int v2, Pieces p, PieceColor c)
	{
		Square square = this[v1, v2];
		square.Piece = new ChessPiece(square, p, c);
		if (c == PieceColor.White)
		{
			WhitePieces.Add(square.Piece.Id, square.Piece);
			lights.MoveList.Add(square.Piece.Id, new List<PossibleMoves>());
		}
		if (c == PieceColor.Black)
		{
			BlackPieces.Add(square.Piece.Id, square.Piece);
			lights.MoveList.Add(square.Piece.Id, new List<PossibleMoves>());
		}
	}

	internal void ShowPieceMoves(Square to)
	{
		if (!ShowSelectedPieceMoves)
		{
			return;
		}
		foreach (PossibleMoves item in lights.MoveList[to.Piece.Id])
		{
			item.Square.ShowSelectedPieceMoves();
		}
	}

	internal void HidePieceMoves(Square to)
	{
		if (!ShowSelectedPieceMoves)
		{
			return;
		}
		foreach (PossibleMoves item in lights.MoveList[to.Piece.Id])
		{
			item.Square.HideMove();
		}
	}

	public void addWhite(int v1, int v2, Pieces p)
	{
		add(v1, v2, p, PieceColor.White);
	}

	public void addBlack(int v1, int v2, Pieces p)
	{
		add(v1, v2, p, PieceColor.Black);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Board.smethod_7((IDisposable)components);
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		table = Board.smethod_8();
		tableLayoutPanel1 = Board.smethod_8();
		tableLayoutPanel2 = Board.smethod_8();
		tableLayoutPanel3 = Board.smethod_8();
		tableLayoutPanel4 = Board.smethod_8();
		tableLayoutPanel5 = Board.smethod_8();
		tableLayoutPanel6 = Board.smethod_8();
		tableLayoutPanel7 = Board.smethod_8();
		Board.smethod_9((Control)(object)table);
		Board.smethod_9((Control)(object)tableLayoutPanel1);
		Board.smethod_9((Control)(object)tableLayoutPanel2);
		Board.smethod_9((Control)(object)tableLayoutPanel4);
		Board.smethod_10((Control)(object)this);
		Board.smethod_11(table, 8);
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(table), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_6(Board.smethod_3(table), (Control)(object)tableLayoutPanel5, 0, 7);
		Board.smethod_6(Board.smethod_3(table), (Control)(object)tableLayoutPanel4, 0, 7);
		Board.smethod_6(Board.smethod_3(table), (Control)(object)tableLayoutPanel1, 0, 0);
		Board.smethod_0((Control)(object)table, (DockStyle)5);
		Board.smethod_15((Control)(object)table, new Point(0, 0));
		Board.smethod_16((Control)(object)table, new Padding(0));
		Board.smethod_17((Control)(object)table, "table");
		Board.smethod_18((Control)(object)table, (RightToLeft)0);
		Board.smethod_19(table, 8);
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(table), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)table, new Size(346, 353));
		Board.smethod_24((Control)(object)table, 1);
		Board.smethod_11(tableLayoutPanel1, 8);
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel1), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_6(Board.smethod_3(tableLayoutPanel1), (Control)(object)tableLayoutPanel2, 0, 0);
		Board.smethod_0((Control)(object)tableLayoutPanel1, (DockStyle)5);
		Board.smethod_15((Control)(object)tableLayoutPanel1, new Point(0, 0));
		Board.smethod_16((Control)(object)tableLayoutPanel1, new Padding(0));
		Board.smethod_17((Control)(object)tableLayoutPanel1, "tableLayoutPanel1");
		Board.smethod_18((Control)(object)tableLayoutPanel1, (RightToLeft)0);
		Board.smethod_19(tableLayoutPanel1, 8);
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel1), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)tableLayoutPanel1, new Size(43, 44));
		Board.smethod_24((Control)(object)tableLayoutPanel1, 1);
		Board.smethod_11(tableLayoutPanel2, 8);
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel2), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_6(Board.smethod_3(tableLayoutPanel2), (Control)(object)tableLayoutPanel3, 0, 0);
		Board.smethod_0((Control)(object)tableLayoutPanel2, (DockStyle)5);
		Board.smethod_15((Control)(object)tableLayoutPanel2, new Point(0, 0));
		Board.smethod_16((Control)(object)tableLayoutPanel2, new Padding(0));
		Board.smethod_17((Control)(object)tableLayoutPanel2, "tableLayoutPanel2");
		Board.smethod_18((Control)(object)tableLayoutPanel2, (RightToLeft)0);
		Board.smethod_19(tableLayoutPanel2, 8);
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel2), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)tableLayoutPanel2, new Size(5, 5));
		Board.smethod_24((Control)(object)tableLayoutPanel2, 1);
		Board.smethod_11(tableLayoutPanel3, 8);
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel3), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_0((Control)(object)tableLayoutPanel3, (DockStyle)5);
		Board.smethod_15((Control)(object)tableLayoutPanel3, new Point(0, 0));
		Board.smethod_16((Control)(object)tableLayoutPanel3, new Padding(0));
		Board.smethod_17((Control)(object)tableLayoutPanel3, "tableLayoutPanel3");
		Board.smethod_18((Control)(object)tableLayoutPanel3, (RightToLeft)0);
		Board.smethod_19(tableLayoutPanel3, 8);
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel3), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)tableLayoutPanel3, new Size(1, 1));
		Board.smethod_24((Control)(object)tableLayoutPanel3, 1);
		Board.smethod_11(tableLayoutPanel4, 8);
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel4), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_6(Board.smethod_3(tableLayoutPanel4), (Control)(object)tableLayoutPanel7, 0, 7);
		Board.smethod_6(Board.smethod_3(tableLayoutPanel4), (Control)(object)tableLayoutPanel6, 0, 0);
		Board.smethod_0((Control)(object)tableLayoutPanel4, (DockStyle)5);
		Board.smethod_15((Control)(object)tableLayoutPanel4, new Point(43, 308));
		Board.smethod_16((Control)(object)tableLayoutPanel4, new Padding(0));
		Board.smethod_17((Control)(object)tableLayoutPanel4, "tableLayoutPanel4");
		Board.smethod_18((Control)(object)tableLayoutPanel4, (RightToLeft)0);
		Board.smethod_19(tableLayoutPanel4, 8);
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel4), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)tableLayoutPanel4, new Size(43, 45));
		Board.smethod_24((Control)(object)tableLayoutPanel4, 2);
		Board.smethod_11(tableLayoutPanel5, 8);
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel5), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_0((Control)(object)tableLayoutPanel5, (DockStyle)5);
		Board.smethod_15((Control)(object)tableLayoutPanel5, new Point(0, 308));
		Board.smethod_16((Control)(object)tableLayoutPanel5, new Padding(0));
		Board.smethod_17((Control)(object)tableLayoutPanel5, "tableLayoutPanel5");
		Board.smethod_18((Control)(object)tableLayoutPanel5, (RightToLeft)0);
		Board.smethod_19(tableLayoutPanel5, 8);
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel5), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)tableLayoutPanel5, new Size(43, 45));
		Board.smethod_24((Control)(object)tableLayoutPanel5, 3);
		Board.smethod_11(tableLayoutPanel6, 8);
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel6), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_0((Control)(object)tableLayoutPanel6, (DockStyle)5);
		Board.smethod_15((Control)(object)tableLayoutPanel6, new Point(0, 0));
		Board.smethod_16((Control)(object)tableLayoutPanel6, new Padding(0));
		Board.smethod_17((Control)(object)tableLayoutPanel6, "tableLayoutPanel6");
		Board.smethod_18((Control)(object)tableLayoutPanel6, (RightToLeft)0);
		Board.smethod_19(tableLayoutPanel6, 8);
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel6), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)tableLayoutPanel6, new Size(5, 5));
		Board.smethod_24((Control)(object)tableLayoutPanel6, 1);
		Board.smethod_11(tableLayoutPanel7, 8);
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_14(Board.smethod_12(tableLayoutPanel7), Board.smethod_13((SizeType)2, 12.5f));
		Board.smethod_0((Control)(object)tableLayoutPanel7, (DockStyle)5);
		Board.smethod_15((Control)(object)tableLayoutPanel7, new Point(0, 35));
		Board.smethod_16((Control)(object)tableLayoutPanel7, new Padding(0));
		Board.smethod_17((Control)(object)tableLayoutPanel7, "tableLayoutPanel7");
		Board.smethod_18((Control)(object)tableLayoutPanel7, (RightToLeft)0);
		Board.smethod_19(tableLayoutPanel7, 8);
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_22(Board.smethod_20(tableLayoutPanel7), Board.smethod_21((SizeType)2, 12.5f));
		Board.smethod_23((Control)(object)tableLayoutPanel7, new Size(5, 10));
		Board.smethod_24((Control)(object)tableLayoutPanel7, 2);
		Board.smethod_25((ContainerControl)(object)this, new SizeF(6f, 13f));
		Board.smethod_26((ContainerControl)(object)this, (AutoScaleMode)1);
		Board.smethod_2(Board.smethod_27((Control)(object)this), (Control)(object)table);
		Board.smethod_28((Control)(object)this, "Board");
		Board.smethod_18((Control)(object)this, (RightToLeft)1);
		Board.smethod_29((Control)(object)this, new Size(346, 353));
		Board.smethod_30((Control)(object)table, bool_0: false);
		Board.smethod_30((Control)(object)tableLayoutPanel1, bool_0: false);
		Board.smethod_30((Control)(object)tableLayoutPanel2, bool_0: false);
		Board.smethod_30((Control)(object)tableLayoutPanel4, bool_0: false);
		Board.smethod_31((Control)(object)this, bool_0: false);
	}

	static void smethod_0(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static ControlCollection smethod_1(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_2(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static TableLayoutControlCollection smethod_3(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_Controls();
	}

	static void smethod_4(ControlCollection controlCollection_0)
	{
		controlCollection_0.Clear();
	}

	static void smethod_5(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_6(TableLayoutControlCollection tableLayoutControlCollection_0, Control control_0, int int_0, int int_1)
	{
		tableLayoutControlCollection_0.Add(control_0, int_0, int_1);
	}

	static void smethod_7(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static TableLayoutPanel smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TableLayoutPanel();
	}

	static void smethod_9(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_10(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_11(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_ColumnCount(int_0);
	}

	static TableLayoutColumnStyleCollection smethod_12(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_ColumnStyles();
	}

	static ColumnStyle smethod_13(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new ColumnStyle(sizeType_0, float_0);
	}

	static int smethod_14(TableLayoutColumnStyleCollection tableLayoutColumnStyleCollection_0, ColumnStyle columnStyle_0)
	{
		return tableLayoutColumnStyleCollection_0.Add(columnStyle_0);
	}

	static void smethod_15(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_16(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_17(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_18(Control control_0, RightToLeft rightToLeft_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_RightToLeft(rightToLeft_0);
	}

	static void smethod_19(TableLayoutPanel tableLayoutPanel_0, int int_0)
	{
		tableLayoutPanel_0.set_RowCount(int_0);
	}

	static TableLayoutRowStyleCollection smethod_20(TableLayoutPanel tableLayoutPanel_0)
	{
		return tableLayoutPanel_0.get_RowStyles();
	}

	static RowStyle smethod_21(SizeType sizeType_0, float float_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new RowStyle(sizeType_0, float_0);
	}

	static int smethod_22(TableLayoutRowStyleCollection tableLayoutRowStyleCollection_0, RowStyle rowStyle_0)
	{
		return tableLayoutRowStyleCollection_0.Add(rowStyle_0);
	}

	static void smethod_23(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_24(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_25(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_26(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_27(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_28(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_29(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_30(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}

	static void smethod_31(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
