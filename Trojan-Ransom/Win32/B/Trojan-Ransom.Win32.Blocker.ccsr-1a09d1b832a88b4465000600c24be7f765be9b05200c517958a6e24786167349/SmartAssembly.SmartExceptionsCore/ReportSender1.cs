using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class Class26
	{
		private readonly Class28 class28_0;

		public bool bool_0 = true;

		internal ReportSender1 reportSender1_0;

		internal byte[] byte_0;

		internal Class31 class31_0;

		public Class26(ReportSender1 reportSender1_1, byte[] byte_1, Class31 class31_1, Class28 class28_1)
		{
			try
			{
				ReportSender1 reportSender = (reportSender1_0 = reportSender1_1);
				class28_0 = class28_1;
				Class31 @class = (class31_0 = class31_1);
				byte[] array = (byte_0 = byte_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, this, reportSender1_1, byte_1, class31_1, class28_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			Class27 @class = default(Class27);
			string text = default(string);
			try
			{
				if (string_0 == "OK")
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
					array = Win32.smethod_12(Class20.smethod_2(326, 296), "{E8999F69-FF1B-4846-9283-897940EB0660}", 893, 787);
					array2 = new byte[array.Length + byte_0.Length];
					Array.Copy(array, array2, array.Length);
					SendingReportFeedbackEventArgs.smethod_0(byte_0, 0, array2, array.Length, byte_0.Length, 143, 166);
					@class = new Class27(reportSender1_0);
					class31_0.method_2(array2, class28_0.method_2(), class28_0.method_1(), class28_0.method_0(), @class.method_0);
					bool_0 = @class.bool_0;
				}
				else
				{
					text = string_0;
					if (reportSender1_0.sendingReportFeedbackEventHandler1_0 != null)
					{
						reportSender1_0.sendingReportFeedbackEventHandler1_0(this, new SendingReportFeedbackEventArgs1(SendingReportStep1.ConnectingToServer, text));
					}
					bool_0 = false;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, array, array2, @class, text, this, string_0);
				throw;
			}
		}

		static Class26()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	private sealed class Class27
	{
		public bool bool_0;

		internal ReportSender1 reportSender1_0;

		public Class27(ReportSender1 reportSender1_1)
		{
			try
			{
				ReportSender1 reportSender = (reportSender1_0 = reportSender1_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, reportSender1_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			try
			{
				if (Win32.smethod_9(string_0, "ERR", 442, 418))
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

		static Class27()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	internal sealed class Class28
	{
		public static Class28 class28_0;

		internal string string_0;

		internal string string_1;

		internal string string_2;

		public Class28(string string_3, string string_4, string string_5)
		{
			try
			{
				string text = (string_0 = string_3);
				string text2 = (string_2 = string_5);
				string text3 = (string_1 = string_4);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, string_3, string_4, string_5);
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
				StackFrameHelper.CreateException1(exception, this);
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
				StackFrameHelper.CreateException1(exception, this);
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
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		static Class28()
		{
			DESCryptoIndirector.smethod_0();
			try
			{
				class28_0 = new Class28(null, null, null);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3186)]
	private struct Struct27
	{
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal IWebProxy iwebProxy_0;

	internal SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler1_0;

	public event SendingReportFeedbackEventHandler1 SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			try
			{
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)Class18.smethod_0(sendingReportFeedbackEventHandler2, value, 41, 1);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
				throw;
			}
		}
		remove
		{
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			try
			{
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)Delegate.Remove(sendingReportFeedbackEventHandler2, value);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
				throw;
			}
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		try
		{
			IWebProxy webProxy = (iwebProxy_0 = proxy);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, proxy);
			throw;
		}
	}

	internal bool method_0(byte[] byte_1, Class28 class28_0)
	{
		byte[] o = default(byte[]);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		Class31 @class = default(Class31);
		Class26 class2 = default(Class26);
		try
		{
			try
			{
				o = SimpleZip.Zip(byte_1);
			}
			catch (Exception)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, SimpleZip.ExceptionMessage);
				flag = false;
				return flag;
			}
			array = Class25.smethod_0(o, "<RSAKeyValue><Modulus>znwYeoTG6J3QopcRcVswJImI+sp841M9VIxjD0lwpQSIUbCGhs7GlMCO0wcXiv0A4XdWnvGHlxBCVBqx89h2hXKJ6VXiOgcxb17pgdTbMMqlj0hezKhZRm93xjdaMR7DiqWlfEot945SsraToAkIcII0lEug/xhK9gQuHLj4O0E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array == null)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Class25.string_0);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
			@class = new Class31("d98c1dd4-008f-04b2-e980-0998ecf8427e");
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			class2 = new Class26(this, array, @class, class28_0);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, o, array, @class, class2, flag, this, byte_1, class28_0);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage, string reportId)
	{
		SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
		try
		{
			sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
			sendingReportFeedbackEventHandler?.Invoke(this, new SendingReportFeedbackEventArgs1(step, errorMessage, reportId));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, this, step, errorMessage, reportId);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage)
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

	protected void InvokeSendingReportFeedback(SendingReportStep1 step)
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

	static ReportSender1()
	{
		DESCryptoIndirector.smethod_0();
		char_1 = new char[1593];
		char[] array = new char[8];
		array[3] = '\u082d';
		array[4] = '\u0952';
		array[0] = '㤖';
		array[2] = '⛱';
		array[5] = 'ᡑ';
		array[6] = 'ໞ';
		array[1] = 'ᮞ';
		array[7] = '૦';
		string_0 = new string[45];
		char_0 = array;
	}

	internal static void smethod_0(CheckBox checkBox_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 39:
				checkBox_0.add_CheckedChanged(eventHandler_0);
				return;
			}
		}
	}

	internal static int smethod_1(double double_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 44:
				return Convert.ToInt32(double_0);
			}
		}
	}
}
