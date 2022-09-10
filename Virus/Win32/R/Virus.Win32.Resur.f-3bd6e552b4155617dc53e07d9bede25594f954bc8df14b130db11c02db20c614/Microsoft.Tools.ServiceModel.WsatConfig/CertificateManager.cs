using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal static class CertificateManager
{
	private static string certificateStore = "Software\\Microsoft\\SystemCertificates\\My";

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static SafeCertificateStore GetCertificateStorePointer(string machineName)
	{
		RegistryExceptionHelper registryExceptionHelper = new RegistryExceptionHelper(machineName, RegistryHive.LocalMachine, certificateStore);
		if (Utilities.IsLocalMachineName(machineName))
		{
			SafeRegistryKey safeRegistryKey = new SafeRegistryKey(new IntPtr(-2147483646), ownsHandle: false);
			SafeRegistryKey phkResult = null;
			try
			{
				int num = SafeNativeMethods.RegOpenKeyEx(safeRegistryKey, certificateStore, 0u, 131097, out phkResult);
				if (num != 0L)
				{
					throw registryExceptionHelper.CreateRegistryAccessException(num);
				}
				SafeCertificateStore safeCertificateStore = SafeNativeMethods.CertOpenStore(4, 0, 0, 49152, phkResult);
				if (safeCertificateStore.IsInvalid)
				{
					throw new WsatAdminException(WsatAdminErrorCode.CERT_STORE_ACCESS, SR.GetString("ErrorAccessCertStore", Marshal.GetLastWin32Error()));
				}
				return safeCertificateStore;
			}
			finally
			{
				phkResult?.Close();
				safeRegistryKey.Close();
			}
		}
		throw new WsatAdminException(WsatAdminErrorCode.CERT_STORE_ACCESS, SR.GetString("ErrorAccessCertStore", 0));
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static X509Certificate2 GetCertificateFromIssuerAndSubjectName(string constraint)
	{
		if (!string.IsNullOrEmpty(constraint) && constraint.Length >= 3)
		{
			int num = constraint.IndexOf('\\');
			if (num <= 0)
			{
				return null;
			}
			string text = constraint.Substring(0, num);
			string text2 = constraint.Substring(num + 1, constraint.Length - num - 1);
			if (Utilities.SafeCompare(text2, "{EMPTY}"))
			{
				text2 = string.Empty;
			}
			X509Store x509Store = null;
			try
			{
				x509Store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
				x509Store.Open(OpenFlags.ReadOnly);
				X509Certificate2Collection x509Certificate2Collection = x509Store.Certificates;
				if (x509Certificate2Collection == null || x509Certificate2Collection.Count == 0)
				{
					return null;
				}
				if (!Utilities.SafeCompare(text, "*"))
				{
					x509Certificate2Collection = x509Certificate2Collection.Find(X509FindType.FindByIssuerDistinguishedName, text, validOnly: false);
				}
				if (x509Certificate2Collection.Count > 0 && !Utilities.SafeCompare(text2, "*"))
				{
					x509Certificate2Collection = x509Certificate2Collection.Find(X509FindType.FindBySubjectDistinguishedName, text2, validOnly: false);
				}
				if (x509Certificate2Collection.Count == 1)
				{
					return x509Certificate2Collection[0];
				}
			}
			catch (ArgumentException)
			{
			}
			catch (SecurityException)
			{
			}
			catch (CryptographicException)
			{
			}
			finally
			{
				x509Store?.Close();
			}
			return null;
		}
		return null;
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static X509Certificate2 GetCertificateFromThumbprint(string thumbprint, string machineName)
	{
		if (string.IsNullOrEmpty(thumbprint))
		{
			return null;
		}
		X509Certificate2 x509Certificate = null;
		SafeCertificateStore certificateStorePointer = GetCertificateStorePointer(machineName);
		SafeCertificateContext safeCertificateContext = new SafeCertificateContext();
		SafeCertificateContext safeCertificateContext2 = new SafeCertificateContext();
		bool flag = false;
		do
		{
			safeCertificateContext2 = SafeNativeMethods.CertFindCertificateInStore(certificateStorePointer, 1, 0, 0, IntPtr.Zero, safeCertificateContext);
			safeCertificateContext = safeCertificateContext2;
			if (!safeCertificateContext2.IsInvalid)
			{
				x509Certificate = safeCertificateContext2.GetNewX509Certificate();
				if (Utilities.SafeCompare(x509Certificate.Thumbprint, thumbprint))
				{
					flag = true;
				}
			}
		}
		while (!safeCertificateContext2.IsInvalid && !flag);
		certificateStorePointer.Close();
		safeCertificateContext.Close();
		if (!safeCertificateContext2.IsInvalid)
		{
			safeCertificateContext2.Close();
			return x509Certificate;
		}
		return null;
	}

	internal static X509Certificate2 GetMachineIdentityCertificate()
	{
		X509Store x509Store = null;
		try
		{
			x509Store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
			x509Store.Open(OpenFlags.ReadOnly);
			string hostName = Dns.GetHostEntry(string.Empty).HostName;
			X509Certificate2 x509Certificate = null;
			int num = 0;
			X509Certificate2Enumerator enumerator = x509Store.Certificates.GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Certificate2 current = enumerator.Current;
				if (!Utilities.SafeCompare(current.GetNameInfo(X509NameType.DnsName, forIssuer: false), hostName))
				{
					continue;
				}
				try
				{
					WsatConfiguration.ValidateIdentityCertificateThrow(current, remoteCert: false);
					if (++num > 1)
					{
						break;
					}
					x509Certificate = current;
					continue;
				}
				catch (WsatAdminException)
				{
					continue;
				}
			}
			return (num == 1) ? x509Certificate : null;
		}
		catch (ArgumentException)
		{
			return null;
		}
		catch (SecurityException)
		{
			return null;
		}
		catch (CryptographicException)
		{
			return null;
		}
		finally
		{
			x509Store?.Close();
		}
	}
}
