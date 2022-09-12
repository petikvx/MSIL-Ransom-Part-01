using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;
using ns7;

namespace ns4;

internal sealed class Class36
{
	internal static readonly string string_0;

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	[NonSerialized]
	internal static GetString getString_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	public void method_1(Delegate3 delegate3_0)
	{
		if (string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(iwebProxy_0);
				}
				string_2 = uploadReportLoginService.GetServerURL(string_1);
				if (string_2.Length == 0)
				{
					throw new ApplicationException(getString_0(107388131));
				}
				if (string_2 == getString_0(107388090))
				{
					string_2 = string_0;
				}
			}
			catch (Exception ex)
			{
				delegate3_0(getString_0(107388113) + ex.Message);
				return;
			}
		}
		delegate3_0(string_2.StartsWith(getString_0(107388064)) ? string_2 : getString_0(107388059));
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate3 delegate3_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
			}
			delegate3_0(reportingService.UploadReport2(string_1, byte_0, string_3, string_4, string_5));
		}
		catch (Exception ex)
		{
			delegate3_0(getString_0(107388054) + ex.Message);
		}
	}

	public Class36(string string_3)
	{
		string_1 = string_3;
	}

	static Class36()
	{
		Strings.CreateGetStringDelegate(typeof(Class36));
		string_0 = getString_0(107388069);
	}
}
