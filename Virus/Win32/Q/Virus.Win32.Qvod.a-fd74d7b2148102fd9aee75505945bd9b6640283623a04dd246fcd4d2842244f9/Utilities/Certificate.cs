using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Utilities;

internal class Certificate
{
	private static string szOID_KEY_USAGE = "2.5.29.15";

	private static string szOID_ENHANCED_KEY_USAGE = "2.5.29.37";

	private static string szOID_CODE_SIGNING = "1.3.6.1.5.5.7.3.3";

	public static bool CanSignWith(X509Certificate2 cert)
	{
		bool result = true;
		if (cert.Extensions.Count > 0)
		{
			X509ExtensionEnumerator enumerator = cert.Extensions.GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Extension current = enumerator.Current;
				bool? flag = null;
				if (string.Compare(current.Oid!.Value, szOID_KEY_USAGE, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
				{
					X509KeyUsageExtension x509KeyUsageExtension = new X509KeyUsageExtension();
					x509KeyUsageExtension.CopyFrom(current);
					if ((x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.DigitalSignature) != 0)
					{
						X509ExtensionEnumerator enumerator2 = cert.Extensions.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							X509Extension current2 = enumerator2.Current;
							flag = CodeSignEnhancedKeyPresent(current2);
							if (flag.HasValue)
							{
								result = flag.Value;
								break;
							}
						}
						break;
					}
					result = false;
				}
				else
				{
					flag = CodeSignEnhancedKeyPresent(current);
					if (flag.HasValue && !flag.Value)
					{
						result = false;
					}
				}
			}
		}
		return result;
	}

	private static bool? CodeSignEnhancedKeyPresent(X509Extension extension)
	{
		bool? result = null;
		if (string.Compare(extension.Oid!.Value, szOID_ENHANCED_KEY_USAGE, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
		{
			if (extension is X509EnhancedKeyUsageExtension x509EnhancedKeyUsageExtension)
			{
				OidEnumerator enumerator = x509EnhancedKeyUsageExtension.EnhancedKeyUsages.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Oid current = enumerator.Current;
					if (string.Compare(current.Value, szOID_CODE_SIGNING, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
					{
						result = true;
						break;
					}
				}
			}
			if (!result.HasValue)
			{
				result = false;
			}
		}
		return result;
	}

	public static bool HasPrivateKey(X509Certificate2 cert)
	{
		return cert.PrivateKey != null;
	}
}
