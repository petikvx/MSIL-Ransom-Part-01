using System.Collections.Generic;
using Gecko.Services;

namespace Gecko.Utils;

public sealed class VersionComparer : IComparer<string>
{
	public int Compare(string x, string y)
	{
		return VersionComparator.Compare(x, y);
	}
}
