using System;
using System.Drawing;
using System.Reflection;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs : EventArgs
{
	internal SendingReportStep sendingReportStep_0;

	internal bool bool_0;

	internal string string_0;

	internal string string_1;

	public SendingReportStep Step
	{
		get
		{
			try
			{
				return sendingReportStep_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
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
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
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
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
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
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2)
		: this(sendingReportStep_1, string_2, string.Empty)
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sendingReportStep_1, string_2);
			throw;
		}
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2, string string_3)
	{
		string o = (string_0 = string.Empty);
		string o2 = (string_1 = string.Empty);
		base._002Ector();
		SendingReportStep sendingReportStep = default(SendingReportStep);
		bool flag = default(bool);
		string o3 = default(string);
		string o4 = default(string);
		try
		{
			sendingReportStep = (sendingReportStep_0 = sendingReportStep_1);
			flag = (bool_0 = string_2 != null && AppPathFinder.smethod_1(string_2, 18, 37) > 0);
			o3 = (string_0 = string_2);
			o4 = (string_1 = string_3);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException10(exception, o, o2, sendingReportStep, flag, o3, o4, this, sendingReportStep_1, string_2, string_3);
			throw;
		}
	}

	static SendingReportFeedbackEventArgs()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static PropertyInfo smethod_0(Type type_0, string string_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 51:
					return type_0.GetProperty(string_2);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, type_0, string_2, int_0, int_1);
			throw;
		}
	}

	internal static byte smethod_1(ref Color color_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 118:
					return color_0.B;
				case 119:
					return color_0.G;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, color_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_2(string string_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					return Convert.ToBoolean(string_2);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_2, int_0, int_1);
			throw;
		}
	}
}
