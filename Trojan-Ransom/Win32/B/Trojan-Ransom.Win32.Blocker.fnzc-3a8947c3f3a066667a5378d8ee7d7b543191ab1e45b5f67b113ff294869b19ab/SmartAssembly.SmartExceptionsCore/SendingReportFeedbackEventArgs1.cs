using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs1 : EventArgs
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1394)]
	private struct Struct17
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal SendingReportStep1 sendingReportStep1_0;

	internal bool bool_0;

	internal string string_1 = string.Empty;

	internal string string_2 = string.Empty;

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
				return string_1;
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
				return string_2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_3)
		: this(sendingReportStep1_1, string_3, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_3, string string_4)
	{
		try
		{
			SendingReportStep1 sendingReportStep = (sendingReportStep1_0 = sendingReportStep1_1);
			bool flag = (bool_0 = string_3 != null && Class3.smethod_1(string_3, 119, 31) > 0);
			string text = (string_1 = string_3);
			string text2 = (string_2 = string_4);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, this, sendingReportStep1_1, string_3, string_4);
			throw;
		}
	}

	[SecuritySafeCritical]
	static SendingReportFeedbackEventArgs1()
	{
		Class32.smethod_1();
		char_1 = new char[697];
		char[] array = new char[8];
		array[7] = 'ȡ';
		array[1] = '\u12c7';
		array[3] = 'ܣ';
		array[6] = 'ጧ';
		array[2] = '㯌';
		array[0] = '⦅';
		array[5] = 'ᕾ';
		array[4] = '⌙';
		string_0 = new string[43];
		char_0 = array;
	}

	[SecuritySafeCritical]
	internal static string smethod_0(string string_3, string string_4, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return Path.Combine(string_3, string_4);
			}
		}
	}

	[SecuritySafeCritical]
	internal static IntPtr smethod_1(Font font_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				return font_0.ToHfont();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(ContainerControl containerControl_0, SizeF sizeF_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				containerControl_0.set_AutoScaleDimensions(sizeF_0);
				return;
			}
		}
	}
}
