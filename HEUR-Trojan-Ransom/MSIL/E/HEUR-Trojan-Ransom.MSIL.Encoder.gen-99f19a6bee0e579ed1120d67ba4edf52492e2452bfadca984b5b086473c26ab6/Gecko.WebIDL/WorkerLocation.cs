namespace Gecko.WebIDL;

public class WorkerLocation : WebIDLBase
{
	public USVString Href => GetProperty<USVString>("href");

	public USVString Origin => GetProperty<USVString>("origin");

	public USVString Protocol => GetProperty<USVString>("protocol");

	public USVString Host => GetProperty<USVString>("host");

	public USVString Hostname => GetProperty<USVString>("hostname");

	public USVString Port => GetProperty<USVString>("port");

	public USVString Pathname => GetProperty<USVString>("pathname");

	public USVString Search => GetProperty<USVString>("search");

	public USVString Hash => GetProperty<USVString>("hash");

	public WorkerLocation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
