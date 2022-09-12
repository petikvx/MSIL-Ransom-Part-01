using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

public class PathFilter : IScanFilter
{
	private NameFilter dypwdgKbBRGToqgbhjReBgZJvHZoA;

	public PathFilter(string filter)
	{
		dypwdgKbBRGToqgbhjReBgZJvHZoA = new NameFilter(filter);
	}

	public virtual bool IsMatch(string name)
	{
		bool result = false;
		if (name != null)
		{
			string name2 = ((name.Length > 0) ? Path.GetFullPath(name) : "");
			result = dypwdgKbBRGToqgbhjReBgZJvHZoA.IsMatch(name2);
		}
		return result;
	}
}
