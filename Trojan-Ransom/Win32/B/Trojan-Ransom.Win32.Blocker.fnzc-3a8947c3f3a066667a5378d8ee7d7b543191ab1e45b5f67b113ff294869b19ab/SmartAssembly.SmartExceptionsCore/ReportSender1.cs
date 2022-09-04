using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Threading;
using ExampleApp;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class Class28
	{
		private readonly Class30 class30_0;

		public bool bool_0 = true;

		internal ReportSender1 reportSender1_0;

		internal byte[] byte_0;

		internal Class33 class33_0;

		public Class28(ReportSender1 reportSender1_1, byte[] byte_1, Class33 class33_1, Class30 class30_1)
		{
			try
			{
				ReportSender1 reportSender = (reportSender1_0 = reportSender1_1);
				class30_0 = class30_1;
				Class33 @class = (class33_0 = class33_1);
				byte[] array = (byte_0 = byte_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, this, reportSender1_1, byte_1, class33_1, class30_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			Class29 @class = default(Class29);
			string text = default(string);
			try
			{
				if (UsageCounts.smethod_0(string_0, "OK", 660, 654))
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
					array = SimpleZip.Stream0.smethod_0(EntryPoint.smethod_0(294, 341), "{8188F18B-DD19-48CB-888D-E596F7B0AB27}", 76, 53);
					array2 = new byte[array.Length + byte_0.Length];
					Array.Copy(array, array2, array.Length);
					Class23.smethod_0(byte_0, 0, array2, array.Length, byte_0.Length, 741, 723);
					@class = new Class29(reportSender1_0);
					class33_0.method_2(array2, class30_0.method_2(), class30_0.method_1(), class30_0.method_0(), @class.method_0);
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

		[SecuritySafeCritical]
		static Class28()
		{
			Class32.smethod_1();
		}
	}

	private sealed class Class29
	{
		public bool bool_0;

		internal ReportSender1 reportSender1_0;

		public Class29(ReportSender1 reportSender1_1)
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
				if (UsageCounts.smethod_0(string_0, "ERR", 807, 828))
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

		[SecuritySafeCritical]
		static Class29()
		{
			Class32.smethod_1();
		}
	}

	internal sealed class Class30
	{
		public static Class30 class30_0;

		internal string string_0;

		internal string string_1;

		internal string string_2;

		public Class30(string string_3, string string_4, string string_5)
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

		[SecuritySafeCritical]
		static Class30()
		{
			Class32.smethod_1();
			try
			{
				class30_0 = new Class30(null, null, null);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1494)]
	private struct Struct16
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
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)Class34.smethod_0(sendingReportFeedbackEventHandler2, value, 843, 772);
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

	internal bool method_0(byte[] byte_1, Class30 class30_0)
	{
		byte[] o = default(byte[]);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		Class33 @class = default(Class33);
		Class28 class2 = default(Class28);
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
			array = Class27.smethod_0(o, "<RSAKeyValue><Modulus>6O6DbDLV9y/u81tMRzmLH3AoTfaBNQZ53eJJFY28qxTx6gBzaAji7fJFmcjE0ZcghwRVa/E+nJ0FlcHFiKY/Faz1NuFYuP7mL+zvuZgcaaxApHA8oQFHjysHhC8LuCUoyYPB1vOUOimrzWXpQ6Q9S2nWpMNYz7McRrTBacsYnOc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array == null)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Class27.string_0);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
			@class = new Class33("!cf86c77b-5629-fe03-a401-6797596d03b4");
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			class2 = new Class28(this, array, @class, class30_0);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, o, array, @class, class2, flag, this, byte_1, class30_0);
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

	[SecuritySafeCritical]
	static ReportSender1()
	{
		Class32.smethod_1();
		char_1 = new char[747];
		char[] array = new char[8];
		array[5] = 'ᕾ';
		array[1] = '\u12c7';
		array[4] = '⌙';
		array[3] = 'ܣ';
		array[2] = '㯌';
		array[0] = '⦅';
		array[6] = 'ጧ';
		array[7] = 'ȡ';
		string_0 = new string[40];
		char_0 = array;
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 23:
				stream_0.Flush();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(CryptoStream cryptoStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				cryptoStream_0.FlushFinalBlock();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_2(ref ushort ushort_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				return ushort_0.ToString(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Module smethod_3(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 67:
				return assembly_0.ManifestModule;
			}
		}
	}
}
