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

	public void SetProxy(IWebProxy proxy)
	{
		this.proxy = proxy;
	}

	public void LoginToServer(StringCallback whenDone)
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
				whenDone("ERR 2001: " + ex.Message);
				return;
			}
		}
		whenDone(m_ServerURL.StartsWith("ERR") ? m_ServerURL : "OK");
	}

	public void Upload(byte[] data, string email, string appFriendlyName, string buildFriendlyNumber, StringCallback whenDone)
	{
		try
		{
			ReportingService reportingService = new ReportingService(m_ServerURL);
			if (proxy != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(proxy);
			}
			whenDone(reportingService.UploadReport2(licenseID, data, email, appFriendlyName, buildFriendlyNumber));
		}
		catch (Exception ex)
		{
			whenDone("ERR 2002: " + ex.Message);
		}
	}

	public WebServicesClient(string licenseID)
	{
		this.licenseID = licenseID;
	}
}
