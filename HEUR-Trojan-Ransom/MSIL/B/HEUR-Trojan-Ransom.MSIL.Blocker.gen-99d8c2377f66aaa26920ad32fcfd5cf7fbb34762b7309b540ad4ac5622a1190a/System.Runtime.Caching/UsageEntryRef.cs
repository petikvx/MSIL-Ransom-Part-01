namespace System.Runtime.Caching;

internal struct UsageEntryRef
{
	internal static readonly UsageEntryRef INVALID = new UsageEntryRef(0, 0);

	private const uint ENTRY_MASK = 255u;

	private const uint PAGE_MASK = 4294967040u;

	private const int PAGE_SHIFT = 8;

	private uint _ref;

	internal int PageIndex => (int)(_ref >> 8);

	internal int Ref1Index => (sbyte)(_ref & 0xFF);

	internal int Ref2Index
	{
		get
		{
			int num = (sbyte)(_ref & 0xFF);
			return -num;
		}
	}

	internal bool IsRef1 => (sbyte)(_ref & 0xFF) > 0;

	internal bool IsRef2 => (sbyte)(_ref & 0xFF) < 0;

	internal bool IsInvalid => _ref == 0;

	internal UsageEntryRef(int pageIndex, int entryIndex)
	{
		_ref = (uint)(pageIndex << 8) | ((uint)entryIndex & 0xFFu);
	}

	public override bool Equals(object value)
	{
		if (value is UsageEntryRef)
		{
			return _ref == ((UsageEntryRef)value)._ref;
		}
		return false;
	}

	public static bool operator ==(UsageEntryRef r1, UsageEntryRef r2)
	{
		return r1._ref == r2._ref;
	}

	public static bool operator !=(UsageEntryRef r1, UsageEntryRef r2)
	{
		return r1._ref != r2._ref;
	}

	public override int GetHashCode()
	{
		return (int)_ref;
	}
}
