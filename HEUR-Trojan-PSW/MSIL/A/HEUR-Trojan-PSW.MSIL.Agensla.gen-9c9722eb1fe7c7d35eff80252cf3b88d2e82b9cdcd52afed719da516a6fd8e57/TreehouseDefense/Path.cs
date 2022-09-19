namespace TreehouseDefense;

internal class Path
{
	private readonly MapLocation[] _path;

	public int Length => _path.Length;

	public Path(MapLocation[] path)
	{
		_path = path;
	}

	public MapLocation GetLocationAt(int pathStep)
	{
		return (pathStep < _path.Length) ? _path[pathStep] : null;
	}

	public bool IsOnPath(MapLocation location)
	{
		MapLocation[] path = _path;
		int num = 0;
		while (true)
		{
			if (num < path.Length)
			{
				MapLocation obj = path[num];
				if (location.Equals(obj))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}
}
