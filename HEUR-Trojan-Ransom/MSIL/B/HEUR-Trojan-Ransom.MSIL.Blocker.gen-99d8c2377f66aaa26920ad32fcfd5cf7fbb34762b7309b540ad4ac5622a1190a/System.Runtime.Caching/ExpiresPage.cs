namespace System.Runtime.Caching;

internal struct ExpiresPage
{
	internal ExpiresEntry[] _entries;

	internal int _pageNext;

	internal int _pagePrev;
}
