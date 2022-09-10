using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class WsatServiceCertificate
{
	private X509Certificate2 cert;

	private uint port;

	private string certificateStore = "MY";

	internal WsatServiceCertificate(X509Certificate2 cert, uint port)
	{
		this.cert = cert;
		this.port = port;
	}

	internal void BindSSLCertificate()
	{
		if (Utilities.IsHttpApiLibAvailable)
		{
			BindSSL();
		}
	}

	internal void UnbindSSLCertificate()
	{
		if (Utilities.IsHttpApiLibAvailable)
		{
			UnbindSSL();
		}
	}

	private void BindSSL()
	{
		int num = 0;
		WinsockSockAddr winsockSockAddr = null;
		try
		{
			num = SafeNativeMethods.HttpInitialize(HttpWrapper.HttpApiVersion1, 2, IntPtr.Zero);
			if (num == 0)
			{
				IntPtr zero = IntPtr.Zero;
				winsockSockAddr = new WinsockSockAddr(new IPAddress(0L), (short)port);
				HttpServiceConfigSslSet configInformation = default(HttpServiceConfigSslSet);
				configInformation.KeyDesc.pIpPort = winsockSockAddr.PinnedSockAddr;
				configInformation.ParamDesc.DefaultCertCheckMode = 0;
				configInformation.ParamDesc.DefaultFlags = 2;
				configInformation.ParamDesc.DefaultRevocationFreshnessTime = 0;
				configInformation.ParamDesc.pSslCertStoreName = certificateStore;
				byte[] certHash = cert.GetCertHash();
				configInformation.ParamDesc.pSslHash = new SafeLocalAllocation(certHash.Length);
				configInformation.ParamDesc.pSslHash.Copy(certHash, 0, certHash.Length);
				configInformation.ParamDesc.SslHashLength = certHash.Length;
				int configInformationLength = Marshal.SizeOf((object)configInformation);
				num = SafeNativeMethods.HttpSetServiceConfiguration_1(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigSSLCertInfo, ref configInformation, configInformationLength, zero);
				if (183 == num)
				{
					num = SafeNativeMethods.HttpDeleteServiceConfiguration_1(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigSSLCertInfo, ref configInformation, configInformationLength, IntPtr.Zero);
					if (num == 0)
					{
						num = SafeNativeMethods.HttpSetServiceConfiguration_1(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigSSLCertInfo, ref configInformation, configInformationLength, zero);
					}
				}
				GC.KeepAlive(winsockSockAddr);
				configInformation.ParamDesc.pSslHash.Close();
			}
		}
		finally
		{
			winsockSockAddr?.Dispose();
			SafeNativeMethods.HttpTerminate(2, IntPtr.Zero);
		}
		if (num != 0)
		{
			if (183 == num)
			{
				throw new WsatAdminException(WsatAdminErrorCode.HTTPS_PORT_SSL_CERT_BINDING_ALREADYEXISTS, SR.GetString("ErrorHttpsPortSSLBindingAlreadyExists"));
			}
			throw new WsatAdminException(WsatAdminErrorCode.HTTPS_PORT_SSL_CERT_BINDING, SR.GetString("ErrorHttpsPortSSLBinding", num));
		}
	}

	private void UnbindSSL()
	{
		int num = 0;
		WinsockSockAddr winsockSockAddr = null;
		try
		{
			num = SafeNativeMethods.HttpInitialize(HttpWrapper.HttpApiVersion1, 2, IntPtr.Zero);
			if (num == 0)
			{
				IntPtr zero = IntPtr.Zero;
				winsockSockAddr = new WinsockSockAddr(new IPAddress(0L), (short)port);
				HttpServiceConfigSslSet configInformation = default(HttpServiceConfigSslSet);
				configInformation.KeyDesc.pIpPort = winsockSockAddr.PinnedSockAddr;
				configInformation.ParamDesc.DefaultCertCheckMode = 0;
				configInformation.ParamDesc.DefaultFlags = 2;
				configInformation.ParamDesc.DefaultRevocationFreshnessTime = 0;
				configInformation.ParamDesc.pSslCertStoreName = certificateStore;
				byte[] certHash = cert.GetCertHash();
				configInformation.ParamDesc.pSslHash = new SafeLocalAllocation(certHash.Length);
				configInformation.ParamDesc.pSslHash.Copy(certHash, 0, certHash.Length);
				configInformation.ParamDesc.SslHashLength = certHash.Length;
				int configInformationLength = Marshal.SizeOf((object)configInformation);
				num = SafeNativeMethods.HttpDeleteServiceConfiguration_1(IntPtr.Zero, HttpServiceConfigId.HttpServiceConfigSSLCertInfo, ref configInformation, configInformationLength, zero);
				configInformation.ParamDesc.pSslHash.Close();
				GC.KeepAlive(winsockSockAddr);
			}
		}
		finally
		{
			winsockSockAddr?.Dispose();
			SafeNativeMethods.HttpTerminate(2, IntPtr.Zero);
		}
		if (num != 0 && num != 2 && num != 87)
		{
			throw new WsatAdminException(WsatAdminErrorCode.HTTPS_PORT_SSL_CERT_UNBINDING, SR.GetString("ErrorHttpsPortSSLUnbinding", num));
		}
	}
}
