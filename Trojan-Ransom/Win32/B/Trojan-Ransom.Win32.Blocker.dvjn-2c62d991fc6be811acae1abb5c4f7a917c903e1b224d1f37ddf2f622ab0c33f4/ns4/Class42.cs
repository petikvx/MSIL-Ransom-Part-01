using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns9;

namespace ns4;

internal sealed class Class42
{
	internal static readonly string string_0 = Class15.smethod_0(952516);

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	public void method_1(Delegate10 delegate10_0)
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
					throw new ApplicationException(Class15.smethod_0(952432));
				}
				if (string_2 == Class15.smethod_0(952473))
				{
					string_2 = string_0;
				}
			}
			catch (Exception ex)
			{
				delegate10_0(Class15.smethod_0(952482) + ex.Message);
				return;
			}
		}
		delegate10_0(string_2.StartsWith(Class15.smethod_0(950020)) ? string_2 : Class15.smethod_0(949962));
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate10 delegate10_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
			}
			delegate10_0(reportingService.UploadReport2(string_1, byte_0, string_3, string_4, string_5));
		}
		catch (Exception ex)
		{
			delegate10_0(Class15.smethod_0(952499) + ex.Message);
		}
	}

	public Class42(string string_3)
	{
		string_1 = string_3;
	}
}
