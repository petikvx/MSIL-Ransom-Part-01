namespace Snake;

internal class BodyPart : GamePart
{
	public Direction m_Dir { get; set; }

	public BodyPart(int X, int Y, Direction Dir)
		: base(X, Y)
	{
		m_Dir = Dir;
	}

	public BodyPart(int X, int Y)
		: base(X, Y)
	{
		m_Dir = Direction.none;
	}
}
