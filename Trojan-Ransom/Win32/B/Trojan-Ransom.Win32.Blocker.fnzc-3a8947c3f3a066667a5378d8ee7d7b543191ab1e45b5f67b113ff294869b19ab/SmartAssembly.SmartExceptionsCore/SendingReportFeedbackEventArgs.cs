using System;
using System.Runtime.CompilerServices;
using System.Security;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs : EventArgs
{
	internal SendingReportStep sendingReportStep_0;

	internal bool bool_0;

	internal string string_0 = string.Empty;

	internal string string_1 = string.Empty;

	public SendingReportStep Step => sendingReportStep_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_0;

	public string ReportID => string_1;

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2)
		: this(sendingReportStep_1, string_2, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2, string string_3)
	{
		SendingReportStep sendingReportStep = (sendingReportStep_0 = sendingReportStep_1);
		bool flag = (bool_0 = string_2 != null && Class3.smethod_1(string_2, 7, 111) > 0);
		string text = (string_0 = string_2);
		string text2 = (string_1 = string_3);
	}

	[SecuritySafeCritical]
	static SendingReportFeedbackEventArgs()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static string smethod_0(ref Guid guid_0, string string_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 60:
				return guid_0.ToString(string_2);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 55:
				RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
				return;
			}
		}
	}
}
