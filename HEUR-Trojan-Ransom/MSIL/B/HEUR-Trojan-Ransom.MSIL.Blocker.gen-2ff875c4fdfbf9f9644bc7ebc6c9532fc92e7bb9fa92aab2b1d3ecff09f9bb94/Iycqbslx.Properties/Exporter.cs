using System;
using System.IO;
using System.Net;
using System.Text;
using SHNB83.Listeners;
using SHNB83.Specifications;

namespace Iycqbslx.Properties;

internal static class Exporter
{
	internal static Exporter CompareUtils;

	internal static string SelectExporter(string setup)
	{
		try
		{
			HttpWebRequest httpWebRequest = WebRequest.Create(setup) as HttpWebRequest;
			httpWebRequest.Headers.Set("Operating-system", DatabaseAdapterSpec.RateExporter());
			int num = 0;
			if (RestartUtils() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: false));
				return streamReader.ReadToEnd();
			}
			}
		}
		catch (Exception ex)
		{
			Tag.FlushExporter(ex.StackTrace);
		}
		finally
		{
			Tag.AssetExporter("Get request to {0}", setup);
		}
		return string.Empty;
	}

	internal static bool PrintUtils()
	{
		return CompareUtils == null;
	}

	internal static Exporter RestartUtils()
	{
		return CompareUtils;
	}
}
