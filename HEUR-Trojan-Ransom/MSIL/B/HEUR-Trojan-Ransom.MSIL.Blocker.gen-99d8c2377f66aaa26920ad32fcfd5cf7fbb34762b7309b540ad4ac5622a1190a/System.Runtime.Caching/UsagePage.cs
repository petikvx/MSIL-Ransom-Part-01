namespace System.Runtime.Caching;

internal struct UsagePage
{
	internal UsageEntry[] _entries;

	internal int _pageNext;

	internal int _pagePrev;
}
