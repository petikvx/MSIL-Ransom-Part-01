using System;
using System.Runtime.InteropServices;

namespace com.poweriwb.PowerDesk;

internal class InternetExplorerClass
{
	[ComImport]
	[Guid("79EAC9EE-BAF9-11CE-8C82-00AA004BA90B")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IInternetSecurityManager
	{
		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int SetSecuritySite([In] IntPtr pSite);

		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int GetSecuritySite([Out] IntPtr pSite);

		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int MapUrlToZone([In][MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, out uint pdwZone, uint dwFlags);

		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int GetSecurityId([MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, [MarshalAs(UnmanagedType.LPArray)] byte[] pbSecurityId, ref uint pcbSecurityId, uint dwReserved);

		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int ProcessUrlAction([In][MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, uint dwAction, out byte pPolicy, uint cbPolicy, byte pContext, uint cbContext, uint dwFlags, uint dwReserved);

		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int QueryCustomPolicy([In][MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, ref Guid guidKey, ref byte ppPolicy, ref uint pcbPolicy, ref byte pContext, uint cbContext, uint dwReserved);

		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int SetZoneMapping(uint dwZone, [In][MarshalAs(UnmanagedType.LPWStr)] string lpszPattern, uint dwFlags);

		[PreserveSig]
		[return: MarshalAs(UnmanagedType.I4)]
		int GetZoneMappings(uint dwZone, out UCOMIEnumString ppenumString, uint dwFlags);
	}

	private const uint SZM_CREATE = 0u;

	private const uint SZM_DELETE = 1u;

	public const uint ZoneLocalMachine = 0u;

	public const uint ZoneIntranet = 1u;

	public const uint ZoneTrusted = 2u;

	public const uint ZoneInternet = 3u;

	public const uint ZoneUntrusted = 4u;

	private static Guid CLSID_InternetSecurityManager = new Guid("7b8a2d94-0ac9-11d1-896c-00c04fb6bfc4");

	private static Guid IID_IInternetSecurityManager = new Guid("79eac9ee-baf9-11ce-8c82-00aa004ba90b");

	private static IInternetSecurityManager CreateInternetSecurityManager()
	{
		Type typeFromCLSID = Type.GetTypeFromCLSID(CLSID_InternetSecurityManager);
		return (IInternetSecurityManager)Activator.CreateInstance(typeFromCLSID);
	}

	public void AddSiteToZone(uint zone, string pattern)
	{
		try
		{
			IInternetSecurityManager internetSecurityManager = CreateInternetSecurityManager();
			internetSecurityManager.SetZoneMapping(zone, pattern, 0u);
		}
		catch (COMException innerException)
		{
			throw new InvalidOperationException("URL has already been added to a zone", innerException);
		}
		catch (UnauthorizedAccessException innerException2)
		{
			throw new InvalidOperationException("Can't add non-SSL site to zone that requires SSL", innerException2);
		}
	}

	private static void RemoveSiteFromZone(string pattern)
	{
		IInternetSecurityManager internetSecurityManager = CreateInternetSecurityManager();
		internetSecurityManager.MapUrlToZone(pattern, out var pdwZone, 0u);
		internetSecurityManager.SetZoneMapping(pdwZone, pattern, 1u);
	}
}
