namespace TreehouseDefense;

internal class FastInvader : Invader
{
	protected override int StepSize { get; } = 2;


	public override int Health { get; protected set; } = 2;


	public FastInvader(Path path)
		: base(path)
	{
	}
}
