namespace Microsoft.InfoCards;

internal enum StorableObjectType
{
	Unknown = 0,
	InfoCard = 1,
	InfoCardClaims = 2,
	InfoCardMasterkey = 3,
	InfocardExtendedInformation = 4,
	RPIdentityRequirement = 5,
	LedgerEntry = -1,
	UserPreferences = -2,
	Recipient = -3
}
