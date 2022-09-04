using System;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class Class29
	{
		private readonly Class31 class31_0;

		public bool bool_0 = true;

		internal ReportSender1 reportSender1_0;

		internal byte[] byte_0;

		internal Class34 class34_0;

		public Class29(ReportSender1 reportSender1_1, byte[] byte_1, Class34 class34_1, Class31 class31_1)
		{
			ReportSender1 o = default(ReportSender1);
			Class34 o2 = default(Class34);
			byte[] o3 = default(byte[]);
			try
			{
				try
				{
					o = (reportSender1_0 = reportSender1_1);
					class31_0 = class31_1;
					o2 = (class34_0 = class34_1);
					o3 = (byte_0 = byte_1);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, this, reportSender1_1, byte_1, class34_1, class31_1);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException8(exception2, o, o2, o3, this, reportSender1_1, byte_1, class34_1, class31_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			int num = default(int);
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			Class30 @class = default(Class30);
			string text = default(string);
			int num2 = default(int);
			try
			{
				try
				{
					num = 0;
					if (Class2.smethod_9(string_0, "OK", 71, 29))
					{
						num = 11;
						reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
						array = Class28.smethod_3(Class33.smethod_0(795, 838), "{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", 734, 680);
						num = 9;
						array2 = new byte[array.Length + byte_0.Length];
						num = 6;
						SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_1(array, array2, array.Length, 948, 1001);
						AppPathFinder.smethod_0(byte_0, 0, array2, array.Length, byte_0.Length, 776, 786);
						num = 5;
						@class = new Class30(reportSender1_0);
						class34_0.method_2(array2, class31_0.method_2(), class31_0.method_1(), class31_0.method_0(), @class.method_0);
						num = 7;
						bool_0 = @class.bool_0;
					}
					else
					{
						num = 4;
						text = string_0;
						if (reportSender1_0.sendingReportFeedbackEventHandler1_0 != null)
						{
							num = 3;
							reportSender1_0.sendingReportFeedbackEventHandler1_0(this, new SendingReportFeedbackEventArgs1(SendingReportStep1.ConnectingToServer, text));
						}
						else
						{
							num = 1;
						}
						bool_0 = false;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException6(exception, array, array2, @class, text, this, string_0);
					throw;
				}
				num2 = 4;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException8(exception2, array, array2, @class, text, num, num2, this, string_0);
				throw;
			}
		}

		static Class29()
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
	}

	private sealed class Class30
	{
		public bool bool_0;

		internal ReportSender1 reportSender1_0;

		public Class30(ReportSender1 reportSender1_1)
		{
			ReportSender1 o = default(ReportSender1);
			try
			{
				try
				{
					o = (reportSender1_0 = reportSender1_1);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, reportSender1_1);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, o, this, reportSender1_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			int num = default(int);
			try
			{
				try
				{
					num = 1;
					if (AppNameFinder.smethod_2(string_0, "ERR", 223, 152))
					{
						reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering, string_0);
						bool_0 = false;
					}
					else
					{
						reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Finished, string.Empty, string_0);
						bool_0 = true;
					}
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException2(exception, this, string_0);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException3(exception2, num, this, string_0);
				throw;
			}
		}

		static Class30()
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
	}

	internal sealed class Class31
	{
		public static Class31 class31_0;

		internal string string_0;

		internal string string_1;

		internal string string_2;

		public Class31(string string_3, string string_4, string string_5)
		{
			string o = default(string);
			string o2 = default(string);
			string o3 = default(string);
			try
			{
				try
				{
					o = (string_0 = string_3);
					o2 = (string_2 = string_5);
					o3 = (string_1 = string_4);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException4(exception, this, string_3, string_4, string_5);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, o, o2, o3, this, string_3, string_4, string_5);
				throw;
			}
		}

		[SpecialName]
		public string method_0()
		{
			string text = default(string);
			try
			{
				try
				{
					text = string_2;
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

		[SpecialName]
		public string method_1()
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

		[SpecialName]
		public string method_2()
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

		static Class31()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
				try
				{
					class31_0 = new Class31(null, null, null);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException0(exception);
					throw;
				}
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException0(exception2);
				throw;
			}
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	internal IWebProxy iwebProxy_0;

	internal SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler1_0;

	public event SendingReportFeedbackEventHandler1 SendingReportFeedback
	{
		add
		{
			int num = default(int);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			int num2 = default(int);
			try
			{
				try
				{
					num = 2;
					sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
					num = 1;
					do
					{
						sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
						sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)WaitSendingReportControl.smethod_3(sendingReportFeedbackEventHandler2, value, 413, 413);
						num = 6;
						sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
					}
					while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
					throw;
				}
				num2 = 2;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, num2, this, value);
				throw;
			}
		}
		remove
		{
			int num = default(int);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			int num2 = default(int);
			try
			{
				try
				{
					num = 6;
					sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
					num = 5;
					do
					{
						sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
						sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)AutoHeightLabel.smethod_2(sendingReportFeedbackEventHandler2, value, 526, 604);
						num = 2;
						sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
					}
					while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
					throw;
				}
				num2 = 0;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, num2, this, value);
				throw;
			}
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		IWebProxy o = default(IWebProxy);
		try
		{
			try
			{
				o = (iwebProxy_0 = proxy);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, proxy);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, o, this, proxy);
			throw;
		}
	}

	internal bool method_0(byte[] byte_0, Class31 class31_0)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		bool flag = default(bool);
		int num2 = default(int);
		byte[] array2 = default(byte[]);
		bool flag2 = default(bool);
		Class34 @class = default(Class34);
		Class29 class2 = default(Class29);
		int num3 = default(int);
		try
		{
			try
			{
				try
				{
					num = 1;
					array = SimpleZip.Zip(byte_0);
				}
				catch (Exception)
				{
					InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, SimpleZip.ExceptionMessage);
					flag = false;
					goto IL_001e;
				}
				num2 = 4;
				array2 = Class28.smethod_0(array, "<RSAKeyValue><Modulus>tD4LsHt5DvkuNayfApsr5CrN2wv0nGPr7RSMZFZe7PTJaKAiEUr1EgQuC2gxjwsI1FEXPujtmMRv+IYkJg9cLuORc3ZnYWjMglPOkqDDcTpvFRze2jmBOUxMDjbQvTV4EoaEYHNDwFNfDdWQnjzwtLSf2EBnOO2W1ntU7fnt5ac=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
				if (array2 == null)
				{
					num2 = 5;
					InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Class28.string_0);
					flag2 = false;
				}
				else
				{
					num2 = 3;
					InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
					@class = new Class34("!1b5d570f-4f6d-4187-55a3-b83778a63f94");
					if (iwebProxy_0 != null)
					{
						num2 = 8;
						@class.method_0(iwebProxy_0);
					}
					else
					{
						num2 = 7;
					}
					class2 = new Class29(this, array2, @class, class31_0);
					@class.method_1(class2.method_0);
					num2 = 0;
					flag2 = class2.bool_0;
				}
				goto end_IL_0000;
				IL_001e:
				flag2 = flag;
				end_IL_0000:;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, array, array2, @class, class2, flag, this, byte_0, class31_0);
				throw;
			}
			num3 = 3;
			return flag2;
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				array, array2, @class, class2, flag, flag2, num, num2, num3, this,
				byte_0, class31_0
			});
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage, string reportId)
	{
		int num = default(int);
		SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
		try
		{
			try
			{
				num = 3;
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
				sendingReportFeedbackEventHandler?.Invoke(this, new SendingReportFeedbackEventArgs1(step, errorMessage, reportId));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, this, step, errorMessage, reportId);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException6(exception2, sendingReportFeedbackEventHandler, num, this, step, errorMessage, reportId);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage)
	{
		try
		{
			try
			{
				InvokeSendingReportFeedback(step, errorMessage, string.Empty);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, this, step, errorMessage);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, this, step, errorMessage);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step)
	{
		try
		{
			try
			{
				InvokeSendingReportFeedback(step, string.Empty);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, step);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, this, step);
			throw;
		}
	}

	public ReportSender1()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static ReportSender1()
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

	internal static MethodInfo smethod_0(Type type_0, string string_0, Type[] type_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return type_0.GetMethod(string_0, type_1);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, type_0, string_0, type_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 126:
					stream_0.Write(byte_0, int_0, int_1);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException8(exception, num, num2, stream_0, byte_0, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static string smethod_2(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 124:
					return string_0.ToUpper();
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_3(ref short short_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return short_0.ToString(string_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, short_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static byte[] smethod_4(RSACryptoServiceProvider rsacryptoServiceProvider_0, byte[] byte_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 25:
					return rsacryptoServiceProvider_0.Encrypt(byte_0, bool_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, rsacryptoServiceProvider_0, byte_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static OperatingSystem smethod_5(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					return Environment.OSVersion;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_6(IsolatedStorageFile isolatedStorageFile_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 40:
					isolatedStorageFile_0.DeleteFile(string_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, isolatedStorageFile_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static IntPtr smethod_7(Graphics graphics_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 60:
					return graphics_0.GetHdc();
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, graphics_0, int_0, int_1);
			throw;
		}
	}
}
