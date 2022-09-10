using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class WsatServiceAddress
{
	private const string wsatServiceAddressFormat = "https://+:{0}/WsatService/";

	private const string wsatSecurityDescriptor = "D:(A;;GA;;;NS)";

	private uint port;

	private string wsatServiceAddress;

	internal WsatServiceAddress(uint port)
	{
		this.port = port;
		wsatServiceAddress = string.Format(CultureInfo.InvariantCulture, "https://+:{0}/WsatService/", new object[1] { this.port });
	}

	internal void ReserveWsatServiceAddress()
	{
		if (Utilities.IsHttpApiLibAvailable)
		{
			ReserveURL(wsatServiceAddress, "D:(A;;GA;;;NS)");
		}
	}

	internal void FreeWsatServiceAddress()
	{
		if (Utilities.IsHttpApiLibAvailable)
		{
			FreeURL(wsatServiceAddress, "D:(A;;GA;;;NS)");
		}
	}

	private static void ReserveURL(string networkURL, string securityDescriptor)
	{
		int num = 0;
		try
		{
			num = SafeNativeMethods.HttpInitialize(HttpWrapper.HttpApiVersion1, 2, IntPtr.Zero);
			if (num == 0)
			{
				HttpServiceConfigUrlAclKey keyDesc = new HttpServiceConfigUrlAclKey(networkURL);
				HttpServiceConfigUrlAclParam paramDesc = new HttpServiceConfigUrlAclParam(securityDescriptor);
				HttpServiceConfigUrlAclSet configInformation = default(HttpServiceConfigUrlAclSet);
				configInformation.KeyDesc = keyDesc;
				configInformation.ParamDesc = paramDesc;
				int configInformationLength = Marshal.SizeOf((object)configInformation);
				num = SafeNativeMethods.HttpSetServiceConfiguration(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigUrlAclInfo, ref configInformation, configInformationLength, IntPtr.Zero);
				if (183 == num)
				{
					num = SafeNativeMethods.HttpDeleteServiceConfiguration(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigUrlAclInfo, ref configInformation, configInformationLength, IntPtr.Zero);
					if (num == 0)
					{
						num = SafeNativeMethods.HttpSetServiceConfiguration(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigUrlAclInfo, ref configInformation, configInformationLength, IntPtr.Zero);
					}
				}
			}
		}
		finally
		{
			SafeNativeMethods.HttpTerminate(2, IntPtr.Zero);
		}
		if (num != 0)
		{
			if (183 == num)
			{
				throw new WsatAdminException(WsatAdminErrorCode.REGISTER_HTTPS_PORT_ALREADYEXISTS, SR.GetString("ErrorRegisterHttpsPortAlreadyExists"));
			}
			throw new WsatAdminException(WsatAdminErrorCode.REGISTER_HTTPS_PORT, SR.GetString("ErrorRegisterHttpsPort", num));
		}
	}

	private static void FreeURL(string networkURL, string securityDescriptor)
	{
		int num = 0;
		try
		{
			num = SafeNativeMethods.HttpInitialize(HttpWrapper.HttpApiVersion1, 2, IntPtr.Zero);
			if (num == 0)
			{
				HttpServiceConfigUrlAclKey keyDesc = new HttpServiceConfigUrlAclKey(networkURL);
				HttpServiceConfigUrlAclParam paramDesc = new HttpServiceConfigUrlAclParam(securityDescriptor);
				HttpServiceConfigUrlAclSet configInformation = default(HttpServiceConfigUrlAclSet);
				configInformation.KeyDesc = keyDesc;
				configInformation.ParamDesc = paramDesc;
				int configInformationLength = Marshal.SizeOf((object)configInformation);
				num = SafeNativeMethods.HttpDeleteServiceConfiguration(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigUrlAclInfo, ref configInformation, configInformationLength, IntPtr.Zero);
			}
		}
		finally
		{
			SafeNativeMethods.HttpTerminate(2, IntPtr.Zero);
		}
		if (num != 0 && num != 2 && num != 87)
		{
			throw new WsatAdminException(WsatAdminErrorCode.UNREGISTER_HTTPS_PORT, SR.GetString("ErrorUnregisterHttpsPort", num));
		}
	}
}
