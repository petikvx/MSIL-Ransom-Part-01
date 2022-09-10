using System;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs1 : EventArgs
{
	internal SendingReportStep1 sendingReportStep1_0;

	internal bool bool_0;

	internal string string_0 = string.Empty;

	internal string string_1 = string.Empty;

	public SendingReportStep1 Step
	{
		get
		{
			try
			{
				return sendingReportStep1_0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public bool Failed
	{
		get
		{
			try
			{
				return bool_0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public string ErrorMessage
	{
		get
		{
			try
			{
				return string_0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public string ReportID
	{
		get
		{
			try
			{
				return string_1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_2)
		: this(sendingReportStep1_1, string_2, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_2, string string_3)
	{
		try
		{
			SendingReportStep1 sendingReportStep = (sendingReportStep1_0 = sendingReportStep1_1);
			bool flag = (bool_0 = string_2 != null && PoweredBy.smethod_0(string_2, 803, 883) > 0);
			string text = (string_0 = string_2);
			string text2 = (string_1 = string_3);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, this, sendingReportStep1_1, string_2, string_3);
			throw;
		}
	}

	static SendingReportFeedbackEventArgs1()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static string smethod_0(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				return control_0.get_Text();
			}
		}
	}

	internal static Module smethod_1(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return assembly_0.ManifestModule;
			}
		}
	}
}
