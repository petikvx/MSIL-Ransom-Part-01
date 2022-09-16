using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Cct.Services;
using _0xH2ignifiers;
using _0xH4ssimilates;
using _0xH5ecade;
using _0xH6ivisive;
using _0xHAi1wo1thie1;
using _0xHBebloo6e6;
using _0xHCarbonade4;
using _0xHCarol0d;
using _0xHChan6ries;
using _0xHCre2asse;
using _0xHFlour4;
using _0xHInti4adehs;
using _0xHOu6s6ared;
using _0xHParge0s;
using _0xHPre7ocalic;
using _0xHR3d3mand;
using _0xHR7sm7lt7d;
using _0xHSli2ken;
using _0xHThalw3g;

namespace _0xHSulphur5us;

internal class _0xHPan5os
{
	[SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Not documenting the obvious")]
	private class _0xHF4ows : ICertificateStore
	{
		private readonly X509Store _0xHPenn3ro3als;

		public X509Certificate2Collection Certificates => _0xHPenn3ro3als.Certificates;

		public _0xHF4ows(StoreName name, StoreLocation location)
		{
			_0xHPenn3ro3als = new X509Store(name, location);
		}

		public void _0xHC6rcumvallat6on(OpenFlags _0xH1onviral)
		{
			_0xHPenn3ro3als.Open(_0xH1onviral);
		}

		public void _0xHMarine1()
		{
			_0xHPenn3ro3als.Close();
		}

		public void _0xHZoospor3(X509Certificate2 _0xH4lectors)
		{
			_0xHPenn3ro3als.Add(_0xH4lectors);
		}

		public X509Certificate2 _0xHAquat8nt8ng(string _0xHOa7ed, string _0xHInitializ8d)
		{
			throw new NotSupportedException();
		}
	}

	internal class _0xHPollard8ng
	{
		[StructLayout(LayoutKind.Sequential)]
		internal class _0xHChu22ily
		{
			[MarshalAs(UnmanagedType.LPWStr)]
			public string _0xHP1cturesqueness;

			[MarshalAs(UnmanagedType.LPWStr)]
			public string _0xHInte0c0opping;

			public int _0xHQua7tifier;

			public int _0xH7uppydoms;

			public int _0xHDiall7rs;

			public IntPtr _0xHCo1oidal;

			public int _0xHRemaster6ng;
		}

		internal const uint _0xHNonathl3tic = 2u;

		[DllImport("crypt32.dll", SetLastError = true)]
		internal static extern bool CryptAcquireCertificatePrivateKey([In] IntPtr _0xHSimula5rum, [In] uint _0xHGeekine33, [In] IntPtr _0xHChoo0er0, [In][Out] ref IntPtr _0xHFamo0sly, [In][Out] ref uint _0xHSoc2ometr2c, [In][Out] ref bool _0xHUnchlorin7ted);

		[DllImport("crypt32.dll", SetLastError = true)]
		internal static extern IntPtr CertOpenSystemStore([In] IntPtr _0xHMini0er, [In][MarshalAs(UnmanagedType.LPWStr)] string _0xHProm7lgated);

		[DllImport("crypt32.dll", SetLastError = true)]
		internal static extern bool CertGetCertificateContextProperty([In] IntPtr _0xHDepre55or5, [In] uint _0xHIndorsin6, [Out] IntPtr _0xHDr1ary, [In][Out] ref int _0xH0rrelative);

		[DllImport("advapi32.dll", SetLastError = true)]
		internal static extern bool CryptReleaseContext([In] IntPtr _0xHCapitalis7, [In] uint _0xHM8rg8s);

		[DllImport("ncrypt.dll")]
		internal static extern int NCryptFreeObject([In] IntPtr _0xHX8non);
	}

	internal static ICertificateStore _0xHBobbe0s { get; set; }

	public static X509Certificate2 _0xHO8erdocumented(string _0xHImp8etions, string _0xHMoh3r = null)
	{
		X509Certificate2 x509Certificate = null;
		string text = _0xHMoh3r ?? "CN=Windows Azure Tools";
		if (_0xHBobbe0s != null)
		{
			return _0xHBobbe0s.CreateAndInstallLegacyCertificate(text, _0xHImp8etions);
		}
		return _0xHUnfr5itf5lly(text, _0xHImp8etions);
	}

	public static X509Certificate2 _0xHPatr22ns(string _0xHNews7es)
	{
		return _0xHFunda4ents(_0xHNews7es) ?? throw _0xHL1mniscus._0xHBiochemistr0(new ArgumentException(((WatError)218)._0xHN6tur6lize()), (WatError)218);
	}

	public static X509Certificate2 _0xHFunda4ents(string _0xH2roublers)
	{
		if (string.IsNullOrEmpty(_0xH2roublers))
		{
			return null;
		}
		ICertificateStore certificateStore = _0xHGloz8(StoreName.My, StoreLocation.CurrentUser);
		certificateStore.Open(OpenFlags.ReadOnly);
		try
		{
			X509Certificate2Collection x509Certificate2Collection = certificateStore.Certificates.Find(X509FindType.FindByThumbprint, _0xH2roublers, validOnly: false);
			if (x509Certificate2Collection != null && x509Certificate2Collection.Count != 0)
			{
				return x509Certificate2Collection[0];
			}
			return null;
		}
		finally
		{
			certificateStore.Close();
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "Microsoft.Cct.Credentials.ServiceManagement.CertificateHelper+NativeMethods.NCryptFreeObject(System.IntPtr)", Justification = "No need to throw if the function fails")]
	public static ICollection<X509Certificate2> _0xHI00oderations(bool _0xHA5ocry5halness, bool _0xHRema6es, bool _0xHSandfli4s)
	{
		List<X509Certificate2> list = new List<X509Certificate2>();
		ICertificateStore certificateStore = _0xHGloz8(StoreName.My, StoreLocation.CurrentUser);
		certificateStore.Open(OpenFlags.ReadOnly);
		try
		{
			X509Certificate2Enumerator enumerator = certificateStore.Certificates.Find(X509FindType.FindByTimeValid, DateTime.Now, validOnly: false).GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Certificate2 current = enumerator.Current;
				if (current.Issuer.StartsWith("CN=DO_NOT_TRUST_FiddlerRoot,", StringComparison.Ordinal) || (_0xHRema6es && !current.HasPrivateKey) || (!_0xHA5ocry5halness && _0xHAnthr7p7l7gies(current)))
				{
					continue;
				}
				if (_0xHSandfli4s)
				{
					bool flag = false;
					if (current.HasPrivateKey)
					{
						IntPtr _0xHFamo0sly = IntPtr.Zero;
						bool _0xHUnchlorin7ted = false;
						uint _0xHSoc2ometr2c = 0u;
						if (_0xHPollard8ng.CryptAcquireCertificatePrivateKey(current.Handle, 64u, IntPtr.Zero, ref _0xHFamo0sly, ref _0xHSoc2ometr2c, ref _0xHUnchlorin7ted))
						{
							flag = true;
							if (_0xHUnchlorin7ted)
							{
								if (_0xHSoc2ometr2c == uint.MaxValue)
								{
									_0xHPollard8ng.NCryptFreeObject(_0xHFamo0sly);
								}
								else
								{
									_0xHPollard8ng.CryptReleaseContext(_0xHFamo0sly, 0u);
								}
							}
							if (_0xHSoc2ometr2c != 1)
							{
								continue;
							}
						}
					}
					if (!flag)
					{
						bool flag2 = false;
						X509ExtensionEnumerator enumerator2 = current.Extensions.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current is X509KeyUsageExtension x509KeyUsageExtension && ((x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.DataEncipherment) == X509KeyUsageFlags.DataEncipherment || (x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.KeyEncipherment) == X509KeyUsageFlags.KeyEncipherment || (x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.KeyAgreement) == X509KeyUsageFlags.KeyAgreement || (x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.EncipherOnly) == X509KeyUsageFlags.EncipherOnly || (x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.DecipherOnly) == X509KeyUsageFlags.DecipherOnly))
							{
								flag2 = true;
								break;
							}
						}
						if (!flag2)
						{
							continue;
						}
					}
				}
				list.Add(current);
			}
			return list;
		}
		finally
		{
			certificateStore.Close();
		}
	}

	internal static void _0xHK7firs(X509Certificate2 _0xHSep4e44es)
	{
		ICertificateStore certificateStore = _0xHGloz8(StoreName.My, StoreLocation.CurrentUser);
		certificateStore.Open(OpenFlags.ReadWrite);
		try
		{
			certificateStore.Add(_0xHSep4e44es);
		}
		finally
		{
			certificateStore.Close();
		}
	}

	internal static X509Certificate2 _0xHThunderstruc0(string _0xHObserv8bility)
	{
		return new X509Certificate2(Convert.FromBase64String(_0xHObserv8bility), string.Empty, X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static SecureString _0xHDeu5eric()
	{
		char[] array = _0xHC0cadae();
		SecureString secureString = new SecureString();
		for (int i = 0; i < array.Length; i++)
		{
			secureString.AppendChar(array[i]);
		}
		Array.Clear(array, 0, array.Length);
		return secureString;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static char[] _0xHC0cadae()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		long num = (long)(1.3333333333333333 * (double)array.Length);
		if (num % 4L != 0L)
		{
			num += 4L - num % 4L;
		}
		char[] array2 = new char[num];
		Convert.ToBase64CharArray(array, 0, array.Length, array2, 0);
		Array.Clear(array, 0, array.Length);
		return array2;
	}

	private static X509Certificate2 _0xHUnfr5itf5lly(string _0xHH8loth8nes, string _0xHTa8ter)
	{
		CX509ExtensionBasicConstraints cX509ExtensionBasicConstraints = (CX509ExtensionBasicConstraints)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("884E2016-217D-11DA-B2A4-000E7BBB2B09")));
		cX509ExtensionBasicConstraints.InitializeEncode(IsCA: false, int.MaxValue);
		CX500DistinguishedName cX500DistinguishedName = (CX500DistinguishedName)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("884E2003-217D-11DA-B2A4-000E7BBB2B09")));
		cX500DistinguishedName.Encode(_0xHH8loth8nes);
		CX509CertificateRequestCertificate cX509CertificateRequestCertificate = (CX509CertificateRequestCertificate)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("884E2043-217D-11DA-B2A4-000E7BBB2B09")));
		cX509CertificateRequestCertificate.Initialize(X509CertificateEnrollmentContext.ContextUser);
		cX509CertificateRequestCertificate.PrivateKey.ExportPolicy = X509PrivateKeyExportFlags.XCN_NCRYPT_ALLOW_EXPORT_FLAG;
		cX509CertificateRequestCertificate.PrivateKey.LegacyCsp = true;
		cX509CertificateRequestCertificate.PrivateKey.KeySpec = X509KeySpec.XCN_AT_KEYEXCHANGE;
		cX509CertificateRequestCertificate.PrivateKey.Length = 2048;
		cX509CertificateRequestCertificate.PrivateKey.Create();
		CObjectId cObjectId = (CObjectId)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("884E2000-217D-11DA-B2A4-000E7BBB2B09")));
		cObjectId.InitializeFromName(CERTENROLL_OBJECTID.XCN_OID_NIST_sha256);
		cX509CertificateRequestCertificate.HashAlgorithm = cObjectId;
		CX509Enrollment cX509Enrollment;
		try
		{
			cX509CertificateRequestCertificate.Subject = cX500DistinguishedName;
			cX509CertificateRequestCertificate.X509Extensions.Add((CX509Extension)cX509ExtensionBasicConstraints);
			cX509CertificateRequestCertificate.NotAfter = DateTime.Now.ToUniversalTime().AddYears(1);
			cX509Enrollment = (CX509Enrollment)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("884E2046-217D-11DA-B2A4-000E7BBB2B09")));
			cX509Enrollment.CertificateFriendlyName = _0xHTa8ter;
			cX509Enrollment.InitializeFromRequest(cX509CertificateRequestCertificate);
			cX509Enrollment.CreateRequest();
		}
		finally
		{
			cX509CertificateRequestCertificate.PrivateKey.Close();
		}
		cX509Enrollment.InstallResponse((InstallResponseRestrictionFlags)7, ((IX509CertificateRequestCertificate)cX509CertificateRequestCertificate).get_RawData(EncodingType.XCN_CRYPT_STRING_BASE64), EncodingType.XCN_CRYPT_STRING_BASE64, string.Empty);
		CCertProperties cCertProperties = (CCertProperties)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("884E202F-217D-11DA-B2A4-000E7BBB2B09")));
		cCertProperties.InitializeFromCertificate(MachineContext: false, EncodingType.XCN_CRYPT_STRING_BASE64, ((IX509CertificateRequestCertificate)cX509CertificateRequestCertificate).get_RawData(EncodingType.XCN_CRYPT_STRING_BASE64));
		string _0xH2roublers = null;
		for (int i = 0; i < cCertProperties.Count; i++)
		{
			if (cCertProperties[i].PropertyId == CERTENROLL_PROPERTYID.XCN_CERT_SHA1_HASH_PROP_ID)
			{
				_0xH2roublers = ((ICertProperty)cCertProperties[i]).get_RawData((EncodingType)1073741836);
				break;
			}
		}
		return _0xHFunda4ents(_0xH2roublers);
	}

	private static ICertificateStore _0xHGloz8(StoreName _0xHRebapti7m, StoreLocation _0xH4plines)
	{
		return _0xHBobbe0s ?? new _0xHF4ows(_0xHRebapti7m, _0xH4plines);
	}

	[SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1305:FieldNamesMustNotUseHungarianNotation", Justification = "Hungarian is handy when dealing with pointers.")]
	private static bool _0xHAnthr7p7l7gies(X509Certificate2 _0xH0aveless)
	{
		IntPtr handle = _0xH0aveless.Handle;
		int _0xH0rrelative = 0;
		if (!_0xHPollard8ng.CertGetCertificateContextProperty(handle, 2u, IntPtr.Zero, ref _0xH0rrelative))
		{
			return false;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(_0xH0rrelative);
		try
		{
			if (_0xHPollard8ng.CertGetCertificateContextProperty(handle, 2u, intPtr, ref _0xH0rrelative))
			{
				_0xHPollard8ng._0xHChu22ily _0xHChu22ily = new _0xHPollard8ng._0xHChu22ily();
				Marshal.PtrToStructure(intPtr, _0xHChu22ily);
				return _0xHChu22ily._0xHQua7tifier == 0;
			}
			return false;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}
}
