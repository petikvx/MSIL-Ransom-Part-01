using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.Zip;

public sealed class DESCryptoIndirector : IDisposable
{
	internal Type type_0;

	internal object object_0;

	public DESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		Type o = default(Type);
		object o2 = default(object);
		try
		{
			try
			{
				assembly = DoNotPruneTypeAttribute.smethod_3("mscorlib", 612, 532);
				o = (type_0 = Form1.smethod_0(assembly, "System.Security.Cryptography.DESCryptoServiceProvider", 776, 808));
				o2 = (object_0 = SecurityExceptionEventArgs.smethod_1(type_0, 40, 6));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, assembly, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, assembly, o, o2, this);
			throw;
		}
	}

	public ICryptoTransform GetDESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
	{
		int num = default(int);
		object[] array = default(object[]);
		MethodInfo methodInfo = default(MethodInfo);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		int num2 = default(int);
		try
		{
			try
			{
				num = 2;
				MethodInfo methodInfo_ = Class3.smethod_3(SendingReportFeedbackEventArgs.smethod_0(type_0, "Key", 597, 614), 376, 295);
				object obj = object_0;
				array = new object[1] { key };
				UsageCounts.smethod_2(methodInfo_, obj, array, 520, 571);
				num = 6;
				MethodInfo methodInfo_2 = Class3.smethod_3(SendingReportFeedbackEventArgs.smethod_0(type_0, "IV", 156, 175), 115, 44);
				object obj2 = object_0;
				array = new object[1] { iv };
				UsageCounts.smethod_2(methodInfo_2, obj2, array, 605, 622);
				num = 1;
				methodInfo = ReportSender1.smethod_0(type_0, decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0], 185, 251);
				cryptoTransform = (ICryptoTransform)methodInfo.Invoke(object_0, new object[0]);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, methodInfo, array, this, key, iv, decrypt);
				throw;
			}
			num2 = 3;
			return cryptoTransform;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException9(exception2, methodInfo, array, cryptoTransform, num, num2, this, key, iv, decrypt);
			throw;
		}
	}

	public void Clear()
	{
		try
		{
			try
			{
				UsageCounts.smethod_2(Class28.smethod_2(type_0, "Clear", 860, 847), object_0, new object[0], 154, 169);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			try
			{
				Clear();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, this);
			throw;
		}
	}

	static DESCryptoIndirector()
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

	internal static string smethod_0(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 97:
					return assembly_0.Location;
				case 98:
					return assembly_0.CodeBase;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
			throw;
		}
	}

	internal static MethodBase smethod_1(StackFrame stackFrame_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 21:
					return stackFrame_0.GetMethod();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, stackFrame_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					control_0.add_Click(eventHandler_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, eventHandler_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(Thread thread_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 30:
					thread_0.Abort();
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, thread_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(EventHandler eventHandler_0, object object_1, EventArgs eventArgs_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 8:
					eventHandler_0(object_1, eventArgs_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException7(exception, num, num2, eventHandler_0, object_1, eventArgs_0, int_0, int_1);
			throw;
		}
	}
}
