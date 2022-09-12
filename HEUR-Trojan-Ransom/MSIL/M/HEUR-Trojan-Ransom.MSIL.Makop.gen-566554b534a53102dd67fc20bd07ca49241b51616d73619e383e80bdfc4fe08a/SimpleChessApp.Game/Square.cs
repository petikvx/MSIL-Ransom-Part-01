using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using SimpleChessApp.Extras;

namespace SimpleChessApp.Game;

[ToolboxItem(false)]
public class Square : SimpleSquare
{
	public int File;

	public int Rank;

	public string Name;

	public Board Board;

	private string msg;

	private IContainer components = null;

	public string SpecialName => Square.smethod_26(CurrentSquare, " ", Square.smethod_25((object)base.Piece));

	public string CurrentSquare => Square.smethod_28(Square.smethod_27("abcdefgh", File).ToString(), (Rank + 1).ToString());

	public static event EventHandler Action
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Square.Action;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Square.smethod_23((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref Square.Action, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Square.Action;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Square.smethod_24((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref Square.Action, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public static void action(string msg)
	{
		Square.Action?.Invoke(msg, null);
	}

	public Square(int file, int rank, Board Board)
		: this()
	{
		this.Board = Board;
		File = file;
		Rank = rank;
		Name = Square.smethod_28(Square.smethod_27("abcdefgh", file).ToString(), (Rank + 1).ToString());
	}

	public Square()
	{
		InitializeComponent();
		base.Click += Square_MouseClick;
	}

	private void SwitchPlayer()
	{
		if (!Board.DisableTurns)
		{
			if (Board.WhosPlaying == PieceColor.White)
			{
				Board.WhosPlaying = PieceColor.Black;
			}
			else
			{
				Board.WhosPlaying = PieceColor.White;
			}
		}
	}

	private bool getSide(Square x)
	{
		return Board.DisableTurns || Board.WhosPlaying == x.Piece.Color;
	}

	private void Square_MouseClick(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)Square.smethod_29(e) == 1048576)
		{
			bool flag = Board.From != null && Board.From.Piece != null;
			if (!(Piece == null && flag))
			{
				if (flag)
				{
					if (Piece.Color != Board.From.Piece.Color)
					{
						msg = "Pedra oposta";
						List<PossibleMoves> list = Board.lights.MoveList[Board.From.Piece.Id];
						if (!list.Exists((PossibleMoves t) => t.Square == this))
						{
							if (Board.DisableTurns)
							{
								hideMoves(Board.From);
								Board.From.ClearHighLight();
								HighLight();
								Board.From = this;
								msg = "Seleção";
								Board.ShowPieceMoves(this);
							}
						}
						else
						{
							msg = "Captura";
							Board.From.ClearHighLight();
							CaptPawn(Board.From);
						}
					}
					else if (getSide(Board.From))
					{
						if (Piece.Id != Board.From.Piece.Id)
						{
							if (Board.From.Piece.Color == Piece.Color)
							{
								hideMoves(Board.From);
								HighLight();
								Board.From = this;
								msg = "Seleção (próxima peça)";
								Board.ShowPieceMoves(this);
							}
						}
						else
						{
							Board.From.ClearHighLight();
							HighLight();
							msg = "Mesma peça";
							Board.ShowPieceMoves(this);
						}
					}
				}
				else if (Piece == null || !getSide(this))
				{
					msg = "Pedra oposta";
				}
				else
				{
					HighLight();
					Board.From = this;
					msg = "Seleção";
					Board.ShowPieceMoves(this);
				}
			}
			else
			{
				List<PossibleMoves> list2 = Board.lights.MoveList[Board.From.Piece.Id];
				msg = Square.smethod_30("Movimento inválido: {0}", (object)list2.Count);
				Board.From.ClearHighLight();
				if (list2.Exists((PossibleMoves t) => t.Square == this))
				{
					msg = "Movimento permitido!";
					if (Board.From.Piece.Kind != Pieces.Pawn)
					{
					}
					MovePawn(Board.From);
				}
				else
				{
					Board.HidePieceMoves(Board.From);
					Board.From = null;
				}
			}
		}
		action(msg);
	}

	private void hideMoves(Square to)
	{
		if (Board.From != null)
		{
			Board.From.ClearHighLight();
			Board.HidePieceMoves(to);
		}
	}

	private void CaptPawn(Square from)
	{
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		if (base.Piece.Color == PieceColor.White)
		{
			Board.WhitePieces.Remove(base.Piece.Id);
		}
		else
		{
			Board.BlackPieces.Remove(base.Piece.Id);
		}
		if (from.Piece.Color == PieceColor.White)
		{
			Board.WhitePieces[from.Piece.Id].Current = this;
		}
		else
		{
			Board.BlackPieces[from.Piece.Id].Current = this;
		}
		base.Piece = from.Piece;
		bool flag = false;
		if (base.Piece.Color == PieceColor.White)
		{
			Board.WhitePieces[base.Piece.Id].Current = this;
			handleWhiteCastling();
			if (base.Piece.Kind == Pieces.Pawn && base.Piece.Current.Rank == 7)
			{
				flag = true;
			}
		}
		if (base.Piece.Color == PieceColor.Black)
		{
			Board.BlackPieces[base.Piece.Id].Current = this;
			handleBlackCastling();
			if (base.Piece.Kind == Pieces.Pawn && base.Piece.Current.Rank == 0)
			{
				flag = true;
			}
		}
		from.Piece = null;
		if (flag)
		{
			Promotion promotion = new Promotion(Square.smethod_31());
			try
			{
				Square.smethod_32((Form)(object)promotion);
				base.Kind = promotion.Piece;
			}
			finally
			{
				if (promotion != null)
				{
					Square.smethod_33((IDisposable)promotion);
				}
			}
		}
		Board.lights.FindAllMoves();
		PlaySound.Play();
		SwitchPlayer();
	}

	private void MovePawn(Square from)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		ChessPiece chessPiece = null;
		base.Piece = from.Piece;
		Board.lastPassantPawn = null;
		if (base.Piece.Kind == Pieces.Pawn && (Rank == 3 || Rank == 4))
		{
			Board.lastPassantPawn = base.Piece;
		}
		bool flag = false;
		bool flag2;
		if (!(flag2 = base.Piece.Color == PieceColor.White))
		{
			Board.BlackPieces[base.Piece.Id].Current = this;
			chessPiece = handleBlackCastling();
			if (base.Piece.Kind == Pieces.Pawn && base.Piece.Current.Rank == 0)
			{
				flag = true;
			}
		}
		else
		{
			Board.WhitePieces[base.Piece.Id].Current = this;
			chessPiece = handleWhiteCastling();
			if (base.Piece.Kind == Pieces.Pawn && base.Piece.Current.Rank == 7)
			{
				flag = true;
			}
		}
		from.Piece = null;
		if (flag)
		{
			Promotion promotion = new Promotion(Square.smethod_31());
			try
			{
				Square.smethod_32((Form)(object)promotion);
				base.Kind = promotion.Piece;
			}
			finally
			{
				if (promotion != null)
				{
					Square.smethod_33((IDisposable)promotion);
				}
			}
		}
		Board.lights.IsOnCheck = false;
		Board.lights.FindAllMoves();
		if (Board.lights.IsOnCheck)
		{
			if (Board.lights.KingColorOnCheck != base.Piece.Color)
			{
				msg = "Cheque";
			}
			else
			{
				bool flag3 = true;
				if (base.Piece.Kind == Pieces.King)
				{
					flag3 = Board.lights.IsOnCheck;
				}
				if (flag3)
				{
					from.Piece = base.Piece;
					base.Piece = null;
					msg = "Inválido! O rei está em cheque 1";
					if (!flag2)
					{
						Board.BlackPieces[from.Piece.Id].Current = from;
					}
					else
					{
						Board.WhitePieces[from.Piece.Id].Current = from;
					}
					if (chessPiece != null)
					{
						int file = chessPiece.Current.File;
						int rank = chessPiece.Current.Rank;
						Square square = ((file == 5) ? Board[7, rank] : Board[0, rank]);
						square.Piece = chessPiece;
						if (flag2)
						{
							Board.WhitePieces[chessPiece.Id].Current = square;
							Board.WhiteCanCastleQueenSide = true;
							Board.WhiteCanCastleKingSide = true;
						}
						else
						{
							Board.BlackPieces[chessPiece.Id].Current = square;
							Board.BlackCanCastleQueenSide = true;
							Board.BlackCanCastleKingSide = true;
						}
						Board[file, rank].Piece = null;
					}
					Board.lights.FindAllMoves();
					return;
				}
			}
		}
		PlaySound.Play();
		SwitchPlayer();
	}

	private ChessPiece handleBlackCastling()
	{
		ChessPiece result = null;
		if ((Board.BlackCanCastleKingSide || Board.BlackCanCastleQueenSide) && (base.Piece.Kind == Pieces.King || base.Piece.Kind == Pieces.Rook))
		{
			if (base.Piece.Kind != Pieces.Rook)
			{
				if (base.Piece.Current.File == 2)
				{
					Square square = Board[3, 7];
					square.Piece = Board[0, 7].Piece;
					Board[0, 7].Piece = null;
					Board.BlackPieces[square.Piece.Id].Current = square;
					result = square.Piece;
				}
				if (base.Piece.Current.File == 6)
				{
					Square square2 = Board[5, 7];
					square2.Piece = Board[7, 7].Piece;
					Board[7, 7].Piece = null;
					Board.BlackPieces[square2.Piece.Id].Current = square2;
					result = square2.Piece;
				}
				Board.BlackCanCastleQueenSide = false;
				Board.BlackCanCastleKingSide = false;
			}
			else if (Square.smethod_34(base.Piece.Home.Name, "a8"))
			{
				Board.BlackCanCastleQueenSide = false;
			}
			else
			{
				Board.BlackCanCastleKingSide = false;
			}
		}
		return result;
	}

	private ChessPiece handleWhiteCastling()
	{
		ChessPiece result = null;
		if ((Board.WhiteCanCastleKingSide || Board.WhiteCanCastleKingSide) && (base.Piece.Kind == Pieces.King || base.Piece.Kind == Pieces.Rook))
		{
			if (base.Piece.Kind == Pieces.Rook)
			{
				if (Square.smethod_34(base.Piece.Home.Name, "a1"))
				{
					Board.WhiteCanCastleQueenSide = false;
				}
				else
				{
					Board.WhiteCanCastleKingSide = false;
				}
			}
			else
			{
				if (base.Piece.Current.File == 2)
				{
					Square square = Board[3, 0];
					square.Piece = Board[0, 0].Piece;
					Board[0, 0].Piece = null;
					Board.WhitePieces[square.Piece.Id].Current = square;
					result = square.Piece;
				}
				if (base.Piece.Current.File == 6)
				{
					Square square2 = Board[5, 0];
					square2.Piece = Board[7, 0].Piece;
					Board[7, 0].Piece = null;
					Board.WhitePieces[square2.Piece.Id].Current = square2;
					result = square2.Piece;
				}
				Board.WhiteCanCastleQueenSide = false;
				Board.WhiteCanCastleKingSide = false;
			}
		}
		return result;
	}

	public void ShowAllMoves()
	{
	}

	public void ShowSelectedPieceMoves()
	{
	}

	public void HideMove()
	{
		Square.smethod_35((Control)(object)panel1, (Image)null);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			Square.smethod_33((IDisposable)components);
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Square.smethod_36((Control)(object)this);
		Square.smethod_37((ContainerControl)(object)this, new SizeF(6f, 13f));
		Square.smethod_38((ContainerControl)(object)this, (AutoScaleMode)1);
		Square.smethod_39((Control)(object)this, (ImageLayout)2);
		Square.smethod_40((Control)(object)this, new Padding(0));
		Name = "Square";
		Square.smethod_41((Control)(object)this, new Size(137, 132));
		Square.smethod_42((Control)(object)this, bool_0: false);
	}

	static Delegate smethod_23(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_24(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static string smethod_25(object object_0)
	{
		return object_0.ToString();
	}

	static string smethod_26(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static char smethod_27(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static string smethod_28(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static MouseButtons smethod_29(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return mouseEventArgs_0.get_Button();
	}

	static string smethod_30(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	static Point smethod_31()
	{
		return Cursor.get_Position();
	}

	static DialogResult smethod_32(Form form_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return form_0.ShowDialog();
	}

	static void smethod_33(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static bool smethod_34(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_35(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_36(Control control_0)
	{
		control_0.SuspendLayout();
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

	static void smethod_39(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_40(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_41(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_42(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
