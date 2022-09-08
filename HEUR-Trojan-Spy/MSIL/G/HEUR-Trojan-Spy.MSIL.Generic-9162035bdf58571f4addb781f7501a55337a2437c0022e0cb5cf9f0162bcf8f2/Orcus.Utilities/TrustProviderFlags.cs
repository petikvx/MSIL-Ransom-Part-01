namespace Orcus.Utilities;

internal enum TrustProviderFlags
{
	UseIE4Trust = 1,
	NoIE4Chain = 2,
	NoPolicyUsage = 4,
	RevocationCheckNone = 0x10,
	RevocationCheckEndCert = 0x20,
	RevocationCheckChain = 0x40,
	RecovationCheckChainExcludeRoot = 0x80,
	Safer = 0x100,
	HashOnly = 0x200,
	UseDefaultOSVerCheck = 0x400,
	LifetimeSigning = 0x800
}
