namespace Gecko.WebIDL;

public class BluetoothMapMessagesListingEvent : WebIDLBase
{
	public uint MaxListCount => GetProperty<uint>("maxListCount");

	public uint ListStartOffset => GetProperty<uint>("listStartOffset");

	public uint SubjectLength => GetProperty<uint>("subjectLength");

	public ParameterMask[] ParameterMask => GetProperty<ParameterMask[]>("parameterMask");

	public MessageType FilterMessageType => GetProperty<MessageType>("filterMessageType");

	public string FilterPeriodBegin => GetProperty<string>("filterPeriodBegin");

	public string FilterPeriodEnd => GetProperty<string>("filterPeriodEnd");

	public ReadStatus FilterReadStatus => GetProperty<ReadStatus>("filterReadStatus");

	public string FilterRecipient => GetProperty<string>("filterRecipient");

	public string FilterOriginator => GetProperty<string>("filterOriginator");

	public Priority FilterPriority => GetProperty<Priority>("filterPriority");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothMapMessagesListingEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
