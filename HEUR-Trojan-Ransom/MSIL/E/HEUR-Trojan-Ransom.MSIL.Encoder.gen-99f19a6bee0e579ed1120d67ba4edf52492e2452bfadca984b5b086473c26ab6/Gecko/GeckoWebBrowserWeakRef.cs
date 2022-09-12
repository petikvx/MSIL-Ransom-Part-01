using System;
using System.Runtime.InteropServices;

namespace Gecko;

internal class GeckoWebBrowserWeakRef : IDisposable, nsIWeakReference
{
	private IntPtr _iUnknown;

	public GeckoWebBrowserWeakRef(GeckoWebBrowser gwb)
	{
		IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(gwb);
		Marshal.Release(iUnknownForObject);
		_iUnknown = iUnknownForObject;
	}

	public IntPtr QueryReferent(ref Guid uuid)
	{
		if (_iUnknown == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		Marshal.QueryInterface(_iUnknown, ref uuid, out var ppv);
		return ppv;
	}

	public void Dispose()
	{
		_iUnknown = IntPtr.Zero;
	}
}
