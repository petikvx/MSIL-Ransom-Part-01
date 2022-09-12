namespace Gecko.WebIDL;

public class MozObjectLoadingContent : WebIDLBase
{
	public string ActualType => GetProperty<string>("actualType");

	public uint DisplayedType => GetProperty<uint>("displayedType");

	public bool Activated => GetProperty<bool>("activated");

	public nsISupports SrcURI => GetProperty<nsISupports>("srcURI");

	public uint DefaultFallbackType => GetProperty<uint>("defaultFallbackType");

	public uint PluginFallbackType => GetProperty<uint>("pluginFallbackType");

	public bool HasRunningPlugin => GetProperty<bool>("hasRunningPlugin");

	public uint RunID => GetProperty<uint>("runID");

	public MozObjectLoadingContent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
