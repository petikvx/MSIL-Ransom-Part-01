using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using ns2;

namespace ns5;

internal sealed class Class45
{
	internal static readonly string string_0 = "http://sawebservice.red-gate.com/";

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy proxy)
	{
		iwebProxy_0 = proxy;
	}

	public void method_1(Delegate5 whenDone)
	{
		if (string_2 == null)
		{
			try
			{
				UploadReportLoginService1 uploadReportLoginService = new UploadReportLoginService1();
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
				whenDone("ERR 2001: " + ex.Message);
				return;
			}
		}
		whenDone(string_2.StartsWith("ERR") ? string_2 : "OK");
	}

	public void method_2(byte[] data, string email, string appFriendlyName, string buildFriendlyNumber, Delegate5 whenDone)
	{
		try
		{
			ReportingService1 reportingService = new ReportingService1(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
			}
			whenDone(reportingService.UploadReport2(string_1, data, email, appFriendlyName, buildFriendlyNumber));
		}
		catch (Exception ex)
		{
			whenDone("ERR 2002: " + ex.Message);
		}
	}

	public Class45(string licenseID)
	{
		string_1 = licenseID;
	}
}
