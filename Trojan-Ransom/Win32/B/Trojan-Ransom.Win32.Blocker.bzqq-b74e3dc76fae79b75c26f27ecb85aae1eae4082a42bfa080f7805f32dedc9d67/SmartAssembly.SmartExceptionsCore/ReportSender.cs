using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private sealed class Class18
	{
		private readonly Class20 class20_0;

		public bool bool_0 = true;

		internal ReportSender reportSender_0;

		internal byte[] byte_0;

		internal Class25 class25_0;

		public Class18(ReportSender reportSender_1, byte[] byte_1, Class25 class25_1, Class20 class20_1)
		{
			ReportSender o = default(ReportSender);
			Class25 o2 = default(Class25);
			byte[] o3 = default(byte[]);
			try
			{
				o = (reportSender_0 = reportSender_1);
				class20_0 = class20_1;
				o2 = (class25_0 = class25_1);
				o3 = (byte_0 = byte_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, o, o2, o3, this, reportSender_1, byte_1, class25_1, class20_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			int num = default(int);
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			Class19 @class = default(Class19);
			string text = default(string);
			try
			{
				num = 2;
				if (Class2.smethod_9(string_0, "OK", 780, 854))
				{
					num = 8;
					reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering);
					array = Class28.smethod_3(Class33.smethod_0(928, 1021), "{7BC8269A-DFA7-4C63-92DF-CECB0FBA593D}", 768, 886);
					num = 7;
					array2 = new byte[array.Length + byte_0.Length];
					num = 6;
					SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_1(array, array2, array.Length, 509, 416);
					AppPathFinder.smethod_0(byte_0, 0, array2, array.Length, byte_0.Length, 950, 940);
					num = 4;
					@class = new Class19(reportSender_0);
					class25_0.method_2(array2, class20_0.method_2(), class20_0.method_1(), class20_0.method_0(), @class.method_0);
					num = 0;
					bool_0 = @class.bool_0;
				}
				else
				{
					text = string_0;
					if (reportSender_0.sendingReportFeedbackEventHandler_0 != null)
					{
						reportSender_0.sendingReportFeedbackEventHandler_0(this, new SendingReportFeedbackEventArgs(SendingReportStep.ConnectingToServer, text));
					}
					bool_0 = false;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException8(exception, array, array2, @class, text, num, num2, this, string_0);
				throw;
			}
		}

		static Class18()
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

	private sealed class Class19
	{
		public bool bool_0;

		internal ReportSender reportSender_0;

		public Class19(ReportSender reportSender_1)
		{
			ReportSender o = default(ReportSender);
			try
			{
				o = (reportSender_0 = reportSender_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, o, this, reportSender_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			int num = default(int);
			try
			{
				num = 2;
				if (AppNameFinder.smethod_2(string_0, "ERR", 279, 336))
				{
					num = 3;
					reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering, string_0);
					bool_0 = false;
				}
				else
				{
					reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Finished, string.Empty, string_0);
					bool_0 = true;
				}
			}
			catch (Exception exception)
			{
				int num2 = default(int);
				StackFrameHelper.CreateException4(exception, num, num2, this, string_0);
				throw;
			}
		}

		static Class19()
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

	internal sealed class Class20
	{
		public static Class20 class20_0;

		internal string string_0;

		internal string string_1;

		internal string string_2;

		public Class20(string string_3, string string_4, string string_5)
		{
			string o = default(string);
			string o2 = default(string);
			string o3 = default(string);
			try
			{
				o = (string_0 = string_3);
				o2 = (string_2 = string_5);
				o3 = (string_1 = string_4);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, o, o2, o3, this, string_3, string_4, string_5);
				throw;
			}
		}

		[SpecialName]
		public string method_0()
		{
			try
			{
				return string_2;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		[SpecialName]
		public string method_1()
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

		[SpecialName]
		public string method_2()
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

		static Class20()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
				class20_0 = new Class20(null, null, null);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	internal IWebProxy iwebProxy_0;

	internal SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler_0;

	public event SendingReportFeedbackEventHandler SendingReportFeedback
	{
		add
		{
			int num = default(int);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler);
			try
			{
				num = 1;
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
				num = 3;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler)WaitSendingReportControl.smethod_3(sendingReportFeedbackEventHandler2, value, 912, 912);
					num = 4;
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, this, value);
				throw;
			}
		}
		remove
		{
			int num = default(int);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler);
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler);
			try
			{
				num = 4;
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
				num = 1;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler)AutoHeightLabel.smethod_2(sendingReportFeedbackEventHandler2, value, 687, 765);
					num = 2;
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, this, value);
				throw;
			}
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		IWebProxy o = default(IWebProxy);
		try
		{
			o = (iwebProxy_0 = proxy);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, o, this, proxy);
			throw;
		}
	}

	internal bool method_0(byte[] byte_0, Class20 class20_0)
	{
		int num = default(int);
		byte[] array = default(byte[]);
		bool flag = default(bool);
		int num2 = default(int);
		byte[] array2 = default(byte[]);
		Class25 @class = default(Class25);
		Class18 class2 = default(Class18);
		try
		{
			try
			{
				num = 2;
				array = SimpleZip.Zip(byte_0);
			}
			catch (Exception)
			{
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport, SimpleZip.ExceptionMessage);
				flag = false;
				return flag;
			}
			num2 = 4;
			array2 = Class16.smethod_0(array, "<RSAKeyValue><Modulus>tD4LsHt5DvkuNayfApsr5CrN2wv0nGPr7RSMZFZe7PTJaKAiEUr1EgQuC2gxjwsI1FEXPujtmMRv+IYkJg9cLuORc3ZnYWjMglPOkqDDcTpvFRze2jmBOUxMDjbQvTV4EoaEYHNDwFNfDdWQnjzwtLSf2EBnOO2W1ntU7fnt5ac=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array2 == null)
			{
				num2 = 3;
				InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class16.string_0);
				return false;
			}
			num2 = 6;
			InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
			@class = new Class25("!1b5d570f-4f6d-4187-55a3-b83778a63f94");
			if (iwebProxy_0 != null)
			{
				num2 = 8;
				@class.method_0(iwebProxy_0);
			}
			else
			{
				num2 = 7;
			}
			class2 = new Class18(this, array2, @class, class20_0);
			@class.method_1(class2.method_0);
			num2 = 2;
			return class2.bool_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException10(exception, array, array2, @class, class2, flag, num, num2, this, byte_0, class20_0);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step, string errorMessage, string reportId)
	{
		int num = default(int);
		SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler);
		try
		{
			num = 4;
			sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
			sendingReportFeedbackEventHandler?.Invoke(this, new SendingReportFeedbackEventArgs(step, errorMessage, reportId));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, sendingReportFeedbackEventHandler, num, this, step, errorMessage, reportId);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step, string errorMessage)
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

	protected void InvokeSendingReportFeedback(SendingReportStep step)
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

	public ReportSender()
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

	static ReportSender()
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

	internal static Size smethod_0(Form form_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 11:
					return form_0.get_ClientSize();
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, form_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_1(ref Size size_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 106:
					return size_0.Height;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, size_0, int_0, int_1);
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
				case 42:
					return Path.GetFileName(string_0);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 85:
					Monitor.Exit(object_0);
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, object_0, int_0, int_1);
			throw;
		}
	}
}
