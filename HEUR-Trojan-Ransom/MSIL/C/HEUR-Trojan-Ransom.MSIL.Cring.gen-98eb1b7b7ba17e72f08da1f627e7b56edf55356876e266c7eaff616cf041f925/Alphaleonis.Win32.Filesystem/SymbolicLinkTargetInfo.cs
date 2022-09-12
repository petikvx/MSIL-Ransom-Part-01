namespace Alphaleonis.Win32.Filesystem;

public class SymbolicLinkTargetInfo : LinkTargetInfo
{
	public SymbolicLinkType LinkType { get; private set; }

	internal SymbolicLinkTargetInfo(string substituteName, string printName, SymbolicLinkType type)
		: base(substituteName, printName)
	{
		LinkType = type;
	}
}
