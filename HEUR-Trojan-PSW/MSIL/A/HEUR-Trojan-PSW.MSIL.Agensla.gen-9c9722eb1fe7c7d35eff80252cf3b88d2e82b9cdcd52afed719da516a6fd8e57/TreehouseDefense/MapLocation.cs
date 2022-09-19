namespace TreehouseDefense;

internal class MapLocation : Point
{
	public MapLocation(int x, int y, Map map)
		: base(x, y)
	{
		if (!map.OnMap(this))
		{
			throw new OutOfBoundsException(this?.ToString() + " is outside the boundaries of the map.");
		}
	}

	public bool InRangeOf(MapLocation location, int range)
	{
		return DistanceTo(location) <= range;
	}
}
