using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using ns4;
using ns9;

namespace ns3;

internal sealed class Class52
{
	internal static readonly string string_0;

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		try
		{
			iwebProxy_0 = iwebProxy_1;
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, this, iwebProxy_1);
			throw;
		}
	}

	public void method_1(Delegate12 delegate12_0)
	{
		UploadReportLoginService1 uploadReportLoginService = default(UploadReportLoginService1);
		Exception ex2 = default(Exception);
		try
		{
			if (string_2 == null)
			{
				try
				{
					uploadReportLoginService = new UploadReportLoginService1();
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
					ex2 = ex;
					delegate12_0(Class15.smethod_0(952482) + ex2.Message);
					return;
				}
			}
			delegate12_0(string_2.StartsWith(Class15.smethod_0(950020)) ? string_2 : Class15.smethod_0(949962));
		}
		catch (Exception exception_)
		{
			Class38.smethod_4(exception_, uploadReportLoginService, ex2, this, delegate12_0);
			throw;
		}
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate12 delegate12_0)
	{
		ReportingService1 reportingService = default(ReportingService1);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				reportingService = new ReportingService1(string_2);
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)reportingService).set_Proxy(iwebProxy_0);
				}
				delegate12_0(reportingService.UploadReport2(string_1, byte_0, string_3, string_4, string_5));
			}
			catch (Exception ex)
			{
				ex2 = ex;
				delegate12_0(Class15.smethod_0(952499) + ex2.Message);
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_8(exception_, reportingService, ex2, this, byte_0, string_3, string_4, string_5, delegate12_0);
			throw;
		}
	}

	public Class52(string string_3)
	{
		try
		{
			string_1 = string_3;
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, this, string_3);
			throw;
		}
	}

	static Class52()
	{
		try
		{
			string_0 = Class15.smethod_0(952516);
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}
}
