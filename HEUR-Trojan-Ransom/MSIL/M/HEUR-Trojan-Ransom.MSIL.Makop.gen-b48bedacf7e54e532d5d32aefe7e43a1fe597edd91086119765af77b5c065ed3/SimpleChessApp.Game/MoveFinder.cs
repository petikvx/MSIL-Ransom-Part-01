using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SimpleChessApp.Game;

public class MoveFinder
{
	public Dictionary<int, List<PossibleMoves>> MoveList = new Dictionary<int, List<PossibleMoves>>();

	private Board board;

	public PieceColor KingColorOnCheck;

	public bool IsOnCheck;

	public MoveFinder(Board b)
	{
		board = b;
	}

	public void FindAllMoves()
	{
		Clear();
		foreach (ChessPiece value in board.WhitePieces.Values)
		{
			FindMoveFrom(value.Current);
		}
		foreach (ChessPiece value2 in board.BlackPieces.Values)
		{
			FindMoveFrom(value2.Current);
		}
		if (board.ShowAllMoves)
		{
			HighLightMoveStyle();
		}
	}

	public void FindMoveFrom(Square x)
	{
		switch (x.Piece.Kind)
		{
		case Pieces.Pawn:
			handlePawn(x);
			break;
		case Pieces.Knight:
			handleKnight(x);
			break;
		case Pieces.Bishop:
			handleBishop(x);
			break;
		case Pieces.Rook:
			handleRook(x);
			break;
		case Pieces.King:
			handleKing(x);
			break;
		case Pieces.Queen:
			handleQueen(x);
			break;
		}
	}

	public void HighLightMoveStyle()
	{
	}

	public void Clear()
	{
	}

	private void handlePawn(Square x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = ((x.Piece.Color == PieceColor.White) ? 1 : 6);
		int num4 = ((x.Piece.Color == PieceColor.White) ? 1 : (-1));
		num = x.File;
		num2 = x.Rank + num4;
		if (num2 >= 0 && num2 < 8)
		{
			Square square = board[num, num2];
			if (square.IsEmpty)
			{
				addMove(num, num2, x);
			}
		}
		bool flag = x.Rank == 4 && x.Piece.Color == PieceColor.White;
		bool flag2 = x.Rank == 3 && x.Piece.Color == PieceColor.Black;
		int b = (flag ? 5 : 2);
		if (flag || flag2)
		{
			int num5 = x.File - 1;
			int num6 = x.File + 1;
			if (num5 >= 0 && board[num5, x.Rank].Piece != null && board[num5, x.Rank].Piece.Kind == Pieces.Pawn && board[num5, x.Rank].Piece.Color != x.Piece.Color && board.lastPassantPawn == board[num5, x.Rank].Piece)
			{
				addCapture(num5, b, x, board[num5, x.Rank].Piece);
			}
			if (num6 < 8 && board[num6, x.Rank].Piece != null && board[num6, x.Rank].Piece.Kind == Pieces.Pawn && board[num6, x.Rank].Piece.Color != x.Piece.Color && board.lastPassantPawn == board[num6, x.Rank].Piece)
			{
				addCapture(num6, b, x, board[num6, x.Rank].Piece);
			}
		}
		if (x.Rank == num3)
		{
			num2 = x.Rank + 2 * num4;
			addMove(num, num2, x);
		}
		num = x.File - 1;
		num2 = x.Rank + num4;
		if (num >= 0 && num2 >= 0 && num2 < 8)
		{
			Square square = board[num, num2];
			if (!square.IsEmpty)
			{
				addMove(num, num2, x);
			}
		}
		num = x.File + 1;
		num2 = x.Rank + num4;
		if (num < 8 && num2 >= 0 && num2 < 8)
		{
			Square square = board[num, num2];
			if (!square.IsEmpty)
			{
				addMove(num, num2, x);
			}
		}
	}

	private void handleQueen(Square x)
	{
		handleRook(x);
		handleBishop(x);
	}

	private void handleKing(Square x)
	{
		addMove(x.File + 1, x.Rank + 1, x);
		addMove(x.File + 1, x.Rank - 1, x);
		addMove(x.File - 1, x.Rank + 1, x);
		addMove(x.File - 1, x.Rank - 1, x);
		addMove(x.File + 1, x.Rank, x);
		addMove(x.File - 1, x.Rank, x);
		addMove(x.File, x.Rank + 1, x);
		addMove(x.File, x.Rank - 1, x);
		if (x.Piece.Color == PieceColor.White)
		{
			if (board.WhiteCanCastleKingSide)
			{
				handleSmallCastling(x);
			}
			if (board.WhiteCanCastleQueenSide)
			{
				handleBigCastling(x);
			}
		}
		if (x.Piece.Color == PieceColor.Black)
		{
			if (board.BlackCanCastleKingSide)
			{
				handleSmallCastling(x);
			}
			if (board.BlackCanCastleQueenSide)
			{
				handleBigCastling(x);
			}
		}
	}

	private void handleBigCastling(Square x)
	{
		Square square = board[x.File - 1, x.Rank];
		Square square2 = board[x.File - 2, x.Rank];
		Square square3 = board[x.File - 3, x.Rank];
		if (square.IsEmpty && square2.IsEmpty && square3.IsEmpty)
		{
			addMove(x.File - 2, x.Rank, x);
		}
	}

	private void handleSmallCastling(Square x)
	{
		Square square = board[x.File + 1, x.Rank];
		Square square2 = board[x.File + 2, x.Rank];
		if (square.IsEmpty && square2.IsEmpty)
		{
			addMove(x.File + 2, x.Rank, x);
		}
	}

	private void handleRook(Square x)
	{
		for (int i = 1; i < 8; i++)
		{
			int b = x.Rank + i;
			if (addMove(x.File, b, x))
			{
				break;
			}
		}
		for (int j = 1; j < 8; j++)
		{
			int b2 = x.Rank - j;
			if (addMove(x.File, b2, x))
			{
				break;
			}
		}
		for (int k = 1; k < 8; k++)
		{
			int a = x.File + k;
			if (addMove(a, x.Rank, x))
			{
				break;
			}
		}
		for (int l = 1; l < 8; l++)
		{
			int a2 = x.File - l;
			if (addMove(a2, x.Rank, x))
			{
				break;
			}
		}
	}

	private void handleBishop(Square x)
	{
		for (int i = 1; i < 8; i++)
		{
			int a = x.File + i;
			int b = x.Rank + i;
			if (addMove(a, b, x))
			{
				break;
			}
		}
		for (int j = 1; j < 8; j++)
		{
			int a2 = x.File + j;
			int b2 = x.Rank - j;
			if (addMove(a2, b2, x))
			{
				break;
			}
		}
		for (int k = 1; k < 8; k++)
		{
			int a3 = x.File - k;
			int b3 = x.Rank - k;
			if (addMove(a3, b3, x))
			{
				break;
			}
		}
		for (int l = 1; l < 8; l++)
		{
			int a4 = x.File - l;
			int b4 = x.Rank + l;
			if (addMove(a4, b4, x))
			{
				break;
			}
		}
	}

	private void handleKnight(Square x)
	{
		ChessPiece piece = x.Piece;
		int[] array = new int[8];
		MoveFinder.smethod_0((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array2 = array;
		int[] array3 = new int[8];
		MoveFinder.smethod_0((Array)array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array4 = array3;
		for (int i = 0; i < 8; i++)
		{
			int num = x.File + array2[i];
			int num2 = x.Rank + array4[i];
			if (num >= 0 && num2 >= 0 && num <= 7 && num2 <= 7)
			{
				Square square = board[num, num2];
				if (square.IsEmpty)
				{
					MoveList[piece.Id].Add(new PossibleMoves(piece, square, UserAction.Move));
				}
				else if (square.Piece.Color != x.Piece.Color)
				{
					MoveList[piece.Id].Add(new PossibleMoves(piece, square, UserAction.Capture));
				}
			}
		}
	}

	private void addCapture(int a, int b, Square x, ChessPiece pawn)
	{
		ChessPiece piece = x.Piece;
		Square sq = board[a, b];
		Board.lastValidPassantMove = new PossibleMoves(piece, sq, UserAction.Capture);
		MoveList[piece.Id].Add(Board.lastValidPassantMove);
	}

	private bool addMove(int a, int b, Square x)
	{
		if (a < 0 || a > 7 || b < 0 || b > 7)
		{
			return true;
		}
		ChessPiece piece = x.Piece;
		Square square = board[a, b];
		if (square.IsEmpty)
		{
			MoveList[piece.Id].Add(new PossibleMoves(piece, square, UserAction.Move));
			return false;
		}
		if (square.Piece.Color == x.Piece.Color)
		{
			return true;
		}
		UserAction kind = UserAction.Capture;
		if (square.Piece.Kind == Pieces.King && x.Piece.Kind != Pieces.King && x.Piece.Kind != Pieces.Pawn)
		{
			KingColorOnCheck = square.Piece.Color;
			IsOnCheck = true;
		}
		MoveList[piece.Id].Add(new PossibleMoves(piece, square, kind));
		return true;
	}

	static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
