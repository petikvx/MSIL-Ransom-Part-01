using Gecko.Interop;

namespace Gecko.Services;

public static class VersionComparator
{
	private static ComPtr<nsIVersionComparator> _versionComparator;

	static VersionComparator()
	{
		_versionComparator = Xpcom.GetService2<nsIVersionComparator>("@mozilla.org/xpcom/version-comparator;1");
	}

	public static int Compare(string x, string y)
	{
		return nsString.Pass(_versionComparator.Instance.Compare, x, y);
	}
}
