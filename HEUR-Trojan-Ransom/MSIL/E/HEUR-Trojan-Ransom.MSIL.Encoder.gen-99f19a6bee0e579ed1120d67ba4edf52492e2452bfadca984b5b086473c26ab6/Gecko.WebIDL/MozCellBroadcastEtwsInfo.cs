namespace Gecko.WebIDL;

public class MozCellBroadcastEtwsInfo : WebIDLBase
{
	public CellBroadcastEtwsWarningType WarningType => GetProperty<CellBroadcastEtwsWarningType>("warningType");

	public bool EmergencyUserAlert => GetProperty<bool>("emergencyUserAlert");

	public bool Popup => GetProperty<bool>("popup");

	public MozCellBroadcastEtwsInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
