namespace TreehouseDefense;

internal class StrongInvader : Invader
{
	public override int Health { get; protected set; } = 2;


	public StrongInvader(Path path)
		: base(path)
	{
	}
}
