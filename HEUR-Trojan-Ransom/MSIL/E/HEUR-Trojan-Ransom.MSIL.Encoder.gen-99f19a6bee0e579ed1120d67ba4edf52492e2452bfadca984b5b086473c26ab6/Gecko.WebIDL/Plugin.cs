namespace Gecko.WebIDL;

public class Plugin : WebIDLBase
{
	public string Description => GetProperty<string>("description");

	public string Filename => GetProperty<string>("filename");

	public string Version => GetProperty<string>("version");

	public string Name => GetProperty<string>("name");

	public uint Length => GetProperty<uint>("length");

	public Plugin(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
