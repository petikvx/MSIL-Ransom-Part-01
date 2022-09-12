namespace SimpleChessApp.Game;

internal class DebugChess
{
	private Board b;

	internal DebugChess(Board board)
	{
		b = board;
	}

	internal void TestSinglePiece(Pieces x)
	{
		b.ClearBoard();
		if (x == Pieces.King)
		{
			b.WhiteCanCastleKingSide = false;
			b.WhiteCanCastleQueenSide = false;
		}
		b.DisableTurns = true;
		b.addWhite(4, 4, x);
		b.lights.FindAllMoves();
	}

	internal void TestPassant()
	{
		b.ClearBoard();
		b.DisableTurns = true;
		b.addWhite(1, 1, Pieces.Pawn);
		b.addWhite(3, 1, Pieces.Pawn);
		b.addWhite(5, 4, Pieces.Pawn);
		b.addBlack(2, 3, Pieces.Pawn);
		b.addBlack(4, 6, Pieces.Pawn);
		b.addBlack(6, 6, Pieces.Pawn);
		b.lights.FindAllMoves();
	}

	internal void TestPromotion()
	{
		b.ClearBoard();
		b.addBlack(4, 1, Pieces.Pawn);
		b.addWhite(4, 6, Pieces.Pawn);
		b.addBlack(3, 7, Pieces.King);
		b.addWhite(3, 0, Pieces.King);
		b.lights.FindAllMoves();
	}

	internal void TestCastling()
	{
		b.ClearBoard();
		b.DisableTurns = true;
		b.addBlack(0, 7, Pieces.Rook);
		b.addBlack(4, 7, Pieces.King);
		b.addBlack(7, 7, Pieces.Rook);
		b.addWhite(0, 0, Pieces.Rook);
		b.addWhite(4, 0, Pieces.King);
		b.addWhite(7, 0, Pieces.Rook);
		b.lights.FindAllMoves();
	}

	internal void TestDiscoverCheck()
	{
		b.ClearBoard();
		b.addWhite(4, 0, Pieces.King);
		b.addWhite(3, 1, Pieces.Pawn);
		b.addBlack(0, 4, Pieces.Bishop);
		b.lights.FindAllMoves();
	}

	internal void TestCheck()
	{
		b.ClearBoard();
		b.addBlack(4, 7, Pieces.King);
		b.addWhite(3, 0, Pieces.Bishop);
		b.lights.FindAllMoves();
	}

	internal void CheckOnCastling()
	{
		b.ClearBoard();
		b.DisableTurns = true;
		b.addBlack(0, 7, Pieces.Rook);
		b.addBlack(4, 7, Pieces.King);
		b.addBlack(7, 7, Pieces.Rook);
		b.addWhite(0, 0, Pieces.Rook);
		b.addWhite(4, 0, Pieces.King);
		b.addWhite(7, 0, Pieces.Rook);
		b.addBlack(4, 2, Pieces.Bishop);
		b.addWhite(4, 5, Pieces.Bishop);
		b.lights.FindAllMoves();
	}
}
