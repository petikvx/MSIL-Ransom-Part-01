namespace MS.Internal.FontCache;

internal static class FontCacheConstants
{
	internal const int InitialSharedCacheSize = 4194304;

	internal const int MaximumSharedCacheSize = 67108864;

	internal const int InitialLocalCacheSize = 4194304;

	internal const int MaximumLocalCacheSize = 67108864;

	internal const int CacheGrowthFactor = 2;

	internal const int GetCacheNameMessage = 0;

	internal const int SendMissReportMessage = 1;

	internal const int ServerShutdownMessage = 2;
}
