namespace Alphaleonis.Win32.Filesystem;

public class LinkTargetInfo
{
	public string PrintName { get; private set; }

	public string SubstituteName { get; private set; }

	internal LinkTargetInfo(string substituteName, string printName)
	{
		SubstituteName = substituteName;
		PrintName = Path.RemoveTrailingDirectorySeparator(printName ?? Path.GetRegularPathCore(substituteName, GetFullPathOptions.None, allowEmpty: false));
	}
}
