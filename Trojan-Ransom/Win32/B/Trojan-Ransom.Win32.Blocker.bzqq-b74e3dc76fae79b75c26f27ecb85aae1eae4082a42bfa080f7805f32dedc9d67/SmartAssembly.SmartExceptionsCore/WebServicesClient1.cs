using System;
using System.Net;
using System.Web.Services.Protocols;

namespace SmartAssembly.SmartExceptionsCore;

internal class WebServicesClient1
{
	internal static readonly string UploadReportServer;

	private string licenseID;

	private string m_ServerURL;

	private IWebProxy proxy;

	public void SetProxy(IWebProxy proxy)
	{
		try
		{
			this.proxy = proxy;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, proxy);
			throw;
		}
	}

	public void LoginToServer(StringCallback1 whenDone)
	{
		UploadReportLoginService1 uploadReportLoginService = default(UploadReportLoginService1);
		Exception ex2 = default(Exception);
		try
		{
			if (m_ServerURL == null)
			{
				try
				{
					uploadReportLoginService = new UploadReportLoginService1();
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
					ex2 = ex;
					whenDone("ERR 2001: " + ex2.Message);
					return;
				}
			}
			whenDone(m_ServerURL.StartsWith("ERR") ? m_ServerURL : "OK");
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, uploadReportLoginService, ex2, this, whenDone);
			throw;
		}
	}

	public void Upload(byte[] data, string email, string appFriendlyName, string buildFriendlyNumber, StringCallback1 whenDone)
	{
		ReportingService1 reportingService = default(ReportingService1);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				reportingService = new ReportingService1(m_ServerURL);
				if (proxy != null)
				{
					((HttpWebClientProtocol)reportingService).set_Proxy(proxy);
				}
				whenDone(reportingService.UploadReport2(licenseID, data, email, appFriendlyName, buildFriendlyNumber));
			}
			catch (Exception ex)
			{
				ex2 = ex;
				whenDone("ERR 2002: " + ex2.Message);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, reportingService, ex2, this, data, email, appFriendlyName, buildFriendlyNumber, whenDone);
			throw;
		}
	}

	public WebServicesClient1(string licenseID)
	{
		try
		{
			this.licenseID = licenseID;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, licenseID);
			throw;
		}
	}

	static WebServicesClient1()
	{
		try
		{
			UploadReportServer = "http://sawebservice.red-gate.com/";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
