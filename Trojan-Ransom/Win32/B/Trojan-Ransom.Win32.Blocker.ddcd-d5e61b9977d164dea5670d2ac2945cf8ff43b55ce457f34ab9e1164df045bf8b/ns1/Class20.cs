using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;

namespace ns1;

internal sealed class Class20
{
	private string string_0;

	private string string_1 = string.Empty;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	public string method_1()
	{
		try
		{
			UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(iwebProxy_0);
			}
			string_1 = uploadReportLoginService.GetServerURL(string_0);
			if (string_1.Length == 0)
			{
				throw new ApplicationException("Cannot connect to webservice");
			}
			return string_1.StartsWith("ERR") ? string_1 : "OK";
		}
		catch (Exception ex)
		{
			return "ERR 2001: " + ex.Message;
		}
	}

	public string method_2(byte[] byte_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_1);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
			}
			return reportingService.UploadReport2(string_0, byte_0);
		}
		catch (Exception ex)
		{
			return "ERR 2002: " + ex.Message;
		}
	}

	public Class20(string string_2)
	{
		string_0 = string_2;
	}
}
