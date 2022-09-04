using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class33
{
	internal static readonly string string_0 = Class5.smethod_0(82630);

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	public Class33(string CO_)
	{
		string_1 = CO_;
	}

	public void method_0(IWebProxy CO_)
	{
		iwebProxy_0 = CO_;
	}

	public void method_1(Delegate2 CO_)
	{
		if (string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				while (true)
				{
					if (iwebProxy_0 != null)
					{
						IWebProxy proxy = iwebProxy_0;
						if (0 == 0)
						{
							((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(proxy);
						}
					}
					string_2 = uploadReportLoginService.GetServerURL(string_1);
					if (string_2.Length != 0)
					{
						if (string_2 == Class5.smethod_0(82587))
						{
							if (0 == 0)
							{
								string_2 = string_0;
								break;
							}
							continue;
						}
						break;
					}
					throw new ApplicationException(Class5.smethod_0(82546));
				}
			}
			catch (Exception ex)
			{
				CO_(Class5.smethod_0(82596) + ex.Message);
				return;
			}
		}
		CO_(string_2.StartsWith(Class5.smethod_0(80133)) ? string_2 : Class5.smethod_0(80075));
	}

	public void method_2(byte[] CO_, string CO_, string CO_, string CO_, Delegate2 CO_)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_2);
			while (4 == 0 || iwebProxy_0 != null)
			{
				if (uint.MaxValue != 0)
				{
					IWebProxy proxy = iwebProxy_0;
					if (7u != 0)
					{
						((HttpWebClientProtocol)reportingService).set_Proxy(proxy);
					}
					break;
				}
			}
			CO_(reportingService.UploadReport2(string_1, CO_, CO_, CO_, CO_));
		}
		catch (Exception ex)
		{
			CO_(Class5.smethod_0(82613) + ex.Message);
		}
	}
}
