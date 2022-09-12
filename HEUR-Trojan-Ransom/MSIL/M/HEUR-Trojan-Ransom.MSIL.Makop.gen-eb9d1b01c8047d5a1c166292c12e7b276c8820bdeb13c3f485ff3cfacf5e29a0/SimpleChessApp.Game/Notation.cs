namespace SimpleChessApp.Game;

public class Notation
{
	public Square from;

	public Square to;

	public string Move => Notation.smethod_0(from.CurrentSquare, " ", to.CurrentSquare);

	public Notation(Square f, Square t, Board bo)
	{
		Square square = new Square(f.File, f.Rank, bo);
		Square square2 = new Square(t.File, t.Rank, bo);
		square.Piece = new ChessPiece(f, t.Piece.Kind, t.Piece.Color);
		square2.Piece = new ChessPiece(t, t.Piece.Kind, t.Piece.Color);
		from = square;
		to = square2;
	}

	public override string ToString()
	{
		return Move;
	}

	static string smethod_0(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}
}
