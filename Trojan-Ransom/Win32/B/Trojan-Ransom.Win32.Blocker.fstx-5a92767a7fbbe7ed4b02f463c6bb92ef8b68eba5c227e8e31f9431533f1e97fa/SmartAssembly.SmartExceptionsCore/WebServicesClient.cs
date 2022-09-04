using System;
using System.Net;
using System.Web.Services.Protocols;

namespace SmartAssembly.SmartExceptionsCore;

internal class WebServicesClient
{
	internal static readonly string UploadReportServer = "http://sawebservice.red-gate.com/";

	private string licenseID;

	private string m_ServerURL;

	private IWebProxy proxy;

	public void SetProxy(IWebProxy iwebProxy_0)
	{
		proxy = iwebProxy_0;
	}

	public void LoginToServer(StringCallback stringCallback_0)
	{
		if (m_ServerURL == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (proxy != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(proxy);
				}
				m_ServerURL = uploadReportLoginService.GetServerURL(licenseID);
				if (m_ServerURL.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (m_ServerURL == "ditto")
				{
					m_ServerURL = UploadReportServer;
				}
			}
			catch (Exception ex)
			{
				stringCallback_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		stringCallback_0(m_ServerURL.StartsWith("ERR") ? m_ServerURL : "OK");
	}

	public void Upload(byte[] byte_0, string string_0, string string_1, string string_2, StringCallback stringCallback_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(m_ServerURL);
			if (proxy != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(proxy);
			}
			stringCallback_0(reportingService.UploadReport2(licenseID, byte_0, string_0, string_1, string_2));
		}
		catch (Exception ex)
		{
			stringCallback_0("ERR 2002: " + ex.Message);
		}
	}

	public WebServicesClient(string string_0)
	{
		licenseID = string_0;
	}
}
