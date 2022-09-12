namespace Yakari;

public class CacheEventMessage : ICacheEventMessage
{
	public string Key { get; }

	public string MemberName { get; }

	public CacheEventType CacheEventType { get; }

	public CacheEventMessage(string key, string memberName, CacheEventType cacheEventType)
	{
		Key = key;
		MemberName = memberName;
		CacheEventType = cacheEventType;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is CacheEventMessage cacheEventMessage))
		{
			return false;
		}
		if (Key == cacheEventMessage.Key && MemberName == cacheEventMessage.MemberName && CacheEventType == cacheEventMessage.CacheEventType)
		{
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Key.GetHashCode() ^ MemberName.GetHashCode() ^ CacheEventType.GetHashCode();
	}
}
