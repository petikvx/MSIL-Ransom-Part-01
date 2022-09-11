namespace System.Runtime.Caching;

internal enum EntryState : byte
{
	NotInCache = 0,
	AddingToCache = 1,
	AddedToCache = 2,
	RemovingFromCache = 4,
	RemovedFromCache = 8,
	Closed = 0x10
}
