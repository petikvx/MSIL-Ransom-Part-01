namespace System.Runtime.Caching;

internal struct ExpiresEntryRef
{
	internal static readonly ExpiresEntryRef INVALID = new ExpiresEntryRef(0, 0);

	private const uint ENTRY_MASK = 255u;

	private const uint PAGE_MASK = 4294967040u;

	private const int PAGE_SHIFT = 8;

	private uint _ref;

	internal int PageIndex => (int)(_ref >> 8);

	internal int Index => (int)(_ref & 0xFF);

	internal bool IsInvalid => _ref == 0;

	internal ExpiresEntryRef(int pageIndex, int entryIndex)
	{
		_ref = (uint)(pageIndex << 8) | ((uint)entryIndex & 0xFFu);
	}

	public override bool Equals(object value)
	{
		if (value is ExpiresEntryRef)
		{
			return _ref == ((ExpiresEntryRef)value)._ref;
		}
		return false;
	}

	public static bool operator !=(ExpiresEntryRef r1, ExpiresEntryRef r2)
	{
		return r1._ref != r2._ref;
	}

	public static bool operator ==(ExpiresEntryRef r1, ExpiresEntryRef r2)
	{
		return r1._ref == r2._ref;
	}

	public override int GetHashCode()
	{
		return (int)_ref;
	}
}
