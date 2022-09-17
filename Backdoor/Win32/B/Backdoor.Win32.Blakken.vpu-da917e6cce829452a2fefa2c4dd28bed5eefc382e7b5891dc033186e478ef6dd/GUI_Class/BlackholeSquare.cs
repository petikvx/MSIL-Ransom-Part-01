namespace GUI_Class;

public class BlackholeSquare : Square
{
	private int destination;

	private int fuelUsed;

	public BlackholeSquare(string name, int number, int next, int fuel)
		: base(name, number)
	{
		destination = next;
		fuelUsed = fuel;
	}

	public override Square NextSquare()
	{
		return Board.Squares[destination];
	}

	public override void LandOn(Player player)
	{
		player.Location = player.Location.NextSquare();
		player.Position = destination;
		player.ConsumeFuel(fuelUsed);
	}
}
