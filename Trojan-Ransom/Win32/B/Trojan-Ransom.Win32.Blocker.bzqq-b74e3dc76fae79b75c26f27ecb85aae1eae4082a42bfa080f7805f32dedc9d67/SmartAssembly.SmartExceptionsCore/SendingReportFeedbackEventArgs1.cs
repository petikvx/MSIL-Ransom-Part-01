using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs1 : EventArgs
{
	internal SendingReportStep1 sendingReportStep1_0;

	internal bool bool_0;

	internal string string_0;

	internal string string_1;

	public SendingReportStep1 Step
	{
		get
		{
			SendingReportStep1 sendingReportStep = default(SendingReportStep1);
			try
			{
				try
				{
					sendingReportStep = sendingReportStep1_0;
					return sendingReportStep;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, sendingReportStep, this);
				throw;
			}
		}
	}

	public bool Failed
	{
		get
		{
			bool flag = default(bool);
			try
			{
				try
				{
					flag = bool_0;
					return flag;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, flag, this);
				throw;
			}
		}
	}

	public string ErrorMessage
	{
		get
		{
			string text = default(string);
			try
			{
				try
				{
					text = string_0;
					return text;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, text, this);
				throw;
			}
		}
	}

	public string ReportID
	{
		get
		{
			string text = default(string);
			try
			{
				try
				{
					text = string_1;
					return text;
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException1(exception, this);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException2(exception2, text, this);
				throw;
			}
		}
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_2)
		: this(sendingReportStep1_1, string_2, string.Empty)
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sendingReportStep1_1, string_2);
			throw;
		}
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_2, string string_3)
	{
		string o = (string_0 = string.Empty);
		string o2 = (string_1 = string.Empty);
		base._002Ector();
		SendingReportStep1 sendingReportStep = default(SendingReportStep1);
		bool flag = default(bool);
		string o3 = default(string);
		string o4 = default(string);
		try
		{
			try
			{
				sendingReportStep = (sendingReportStep1_0 = sendingReportStep1_1);
				flag = (bool_0 = string_2 != null && AppPathFinder.smethod_1(string_2, 648, 703) > 0);
				o3 = (string_0 = string_2);
				o4 = (string_1 = string_3);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, sendingReportStep1_1, string_2, string_3);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException10(exception2, o, o2, sendingReportStep, flag, o3, o4, this, sendingReportStep1_1, string_2, string_3);
			throw;
		}
	}

	static SendingReportFeedbackEventArgs1()
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

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return Type.GetTypeFromHandle(runtimeTypeHandle_0);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, runtimeTypeHandle_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_1(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 57:
					return encoding_0.GetString(byte_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, encoding_0, byte_0, int_0, int_1);
			throw;
		}
	}

	internal static string[] smethod_2(string string_2, char[] char_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 29:
					return string_2.Split(char_0);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_2, char_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_3(string string_2, string string_3, string string_4, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 60:
					return string_2 + string_3 + string_4;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, string_2, string_3, string_4, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(Label label_0, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 17:
					label_0.set_FlatStyle(flatStyle_0);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, label_0, flatStyle_0, int_0, int_1);
			throw;
		}
	}

	internal static ApartmentState smethod_5(Thread thread_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 81:
					return thread_0.ApartmentState;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, thread_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_6(PictureBox pictureBox_0, PictureBoxSizeMode pictureBoxSizeMode_0, int int_0, int int_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 81:
					pictureBox_0.set_SizeMode(pictureBoxSizeMode_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, pictureBox_0, pictureBoxSizeMode_0, int_0, int_1);
			throw;
		}
	}

	internal static Cursor smethod_7(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 107:
					return Cursors.get_Hand();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}
}
