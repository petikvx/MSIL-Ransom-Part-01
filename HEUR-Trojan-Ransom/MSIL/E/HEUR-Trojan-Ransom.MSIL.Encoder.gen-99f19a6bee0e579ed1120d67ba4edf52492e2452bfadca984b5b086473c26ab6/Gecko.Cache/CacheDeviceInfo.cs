using Gecko.Interop;

namespace Gecko.Cache;

public sealed class CacheDeviceInfo
{
	private ComPtr<nsICacheDeviceInfo> _cacheDeviceInfo;

	public string Description => _cacheDeviceInfo.Instance.GetDescriptionAttribute();

	public uint EntryCount => _cacheDeviceInfo.Instance.GetEntryCountAttribute();

	public uint MaximumSize => _cacheDeviceInfo.Instance.GetMaximumSizeAttribute();

	public uint TotalSize => _cacheDeviceInfo.Instance.GetTotalSizeAttribute();

	public string UsageReport => _cacheDeviceInfo.Instance.GetUsageReportAttribute();

	internal CacheDeviceInfo(nsICacheDeviceInfo cacheDeviceInfo)
	{
		_cacheDeviceInfo = new ComPtr<nsICacheDeviceInfo>(cacheDeviceInfo);
	}
}
