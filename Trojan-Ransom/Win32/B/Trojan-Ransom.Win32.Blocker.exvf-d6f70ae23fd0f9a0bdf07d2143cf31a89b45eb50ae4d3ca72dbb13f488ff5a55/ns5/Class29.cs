using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using ns3;

namespace ns5;

internal class Class29
{
	internal static readonly string string_0 = "http://sawebservice.red-gate.com/";

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	public void method_1(Delegate2 delegate2_0)
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
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (string_2 == "ditto")
				{
					string_2 = string_0;
				}
			}
			catch (Exception ex)
			{
				delegate2_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate2_0(string_2.StartsWith("ERR") ? string_2 : "OK");
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate2 delegate2_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
			}
			delegate2_0(reportingService.UploadReport2(string_1, byte_0, string_3, string_4, string_5));
		}
		catch (Exception ex)
		{
			delegate2_0("ERR 2002: " + ex.Message);
		}
	}

	public Class29(string string_3)
	{
		string_1 = string_3;
	}
}
