namespace Yakari;

public interface ICacheEventMessage
{
	string Key { get; }

	string MemberName { get; }

	CacheEventType CacheEventType { get; }
}
