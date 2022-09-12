namespace Gecko.WebIDL;

public class WebGLActiveInfo : WebIDLBase
{
	public int Size => GetProperty<int>("size");

	public uint Type => GetProperty<uint>("type");

	public string Name => GetProperty<string>("name");

	public WebGLActiveInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
