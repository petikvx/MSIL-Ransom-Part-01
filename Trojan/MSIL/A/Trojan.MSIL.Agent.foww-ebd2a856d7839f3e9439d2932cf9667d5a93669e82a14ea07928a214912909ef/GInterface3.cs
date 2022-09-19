using System;
using System.Runtime.InteropServices;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3C374A41-BAE4-11CF-BF7D-00AA006946EE")]
public interface GInterface3
{
	object EnumUrls
	{
		[return: MarshalAs(UnmanagedType.IUnknown)]
		get;
	}

	void AddUrl(string pocsUrl, string pocsTitle, GEnum7 dwFlags);

	void DeleteUrl(string pocsUrl, int dwFlags);

	void QueryUrl([MarshalAs(UnmanagedType.LPWStr)] string pocsUrl, GEnum5 dwFlags, ref GStruct3 lpSTATURL);

	void BindToObject([In] string pocsUrl, [In] GStruct4 riid, IntPtr ppvOut);
}
