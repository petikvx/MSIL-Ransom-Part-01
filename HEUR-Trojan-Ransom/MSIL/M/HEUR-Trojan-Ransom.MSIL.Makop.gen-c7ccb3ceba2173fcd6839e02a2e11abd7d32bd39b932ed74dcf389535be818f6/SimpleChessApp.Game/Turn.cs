namespace SimpleChessApp.Game;

public class Turn
{
	public int Id;

	public Notation White;

	public Notation Black;

	public override string ToString()
	{
		return Turn.smethod_0("{0} {1}-{2}", (object)Id, (object)White, (object)Black);
	}

	static string smethod_0(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
