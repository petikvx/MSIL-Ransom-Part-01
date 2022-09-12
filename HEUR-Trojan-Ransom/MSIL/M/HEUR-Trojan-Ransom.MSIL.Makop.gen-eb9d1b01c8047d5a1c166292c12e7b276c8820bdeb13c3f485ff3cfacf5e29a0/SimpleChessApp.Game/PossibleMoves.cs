namespace SimpleChessApp.Game;

public class PossibleMoves
{
	public Square Square;

	public UserAction Kind;

	public ChessPiece Piece;

	public PossibleMoves(ChessPiece p, Square sq, UserAction kind)
	{
		Piece = p;
		Square = sq;
		Kind = kind;
	}
}
