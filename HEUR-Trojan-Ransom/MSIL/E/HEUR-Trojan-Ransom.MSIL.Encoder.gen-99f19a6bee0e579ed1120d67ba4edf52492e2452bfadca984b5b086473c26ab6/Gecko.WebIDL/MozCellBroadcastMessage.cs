namespace Gecko.WebIDL;

public class MozCellBroadcastMessage : WebIDLBase
{
	public uint ServiceId => GetProperty<uint>("serviceId");

	public CellBroadcastGsmGeographicalScope GsmGeographicalScope => GetProperty<CellBroadcastGsmGeographicalScope>("gsmGeographicalScope");

	public ushort MessageCode => GetProperty<ushort>("messageCode");

	public ushort MessageId => GetProperty<ushort>("messageId");

	public string Language => GetProperty<string>("language");

	public string Body => GetProperty<string>("body");

	public CellBroadcastMessageClass MessageClass => GetProperty<CellBroadcastMessageClass>("messageClass");

	public nsISupports Timestamp => GetProperty<nsISupports>("timestamp");

	public nsISupports Etws => GetProperty<nsISupports>("etws");

	public ushort? CdmaServiceCategory => GetProperty<ushort?>("cdmaServiceCategory");

	public MozCellBroadcastMessage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
