namespace TreehouseDefense;

internal class LongRangeTower : Tower
{
	protected override int Range { get; } = 3;


	public LongRangeTower(MapLocation location)
		: base(location)
	{
	}
}
