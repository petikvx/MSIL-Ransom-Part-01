using System;
using SmartAssembly.SmartExceptionsCore;

namespace ns4;

[GAttribute0(32)]
internal class Class9
{
	private string string_0;

	private string string_1 = string.Empty;

	public string method_0()
	{
		try
		{
			UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
			string_1 = uploadReportLoginService.GetServerURL(string_0);
			if (string_1.Length == 0)
			{
				throw new ApplicationException("慃湮瑯挠湯敮瑣琠\u206f敷獢牥楶散");
			}
			return string_1.StartsWith("剅") ? string_1 : "䭏";
		}
		catch (Exception ex)
		{
			return "剅⁒〲\u3130›" + ex.Message;
		}
	}

	public string method_1(byte[] byte_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(string_1);
			return reportingService.UploadReport2(string_0, byte_0);
		}
		catch (Exception ex)
		{
			return "剅⁒〲㈰›" + ex.Message;
		}
	}

	public Class9(string string_2)
	{
		string_0 = string_2;
	}
}
