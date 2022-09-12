namespace Gecko.WebIDL;

public class MozVoicemailStatus : WebIDLBase
{
	public uint ServiceId => GetProperty<uint>("serviceId");

	public bool HasMessages => GetProperty<bool>("hasMessages");

	public int MessageCount => GetProperty<int>("messageCount");

	public string ReturnNumber => GetProperty<string>("returnNumber");

	public string ReturnMessage => GetProperty<string>("returnMessage");

	public MozVoicemailStatus(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
