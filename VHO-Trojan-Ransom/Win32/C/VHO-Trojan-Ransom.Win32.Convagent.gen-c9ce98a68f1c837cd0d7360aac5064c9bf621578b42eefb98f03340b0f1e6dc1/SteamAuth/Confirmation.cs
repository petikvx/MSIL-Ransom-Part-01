namespace SteamAuth;

public class Confirmation
{
	public enum ConfirmationType
	{
		GenericConfirmation,
		Trade,
		MarketSellTransaction,
		Unknown
	}

	public ulong ID;

	public ulong Key;

	public int IntType;

	public ulong Creator;

	public ConfirmationType ConfType;

	public Confirmation(ulong id, ulong key, int type, ulong creator)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		ID = id;
		Key = key;
		IntType = type;
		Creator = creator;
		switch (type)
		{
		default:
			ConfType = ConfirmationType.Unknown;
			break;
		case 1:
			ConfType = ConfirmationType.GenericConfirmation;
			break;
		case 2:
			ConfType = ConfirmationType.Trade;
			break;
		case 3:
			ConfType = ConfirmationType.MarketSellTransaction;
			break;
		}
	}
}
