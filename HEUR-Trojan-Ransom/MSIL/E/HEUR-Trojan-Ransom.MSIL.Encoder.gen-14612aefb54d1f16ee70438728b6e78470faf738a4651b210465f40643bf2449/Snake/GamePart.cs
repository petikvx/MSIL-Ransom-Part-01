namespace Snake;

internal class GamePart
{
	private Point Position;

	public Point GetPosition()
	{
		return Position;
	}

	public void AddPosition(Point point)
	{
		Position.X += point.X;
		Position.Y += point.Y;
	}

	public void SetPosition(Point point)
	{
		Position = point;
	}

	public GamePart(int X, int Y)
	{
		Position = new Point(X, Y);
	}
}
