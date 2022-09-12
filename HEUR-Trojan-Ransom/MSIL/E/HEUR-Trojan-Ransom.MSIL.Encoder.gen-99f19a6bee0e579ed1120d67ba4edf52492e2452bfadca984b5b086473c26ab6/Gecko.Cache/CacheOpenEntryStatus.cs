namespace Gecko.Cache;

public enum CacheOpenEntryStatus
{
	Ok = 0,
	KeyNotFound = -2142568387,
	DataIsStream = -2142568386,
	DataIsNotStream = -2142568385,
	WaitForValidation = -2142568384,
	EntryDoomed = -2142568383,
	ReadAccessDenied = -2142568382,
	WriteAccessDenied = -2142568381,
	InUse = -2142568380
}
