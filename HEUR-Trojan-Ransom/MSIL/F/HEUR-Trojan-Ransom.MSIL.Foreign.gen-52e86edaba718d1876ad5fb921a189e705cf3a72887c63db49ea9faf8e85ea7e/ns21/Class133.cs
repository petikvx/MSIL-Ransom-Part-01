using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns19;
using ns20;

namespace ns21;

internal sealed class Class133
{
	private MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	private static Dictionary<string, SslProtocols> dictionary_0;

	private static Dictionary<string, int> dictionary_1;

	private static SslProtocols[] sslProtocols_0;

	private static object object_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class133(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		mySqlConnectionStringBuilder_0 = mySqlConnectionStringBuilder_1;
	}

	private X509CertificateCollection method_0()
	{
		X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
		if (mySqlConnectionStringBuilder_0.CertificateFile != null)
		{
			X509Certificate2 value = new X509Certificate2(mySqlConnectionStringBuilder_0.CertificateFile, mySqlConnectionStringBuilder_0.CertificatePassword);
			x509CertificateCollection.Add(value);
			return x509CertificateCollection;
		}
		if (mySqlConnectionStringBuilder_0.CertificateStoreLocation == Enum44.const_0)
		{
			return x509CertificateCollection;
		}
		StoreLocation storeLocation = ((mySqlConnectionStringBuilder_0.CertificateStoreLocation == Enum44.const_1) ? StoreLocation.CurrentUser : StoreLocation.LocalMachine);
		X509Store x509Store = new X509Store(StoreName.My, storeLocation);
		x509Store.Open(OpenFlags.OpenExistingOnly);
		if (mySqlConnectionStringBuilder_0.CertificateThumbprint == null)
		{
			x509CertificateCollection.AddRange(x509Store.Certificates);
			return x509CertificateCollection;
		}
		x509CertificateCollection.AddRange(x509Store.Certificates.Find(X509FindType.FindByThumbprint, mySqlConnectionStringBuilder_0.CertificateThumbprint, validOnly: true));
		if (x509CertificateCollection.Count == 0)
		{
			throw new MySqlException(getString_0(107356846) + mySqlConnectionStringBuilder_0.CertificateThumbprint + getString_0(107356805));
		}
		return x509CertificateCollection;
	}

	public Class168 method_1(ref Stream stream_0, Encoding encoding_0, string string_0)
	{
		RemoteCertificateValidationCallback userCertificateValidationCallback = method_2;
		SslStream sslStream = new SslStream(stream_0, leaveInnerStreamOpen: false, userCertificateValidationCallback, null);
		X509CertificateCollection clientCertificates = method_0();
		string key = string_0.GetHashCode().ToString();
		SslProtocols sslProtocols = SslProtocols.Tls;
		lock (object_0)
		{
			if (dictionary_0.ContainsKey(key))
			{
				sslProtocols = dictionary_0[key];
			}
			else
			{
				if (!dictionary_1.ContainsKey(key))
				{
					dictionary_1[key] = 0;
				}
				for (int i = dictionary_1[key]; i < sslProtocols_0.Length; i++)
				{
					sslProtocols |= sslProtocols_0[i];
				}
			}
			try
			{
				sslStream.AuthenticateAsClientAsync(mySqlConnectionStringBuilder_0.Server, clientCertificates, sslProtocols, checkCertificateRevocation: false).Wait();
				dictionary_0[key] = sslProtocols;
				dictionary_1.Remove(key);
			}
			catch (AggregateException ex)
			{
				if (ex.GetBaseException() is IOException)
				{
					dictionary_0.Remove(key);
					if (dictionary_1.ContainsKey(key))
					{
						if (dictionary_1[key] > sslProtocols_0.Length)
						{
							throw new MySqlException(Class121.SslConnectionError, ex);
						}
						dictionary_1[key]++;
					}
				}
				throw ex.GetBaseException();
			}
		}
		stream_0 = sslStream;
		return new Class168(sslStream, encoding_0, bool_0: false)
		{
			SequenceByte = 2
		};
	}

	private bool method_2(object object_1, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
	{
		if (sslPolicyErrors_0 == SslPolicyErrors.None)
		{
			return true;
		}
		if (mySqlConnectionStringBuilder_0.SslMode == Enum42.const_1)
		{
			return true;
		}
		if (mySqlConnectionStringBuilder_0.SslMode == Enum42.const_2 && sslPolicyErrors_0 == SslPolicyErrors.RemoteCertificateNameMismatch)
		{
			return true;
		}
		return false;
	}

	static Class133()
	{
		Strings.CreateGetStringDelegate(typeof(Class133));
		dictionary_0 = new Dictionary<string, SslProtocols>();
		dictionary_1 = new Dictionary<string, int>();
		sslProtocols_0 = new SslProtocols[2]
		{
			SslProtocols.Tls12,
			SslProtocols.Tls11
		};
		object_0 = new object();
	}
}
