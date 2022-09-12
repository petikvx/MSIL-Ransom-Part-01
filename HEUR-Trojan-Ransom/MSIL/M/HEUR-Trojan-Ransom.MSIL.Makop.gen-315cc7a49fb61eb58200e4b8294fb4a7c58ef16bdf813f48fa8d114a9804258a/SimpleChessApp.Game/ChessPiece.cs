namespace SimpleChessApp.Game;

public class ChessPiece
{
	public int Id;

	public Pieces Kind;

	public PieceColor Color;

	public Square Home;

	public bool Passant;

	public Square Current;

	private static int idd = 0;

	public string SpecialName => ChessPiece.smethod_0("{0} - {1}", (object)Current.Name, (object)Kind);

	public ChessPiece(Square h, Pieces p, PieceColor c)
	{
		Id = idd++;
		Kind = p;
		Color = c;
		Current = (Home = h);
	}

	public ChessPiece(Pieces p, PieceColor c)
	{
		Id = idd++;
		Kind = p;
		Color = c;
	}

	static string smethod_0(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}
}
