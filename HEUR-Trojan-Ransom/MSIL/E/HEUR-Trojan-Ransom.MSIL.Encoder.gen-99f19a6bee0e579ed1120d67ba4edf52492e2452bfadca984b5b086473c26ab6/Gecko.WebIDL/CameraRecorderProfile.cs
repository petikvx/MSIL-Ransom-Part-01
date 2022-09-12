namespace Gecko.WebIDL;

public class CameraRecorderProfile : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string ContainerFormat => GetProperty<string>("containerFormat");

	public string MimeType => GetProperty<string>("mimeType");

	public nsISupports Audio => GetProperty<nsISupports>("audio");

	public nsISupports Video => GetProperty<nsISupports>("video");

	public CameraRecorderProfile(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
