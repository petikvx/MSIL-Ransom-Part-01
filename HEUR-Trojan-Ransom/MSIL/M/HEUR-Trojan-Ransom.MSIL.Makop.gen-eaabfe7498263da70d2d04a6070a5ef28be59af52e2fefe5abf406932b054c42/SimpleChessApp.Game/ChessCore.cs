namespace SimpleChessApp.Game;

public class ChessCore
{
	public Board ChessBoard;

	public PieceColor WhosPlaying;

	public bool DisableTurn;

	public int TurnId = 1;

	public Square lastCheckPiece;

	public Square ghostCheckPiece;

	public Square LastMove;

	public NotationManager Turns = new NotationManager();

	public bool firstClick = true;

	public Square lastSquare;

	public ChessCore(Board b)
	{
		ChessBoard = b;
		resetFlags();
	}

	public ChessCore()
	{
	}

	public void RestartGame()
	{
		resetFlags();
		ChessBoard.Restart();
	}

	private void resetFlags(bool turn = false)
	{
		DisableTurn = turn;
		WhosPlaying = PieceColor.White;
		TurnId = 1;
		lastCheckPiece = null;
		Turns.Clear();
	}

	internal void TestPassant()
	{
		new DebugChess(ChessBoard).TestPassant();
		resetFlags(turn: true);
	}

	internal void TestSinglePiece(Pieces x)
	{
		new DebugChess(ChessBoard).TestSinglePiece(x);
		resetFlags(turn: true);
	}

	internal void TestCastling()
	{
		new DebugChess(ChessBoard).TestCastling();
		resetFlags(turn: true);
	}

	internal void TestCheck()
	{
		new DebugChess(ChessBoard).TestCheck();
		resetFlags(turn: true);
	}

	internal void TestDiscoverCheck()
	{
		new DebugChess(ChessBoard).TestDiscoverCheck();
		resetFlags(turn: true);
	}

	internal void TestPromotion()
	{
		new DebugChess(ChessBoard).TestPromotion();
		resetFlags(turn: true);
	}

	internal void CheckOnCastling()
	{
		new DebugChess(ChessBoard).CheckOnCastling();
		resetFlags(turn: true);
	}
}
