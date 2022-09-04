using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;
using ns2;

namespace ns3;

internal sealed class Class13
{
	[NonSerialized]
	internal static GetString getString_0;

	internal static readonly string string_0;

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	public void method_1(Delegate0 delegate0_0)
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
					throw new ApplicationException(getString_0(3926));
				}
				if (string_2 == getString_0(3967))
				{
					string_2 = string_0;
				}
			}
			catch (Exception ex)
			{
				delegate0_0(getString_0(3976) + ex.Message);
				return;
			}
		}
		delegate0_0(string_2.StartsWith(getString_0(1364)) ? string_2 : getString_0(1306));
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate0 delegate0_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
			}
			delegate0_0(reportingService.UploadReport2(string_1, byte_0, string_3, string_4, string_5));
		}
		catch (Exception ex)
		{
			delegate0_0(getString_0(3993) + ex.Message);
		}
	}

	public Class13(string string_3)
	{
		string_1 = string_3;
	}

	static Class13()
	{
		Strings.CreateGetStringDelegate(typeof(Class13));
		string_0 = getString_0(4010);
	}
}
